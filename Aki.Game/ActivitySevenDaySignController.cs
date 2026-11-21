using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

// Token: 0x020009AF RID: 2479
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivitySevenDaySignController : ActivityControllerBase
{
	// Token: 0x06006CEC RID: 27884 RVA: 0x0021B90E File Offset: 0x00219B0E
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.SignActivitySignStateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSignActivitySignStateNotify));
	}

	// Token: 0x06006CED RID: 27885 RVA: 0x0021B92C File Offset: 0x00219B2C
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.SignActivitySignStateNotify);
	}

	// Token: 0x06006CEE RID: 27886 RVA: 0x0021B93E File Offset: 0x00219B3E
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06006CEF RID: 27887 RVA: 0x0021B940 File Offset: 0x00219B40
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		ActivitySign? activitySignById = ActivitySevenDaySignConfig.Instance.GetActivitySignById(data.Id);
		if (activitySignById == null)
		{
			return "";
		}
		switch (activitySignById.Value.Type)
		{
		case 1:
			return activitySignById.Value.PrefabResource;
		case 2:
			return "UiItem_VersionSignIn";
		case 3:
			return "UiView_NewcomerSignIn";
		default:
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Activity;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "签到活动类型配置错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", activitySignById.Value.Type);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return "";
		}
		}
	}

	// Token: 0x06006CF0 RID: 27888 RVA: 0x0021B9F4 File Offset: 0x00219BF4
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		ActivitySign? activitySignById = ActivitySevenDaySignConfig.Instance.GetActivitySignById(data.Id);
		if (activitySignById == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Activity;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "签到活动未查到对应配置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", data.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return new ActivitySevenDaySignView();
		}
		switch (activitySignById.Value.Type)
		{
		case 1:
			return new ActivitySevenDaySignView();
		case 2:
			return new ActivitySubViewSevenDayVersionSign();
		case 3:
			return new ActivitySubViewNewcomerSignIn();
		default:
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Activity;
			ELogAuthor author2 = ELogAuthor.YYZ;
			string message2 = "签到活动类型配置错误";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Type", activitySignById.Value.Type);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return new ActivitySevenDaySignView();
		}
		}
	}

	// Token: 0x06006CF1 RID: 27889 RVA: 0x0021BAD1 File Offset: 0x00219CD1
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new ActivitySevenDaySignData();
	}

	// Token: 0x06006CF2 RID: 27890 RVA: 0x0021BAD8 File Offset: 0x00219CD8
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06006CF3 RID: 27891 RVA: 0x0021BADC File Offset: 0x00219CDC
	[NullableContext(2)]
	private unsafe void OnSignActivitySignStateNotify(IMessage msg, Net.CallbackStatus status)
	{
		SignActivitySignStateNotify signActivitySignStateNotify = (SignActivitySignStateNotify)msg;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Activity;
		ELogAuthor author = ELogAuthor.YYZ;
		string message = "[ActivitySevenDaySign][OnNotify]收到签到状态通知";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActivityId", signActivitySignStateNotify.ActivityId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SignIndex", signActivitySignStateNotify.Index);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("SignState", signActivitySignStateNotify.SignState);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		ActivitySevenDaySignData activitySevenDaySignData = ActivityModel.Instance.GetActivityById(signActivitySignStateNotify.ActivityId) as ActivitySevenDaySignData;
		if (activitySevenDaySignData != null)
		{
			activitySevenDaySignData.UpdateActivityData(signActivitySignStateNotify);
		}
		EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, signActivitySignStateNotify.ActivityId);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, signActivitySignStateNotify.ActivityId);
	}

	// Token: 0x06006CF4 RID: 27892 RVA: 0x0021BBCC File Offset: 0x00219DCC
	public void GetRewardByDay(int activityId, int day)
	{
		SignActivityRequest signActivityRequest = SignActivityRequest.Create();
		signActivityRequest.ActivityId = activityId;
		signActivityRequest.Index = day;
		Net.Instance.Call(ERequestMessageId.SignActivityRequest, signActivityRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			SignActivityResponse signActivityResponse = (SignActivityResponse)msg;
			if (signActivityResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(signActivityResponse.ErrorCode, 18799, null, true, true);
				return;
			}
			(ActivityModel.Instance.GetActivityById(activityId) as ActivitySevenDaySignData).SetRewardToGotState(day);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityId);
		}, 0);
	}

	// Token: 0x06006CF5 RID: 27893 RVA: 0x0021BC28 File Offset: 0x00219E28
	public void GetActivityFreeDrop(int activityId)
	{
		SignActivityFreeDropRequest signActivityFreeDropRequest = SignActivityFreeDropRequest.Create();
		signActivityFreeDropRequest.ActivityId = activityId;
		Net.Instance.Call(ERequestMessageId.SignActivityFreeDropRequest, signActivityFreeDropRequest, delegate(IMessage response, Net.CallbackStatus _)
		{
			(ActivityModel.Instance.GetActivityById(activityId) as ActivitySevenDaySignData).SetFreeRewardIsGet(true);
		}, 0);
	}

	// Token: 0x17000D4D RID: 3405
	// (get) Token: 0x06006CF6 RID: 27894 RVA: 0x0021BC71 File Offset: 0x00219E71
	public static ActivitySevenDaySignController Instance
	{
		get
		{
			return ActivitySevenDaySignController._Instance;
		}
	}

	// Token: 0x06006CF7 RID: 27895 RVA: 0x0021BC78 File Offset: 0x00219E78
	public static ActivitySevenDaySignController GetOrCreateInstance()
	{
		if (ActivitySevenDaySignController._Instance == null)
		{
			ActivitySevenDaySignController.CreateInstance();
		}
		return ActivitySevenDaySignController._Instance;
	}

	// Token: 0x06006CF8 RID: 27896 RVA: 0x0021BC8C File Offset: 0x00219E8C
	public static bool CreateInstance()
	{
		if (ActivitySevenDaySignController._Instance != null)
		{
			return true;
		}
		ActivitySevenDaySignController._Instance = new ActivitySevenDaySignController();
		return true;
	}

	// Token: 0x06006CF9 RID: 27897 RVA: 0x0021BCA2 File Offset: 0x00219EA2
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006CFA RID: 27898 RVA: 0x0021BCA4 File Offset: 0x00219EA4
	public static void ResetStaticDefaultValue()
	{
		ActivitySevenDaySignController._Instance = null;
	}

	// Token: 0x06006CFB RID: 27899 RVA: 0x0021BCAC File Offset: 0x00219EAC
	static ActivitySevenDaySignController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivitySevenDaySignController.CreateStaticDefaultValue), new Action(ActivitySevenDaySignController.ResetStaticDefaultValue));
	}

	// Token: 0x040043FB RID: 17403
	[Nullable(2)]
	private static ActivitySevenDaySignController _Instance;
}
