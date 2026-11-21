using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Functional;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000871 RID: 2161
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ActivityNewPlayerSupportTaskItem : GridProxyAbstract<IActivityNewPlayerSupportTaskItemData>
{
	// Token: 0x0600621B RID: 25115 RVA: 0x001F4938 File Offset: 0x001F2B38
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

	// Token: 0x0600621C RID: 25116 RVA: 0x001F4B3A File Offset: 0x001F2D3A
	protected override void OnStart()
	{
		this.RewardLayout = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetVerticalLayout(6), new Func<CommonItemSmallItemGrid>(this.CreateLayoutItem), null, false, true);
	}

	// Token: 0x0600621D RID: 25117 RVA: 0x001F4B5D File Offset: 0x001F2D5D
	public override void Refresh(IActivityNewPlayerSupportTaskItemData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.RefreshRewardView();
		this.RefreshTrialRoleView();
	}

	// Token: 0x0600621E RID: 25118 RVA: 0x001F4B74 File Offset: 0x001F2D74
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

	// Token: 0x0600621F RID: 25119 RVA: 0x001F4C44 File Offset: 0x001F2E44
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

	// Token: 0x06006220 RID: 25120 RVA: 0x001F4DBC File Offset: 0x001F2FBC
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

	// Token: 0x06006221 RID: 25121 RVA: 0x001F4E28 File Offset: 0x001F3028
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

	// Token: 0x06006222 RID: 25122 RVA: 0x001F4E60 File Offset: 0x001F3060
	private void OnRoleClick()
	{
		int trialRoleGroupId = this.Data.TaskData.TaskConfig.TrialRoleGroupId;
		ActivityNewPlayerSupportController.Instance.OpenTrialRoleView(new int?(trialRoleGroupId));
	}

	// Token: 0x06006223 RID: 25123 RVA: 0x001F4E96 File Offset: 0x001F3096
	private CommonItemSmallItemGrid CreateLayoutItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x06006224 RID: 25124 RVA: 0x001F4EA0 File Offset: 0x001F30A0
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

	// Token: 0x04003FAD RID: 16301
	[Nullable(2)]
	private IActivityNewPlayerSupportTaskItemData Data;

	// Token: 0x04003FAE RID: 16302
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

	// Token: 0x02006BB7 RID: 27575
	[NullableContext(0)]
	private static class EComponentType
	{
		// Token: 0x040236A4 RID: 145060
		public const int TaskItem = 0;

		// Token: 0x040236A5 RID: 145061
		public const int LockItem = 1;

		// Token: 0x040236A6 RID: 145062
		public const int ReceiveItem = 2;

		// Token: 0x040236A7 RID: 145063
		public const int TaskTxt = 3;

		// Token: 0x040236A8 RID: 145064
		public const int TrialRoleTex = 4;

		// Token: 0x040236A9 RID: 145065
		public const int TrialRoleMarkImg = 5;

		// Token: 0x040236AA RID: 145066
		public const int RewardLayout = 6;

		// Token: 0x040236AB RID: 145067
		public const int RewardItem = 7;

		// Token: 0x040236AC RID: 145068
		public const int ReceiveBtn = 8;

		// Token: 0x040236AD RID: 145069
		public const int FunctionBtn = 9;

		// Token: 0x040236AE RID: 145070
		public const int ReceivedItem = 10;

		// Token: 0x040236AF RID: 145071
		public const int TrialRoleBtn = 11;

		// Token: 0x040236B0 RID: 145072
		public const int DotItem1 = 12;

		// Token: 0x040236B1 RID: 145073
		public const int DotItem2 = 13;

		// Token: 0x040236B2 RID: 145074
		public const int LineItem1 = 14;

		// Token: 0x040236B3 RID: 145075
		public const int LineItem2 = 15;

		// Token: 0x040236B4 RID: 145076
		public const int TrialRoleNormalItem = 16;

		// Token: 0x040236B5 RID: 145077
		public const int TrialRoleReceiveItem = 17;
	}
}
