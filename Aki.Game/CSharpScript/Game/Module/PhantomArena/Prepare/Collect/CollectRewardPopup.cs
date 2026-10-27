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
	// Token: 0x020051B5 RID: 20917
	[NullableContext(1)]
	[Nullable(0)]
	public class CollectRewardPopup : UiPanelBase
	{
		// Token: 0x060358E1 RID: 219361 RVA: 0x00CAF8BC File Offset: 0x00CADABC
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

		// Token: 0x060358E2 RID: 219362 RVA: 0x00CAF94F File Offset: 0x00CADB4F
		protected override void OnBeforeCreateImplement()
		{
			this.Sequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.Sequence);
		}

		// Token: 0x060358E3 RID: 219363 RVA: 0x00CAF96C File Offset: 0x00CADB6C
		protected override void OnStart()
		{
			this.RewardPanel = new GenericLayout<RewardPanelItem, RewardTuple>(base.GetHorizontalLayout(0), new Func<RewardPanelItem>(this.CreateRewardItem), null, false, true);
			this.SetActive(false);
			foreach (Action action in this.OperationMap.Values)
			{
				action();
			}
		}

		// Token: 0x060358E4 RID: 219364 RVA: 0x00CAF9EC File Offset: 0x00CADBEC
		protected override UniTask OnShowAsyncImplementImplement()
		{
			CollectRewardPopup.<OnShowAsyncImplementImplement>d__7 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<CollectRewardPopup.<OnShowAsyncImplementImplement>d__7>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x060358E5 RID: 219365 RVA: 0x00CAFA30 File Offset: 0x00CADC30
		protected override UniTask OnHideAsyncImplementImplement()
		{
			CollectRewardPopup.<OnHideAsyncImplementImplement>d__8 <OnHideAsyncImplementImplement>d__;
			<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplementImplement>d__.<>4__this = this;
			<OnHideAsyncImplementImplement>d__.<>1__state = -1;
			<OnHideAsyncImplementImplement>d__.<>t__builder.Start<CollectRewardPopup.<OnHideAsyncImplementImplement>d__8>(ref <OnHideAsyncImplementImplement>d__);
			return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x060358E6 RID: 219366 RVA: 0x00CAFA73 File Offset: 0x00CADC73
		protected override void OnBeforeDestroy()
		{
			this.RewardPanel.ClearChildren();
			this.RewardPanel = null;
			this.PopUpData = null;
			this.OperationMap.Clear();
		}

		// Token: 0x060358E7 RID: 219367 RVA: 0x00CAFA9C File Offset: 0x00CADC9C
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

		// Token: 0x060358E8 RID: 219368 RVA: 0x00CAFADD File Offset: 0x00CADCDD
		private RewardPanelItem CreateRewardItem()
		{
			return new RewardPanelItem();
		}

		// Token: 0x060358E9 RID: 219369 RVA: 0x00CAFAE4 File Offset: 0x00CADCE4
		private void OnMaskBtnClick()
		{
			this.SetActive(false);
		}

		// Token: 0x0401C6E7 RID: 116455
		private GenericLayout<RewardPanelItem, RewardTuple> RewardPanel;

		// Token: 0x0401C6E8 RID: 116456
		private RewardPopupData PopUpData;

		// Token: 0x0401C6E9 RID: 116457
		private readonly Dictionary<string, Action> OperationMap = new Dictionary<string, Action>();

		// Token: 0x0401C6EA RID: 116458
		private UiBehaviorLevelSequence Sequence;

		// Token: 0x0200B33C RID: 45884
		[NullableContext(0)]
		private static class EPopupComponents
		{
			// Token: 0x04036528 RID: 222504
			public const int PanelLayout = 0;

			// Token: 0x04036529 RID: 222505
			public const int RewardItem = 1;

			// Token: 0x0403652A RID: 222506
			public const int Panel = 2;

			// Token: 0x0403652B RID: 222507
			public const int MaskBtn = 3;
		}
	}
}
