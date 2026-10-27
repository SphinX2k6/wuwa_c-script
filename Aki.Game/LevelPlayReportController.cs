using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02002054 RID: 8276
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class LevelPlayReportController : UiControllerBase
{
	// Token: 0x06010438 RID: 66616 RVA: 0x003F72E0 File Offset: 0x003F54E0
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.LevelPlayGainRewardInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnLevelPlayGainRewardInfoNotify));
	}

	// Token: 0x06010439 RID: 66617 RVA: 0x003F72FE File Offset: 0x003F54FE
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.LevelPlayGainRewardInfoNotify);
	}

	// Token: 0x0601043A RID: 66618 RVA: 0x003F7310 File Offset: 0x003F5510
	[NullableContext(0)]
	public UniTask<bool> RequestSimpleTrackReportAsync()
	{
		LevelPlayReportController.<RequestSimpleTrackReportAsync>d__2 <RequestSimpleTrackReportAsync>d__;
		<RequestSimpleTrackReportAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestSimpleTrackReportAsync>d__.<>1__state = -1;
		<RequestSimpleTrackReportAsync>d__.<>t__builder.Start<LevelPlayReportController.<RequestSimpleTrackReportAsync>d__2>(ref <RequestSimpleTrackReportAsync>d__);
		return <RequestSimpleTrackReportAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601043B RID: 66619 RVA: 0x003F734C File Offset: 0x003F554C
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

	// Token: 0x0601043C RID: 66620 RVA: 0x003F73A0 File Offset: 0x003F55A0
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

	// Token: 0x0601043D RID: 66621 RVA: 0x003F73EC File Offset: 0x003F55EC
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

	// Token: 0x0601043E RID: 66622 RVA: 0x003F7438 File Offset: 0x003F5638
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

	// Token: 0x0601043F RID: 66623 RVA: 0x003F748C File Offset: 0x003F568C
	public UniTask RequestLevelPlayStateListAsync(List<InstLevelPlayStateReq> requestList)
	{
		LevelPlayReportController.<RequestLevelPlayStateListAsync>d__7 <RequestLevelPlayStateListAsync>d__;
		<RequestLevelPlayStateListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestLevelPlayStateListAsync>d__.requestList = requestList;
		<RequestLevelPlayStateListAsync>d__.<>1__state = -1;
		<RequestLevelPlayStateListAsync>d__.<>t__builder.Start<LevelPlayReportController.<RequestLevelPlayStateListAsync>d__7>(ref <RequestLevelPlayStateListAsync>d__);
		return <RequestLevelPlayStateListAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010440 RID: 66624 RVA: 0x003F74D0 File Offset: 0x003F56D0
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

	// Token: 0x06010441 RID: 66625 RVA: 0x003F751C File Offset: 0x003F571C
	[NullableContext(2)]
	private void OnLevelPlayGainRewardInfoNotify(IMessage msg, Net.CallbackStatus _)
	{
		LevelPlayGainRewardInfoNotify data = (LevelPlayGainRewardInfoNotify)msg;
		LevelPlayReportModel.Instance.UpdateLevelPlayRewardMsgByNotify(data);
	}

	// Token: 0x170013F6 RID: 5110
	// (get) Token: 0x06010442 RID: 66626 RVA: 0x003F753B File Offset: 0x003F573B
	public static LevelPlayReportController Instance
	{
		get
		{
			return LevelPlayReportController._Instance;
		}
	}

	// Token: 0x06010443 RID: 66627 RVA: 0x003F7542 File Offset: 0x003F5742
	public static LevelPlayReportController GetOrCreateInstance()
	{
		if (LevelPlayReportController._Instance == null)
		{
			LevelPlayReportController.CreateInstance();
		}
		return LevelPlayReportController._Instance;
	}

	// Token: 0x06010444 RID: 66628 RVA: 0x003F7556 File Offset: 0x003F5756
	public static bool CreateInstance()
	{
		if (LevelPlayReportController._Instance != null)
		{
			return true;
		}
		LevelPlayReportController._Instance = new LevelPlayReportController();
		return true;
	}

	// Token: 0x06010445 RID: 66629 RVA: 0x003F756C File Offset: 0x003F576C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06010446 RID: 66630 RVA: 0x003F756E File Offset: 0x003F576E
	public static void ResetStaticDefaultValue()
	{
		LevelPlayReportController._Instance = null;
	}

	// Token: 0x06010447 RID: 66631 RVA: 0x003F7576 File Offset: 0x003F5776
	static LevelPlayReportController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LevelPlayReportController.CreateStaticDefaultValue), new Action(LevelPlayReportController.ResetStaticDefaultValue));
	}

	// Token: 0x04007842 RID: 30786
	[Nullable(2)]
	private static LevelPlayReportController _Instance;
}
