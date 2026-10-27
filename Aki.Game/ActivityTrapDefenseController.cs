using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.TrapDefense;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x0200152F RID: 5423
[NullableContext(1)]
[Nullable(0)]
public class ActivityTrapDefenseController : ActivityControllerBase
{
	// Token: 0x06009AB5 RID: 39605 RVA: 0x00217743 File Offset: 0x00215943
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06009AB6 RID: 39606 RVA: 0x00217746 File Offset: 0x00215946
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
	}

	// Token: 0x06009AB7 RID: 39607 RVA: 0x00217764 File Offset: 0x00215964
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
	}

	// Token: 0x06009AB8 RID: 39608 RVA: 0x00217782 File Offset: 0x00215982
	private void OnWorldDone()
	{
		if (TrapDefenseModel.Instance.NeedOpenActivityMainView)
		{
			this.AddMainViewSplashTask();
		}
	}

	// Token: 0x06009AB9 RID: 39609 RVA: 0x00217798 File Offset: 0x00215998
	private void AddMainViewSplashTask()
	{
		SplashScreenTask splashScreenTask = new SplashScreenTask(ESplashScreenSourceModuleType.None, ESplashScreenType.Other, delegate()
		{
			UiManager.Instance.OpenView(EUiViewName.TrapDefenseMainView, null, null);
		});
		SplashScreenController.Instance.PushSplashScreenTask(splashScreenTask, false);
	}

	// Token: 0x06009ABA RID: 39610 RVA: 0x002177D8 File Offset: 0x002159D8
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

	// Token: 0x06009ABB RID: 39611 RVA: 0x0021781B File Offset: 0x00215A1B
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06009ABC RID: 39612 RVA: 0x0021781D File Offset: 0x00215A1D
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_TowerDefenseActivityMain";
	}

	// Token: 0x06009ABD RID: 39613 RVA: 0x00217824 File Offset: 0x00215A24
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewTrapDefense();
	}

	// Token: 0x06009ABE RID: 39614 RVA: 0x0021782B File Offset: 0x00215A2B
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.Data = new ActivityTrapDefenseData();
		return this.Data;
	}

	// Token: 0x06009ABF RID: 39615 RVA: 0x00217840 File Offset: 0x00215A40
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

	// Token: 0x06009AC0 RID: 39616 RVA: 0x00217998 File Offset: 0x00215B98
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.TrapDefenseChallengeUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.TrapDefenseRewardUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.TrapDefenseSpecialRewardUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.TrapDefenseTechUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.TrapDefenseBdUpdateNotify);
	}

	// Token: 0x06009AC1 RID: 39617 RVA: 0x002179F8 File Offset: 0x00215BF8
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

	// Token: 0x06009AC2 RID: 39618 RVA: 0x00217A5D File Offset: 0x00215C5D
	public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
	{
		UiManager.Instance.OpenView(EUiViewName.TrapDefenseActivityUnlockView, null, null);
	}

	// Token: 0x17000D4D RID: 3405
	// (get) Token: 0x06009AC3 RID: 39619 RVA: 0x00217A70 File Offset: 0x00215C70
	public static ActivityTrapDefenseController Instance
	{
		get
		{
			return ActivityTrapDefenseController._Instance;
		}
	}

	// Token: 0x06009AC4 RID: 39620 RVA: 0x00217A77 File Offset: 0x00215C77
	public static ActivityTrapDefenseController GetOrCreateInstance()
	{
		if (ActivityTrapDefenseController._Instance == null)
		{
			ActivityTrapDefenseController.CreateInstance();
		}
		return ActivityTrapDefenseController._Instance;
	}

	// Token: 0x06009AC5 RID: 39621 RVA: 0x00217A8B File Offset: 0x00215C8B
	public static bool CreateInstance()
	{
		if (ActivityTrapDefenseController._Instance != null)
		{
			return true;
		}
		ActivityTrapDefenseController._Instance = new ActivityTrapDefenseController();
		return true;
	}

	// Token: 0x06009AC6 RID: 39622 RVA: 0x00217AA1 File Offset: 0x00215CA1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009AC7 RID: 39623 RVA: 0x00217AA3 File Offset: 0x00215CA3
	public static void ResetStaticDefaultValue()
	{
		ActivityTrapDefenseController._Instance = null;
	}

	// Token: 0x06009AC8 RID: 39624 RVA: 0x00217AAB File Offset: 0x00215CAB
	static ActivityTrapDefenseController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityTrapDefenseController.CreateStaticDefaultValue), new Action(ActivityTrapDefenseController.ResetStaticDefaultValue));
	}

	// Token: 0x0400440F RID: 17423
	[Nullable(2)]
	public ActivityTrapDefenseData Data;

	// Token: 0x04004410 RID: 17424
	[Nullable(2)]
	private static ActivityTrapDefenseController _Instance;
}
