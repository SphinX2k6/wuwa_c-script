using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000B25 RID: 2853
[NullableContext(2)]
[Nullable(0)]
public class WuWuLogisticsRewardPreviewPanel : UiPanelBase
{
	// Token: 0x060075B4 RID: 30132 RVA: 0x00245C0C File Offset: 0x00243E0C
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

	// Token: 0x060075B5 RID: 30133 RVA: 0x00245CC0 File Offset: 0x00243EC0
	protected override void OnStart()
	{
		this.RewardScrollView = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetHorizontalLayout(0), new Func<CommonItemSmallItemGrid>(this.InitGridItem), null, false, true);
		this.ConfirmQuick = new ButtonItem(base.GetButton(4).RootUIComp);
		this.ConfirmQuick.SetFunction(new Action<int>(this.OnClickConfirm));
	}

	// Token: 0x060075B6 RID: 30134 RVA: 0x00245D21 File Offset: 0x00243F21
	public void SetPackConfigId(int packConfigId, WuWuLogisticsActivityData activityData)
	{
		this.PackConfigId = packConfigId;
		this.ActivityData = activityData;
		this.RefreshContent();
		this.RefreshConfirmButtonRedPoint();
	}

	// Token: 0x060075B7 RID: 30135 RVA: 0x00245D40 File Offset: 0x00243F40
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

	// Token: 0x060075B8 RID: 30136 RVA: 0x00245DC4 File Offset: 0x00243FC4
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

	// Token: 0x060075B9 RID: 30137 RVA: 0x00245E62 File Offset: 0x00244062
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

	// Token: 0x060075BA RID: 30138 RVA: 0x00245E7B File Offset: 0x0024407B
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

	// Token: 0x060075BB RID: 30139 RVA: 0x00245EAC File Offset: 0x002440AC
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

	// Token: 0x04004A60 RID: 19040
	private int PackConfigId;

	// Token: 0x04004A61 RID: 19041
	private WuWuLogisticsActivityData ActivityData;

	// Token: 0x04004A62 RID: 19042
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> RewardScrollView;

	// Token: 0x04004A63 RID: 19043
	protected ButtonItem ConfirmQuick;
}
