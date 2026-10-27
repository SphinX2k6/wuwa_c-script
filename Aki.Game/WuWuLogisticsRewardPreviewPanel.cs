using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200166D RID: 5741
[NullableContext(2)]
[Nullable(0)]
public class WuWuLogisticsRewardPreviewPanel : UiPanelBase
{
	// Token: 0x0600A1D6 RID: 41430 RVA: 0x0023BD70 File Offset: 0x00239F70
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUISprite))
		};
	}

	// Token: 0x0600A1D7 RID: 41431 RVA: 0x0023BE24 File Offset: 0x0023A024
	protected override void OnStart()
	{
		this.RewardScrollView = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetHorizontalLayout(0), new Func<CommonItemSmallItemGrid>(this.InitGridItem), null, false, true);
		this.ConfirmQuick = new ButtonItem(base.GetButton(4).RootUIComp);
		this.ConfirmQuick.SetFunction(new Action<int>(this.OnClickConfirm));
	}

	// Token: 0x0600A1D8 RID: 41432 RVA: 0x0023BE85 File Offset: 0x0023A085
	public void SetPackConfigId(int packConfigId, WuWuLogisticsActivityData activityData)
	{
		this.PackConfigId = packConfigId;
		this.ActivityData = activityData;
		this.RefreshContent();
		this.RefreshConfirmButtonRedPoint();
	}

	// Token: 0x0600A1D9 RID: 41433 RVA: 0x0023BEA4 File Offset: 0x0023A0A4
	private void RefreshContent()
	{
		if (this.PackConfigId == 0)
		{
			return;
		}
		WuWuTaskPackage? taskPackageById = WuWuLogisticsConfig.Instance.GetTaskPackageById(this.PackConfigId);
		if (taskPackageById == null)
		{
			return;
		}
		int activityId = WuWuLogisticsActivityController.Instance.ActivityId;
		if (!(ActivityModel.Instance.GetActivityById(activityId) is WuWuLogisticsActivityData))
		{
			return;
		}
		List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(taskPackageById.Value.DropId);
		GenericLayout<CommonItemSmallItemGrid, TItem> rewardScrollView = this.RewardScrollView;
		if (rewardScrollView != null)
		{
			rewardScrollView.RefreshByData(dropPackagePreviewItemList, null, false);
		}
		this.RefreshState();
	}

	// Token: 0x0600A1DA RID: 41434 RVA: 0x0023BF28 File Offset: 0x0023A128
	private void RefreshState()
	{
		if (this.ActivityData == null)
		{
			return;
		}
		bool flag = this.ActivityData.TargetPackIsAllCompleted(this.PackConfigId);
		WuWuTaskPackData taskPackById = this.ActivityData.GetTaskPackById(this.PackConfigId);
		if (taskPackById == null)
		{
			return;
		}
		bool hadReward = taskPackById.HadReward;
		UUIItem item = base.GetItem(5);
		if (item != null)
		{
			item.SetUIActive(hadReward);
		}
		UUISprite sprite = base.GetSprite(6);
		if (sprite != null)
		{
			sprite.SetUIActive(flag || hadReward);
		}
		UUIItem item2 = base.GetItem(3);
		if (item2 != null)
		{
			item2.SetUIActive(flag && !hadReward);
		}
		UUIItem item3 = base.GetItem(2);
		if (item3 == null)
		{
			return;
		}
		item3.SetUIActive(!flag);
	}

	// Token: 0x0600A1DB RID: 41435 RVA: 0x0023BFC6 File Offset: 0x0023A1C6
	[NullableContext(1)]
	private CommonItemSmallItemGrid InitGridItem()
	{
		return new CommonItemSmallItemGrid
		{
			ShowReceivedCallBack = delegate(TItem _)
			{
				WuWuTaskPackData taskPackById = this.ActivityData.GetTaskPackById(this.PackConfigId);
				return taskPackById != null && taskPackById.HadReward;
			}
		};
	}

	// Token: 0x0600A1DC RID: 41436 RVA: 0x0023BFDF File Offset: 0x0023A1DF
	private void OnClickConfirm(int data)
	{
		if (this.ActivityData == null)
		{
			return;
		}
		if (this.ActivityData.TargetPackHasReceiveReward(this.PackConfigId))
		{
			WuWuLogisticsActivityController.Instance.RequestTaskPackageReward(this.PackConfigId);
		}
	}

	// Token: 0x0600A1DD RID: 41437 RVA: 0x0023C010 File Offset: 0x0023A210
	public void RefreshConfirmButtonRedPoint()
	{
		WuWuLogisticsActivityData activityData = this.ActivityData;
		bool redDotVisible = activityData != null && activityData.TargetPackHasReceiveReward(this.PackConfigId);
		ButtonItem confirmQuick = this.ConfirmQuick;
		if (confirmQuick == null)
		{
			return;
		}
		confirmQuick.SetRedDotVisible(redDotVisible);
	}

	// Token: 0x040049BA RID: 18874
	private int PackConfigId;

	// Token: 0x040049BB RID: 18875
	private WuWuLogisticsActivityData ActivityData;

	// Token: 0x040049BC RID: 18876
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> RewardScrollView;

	// Token: 0x040049BD RID: 18877
	protected ButtonItem ConfirmQuick;
}
