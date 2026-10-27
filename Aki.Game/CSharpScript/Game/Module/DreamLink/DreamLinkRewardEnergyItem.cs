using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005ABC RID: 23228
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DreamLinkRewardEnergyItem : GridProxyAbstract<DreamLinkRewardData>
	{
		// Token: 0x0603AD54 RID: 240980 RVA: 0x00E04EF8 File Offset: 0x00E030F8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickGetButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603AD55 RID: 240981 RVA: 0x00E05064 File Offset: 0x00E03264
		protected override void OnStart()
		{
			this.RewardScrollView = new GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData>(base.GetScrollViewWithScrollbar(6), new Func<ActivitySmallItemGrid>(this.InitGridItem), null, false, null);
			base.GetButton(0).RootUIComp.Get().SetUIActive(false);
			base.GetItem(4).SetUIActive(false);
		}

		// Token: 0x0603AD56 RID: 240982 RVA: 0x00E050B9 File Offset: 0x00E032B9
		private ActivitySmallItemGrid InitGridItem()
		{
			return new ActivitySmallItemGrid();
		}

		// Token: 0x0603AD57 RID: 240983 RVA: 0x00E050C0 File Offset: 0x00E032C0
		public override void Refresh(DreamLinkRewardData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			RogueWhiteCatReward? energyRewardConfig = DreamLinkConfig.Instance.GetEnergyRewardConfig(data.Id);
			if (energyRewardConfig == null)
			{
				return;
			}
			bool uiactive = data.Status == EActivityTaskState.Active;
			bool flag = data.Status == EActivityTaskState.FinishedAndClaimed;
			bool uiactive2 = data.Status == EActivityTaskState.FinishedAndUnclaimed;
			this.RefreshReward(energyRewardConfig.Value.DropId, flag);
			base.GetText(3).SetText(energyRewardConfig.Value.NeedEnergy.ToString(), true);
			base.GetText(7).SetUIActive(uiactive);
			base.GetItem(2).SetUIActive(flag);
			base.GetButton(1).RootUIComp.Get().SetUIActive(uiactive2);
		}

		// Token: 0x0603AD58 RID: 240984 RVA: 0x00E0517F File Offset: 0x00E0337F
		public void SetBtnClickCallback(Action callback)
		{
			this.BtnClickCb = callback;
		}

		// Token: 0x0603AD59 RID: 240985 RVA: 0x00E05188 File Offset: 0x00E03388
		private void RefreshReward(int dropId, bool hasClaimed)
		{
			List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(dropId);
			List<IItemGridData> list = new List<IItemGridData>();
			foreach (TItem item in dropPackagePreviewItemList)
			{
				IItemGridData item2 = new ItemGridData
				{
					Item = item,
					HasClaimed = hasClaimed
				};
				list.Add(item2);
			}
			this.RewardScrollView.RefreshByData(list, null, false);
		}

		// Token: 0x0603AD5A RID: 240986 RVA: 0x00E05208 File Offset: 0x00E03408
		private void OnClickGetButton()
		{
			Action btnClickCb = this.BtnClickCb;
			if (btnClickCb == null)
			{
				return;
			}
			btnClickCb();
		}

		// Token: 0x0401EB36 RID: 125750
		[Nullable(2)]
		protected DreamLinkRewardData Data;

		// Token: 0x0401EB37 RID: 125751
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData> RewardScrollView;

		// Token: 0x0401EB38 RID: 125752
		[Nullable(2)]
		private Action BtnClickCb;

		// Token: 0x0200BD0F RID: 48399
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04039049 RID: 233545
			public const int Button = 0;

			// Token: 0x0403904A RID: 233546
			public const int RewardButton = 1;

			// Token: 0x0403904B RID: 233547
			public const int PanelDone = 2;

			// Token: 0x0403904C RID: 233548
			public const int Text = 3;

			// Token: 0x0403904D RID: 233549
			public const int PanelLock = 4;

			// Token: 0x0403904E RID: 233550
			public const int TextLock = 5;

			// Token: 0x0403904F RID: 233551
			public const int RewardLayout = 6;

			// Token: 0x04039050 RID: 233552
			public const int TextGoing = 7;
		}
	}
}
