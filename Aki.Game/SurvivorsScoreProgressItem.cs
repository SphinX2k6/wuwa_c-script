using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200209C RID: 8348
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SurvivorsScoreProgressItem : GridProxyAbstract<SurvivorsMilestoneData>
{
	// Token: 0x06014912 RID: 84242 RVA: 0x005FE8B4 File Offset: 0x005FCAB4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06014913 RID: 84243 RVA: 0x005FE910 File Offset: 0x005FCB10
	protected override void OnStart()
	{
		this.RewardItemGrid = new SmallItemGrid();
		this.RewardItemGrid.Initialize(base.GetItem(2).GetOwner());
		this.RewardItemGrid.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
		this.RewardItemGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClickedGrid));
	}

	// Token: 0x06014914 RID: 84244 RVA: 0x005FE980 File Offset: 0x005FCB80
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

	// Token: 0x06014915 RID: 84245 RVA: 0x005FEA00 File Offset: 0x005FCC00
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

	// Token: 0x06014916 RID: 84246 RVA: 0x005FEAC4 File Offset: 0x005FCCC4
	private void OnClickedGrid(MediumItemGridExtendCallback _)
	{
		SurvivorsActivityData activityData = SurvivorsRogueModel.Instance.ActivityData;
		int currentPoint = (activityData != null) ? activityData.GetMilestoneItemCount() : 0;
		if (!this.Data.IsReceivable(currentPoint))
		{
			ItemController.Instance.OpenItemTipsByItemId(this.RewardItem.Value.ItemData.ItemId, true, null, false);
			return;
		}
		Action onClickToGet = this.OnClickToGet;
		if (onClickToGet == null)
		{
			return;
		}
		onClickToGet();
	}

	// Token: 0x06014917 RID: 84247 RVA: 0x005FEB29 File Offset: 0x005FCD29
	public override object GetKey(SurvivorsMilestoneData data, int displayIndex)
	{
		return data.DropId;
	}

	// Token: 0x0400AEA3 RID: 44707
	private SurvivorsMilestoneData Data;

	// Token: 0x0400AEA4 RID: 44708
	[Nullable(2)]
	private SmallItemGrid RewardItemGrid;

	// Token: 0x0400AEA5 RID: 44709
	private TItem? RewardItem;

	// Token: 0x0400AEA6 RID: 44710
	[Nullable(2)]
	public Action OnClickToGet;
}
