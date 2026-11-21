using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

// Token: 0x02000888 RID: 2184
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityNoviceJourneyController : ActivityControllerBase
{
	// Token: 0x060062CE RID: 25294 RVA: 0x001F800E File Offset: 0x001F620E
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, int, int, int, int, int, int>(EEventName.OnPlayerLevelChanged, new Action<int, int, int, int, int, int, int>(this.OnPlayerLevelChanged));
	}

	// Token: 0x060062CF RID: 25295 RVA: 0x001F802C File Offset: 0x001F622C
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<int, int, int, int, int, int, int>(EEventName.OnPlayerLevelChanged, new Action<int, int, int, int, int, int, int>(this.OnPlayerLevelChanged));
	}

	// Token: 0x060062D0 RID: 25296 RVA: 0x001F804A File Offset: 0x001F624A
	private void OnPlayerLevelChanged(int i, int i1, int arg3, int arg4, int arg5, int arg6, int arg7)
	{
		if (this.DataId != 0)
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.DataId);
		}
	}

	// Token: 0x060062D1 RID: 25297 RVA: 0x001F806A File Offset: 0x001F626A
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.NewBieCourseRewardNotify, new Action<IMessage, Net.CallbackStatus>(this.OnNewBieCourseRewardNotify));
	}

	// Token: 0x060062D2 RID: 25298 RVA: 0x001F8088 File Offset: 0x001F6288
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.NewBieCourseRewardNotify);
	}

	// Token: 0x060062D3 RID: 25299 RVA: 0x001F809A File Offset: 0x001F629A
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x060062D4 RID: 25300 RVA: 0x001F809C File Offset: 0x001F629C
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityRoleLevel";
	}

	// Token: 0x060062D5 RID: 25301 RVA: 0x001F80A3 File Offset: 0x001F62A3
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewNoviceJourney();
	}

	// Token: 0x060062D6 RID: 25302 RVA: 0x001F80AA File Offset: 0x001F62AA
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.DataId = data.Id;
		return new ActivityNoviceJourneyData();
	}

	// Token: 0x060062D7 RID: 25303 RVA: 0x001F80BD File Offset: 0x001F62BD
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x060062D8 RID: 25304 RVA: 0x001F80C0 File Offset: 0x001F62C0
	[NullableContext(2)]
	private void OnNewBieCourseRewardNotify(IMessage msg, Net.CallbackStatus status)
	{
		NewBieCourseRewardNotify newBieCourseRewardNotify = (NewBieCourseRewardNotify)msg;
		ActivityNoviceJourneyData activityNoviceJourneyData = ActivityModel.Instance.GetActivityById(this.DataId) as ActivityNoviceJourneyData;
		if (activityNoviceJourneyData == null)
		{
			return;
		}
		activityNoviceJourneyData.SetReceiveData(newBieCourseRewardNotify.HadTakeReward);
	}

	// Token: 0x060062D9 RID: 25305 RVA: 0x001F80FC File Offset: 0x001F62FC
	public void RequestReward(int level)
	{
		NewBieCourseRewardRequest newBieCourseRewardRequest = NewBieCourseRewardRequest.Create();
		newBieCourseRewardRequest.Level = level;
		Net.Instance.Call(ERequestMessageId.NewBieCourseRewardRequest, newBieCourseRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			NewBieCourseRewardResponse newBieCourseRewardResponse = (NewBieCourseRewardResponse)msg;
			if (newBieCourseRewardResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(newBieCourseRewardResponse.ErrorCode, 17644, null, true, true);
				return;
			}
			ActivityNoviceJourneyData activityNoviceJourneyData = ActivityModel.Instance.GetActivityById(this.DataId) as ActivityNoviceJourneyData;
			if (activityNoviceJourneyData != null)
			{
				activityNoviceJourneyData.AddReceivedData(level);
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.DataId);
		}, 0);
	}

	// Token: 0x17000C23 RID: 3107
	// (get) Token: 0x060062DA RID: 25306 RVA: 0x001F814C File Offset: 0x001F634C
	public static ActivityNoviceJourneyController Instance
	{
		get
		{
			return ActivityNoviceJourneyController._Instance;
		}
	}

	// Token: 0x060062DB RID: 25307 RVA: 0x001F8153 File Offset: 0x001F6353
	public static ActivityNoviceJourneyController GetOrCreateInstance()
	{
		if (ActivityNoviceJourneyController._Instance == null)
		{
			ActivityNoviceJourneyController.CreateInstance();
		}
		return ActivityNoviceJourneyController._Instance;
	}

	// Token: 0x060062DC RID: 25308 RVA: 0x001F8167 File Offset: 0x001F6367
	public static bool CreateInstance()
	{
		if (ActivityNoviceJourneyController._Instance != null)
		{
			return true;
		}
		ActivityNoviceJourneyController._Instance = new ActivityNoviceJourneyController();
		return true;
	}

	// Token: 0x060062DD RID: 25309 RVA: 0x001F817D File Offset: 0x001F637D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060062DE RID: 25310 RVA: 0x001F817F File Offset: 0x001F637F
	public static void ResetStaticDefaultValue()
	{
		ActivityNoviceJourneyController._Instance = null;
	}

	// Token: 0x060062DF RID: 25311 RVA: 0x001F8187 File Offset: 0x001F6387
	static ActivityNoviceJourneyController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityNoviceJourneyController.CreateStaticDefaultValue), new Action(ActivityNoviceJourneyController.ResetStaticDefaultValue));
	}

	// Token: 0x04003FFF RID: 16383
	private int DataId;

	// Token: 0x04004000 RID: 16384
	[Nullable(2)]
	private static ActivityNoviceJourneyController _Instance;
}
