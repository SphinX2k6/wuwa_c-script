using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

// Token: 0x02000972 RID: 2418
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityRoleGiveController : ActivityControllerBase
{
	// Token: 0x06006A1B RID: 27163 RVA: 0x00211264 File Offset: 0x0020F464
	protected override void OnOpenView(ActivityBaseData data)
	{
		throw new NotImplementedException();
	}

	// Token: 0x06006A1C RID: 27164 RVA: 0x0021126B File Offset: 0x0020F46B
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityRoleXiangliyao";
	}

	// Token: 0x06006A1D RID: 27165 RVA: 0x00211272 File Offset: 0x0020F472
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewRoleGive();
	}

	// Token: 0x06006A1E RID: 27166 RVA: 0x00211279 File Offset: 0x0020F479
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.CurrentActivityId = data.Id;
		return new ActivityRoleGiveData();
	}

	// Token: 0x06006A1F RID: 27167 RVA: 0x0021128C File Offset: 0x0020F48C
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06006A20 RID: 27168 RVA: 0x00211290 File Offset: 0x0020F490
	public void TrackMoonActivityRewardRequest()
	{
		TraceMoonPhaseRewardRequest traceMoonPhaseRewardRequest = TraceMoonPhaseRewardRequest.Create();
		traceMoonPhaseRewardRequest.ActivityId = this.CurrentActivityId;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.MoonChasing;
		ELogAuthor author = ELogAuthor.LPH;
		string message = "TrackMoonActivityRewardRequest";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActivityId:", this.CurrentActivityId);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		Net.Instance.Call(ERequestMessageId.TraceMoonPhaseRewardRequest, traceMoonPhaseRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TraceMoonPhaseRewardResponse traceMoonPhaseRewardResponse = (TraceMoonPhaseRewardResponse)msg;
			if (traceMoonPhaseRewardResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(traceMoonPhaseRewardResponse.ErrorCode, 17223, null, true, true);
				return;
			}
			ActivityRoleGiveData currentActivityData = this.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				return;
			}
			currentActivityData.IsGetReward = true;
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.CurrentActivityId);
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.MoonChasing;
			ELogAuthor author2 = ELogAuthor.LPH;
			string message2 = "TrackMoonActivityRewardResponse";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ActivityId:", this.CurrentActivityId);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}, 0);
	}

	// Token: 0x06006A21 RID: 27169 RVA: 0x00211300 File Offset: 0x0020F500
	[NullableContext(2)]
	public ActivityRoleGiveData GetCurrentActivityData()
	{
		ActivityRoleGiveData activityRoleGiveData = ActivityModel.Instance.GetActivityById(this.CurrentActivityId) as ActivityRoleGiveData;
		if (activityRoleGiveData == null)
		{
			return null;
		}
		return activityRoleGiveData;
	}

	// Token: 0x17000D28 RID: 3368
	// (get) Token: 0x06006A22 RID: 27170 RVA: 0x00211329 File Offset: 0x0020F529
	public static ActivityRoleGiveController Instance
	{
		get
		{
			return ActivityRoleGiveController._Instance;
		}
	}

	// Token: 0x06006A23 RID: 27171 RVA: 0x00211330 File Offset: 0x0020F530
	public static ActivityRoleGiveController GetOrCreateInstance()
	{
		if (ActivityRoleGiveController._Instance == null)
		{
			ActivityRoleGiveController.CreateInstance();
		}
		return ActivityRoleGiveController._Instance;
	}

	// Token: 0x06006A24 RID: 27172 RVA: 0x00211344 File Offset: 0x0020F544
	public static bool CreateInstance()
	{
		if (ActivityRoleGiveController._Instance != null)
		{
			return true;
		}
		ActivityRoleGiveController._Instance = new ActivityRoleGiveController();
		return true;
	}

	// Token: 0x06006A25 RID: 27173 RVA: 0x0021135A File Offset: 0x0020F55A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006A26 RID: 27174 RVA: 0x0021135C File Offset: 0x0020F55C
	public static void ResetStaticDefaultValue()
	{
		ActivityRoleGiveController._Instance = null;
	}

	// Token: 0x06006A27 RID: 27175 RVA: 0x00211364 File Offset: 0x0020F564
	static ActivityRoleGiveController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityRoleGiveController.CreateStaticDefaultValue), new Action(ActivityRoleGiveController.ResetStaticDefaultValue));
	}

	// Token: 0x04004305 RID: 17157
	public int CurrentActivityId;

	// Token: 0x04004306 RID: 17158
	[Nullable(2)]
	private static ActivityRoleGiveController _Instance;
}
