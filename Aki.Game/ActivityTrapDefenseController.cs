using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.TrapDefense;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x020009E7 RID: 2535
[NullableContext(1)]
[Nullable(0)]
public class ActivityTrapDefenseController : ActivityControllerBase
{
	// Token: 0x06006E93 RID: 28307 RVA: 0x002214E3 File Offset: 0x0021F6E3
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06006E94 RID: 28308 RVA: 0x002214E6 File Offset: 0x0021F6E6
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
	}

	// Token: 0x06006E95 RID: 28309 RVA: 0x00221504 File Offset: 0x0021F704
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
	}

	// Token: 0x06006E96 RID: 28310 RVA: 0x00221522 File Offset: 0x0021F722
	private void OnWorldDone()
	{
		if (TrapDefenseModel.Instance.NeedOpenActivityMainView)
		{
			this.AddMainViewSplashTask();
		}
	}

	// Token: 0x06006E97 RID: 28311 RVA: 0x00221538 File Offset: 0x0021F738
	private void AddMainViewSplashTask()
	{
		SplashScreenTask splashScreenTask = new SplashScreenTask(ESplashScreenSourceModuleType.None, ESplashScreenType.Other, delegate()
		{
			UiManager.Instance.OpenView(EUiViewName.TrapDefenseMainView, null, null);
		});
		SplashScreenController.Instance.PushSplashScreenTask(splashScreenTask, false);
	}

	// Token: 0x06006E98 RID: 28312 RVA: 0x00221578 File Offset: 0x0021F778
	[NullableContext(0)]
	protected override UniTask<bool> OnOpenSubView(EUiViewName viewName, int activityId = 0)
	{
		ActivityTrapDefenseController.<OnOpenSubView>d__6 <OnOpenSubView>d__;
		<OnOpenSubView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OnOpenSubView>d__.viewName = viewName;
		<OnOpenSubView>d__.<>1__state = -1;
		<OnOpenSubView>d__.<>t__builder.Start<ActivityTrapDefenseController.<OnOpenSubView>d__6>(ref <OnOpenSubView>d__);
		return <OnOpenSubView>d__.<>t__builder.Task;
	}

	// Token: 0x06006E99 RID: 28313 RVA: 0x002215BB File Offset: 0x0021F7BB
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06006E9A RID: 28314 RVA: 0x002215BD File Offset: 0x0021F7BD
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_TowerDefenseActivityMain";
	}

	// Token: 0x06006E9B RID: 28315 RVA: 0x002215C4 File Offset: 0x0021F7C4
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewTrapDefense();
	}

	// Token: 0x06006E9C RID: 28316 RVA: 0x002215CB File Offset: 0x0021F7CB
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.Data = new ActivityTrapDefenseData();
		return this.Data;
	}

	// Token: 0x06006E9D RID: 28317 RVA: 0x002215E0 File Offset: 0x0021F7E0
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.TrapDefenseChallengeUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TrapDefenseChallengeUpdateNotify response = (TrapDefenseChallengeUpdateNotify)msg;
			TrapDefenseModel instance = TrapDefenseModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.ProtoChallengeUpdateNotify(response);
		});
		Net.Instance.Register(ENotifyMessageId.TrapDefenseRewardUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TrapDefenseRewardUpdateNotify response = (TrapDefenseRewardUpdateNotify)msg;
			TrapDefenseModel instance = TrapDefenseModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.ProtoRewardUpdateNotify(response);
		});
		Net.Instance.Register(ENotifyMessageId.TrapDefenseSpecialRewardUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TrapDefenseSpecialRewardUpdateNotify response = (TrapDefenseSpecialRewardUpdateNotify)msg;
			TrapDefenseModel instance = TrapDefenseModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.ProtoSpecialRewardUpdateNotify(response);
		});
		Net.Instance.Register(ENotifyMessageId.TrapDefenseTechUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TrapDefenseTechUpdateNotify response = (TrapDefenseTechUpdateNotify)msg;
			TrapDefenseModel instance = TrapDefenseModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.ProtoTechUpdateNotify(response);
		});
		Net.Instance.Register(ENotifyMessageId.TrapDefenseBdUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TrapDefenseBdUpdateNotify response = (TrapDefenseBdUpdateNotify)msg;
			TrapDefenseModel instance = TrapDefenseModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.ProtoBdUpdateNotify(response);
		});
		Net.Instance.Register(ENotifyMessageId.TrapDefenseBdGroupUnlockNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TrapDefenseBdGroupUnlockNotify response = (TrapDefenseBdGroupUnlockNotify)msg;
			TrapDefenseModel instance = TrapDefenseModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.ProtoBdBuffUpdateNotify(response);
		});
		Net.Instance.Register(ENotifyMessageId.TrapDefenseTechPointUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TrapDefenseTechPointUpdateNotify response = (TrapDefenseTechPointUpdateNotify)msg;
			TrapDefenseModel instance = TrapDefenseModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.ProtoTechPointUpdateNotify(response);
		});
	}

	// Token: 0x06006E9E RID: 28318 RVA: 0x00221738 File Offset: 0x0021F938
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.TrapDefenseChallengeUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.TrapDefenseRewardUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.TrapDefenseSpecialRewardUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.TrapDefenseTechUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.TrapDefenseBdUpdateNotify);
	}

	// Token: 0x06006E9F RID: 28319 RVA: 0x00221798 File Offset: 0x0021F998
	public void RefreshActivityRedDot()
	{
		ActivityTrapDefenseData data = this.Data;
		int? num = (data != null) ? new int?(data.Id) : null;
		if (num != null)
		{
			int? num2 = num;
			int num3 = 0;
			if (!(num2.GetValueOrDefault() == num3 & num2 != null))
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, num.Value);
			}
		}
	}

	// Token: 0x06006EA0 RID: 28320 RVA: 0x002217FD File Offset: 0x0021F9FD
	public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
	{
		UiManager.Instance.OpenView(EUiViewName.TrapDefenseActivityUnlockView, null, null);
	}

	// Token: 0x17000D6E RID: 3438
	// (get) Token: 0x06006EA1 RID: 28321 RVA: 0x00221810 File Offset: 0x0021FA10
	public static ActivityTrapDefenseController Instance
	{
		get
		{
			return ActivityTrapDefenseController._Instance;
		}
	}

	// Token: 0x06006EA2 RID: 28322 RVA: 0x00221817 File Offset: 0x0021FA17
	public static ActivityTrapDefenseController GetOrCreateInstance()
	{
		if (ActivityTrapDefenseController._Instance == null)
		{
			ActivityTrapDefenseController.CreateInstance();
		}
		return ActivityTrapDefenseController._Instance;
	}

	// Token: 0x06006EA3 RID: 28323 RVA: 0x0022182B File Offset: 0x0021FA2B
	public static bool CreateInstance()
	{
		if (ActivityTrapDefenseController._Instance != null)
		{
			return true;
		}
		ActivityTrapDefenseController._Instance = new ActivityTrapDefenseController();
		return true;
	}

	// Token: 0x06006EA4 RID: 28324 RVA: 0x00221841 File Offset: 0x0021FA41
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006EA5 RID: 28325 RVA: 0x00221843 File Offset: 0x0021FA43
	public static void ResetStaticDefaultValue()
	{
		ActivityTrapDefenseController._Instance = null;
	}

	// Token: 0x06006EA6 RID: 28326 RVA: 0x0022184B File Offset: 0x0021FA4B
	static ActivityTrapDefenseController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityTrapDefenseController.CreateStaticDefaultValue), new Action(ActivityTrapDefenseController.ResetStaticDefaultValue));
	}

	// Token: 0x040044B5 RID: 17589
	[Nullable(2)]
	public ActivityTrapDefenseData Data;

	// Token: 0x040044B6 RID: 17590
	[Nullable(2)]
	private static ActivityTrapDefenseController _Instance;
}
