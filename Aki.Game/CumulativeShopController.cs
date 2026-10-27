using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;
using Google.Protobuf.Collections;

// Token: 0x02001200 RID: 4608
[NullableContext(1)]
[Nullable(0)]
public class CumulativeShopController : ActivityControllerBase
{
	// Token: 0x06007B4C RID: 31564 RVA: 0x0019FC00 File Offset: 0x0019DE00
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06007B4D RID: 31565 RVA: 0x0019FC02 File Offset: 0x0019DE02
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiView_CumulativeShop";
	}

	// Token: 0x06007B4E RID: 31566 RVA: 0x0019FC09 File Offset: 0x0019DE09
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new CumulativeShopSubView();
	}

	// Token: 0x06007B4F RID: 31567 RVA: 0x0019FC10 File Offset: 0x0019DE10
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.ActivityId = data.Id;
		return new CumulativeShopData();
	}

	// Token: 0x06007B50 RID: 31568 RVA: 0x0019FC23 File Offset: 0x0019DE23
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06007B51 RID: 31569 RVA: 0x0019FC26 File Offset: 0x0019DE26
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.ConsumptiveTaskInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.ConsumptiveTaskInfoNotify));
		Net.Instance.Register(ENotifyMessageId.ConsumptiveTotalScoreNotify, new Action<IMessage, Net.CallbackStatus>(this.ConsumptiveTotalScoreNotify));
	}

	// Token: 0x06007B52 RID: 31570 RVA: 0x0019FC60 File Offset: 0x0019DE60
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.ConsumptiveTaskInfoNotify);
		Net.Instance.UnRegister(ENotifyMessageId.ConsumptiveTotalScoreNotify);
	}

	// Token: 0x06007B53 RID: 31571 RVA: 0x0019FC84 File Offset: 0x0019DE84
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(consumptiveRewardResponse.ErrorCode, 23419, null, true, true);
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

	// Token: 0x06007B54 RID: 31572 RVA: 0x0019FD9C File Offset: 0x0019DF9C
	public CumulativeShopData GetCumulativeShopData()
	{
		return ActivityModel.Instance.GetActivityById(this.ActivityId) as CumulativeShopData;
	}

	// Token: 0x06007B55 RID: 31573 RVA: 0x0019FDB4 File Offset: 0x0019DFB4
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

	// Token: 0x06007B56 RID: 31574 RVA: 0x0019FE84 File Offset: 0x0019E084
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

	// Token: 0x06007B57 RID: 31575 RVA: 0x0019FEC8 File Offset: 0x0019E0C8
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

	// Token: 0x06007B58 RID: 31576 RVA: 0x0019FEF8 File Offset: 0x0019E0F8
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(consumptiveActivityScoreResponse.ErrorCode, 15172, null, true, true);
				return;
			}
			data.TotalScore = consumptiveActivityScoreResponse.TotalScore;
			EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, this.ActivityId);
		}, 0);
	}

	// Token: 0x17000A8B RID: 2699
	// (get) Token: 0x06007B59 RID: 31577 RVA: 0x0019FF6F File Offset: 0x0019E16F
	public static CumulativeShopController Instance
	{
		get
		{
			return CumulativeShopController._Instance;
		}
	}

	// Token: 0x06007B5A RID: 31578 RVA: 0x0019FF76 File Offset: 0x0019E176
	public static CumulativeShopController GetOrCreateInstance()
	{
		if (CumulativeShopController._Instance == null)
		{
			CumulativeShopController.CreateInstance();
		}
		return CumulativeShopController._Instance;
	}

	// Token: 0x06007B5B RID: 31579 RVA: 0x0019FF8A File Offset: 0x0019E18A
	public static bool CreateInstance()
	{
		if (CumulativeShopController._Instance != null)
		{
			return true;
		}
		CumulativeShopController._Instance = new CumulativeShopController();
		return true;
	}

	// Token: 0x06007B5C RID: 31580 RVA: 0x0019FFA0 File Offset: 0x0019E1A0
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007B5D RID: 31581 RVA: 0x0019FFA2 File Offset: 0x0019E1A2
	public static void ResetStaticDefaultValue()
	{
		CumulativeShopController._Instance = null;
	}

	// Token: 0x06007B5E RID: 31582 RVA: 0x0019FFAA File Offset: 0x0019E1AA
	static CumulativeShopController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CumulativeShopController.CreateStaticDefaultValue), new Action(CumulativeShopController.ResetStaticDefaultValue));
	}

	// Token: 0x04003865 RID: 14437
	public int ActivityId;

	// Token: 0x04003866 RID: 14438
	[Nullable(2)]
	private static CumulativeShopController _Instance;
}
