using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02000F5C RID: 3932
[NullableContext(2)]
[Nullable(0)]
public class ExploreProgressController : UiControllerBase
{
	// Token: 0x06009DD1 RID: 40401 RVA: 0x002EC4CB File Offset: 0x002EA6CB
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.ExploreProgressRewardIdsNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleExploreProgressRewardIdsNotify));
	}

	// Token: 0x06009DD2 RID: 40402 RVA: 0x002EC4E9 File Offset: 0x002EA6E9
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.ExploreProgressRewardIdsNotify);
	}

	// Token: 0x06009DD3 RID: 40403 RVA: 0x002EC4FB File Offset: 0x002EA6FB
	protected override void OnAddEvents()
	{
		base.OnAddEvents();
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDone));
	}

	// Token: 0x06009DD4 RID: 40404 RVA: 0x002EC51F File Offset: 0x002EA71F
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDone));
		base.OnRemoveEvents();
	}

	// Token: 0x06009DD5 RID: 40405 RVA: 0x002EC544 File Offset: 0x002EA744
	private void HandleExploreProgressRewardIdsNotify(IMessage msg, Net.CallbackStatus status)
	{
		ExploreProgressRewardIdsNotify exploreProgressRewardIdsNotify = (ExploreProgressRewardIdsNotify)msg;
		ExploreProgressModel.Instance.UpdateAreaStageRewardDataList(exploreProgressRewardIdsNotify.RewardIds);
	}

	// Token: 0x06009DD6 RID: 40406 RVA: 0x002EC568 File Offset: 0x002EA768
	private void OnWorldDone()
	{
		this.AllExploreProgressAsyncRequest(0);
	}

	// Token: 0x06009DD7 RID: 40407 RVA: 0x002EC574 File Offset: 0x002EA774
	[NullableContext(0)]
	public UniTask<bool> AllExploreProgressAsyncRequest(int timeoutMs = 0)
	{
		ExploreProgressController.<AllExploreProgressAsyncRequest>d__6 <AllExploreProgressAsyncRequest>d__;
		<AllExploreProgressAsyncRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<AllExploreProgressAsyncRequest>d__.<>4__this = this;
		<AllExploreProgressAsyncRequest>d__.timeoutMs = timeoutMs;
		<AllExploreProgressAsyncRequest>d__.<>1__state = -1;
		<AllExploreProgressAsyncRequest>d__.<>t__builder.Start<ExploreProgressController.<AllExploreProgressAsyncRequest>d__6>(ref <AllExploreProgressAsyncRequest>d__);
		return <AllExploreProgressAsyncRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06009DD8 RID: 40408 RVA: 0x002EC5C0 File Offset: 0x002EA7C0
	private void ExploreProgressResponseHandle(ExploreProgressResponse response)
	{
		ExploreProgressModel instance = ExploreProgressModel.Instance;
		foreach (AreaExploreInfo areaExploreInfo in response.AreaProgress)
		{
			instance.RefreshExploreAreaData(areaExploreInfo);
		}
		EventSystem.Instance.Emit(EEventName.OnExploreProgressResponse);
	}

	// Token: 0x06009DD9 RID: 40409 RVA: 0x002EC624 File Offset: 0x002EA824
	[NullableContext(1)]
	public UniTask ReceiveAreaStageRewardAsyncRequest(int[] rewardIds)
	{
		ExploreProgressController.<ReceiveAreaStageRewardAsyncRequest>d__8 <ReceiveAreaStageRewardAsyncRequest>d__;
		<ReceiveAreaStageRewardAsyncRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ReceiveAreaStageRewardAsyncRequest>d__.<>4__this = this;
		<ReceiveAreaStageRewardAsyncRequest>d__.rewardIds = rewardIds;
		<ReceiveAreaStageRewardAsyncRequest>d__.<>1__state = -1;
		<ReceiveAreaStageRewardAsyncRequest>d__.<>t__builder.Start<ExploreProgressController.<ReceiveAreaStageRewardAsyncRequest>d__8>(ref <ReceiveAreaStageRewardAsyncRequest>d__);
		return <ReceiveAreaStageRewardAsyncRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06009DDA RID: 40410 RVA: 0x002EC670 File Offset: 0x002EA870
	private void ReceiveAreaStageRewardResponseHandle(ExploreProgressRewardResponse response)
	{
		if (((response != null) ? response.RewardIds : null) != null && response.RewardIds.Count > 0)
		{
			ExploreProgressModel.Instance.UpdateAreaStageRewardDataList(response.RewardIds);
			EventSystem.Instance.Emit<IReadOnlyList<int>>(EEventName.OnReceiveAreaStageRewardResponse, response.RewardIds);
		}
	}

	// Token: 0x06009DDB RID: 40411 RVA: 0x002EC6C0 File Offset: 0x002EA8C0
	public UniTask QueryOnlinePlayersAreaAsyncRequest()
	{
		ExploreProgressController.<QueryOnlinePlayersAreaAsyncRequest>d__10 <QueryOnlinePlayersAreaAsyncRequest>d__;
		<QueryOnlinePlayersAreaAsyncRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<QueryOnlinePlayersAreaAsyncRequest>d__.<>4__this = this;
		<QueryOnlinePlayersAreaAsyncRequest>d__.<>1__state = -1;
		<QueryOnlinePlayersAreaAsyncRequest>d__.<>t__builder.Start<ExploreProgressController.<QueryOnlinePlayersAreaAsyncRequest>d__10>(ref <QueryOnlinePlayersAreaAsyncRequest>d__);
		return <QueryOnlinePlayersAreaAsyncRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06009DDC RID: 40412 RVA: 0x002EC703 File Offset: 0x002EA903
	private void QueryOnlinePlayersAreaResponseHandle(QueryOnlinePlayersAreaResponse response)
	{
		if (response.ErrorCode != ErrorCode.Success)
		{
			ErrorCodeConfig.Instance.GetTextByErrorId(response.ErrorCode);
			return;
		}
		ExploreProgressModel.Instance.UpdateOnlinePlayersArea(new Dictionary<int, int>(response.AreaDict));
	}

	// Token: 0x06009DDD RID: 40413 RVA: 0x002EC734 File Offset: 0x002EA934
	public UniTask ExploreEntityTraceRequest(int exploratoryDegree, int areaId)
	{
		ExploreProgressController.<ExploreEntityTraceRequest>d__12 <ExploreEntityTraceRequest>d__;
		<ExploreEntityTraceRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ExploreEntityTraceRequest>d__.exploratoryDegree = exploratoryDegree;
		<ExploreEntityTraceRequest>d__.areaId = areaId;
		<ExploreEntityTraceRequest>d__.<>1__state = -1;
		<ExploreEntityTraceRequest>d__.<>t__builder.Start<ExploreProgressController.<ExploreEntityTraceRequest>d__12>(ref <ExploreEntityTraceRequest>d__);
		return <ExploreEntityTraceRequest>d__.<>t__builder.Task;
	}

	// Token: 0x170010A8 RID: 4264
	// (get) Token: 0x06009DDE RID: 40414 RVA: 0x002EC77F File Offset: 0x002EA97F
	[Nullable(1)]
	public static ExploreProgressController Instance
	{
		[NullableContext(1)]
		get
		{
			return ExploreProgressController._Instance;
		}
	}

	// Token: 0x06009DDF RID: 40415 RVA: 0x002EC786 File Offset: 0x002EA986
	[NullableContext(1)]
	public static ExploreProgressController GetOrCreateInstance()
	{
		if (ExploreProgressController._Instance == null)
		{
			ExploreProgressController.CreateInstance();
		}
		return ExploreProgressController._Instance;
	}

	// Token: 0x06009DE0 RID: 40416 RVA: 0x002EC79A File Offset: 0x002EA99A
	public static bool CreateInstance()
	{
		if (ExploreProgressController._Instance != null)
		{
			return true;
		}
		ExploreProgressController._Instance = new ExploreProgressController();
		return true;
	}

	// Token: 0x06009DE1 RID: 40417 RVA: 0x002EC7B0 File Offset: 0x002EA9B0
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009DE2 RID: 40418 RVA: 0x002EC7B2 File Offset: 0x002EA9B2
	public static void ResetStaticDefaultValue()
	{
		ExploreProgressController._Instance = null;
	}

	// Token: 0x06009DE3 RID: 40419 RVA: 0x002EC7BA File Offset: 0x002EA9BA
	static ExploreProgressController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ExploreProgressController.CreateStaticDefaultValue), new Action(ExploreProgressController.ResetStaticDefaultValue));
	}

	// Token: 0x04005DB6 RID: 23990
	private static ExploreProgressController _Instance;
}
