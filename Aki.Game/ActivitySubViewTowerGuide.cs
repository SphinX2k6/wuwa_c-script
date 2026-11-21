using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020009DA RID: 2522
[NullableContext(2)]
[Nullable(0)]
public class ActivitySubViewTowerGuide : ActivitySubViewBase
{
	// Token: 0x17000D64 RID: 3428
	// (get) Token: 0x06006E28 RID: 28200 RVA: 0x00220173 File Offset: 0x0021E373
	private ActivityTowerGuideData TowerGuideData
	{
		get
		{
			return this.ActivityBaseData as ActivityTowerGuideData;
		}
	}

	// Token: 0x06006E29 RID: 28201 RVA: 0x00220180 File Offset: 0x0021E380
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(12, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(20, typeof(UUIText)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIText)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(17, typeof(UUIText)),
			new ValueTuple<int, Type>(18, typeof(UUIText)),
			new ValueTuple<int, Type>(19, typeof(UUIText)),
			new ValueTuple<int, Type>(21, typeof(UUIItem)),
			new ValueTuple<int, Type>(22, typeof(UUIText)),
			new ValueTuple<int, Type>(23, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(5, new Action(this.ButtonRolePreviewClick)),
			new ValueTuple<int, Delegate>(16, new Action(this.ButtonRolePreviewClick)),
			new ValueTuple<int, Delegate>(6, new Action(this.ButtonReward1Click)),
			new ValueTuple<int, Delegate>(11, new Action(this.ButtonReward2Click)),
			new ValueTuple<int, Delegate>(12, new Action(this.ButtonJumpClick)),
			new ValueTuple<int, Delegate>(23, new Action(this.ButtonLockClick))
		};
	}

	// Token: 0x06006E2A RID: 28202 RVA: 0x00220456 File Offset: 0x0021E656
	protected override void OnSetData()
	{
	}

	// Token: 0x06006E2B RID: 28203 RVA: 0x00220458 File Offset: 0x0021E658
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewTowerGuide.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewTowerGuide.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006E2C RID: 28204 RVA: 0x0022049B File Offset: 0x0021E69B
	[NullableContext(1)]
	private ActivityTowerGuideRewardGrid CreateGridItem()
	{
		return new ActivityTowerGuideRewardGrid();
	}

	// Token: 0x06006E2D RID: 28205 RVA: 0x002204A2 File Offset: 0x0021E6A2
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x06006E2E RID: 28206 RVA: 0x002204C0 File Offset: 0x0021E6C0
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x06006E2F RID: 28207 RVA: 0x002204DE File Offset: 0x0021E6DE
	private void OnRefreshCommonActivityRedDot(int id)
	{
		if (this.TowerGuideData != null && id == this.TowerGuideData.Id)
		{
			this.OnRefreshView();
		}
	}

	// Token: 0x06006E30 RID: 28208 RVA: 0x002204FC File Offset: 0x0021E6FC
	protected override void OnStart()
	{
		this.SetTitlePart();
		this.SetRolePart();
		this.OnRefreshView();
	}

	// Token: 0x06006E31 RID: 28209 RVA: 0x00220510 File Offset: 0x0021E710
	protected override void OnBeforeDestroy()
	{
		if (this.RewardLayout != null)
		{
			foreach (ActivityTowerGuideRewardGrid child in this.RewardLayout.GetLayoutItemList())
			{
				base.AddChild(child);
			}
		}
	}

	// Token: 0x06006E32 RID: 28210 RVA: 0x00220570 File Offset: 0x0021E770
	protected override void OnRefreshView()
	{
		if (this.TowerGuideData == null)
		{
			return;
		}
		ETowerGuideViewState viewState = this.TowerGuideData.GetViewState();
		this.SetRemainTimeText();
		this.SetViewState(viewState);
	}

	// Token: 0x06006E33 RID: 28211 RVA: 0x002205A0 File Offset: 0x0021E7A0
	private void SetTitlePart()
	{
		if (this.TowerGuideData == null)
		{
			return;
		}
		base.GetText(18).SetText(this.TowerGuideData.GetTitle(), true);
		base.GetText(19).ShowTextNew(this.TowerGuideData.LocalConfig.Value.Desc);
	}

	// Token: 0x06006E34 RID: 28212 RVA: 0x002205F4 File Offset: 0x0021E7F4
	private void SetRolePart()
	{
		if (this.TowerGuideData == null)
		{
			return;
		}
		this.TrialRoleId = this.TowerGuideData.TrialRoleId;
		RoleDataBase trialRoleData = this.TowerGuideData.GetTrialRoleData();
		if (trialRoleData == null)
		{
			return;
		}
		base.GetText(17).SetText(trialRoleData.GetName(null), true);
	}

	// Token: 0x06006E35 RID: 28213 RVA: 0x00220648 File Offset: 0x0021E848
	private void SetViewState(ETowerGuideViewState state)
	{
		if (this.TowerGuideData == null)
		{
			return;
		}
		this.ViewState = state;
		bool flag = state == ETowerGuideViewState.InActive;
		bool flag2 = state == ETowerGuideViewState.Active;
		bool uiactive = state == ETowerGuideViewState.Finished;
		base.GetItem(0).SetUIActive(flag);
		base.GetItem(1).SetUIActive(flag);
		base.GetItem(2).SetUIActive(flag);
		base.GetItem(8).SetUIActive(flag);
		base.GetItem(13).SetUIActive(flag);
		base.GetButton(23).RootUIComp.Get().SetUIActive(flag);
		if (flag)
		{
			base.GetText(14).ShowTextNew(this.GetCurrentLockConditionText());
		}
		ETowerProgressState towerProgressState = this.TowerGuideData.GetTowerProgressState(1);
		ETowerProgressState towerProgressState2 = this.TowerGuideData.GetTowerProgressState(2);
		this.RefreshRewardLayout(flag, towerProgressState2 == ETowerProgressState.FinishedAndUnClaimed);
		this.ProgressComponent1.SetUiActive(towerProgressState == ETowerProgressState.Active);
		if (towerProgressState == ETowerProgressState.Active)
		{
			ValueTuple<int, int> towerProgress = this.TowerGuideData.GetTowerProgress(ETowerDifficultId.Low);
			int item = towerProgress.Item1;
			int item2 = towerProgress.Item2;
			this.ProgressComponent1.Refresh(item, item2);
		}
		base.GetItem(3).SetUIActive(towerProgressState == ETowerProgressState.FinishedAndClaimed);
		base.GetButton(6).RootUIComp.Get().SetUIActive(towerProgressState == ETowerProgressState.FinishedAndUnClaimed);
		this.ProgressComponent2.SetUiActive(towerProgressState2 == ETowerProgressState.Active);
		if (towerProgressState2 == ETowerProgressState.Active)
		{
			ValueTuple<int, int> towerProgress2 = this.TowerGuideData.GetTowerProgress(ETowerDifficultId.High);
			int item3 = towerProgress2.Item1;
			int item4 = towerProgress2.Item2;
			this.ProgressComponent2.Refresh(item3, item4);
		}
		base.GetItem(7).SetUIActive(towerProgressState2 == ETowerProgressState.FinishedAndClaimed);
		base.GetButton(11).RootUIComp.Get().SetUIActive(towerProgressState2 == ETowerProgressState.FinishedAndUnClaimed);
		base.GetButton(12).RootUIComp.Get().SetUIActive(flag2);
		if (flag2)
		{
			string key = this.TowerGuideData.GetPreGuideQuestFinishState() ? "ReadyToFightText" : "JumpToQuestText";
			base.GetText(20).ShowTextNew(key);
		}
		base.GetItem(15).SetUIActive(uiactive);
	}

	// Token: 0x06006E36 RID: 28214 RVA: 0x00220841 File Offset: 0x0021EA41
	protected override void OnTimer(float gap)
	{
		this.SetRemainTimeText();
	}

	// Token: 0x06006E37 RID: 28215 RVA: 0x00220849 File Offset: 0x0021EA49
	private void SetRemainTimeActive(bool isActive)
	{
		if (this.IsRemainTimeActive == isActive)
		{
			return;
		}
		this.IsRemainTimeActive = isActive;
		base.GetItem(21).SetUIActive(isActive);
	}

	// Token: 0x06006E38 RID: 28216 RVA: 0x0022086C File Offset: 0x0021EA6C
	private void SetRemainTimeText()
	{
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		this.SetRemainTimeActive(item);
		if (item && this.RemainTime != null)
		{
			this.RemainTime.SetText(item2, true);
		}
	}

	// Token: 0x06006E39 RID: 28217 RVA: 0x002208AC File Offset: 0x0021EAAC
	private void RefreshRewardLayout(bool isLock, bool isReceivableVisible)
	{
		TowerGuide? towerGuideById = ActivityTowerGuideConfig.Instance.GetTowerGuideById(2);
		if (towerGuideById == null || this.RewardLayout == null)
		{
			return;
		}
		TowerGuide value = towerGuideById.Value;
		List<ITowerGuideRewardItem> list = new List<ITowerGuideRewardItem>();
		for (int i = 0; i < value.RewardItemLength; i++)
		{
			DicIntInt? dicIntInt = value.RewardItem(i);
			if (dicIntInt != null)
			{
				int key = dicIntInt.Value.Key;
				int value2 = dicIntInt.Value.Value;
				TItem item = new TItem(new InventoryDefine.GetItemData(key, 0), value2);
				list.Add(new TowerGuideRewardItem
				{
					Item = item,
					IsLock = isLock,
					IsReceivableVisible = isReceivableVisible
				});
			}
		}
		this.RewardLayout.RefreshByData(list, null, false);
	}

	// Token: 0x06006E3A RID: 28218 RVA: 0x00220970 File Offset: 0x0021EB70
	private unsafe void ButtonRolePreviewClick()
	{
		RoleController instance = RoleController.Instance;
		ERoleAgentType agentType = ERoleAgentType.Preview;
		int selectRoleId = 0;
		int num = 1;
		List<int> list = new List<int>(num);
		CollectionsMarshal.SetCount<int>(list, num);
		Span<int> span = CollectionsMarshal.AsSpan<int>(list);
		int index = 0;
		*span[index] = this.TrialRoleId;
		instance.OpenRoleMainView(agentType, selectRoleId, list, null, null);
	}

	// Token: 0x06006E3B RID: 28219 RVA: 0x002209BA File Offset: 0x0021EBBA
	private void ButtonReward1Click()
	{
		if (this.TowerGuideData == null)
		{
			return;
		}
		if (this.TowerGuideData.GetTowerProgressState(1) == ETowerProgressState.FinishedAndUnClaimed)
		{
			ActivityTowerGuideController.Instance.RequestTowerReward(ETowerDifficultId.Low);
		}
	}

	// Token: 0x06006E3C RID: 28220 RVA: 0x002209DF File Offset: 0x0021EBDF
	private void ButtonReward2Click()
	{
		if (this.TowerGuideData == null)
		{
			return;
		}
		if (this.TowerGuideData.GetTowerProgressState(2) == ETowerProgressState.FinishedAndUnClaimed)
		{
			ActivityTowerGuideController.Instance.RequestTowerReward(ETowerDifficultId.High);
		}
	}

	// Token: 0x06006E3D RID: 28221 RVA: 0x00220A04 File Offset: 0x0021EC04
	private void ButtonJumpClick()
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			if (this.TowerGuideData == null)
			{
				return;
			}
			if (!this.TowerGuideData.GetPreGuideQuestFinishState())
			{
				int unFinishPreGuideQuestId = this.TowerGuideData.GetUnFinishPreGuideQuestId();
				UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
				return;
			}
			TowerController.Instance.OpenTowerView(false);
		});
	}

	// Token: 0x06006E3E RID: 28222 RVA: 0x00220A22 File Offset: 0x0021EC22
	private void ButtonLockClick()
	{
		if (this.TowerGuideData == null)
		{
			return;
		}
		ActivityController.Instance.OpenActivityConditionView(this.TowerGuideData.Id);
	}

	// Token: 0x04004490 RID: 17552
	private int TrialRoleId;

	// Token: 0x04004491 RID: 17553
	protected ETowerGuideViewState ViewState;

	// Token: 0x04004492 RID: 17554
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ActivityTowerGuideRewardGrid, ITowerGuideRewardItem> RewardLayout;

	// Token: 0x04004493 RID: 17555
	private UUIText RemainTime;

	// Token: 0x04004494 RID: 17556
	private bool IsRemainTimeActive = true;

	// Token: 0x04004495 RID: 17557
	private TowerGuideProgress ProgressComponent1;

	// Token: 0x04004496 RID: 17558
	private TowerGuideProgress ProgressComponent2;

	// Token: 0x02006CDE RID: 27870
	[NullableContext(0)]
	private class ETowerGuideComponents
	{
		// Token: 0x04023C04 RID: 146436
		public const int LockLow1 = 0;

		// Token: 0x04023C05 RID: 146437
		public const int LockLow2 = 1;

		// Token: 0x04023C06 RID: 146438
		public const int LockLow3 = 2;

		// Token: 0x04023C07 RID: 146439
		public const int ClaimedLow = 3;

		// Token: 0x04023C08 RID: 146440
		public const int Progress1 = 4;

		// Token: 0x04023C09 RID: 146441
		public const int ButtonRolePreview1 = 5;

		// Token: 0x04023C0A RID: 146442
		public const int ButtonReward1 = 6;

		// Token: 0x04023C0B RID: 146443
		public const int ClaimedHigh = 7;

		// Token: 0x04023C0C RID: 146444
		public const int LockHigh1 = 8;

		// Token: 0x04023C0D RID: 146445
		public const int RewardLayout = 9;

		// Token: 0x04023C0E RID: 146446
		public const int Progress2 = 10;

		// Token: 0x04023C0F RID: 146447
		public const int ButtonReward2 = 11;

		// Token: 0x04023C10 RID: 146448
		public const int ButtonJump = 12;

		// Token: 0x04023C11 RID: 146449
		public const int ConditionPanel = 13;

		// Token: 0x04023C12 RID: 146450
		public const int TxtCondition = 14;

		// Token: 0x04023C13 RID: 146451
		public const int FinishedPanel = 15;

		// Token: 0x04023C14 RID: 146452
		public const int ButtonRolePreview2 = 16;

		// Token: 0x04023C15 RID: 146453
		public const int RoleName = 17;

		// Token: 0x04023C16 RID: 146454
		public const int Title = 18;

		// Token: 0x04023C17 RID: 146455
		public const int TxtDesc = 19;

		// Token: 0x04023C18 RID: 146456
		public const int TxtButton = 20;

		// Token: 0x04023C19 RID: 146457
		public const int PanelTime = 21;

		// Token: 0x04023C1A RID: 146458
		public const int TxtTime = 22;

		// Token: 0x04023C1B RID: 146459
		public const int ButtonLock = 23;
	}
}
