using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.ItemReward;
using Google.Protobuf;

// Token: 0x02001537 RID: 5431
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityTurntableController : ActivityControllerBase
{
	// Token: 0x06009B31 RID: 39729 RVA: 0x00219855 File Offset: 0x00217A55
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.TurntableTaskUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTurntableTaskUpdateNotify));
	}

	// Token: 0x06009B32 RID: 39730 RVA: 0x00219873 File Offset: 0x00217A73
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.TurntableTaskUpdateNotify);
	}

	// Token: 0x06009B33 RID: 39731 RVA: 0x00219885 File Offset: 0x00217A85
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x06009B34 RID: 39732 RVA: 0x002198BF File Offset: 0x00217ABF
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x06009B35 RID: 39733 RVA: 0x002198F9 File Offset: 0x00217AF9
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06009B36 RID: 39734 RVA: 0x002198FB File Offset: 0x00217AFB
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		if (data.GetPreGuideQuestFinishState())
		{
			return "UiItem_ActivityTurntable";
		}
		return "UiItem_ActivityTurntableLock";
	}

	// Token: 0x06009B37 RID: 39735 RVA: 0x00219910 File Offset: 0x00217B10
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		if (data.GetPreGuideQuestFinishState())
		{
			return new ActivitySubViewTurntable();
		}
		return new ActivitySubViewTurntableLock();
	}

	// Token: 0x06009B38 RID: 39736 RVA: 0x00219925 File Offset: 0x00217B25
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new ActivityTurntableData();
	}

	// Token: 0x06009B39 RID: 39737 RVA: 0x0021992C File Offset: 0x00217B2C
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06009B3A RID: 39738 RVA: 0x00219930 File Offset: 0x00217B30
	private void OnQuestStateChange(int questId, QuestState state, EQuestStatusUpdateReason reason)
	{
		foreach (ActivityBaseData activityBaseData in ActivityModel.Instance.GetCurrentActivitiesByType(15))
		{
			(activityBaseData as ActivityTurntableData).OnQuestStateChange(questId, state, EQuestStatusUpdateReason.ReLogin);
		}
	}

	// Token: 0x06009B3B RID: 39739 RVA: 0x00219990 File Offset: 0x00217B90
	private void OnCommonItemCountAnyChange(int configId, int count)
	{
		foreach (ActivityBaseData activityBaseData in ActivityModel.Instance.GetCurrentActivitiesByType(15))
		{
			(activityBaseData as ActivityTurntableData).OnCommonItemCountAnyChange(configId, count);
		}
	}

	// Token: 0x06009B3C RID: 39740 RVA: 0x002199F0 File Offset: 0x00217BF0
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

	// Token: 0x06009B3D RID: 39741 RVA: 0x00219A64 File Offset: 0x00217C64
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(runTurntableActivityResponse.ErrorCode, 26481, null, true, true);
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

	// Token: 0x06009B3E RID: 39742 RVA: 0x00219AB0 File Offset: 0x00217CB0
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

	// Token: 0x17000D4F RID: 3407
	// (get) Token: 0x06009B3F RID: 39743 RVA: 0x00219B90 File Offset: 0x00217D90
	public static ActivityTurntableController Instance
	{
		get
		{
			return ActivityTurntableController._Instance;
		}
	}

	// Token: 0x06009B40 RID: 39744 RVA: 0x00219B97 File Offset: 0x00217D97
	public static ActivityTurntableController GetOrCreateInstance()
	{
		if (ActivityTurntableController._Instance == null)
		{
			ActivityTurntableController.CreateInstance();
		}
		return ActivityTurntableController._Instance;
	}

	// Token: 0x06009B41 RID: 39745 RVA: 0x00219BAB File Offset: 0x00217DAB
	public static bool CreateInstance()
	{
		if (ActivityTurntableController._Instance != null)
		{
			return true;
		}
		ActivityTurntableController._Instance = new ActivityTurntableController();
		return true;
	}

	// Token: 0x06009B42 RID: 39746 RVA: 0x00219BC1 File Offset: 0x00217DC1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009B43 RID: 39747 RVA: 0x00219BC3 File Offset: 0x00217DC3
	public static void ResetStaticDefaultValue()
	{
		ActivityTurntableController._Instance = null;
	}

	// Token: 0x06009B44 RID: 39748 RVA: 0x00219BCB File Offset: 0x00217DCB
	static ActivityTurntableController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityTurntableController.CreateStaticDefaultValue), new Action(ActivityTurntableController.ResetStaticDefaultValue));
	}

	// Token: 0x0400443A RID: 17466
	[Nullable(2)]
	private static ActivityTurntableController _Instance;
}
