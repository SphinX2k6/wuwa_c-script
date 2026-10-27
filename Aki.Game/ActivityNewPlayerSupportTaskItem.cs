using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Functional;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020013BD RID: 5053
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ActivityNewPlayerSupportTaskItem : GridProxyAbstract<IActivityNewPlayerSupportTaskItemData>
{
	// Token: 0x06008E86 RID: 36486 RVA: 0x001EBE18 File Offset: 0x001EA018
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUITexture)),
			new ValueTuple<int, Type>(5, typeof(UUISprite)),
			new ValueTuple<int, Type>(6, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(9, new Action(this.OnFunctionClick)),
			new ValueTuple<int, Delegate>(8, new Action(this.OnReceiveClick)),
			new ValueTuple<int, Delegate>(11, new Action(this.OnRoleClick))
		};
	}

	// Token: 0x06008E87 RID: 36487 RVA: 0x001EC01A File Offset: 0x001EA21A
	protected override void OnStart()
	{
		this.RewardLayout = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetVerticalLayout(6), new Func<CommonItemSmallItemGrid>(this.CreateLayoutItem), null, false, true);
	}

	// Token: 0x06008E88 RID: 36488 RVA: 0x001EC03D File Offset: 0x001EA23D
	public override void Refresh(IActivityNewPlayerSupportTaskItemData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.RefreshRewardView();
		this.RefreshTrialRoleView();
	}

	// Token: 0x06008E89 RID: 36489 RVA: 0x001EC054 File Offset: 0x001EA254
	private void RefreshRewardView()
	{
		ActivityNewPlayerSupportTaskData taskData = this.Data.TaskData;
		bool isReceived = taskData.IsTaskReceived();
		bool flag = taskData.CanReceiveReward();
		base.GetButton(9).RootUIComp.Get().SetUIActive(taskData.IsTaskRunning());
		base.GetButton(8).RootUIComp.Get().SetUIActive(taskData.CanReceiveReward());
		base.GetItem(10).SetUIActive(isReceived);
		base.GetItem(2).SetUIActive(flag);
		base.GetItem(1).SetUIActive(!flag);
		List<TItem> rewardList = taskData.GetRewardList();
		GenericLayout<CommonItemSmallItemGrid, TItem> rewardLayout = this.RewardLayout;
		if (rewardLayout == null)
		{
			return;
		}
		rewardLayout.RefreshByData(rewardList, delegate
		{
			foreach (CommonItemSmallItemGrid commonItemSmallItemGrid in this.RewardLayout.GetLayoutItemList())
			{
				commonItemSmallItemGrid.SetReceivedVisible(isReceived);
			}
		}, false);
	}

	// Token: 0x06008E8A RID: 36490 RVA: 0x001EC124 File Offset: 0x001EA324
	private void RefreshTrialRoleView()
	{
		ActivityNewPlayerSupportTaskData taskData = this.Data.TaskData;
		bool flag = taskData.IsTaskReceived();
		bool flag2 = taskData.CanReceiveReward();
		int taskTarget = taskData.GetTaskTarget();
		UUIText text = base.GetText(3);
		text.SetText(taskTarget.ToString(), true);
		FColor color = flag2 ? ActivityNewPlayerSupportDefine.FinishTaskTextColor : ActivityNewPlayerSupportDefine.NormalTaskTextColor;
		text.SetColor(color);
		bool showDecoration = this.Data.ShowDecoration;
		base.GetItem(12).SetUIActive(!flag);
		base.GetItem(13).SetUIActive(flag);
		base.GetItem(14).SetUIActive(!flag && showDecoration);
		base.GetItem(15).SetUIActive(flag && showDecoration);
		base.GetItem(16).SetUIActive(!flag2);
		base.GetItem(17).SetUIActive(flag2);
		int trialRoleGroupId = taskData.TaskConfig.TrialRoleGroupId;
		IReadOnlyList<TrialRoleInfo> trialRoleConfigsByGroupId = TrialRoleConfig.Instance.GetTrialRoleConfigsByGroupId(trialRoleGroupId);
		if (trialRoleConfigsByGroupId != null)
		{
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(trialRoleConfigsByGroupId[0].ParentId);
			if (roleConfig != null)
			{
				base.SetRoleIcon(roleConfig.Value.RoleHeadIconCircle, base.GetTexture(4), roleConfig.Value.Id, null, null);
				string resourcePath = UiResourceConfig.Instance.GetResourcePath(RoleUtils.GetTrialRoleLabelIconByType(ETrialRoleType.NewbieSupportTrial));
				this.SetSpriteByPath(resourcePath, base.GetSprite(5), false, null, null);
			}
		}
	}

	// Token: 0x06008E8B RID: 36491 RVA: 0x001EC29C File Offset: 0x001EA49C
	private void OnFunctionClick()
	{
		if (FunctionModel.Instance.IsOpen(EFunctionType.AdventureGuide))
		{
			FunctionController.Instance.OpenFunctionRelateView(EFunctionType.AdventureGuide);
			return;
		}
		ActivityNewPlayerSupportData activityData = ActivityNewPlayerSupportController.Instance.ActivityData;
		int? num = (activityData != null) ? activityData.GetFirstUnFinishMainQuestId() : null;
		UiManager.Instance.OpenView(EUiViewName.QuestView, num.Value, null);
	}

	// Token: 0x06008E8C RID: 36492 RVA: 0x001EC308 File Offset: 0x001EA508
	private void OnReceiveClick()
	{
		ActivityNewPlayerSupportTaskData taskData = this.Data.TaskData;
		if (!taskData.CanReceiveReward())
		{
			return;
		}
		ActivityNewPlayerSupportController instance = ActivityNewPlayerSupportController.Instance;
		if (instance == null)
		{
			return;
		}
		instance.RequestRewardTask(taskData.Id, true);
	}

	// Token: 0x06008E8D RID: 36493 RVA: 0x001EC340 File Offset: 0x001EA540
	private void OnRoleClick()
	{
		int trialRoleGroupId = this.Data.TaskData.TaskConfig.TrialRoleGroupId;
		ActivityNewPlayerSupportController.Instance.OpenTrialRoleView(new int?(trialRoleGroupId));
	}

	// Token: 0x06008E8E RID: 36494 RVA: 0x001EC376 File Offset: 0x001EA576
	private CommonItemSmallItemGrid CreateLayoutItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x06008E8F RID: 36495 RVA: 0x001EC380 File Offset: 0x001EA580
	[NullableContext(2)]
	public UUIItem GetReceiveBtn()
	{
		UUIButtonComponent button = base.GetButton(8);
		if (button == null)
		{
			return null;
		}
		return button.RootUIComp.Get();
	}

	// Token: 0x04003F15 RID: 16149
	[Nullable(2)]
	private IActivityNewPlayerSupportTaskItemData Data;

	// Token: 0x04003F16 RID: 16150
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

	// Token: 0x02007A31 RID: 31281
	[NullableContext(0)]
	private static class EComponentType
	{
		// Token: 0x04028387 RID: 164743
		public const int TaskItem = 0;

		// Token: 0x04028388 RID: 164744
		public const int LockItem = 1;

		// Token: 0x04028389 RID: 164745
		public const int ReceiveItem = 2;

		// Token: 0x0402838A RID: 164746
		public const int TaskTxt = 3;

		// Token: 0x0402838B RID: 164747
		public const int TrialRoleTex = 4;

		// Token: 0x0402838C RID: 164748
		public const int TrialRoleMarkImg = 5;

		// Token: 0x0402838D RID: 164749
		public const int RewardLayout = 6;

		// Token: 0x0402838E RID: 164750
		public const int RewardItem = 7;

		// Token: 0x0402838F RID: 164751
		public const int ReceiveBtn = 8;

		// Token: 0x04028390 RID: 164752
		public const int FunctionBtn = 9;

		// Token: 0x04028391 RID: 164753
		public const int ReceivedItem = 10;

		// Token: 0x04028392 RID: 164754
		public const int TrialRoleBtn = 11;

		// Token: 0x04028393 RID: 164755
		public const int DotItem1 = 12;

		// Token: 0x04028394 RID: 164756
		public const int DotItem2 = 13;

		// Token: 0x04028395 RID: 164757
		public const int LineItem1 = 14;

		// Token: 0x04028396 RID: 164758
		public const int LineItem2 = 15;

		// Token: 0x04028397 RID: 164759
		public const int TrialRoleNormalItem = 16;

		// Token: 0x04028398 RID: 164760
		public const int TrialRoleReceiveItem = 17;
	}
}
