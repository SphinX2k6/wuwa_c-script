using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;
using Google.Protobuf.Collections;

// Token: 0x020006B4 RID: 1716
[NullableContext(1)]
[Nullable(0)]
public class CumulativeShopController : ActivityControllerBase
{
	// Token: 0x06004EE2 RID: 20194 RVA: 0x001A88B8 File Offset: 0x001A6AB8
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06004EE3 RID: 20195 RVA: 0x001A88BA File Offset: 0x001A6ABA
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiView_CumulativeShop";
	}

	// Token: 0x06004EE4 RID: 20196 RVA: 0x001A88C1 File Offset: 0x001A6AC1
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new CumulativeShopSubView();
	}

	// Token: 0x06004EE5 RID: 20197 RVA: 0x001A88C8 File Offset: 0x001A6AC8
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.ActivityId = data.Id;
		return new CumulativeShopData();
	}

	// Token: 0x06004EE6 RID: 20198 RVA: 0x001A88DB File Offset: 0x001A6ADB
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06004EE7 RID: 20199 RVA: 0x001A88DE File Offset: 0x001A6ADE
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.ConsumptiveTaskInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.ConsumptiveTaskInfoNotify));
		Net.Instance.Register(ENotifyMessageId.ConsumptiveTotalScoreNotify, new Action<IMessage, Net.CallbackStatus>(this.ConsumptiveTotalScoreNotify));
	}

	// Token: 0x06004EE8 RID: 20200 RVA: 0x001A8918 File Offset: 0x001A6B18
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.ConsumptiveTaskInfoNotify);
		Net.Instance.UnRegister(ENotifyMessageId.ConsumptiveTotalScoreNotify);
	}

	// Token: 0x06004EE9 RID: 20201 RVA: 0x001A893C File Offset: 0x001A6B3C
	public void ConsumptiveRewardRequest(int taskTab)
	{
		CumulativeShopData cumulativeShopData = this.GetCumulativeShopData();
		if (cumulativeShopData == null)
		{
			return;
		}
		List<int> list;
		if (!cumulativeShopData.TaskTabMap.TryGetValue(taskTab, out list) || list == null)
		{
			return;
		}
		List<int> list2 = new List<int>();
		foreach (int num in list)
		{
			ConsumptiveTaskInfo consumptiveTaskInfo;
			if (cumulativeShopData.TaskDataMap.TryGetValue(num, out consumptiveTaskInfo) && ((consumptiveTaskInfo.Reward != null) ? consumptiveTaskInfo.Reward.WaitReward : 0) > 0)
			{
				list2.Add(num);
			}
		}
		ConsumptiveRewardRequest consumptiveRewardRequest = Aki.Protocol.ConsumptiveRewardRequest.Create();
		consumptiveRewardRequest.ActivityId = this.ActivityId;
		foreach (int item in list2)
		{
			consumptiveRewardRequest.TaskIds.Add(item);
		}
		Net.Instance.Call(ERequestMessageId.ConsumptiveRewardRequest, consumptiveRewardRequest, delegate(IMessage msg, Net.CallbackStatus status)
		{
			ConsumptiveRewardResponse consumptiveRewardResponse = (ConsumptiveRewardResponse)msg;
			if (consumptiveRewardResponse == null)
			{
				return;
			}
			if (consumptiveRewardResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(consumptiveRewardResponse.ErrorCode, 25276, null, true, true);
				return;
			}
			CumulativeShopData cumulativeShopData2 = this.GetCumulativeShopData();
			for (int i = 0; i < consumptiveRewardResponse.TaskInfos.Count; i++)
			{
				ConsumptiveTaskInfo consumptiveTaskInfo2 = consumptiveRewardResponse.TaskInfos[i];
				cumulativeShopData2.TaskDataMap[consumptiveTaskInfo2.Id] = consumptiveTaskInfo2;
				int taskTab2 = CumulativeShopConfig.Instance.GetCumulativeShopTaskConfig(consumptiveTaskInfo2.Id).Value.TaskTab;
				List<int> list3;
				if (!cumulativeShopData2.TaskTabMap.TryGetValue(taskTab2, out list3) || list3 == null)
				{
					list3 = new List<int>();
				}
				if (!list3.Contains(consumptiveTaskInfo2.Id))
				{
					list3.Add(consumptiveTaskInfo2.Id);
				}
				cumulativeShopData2.TaskTabMap[taskTab2] = list3;
				EventSystem.Instance.Emit<int>(EEventName.CumulativeShopTaskRefresh, taskTab2);
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
		}, 0);
	}

	// Token: 0x06004EEA RID: 20202 RVA: 0x001A8A54 File Offset: 0x001A6C54
	public CumulativeShopData GetCumulativeShopData()
	{
		return ActivityModel.Instance.GetActivityById(this.ActivityId) as CumulativeShopData;
	}

	// Token: 0x06004EEB RID: 20203 RVA: 0x001A8A6C File Offset: 0x001A6C6C
	[NullableContext(2)]
	public void ConsumptiveTaskInfoNotify(IMessage msg, Net.CallbackStatus status)
	{
		ConsumptiveTaskInfoNotify consumptiveTaskInfoNotify = (ConsumptiveTaskInfoNotify)msg;
		CumulativeShopData cumulativeShopData = this.GetCumulativeShopData();
		cumulativeShopData.TaskDataMap[consumptiveTaskInfoNotify.ConsumptiveTaskInfo.Id] = consumptiveTaskInfoNotify.ConsumptiveTaskInfo;
		int taskTab = CumulativeShopConfig.Instance.GetCumulativeShopTaskConfig(consumptiveTaskInfoNotify.ConsumptiveTaskInfo.Id).Value.TaskTab;
		List<int> list;
		if (!cumulativeShopData.TaskTabMap.TryGetValue(taskTab, out list) || list == null)
		{
			list = new List<int>();
		}
		if (!list.Contains(consumptiveTaskInfoNotify.ConsumptiveTaskInfo.Id))
		{
			list.Add(consumptiveTaskInfoNotify.ConsumptiveTaskInfo.Id);
		}
		cumulativeShopData.TaskTabMap[taskTab] = list;
		EventSystem.Instance.Emit<int>(EEventName.CumulativeShopTaskRefresh, taskTab);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
	}

	// Token: 0x06004EEC RID: 20204 RVA: 0x001A8B3C File Offset: 0x001A6D3C
	[NullableContext(2)]
	private void ConsumptiveTotalScoreNotify(IMessage msg, Net.CallbackStatus status)
	{
		ConsumptiveTotalScoreNotify consumptiveTotalScoreNotify = (ConsumptiveTotalScoreNotify)msg;
		CumulativeShopData cumulativeShopData = this.GetCumulativeShopData();
		if (cumulativeShopData == null)
		{
			return;
		}
		cumulativeShopData.TotalScore = consumptiveTotalScoreNotify.TotalScore;
		EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, this.ActivityId);
	}

	// Token: 0x06004EED RID: 20205 RVA: 0x001A8B80 File Offset: 0x001A6D80
	public void ConsumptiveActivityInfoRequest()
	{
		ConsumptiveActivityInfoRequest message = Aki.Protocol.ConsumptiveActivityInfoRequest.Create();
		Net.Instance.Call(ERequestMessageId.ConsumptiveActivityInfoRequest, message, delegate(IMessage msg, Net.CallbackStatus status)
		{
			ConsumptiveActivityInfoResponse consumptiveActivityInfoResponse = (ConsumptiveActivityInfoResponse)msg;
			CumulativeShopData cumulativeShopData = this.GetCumulativeShopData();
			cumulativeShopData.TaskDataMap.Clear();
			cumulativeShopData.TaskTabMap.Clear();
			RepeatedField<ConsumptiveTaskInfo> tasks = consumptiveActivityInfoResponse.ConsumptiveActivityInfo.Tasks;
			int totalScore = consumptiveActivityInfoResponse.ConsumptiveActivityInfo.TotalScore;
			cumulativeShopData.TotalScore = totalScore;
			foreach (ConsumptiveTaskInfo consumptiveTaskInfo in tasks)
			{
				cumulativeShopData.TaskDataMap[consumptiveTaskInfo.Id] = consumptiveTaskInfo;
				int taskTab = CumulativeShopConfig.Instance.GetCumulativeShopTaskConfig(consumptiveTaskInfo.Id).Value.TaskTab;
				List<int> list;
				if (!cumulativeShopData.TaskTabMap.TryGetValue(taskTab, out list) || list == null)
				{
					list = new List<int>();
				}
				list.Add(consumptiveTaskInfo.Id);
				cumulativeShopData.TaskTabMap[taskTab] = list;
			}
			EventSystem.Instance.Emit(EEventName.CumulativeShopTaskViewDataRefresh);
		}, 0);
	}

	// Token: 0x06004EEE RID: 20206 RVA: 0x001A8BB0 File Offset: 0x001A6DB0
	public void ConsumptiveActivityScoreRequest()
	{
		CumulativeShopData data = this.GetCumulativeShopData();
		if (data == null || data.ScoreRequesting)
		{
			return;
		}
		data.ScoreRequesting = true;
		ConsumptiveActivityScoreRequest consumptiveActivityScoreRequest = Aki.Protocol.ConsumptiveActivityScoreRequest.Create();
		consumptiveActivityScoreRequest.ActivityId = this.ActivityId;
		Net.Instance.Call(ERequestMessageId.ConsumptiveActivityScoreRequest, consumptiveActivityScoreRequest, delegate(IMessage msg, Net.CallbackStatus status)
		{
			ConsumptiveActivityScoreResponse consumptiveActivityScoreResponse = (ConsumptiveActivityScoreResponse)msg;
			data.ScoreRequesting = false;
			if (consumptiveActivityScoreResponse == null)
			{
				return;
			}
			if (consumptiveActivityScoreResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(consumptiveActivityScoreResponse.ErrorCode, 15654, null, true, true);
				return;
			}
			data.TotalScore = consumptiveActivityScoreResponse.TotalScore;
			EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, this.ActivityId);
		}, 0);
	}

	// Token: 0x17000AAB RID: 2731
	// (get) Token: 0x06004EEF RID: 20207 RVA: 0x001A8C27 File Offset: 0x001A6E27
	public static CumulativeShopController Instance
	{
		get
		{
			return CumulativeShopController._Instance;
		}
	}

	// Token: 0x06004EF0 RID: 20208 RVA: 0x001A8C2E File Offset: 0x001A6E2E
	public static CumulativeShopController GetOrCreateInstance()
	{
		if (CumulativeShopController._Instance == null)
		{
			CumulativeShopController.CreateInstance();
		}
		return CumulativeShopController._Instance;
	}

	// Token: 0x06004EF1 RID: 20209 RVA: 0x001A8C42 File Offset: 0x001A6E42
	public static bool CreateInstance()
	{
		if (CumulativeShopController._Instance != null)
		{
			return true;
		}
		CumulativeShopController._Instance = new CumulativeShopController();
		return true;
	}

	// Token: 0x06004EF2 RID: 20210 RVA: 0x001A8C58 File Offset: 0x001A6E58
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06004EF3 RID: 20211 RVA: 0x001A8C5A File Offset: 0x001A6E5A
	public static void ResetStaticDefaultValue()
	{
		CumulativeShopController._Instance = null;
	}

	// Token: 0x06004EF4 RID: 20212 RVA: 0x001A8C62 File Offset: 0x001A6E62
	static CumulativeShopController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CumulativeShopController.CreateStaticDefaultValue), new Action(CumulativeShopController.ResetStaticDefaultValue));
	}

	// Token: 0x040038FE RID: 14590
	public int ActivityId;

	// Token: 0x040038FF RID: 14591
	[Nullable(2)]
	private static CumulativeShopController _Instance;
}
