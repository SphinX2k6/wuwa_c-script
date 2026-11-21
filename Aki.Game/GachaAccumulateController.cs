using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02001110 RID: 4368
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class GachaAccumulateController : UiControllerBase
{
	// Token: 0x0600AEC1 RID: 44737 RVA: 0x00337BAB File Offset: 0x00335DAB
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x0600AEC2 RID: 44738 RVA: 0x00337BAE File Offset: 0x00335DAE
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnOpenGachaChanged, new Action(this.OnOpenGachaChanged));
	}

	// Token: 0x0600AEC3 RID: 44739 RVA: 0x00337BCC File Offset: 0x00335DCC
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnOpenGachaChanged, new Action(this.OnOpenGachaChanged));
	}

	// Token: 0x0600AEC4 RID: 44740 RVA: 0x00337BEA File Offset: 0x00335DEA
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.GachaAccumulateInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnGachaAccumulateInfoNotify));
	}

	// Token: 0x0600AEC5 RID: 44741 RVA: 0x00337C08 File Offset: 0x00335E08
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.GachaAccumulateInfoNotify);
	}

	// Token: 0x0600AEC6 RID: 44742 RVA: 0x00337C1A File Offset: 0x00335E1A
	private void OnOpenGachaChanged()
	{
		this.OnOpenGachaChangedAsync().Forget();
	}

	// Token: 0x0600AEC7 RID: 44743 RVA: 0x00337C28 File Offset: 0x00335E28
	private UniTask OnOpenGachaChangedAsync()
	{
		GachaAccumulateController.<OnOpenGachaChangedAsync>d__6 <OnOpenGachaChangedAsync>d__;
		<OnOpenGachaChangedAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnOpenGachaChangedAsync>d__.<>4__this = this;
		<OnOpenGachaChangedAsync>d__.<>1__state = -1;
		<OnOpenGachaChangedAsync>d__.<>t__builder.Start<GachaAccumulateController.<OnOpenGachaChangedAsync>d__6>(ref <OnOpenGachaChangedAsync>d__);
		return <OnOpenGachaChangedAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AEC8 RID: 44744 RVA: 0x00337C6C File Offset: 0x00335E6C
	[NullableContext(2)]
	private void OnGachaAccumulateInfoNotify(IMessage msg, Net.CallbackStatus _)
	{
		GachaAccumulateInfo gachaAccumulateInfo = ((GachaAccumulateInfoNotify)msg).GachaAccumulateInfo;
		if (gachaAccumulateInfo == null)
		{
			Log.Instance.Error(ELogModule.Gacha, ELogAuthor.YZY, "[GachaAccumulateController] Notify 中 GachaAccumulateInfo 为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		GachaAccumulateModel.Instance.UpdateAccumulateInfo(gachaAccumulateInfo);
		EventSystem.Instance.Emit(EEventName.GachaAccumulateRedDot);
		EventSystem.Instance.Emit<int>(EEventName.GachaAccumulateDataUpdate, gachaAccumulateInfo.GachaAccumulateId);
	}

	// Token: 0x0600AEC9 RID: 44745 RVA: 0x00337CDC File Offset: 0x00335EDC
	public UniTask RequestAccumulateInfoAsync(int accumulateId)
	{
		GachaAccumulateController.<RequestAccumulateInfoAsync>d__8 <RequestAccumulateInfoAsync>d__;
		<RequestAccumulateInfoAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestAccumulateInfoAsync>d__.accumulateId = accumulateId;
		<RequestAccumulateInfoAsync>d__.<>1__state = -1;
		<RequestAccumulateInfoAsync>d__.<>t__builder.Start<GachaAccumulateController.<RequestAccumulateInfoAsync>d__8>(ref <RequestAccumulateInfoAsync>d__);
		return <RequestAccumulateInfoAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AECA RID: 44746 RVA: 0x00337D20 File Offset: 0x00335F20
	[NullableContext(0)]
	public UniTask<bool> ClaimAccumulateRewardAsync(int accumulateId, [Nullable(1)] int[] rewardIds, [Nullable(2)] int[] selectedIds = null)
	{
		GachaAccumulateController.<ClaimAccumulateRewardAsync>d__9 <ClaimAccumulateRewardAsync>d__;
		<ClaimAccumulateRewardAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<ClaimAccumulateRewardAsync>d__.accumulateId = accumulateId;
		<ClaimAccumulateRewardAsync>d__.rewardIds = rewardIds;
		<ClaimAccumulateRewardAsync>d__.selectedIds = selectedIds;
		<ClaimAccumulateRewardAsync>d__.<>1__state = -1;
		<ClaimAccumulateRewardAsync>d__.<>t__builder.Start<GachaAccumulateController.<ClaimAccumulateRewardAsync>d__9>(ref <ClaimAccumulateRewardAsync>d__);
		return <ClaimAccumulateRewardAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AECB RID: 44747 RVA: 0x00337D74 File Offset: 0x00335F74
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public UniTask<ResonantChainOptionLimitInfo> GetResonantChainOptionLimitInfoAsync()
	{
		GachaAccumulateController.<GetResonantChainOptionLimitInfoAsync>d__10 <GetResonantChainOptionLimitInfoAsync>d__;
		<GetResonantChainOptionLimitInfoAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<ResonantChainOptionLimitInfo>.Create();
		<GetResonantChainOptionLimitInfoAsync>d__.<>1__state = -1;
		<GetResonantChainOptionLimitInfoAsync>d__.<>t__builder.Start<GachaAccumulateController.<GetResonantChainOptionLimitInfoAsync>d__10>(ref <GetResonantChainOptionLimitInfoAsync>d__);
		return <GetResonantChainOptionLimitInfoAsync>d__.<>t__builder.Task;
	}

	// Token: 0x17001202 RID: 4610
	// (get) Token: 0x0600AECC RID: 44748 RVA: 0x00337DAF File Offset: 0x00335FAF
	public static GachaAccumulateController Instance
	{
		get
		{
			return GachaAccumulateController._Instance;
		}
	}

	// Token: 0x0600AECD RID: 44749 RVA: 0x00337DB6 File Offset: 0x00335FB6
	public static GachaAccumulateController GetOrCreateInstance()
	{
		if (GachaAccumulateController._Instance == null)
		{
			GachaAccumulateController.CreateInstance();
		}
		return GachaAccumulateController._Instance;
	}

	// Token: 0x0600AECE RID: 44750 RVA: 0x00337DCA File Offset: 0x00335FCA
	public static bool CreateInstance()
	{
		if (GachaAccumulateController._Instance != null)
		{
			return true;
		}
		GachaAccumulateController._Instance = new GachaAccumulateController();
		return true;
	}

	// Token: 0x0600AECF RID: 44751 RVA: 0x00337DE0 File Offset: 0x00335FE0
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600AED0 RID: 44752 RVA: 0x00337DE2 File Offset: 0x00335FE2
	public static void ResetStaticDefaultValue()
	{
		GachaAccumulateController._Instance = null;
	}

	// Token: 0x0600AED1 RID: 44753 RVA: 0x00337DEA File Offset: 0x00335FEA
	static GachaAccumulateController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GachaAccumulateController.CreateStaticDefaultValue), new Action(GachaAccumulateController.ResetStaticDefaultValue));
	}

	// Token: 0x040064D8 RID: 25816
	[Nullable(2)]
	private static GachaAccumulateController _Instance;
}
