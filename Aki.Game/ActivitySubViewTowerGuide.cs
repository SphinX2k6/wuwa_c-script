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

// Token: 0x02001522 RID: 5410
[NullableContext(2)]
[Nullable(0)]
public class ActivitySubViewTowerGuide : ActivitySubViewBase
{
	// Token: 0x17000D43 RID: 3395
	// (get) Token: 0x06009A4A RID: 39498 RVA: 0x002163D6 File Offset: 0x002145D6
	private ActivityTowerGuideData TowerGuideData
	{
		get
		{
			return this.ActivityBaseData as ActivityTowerGuideData;
		}
	}

	// Token: 0x06009A4B RID: 39499 RVA: 0x002163E4 File Offset: 0x002145E4
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

	// Token: 0x06009A4C RID: 39500 RVA: 0x002166BA File Offset: 0x002148BA
	protected override void OnSetData()
	{
	}

	// Token: 0x06009A4D RID: 39501 RVA: 0x002166BC File Offset: 0x002148BC
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewTowerGuide.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewTowerGuide.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009A4E RID: 39502 RVA: 0x002166FF File Offset: 0x002148FF
	[NullableContext(1)]
	private ActivityTowerGuideRewardGrid CreateGridItem()
	{
		return new ActivityTowerGuideRewardGrid();
	}

	// Token: 0x06009A4F RID: 39503 RVA: 0x00216706 File Offset: 0x00214906
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x06009A50 RID: 39504 RVA: 0x00216724 File Offset: 0x00214924
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x06009A51 RID: 39505 RVA: 0x00216742 File Offset: 0x00214942
	private void OnRefreshCommonActivityRedDot(int id)
	{
		if (this.TowerGuideData != null && id == this.TowerGuideData.Id)
		{
			this.OnRefreshView();
		}
	}

	// Token: 0x06009A52 RID: 39506 RVA: 0x00216760 File Offset: 0x00214960
	protected override void OnStart()
	{
		this.SetTitlePart();
		this.SetRolePart();
		this.OnRefreshView();
	}

	// Token: 0x06009A53 RID: 39507 RVA: 0x00216774 File Offset: 0x00214974
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

	// Token: 0x06009A54 RID: 39508 RVA: 0x002167D4 File Offset: 0x002149D4
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

	// Token: 0x06009A55 RID: 39509 RVA: 0x00216804 File Offset: 0x00214A04
	private void SetTitlePart()
	{
		if (this.TowerGuideData == null)
		{
			return;
		}
		base.GetText(18).SetText(this.TowerGuideData.GetTitle(), true);
		base.GetText(19).ShowTextNew(this.TowerGuideData.LocalConfig.Value.Desc);
	}

	// Token: 0x06009A56 RID: 39510 RVA: 0x00216858 File Offset: 0x00214A58
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

	// Token: 0x06009A57 RID: 39511 RVA: 0x002168AC File Offset: 0x00214AAC
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

	// Token: 0x06009A58 RID: 39512 RVA: 0x00216AA5 File Offset: 0x00214CA5
	protected override void OnTimer(float gap)
	{
		this.SetRemainTimeText();
	}

	// Token: 0x06009A59 RID: 39513 RVA: 0x00216AAD File Offset: 0x00214CAD
	private void SetRemainTimeActive(bool isActive)
	{
		if (this.IsRemainTimeActive == isActive)
		{
			return;
		}
		this.IsRemainTimeActive = isActive;
		base.GetItem(21).SetUIActive(isActive);
	}

	// Token: 0x06009A5A RID: 39514 RVA: 0x00216AD0 File Offset: 0x00214CD0
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

	// Token: 0x06009A5B RID: 39515 RVA: 0x00216B10 File Offset: 0x00214D10
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

	// Token: 0x06009A5C RID: 39516 RVA: 0x00216BD4 File Offset: 0x00214DD4
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

	// Token: 0x06009A5D RID: 39517 RVA: 0x00216C1E File Offset: 0x00214E1E
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

	// Token: 0x06009A5E RID: 39518 RVA: 0x00216C43 File Offset: 0x00214E43
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

	// Token: 0x06009A5F RID: 39519 RVA: 0x00216C68 File Offset: 0x00214E68
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

	// Token: 0x06009A60 RID: 39520 RVA: 0x00216C86 File Offset: 0x00214E86
	private void ButtonLockClick()
	{
		if (this.TowerGuideData == null)
		{
			return;
		}
		ActivityController.Instance.OpenActivityConditionView(this.TowerGuideData.Id);
	}

	// Token: 0x040043EA RID: 17386
	private int TrialRoleId;

	// Token: 0x040043EB RID: 17387
	protected ETowerGuideViewState ViewState;

	// Token: 0x040043EC RID: 17388
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ActivityTowerGuideRewardGrid, ITowerGuideRewardItem> RewardLayout;

	// Token: 0x040043ED RID: 17389
	private UUIText RemainTime;

	// Token: 0x040043EE RID: 17390
	private bool IsRemainTimeActive = true;

	// Token: 0x040043EF RID: 17391
	private TowerGuideProgress ProgressComponent1;

	// Token: 0x040043F0 RID: 17392
	private TowerGuideProgress ProgressComponent2;

	// Token: 0x02007B53 RID: 31571
	[NullableContext(0)]
	private class ETowerGuideComponents
	{
		// Token: 0x040288C9 RID: 166089
		public const int LockLow1 = 0;

		// Token: 0x040288CA RID: 166090
		public const int LockLow2 = 1;

		// Token: 0x040288CB RID: 166091
		public const int LockLow3 = 2;

		// Token: 0x040288CC RID: 166092
		public const int ClaimedLow = 3;

		// Token: 0x040288CD RID: 166093
		public const int Progress1 = 4;

		// Token: 0x040288CE RID: 166094
		public const int ButtonRolePreview1 = 5;

		// Token: 0x040288CF RID: 166095
		public const int ButtonReward1 = 6;

		// Token: 0x040288D0 RID: 166096
		public const int ClaimedHigh = 7;

		// Token: 0x040288D1 RID: 166097
		public const int LockHigh1 = 8;

		// Token: 0x040288D2 RID: 166098
		public const int RewardLayout = 9;

		// Token: 0x040288D3 RID: 166099
		public const int Progress2 = 10;

		// Token: 0x040288D4 RID: 166100
		public const int ButtonReward2 = 11;

		// Token: 0x040288D5 RID: 166101
		public const int ButtonJump = 12;

		// Token: 0x040288D6 RID: 166102
		public const int ConditionPanel = 13;

		// Token: 0x040288D7 RID: 166103
		public const int TxtCondition = 14;

		// Token: 0x040288D8 RID: 166104
		public const int FinishedPanel = 15;

		// Token: 0x040288D9 RID: 166105
		public const int ButtonRolePreview2 = 16;

		// Token: 0x040288DA RID: 166106
		public const int RoleName = 17;

		// Token: 0x040288DB RID: 166107
		public const int Title = 18;

		// Token: 0x040288DC RID: 166108
		public const int TxtDesc = 19;

		// Token: 0x040288DD RID: 166109
		public const int TxtButton = 20;

		// Token: 0x040288DE RID: 166110
		public const int PanelTime = 21;

		// Token: 0x040288DF RID: 166111
		public const int TxtTime = 22;

		// Token: 0x040288E0 RID: 166112
		public const int ButtonLock = 23;
	}
}
