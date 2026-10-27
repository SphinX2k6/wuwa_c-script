using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x02001288 RID: 4744
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityInviteNewbieController : ActivityControllerBase
{
	// Token: 0x060081A4 RID: 33188 RVA: 0x001B8365 File Offset: 0x001B6565
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x060081A5 RID: 33189 RVA: 0x001B8367 File Offset: 0x001B6567
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ReferralCampaignMain";
	}

	// Token: 0x060081A6 RID: 33190 RVA: 0x001B836E File Offset: 0x001B656E
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new InviteNewbieSubView();
	}

	// Token: 0x060081A7 RID: 33191 RVA: 0x001B8375 File Offset: 0x001B6575
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return InviteNewbieModel.Instance.ActivityData;
	}

	// Token: 0x060081A8 RID: 33192 RVA: 0x001B8381 File Offset: 0x001B6581
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x060081A9 RID: 33193 RVA: 0x001B8384 File Offset: 0x001B6584
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.H5CircumFluenceActivityDataNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleActivityDataNotify));
	}

	// Token: 0x060081AA RID: 33194 RVA: 0x001B83A2 File Offset: 0x001B65A2
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.H5CircumFluenceActivityDataNotify);
	}

	// Token: 0x060081AB RID: 33195 RVA: 0x001B83B4 File Offset: 0x001B65B4
	[NullableContext(2)]
	private void HandleActivityDataNotify(IMessage msg, Net.CallbackStatus _)
	{
		H5CircumFluenceActivityDataNotify notify = (H5CircumFluenceActivityDataNotify)msg;
		InviteNewbieModel.Instance.SyncActivityNotify(notify);
	}

	// Token: 0x060081AC RID: 33196 RVA: 0x001B83D3 File Offset: 0x001B65D3
	public void HandleOnRewardClick(InviteNewbieProtocolContext activityData)
	{
		if (activityData != null)
		{
			activityData.SetCurrentLoginClickState(true);
		}
		this.OpenUrl();
	}

	// Token: 0x060081AD RID: 33197 RVA: 0x001B83E5 File Offset: 0x001B65E5
	public void HandleOnEnterClick(InviteNewbieProtocolContext activityData)
	{
		if (activityData != null)
		{
			activityData.SetCurrentLoginClickState(true);
		}
		this.OpenUrl();
	}

	// Token: 0x060081AE RID: 33198 RVA: 0x001B83F7 File Offset: 0x001B65F7
	public void HandleOnCopyInviteCodeClick()
	{
		string inviteCode = InviteNewbieModel.Instance.InviteCode;
		ScrollingTipsController.Instance.ShowTipsByTextId("Activity_104600001_CopyTips", Array.Empty<object>());
		ULGUIBPLibrary.ClipBoardCopy(inviteCode);
	}

	// Token: 0x060081AF RID: 33199 RVA: 0x001B841C File Offset: 0x001B661C
	private void RequestSaveReadState()
	{
		H5CircumFluenceActivityReadRequest message = H5CircumFluenceActivityReadRequest.Create();
		Net.Instance.Call(ERequestMessageId.H5CircumFluenceActivityReadRequest, message, delegate(IMessage response, Net.CallbackStatus _)
		{
		}, 0);
	}

	// Token: 0x060081B0 RID: 33200 RVA: 0x001B8460 File Offset: 0x001B6660
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

	// Token: 0x17000B1B RID: 2843
	// (get) Token: 0x060081B1 RID: 33201 RVA: 0x001B8588 File Offset: 0x001B6788
	public static ActivityInviteNewbieController Instance
	{
		get
		{
			return ActivityInviteNewbieController._Instance;
		}
	}

	// Token: 0x060081B2 RID: 33202 RVA: 0x001B858F File Offset: 0x001B678F
	public static ActivityInviteNewbieController GetOrCreateInstance()
	{
		if (ActivityInviteNewbieController._Instance == null)
		{
			ActivityInviteNewbieController.CreateInstance();
		}
		return ActivityInviteNewbieController._Instance;
	}

	// Token: 0x060081B3 RID: 33203 RVA: 0x001B85A3 File Offset: 0x001B67A3
	public static bool CreateInstance()
	{
		if (ActivityInviteNewbieController._Instance != null)
		{
			return true;
		}
		ActivityInviteNewbieController._Instance = new ActivityInviteNewbieController();
		return true;
	}

	// Token: 0x060081B4 RID: 33204 RVA: 0x001B85B9 File Offset: 0x001B67B9
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060081B5 RID: 33205 RVA: 0x001B85BB File Offset: 0x001B67BB
	public static void ResetStaticDefaultValue()
	{
		ActivityInviteNewbieController._Instance = null;
	}

	// Token: 0x060081B6 RID: 33206 RVA: 0x001B85C3 File Offset: 0x001B67C3
	static ActivityInviteNewbieController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityInviteNewbieController.CreateStaticDefaultValue), new Action(ActivityInviteNewbieController.ResetStaticDefaultValue));
	}

	// Token: 0x04003AB7 RID: 15031
	[Nullable(2)]
	private static ActivityInviteNewbieController _Instance;
}
