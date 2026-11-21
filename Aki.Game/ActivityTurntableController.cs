using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.ItemReward;
using Google.Protobuf;

// Token: 0x020009EF RID: 2543
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityTurntableController : ActivityControllerBase
{
	// Token: 0x06006F0F RID: 28431 RVA: 0x002235F6 File Offset: 0x002217F6
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.TurntableTaskUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTurntableTaskUpdateNotify));
	}

	// Token: 0x06006F10 RID: 28432 RVA: 0x00223614 File Offset: 0x00221814
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.TurntableTaskUpdateNotify);
	}

	// Token: 0x06006F11 RID: 28433 RVA: 0x00223626 File Offset: 0x00221826
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x06006F12 RID: 28434 RVA: 0x00223660 File Offset: 0x00221860
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x06006F13 RID: 28435 RVA: 0x0022369A File Offset: 0x0022189A
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06006F14 RID: 28436 RVA: 0x0022369C File Offset: 0x0022189C
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		if (data.GetPreGuideQuestFinishState())
		{
			return "UiItem_ActivityTurntable";
		}
		return "UiItem_ActivityTurntableLock";
	}

	// Token: 0x06006F15 RID: 28437 RVA: 0x002236B1 File Offset: 0x002218B1
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		if (data.GetPreGuideQuestFinishState())
		{
			return new ActivitySubViewTurntable();
		}
		return new ActivitySubViewTurntableLock();
	}

	// Token: 0x06006F16 RID: 28438 RVA: 0x002236C6 File Offset: 0x002218C6
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new ActivityTurntableData();
	}

	// Token: 0x06006F17 RID: 28439 RVA: 0x002236CD File Offset: 0x002218CD
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06006F18 RID: 28440 RVA: 0x002236D0 File Offset: 0x002218D0
	private void OnQuestStateChange(int questId, QuestState state, EQuestStatusUpdateReason reason)
	{
		foreach (ActivityBaseData activityBaseData in ActivityModel.Instance.GetCurrentActivitiesByType(15))
		{
			(activityBaseData as ActivityTurntableData).OnQuestStateChange(questId, state, EQuestStatusUpdateReason.ReLogin);
		}
	}

	// Token: 0x06006F19 RID: 28441 RVA: 0x00223730 File Offset: 0x00221930
	private void OnCommonItemCountAnyChange(int configId, int count)
	{
		foreach (ActivityBaseData activityBaseData in ActivityModel.Instance.GetCurrentActivitiesByType(15))
		{
			(activityBaseData as ActivityTurntableData).OnCommonItemCountAnyChange(configId, count);
		}
	}

	// Token: 0x06006F1A RID: 28442 RVA: 0x00223790 File Offset: 0x00221990
	[NullableContext(2)]
	private void OnTurntableTaskUpdateNotify(IMessage msg, Net.CallbackStatus _)
	{
		TurntableTaskUpdateNotify turntableTaskUpdateNotify = (TurntableTaskUpdateNotify)msg;
		foreach (ActivityBaseData activityBaseData in ActivityModel.Instance.GetCurrentActivitiesByType(15))
		{
			ActivityTurntableData activityTurntableData = activityBaseData as ActivityTurntableData;
			if (turntableTaskUpdateNotify.TurntableTask != null)
			{
				activityTurntableData.RefreshTask(turntableTaskUpdateNotify.TurntableTask, false);
			}
		}
	}

	// Token: 0x06006F1B RID: 28443 RVA: 0x00223804 File Offset: 0x00221A04
	public static void RequestTurntableRun(int activityId)
	{
		RunTurntableActivityRequest runTurntableActivityRequest = RunTurntableActivityRequest.Create();
		runTurntableActivityRequest.ActivityId = activityId;
		Net.Instance.Call(ERequestMessageId.RunTurntableActivityRequest, runTurntableActivityRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RunTurntableActivityResponse runTurntableActivityResponse = (RunTurntableActivityResponse)msg;
			if (runTurntableActivityResponse == null)
			{
				return;
			}
			if (runTurntableActivityResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(runTurntableActivityResponse.ErrorCode, 15518, null, true, true);
			}
			ActivityTurntableData activityTurntableData = ActivityModel.Instance.GetActivityById(activityId) as ActivityTurntableData;
			if (activityTurntableData == null)
			{
				return;
			}
			List<TItem> list = new List<TItem>();
			foreach (int num in runTurntableActivityResponse.ItemMap.Keys)
			{
				TItem item = new TItem(new InventoryDefine.GetItemData(num, 0), runTurntableActivityResponse.ItemMap[num]);
				list.Add(item);
			}
			activityTurntableData.SetRunResult(runTurntableActivityResponse.RewardId, list);
			EventSystem.Instance.Emit<int>(EEventName.TurntableStartRun, runTurntableActivityResponse.RewardId);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityId);
		}, 0);
	}

	// Token: 0x06006F1C RID: 28444 RVA: 0x00223850 File Offset: 0x00221A50
	public static void ShowTurntableItemObtain(List<TItem> itemList, [Nullable(2)] Action onCloseCallback = null)
	{
		if (itemList.Count == 0)
		{
			return;
		}
		List<RewardItemData> list = new List<RewardItemData>();
		foreach (TItem titem in itemList)
		{
			RewardItemData item = new RewardItemData(titem.ItemData.ItemId, titem.Count, new int?(titem.ItemData.IncId), EDropItemType.Normal);
			list.Add(item);
		}
		RewardViewFromSource? rewardViewFromSource;
		int? num = (ItemRewardConfig.Instance.GetRewardViewFromSourceConfig(20531) != null) ? new int?(rewardViewFromSource.GetValueOrDefault().RewardViewId) : null;
		if (num != null)
		{
			ItemRewardController.Instance.OpenCommonRewardView(num.Value, list, onCloseCallback);
		}
	}

	// Token: 0x17000D70 RID: 3440
	// (get) Token: 0x06006F1D RID: 28445 RVA: 0x00223930 File Offset: 0x00221B30
	public static ActivityTurntableController Instance
	{
		get
		{
			return ActivityTurntableController._Instance;
		}
	}

	// Token: 0x06006F1E RID: 28446 RVA: 0x00223937 File Offset: 0x00221B37
	public static ActivityTurntableController GetOrCreateInstance()
	{
		if (ActivityTurntableController._Instance == null)
		{
			ActivityTurntableController.CreateInstance();
		}
		return ActivityTurntableController._Instance;
	}

	// Token: 0x06006F1F RID: 28447 RVA: 0x0022394B File Offset: 0x00221B4B
	public static bool CreateInstance()
	{
		if (ActivityTurntableController._Instance != null)
		{
			return true;
		}
		ActivityTurntableController._Instance = new ActivityTurntableController();
		return true;
	}

	// Token: 0x06006F20 RID: 28448 RVA: 0x00223961 File Offset: 0x00221B61
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006F21 RID: 28449 RVA: 0x00223963 File Offset: 0x00221B63
	public static void ResetStaticDefaultValue()
	{
		ActivityTurntableController._Instance = null;
	}

	// Token: 0x06006F22 RID: 28450 RVA: 0x0022396B File Offset: 0x00221B6B
	static ActivityTurntableController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityTurntableController.CreateStaticDefaultValue), new Action(ActivityTurntableController.ResetStaticDefaultValue));
	}

	// Token: 0x040044E0 RID: 17632
	[Nullable(2)]
	private static ActivityTurntableController _Instance;
}
