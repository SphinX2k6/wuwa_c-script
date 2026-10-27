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

// Token: 0x02001AD3 RID: 6867
[NullableContext(2)]
[Nullable(0)]
[Controller(0)]
public class FeedbackRewardController : UiControllerBase
{
	// Token: 0x0600CBBF RID: 52159 RVA: 0x002E80C5 File Offset: 0x002E62C5
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.GivebackInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.GivebackInfoUpdateNotify));
	}

	// Token: 0x0600CBC0 RID: 52160 RVA: 0x002E80E3 File Offset: 0x002E62E3
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.GivebackInfoUpdateNotify);
	}

	// Token: 0x0600CBC1 RID: 52161 RVA: 0x002E80F5 File Offset: 0x002E62F5
	protected override void OnAddEvents()
	{
		base.OnAddEvents();
		EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.WorldDone));
	}

	// Token: 0x0600CBC2 RID: 52162 RVA: 0x002E8135 File Offset: 0x002E6335
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.WorldDone));
		base.OnRemoveEvents();
	}

	// Token: 0x0600CBC3 RID: 52163 RVA: 0x002E8175 File Offset: 0x002E6375
	private void OnLoadingNetDataDone()
	{
		this.GivebackInfoRequest().Forget();
	}

	// Token: 0x0600CBC4 RID: 52164 RVA: 0x002E8182 File Offset: 0x002E6382
	private void WorldDone()
	{
		this.TryPushSplashScreenTask(false);
	}

	// Token: 0x0600CBC5 RID: 52165 RVA: 0x002E818C File Offset: 0x002E638C
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

	// Token: 0x0600CBC6 RID: 52166 RVA: 0x002E81E8 File Offset: 0x002E63E8
	public UniTask GivebackInfoRequest()
	{
		FeedbackRewardController.<GivebackInfoRequest>d__8 <GivebackInfoRequest>d__;
		<GivebackInfoRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<GivebackInfoRequest>d__.<>4__this = this;
		<GivebackInfoRequest>d__.<>1__state = -1;
		<GivebackInfoRequest>d__.<>t__builder.Start<FeedbackRewardController.<GivebackInfoRequest>d__8>(ref <GivebackInfoRequest>d__);
		return <GivebackInfoRequest>d__.<>t__builder.Task;
	}

	// Token: 0x0600CBC7 RID: 52167 RVA: 0x002E822B File Offset: 0x002E642B
	private void GivebackInfoResponse(GivebackInfoResponse response, Net.CallbackStatus _)
	{
	}

	// Token: 0x0600CBC8 RID: 52168 RVA: 0x002E8230 File Offset: 0x002E6430
	public UniTask GivebackRewardRequest()
	{
		FeedbackRewardController.<GivebackRewardRequest>d__10 <GivebackRewardRequest>d__;
		<GivebackRewardRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<GivebackRewardRequest>d__.<>4__this = this;
		<GivebackRewardRequest>d__.<>1__state = -1;
		<GivebackRewardRequest>d__.<>t__builder.Start<FeedbackRewardController.<GivebackRewardRequest>d__10>(ref <GivebackRewardRequest>d__);
		return <GivebackRewardRequest>d__.<>t__builder.Task;
	}

	// Token: 0x0600CBC9 RID: 52169 RVA: 0x002E8273 File Offset: 0x002E6473
	private void GivebackRewardResponse(GivebackRewardResponse response, Net.CallbackStatus _)
	{
	}

	// Token: 0x0600CBCA RID: 52170 RVA: 0x002E8278 File Offset: 0x002E6478
	private void GivebackInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		GivebackInfoPb givebackInfo = ((GivebackInfoUpdateNotify)msg).GivebackInfo;
		if (givebackInfo == null)
		{
			return;
		}
		FeedbackRewardModel.Instance.CurrentPointCount = givebackInfo.TotalScore;
		FeedbackRewardModel.Instance.CurrentLoginDayCount = givebackInfo.ActiveDay;
		FeedbackRewardModel.Instance.RefreshFeedBackRewardMapState(givebackInfo.RewardedIds.ToArray<int>());
		FeedbackRewardModel.Instance.RefreshFeedBackTask(givebackInfo.Task.ToArray<GivebackTaskPb>());
		EventSystem.Instance.Emit(EEventName.FeedbackRewardRefresh);
		this.TryPushSplashScreenTask(true);
	}

	// Token: 0x170010D4 RID: 4308
	// (get) Token: 0x0600CBCB RID: 52171 RVA: 0x002E82F6 File Offset: 0x002E64F6
	[Nullable(1)]
	public static FeedbackRewardController Instance
	{
		[NullableContext(1)]
		get
		{
			return FeedbackRewardController._Instance;
		}
	}

	// Token: 0x0600CBCC RID: 52172 RVA: 0x002E82FD File Offset: 0x002E64FD
	[NullableContext(1)]
	public static FeedbackRewardController GetOrCreateInstance()
	{
		if (FeedbackRewardController._Instance == null)
		{
			FeedbackRewardController.CreateInstance();
		}
		return FeedbackRewardController._Instance;
	}

	// Token: 0x0600CBCD RID: 52173 RVA: 0x002E8311 File Offset: 0x002E6511
	public static bool CreateInstance()
	{
		if (FeedbackRewardController._Instance != null)
		{
			return true;
		}
		FeedbackRewardController._Instance = new FeedbackRewardController();
		return true;
	}

	// Token: 0x0600CBCE RID: 52174 RVA: 0x002E8327 File Offset: 0x002E6527
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600CBCF RID: 52175 RVA: 0x002E8329 File Offset: 0x002E6529
	public static void ResetStaticDefaultValue()
	{
		FeedbackRewardController._Instance = null;
	}

	// Token: 0x0600CBD0 RID: 52176 RVA: 0x002E8331 File Offset: 0x002E6531
	static FeedbackRewardController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FeedbackRewardController.CreateStaticDefaultValue), new Action(FeedbackRewardController.ResetStaticDefaultValue));
	}

	// Token: 0x04005DAE RID: 23982
	private bool HaveShowFeedbackRewardStartView;

	// Token: 0x04005DAF RID: 23983
	private static FeedbackRewardController _Instance;
}
