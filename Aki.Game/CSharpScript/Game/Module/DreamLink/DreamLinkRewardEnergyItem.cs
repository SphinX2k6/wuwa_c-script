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
	// Token: 0x02004A98 RID: 19096
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DreamLinkRewardEnergyItem : GridProxyAbstract<DreamLinkRewardData>
	{
		// Token: 0x0602FCA0 RID: 195744 RVA: 0x00D554C0 File Offset: 0x00D536C0
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

		// Token: 0x0602FCA1 RID: 195745 RVA: 0x00D5562C File Offset: 0x00D5382C
		protected override void OnStart()
		{
			this.RewardScrollView = new GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData>(base.GetScrollViewWithScrollbar(6), new Func<ActivitySmallItemGrid>(this.InitGridItem), null, false, null);
			base.GetButton(0).RootUIComp.Get().SetUIActive(false);
			base.GetItem(4).SetUIActive(false);
		}

		// Token: 0x0602FCA2 RID: 195746 RVA: 0x00D55681 File Offset: 0x00D53881
		private ActivitySmallItemGrid InitGridItem()
		{
			return new ActivitySmallItemGrid();
		}

		// Token: 0x0602FCA3 RID: 195747 RVA: 0x00D55688 File Offset: 0x00D53888
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

		// Token: 0x0602FCA4 RID: 195748 RVA: 0x00D55747 File Offset: 0x00D53947
		public void SetBtnClickCallback(Action callback)
		{
			this.BtnClickCb = callback;
		}

		// Token: 0x0602FCA5 RID: 195749 RVA: 0x00D55750 File Offset: 0x00D53950
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

		// Token: 0x0602FCA6 RID: 195750 RVA: 0x00D557D0 File Offset: 0x00D539D0
		private void OnClickGetButton()
		{
			Action btnClickCb = this.BtnClickCb;
			if (btnClickCb == null)
			{
				return;
			}
			btnClickCb();
		}

		// Token: 0x040195DD RID: 103901
		[Nullable(2)]
		protected DreamLinkRewardData Data;

		// Token: 0x040195DE RID: 103902
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData> RewardScrollView;

		// Token: 0x040195DF RID: 103903
		[Nullable(2)]
		private Action BtnClickCb;

		// Token: 0x0200A717 RID: 42775
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04033A13 RID: 211475
			public const int Button = 0;

			// Token: 0x04033A14 RID: 211476
			public const int RewardButton = 1;

			// Token: 0x04033A15 RID: 211477
			public const int PanelDone = 2;

			// Token: 0x04033A16 RID: 211478
			public const int Text = 3;

			// Token: 0x04033A17 RID: 211479
			public const int PanelLock = 4;

			// Token: 0x04033A18 RID: 211480
			public const int TextLock = 5;

			// Token: 0x04033A19 RID: 211481
			public const int RewardLayout = 6;

			// Token: 0x04033A1A RID: 211482
			public const int TextGoing = 7;
		}
	}
}
