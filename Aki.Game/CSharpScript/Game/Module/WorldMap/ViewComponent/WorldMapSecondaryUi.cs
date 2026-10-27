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
	// Token: 0x020047B6 RID: 18358
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapSecondaryUi : UiPanelBase
	{
		// Token: 0x17007870 RID: 30832
		// (get) Token: 0x06030140 RID: 196928 RVA: 0x00B2494D File Offset: 0x00B22B4D
		public bool IsUiOpen
		{
			get
			{
				return this.SecondaryUiState == ESecondaryPanelState.Open;
			}
		}

		// Token: 0x17007871 RID: 30833
		// (get) Token: 0x06030141 RID: 196929 RVA: 0x00B24958 File Offset: 0x00B22B58
		public bool IsUiCloseComplete
		{
			get
			{
				return this.SecondaryUiState == ESecondaryPanelState.CloseComplete;
			}
		}

		// Token: 0x17007872 RID: 30834
		// (get) Token: 0x06030142 RID: 196930 RVA: 0x00B24963 File Offset: 0x00B22B63
		public bool IsUiClose
		{
			get
			{
				return this.SecondaryUiState == ESecondaryPanelState.Close;
			}
		}

		// Token: 0x17007873 RID: 30835
		// (get) Token: 0x06030143 RID: 196931 RVA: 0x00B24970 File Offset: 0x00B22B70
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

		// Token: 0x06030144 RID: 196932 RVA: 0x00B249CC File Offset: 0x00B22BCC
		protected override void OnBeforeCreate()
		{
			if (!this.GetNeedBgItem())
			{
				return;
			}
			this.UiBgItem = this.GetPopupRightItem();
		}

		// Token: 0x06030145 RID: 196933 RVA: 0x00B249E3 File Offset: 0x00B22BE3
		protected virtual PopupTypeRightItem GetPopupRightItem()
		{
			return new PopupTypeRightItem();
		}

		// Token: 0x06030146 RID: 196934 RVA: 0x00B249EA File Offset: 0x00B22BEA
		protected virtual void OnBeforeDestroyImplementImplement()
		{
		}

		// Token: 0x06030147 RID: 196935 RVA: 0x00B249EC File Offset: 0x00B22BEC
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

		// Token: 0x06030148 RID: 196936 RVA: 0x00B24A0C File Offset: 0x00B22C0C
		protected override UniTask OnBeforeStartAsync()
		{
			WorldMapSecondaryUi.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<WorldMapSecondaryUi.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030149 RID: 196937 RVA: 0x00B24A4F File Offset: 0x00B22C4F
		private void FinishSequenceEvent(string sequenceName)
		{
			if (sequenceName == "Close")
			{
				this.HandleClose(false);
			}
		}

		// Token: 0x0603014A RID: 196938 RVA: 0x00B24A65 File Offset: 0x00B22C65
		private void HandleClose(bool bIsForce = false)
		{
			this.SetActive(false);
			this.OnClose(bIsForce);
		}

		// Token: 0x0603014B RID: 196939 RVA: 0x00B24A75 File Offset: 0x00B22C75
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

		// Token: 0x0603014C RID: 196940 RVA: 0x00B24AA5 File Offset: 0x00B22CA5
		protected override void OnBeforeHide()
		{
			if (this.LevelSequencePlayer.IsPlayingSequence("Close"))
			{
				this.LevelSequencePlayer.StopCurrentSequence(false, false);
				this.OnClose(false);
			}
		}

		// Token: 0x0603014D RID: 196941 RVA: 0x00B24ACD File Offset: 0x00B22CCD
		public void MarkForOpen()
		{
			this.SecondaryUiState = ESecondaryPanelState.Open;
		}

		// Token: 0x0603014E RID: 196942 RVA: 0x00B24AD8 File Offset: 0x00B22CD8
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

		// Token: 0x0603014F RID: 196943 RVA: 0x00B24B2B File Offset: 0x00B22D2B
		protected override void OnAfterShow()
		{
			this.OnAfterShowWorldMapSecondaryUi();
		}

		// Token: 0x06030150 RID: 196944 RVA: 0x00B24B33 File Offset: 0x00B22D33
		public void UpdateMap(BaseMap map)
		{
			this.Map = map;
		}

		// Token: 0x06030151 RID: 196945 RVA: 0x00B24B3C File Offset: 0x00B22D3C
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

		// Token: 0x06030152 RID: 196946 RVA: 0x00B24B7D File Offset: 0x00B22D7D
		public void Close()
		{
			this.CloseWithCallBack(null, true);
		}

		// Token: 0x06030153 RID: 196947 RVA: 0x00B24B87 File Offset: 0x00B22D87
		protected virtual UniTask OnBeforeShowWorldMapSecondaryUiAsync(params object[] parameters)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06030154 RID: 196948 RVA: 0x00B24B8E File Offset: 0x00B22D8E
		protected virtual void SetupWorldMapSecondaryUiLayout()
		{
		}

		// Token: 0x06030155 RID: 196949 RVA: 0x00B24B90 File Offset: 0x00B22D90
		protected virtual void OnShowWorldMapSecondaryUi(params object[] parameters)
		{
		}

		// Token: 0x06030156 RID: 196950 RVA: 0x00B24B92 File Offset: 0x00B22D92
		protected virtual void OnCloseWorldMapSecondaryUi()
		{
		}

		// Token: 0x06030157 RID: 196951 RVA: 0x00B24B94 File Offset: 0x00B22D94
		public virtual string GetResourceId()
		{
			return "";
		}

		// Token: 0x06030158 RID: 196952 RVA: 0x00B24B9B File Offset: 0x00B22D9B
		[NullableContext(2)]
		public virtual UUIItem GetGuideFocusUiItem()
		{
			return null;
		}

		// Token: 0x06030159 RID: 196953 RVA: 0x00B24B9E File Offset: 0x00B22D9E
		protected virtual bool GetNeedBgItem()
		{
			return true;
		}

		// Token: 0x0603015A RID: 196954 RVA: 0x00B24BA1 File Offset: 0x00B22DA1
		protected void CheckAndShowCrossMapTips(MarkItem markItem)
		{
			if (!markItem.IsTracked)
			{
				MapHelper.CheckAndShowCrossMapTips(markItem.MarkId, markItem.MarkType, markItem.TrackAreaId, markItem.WorldPosition);
			}
		}

		// Token: 0x0603015B RID: 196955 RVA: 0x00B24BC8 File Offset: 0x00B22DC8
		protected virtual void OnAfterShowWorldMapSecondaryUi()
		{
		}

		// Token: 0x04019EBB RID: 106171
		[Nullable(2)]
		protected PopupTypeRightItem UiBgItem;

		// Token: 0x04019EBC RID: 106172
		[Nullable(2)]
		private LevelSequencePlayer InterLevelSequencePlayer;

		// Token: 0x04019EBD RID: 106173
		private ESecondaryPanelState SecondaryUiState;

		// Token: 0x04019EBE RID: 106174
		[Nullable(2)]
		protected BaseMap Map;

		// Token: 0x04019EBF RID: 106175
		[Nullable(2)]
		private Action CurrentCloseCall;
	}
}
