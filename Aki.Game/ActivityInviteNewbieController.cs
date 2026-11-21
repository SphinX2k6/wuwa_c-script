using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x0200073C RID: 1852
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityInviteNewbieController : ActivityControllerBase
{
	// Token: 0x0600553B RID: 21819 RVA: 0x001C1035 File Offset: 0x001BF235
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x0600553C RID: 21820 RVA: 0x001C1037 File Offset: 0x001BF237
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ReferralCampaignMain";
	}

	// Token: 0x0600553D RID: 21821 RVA: 0x001C103E File Offset: 0x001BF23E
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new InviteNewbieSubView();
	}

	// Token: 0x0600553E RID: 21822 RVA: 0x001C1045 File Offset: 0x001BF245
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return InviteNewbieModel.Instance.ActivityData;
	}

	// Token: 0x0600553F RID: 21823 RVA: 0x001C1051 File Offset: 0x001BF251
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06005540 RID: 21824 RVA: 0x001C1054 File Offset: 0x001BF254
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.H5CircumFluenceActivityDataNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleActivityDataNotify));
	}

	// Token: 0x06005541 RID: 21825 RVA: 0x001C1072 File Offset: 0x001BF272
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.H5CircumFluenceActivityDataNotify);
	}

	// Token: 0x06005542 RID: 21826 RVA: 0x001C1084 File Offset: 0x001BF284
	[NullableContext(2)]
	private void HandleActivityDataNotify(IMessage msg, Net.CallbackStatus _)
	{
		H5CircumFluenceActivityDataNotify notify = (H5CircumFluenceActivityDataNotify)msg;
		InviteNewbieModel.Instance.SyncActivityNotify(notify);
	}

	// Token: 0x06005543 RID: 21827 RVA: 0x001C10A3 File Offset: 0x001BF2A3
	public void HandleOnRewardClick(InviteNewbieProtocolContext activityData)
	{
		if (activityData != null)
		{
			activityData.SetCurrentLoginClickState(true);
		}
		this.OpenUrl();
	}

	// Token: 0x06005544 RID: 21828 RVA: 0x001C10B5 File Offset: 0x001BF2B5
	public void HandleOnEnterClick(InviteNewbieProtocolContext activityData)
	{
		if (activityData != null)
		{
			activityData.SetCurrentLoginClickState(true);
		}
		this.OpenUrl();
	}

	// Token: 0x06005545 RID: 21829 RVA: 0x001C10C7 File Offset: 0x001BF2C7
	public void HandleOnCopyInviteCodeClick()
	{
		string inviteCode = InviteNewbieModel.Instance.InviteCode;
		ScrollingTipsController.Instance.ShowTipsByTextId("Activity_104600001_CopyTips", Array.Empty<object>());
		ULGUIBPLibrary.ClipBoardCopy(inviteCode);
	}

	// Token: 0x06005546 RID: 21830 RVA: 0x001C10EC File Offset: 0x001BF2EC
	private void RequestSaveReadState()
	{
		H5CircumFluenceActivityReadRequest message = H5CircumFluenceActivityReadRequest.Create();
		Net.Instance.Call(ERequestMessageId.H5CircumFluenceActivityReadRequest, message, delegate(IMessage response, Net.CallbackStatus _)
		{
		}, 0);
	}

	// Token: 0x06005547 RID: 21831 RVA: 0x001C1130 File Offset: 0x001BF330
	private void OpenUrl()
	{
		string rootUrl = InviteNewbieModel.Instance.RootUrl;
		if (StringUtils.IsEmpty(rootUrl))
		{
			Log.Instance.Info(ELogModule.InviteNewbie, ELogAuthor.WZ, "无法获取根链接", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		string text = PublicUtil.Instance.GetExternalUrl(rootUrl, PublicUtil.EExternalUrlReason.InviteNewbie);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.InviteNewbie;
		ELogAuthor author = ELogAuthor.WZ;
		string message = "打开外部链接";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("url", text);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (text != null)
		{
			InviteNewbieModel.Instance.SaveClickState();
			this.RequestSaveReadState();
			EventSystem.Instance.Emit(EEventName.InviteNewbieEntered);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, InviteNewbieModel.Instance.CurrentActivityId);
			if (InviteNewbieModel.Instance.IsInternalBrowser)
			{
				if (KuroSdkController.Instance.CanUseSdk())
				{
					text = PublicUtil.Instance.GetExtendExternalUrl(text, true);
					KuroSdkController.Instance.OpenWebView("", text, true, true, true, "Default");
					return;
				}
				text = PublicUtil.Instance.GetExtendExternalUrl(text, false);
				KuroSdkController.Instance.OpenExternalUrl(text);
				return;
			}
			else
			{
				text = PublicUtil.Instance.GetExtendExternalUrl(text, false);
				KuroSdkController.Instance.OpenExternalUrl(text);
			}
		}
	}

	// Token: 0x17000B3B RID: 2875
	// (get) Token: 0x06005548 RID: 21832 RVA: 0x001C1258 File Offset: 0x001BF458
	public static ActivityInviteNewbieController Instance
	{
		get
		{
			return ActivityInviteNewbieController._Instance;
		}
	}

	// Token: 0x06005549 RID: 21833 RVA: 0x001C125F File Offset: 0x001BF45F
	public static ActivityInviteNewbieController GetOrCreateInstance()
	{
		if (ActivityInviteNewbieController._Instance == null)
		{
			ActivityInviteNewbieController.CreateInstance();
		}
		return ActivityInviteNewbieController._Instance;
	}

	// Token: 0x0600554A RID: 21834 RVA: 0x001C1273 File Offset: 0x001BF473
	public static bool CreateInstance()
	{
		if (ActivityInviteNewbieController._Instance != null)
		{
			return true;
		}
		ActivityInviteNewbieController._Instance = new ActivityInviteNewbieController();
		return true;
	}

	// Token: 0x0600554B RID: 21835 RVA: 0x001C1289 File Offset: 0x001BF489
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600554C RID: 21836 RVA: 0x001C128B File Offset: 0x001BF48B
	public static void ResetStaticDefaultValue()
	{
		ActivityInviteNewbieController._Instance = null;
	}

	// Token: 0x0600554D RID: 21837 RVA: 0x001C1293 File Offset: 0x001BF493
	static ActivityInviteNewbieController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityInviteNewbieController.CreateStaticDefaultValue), new Action(ActivityInviteNewbieController.ResetStaticDefaultValue));
	}

	// Token: 0x04003B4F RID: 15183
	[Nullable(2)]
	private static ActivityInviteNewbieController _Instance;
}
