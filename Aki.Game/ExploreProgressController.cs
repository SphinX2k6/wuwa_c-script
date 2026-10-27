using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02001A9D RID: 6813
[NullableContext(2)]
[Nullable(0)]
public class ExploreProgressController : UiControllerBase
{
	// Token: 0x0600C9C0 RID: 51648 RVA: 0x002E1377 File Offset: 0x002DF577
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.ExploreProgressRewardIdsNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleExploreProgressRewardIdsNotify));
	}

	// Token: 0x0600C9C1 RID: 51649 RVA: 0x002E1395 File Offset: 0x002DF595
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.ExploreProgressRewardIdsNotify);
	}

	// Token: 0x0600C9C2 RID: 51650 RVA: 0x002E13A7 File Offset: 0x002DF5A7
	protected override void OnAddEvents()
	{
		base.OnAddEvents();
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDone));
	}

	// Token: 0x0600C9C3 RID: 51651 RVA: 0x002E13CB File Offset: 0x002DF5CB
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDone));
		base.OnRemoveEvents();
	}

	// Token: 0x0600C9C4 RID: 51652 RVA: 0x002E13F0 File Offset: 0x002DF5F0
	private void HandleExploreProgressRewardIdsNotify(IMessage msg, Net.CallbackStatus status)
	{
		ExploreProgressRewardIdsNotify exploreProgressRewardIdsNotify = (ExploreProgressRewardIdsNotify)msg;
		ExploreProgressModel.Instance.UpdateAreaStageRewardDataList(exploreProgressRewardIdsNotify.RewardIds.ToArray<int>());
	}

	// Token: 0x0600C9C5 RID: 51653 RVA: 0x002E1419 File Offset: 0x002DF619
	private void OnWorldDone()
	{
		this.AllExploreProgressAsyncRequest(0);
	}

	// Token: 0x0600C9C6 RID: 51654 RVA: 0x002E1424 File Offset: 0x002DF624
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

	// Token: 0x0600C9C7 RID: 51655 RVA: 0x002E1470 File Offset: 0x002DF670
	private void ExploreProgressResponseHandle(ExploreProgressResponse response)
	{
		ExploreProgressModel instance = ExploreProgressModel.Instance;
		foreach (AreaExploreInfo areaExploreInfo in response.AreaProgress)
		{
			instance.RefreshExploreAreaData(areaExploreInfo);
		}
		EventSystem.Instance.Emit(EEventName.OnExploreProgressResponse);
	}

	// Token: 0x0600C9C8 RID: 51656 RVA: 0x002E14D4 File Offset: 0x002DF6D4
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

	// Token: 0x0600C9C9 RID: 51657 RVA: 0x002E1520 File Offset: 0x002DF720
	private void ReceiveAreaStageRewardResponseHandle(ExploreProgressRewardResponse response)
	{
		if (((response != null) ? response.RewardIds : null) != null && response.RewardIds.Count > 0)
		{
			ExploreProgressModel.Instance.UpdateAreaStageRewardDataList(response.RewardIds);
			EventSystem.Instance.Emit<IReadOnlyList<int>>(EEventName.OnReceiveAreaStageRewardResponse, response.RewardIds);
		}
	}

	// Token: 0x0600C9CA RID: 51658 RVA: 0x002E1570 File Offset: 0x002DF770
	public UniTask QueryOnlinePlayersAreaAsyncRequest()
	{
		ExploreProgressController.<QueryOnlinePlayersAreaAsyncRequest>d__10 <QueryOnlinePlayersAreaAsyncRequest>d__;
		<QueryOnlinePlayersAreaAsyncRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<QueryOnlinePlayersAreaAsyncRequest>d__.<>4__this = this;
		<QueryOnlinePlayersAreaAsyncRequest>d__.<>1__state = -1;
		<QueryOnlinePlayersAreaAsyncRequest>d__.<>t__builder.Start<ExploreProgressController.<QueryOnlinePlayersAreaAsyncRequest>d__10>(ref <QueryOnlinePlayersAreaAsyncRequest>d__);
		return <QueryOnlinePlayersAreaAsyncRequest>d__.<>t__builder.Task;
	}

	// Token: 0x0600C9CB RID: 51659 RVA: 0x002E15B3 File Offset: 0x002DF7B3
	private void QueryOnlinePlayersAreaResponseHandle(QueryOnlinePlayersAreaResponse response)
	{
		if (response.ErrorCode != ErrorCode.Success)
		{
			ErrorCodeConfig.Instance.GetTextByErrorId(response.ErrorCode);
			return;
		}
		ExploreProgressModel.Instance.UpdateOnlinePlayersArea(response.AreaDict.ToDictionary<int, int>());
	}

	// Token: 0x0600C9CC RID: 51660 RVA: 0x002E15E4 File Offset: 0x002DF7E4
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

	// Token: 0x17001083 RID: 4227
	// (get) Token: 0x0600C9CD RID: 51661 RVA: 0x002E162F File Offset: 0x002DF82F
	[Nullable(1)]
	public static ExploreProgressController Instance
	{
		[NullableContext(1)]
		get
		{
			return ExploreProgressController._Instance;
		}
	}

	// Token: 0x0600C9CE RID: 51662 RVA: 0x002E1636 File Offset: 0x002DF836
	[NullableContext(1)]
	public static ExploreProgressController GetOrCreateInstance()
	{
		if (ExploreProgressController._Instance == null)
		{
			ExploreProgressController.CreateInstance();
		}
		return ExploreProgressController._Instance;
	}

	// Token: 0x0600C9CF RID: 51663 RVA: 0x002E164A File Offset: 0x002DF84A
	public static bool CreateInstance()
	{
		if (ExploreProgressController._Instance != null)
		{
			return true;
		}
		ExploreProgressController._Instance = new ExploreProgressController();
		return true;
	}

	// Token: 0x0600C9D0 RID: 51664 RVA: 0x002E1660 File Offset: 0x002DF860
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600C9D1 RID: 51665 RVA: 0x002E1662 File Offset: 0x002DF862
	public static void ResetStaticDefaultValue()
	{
		ExploreProgressController._Instance = null;
	}

	// Token: 0x0600C9D2 RID: 51666 RVA: 0x002E166A File Offset: 0x002DF86A
	static ExploreProgressController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ExploreProgressController.CreateStaticDefaultValue), new Action(ExploreProgressController.ResetStaticDefaultValue));
	}

	// Token: 0x04005CE7 RID: 23783
	private static ExploreProgressController _Instance;
}
