using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

// Token: 0x020014BE RID: 5310
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityRoleGiveController : ActivityControllerBase
{
	// Token: 0x06009686 RID: 38534 RVA: 0x002082F8 File Offset: 0x002064F8
	protected override void OnOpenView(ActivityBaseData data)
	{
		throw new NotImplementedException();
	}

	// Token: 0x06009687 RID: 38535 RVA: 0x002082FF File Offset: 0x002064FF
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityRoleXiangliyao";
	}

	// Token: 0x06009688 RID: 38536 RVA: 0x00208306 File Offset: 0x00206506
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewRoleGive();
	}

	// Token: 0x06009689 RID: 38537 RVA: 0x0020830D File Offset: 0x0020650D
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.CurrentActivityId = data.Id;
		return new ActivityRoleGiveData();
	}

	// Token: 0x0600968A RID: 38538 RVA: 0x00208320 File Offset: 0x00206520
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x0600968B RID: 38539 RVA: 0x00208324 File Offset: 0x00206524
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(traceMoonPhaseRewardResponse.ErrorCode, 18742, null, true, true);
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

	// Token: 0x0600968C RID: 38540 RVA: 0x00208394 File Offset: 0x00206594
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

	// Token: 0x17000D08 RID: 3336
	// (get) Token: 0x0600968D RID: 38541 RVA: 0x002083BD File Offset: 0x002065BD
	public static ActivityRoleGiveController Instance
	{
		get
		{
			return ActivityRoleGiveController._Instance;
		}
	}

	// Token: 0x0600968E RID: 38542 RVA: 0x002083C4 File Offset: 0x002065C4
	public static ActivityRoleGiveController GetOrCreateInstance()
	{
		if (ActivityRoleGiveController._Instance == null)
		{
			ActivityRoleGiveController.CreateInstance();
		}
		return ActivityRoleGiveController._Instance;
	}

	// Token: 0x0600968F RID: 38543 RVA: 0x002083D8 File Offset: 0x002065D8
	public static bool CreateInstance()
	{
		if (ActivityRoleGiveController._Instance != null)
		{
			return true;
		}
		ActivityRoleGiveController._Instance = new ActivityRoleGiveController();
		return true;
	}

	// Token: 0x06009690 RID: 38544 RVA: 0x002083EE File Offset: 0x002065EE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009691 RID: 38545 RVA: 0x002083F0 File Offset: 0x002065F0
	public static void ResetStaticDefaultValue()
	{
		ActivityRoleGiveController._Instance = null;
	}

	// Token: 0x06009692 RID: 38546 RVA: 0x002083F8 File Offset: 0x002065F8
	static ActivityRoleGiveController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityRoleGiveController.CreateStaticDefaultValue), new Action(ActivityRoleGiveController.ResetStaticDefaultValue));
	}

	// Token: 0x0400426D RID: 17005
	public int CurrentActivityId;

	// Token: 0x0400426E RID: 17006
	[Nullable(2)]
	private static ActivityRoleGiveController _Instance;
}
