using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02001C51 RID: 7249
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class GachaAccumulateController : UiControllerBase
{
	// Token: 0x0600DAAB RID: 55979 RVA: 0x0032C7A3 File Offset: 0x0032A9A3
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x0600DAAC RID: 55980 RVA: 0x0032C7A6 File Offset: 0x0032A9A6
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnOpenGachaChanged, new Action(this.OnOpenGachaChanged));
	}

	// Token: 0x0600DAAD RID: 55981 RVA: 0x0032C7C4 File Offset: 0x0032A9C4
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnOpenGachaChanged, new Action(this.OnOpenGachaChanged));
	}

	// Token: 0x0600DAAE RID: 55982 RVA: 0x0032C7E2 File Offset: 0x0032A9E2
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.GachaAccumulateInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnGachaAccumulateInfoNotify));
	}

	// Token: 0x0600DAAF RID: 55983 RVA: 0x0032C800 File Offset: 0x0032AA00
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.GachaAccumulateInfoNotify);
	}

	// Token: 0x0600DAB0 RID: 55984 RVA: 0x0032C812 File Offset: 0x0032AA12
	private void OnOpenGachaChanged()
	{
		this.OnOpenGachaChangedAsync().Forget();
	}

	// Token: 0x0600DAB1 RID: 55985 RVA: 0x0032C820 File Offset: 0x0032AA20
	private UniTask OnOpenGachaChangedAsync()
	{
		GachaAccumulateController.<OnOpenGachaChangedAsync>d__6 <OnOpenGachaChangedAsync>d__;
		<OnOpenGachaChangedAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnOpenGachaChangedAsync>d__.<>4__this = this;
		<OnOpenGachaChangedAsync>d__.<>1__state = -1;
		<OnOpenGachaChangedAsync>d__.<>t__builder.Start<GachaAccumulateController.<OnOpenGachaChangedAsync>d__6>(ref <OnOpenGachaChangedAsync>d__);
		return <OnOpenGachaChangedAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DAB2 RID: 55986 RVA: 0x0032C864 File Offset: 0x0032AA64
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

	// Token: 0x0600DAB3 RID: 55987 RVA: 0x0032C8D4 File Offset: 0x0032AAD4
	public UniTask RequestAccumulateInfoAsync(int accumulateId)
	{
		GachaAccumulateController.<RequestAccumulateInfoAsync>d__8 <RequestAccumulateInfoAsync>d__;
		<RequestAccumulateInfoAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestAccumulateInfoAsync>d__.accumulateId = accumulateId;
		<RequestAccumulateInfoAsync>d__.<>1__state = -1;
		<RequestAccumulateInfoAsync>d__.<>t__builder.Start<GachaAccumulateController.<RequestAccumulateInfoAsync>d__8>(ref <RequestAccumulateInfoAsync>d__);
		return <RequestAccumulateInfoAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DAB4 RID: 55988 RVA: 0x0032C918 File Offset: 0x0032AB18
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

	// Token: 0x0600DAB5 RID: 55989 RVA: 0x0032C96C File Offset: 0x0032AB6C
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

	// Token: 0x170011DC RID: 4572
	// (get) Token: 0x0600DAB6 RID: 55990 RVA: 0x0032C9A7 File Offset: 0x0032ABA7
	public static GachaAccumulateController Instance
	{
		get
		{
			return GachaAccumulateController._Instance;
		}
	}

	// Token: 0x0600DAB7 RID: 55991 RVA: 0x0032C9AE File Offset: 0x0032ABAE
	public static GachaAccumulateController GetOrCreateInstance()
	{
		if (GachaAccumulateController._Instance == null)
		{
			GachaAccumulateController.CreateInstance();
		}
		return GachaAccumulateController._Instance;
	}

	// Token: 0x0600DAB8 RID: 55992 RVA: 0x0032C9C2 File Offset: 0x0032ABC2
	public static bool CreateInstance()
	{
		if (GachaAccumulateController._Instance != null)
		{
			return true;
		}
		GachaAccumulateController._Instance = new GachaAccumulateController();
		return true;
	}

	// Token: 0x0600DAB9 RID: 55993 RVA: 0x0032C9D8 File Offset: 0x0032ABD8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600DABA RID: 55994 RVA: 0x0032C9DA File Offset: 0x0032ABDA
	public static void ResetStaticDefaultValue()
	{
		GachaAccumulateController._Instance = null;
	}

	// Token: 0x0600DABB RID: 55995 RVA: 0x0032C9E2 File Offset: 0x0032ABE2
	static GachaAccumulateController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GachaAccumulateController.CreateStaticDefaultValue), new Action(GachaAccumulateController.ResetStaticDefaultValue));
	}

	// Token: 0x04006406 RID: 25606
	[Nullable(2)]
	private static GachaAccumulateController _Instance;
}
