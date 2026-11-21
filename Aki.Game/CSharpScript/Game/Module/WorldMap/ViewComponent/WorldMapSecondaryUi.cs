using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.View.BaseMap;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.ViewComponent
{
	// Token: 0x020036E7 RID: 14055
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapSecondaryUi : UiPanelBase
	{
		// Token: 0x17004B2C RID: 19244
		// (get) Token: 0x0602490F RID: 149775 RVA: 0x00A548D1 File Offset: 0x00A52AD1
		public bool IsUiOpen
		{
			get
			{
				return this.SecondaryUiState == ESecondaryPanelState.Open;
			}
		}

		// Token: 0x17004B2D RID: 19245
		// (get) Token: 0x06024910 RID: 149776 RVA: 0x00A548DC File Offset: 0x00A52ADC
		public bool IsUiCloseComplete
		{
			get
			{
				return this.SecondaryUiState == ESecondaryPanelState.CloseComplete;
			}
		}

		// Token: 0x17004B2E RID: 19246
		// (get) Token: 0x06024911 RID: 149777 RVA: 0x00A548E7 File Offset: 0x00A52AE7
		public bool IsUiClose
		{
			get
			{
				return this.SecondaryUiState == ESecondaryPanelState.Close;
			}
		}

		// Token: 0x17004B2F RID: 19247
		// (get) Token: 0x06024912 RID: 149778 RVA: 0x00A548F4 File Offset: 0x00A52AF4
		private LevelSequencePlayer LevelSequencePlayer
		{
			get
			{
				if (this.InterLevelSequencePlayer == null)
				{
					PopupTypeRightItem uiBgItem = this.UiBgItem;
					UUIItem uiItem = ((uiBgItem != null) ? uiBgItem.GetRootItem() : null) ?? base.GetRootItem();
					this.InterLevelSequencePlayer = new LevelSequencePlayer(uiItem);
					this.InterLevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.FinishSequenceEvent), false);
				}
				return this.InterLevelSequencePlayer;
			}
		}

		// Token: 0x06024913 RID: 149779 RVA: 0x00A54950 File Offset: 0x00A52B50
		protected override void OnBeforeCreate()
		{
			if (!this.GetNeedBgItem())
			{
				return;
			}
			this.UiBgItem = this.GetPopupRightItem();
		}

		// Token: 0x06024914 RID: 149780 RVA: 0x00A54967 File Offset: 0x00A52B67
		protected virtual PopupTypeRightItem GetPopupRightItem()
		{
			return new PopupTypeRightItem();
		}

		// Token: 0x06024915 RID: 149781 RVA: 0x00A5496E File Offset: 0x00A52B6E
		protected virtual void OnBeforeDestroyImplementImplement()
		{
		}

		// Token: 0x06024916 RID: 149782 RVA: 0x00A54970 File Offset: 0x00A52B70
		protected override void OnBeforeDestroyImplement()
		{
			this.OnBeforeDestroyImplementImplement();
			LevelSequencePlayer interLevelSequencePlayer = this.InterLevelSequencePlayer;
			if (interLevelSequencePlayer != null)
			{
				interLevelSequencePlayer.Clear();
			}
			this.InterLevelSequencePlayer = null;
		}

		// Token: 0x06024917 RID: 149783 RVA: 0x00A54990 File Offset: 0x00A52B90
		protected override UniTask OnBeforeStartAsync()
		{
			WorldMapSecondaryUi.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<WorldMapSecondaryUi.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024918 RID: 149784 RVA: 0x00A549D3 File Offset: 0x00A52BD3
		private void FinishSequenceEvent(string sequenceName)
		{
			if (sequenceName == "Close")
			{
				this.HandleClose(false);
			}
		}

		// Token: 0x06024919 RID: 149785 RVA: 0x00A549E9 File Offset: 0x00A52BE9
		private void HandleClose(bool bIsForce = false)
		{
			this.SetActive(false);
			this.OnClose(bIsForce);
		}

		// Token: 0x0602491A RID: 149786 RVA: 0x00A549F9 File Offset: 0x00A52BF9
		private void OnClose(bool bIsForce = false)
		{
			this.OnCloseWorldMapSecondaryUi();
			this.SecondaryUiState = ESecondaryPanelState.CloseComplete;
			EventSystem.Instance.Emit<bool>(EEventName.WorldMapSecondaryUiClosed, bIsForce);
			Action currentCloseCall = this.CurrentCloseCall;
			if (currentCloseCall == null)
			{
				return;
			}
			currentCloseCall();
		}

		// Token: 0x0602491B RID: 149787 RVA: 0x00A54A29 File Offset: 0x00A52C29
		protected override void OnBeforeHide()
		{
			if (this.LevelSequencePlayer.IsPlayingSequence("Close"))
			{
				this.LevelSequencePlayer.StopCurrentSequence(false, false);
				this.OnClose(false);
			}
		}

		// Token: 0x0602491C RID: 149788 RVA: 0x00A54A51 File Offset: 0x00A52C51
		public void MarkForOpen()
		{
			this.SecondaryUiState = ESecondaryPanelState.Open;
		}

		// Token: 0x0602491D RID: 149789 RVA: 0x00A54A5C File Offset: 0x00A52C5C
		public UniTask ShowPanel(BaseMap map, params object[] parameters)
		{
			WorldMapSecondaryUi.<ShowPanel>d__23 <ShowPanel>d__;
			<ShowPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowPanel>d__.<>4__this = this;
			<ShowPanel>d__.map = map;
			<ShowPanel>d__.parameters = parameters;
			<ShowPanel>d__.<>1__state = -1;
			<ShowPanel>d__.<>t__builder.Start<WorldMapSecondaryUi.<ShowPanel>d__23>(ref <ShowPanel>d__);
			return <ShowPanel>d__.<>t__builder.Task;
		}

		// Token: 0x0602491E RID: 149790 RVA: 0x00A54AAF File Offset: 0x00A52CAF
		protected override void OnAfterShow()
		{
			this.OnAfterShowWorldMapSecondaryUi();
		}

		// Token: 0x0602491F RID: 149791 RVA: 0x00A54AB7 File Offset: 0x00A52CB7
		public void UpdateMap(BaseMap map)
		{
			this.Map = map;
		}

		// Token: 0x06024920 RID: 149792 RVA: 0x00A54AC0 File Offset: 0x00A52CC0
		[NullableContext(2)]
		public void CloseWithCallBack(Action callback, bool playSequence = true)
		{
			this.CurrentCloseCall = callback;
			this.SecondaryUiState = ESecondaryPanelState.Close;
			if (playSequence)
			{
				this.LevelSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
				return;
			}
			this.HandleClose(false);
		}

		// Token: 0x06024921 RID: 149793 RVA: 0x00A54B01 File Offset: 0x00A52D01
		public void Close()
		{
			this.CloseWithCallBack(null, true);
		}

		// Token: 0x06024922 RID: 149794 RVA: 0x00A54B0B File Offset: 0x00A52D0B
		protected virtual UniTask OnBeforeShowWorldMapSecondaryUiAsync(params object[] parameters)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06024923 RID: 149795 RVA: 0x00A54B12 File Offset: 0x00A52D12
		protected virtual void SetupWorldMapSecondaryUiLayout()
		{
		}

		// Token: 0x06024924 RID: 149796 RVA: 0x00A54B14 File Offset: 0x00A52D14
		protected virtual void OnShowWorldMapSecondaryUi(params object[] parameters)
		{
		}

		// Token: 0x06024925 RID: 149797 RVA: 0x00A54B16 File Offset: 0x00A52D16
		protected virtual void OnCloseWorldMapSecondaryUi()
		{
		}

		// Token: 0x06024926 RID: 149798 RVA: 0x00A54B18 File Offset: 0x00A52D18
		public virtual string GetResourceId()
		{
			return "";
		}

		// Token: 0x06024927 RID: 149799 RVA: 0x00A54B1F File Offset: 0x00A52D1F
		[NullableContext(2)]
		public virtual UUIItem GetGuideFocusUiItem()
		{
			return null;
		}

		// Token: 0x06024928 RID: 149800 RVA: 0x00A54B22 File Offset: 0x00A52D22
		protected virtual bool GetNeedBgItem()
		{
			return true;
		}

		// Token: 0x06024929 RID: 149801 RVA: 0x00A54B25 File Offset: 0x00A52D25
		protected void CheckAndShowCrossMapTips(MarkItem markItem)
		{
			if (!markItem.IsTracked)
			{
				MapHelper.CheckAndShowCrossMapTips(markItem.MarkId, markItem.MarkType, markItem.TrackAreaId, markItem.WorldPosition);
			}
		}

		// Token: 0x0602492A RID: 149802 RVA: 0x00A54B4C File Offset: 0x00A52D4C
		protected virtual void OnAfterShowWorldMapSecondaryUi()
		{
		}

		// Token: 0x0401456B RID: 83307
		[Nullable(2)]
		protected PopupTypeRightItem UiBgItem;

		// Token: 0x0401456C RID: 83308
		[Nullable(2)]
		private LevelSequencePlayer InterLevelSequencePlayer;

		// Token: 0x0401456D RID: 83309
		private ESecondaryPanelState SecondaryUiState;

		// Token: 0x0401456E RID: 83310
		[Nullable(2)]
		protected BaseMap Map;

		// Token: 0x0401456F RID: 83311
		[Nullable(2)]
		private Action CurrentCloseCall;
	}
}
