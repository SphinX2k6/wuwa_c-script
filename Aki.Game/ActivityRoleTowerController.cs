using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x0200097E RID: 2430
[NullableContext(1)]
[Nullable(0)]
public class ActivityRoleTowerController : ActivityControllerBase
{
	// Token: 0x06006AA5 RID: 27301 RVA: 0x0021300F File Offset: 0x0021120F
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return this.IsOpeningOutsideView();
	}

	// Token: 0x06006AA6 RID: 27302 RVA: 0x00213018 File Offset: 0x00211218
	private bool IsOpeningOutsideView()
	{
		if (RoleTowerModel.Instance.IsInRoleTowerDungeon())
		{
			return false;
		}
		foreach (EUiViewName viewName in this.OutsideViewList)
		{
			if (UiManager.Instance.IsViewOpen(viewName))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06006AA7 RID: 27303 RVA: 0x00213060 File Offset: 0x00211260
	private void OnExpireCheckTimer(float delta)
	{
		if (!this.IsOpeningOutsideView())
		{
			this.IsExpireHandled = false;
			return;
		}
		ActivityRoleTowerData data = this.Data;
		if (this.IsExpireHandled || data == null || data.CheckIfInOpenTime())
		{
			return;
		}
		this.IsExpireHandled = true;
		ActivityController.Instance.ShowActivityRefreshAndBackToBattleView();
	}

	// Token: 0x06006AA8 RID: 27304 RVA: 0x002130A9 File Offset: 0x002112A9
	private void ClearExpireCheckTimer()
	{
		if (this.ExpireCheckTimer != null)
		{
			TimerSystem.Instance.Remove(this.ExpireCheckTimer);
			this.ExpireCheckTimer = null;
		}
	}

	// Token: 0x06006AA9 RID: 27305 RVA: 0x002130CB File Offset: 0x002112CB
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06006AAA RID: 27306 RVA: 0x002130D0 File Offset: 0x002112D0
	[NullableContext(0)]
	protected override UniTask<bool> OnOpenSubView(EUiViewName viewName, int activityId = 0)
	{
		ActivityRoleTowerController.<OnOpenSubView>d__10 <OnOpenSubView>d__;
		<OnOpenSubView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OnOpenSubView>d__.<>4__this = this;
		<OnOpenSubView>d__.viewName = viewName;
		<OnOpenSubView>d__.<>1__state = -1;
		<OnOpenSubView>d__.<>t__builder.Start<ActivityRoleTowerController.<OnOpenSubView>d__10>(ref <OnOpenSubView>d__);
		return <OnOpenSubView>d__.<>t__builder.Task;
	}

	// Token: 0x06006AAB RID: 27307 RVA: 0x0021311B File Offset: 0x0021131B
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityRoleTower";
	}

	// Token: 0x06006AAC RID: 27308 RVA: 0x00213122 File Offset: 0x00211322
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewRoleTower();
	}

	// Token: 0x06006AAD RID: 27309 RVA: 0x00213129 File Offset: 0x00211329
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.Data = new ActivityRoleTowerData();
		return this.Data;
	}

	// Token: 0x06006AAE RID: 27310 RVA: 0x0021313C File Offset: 0x0021133C
	protected override void OnRegisterNetEvent()
	{
	}

	// Token: 0x06006AAF RID: 27311 RVA: 0x0021313E File Offset: 0x0021133E
	protected override void OnUnRegisterNetEvent()
	{
	}

	// Token: 0x06006AB0 RID: 27312 RVA: 0x00213140 File Offset: 0x00211340
	protected override void OnAddEvents()
	{
		EventSystem instance = EventSystem.Instance;
		EEventName name = EEventName.RoleTowerRewardReceive;
		Action handle;
		if ((handle = ActivityRoleTowerController.<>O.<0>__RefreshActivityRedDot) == null)
		{
			handle = (ActivityRoleTowerController.<>O.<0>__RefreshActivityRedDot = new Action(ActivityRoleTowerController.RefreshActivityRedDot));
		}
		instance.Add(name, handle);
		EventSystem instance2 = EventSystem.Instance;
		EEventName name2 = EEventName.RoleTowerInfoUpdate;
		Action handle2;
		if ((handle2 = ActivityRoleTowerController.<>O.<0>__RefreshActivityRedDot) == null)
		{
			handle2 = (ActivityRoleTowerController.<>O.<0>__RefreshActivityRedDot = new Action(ActivityRoleTowerController.RefreshActivityRedDot));
		}
		instance2.Add(name2, handle2);
		this.ClearExpireCheckTimer();
		this.ExpireCheckTimer = TimerSystem.Instance.Forever(new TTimerAction(this.OnExpireCheckTimer), 1000f, 1f, null, null, true);
	}

	// Token: 0x06006AB1 RID: 27313 RVA: 0x002131D4 File Offset: 0x002113D4
	protected override void OnRemoveEvents()
	{
		EventSystem instance = EventSystem.Instance;
		EEventName name = EEventName.RoleTowerRewardReceive;
		Action handle;
		if ((handle = ActivityRoleTowerController.<>O.<0>__RefreshActivityRedDot) == null)
		{
			handle = (ActivityRoleTowerController.<>O.<0>__RefreshActivityRedDot = new Action(ActivityRoleTowerController.RefreshActivityRedDot));
		}
		instance.Remove(name, handle);
		EventSystem instance2 = EventSystem.Instance;
		EEventName name2 = EEventName.RoleTowerInfoUpdate;
		Action handle2;
		if ((handle2 = ActivityRoleTowerController.<>O.<0>__RefreshActivityRedDot) == null)
		{
			handle2 = (ActivityRoleTowerController.<>O.<0>__RefreshActivityRedDot = new Action(ActivityRoleTowerController.RefreshActivityRedDot));
		}
		instance2.Remove(name2, handle2);
		this.ClearExpireCheckTimer();
		this.IsExpireHandled = false;
	}

	// Token: 0x06006AB2 RID: 27314 RVA: 0x00213244 File Offset: 0x00211444
	public static void RefreshActivityRedDot()
	{
		ActivityRoleTowerData data = ActivityRoleTowerController.Instance.Data;
		if (data != null)
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, data.Id);
		}
	}

	// Token: 0x17000D2E RID: 3374
	// (get) Token: 0x06006AB3 RID: 27315 RVA: 0x00213275 File Offset: 0x00211475
	public static ActivityRoleTowerController Instance
	{
		get
		{
			return ActivityRoleTowerController._Instance;
		}
	}

	// Token: 0x06006AB4 RID: 27316 RVA: 0x0021327C File Offset: 0x0021147C
	public static ActivityRoleTowerController GetOrCreateInstance()
	{
		if (ActivityRoleTowerController._Instance == null)
		{
			ActivityRoleTowerController.CreateInstance();
		}
		return ActivityRoleTowerController._Instance;
	}

	// Token: 0x06006AB5 RID: 27317 RVA: 0x00213290 File Offset: 0x00211490
	public static bool CreateInstance()
	{
		if (ActivityRoleTowerController._Instance != null)
		{
			return true;
		}
		ActivityRoleTowerController._Instance = new ActivityRoleTowerController();
		return true;
	}

	// Token: 0x06006AB6 RID: 27318 RVA: 0x002132A6 File Offset: 0x002114A6
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006AB7 RID: 27319 RVA: 0x002132A8 File Offset: 0x002114A8
	public static void ResetStaticDefaultValue()
	{
		ActivityRoleTowerController._Instance = null;
	}

	// Token: 0x06006AB8 RID: 27320 RVA: 0x002132B0 File Offset: 0x002114B0
	static ActivityRoleTowerController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityRoleTowerController.CreateStaticDefaultValue), new Action(ActivityRoleTowerController.ResetStaticDefaultValue));
	}

	// Token: 0x04004325 RID: 17189
	[Nullable(2)]
	public ActivityRoleTowerData Data;

	// Token: 0x04004326 RID: 17190
	private const int EXPIRE_CHECK_GAP = 1000;

	// Token: 0x04004327 RID: 17191
	private readonly EUiViewName[] OutsideViewList = new EUiViewName[]
	{
		EUiViewName.RoleTowerActivityView,
		EUiViewName.RoleTowerLevelSelectView,
		EUiViewName.RoleTowerPrepareView,
		EUiViewName.RoleTowerRewardView,
		EUiViewName.RoleTowerRankView,
		EUiViewName.RoleTowerTokenView,
		EUiViewName.RoleTowerTimeRecordView,
		EUiViewName.RoleTowerStarUpView,
		EUiViewName.RoleTowerMonsterSelectView,
		EUiViewName.RoleTowerMonsterDetailView,
		EUiViewName.RoleTowerBuffDetailView,
		EUiViewName.RoleTowerVisionDetailView,
		EUiViewName.RoleTowerRolePropertyView,
		EUiViewName.RoleTowerAttributeDetailView
	};

	// Token: 0x04004328 RID: 17192
	[Nullable(2)]
	private TimerHandle ExpireCheckTimer;

	// Token: 0x04004329 RID: 17193
	private bool IsExpireHandled;

	// Token: 0x0400432A RID: 17194
	[Nullable(2)]
	private static ActivityRoleTowerController _Instance;

	// Token: 0x02006C84 RID: 27780
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04023A67 RID: 146023
		[Nullable(0)]
		public static Action <0>__RefreshActivityRedDot;
	}
}
