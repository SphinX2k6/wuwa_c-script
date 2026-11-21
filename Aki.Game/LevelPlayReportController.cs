using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02001527 RID: 5415
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class LevelPlayReportController : UiControllerBase
{
	// Token: 0x0600D89F RID: 55455 RVA: 0x004037D8 File Offset: 0x004019D8
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.LevelPlayGainRewardInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnLevelPlayGainRewardInfoNotify));
	}

	// Token: 0x0600D8A0 RID: 55456 RVA: 0x004037F6 File Offset: 0x004019F6
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.LevelPlayGainRewardInfoNotify);
	}

	// Token: 0x0600D8A1 RID: 55457 RVA: 0x00403808 File Offset: 0x00401A08
	[NullableContext(0)]
	public UniTask<bool> RequestSimpleTrackReportAsync()
	{
		LevelPlayReportController.<RequestSimpleTrackReportAsync>d__2 <RequestSimpleTrackReportAsync>d__;
		<RequestSimpleTrackReportAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestSimpleTrackReportAsync>d__.<>1__state = -1;
		<RequestSimpleTrackReportAsync>d__.<>t__builder.Start<LevelPlayReportController.<RequestSimpleTrackReportAsync>d__2>(ref <RequestSimpleTrackReportAsync>d__);
		return <RequestSimpleTrackReportAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D8A2 RID: 55458 RVA: 0x00403844 File Offset: 0x00401A44
	public UniTask CheckAndRequestLevelPlayVarAsync(int instId, int levelPlayId)
	{
		LevelPlayReportController.<CheckAndRequestLevelPlayVarAsync>d__3 <CheckAndRequestLevelPlayVarAsync>d__;
		<CheckAndRequestLevelPlayVarAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckAndRequestLevelPlayVarAsync>d__.<>4__this = this;
		<CheckAndRequestLevelPlayVarAsync>d__.instId = instId;
		<CheckAndRequestLevelPlayVarAsync>d__.levelPlayId = levelPlayId;
		<CheckAndRequestLevelPlayVarAsync>d__.<>1__state = -1;
		<CheckAndRequestLevelPlayVarAsync>d__.<>t__builder.Start<LevelPlayReportController.<CheckAndRequestLevelPlayVarAsync>d__3>(ref <CheckAndRequestLevelPlayVarAsync>d__);
		return <CheckAndRequestLevelPlayVarAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D8A3 RID: 55459 RVA: 0x00403898 File Offset: 0x00401A98
	public UniTask RequestLevelPlayVarAsync(int instId, int levelPlayId)
	{
		LevelPlayReportController.<RequestLevelPlayVarAsync>d__4 <RequestLevelPlayVarAsync>d__;
		<RequestLevelPlayVarAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestLevelPlayVarAsync>d__.instId = instId;
		<RequestLevelPlayVarAsync>d__.levelPlayId = levelPlayId;
		<RequestLevelPlayVarAsync>d__.<>1__state = -1;
		<RequestLevelPlayVarAsync>d__.<>t__builder.Start<LevelPlayReportController.<RequestLevelPlayVarAsync>d__4>(ref <RequestLevelPlayVarAsync>d__);
		return <RequestLevelPlayVarAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D8A4 RID: 55460 RVA: 0x004038E4 File Offset: 0x00401AE4
	public UniTask RequestPlayPointStateAsync(int areaId, int sceneId)
	{
		LevelPlayReportController.<RequestPlayPointStateAsync>d__5 <RequestPlayPointStateAsync>d__;
		<RequestPlayPointStateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestPlayPointStateAsync>d__.areaId = areaId;
		<RequestPlayPointStateAsync>d__.sceneId = sceneId;
		<RequestPlayPointStateAsync>d__.<>1__state = -1;
		<RequestPlayPointStateAsync>d__.<>t__builder.Start<LevelPlayReportController.<RequestPlayPointStateAsync>d__5>(ref <RequestPlayPointStateAsync>d__);
		return <RequestPlayPointStateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D8A5 RID: 55461 RVA: 0x00403930 File Offset: 0x00401B30
	public UniTask RequestSingleLevelPlayStateListAsync(int instId, int levelPlayId)
	{
		LevelPlayReportController.<RequestSingleLevelPlayStateListAsync>d__6 <RequestSingleLevelPlayStateListAsync>d__;
		<RequestSingleLevelPlayStateListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestSingleLevelPlayStateListAsync>d__.<>4__this = this;
		<RequestSingleLevelPlayStateListAsync>d__.instId = instId;
		<RequestSingleLevelPlayStateListAsync>d__.levelPlayId = levelPlayId;
		<RequestSingleLevelPlayStateListAsync>d__.<>1__state = -1;
		<RequestSingleLevelPlayStateListAsync>d__.<>t__builder.Start<LevelPlayReportController.<RequestSingleLevelPlayStateListAsync>d__6>(ref <RequestSingleLevelPlayStateListAsync>d__);
		return <RequestSingleLevelPlayStateListAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D8A6 RID: 55462 RVA: 0x00403984 File Offset: 0x00401B84
	public UniTask RequestLevelPlayStateListAsync(List<InstLevelPlayStateReq> requestList)
	{
		LevelPlayReportController.<RequestLevelPlayStateListAsync>d__7 <RequestLevelPlayStateListAsync>d__;
		<RequestLevelPlayStateListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestLevelPlayStateListAsync>d__.requestList = requestList;
		<RequestLevelPlayStateListAsync>d__.<>1__state = -1;
		<RequestLevelPlayStateListAsync>d__.<>t__builder.Start<LevelPlayReportController.<RequestLevelPlayStateListAsync>d__7>(ref <RequestLevelPlayStateListAsync>d__);
		return <RequestLevelPlayStateListAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D8A7 RID: 55463 RVA: 0x004039C8 File Offset: 0x00401BC8
	public UniTask RequestLevelPlayRewardsAsync(int instId, int levelPlayId)
	{
		LevelPlayReportController.<RequestLevelPlayRewardsAsync>d__8 <RequestLevelPlayRewardsAsync>d__;
		<RequestLevelPlayRewardsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestLevelPlayRewardsAsync>d__.instId = instId;
		<RequestLevelPlayRewardsAsync>d__.levelPlayId = levelPlayId;
		<RequestLevelPlayRewardsAsync>d__.<>1__state = -1;
		<RequestLevelPlayRewardsAsync>d__.<>t__builder.Start<LevelPlayReportController.<RequestLevelPlayRewardsAsync>d__8>(ref <RequestLevelPlayRewardsAsync>d__);
		return <RequestLevelPlayRewardsAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D8A8 RID: 55464 RVA: 0x00403A14 File Offset: 0x00401C14
	[NullableContext(2)]
	private void OnLevelPlayGainRewardInfoNotify(IMessage msg, Net.CallbackStatus _)
	{
		LevelPlayGainRewardInfoNotify data = (LevelPlayGainRewardInfoNotify)msg;
		LevelPlayReportModel.Instance.UpdateLevelPlayRewardMsgByNotify(data);
	}

	// Token: 0x17001423 RID: 5155
	// (get) Token: 0x0600D8A9 RID: 55465 RVA: 0x00403A33 File Offset: 0x00401C33
	public static LevelPlayReportController Instance
	{
		get
		{
			return LevelPlayReportController._Instance;
		}
	}

	// Token: 0x0600D8AA RID: 55466 RVA: 0x00403A3A File Offset: 0x00401C3A
	public static LevelPlayReportController GetOrCreateInstance()
	{
		if (LevelPlayReportController._Instance == null)
		{
			LevelPlayReportController.CreateInstance();
		}
		return LevelPlayReportController._Instance;
	}

	// Token: 0x0600D8AB RID: 55467 RVA: 0x00403A4E File Offset: 0x00401C4E
	public static bool CreateInstance()
	{
		if (LevelPlayReportController._Instance != null)
		{
			return true;
		}
		LevelPlayReportController._Instance = new LevelPlayReportController();
		return true;
	}

	// Token: 0x0600D8AC RID: 55468 RVA: 0x00403A64 File Offset: 0x00401C64
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600D8AD RID: 55469 RVA: 0x00403A66 File Offset: 0x00401C66
	public static void ResetStaticDefaultValue()
	{
		LevelPlayReportController._Instance = null;
	}

	// Token: 0x0600D8AE RID: 55470 RVA: 0x00403A6E File Offset: 0x00401C6E
	static LevelPlayReportController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LevelPlayReportController.CreateStaticDefaultValue), new Action(LevelPlayReportController.ResetStaticDefaultValue));
	}

	// Token: 0x0400792B RID: 31019
	[Nullable(2)]
	private static LevelPlayReportController _Instance;
}
