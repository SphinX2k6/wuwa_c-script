using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02000F92 RID: 3986
[NullableContext(2)]
[Nullable(0)]
[Controller(0)]
public class FeedbackRewardController : UiControllerBase
{
	// Token: 0x06009FD0 RID: 40912 RVA: 0x002F3219 File Offset: 0x002F1419
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.GivebackInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.GivebackInfoUpdateNotify));
	}

	// Token: 0x06009FD1 RID: 40913 RVA: 0x002F3237 File Offset: 0x002F1437
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.GivebackInfoUpdateNotify);
	}

	// Token: 0x06009FD2 RID: 40914 RVA: 0x002F3249 File Offset: 0x002F1449
	protected override void OnAddEvents()
	{
		base.OnAddEvents();
		EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.WorldDone));
	}

	// Token: 0x06009FD3 RID: 40915 RVA: 0x002F3289 File Offset: 0x002F1489
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.WorldDone));
		base.OnRemoveEvents();
	}

	// Token: 0x06009FD4 RID: 40916 RVA: 0x002F32C9 File Offset: 0x002F14C9
	private void OnLoadingNetDataDone()
	{
		this.GivebackInfoRequest().Forget();
	}

	// Token: 0x06009FD5 RID: 40917 RVA: 0x002F32D6 File Offset: 0x002F14D6
	private void WorldDone()
	{
		this.TryPushSplashScreenTask(false);
	}

	// Token: 0x06009FD6 RID: 40918 RVA: 0x002F32E0 File Offset: 0x002F14E0
	private void TryPushSplashScreenTask(bool isInstantly = false)
	{
		if (this.HaveShowFeedbackRewardStartView || GameModeController.Instance.IsInInstance())
		{
			return;
		}
		List<int> canClaimRewardIds = FeedbackRewardModel.Instance.GetCanClaimRewardIds();
		if (canClaimRewardIds != null && canClaimRewardIds.Count > 0)
		{
			SplashScreenTask splashScreenTask = new SplashScreenTask(ESplashScreenSourceModuleType.FeedbackReward, ESplashScreenType.Config, delegate()
			{
				this.HaveShowFeedbackRewardStartView = true;
				List<int> canClaimRewardIds2 = FeedbackRewardModel.Instance.GetCanClaimRewardIds();
				if (canClaimRewardIds2 != null && canClaimRewardIds2.Count > 0)
				{
					UiManager.Instance.OpenView(EUiViewName.FeedbackRewardStartView, null, null);
				}
			});
			SplashScreenController.Instance.PushSplashScreenTask(splashScreenTask, isInstantly);
		}
	}

	// Token: 0x06009FD7 RID: 40919 RVA: 0x002F333C File Offset: 0x002F153C
	public UniTask GivebackInfoRequest()
	{
		FeedbackRewardController.<GivebackInfoRequest>d__8 <GivebackInfoRequest>d__;
		<GivebackInfoRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<GivebackInfoRequest>d__.<>4__this = this;
		<GivebackInfoRequest>d__.<>1__state = -1;
		<GivebackInfoRequest>d__.<>t__builder.Start<FeedbackRewardController.<GivebackInfoRequest>d__8>(ref <GivebackInfoRequest>d__);
		return <GivebackInfoRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06009FD8 RID: 40920 RVA: 0x002F337F File Offset: 0x002F157F
	private void GivebackInfoResponse(GivebackInfoResponse response, Net.CallbackStatus _)
	{
	}

	// Token: 0x06009FD9 RID: 40921 RVA: 0x002F3384 File Offset: 0x002F1584
	public UniTask GivebackRewardRequest()
	{
		FeedbackRewardController.<GivebackRewardRequest>d__10 <GivebackRewardRequest>d__;
		<GivebackRewardRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<GivebackRewardRequest>d__.<>4__this = this;
		<GivebackRewardRequest>d__.<>1__state = -1;
		<GivebackRewardRequest>d__.<>t__builder.Start<FeedbackRewardController.<GivebackRewardRequest>d__10>(ref <GivebackRewardRequest>d__);
		return <GivebackRewardRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06009FDA RID: 40922 RVA: 0x002F33C7 File Offset: 0x002F15C7
	private void GivebackRewardResponse(GivebackRewardResponse response, Net.CallbackStatus _)
	{
	}

	// Token: 0x06009FDB RID: 40923 RVA: 0x002F33CC File Offset: 0x002F15CC
	private void GivebackInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		GivebackInfoPb givebackInfo = ((GivebackInfoUpdateNotify)msg).GivebackInfo;
		if (givebackInfo == null)
		{
			return;
		}
		FeedbackRewardModel.Instance.CurrentPointCount = givebackInfo.TotalScore;
		FeedbackRewardModel.Instance.CurrentLoginDayCount = givebackInfo.ActiveDay;
		int[] array = new int[givebackInfo.RewardedIds.Count];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = givebackInfo.RewardedIds[i];
		}
		FeedbackRewardModel.Instance.RefreshFeedBackRewardMapState(array);
		FeedbackRewardModel.Instance.RefreshFeedBackTask(givebackInfo.Task);
		EventSystem.Instance.Emit(EEventName.FeedbackRewardRefresh);
		this.TryPushSplashScreenTask(true);
	}

	// Token: 0x170010F9 RID: 4345
	// (get) Token: 0x06009FDC RID: 40924 RVA: 0x002F3469 File Offset: 0x002F1669
	[Nullable(1)]
	public static FeedbackRewardController Instance
	{
		[NullableContext(1)]
		get
		{
			return FeedbackRewardController._Instance;
		}
	}

	// Token: 0x06009FDD RID: 40925 RVA: 0x002F3470 File Offset: 0x002F1670
	[NullableContext(1)]
	public static FeedbackRewardController GetOrCreateInstance()
	{
		if (FeedbackRewardController._Instance == null)
		{
			FeedbackRewardController.CreateInstance();
		}
		return FeedbackRewardController._Instance;
	}

	// Token: 0x06009FDE RID: 40926 RVA: 0x002F3484 File Offset: 0x002F1684
	public static bool CreateInstance()
	{
		if (FeedbackRewardController._Instance != null)
		{
			return true;
		}
		FeedbackRewardController._Instance = new FeedbackRewardController();
		return true;
	}

	// Token: 0x06009FDF RID: 40927 RVA: 0x002F349A File Offset: 0x002F169A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009FE0 RID: 40928 RVA: 0x002F349C File Offset: 0x002F169C
	public static void ResetStaticDefaultValue()
	{
		FeedbackRewardController._Instance = null;
	}

	// Token: 0x06009FE1 RID: 40929 RVA: 0x002F34A4 File Offset: 0x002F16A4
	static FeedbackRewardController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FeedbackRewardController.CreateStaticDefaultValue), new Action(FeedbackRewardController.ResetStaticDefaultValue));
	}

	// Token: 0x04005E7D RID: 24189
	private bool HaveShowFeedbackRewardStartView;

	// Token: 0x04005E7E RID: 24190
	private static FeedbackRewardController _Instance;
}
