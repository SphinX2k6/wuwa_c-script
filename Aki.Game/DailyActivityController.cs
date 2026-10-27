using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x020019EA RID: 6634
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class DailyActivityController : UiControllerBase
{
	// Token: 0x0600C211 RID: 49681 RVA: 0x002BCC7A File Offset: 0x002BAE7A
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x0600C212 RID: 49682 RVA: 0x002BCC80 File Offset: 0x002BAE80
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.LivenessUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnReceiveDailyActivityUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.LivenessRefreshNotify, new Action<IMessage, Net.CallbackStatus>(this.OnReceiveDailyActivityRefreshNotify));
		Net.Instance.Register(ENotifyMessageId.LivenessCountUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnReceiveDailyActivityValueNotify));
	}

	// Token: 0x0600C213 RID: 49683 RVA: 0x002BCCE1 File Offset: 0x002BAEE1
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.LivenessUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.LivenessRefreshNotify);
		Net.Instance.UnRegister(ENotifyMessageId.LivenessCountUpdateNotify);
	}

	// Token: 0x0600C214 RID: 49684 RVA: 0x002BCD13 File Offset: 0x002BAF13
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
		EventSystem.Instance.Add(EEventName.CrossDay, new Action(this.OnCrossDay));
	}

	// Token: 0x0600C215 RID: 49685 RVA: 0x002BCD4D File Offset: 0x002BAF4D
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
		EventSystem.Instance.Remove(EEventName.CrossDay, new Action(this.OnCrossDay));
	}

	// Token: 0x0600C216 RID: 49686 RVA: 0x002BCD87 File Offset: 0x002BAF87
	private void OnLoadingNetDataDone()
	{
		DailyActivityModel.Instance.InitGoalData();
		this.RequestDailyActivityData().Forget<bool>();
	}

	// Token: 0x0600C217 RID: 49687 RVA: 0x002BCD9E File Offset: 0x002BAF9E
	private void OnCrossDay()
	{
		this.RequestDailyActivityData().ContinueWith(delegate(bool success)
		{
			EventSystem.Instance.Emit(EEventName.DailyUpdateNotify);
		}).Forget();
	}

	// Token: 0x0600C218 RID: 49688 RVA: 0x002BCDD0 File Offset: 0x002BAFD0
	[NullableContext(0)]
	public UniTask<bool> RequestDailyActivityData()
	{
		DailyActivityController.<RequestDailyActivityData>d__7 <RequestDailyActivityData>d__;
		<RequestDailyActivityData>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestDailyActivityData>d__.<>1__state = -1;
		<RequestDailyActivityData>d__.<>t__builder.Start<DailyActivityController.<RequestDailyActivityData>d__7>(ref <RequestDailyActivityData>d__);
		return <RequestDailyActivityData>d__.<>t__builder.Task;
	}

	// Token: 0x0600C219 RID: 49689 RVA: 0x002BCE0C File Offset: 0x002BB00C
	[NullableContext(0)]
	public UniTask<bool> RequestDailyActivityTaskRewardAsync([Nullable(1)] List<int> taskIds)
	{
		DailyActivityController.<RequestDailyActivityTaskRewardAsync>d__8 <RequestDailyActivityTaskRewardAsync>d__;
		<RequestDailyActivityTaskRewardAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestDailyActivityTaskRewardAsync>d__.taskIds = taskIds;
		<RequestDailyActivityTaskRewardAsync>d__.<>1__state = -1;
		<RequestDailyActivityTaskRewardAsync>d__.<>t__builder.Start<DailyActivityController.<RequestDailyActivityTaskRewardAsync>d__8>(ref <RequestDailyActivityTaskRewardAsync>d__);
		return <RequestDailyActivityTaskRewardAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C21A RID: 49690 RVA: 0x002BCE50 File Offset: 0x002BB050
	public void RequestDailyActivityReward(List<int> goalIds, [Nullable(2)] Action onRewardClose = null)
	{
		DailyActivityController.<>c__DisplayClass9_0 CS$<>8__locals1 = new DailyActivityController.<>c__DisplayClass9_0();
		CS$<>8__locals1.onRewardClose = onRewardClose;
		if (goalIds.Count == 0)
		{
			Log.Instance.Warn(ELogModule.DailyActivity, ELogAuthor.YYZ, "RequestDailyActivityReward GoalIds is empty", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		LivenessTakeRequest livenessTakeRequest = LivenessTakeRequest.Create();
		livenessTakeRequest.Ids.AddRange(goalIds);
		Net.Instance.Call(ERequestMessageId.LivenessTakeRequest, livenessTakeRequest, new Action<IMessage, Net.CallbackStatus>(CS$<>8__locals1.<RequestDailyActivityReward>g__responseAction|0), 0);
	}

	// Token: 0x0600C21B RID: 49691 RVA: 0x002BCEC4 File Offset: 0x002BB0C4
	[NullableContext(2)]
	private void OnReceiveDailyActivityUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		LivenessUpdateNotify livenessUpdateNotify = (LivenessUpdateNotify)msg;
		DailyActivityModel.Instance.UpdateDailyActivityData(livenessUpdateNotify.LivenessInfo);
	}

	// Token: 0x0600C21C RID: 49692 RVA: 0x002BCEE8 File Offset: 0x002BB0E8
	[NullableContext(2)]
	private void OnReceiveDailyActivityRefreshNotify(IMessage msg, Net.CallbackStatus status)
	{
		LivenessRefreshNotify livenessRefreshNotify = (LivenessRefreshNotify)msg;
		DailyActivityModel.Instance.RefreshDailyActivityData(livenessRefreshNotify.LivenessInfo);
	}

	// Token: 0x0600C21D RID: 49693 RVA: 0x002BCF0C File Offset: 0x002BB10C
	[NullableContext(2)]
	private void OnReceiveDailyActivityValueNotify(IMessage msg, Net.CallbackStatus status)
	{
		LivenessCountUpdateNotify livenessCountUpdateNotify = (LivenessCountUpdateNotify)msg;
		DailyActivityModel.Instance.RefreshActivityValue(livenessCountUpdateNotify.LivenessCount);
	}

	// Token: 0x0600C21E RID: 49694 RVA: 0x002BCF30 File Offset: 0x002BB130
	public void RequestAllAvailableActivityReward()
	{
		Dictionary<int, DailyActivityDefine.IActivityGoalData> dailyActivityGoalMap = DailyActivityModel.Instance.DailyActivityGoalMap;
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, DailyActivityDefine.IActivityGoalData> keyValuePair in dailyActivityGoalMap)
		{
			int key = keyValuePair.Key;
			if (keyValuePair.Value.State == EDailyActiveState.FinishedAndNotTaken)
			{
				list.Add(key);
			}
		}
		this.RequestDailyActivityReward(list, null);
	}

	// Token: 0x17001035 RID: 4149
	// (get) Token: 0x0600C21F RID: 49695 RVA: 0x002BCFAC File Offset: 0x002BB1AC
	public static DailyActivityController Instance
	{
		get
		{
			return DailyActivityController._Instance;
		}
	}

	// Token: 0x0600C220 RID: 49696 RVA: 0x002BCFB3 File Offset: 0x002BB1B3
	public static DailyActivityController GetOrCreateInstance()
	{
		if (DailyActivityController._Instance == null)
		{
			DailyActivityController.CreateInstance();
		}
		return DailyActivityController._Instance;
	}

	// Token: 0x0600C221 RID: 49697 RVA: 0x002BCFC7 File Offset: 0x002BB1C7
	public static bool CreateInstance()
	{
		if (DailyActivityController._Instance != null)
		{
			return true;
		}
		DailyActivityController._Instance = new DailyActivityController();
		return true;
	}

	// Token: 0x0600C222 RID: 49698 RVA: 0x002BCFDD File Offset: 0x002BB1DD
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600C223 RID: 49699 RVA: 0x002BCFDF File Offset: 0x002BB1DF
	public static void ResetStaticDefaultValue()
	{
		DailyActivityController._Instance = null;
	}

	// Token: 0x0600C224 RID: 49700 RVA: 0x002BCFE7 File Offset: 0x002BB1E7
	static DailyActivityController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DailyActivityController.CreateStaticDefaultValue), new Action(DailyActivityController.ResetStaticDefaultValue));
	}

	// Token: 0x0400595A RID: 22874
	[Nullable(2)]
	private static DailyActivityController _Instance;
}
