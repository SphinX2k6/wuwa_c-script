using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

// Token: 0x020013D4 RID: 5076
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityNoviceJourneyController : ActivityControllerBase
{
	// Token: 0x06008F39 RID: 36665 RVA: 0x001EF4EE File Offset: 0x001ED6EE
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, int, int, int, int, int, int>(EEventName.OnPlayerLevelChanged, new Action<int, int, int, int, int, int, int>(this.OnPlayerLevelChanged));
	}

	// Token: 0x06008F3A RID: 36666 RVA: 0x001EF50C File Offset: 0x001ED70C
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<int, int, int, int, int, int, int>(EEventName.OnPlayerLevelChanged, new Action<int, int, int, int, int, int, int>(this.OnPlayerLevelChanged));
	}

	// Token: 0x06008F3B RID: 36667 RVA: 0x001EF52A File Offset: 0x001ED72A
	private void OnPlayerLevelChanged(int i, int i1, int arg3, int arg4, int arg5, int arg6, int arg7)
	{
		if (this.DataId != 0)
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.DataId);
		}
	}

	// Token: 0x06008F3C RID: 36668 RVA: 0x001EF54A File Offset: 0x001ED74A
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.NewBieCourseRewardNotify, new Action<IMessage, Net.CallbackStatus>(this.OnNewBieCourseRewardNotify));
	}

	// Token: 0x06008F3D RID: 36669 RVA: 0x001EF568 File Offset: 0x001ED768
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.NewBieCourseRewardNotify);
	}

	// Token: 0x06008F3E RID: 36670 RVA: 0x001EF57A File Offset: 0x001ED77A
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06008F3F RID: 36671 RVA: 0x001EF57C File Offset: 0x001ED77C
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityRoleLevel";
	}

	// Token: 0x06008F40 RID: 36672 RVA: 0x001EF583 File Offset: 0x001ED783
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewNoviceJourney();
	}

	// Token: 0x06008F41 RID: 36673 RVA: 0x001EF58A File Offset: 0x001ED78A
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.DataId = data.Id;
		return new ActivityNoviceJourneyData();
	}

	// Token: 0x06008F42 RID: 36674 RVA: 0x001EF59D File Offset: 0x001ED79D
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06008F43 RID: 36675 RVA: 0x001EF5A0 File Offset: 0x001ED7A0
	[NullableContext(2)]
	private void OnNewBieCourseRewardNotify(IMessage msg, Net.CallbackStatus status)
	{
		NewBieCourseRewardNotify newBieCourseRewardNotify = (NewBieCourseRewardNotify)msg;
		ActivityNoviceJourneyData activityNoviceJourneyData = ActivityModel.Instance.GetActivityById(this.DataId) as ActivityNoviceJourneyData;
		if (activityNoviceJourneyData == null)
		{
			return;
		}
		activityNoviceJourneyData.SetReceiveData(newBieCourseRewardNotify.HadTakeReward.ToArray<int>());
	}

	// Token: 0x06008F44 RID: 36676 RVA: 0x001EF5E0 File Offset: 0x001ED7E0
	public void RequestReward(int level)
	{
		NewBieCourseRewardRequest newBieCourseRewardRequest = NewBieCourseRewardRequest.Create();
		newBieCourseRewardRequest.Level = level;
		Net.Instance.Call(ERequestMessageId.NewBieCourseRewardRequest, newBieCourseRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			NewBieCourseRewardResponse newBieCourseRewardResponse = (NewBieCourseRewardResponse)msg;
			if (newBieCourseRewardResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(newBieCourseRewardResponse.ErrorCode, 23806, null, true, true);
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

	// Token: 0x17000C03 RID: 3075
	// (get) Token: 0x06008F45 RID: 36677 RVA: 0x001EF630 File Offset: 0x001ED830
	public static ActivityNoviceJourneyController Instance
	{
		get
		{
			return ActivityNoviceJourneyController._Instance;
		}
	}

	// Token: 0x06008F46 RID: 36678 RVA: 0x001EF637 File Offset: 0x001ED837
	public static ActivityNoviceJourneyController GetOrCreateInstance()
	{
		if (ActivityNoviceJourneyController._Instance == null)
		{
			ActivityNoviceJourneyController.CreateInstance();
		}
		return ActivityNoviceJourneyController._Instance;
	}

	// Token: 0x06008F47 RID: 36679 RVA: 0x001EF64B File Offset: 0x001ED84B
	public static bool CreateInstance()
	{
		if (ActivityNoviceJourneyController._Instance != null)
		{
			return true;
		}
		ActivityNoviceJourneyController._Instance = new ActivityNoviceJourneyController();
		return true;
	}

	// Token: 0x06008F48 RID: 36680 RVA: 0x001EF661 File Offset: 0x001ED861
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06008F49 RID: 36681 RVA: 0x001EF663 File Offset: 0x001ED863
	public static void ResetStaticDefaultValue()
	{
		ActivityNoviceJourneyController._Instance = null;
	}

	// Token: 0x06008F4A RID: 36682 RVA: 0x001EF66B File Offset: 0x001ED86B
	static ActivityNoviceJourneyController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityNoviceJourneyController.CreateStaticDefaultValue), new Action(ActivityNoviceJourneyController.ResetStaticDefaultValue));
	}

	// Token: 0x04003F67 RID: 16231
	private int DataId;

	// Token: 0x04003F68 RID: 16232
	[Nullable(2)]
	private static ActivityNoviceJourneyController _Instance;
}
