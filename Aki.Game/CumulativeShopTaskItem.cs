using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001205 RID: 4613
public class CumulativeShopTaskItem : GridProxyAbstract<int>
{
	// Token: 0x06007B82 RID: 31618 RVA: 0x001A0B58 File Offset: 0x0019ED58
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickGetBtn)),
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickGotoBtn))
		};
	}

	// Token: 0x06007B83 RID: 31619 RVA: 0x001A0CB6 File Offset: 0x0019EEB6
	protected override void OnStart()
	{
		base.GetItem(8).SetUIActive(false);
		this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(6), new Func<CommonItemSmallItemGrid>(this.CreatePropItem), null, false, null);
	}

	// Token: 0x06007B84 RID: 31620 RVA: 0x001A0CE8 File Offset: 0x0019EEE8
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.TaskId = data;
		ConsumptiveTask? cumulativeShopTaskConfig = CumulativeShopConfig.Instance.GetCumulativeShopTaskConfig(this.TaskId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), cumulativeShopTaskConfig.Value.DesString, Array.Empty<object>());
		this.SkipId = cumulativeShopTaskConfig.Value.SkipId;
		CumulativeShopData cumulativeShopData = CumulativeShopController.Instance.GetCumulativeShopData();
		ConsumptiveTaskInfo consumptiveTaskInfo = cumulativeShopData.TaskDataMap[this.TaskId];
		int num = consumptiveTaskInfo.Process.Current;
		int target = consumptiveTaskInfo.Process.Target;
		base.GetText(5).SetText(num.ToString() + "/" + target.ToString(), true);
		int currencyId = cumulativeShopData.CurrencyId;
		List<TItem> data2 = new List<TItem>
		{
			new TItem(new InventoryDefine.GetItemData(currencyId, 0), cumulativeShopTaskConfig.Value.RewardScore)
		};
		GenericScrollViewNew<CommonItemSmallItemGrid, TItem> rewardScrollView = this.RewardScrollView;
		if (rewardScrollView != null)
		{
			rewardScrollView.RefreshByData(data2, null, false);
		}
		int waitReward = consumptiveTaskInfo.Reward.WaitReward;
		int rewarded = consumptiveTaskInfo.Reward.Rewarded;
		int maxReward = consumptiveTaskInfo.Reward.MaxReward;
		if (waitReward > 0)
		{
			base.GetItem(2).SetUIActive(false);
			base.GetItem(3).SetUIActive(false);
			base.GetButton(0).RootUIComp.Get().SetUIActive(false);
			base.GetButton(1).RootUIComp.Get().SetUIActive(true);
			base.GetItem(7).SetUIActive(true);
		}
		else if (maxReward > 0 && rewarded >= maxReward)
		{
			base.GetItem(2).SetUIActive(false);
			base.GetItem(3).SetUIActive(true);
			base.GetButton(0).RootUIComp.Get().SetUIActive(false);
			base.GetButton(1).RootUIComp.Get().SetUIActive(false);
			base.GetItem(7).SetUIActive(false);
		}
		else
		{
			bool flag = cumulativeShopTaskConfig.Value.SkipId > 0;
			base.GetItem(2).SetUIActive(!flag);
			base.GetItem(3).SetUIActive(false);
			base.GetButton(0).RootUIComp.Get().SetUIActive(flag);
			base.GetButton(1).RootUIComp.Get().SetUIActive(false);
			base.GetItem(7).SetUIActive(false);
		}
		if (cumulativeShopTaskConfig.Value.MaxFinishCount > 1)
		{
			base.GetItem(10).SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(11), "LeiXiao_TaskNum", new <>z__ReadOnlyArray<object>(new object[]
			{
				rewarded,
				maxReward
			}));
			return;
		}
		base.GetItem(10).SetUIActive(false);
	}

	// Token: 0x06007B85 RID: 31621 RVA: 0x001A0FBD File Offset: 0x0019F1BD
	[NullableContext(1)]
	private CommonItemSmallItemGrid CreatePropItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x06007B86 RID: 31622 RVA: 0x001A0FC4 File Offset: 0x0019F1C4
	private void OnClickGetBtn()
	{
		ConsumptiveTask? cumulativeShopTaskConfig = CumulativeShopConfig.Instance.GetCumulativeShopTaskConfig(this.TaskId);
		if (cumulativeShopTaskConfig == null)
		{
			return;
		}
		CumulativeShopController.Instance.ConsumptiveRewardRequest(cumulativeShopTaskConfig.Value.TaskTab);
	}

	// Token: 0x06007B87 RID: 31623 RVA: 0x001A1005 File Offset: 0x0019F205
	private void OnClickGotoBtn()
	{
		if (this.SkipId <= 0)
		{
			return;
		}
		SkipTaskManager.RunByConfigId(this.SkipId, null);
	}

	// Token: 0x0400388E RID: 14478
	private int TaskId;

	// Token: 0x0400388F RID: 14479
	private int SkipId;

	// Token: 0x04003890 RID: 14480
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;
}
