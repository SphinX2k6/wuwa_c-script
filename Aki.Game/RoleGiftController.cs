using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x0200096C RID: 2412
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class RoleGiftController : ActivityControllerBase
{
	// Token: 0x060069D8 RID: 27096 RVA: 0x0021009C File Offset: 0x0020E29C
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Add<int, IReadOnlyList<int>>(EEventName.OnReceiveActivityData, new Action<int, IReadOnlyList<int>>(this.OnReceiveActivityData));
		EventSystem.Instance.Add(EEventName.ActivityViewRefreshCurrent, new Action<int>(this.OnActivityViewRefreshCurrent));
	}

	// Token: 0x060069D9 RID: 27097 RVA: 0x00210100 File Offset: 0x0020E300
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Remove<int, IReadOnlyList<int>>(EEventName.OnReceiveActivityData, new Action<int, IReadOnlyList<int>>(this.OnReceiveActivityData));
		EventSystem.Instance.Remove(EEventName.ActivityViewRefreshCurrent, new Action<int>(this.OnActivityViewRefreshCurrent));
	}

	// Token: 0x060069DA RID: 27098 RVA: 0x00210161 File Offset: 0x0020E361
	protected override void OnRegisterNetEvent()
	{
	}

	// Token: 0x060069DB RID: 27099 RVA: 0x00210163 File Offset: 0x0020E363
	protected override void OnUnRegisterNetEvent()
	{
	}

	// Token: 0x060069DC RID: 27100 RVA: 0x00210168 File Offset: 0x0020E368
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

	// Token: 0x060069DD RID: 27101 RVA: 0x002101E8 File Offset: 0x0020E3E8
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

	// Token: 0x060069DE RID: 27102 RVA: 0x00210228 File Offset: 0x0020E428
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

	// Token: 0x060069DF RID: 27103 RVA: 0x00210288 File Offset: 0x0020E488
	private void OnActivityViewRefreshCurrent(int activityId)
	{
		RoleGiftData roleGiftData = ActivityModel.Instance.GetActivityById(activityId) as RoleGiftData;
		if (roleGiftData == null || roleGiftData.Type != ActivityType.RoleGiftActivity)
		{
			return;
		}
		this.TryPushRoleGiftSplash(roleGiftData, false);
	}

	// Token: 0x060069E0 RID: 27104 RVA: 0x002102BC File Offset: 0x0020E4BC
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

	// Token: 0x060069E1 RID: 27105 RVA: 0x00210384 File Offset: 0x0020E584
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

	// Token: 0x060069E2 RID: 27106 RVA: 0x002104B2 File Offset: 0x0020E6B2
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x060069E3 RID: 27107 RVA: 0x002104B4 File Offset: 0x0020E6B4
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_PresentMain";
	}

	// Token: 0x060069E4 RID: 27108 RVA: 0x002104BB File Offset: 0x0020E6BB
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new RoleGiftView();
	}

	// Token: 0x060069E5 RID: 27109 RVA: 0x002104C2 File Offset: 0x0020E6C2
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new RoleGiftData();
	}

	// Token: 0x060069E6 RID: 27110 RVA: 0x002104C9 File Offset: 0x0020E6C9
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x060069E7 RID: 27111 RVA: 0x002104CC File Offset: 0x0020E6CC
	public UniTask RequestRoleGiftReward(int activityId)
	{
		RoleGiftController.<RequestRoleGiftReward>d__17 <RequestRoleGiftReward>d__;
		<RequestRoleGiftReward>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestRoleGiftReward>d__.activityId = activityId;
		<RequestRoleGiftReward>d__.<>1__state = -1;
		<RequestRoleGiftReward>d__.<>t__builder.Start<RoleGiftController.<RequestRoleGiftReward>d__17>(ref <RequestRoleGiftReward>d__);
		return <RequestRoleGiftReward>d__.<>t__builder.Task;
	}

	// Token: 0x17000D26 RID: 3366
	// (get) Token: 0x060069E8 RID: 27112 RVA: 0x0021050F File Offset: 0x0020E70F
	public static RoleGiftController Instance
	{
		get
		{
			return RoleGiftController._Instance;
		}
	}

	// Token: 0x060069E9 RID: 27113 RVA: 0x00210516 File Offset: 0x0020E716
	public static RoleGiftController GetOrCreateInstance()
	{
		if (RoleGiftController._Instance == null)
		{
			RoleGiftController.CreateInstance();
		}
		return RoleGiftController._Instance;
	}

	// Token: 0x060069EA RID: 27114 RVA: 0x0021052A File Offset: 0x0020E72A
	public static bool CreateInstance()
	{
		if (RoleGiftController._Instance != null)
		{
			return true;
		}
		RoleGiftController._Instance = new RoleGiftController();
		return true;
	}

	// Token: 0x060069EB RID: 27115 RVA: 0x00210540 File Offset: 0x0020E740
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060069EC RID: 27116 RVA: 0x00210542 File Offset: 0x0020E742
	public static void ResetStaticDefaultValue()
	{
		RoleGiftController._Instance = null;
	}

	// Token: 0x060069ED RID: 27117 RVA: 0x0021054A File Offset: 0x0020E74A
	static RoleGiftController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleGiftController.CreateStaticDefaultValue), new Action(RoleGiftController.ResetStaticDefaultValue));
	}

	// Token: 0x040042F2 RID: 17138
	private bool PendingSplashAfterActivitySync;

	// Token: 0x040042F3 RID: 17139
	private bool HadPushedSplash;

	// Token: 0x040042F4 RID: 17140
	[Nullable(2)]
	private static RoleGiftController _Instance;
}
