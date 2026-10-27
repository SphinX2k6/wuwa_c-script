using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

// Token: 0x020014F7 RID: 5367
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivitySevenDaySignController : ActivityControllerBase
{
	// Token: 0x06009912 RID: 39186 RVA: 0x00211C1E File Offset: 0x0020FE1E
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.SignActivitySignStateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSignActivitySignStateNotify));
	}

	// Token: 0x06009913 RID: 39187 RVA: 0x00211C3C File Offset: 0x0020FE3C
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.SignActivitySignStateNotify);
	}

	// Token: 0x06009914 RID: 39188 RVA: 0x00211C4E File Offset: 0x0020FE4E
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06009915 RID: 39189 RVA: 0x00211C50 File Offset: 0x0020FE50
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

	// Token: 0x06009916 RID: 39190 RVA: 0x00211D04 File Offset: 0x0020FF04
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

	// Token: 0x06009917 RID: 39191 RVA: 0x00211DE1 File Offset: 0x0020FFE1
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new ActivitySevenDaySignData();
	}

	// Token: 0x06009918 RID: 39192 RVA: 0x00211DE8 File Offset: 0x0020FFE8
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06009919 RID: 39193 RVA: 0x00211DEC File Offset: 0x0020FFEC
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

	// Token: 0x0600991A RID: 39194 RVA: 0x00211EDC File Offset: 0x002100DC
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(signActivityResponse.ErrorCode, 18069, null, true, true);
				return;
			}
			(ActivityModel.Instance.GetActivityById(activityId) as ActivitySevenDaySignData).SetRewardToGotState(day);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityId);
		}, 0);
	}

	// Token: 0x0600991B RID: 39195 RVA: 0x00211F38 File Offset: 0x00210138
	public void GetActivityFreeDrop(int activityId)
	{
		SignActivityFreeDropRequest signActivityFreeDropRequest = SignActivityFreeDropRequest.Create();
		signActivityFreeDropRequest.ActivityId = activityId;
		Net.Instance.Call(ERequestMessageId.SignActivityFreeDropRequest, signActivityFreeDropRequest, delegate(IMessage response, Net.CallbackStatus _)
		{
			(ActivityModel.Instance.GetActivityById(activityId) as ActivitySevenDaySignData).SetFreeRewardIsGet(true);
		}, 0);
	}

	// Token: 0x17000D2C RID: 3372
	// (get) Token: 0x0600991C RID: 39196 RVA: 0x00211F81 File Offset: 0x00210181
	public static ActivitySevenDaySignController Instance
	{
		get
		{
			return ActivitySevenDaySignController._Instance;
		}
	}

	// Token: 0x0600991D RID: 39197 RVA: 0x00211F88 File Offset: 0x00210188
	public static ActivitySevenDaySignController GetOrCreateInstance()
	{
		if (ActivitySevenDaySignController._Instance == null)
		{
			ActivitySevenDaySignController.CreateInstance();
		}
		return ActivitySevenDaySignController._Instance;
	}

	// Token: 0x0600991E RID: 39198 RVA: 0x00211F9C File Offset: 0x0021019C
	public static bool CreateInstance()
	{
		if (ActivitySevenDaySignController._Instance != null)
		{
			return true;
		}
		ActivitySevenDaySignController._Instance = new ActivitySevenDaySignController();
		return true;
	}

	// Token: 0x0600991F RID: 39199 RVA: 0x00211FB2 File Offset: 0x002101B2
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009920 RID: 39200 RVA: 0x00211FB4 File Offset: 0x002101B4
	public static void ResetStaticDefaultValue()
	{
		ActivitySevenDaySignController._Instance = null;
	}

	// Token: 0x06009921 RID: 39201 RVA: 0x00211FBC File Offset: 0x002101BC
	static ActivitySevenDaySignController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivitySevenDaySignController.CreateStaticDefaultValue), new Action(ActivitySevenDaySignController.ResetStaticDefaultValue));
	}

	// Token: 0x04004356 RID: 17238
	[Nullable(2)]
	private static ActivitySevenDaySignController _Instance;
}
