using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020014B8 RID: 5304
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class RoleGiftController : ActivityControllerBase
{
	// Token: 0x06009643 RID: 38467 RVA: 0x00207130 File Offset: 0x00205330
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Add<int, IReadOnlyList<int>>(EEventName.OnReceiveActivityData, new Action<int, IReadOnlyList<int>>(this.OnReceiveActivityData));
		EventSystem.Instance.Add(EEventName.ActivityViewRefreshCurrent, new Action<int>(this.OnActivityViewRefreshCurrent));
	}

	// Token: 0x06009644 RID: 38468 RVA: 0x00207194 File Offset: 0x00205394
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Remove<int, IReadOnlyList<int>>(EEventName.OnReceiveActivityData, new Action<int, IReadOnlyList<int>>(this.OnReceiveActivityData));
		EventSystem.Instance.Remove(EEventName.ActivityViewRefreshCurrent, new Action<int>(this.OnActivityViewRefreshCurrent));
	}

	// Token: 0x06009645 RID: 38469 RVA: 0x002071F5 File Offset: 0x002053F5
	protected override void OnRegisterNetEvent()
	{
	}

	// Token: 0x06009646 RID: 38470 RVA: 0x002071F7 File Offset: 0x002053F7
	protected override void OnUnRegisterNetEvent()
	{
	}

	// Token: 0x06009647 RID: 38471 RVA: 0x002071FC File Offset: 0x002053FC
	private void OnWorldDone()
	{
		if (PublicUtil.Instance.GetIsSilentLogin())
		{
			RoleGiftUtil.Debug("RoleGift 开屏任务跳过：静默登录", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (ConfigSplashScreenById.GetConfig(9, true) == null)
		{
			RoleGiftUtil.Debug("RoleGift 开屏任务跳过：开屏动画表无 RoleGiftActivity 配置", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		RoleGiftData roleGiftData = this.TryGetSingleActivityData();
		if (roleGiftData == null)
		{
			this.PendingSplashAfterActivitySync = true;
			RoleGiftUtil.Debug("RoleGift 开屏：暂无活动数据，待活动信息更新后重试", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.TryPushRoleGiftSplash(roleGiftData, false);
	}

	// Token: 0x06009648 RID: 38472 RVA: 0x0020727C File Offset: 0x0020547C
	private void OnReceiveActivityData(int type, IReadOnlyList<int> activityIds)
	{
		if (!this.PendingSplashAfterActivitySync)
		{
			return;
		}
		if (type != 104)
		{
			return;
		}
		string message = "RoleGift 收到 RoleGift 活动数据同步";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityIds", activityIds);
		RoleGiftUtil.Debug(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.TryResolvePendingSplashAfterActivitySync();
	}

	// Token: 0x06009649 RID: 38473 RVA: 0x002072BC File Offset: 0x002054BC
	private void TryResolvePendingSplashAfterActivitySync()
	{
		if (!this.PendingSplashAfterActivitySync)
		{
			return;
		}
		if (PublicUtil.Instance.GetIsSilentLogin())
		{
			this.PendingSplashAfterActivitySync = false;
			return;
		}
		if (ConfigSplashScreenById.GetConfig(9, true) == null)
		{
			this.PendingSplashAfterActivitySync = false;
			return;
		}
		RoleGiftData roleGiftData = this.TryGetSingleActivityData();
		if (roleGiftData == null)
		{
			return;
		}
		this.PendingSplashAfterActivitySync = false;
		this.TryPushRoleGiftSplash(roleGiftData, true);
	}

	// Token: 0x0600964A RID: 38474 RVA: 0x0020731C File Offset: 0x0020551C
	private void OnActivityViewRefreshCurrent(int activityId)
	{
		RoleGiftData roleGiftData = ActivityModel.Instance.GetActivityById(activityId) as RoleGiftData;
		if (roleGiftData == null || roleGiftData.Type != ActivityType.RoleGiftActivity)
		{
			return;
		}
		this.TryPushRoleGiftSplash(roleGiftData, false);
	}

	// Token: 0x0600964B RID: 38475 RVA: 0x00207350 File Offset: 0x00205550
	private void TryPushRoleGiftSplash(RoleGiftData data, bool isInstantly = false)
	{
		if (GameModeModel.Instance.IsMulti)
		{
			RoleGiftUtil.Debug("RoleGift 开屏任务跳过：多人在线模式", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (!data.NeedSplash())
		{
			RoleGiftUtil.Debug("RoleGift 开屏任务跳过：无满足条件的活动", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (this.HadPushedSplash)
		{
			RoleGiftUtil.Debug("RoleGift 开屏任务跳过：开屏动画已入过队", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		int activityId = data.Id;
		SplashScreenTask splashScreenTask = new SplashScreenTask(ESplashScreenSourceModuleType.RoleGiftActivity, ESplashScreenType.Config, delegate()
		{
			this.HadPushedSplash = true;
			UiManager.Instance.OpenView(EUiViewName.RoleGiftSplashView, activityId, null);
		});
		string message = "RoleGift 开屏任务入队";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
		RoleGiftUtil.Debug(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		SplashScreenController.Instance.PushSplashScreenTask(splashScreenTask, isInstantly);
	}

	// Token: 0x0600964C RID: 38476 RVA: 0x00207418 File Offset: 0x00205618
	[NullableContext(2)]
	public unsafe RoleGiftData TryGetSingleActivityData()
	{
		List<ActivityBaseData> activitiesByType = ActivityModel.Instance.GetActivitiesByType(104);
		if (activitiesByType == null || activitiesByType.Count <= 0)
		{
			string message = "GetSingleActivityData";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("reason", "empty_list");
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("count", (activitiesByType != null) ? activitiesByType.Count : 0);
			RoleGiftUtil.Debug(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}
		if (activitiesByType.Count > 1)
		{
			string message2 = "RoleGift multiple activity data found";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("count", activitiesByType.Count);
			RoleGiftUtil.Error(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		RoleGiftData roleGiftData = activitiesByType[0] as RoleGiftData;
		if (roleGiftData == null)
		{
			return null;
		}
		if (!roleGiftData.CheckIfInOpenTime())
		{
			return null;
		}
		string message3 = "GetSingleActivityData";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("reason", "ok");
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("activityId", roleGiftData.Id);
		RoleGiftUtil.Debug(message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
		return roleGiftData;
	}

	// Token: 0x0600964D RID: 38477 RVA: 0x00207546 File Offset: 0x00205746
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x0600964E RID: 38478 RVA: 0x00207548 File Offset: 0x00205748
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_PresentMain";
	}

	// Token: 0x0600964F RID: 38479 RVA: 0x0020754F File Offset: 0x0020574F
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new RoleGiftView();
	}

	// Token: 0x06009650 RID: 38480 RVA: 0x00207556 File Offset: 0x00205756
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new RoleGiftData();
	}

	// Token: 0x06009651 RID: 38481 RVA: 0x0020755D File Offset: 0x0020575D
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06009652 RID: 38482 RVA: 0x00207560 File Offset: 0x00205760
	public UniTask RequestRoleGiftReward(int activityId)
	{
		RoleGiftController.<RequestRoleGiftReward>d__17 <RequestRoleGiftReward>d__;
		<RequestRoleGiftReward>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestRoleGiftReward>d__.activityId = activityId;
		<RequestRoleGiftReward>d__.<>1__state = -1;
		<RequestRoleGiftReward>d__.<>t__builder.Start<RoleGiftController.<RequestRoleGiftReward>d__17>(ref <RequestRoleGiftReward>d__);
		return <RequestRoleGiftReward>d__.<>t__builder.Task;
	}

	// Token: 0x17000D06 RID: 3334
	// (get) Token: 0x06009653 RID: 38483 RVA: 0x002075A3 File Offset: 0x002057A3
	public static RoleGiftController Instance
	{
		get
		{
			return RoleGiftController._Instance;
		}
	}

	// Token: 0x06009654 RID: 38484 RVA: 0x002075AA File Offset: 0x002057AA
	public static RoleGiftController GetOrCreateInstance()
	{
		if (RoleGiftController._Instance == null)
		{
			RoleGiftController.CreateInstance();
		}
		return RoleGiftController._Instance;
	}

	// Token: 0x06009655 RID: 38485 RVA: 0x002075BE File Offset: 0x002057BE
	public static bool CreateInstance()
	{
		if (RoleGiftController._Instance != null)
		{
			return true;
		}
		RoleGiftController._Instance = new RoleGiftController();
		return true;
	}

	// Token: 0x06009656 RID: 38486 RVA: 0x002075D4 File Offset: 0x002057D4
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009657 RID: 38487 RVA: 0x002075D6 File Offset: 0x002057D6
	public static void ResetStaticDefaultValue()
	{
		RoleGiftController._Instance = null;
	}

	// Token: 0x06009658 RID: 38488 RVA: 0x002075DE File Offset: 0x002057DE
	static RoleGiftController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleGiftController.CreateStaticDefaultValue), new Action(RoleGiftController.ResetStaticDefaultValue));
	}

	// Token: 0x0400425A RID: 16986
	private bool PendingSplashAfterActivitySync;

	// Token: 0x0400425B RID: 16987
	private bool HadPushedSplash;

	// Token: 0x0400425C RID: 16988
	[Nullable(2)]
	private static RoleGiftController _Instance;
}
