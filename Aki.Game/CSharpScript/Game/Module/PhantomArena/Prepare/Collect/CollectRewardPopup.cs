using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Collect
{
	// Token: 0x02004185 RID: 16773
	[NullableContext(1)]
	[Nullable(0)]
	public class CollectRewardPopup : UiPanelBase
	{
		// Token: 0x0602A7DC RID: 174044 RVA: 0x00BFCEF8 File Offset: 0x00BFB0F8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(3, new Action(this.OnMaskBtnClick))
			};
		}

		// Token: 0x0602A7DD RID: 174045 RVA: 0x00BFCF8B File Offset: 0x00BFB18B
		protected override void OnBeforeCreateImplement()
		{
			this.Sequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.Sequence);
		}

		// Token: 0x0602A7DE RID: 174046 RVA: 0x00BFCFA8 File Offset: 0x00BFB1A8
		protected override void OnStart()
		{
			this.RewardPanel = new GenericLayout<RewardPanelItem, RewardTuple>(base.GetHorizontalLayout(0), new Func<RewardPanelItem>(this.CreateRewardItem), null, false, true);
			this.SetActive(false);
			foreach (Action action in this.OperationMap.Values)
			{
				action();
			}
		}

		// Token: 0x0602A7DF RID: 174047 RVA: 0x00BFD028 File Offset: 0x00BFB228
		protected override UniTask OnShowAsyncImplementImplement()
		{
			CollectRewardPopup.<OnShowAsyncImplementImplement>d__7 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<CollectRewardPopup.<OnShowAsyncImplementImplement>d__7>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602A7E0 RID: 174048 RVA: 0x00BFD06C File Offset: 0x00BFB26C
		protected override UniTask OnHideAsyncImplementImplement()
		{
			CollectRewardPopup.<OnHideAsyncImplementImplement>d__8 <OnHideAsyncImplementImplement>d__;
			<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplementImplement>d__.<>4__this = this;
			<OnHideAsyncImplementImplement>d__.<>1__state = -1;
			<OnHideAsyncImplementImplement>d__.<>t__builder.Start<CollectRewardPopup.<OnHideAsyncImplementImplement>d__8>(ref <OnHideAsyncImplementImplement>d__);
			return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602A7E1 RID: 174049 RVA: 0x00BFD0AF File Offset: 0x00BFB2AF
		protected override void OnBeforeDestroy()
		{
			this.RewardPanel.ClearChildren();
			this.RewardPanel = null;
			this.PopUpData = null;
			this.OperationMap.Clear();
		}

		// Token: 0x0602A7E2 RID: 174050 RVA: 0x00BFD0D8 File Offset: 0x00BFB2D8
		public void Refresh(RewardPopupData data)
		{
			Action action = delegate()
			{
				if (this.PopUpData.RewardLists.Count == 0)
				{
					return;
				}
				FVector fvector = this.PopUpData.MountItem.GetLGUISpaceAbsolutePosition();
				if (this.PopUpData.PosBias != null)
				{
					FVector value = this.PopUpData.PosBias.Value;
					fvector = fvector + value;
				}
				base.GetItem(2).SetLGUISpaceAbsolutePosition(fvector);
				this.RewardPanel.RefreshByDataAsync(this.PopUpData.RewardLists, false, null).ContinueWith(delegate()
				{
					this.SetActive(true);
				});
			};
			this.PopUpData = data;
			if (base.InAsyncLoading())
			{
				this.OperationMap["Refresh"] = action;
				return;
			}
			action();
		}

		// Token: 0x0602A7E3 RID: 174051 RVA: 0x00BFD119 File Offset: 0x00BFB319
		private RewardPanelItem CreateRewardItem()
		{
			return new RewardPanelItem();
		}

		// Token: 0x0602A7E4 RID: 174052 RVA: 0x00BFD120 File Offset: 0x00BFB320
		private void OnMaskBtnClick()
		{
			this.SetActive(false);
		}

		// Token: 0x0401711C RID: 94492
		private GenericLayout<RewardPanelItem, RewardTuple> RewardPanel;

		// Token: 0x0401711D RID: 94493
		private RewardPopupData PopUpData;

		// Token: 0x0401711E RID: 94494
		private readonly Dictionary<string, Action> OperationMap = new Dictionary<string, Action>();

		// Token: 0x0401711F RID: 94495
		private UiBehaviorLevelSequence Sequence;

		// Token: 0x02009D74 RID: 40308
		[NullableContext(0)]
		private static class EPopupComponents
		{
			// Token: 0x04030F7B RID: 200571
			public const int PanelLayout = 0;

			// Token: 0x04030F7C RID: 200572
			public const int RewardItem = 1;

			// Token: 0x04030F7D RID: 200573
			public const int Panel = 2;

			// Token: 0x04030F7E RID: 200574
			public const int MaskBtn = 3;
		}
	}
}
