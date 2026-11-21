using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Google.Protobuf;

// Token: 0x02000573 RID: 1395
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityLinkageController : ActivityControllerBase
{
	// Token: 0x06004330 RID: 17200 RVA: 0x0017438E File Offset: 0x0017258E
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06004331 RID: 17201 RVA: 0x00174390 File Offset: 0x00172590
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06004332 RID: 17202 RVA: 0x00174393 File Offset: 0x00172593
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_LinkageMain";
	}

	// Token: 0x06004333 RID: 17203 RVA: 0x0017439A File Offset: 0x0017259A
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivityLinkageSubView();
	}

	// Token: 0x06004334 RID: 17204 RVA: 0x001743A1 File Offset: 0x001725A1
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.ActivityId = data.Id;
		return new global::ActivityLinkageData();
	}

	// Token: 0x06004335 RID: 17205 RVA: 0x001743B4 File Offset: 0x001725B4
	public global::ActivityLinkageData GetActivityLinkageData()
	{
		ActivityModel instance = ActivityModel.Instance;
		return ((instance != null) ? instance.GetActivityById(this.ActivityId) : null) as global::ActivityLinkageData;
	}

	// Token: 0x06004336 RID: 17206 RVA: 0x001743D4 File Offset: 0x001725D4
	public void RequestReward(int tabId)
	{
		LinkageRewardRequest linkageRewardRequest = LinkageRewardRequest.Create();
		linkageRewardRequest.ActivityId = this.ActivityId;
		linkageRewardRequest.ActivityPageId = tabId;
		Net.Instance.Call(ERequestMessageId.LinkageRewardRequest, linkageRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			LinkageRewardResponse linkageRewardResponse = (LinkageRewardResponse)msg;
			if (linkageRewardResponse == null)
			{
				return;
			}
			if (linkageRewardResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(linkageRewardResponse.ErrorCode, 23303, null, true, true);
				return;
			}
			global::ActivityLinkageData activityLinkageData = this.GetActivityLinkageData();
			if (activityLinkageData == null)
			{
				return;
			}
			activityLinkageData.ReceiveReward(tabId);
		}, 0);
	}

	// Token: 0x17000993 RID: 2451
	// (get) Token: 0x06004337 RID: 17207 RVA: 0x00174430 File Offset: 0x00172630
	public static ActivityLinkageController Instance
	{
		get
		{
			return ActivityLinkageController._Instance;
		}
	}

	// Token: 0x06004338 RID: 17208 RVA: 0x00174437 File Offset: 0x00172637
	public static ActivityLinkageController GetOrCreateInstance()
	{
		if (ActivityLinkageController._Instance == null)
		{
			ActivityLinkageController.CreateInstance();
		}
		return ActivityLinkageController._Instance;
	}

	// Token: 0x06004339 RID: 17209 RVA: 0x0017444B File Offset: 0x0017264B
	public static bool CreateInstance()
	{
		if (ActivityLinkageController._Instance != null)
		{
			return true;
		}
		ActivityLinkageController._Instance = new ActivityLinkageController();
		return true;
	}

	// Token: 0x0600433A RID: 17210 RVA: 0x00174461 File Offset: 0x00172661
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600433B RID: 17211 RVA: 0x00174463 File Offset: 0x00172663
	public static void ResetStaticDefaultValue()
	{
		ActivityLinkageController._Instance = null;
	}

	// Token: 0x0600433C RID: 17212 RVA: 0x0017446B File Offset: 0x0017266B
	static ActivityLinkageController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityLinkageController.CreateStaticDefaultValue), new Action(ActivityLinkageController.ResetStaticDefaultValue));
	}

	// Token: 0x04003476 RID: 13430
	private int ActivityId;

	// Token: 0x04003477 RID: 13431
	[Nullable(2)]
	private static ActivityLinkageController _Instance;
}
