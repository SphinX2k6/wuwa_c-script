using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Google.Protobuf;

// Token: 0x020010BF RID: 4287
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityLinkageController : ActivityControllerBase
{
	// Token: 0x06006F9A RID: 28570 RVA: 0x0016BA16 File Offset: 0x00169C16
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06006F9B RID: 28571 RVA: 0x0016BA18 File Offset: 0x00169C18
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06006F9C RID: 28572 RVA: 0x0016BA1B File Offset: 0x00169C1B
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_LinkageMain";
	}

	// Token: 0x06006F9D RID: 28573 RVA: 0x0016BA22 File Offset: 0x00169C22
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivityLinkageSubView();
	}

	// Token: 0x06006F9E RID: 28574 RVA: 0x0016BA29 File Offset: 0x00169C29
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.ActivityId = data.Id;
		return new global::ActivityLinkageData();
	}

	// Token: 0x06006F9F RID: 28575 RVA: 0x0016BA3C File Offset: 0x00169C3C
	public global::ActivityLinkageData GetActivityLinkageData()
	{
		ActivityModel instance = ActivityModel.Instance;
		return ((instance != null) ? instance.GetActivityById(this.ActivityId) : null) as global::ActivityLinkageData;
	}

	// Token: 0x06006FA0 RID: 28576 RVA: 0x0016BA5C File Offset: 0x00169C5C
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(linkageRewardResponse.ErrorCode, 25500, null, true, true);
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

	// Token: 0x17000973 RID: 2419
	// (get) Token: 0x06006FA1 RID: 28577 RVA: 0x0016BAB8 File Offset: 0x00169CB8
	public static ActivityLinkageController Instance
	{
		get
		{
			return ActivityLinkageController._Instance;
		}
	}

	// Token: 0x06006FA2 RID: 28578 RVA: 0x0016BABF File Offset: 0x00169CBF
	public static ActivityLinkageController GetOrCreateInstance()
	{
		if (ActivityLinkageController._Instance == null)
		{
			ActivityLinkageController.CreateInstance();
		}
		return ActivityLinkageController._Instance;
	}

	// Token: 0x06006FA3 RID: 28579 RVA: 0x0016BAD3 File Offset: 0x00169CD3
	public static bool CreateInstance()
	{
		if (ActivityLinkageController._Instance != null)
		{
			return true;
		}
		ActivityLinkageController._Instance = new ActivityLinkageController();
		return true;
	}

	// Token: 0x06006FA4 RID: 28580 RVA: 0x0016BAE9 File Offset: 0x00169CE9
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006FA5 RID: 28581 RVA: 0x0016BAEB File Offset: 0x00169CEB
	public static void ResetStaticDefaultValue()
	{
		ActivityLinkageController._Instance = null;
	}

	// Token: 0x06006FA6 RID: 28582 RVA: 0x0016BAF3 File Offset: 0x00169CF3
	static ActivityLinkageController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityLinkageController.CreateStaticDefaultValue), new Action(ActivityLinkageController.ResetStaticDefaultValue));
	}

	// Token: 0x040033DD RID: 13277
	private int ActivityId;

	// Token: 0x040033DE RID: 13278
	[Nullable(2)]
	private static ActivityLinkageController _Instance;
}
