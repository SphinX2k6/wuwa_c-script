using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02000EA9 RID: 3753
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class DailyActivityController : UiControllerBase
{
	// Token: 0x0600961E RID: 38430 RVA: 0x002C7C52 File Offset: 0x002C5E52
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x0600961F RID: 38431 RVA: 0x002C7C58 File Offset: 0x002C5E58
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.LivenessUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnReceiveDailyActivityUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.LivenessRefreshNotify, new Action<IMessage, Net.CallbackStatus>(this.OnReceiveDailyActivityRefreshNotify));
		Net.Instance.Register(ENotifyMessageId.LivenessCountUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnReceiveDailyActivityValueNotify));
	}

	// Token: 0x06009620 RID: 38432 RVA: 0x002C7CB9 File Offset: 0x002C5EB9
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.LivenessUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.LivenessRefreshNotify);
		Net.Instance.UnRegister(ENotifyMessageId.LivenessCountUpdateNotify);
	}

	// Token: 0x06009621 RID: 38433 RVA: 0x002C7CEB File Offset: 0x002C5EEB
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
		EventSystem.Instance.Add(EEventName.CrossDay, new Action(this.OnCrossDay));
	}

	// Token: 0x06009622 RID: 38434 RVA: 0x002C7D25 File Offset: 0x002C5F25
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
		EventSystem.Instance.Remove(EEventName.CrossDay, new Action(this.OnCrossDay));
	}

	// Token: 0x06009623 RID: 38435 RVA: 0x002C7D5F File Offset: 0x002C5F5F
	private void OnLoadingNetDataDone()
	{
		DailyActivityModel.Instance.InitGoalData();
		this.RequestDailyActivityData().Forget<bool>();
	}

	// Token: 0x06009624 RID: 38436 RVA: 0x002C7D76 File Offset: 0x002C5F76
	private void OnCrossDay()
	{
		this.RequestDailyActivityData().ContinueWith(delegate(bool success)
		{
			EventSystem.Instance.Emit(EEventName.DailyUpdateNotify);
		}).Forget();
	}

	// Token: 0x06009625 RID: 38437 RVA: 0x002C7DA8 File Offset: 0x002C5FA8
	[NullableContext(0)]
	public UniTask<bool> RequestDailyActivityData()
	{
		DailyActivityController.<RequestDailyActivityData>d__7 <RequestDailyActivityData>d__;
		<RequestDailyActivityData>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestDailyActivityData>d__.<>1__state = -1;
		<RequestDailyActivityData>d__.<>t__builder.Start<DailyActivityController.<RequestDailyActivityData>d__7>(ref <RequestDailyActivityData>d__);
		return <RequestDailyActivityData>d__.<>t__builder.Task;
	}

	// Token: 0x06009626 RID: 38438 RVA: 0x002C7DE4 File Offset: 0x002C5FE4
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

	// Token: 0x06009627 RID: 38439 RVA: 0x002C7E28 File Offset: 0x002C6028
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

	// Token: 0x06009628 RID: 38440 RVA: 0x002C7E9C File Offset: 0x002C609C
	[NullableContext(2)]
	private void OnReceiveDailyActivityUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		LivenessUpdateNotify livenessUpdateNotify = (LivenessUpdateNotify)msg;
		DailyActivityModel.Instance.UpdateDailyActivityData(livenessUpdateNotify.LivenessInfo);
	}

	// Token: 0x06009629 RID: 38441 RVA: 0x002C7EC0 File Offset: 0x002C60C0
	[NullableContext(2)]
	private void OnReceiveDailyActivityRefreshNotify(IMessage msg, Net.CallbackStatus status)
	{
		LivenessRefreshNotify livenessRefreshNotify = (LivenessRefreshNotify)msg;
		DailyActivityModel.Instance.RefreshDailyActivityData(livenessRefreshNotify.LivenessInfo);
	}

	// Token: 0x0600962A RID: 38442 RVA: 0x002C7EE4 File Offset: 0x002C60E4
	[NullableContext(2)]
	private void OnReceiveDailyActivityValueNotify(IMessage msg, Net.CallbackStatus status)
	{
		LivenessCountUpdateNotify livenessCountUpdateNotify = (LivenessCountUpdateNotify)msg;
		DailyActivityModel.Instance.RefreshActivityValue(livenessCountUpdateNotify.LivenessCount);
	}

	// Token: 0x0600962B RID: 38443 RVA: 0x002C7F08 File Offset: 0x002C6108
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

	// Token: 0x1700105A RID: 4186
	// (get) Token: 0x0600962C RID: 38444 RVA: 0x002C7F84 File Offset: 0x002C6184
	public static DailyActivityController Instance
	{
		get
		{
			return DailyActivityController._Instance;
		}
	}

	// Token: 0x0600962D RID: 38445 RVA: 0x002C7F8B File Offset: 0x002C618B
	public static DailyActivityController GetOrCreateInstance()
	{
		if (DailyActivityController._Instance == null)
		{
			DailyActivityController.CreateInstance();
		}
		return DailyActivityController._Instance;
	}

	// Token: 0x0600962E RID: 38446 RVA: 0x002C7F9F File Offset: 0x002C619F
	public static bool CreateInstance()
	{
		if (DailyActivityController._Instance != null)
		{
			return true;
		}
		DailyActivityController._Instance = new DailyActivityController();
		return true;
	}

	// Token: 0x0600962F RID: 38447 RVA: 0x002C7FB5 File Offset: 0x002C61B5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009630 RID: 38448 RVA: 0x002C7FB7 File Offset: 0x002C61B7
	public static void ResetStaticDefaultValue()
	{
		DailyActivityController._Instance = null;
	}

	// Token: 0x06009631 RID: 38449 RVA: 0x002C7FBF File Offset: 0x002C61BF
	static DailyActivityController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DailyActivityController.CreateStaticDefaultValue), new Action(DailyActivityController.ResetStaticDefaultValue));
	}

	// Token: 0x04005A29 RID: 23081
	[Nullable(2)]
	private static DailyActivityController _Instance;
}
