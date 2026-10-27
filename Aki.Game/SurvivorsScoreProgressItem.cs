using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002B20 RID: 11040
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SurvivorsScoreProgressItem : GridProxyAbstract<SurvivorsMilestoneData>
{
	// Token: 0x06016EE1 RID: 93921 RVA: 0x005D1D38 File Offset: 0x005CFF38
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06016EE2 RID: 93922 RVA: 0x005D1D94 File Offset: 0x005CFF94
	protected override void OnStart()
	{
		this.RewardItemGrid = new SmallItemGrid();
		this.RewardItemGrid.Initialize(base.GetItem(2).GetOwner());
		this.RewardItemGrid.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
		this.RewardItemGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClickedGrid));
	}

	// Token: 0x06016EE3 RID: 93923 RVA: 0x005D1E04 File Offset: 0x005D0004
	public override void Refresh(SurvivorsMilestoneData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		SurvivorsActivityData activityData = SurvivorsRogueModel.Instance.ActivityData;
		int num = (activityData != null) ? activityData.GetMilestoneItemCount() : 0;
		base.GetText(1).SetText(data.Goal.ToString(), true);
		base.GetSprite(0).SetUIActive(data.IsAchieved(num));
		List<TItem> dropPackagePreviewItemList = RewardConfig.Instance.GetDropPackagePreviewItemList(data.DropId);
		this.RewardItem = new TItem?(dropPackagePreviewItemList[0]);
		this.RefreshGrid(num);
	}

	// Token: 0x06016EE4 RID: 93924 RVA: 0x005D1E84 File Offset: 0x005D0084
	private void RefreshGrid(int currentCount)
	{
		bool lockBlackVisible = !this.Data.IsAchieved(currentCount);
		bool value = this.Data.IsReceivable(currentCount);
		bool isGot = this.Data.IsGot;
		PropSmallItemGrid parameters = new PropSmallItemGrid
		{
			Data = this.Data,
			ItemConfigId = new int?(this.RewardItem.Value.ItemData.ItemId),
			BottomText = this.RewardItem.Value.Count.ToString(),
			IsReceivableVisible = new bool?(value),
			IsReceivedVisible = new bool?(isGot),
			IsRedDotVisible = new bool?(value)
		};
		this.RewardItemGrid.Apply<PropSmallItemGrid>(parameters);
		this.RewardItemGrid.SetLockBlackVisible(lockBlackVisible);
	}

	// Token: 0x06016EE5 RID: 93925 RVA: 0x005D1F48 File Offset: 0x005D0148
	private void OnClickedGrid(MediumItemGridExtendCallback _)
	{
		SurvivorsActivityData activityData = SurvivorsRogueModel.Instance.ActivityData;
		int currentPoint = (activityData != null) ? activityData.GetMilestoneItemCount() : 0;
		if (!this.Data.IsReceivable(currentPoint))
		{
			ItemController.Instance.OpenItemTipsByItemId(this.RewardItem.Value.ItemData.ItemId, true, null);
			return;
		}
		Action onClickToGet = this.OnClickToGet;
		if (onClickToGet == null)
		{
			return;
		}
		onClickToGet();
	}

	// Token: 0x06016EE6 RID: 93926 RVA: 0x005D1FAC File Offset: 0x005D01AC
	public override object GetKey(SurvivorsMilestoneData data, int displayIndex)
	{
		return data.DropId;
	}

	// Token: 0x0400AA9D RID: 43677
	private SurvivorsMilestoneData Data;

	// Token: 0x0400AA9E RID: 43678
	[Nullable(2)]
	private SmallItemGrid RewardItemGrid;

	// Token: 0x0400AA9F RID: 43679
	private TItem? RewardItem;

	// Token: 0x0400AAA0 RID: 43680
	[Nullable(2)]
	public Action OnClickToGet;
}
