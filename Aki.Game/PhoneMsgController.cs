using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.PhoneMessage;
using CSharpScript.Game.Module.PhoneMessage.View;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;

// Token: 0x020019E8 RID: 6632
[Controller(0)]
public class PhoneMsgController : ControllerBase
{
	// Token: 0x0601056C RID: 66924 RVA: 0x004C4AC4 File Offset: 0x004C2CC4
	protected override bool OnInit()
	{
		this.OnAddEvents();
		this.OnRegisterNetEvent();
		InputManager.Instance.RegisterOpenViewFunc(EUiViewName.PhoneMsgPanelViewBig, new Action(this.OpenPhoneMsgPanelViewBigByShortKey));
		return true;
	}

	// Token: 0x0601056D RID: 66925 RVA: 0x004C4AEE File Offset: 0x004C2CEE
	protected override bool OnClear()
	{
		this.OnRemoveEvents();
		this.OnUnRegisterNetEvent();
		return true;
	}

	// Token: 0x0601056E RID: 66926 RVA: 0x004C4B00 File Offset: 0x004C2D00
	protected void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Add(EEventName.ShowFloatTips, new Action(this.TryShowPhoneMsgTipView));
		EventSystem.Instance.Add(EEventName.OnNewPhoneMsgNeedShowTips, new Action(this.TryShowPhoneMsgTipView));
	}

	// Token: 0x0601056F RID: 66927 RVA: 0x004C4B64 File Offset: 0x004C2D64
	protected void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Remove(EEventName.ShowFloatTips, new Action(this.TryShowPhoneMsgTipView));
		EventSystem.Instance.Remove(EEventName.OnNewPhoneMsgNeedShowTips, new Action(this.TryShowPhoneMsgTipView));
	}

	// Token: 0x06010570 RID: 66928 RVA: 0x004C4BC5 File Offset: 0x004C2DC5
	protected void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.ShortMessageUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPhoneMsgNotify));
		Net.Instance.Register(ENotifyMessageId.ShortMessageItemUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPhoneMsgDialogAndBgAddNotify));
	}

	// Token: 0x06010571 RID: 66929 RVA: 0x004C4BFF File Offset: 0x004C2DFF
	protected void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.ShortMessageUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.ShortMessageItemUpdateNotify);
	}

	// Token: 0x06010572 RID: 66930 RVA: 0x004C4C21 File Offset: 0x004C2E21
	public void OpenPhoneMsgPanelViewBigByShortKey()
	{
		if (!FunctionModel.Instance.IsOpen(10130))
		{
			return;
		}
		if (!UiManager.Instance.IsViewOpen(EUiViewName.PhoneMsgPanelViewBig))
		{
			this.OpenAndJumpShowTipShortMessage(EPhoneMsgOpenWay.HotKey, EPhoneMsgViewType.Big);
			return;
		}
		UiManager.Instance.CloseView(EUiViewName.PhoneMsgPanelViewBig, null);
	}

	// Token: 0x06010573 RID: 66931 RVA: 0x004C4C60 File Offset: 0x004C2E60
	public void OpenAndJumpShowTipShortMessage(EPhoneMsgOpenWay openWay, EPhoneMsgViewType viewType)
	{
		int currentShowingMsgIdInSmallHead = PhoneMsgModel.Instance.CurrentShowingMsgIdInSmallHead;
		PhoneMsgPanelViewData param = new PhoneMsgPanelViewData
		{
			ShortMessage = null,
			NeedShowTips = false,
			OpenWay = openWay,
			ViewType = viewType
		};
		if (currentShowingMsgIdInSmallHead != 0)
		{
			ShortMessage? phoneMsgConfig = PhoneMsgConfig.Instance.GetPhoneMsgConfig(currentShowingMsgIdInSmallHead);
			param = new PhoneMsgPanelViewData
			{
				ShortMessage = phoneMsgConfig,
				NeedShowTips = false,
				OpenWay = openWay,
				ViewType = viewType
			};
		}
		UiManager.Instance.OpenView(EUiViewName.PhoneMsgPanelViewBig, param, null);
	}

	// Token: 0x06010574 RID: 66932 RVA: 0x004C4CE4 File Offset: 0x004C2EE4
	public void QuickOpenPhoneMsgPanelViewBig(int msgId, EPhoneMsgOpenWay openWay)
	{
		ShortMessage? phoneMsgConfig = PhoneMsgConfig.Instance.GetPhoneMsgConfig(msgId);
		if (phoneMsgConfig == null)
		{
			Log.Instance.Error(ELogModule.PhoneSystem, ELogAuthor.LZK, "短信配置不存在，msgId: " + msgId.ToString(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		PhoneMsgPanelViewData param = new PhoneMsgPanelViewData
		{
			ShortMessage = phoneMsgConfig,
			NeedShowTips = false,
			OpenWay = openWay,
			ViewType = EPhoneMsgViewType.Big
		};
		UiManager.Instance.OpenView(EUiViewName.PhoneMsgPanelViewBig, param, null);
	}

	// Token: 0x06010575 RID: 66933 RVA: 0x004C4D68 File Offset: 0x004C2F68
	[NullableContext(2)]
	private void OnPhoneMsgNotify(IMessage msg, Net.CallbackStatus _)
	{
		ShortMessageUpdateNotify shortMessageUpdateNotify = (ShortMessageUpdateNotify)msg;
		if (shortMessageUpdateNotify != null)
		{
			PhoneMsgModel.Instance.OnPhoneMsgUpdateNotify(shortMessageUpdateNotify);
		}
	}

	// Token: 0x06010576 RID: 66934 RVA: 0x004C4D8A File Offset: 0x004C2F8A
	private void TryShowPhoneMsgTipView()
	{
		if (!UiModel.Instance.IsInMainView)
		{
			return;
		}
		if (!this.IsPhoneMsgTipEnable)
		{
			return;
		}
		if (!PhoneMsgModel.Instance.CheckIsInWhiteList())
		{
			return;
		}
		this.TopPanelCheckAndPlayPhoneSequence();
		this.OpenPhoneMsgTipView();
	}

	// Token: 0x06010577 RID: 66935 RVA: 0x004C4DBC File Offset: 0x004C2FBC
	public void OpenPhoneMsgTipView()
	{
		List<int> currentToBeNotifiedMsgArray = PhoneMsgModel.Instance.CurrentToBeNotifiedMsgArray;
		if (!PhoneMsgModel.Instance.IsPhoneChatShowInitDone)
		{
			Log.Instance.Warn(ELogModule.PhoneSystem, ELogAuthor.LZK, "[仅警告，无需处理] 聊天气泡&背景未初始化完成，不能弹出短信弹窗提示，已缓存等待初始化完成后会正常弹出", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		int count = currentToBeNotifiedMsgArray.Count;
		for (int i = 0; i < count; i++)
		{
			int shortMessageId = currentToBeNotifiedMsgArray[i];
			ShortMessage? phoneMsgConfig = PhoneMsgConfig.Instance.GetPhoneMsgConfig(shortMessageId);
			if (phoneMsgConfig != null)
			{
				switch (phoneMsgConfig.Value.TipType)
				{
				case 2:
					Log.Instance.Error(ELogModule.PhoneSystem, ELogAuthor.LZK, "短信弹窗提示类型B未已经弃用,请通知策划更改配置", default(ReadOnlySpan<ValueTuple<string, object>>));
					break;
				case 3:
				{
					PhoneMsgPanelViewData param = new PhoneMsgPanelViewData
					{
						ShortMessage = phoneMsgConfig,
						NeedShowTips = true,
						OpenWay = EPhoneMsgOpenWay.ForceOpen,
						ViewType = EPhoneMsgViewType.Small
					};
					UiManager.Instance.OpenView(EUiViewName.PhoneMsgPanelViewSmall, param, null);
					break;
				}
				case 4:
				{
					PhoneMsgPanelViewData param2 = new PhoneMsgPanelViewData
					{
						ShortMessage = phoneMsgConfig,
						NeedShowTips = false,
						OpenWay = EPhoneMsgOpenWay.ForceOpen,
						ViewType = EPhoneMsgViewType.Small
					};
					UiManager.Instance.OpenView(EUiViewName.PhoneMsgPanelViewSmall, param2, null);
					break;
				}
				case 5:
				{
					PhoneMsgPanelViewData param3 = new PhoneMsgPanelViewData
					{
						ShortMessage = phoneMsgConfig,
						NeedShowTips = true,
						NeedForceReadAllMsg = true,
						OpenWay = EPhoneMsgOpenWay.ForceOpen,
						ViewType = EPhoneMsgViewType.Small
					};
					UiManager.Instance.OpenView(EUiViewName.PhoneMsgPanelViewSmall, param3, null);
					break;
				}
				}
			}
		}
		currentToBeNotifiedMsgArray.Clear();
	}

	// Token: 0x06010578 RID: 66936 RVA: 0x004C4F4C File Offset: 0x004C314C
	[NullableContext(2)]
	private void OnPhoneMsgDialogAndBgAddNotify(IMessage msg, Net.CallbackStatus _)
	{
		ShortMessageItemUpdateNotify shortMessageItemUpdateNotify = (ShortMessageItemUpdateNotify)msg;
		if (shortMessageItemUpdateNotify != null)
		{
			PhoneMsgModel.Instance.OnPhoneMsgDialogAndBgAddNotify(shortMessageItemUpdateNotify);
		}
	}

	// Token: 0x06010579 RID: 66937 RVA: 0x004C4F6E File Offset: 0x004C316E
	private void OnWorldDone()
	{
		this.RequestAllMsg();
	}

	// Token: 0x0601057A RID: 66938 RVA: 0x004C4F78 File Offset: 0x004C3178
	public void TopPanelCheckAndPlayPhoneSequence()
	{
		UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.BattleView);
		if (viewByName == null)
		{
			return;
		}
		BattleViewProxy battleViewProxy = viewByName.OpenParam as BattleViewProxy;
		if (battleViewProxy == null)
		{
			return;
		}
		IPhoneMessageButtonImplement topPanelPhoneMsgButton = battleViewProxy.GetTopPanelPhoneMsgButton();
		if (topPanelPhoneMsgButton == null)
		{
			return;
		}
		if (PhoneMsgModel.Instance.CurrentToBeNotifiedMsgInSmallHeadQueue.Count == 0)
		{
			return;
		}
		topPanelPhoneMsgButton.CheckAndPlayPhoneSequence();
	}

	// Token: 0x0601057B RID: 66939 RVA: 0x004C4FCC File Offset: 0x004C31CC
	public void TopPanelCheckAndPopHead(int clickId)
	{
		UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.BattleView);
		if (viewByName == null)
		{
			return;
		}
		BattleViewProxy battleViewProxy = viewByName.OpenParam as BattleViewProxy;
		if (battleViewProxy == null)
		{
			return;
		}
		if (battleViewProxy.GetTopPanelPhoneMsgButton() == null)
		{
			return;
		}
		List<int> currentToBeNotifiedMsgInSmallHeadQueue = PhoneMsgModel.Instance.CurrentToBeNotifiedMsgInSmallHeadQueue;
		int num = currentToBeNotifiedMsgInSmallHeadQueue.IndexOf(clickId);
		if (num != -1)
		{
			currentToBeNotifiedMsgInSmallHeadQueue.RemoveAt(num);
		}
		int currentShowingMsgIdInSmallHead = PhoneMsgModel.Instance.CurrentShowingMsgIdInSmallHead;
		if (clickId == currentShowingMsgIdInSmallHead)
		{
			PhoneMsgModel.Instance.CurrentShowingMsgIdInSmallHead = 0;
		}
	}

	// Token: 0x0601057C RID: 66940 RVA: 0x004C5040 File Offset: 0x004C3240
	public void RequestAllMsg()
	{
		ShortMessageInfoRequest message = ShortMessageInfoRequest.Create();
		Net.Instance.Call(ERequestMessageId.ShortMessageInfoRequest, message, new Action<IMessage, Net.CallbackStatus>(this.HandleRequestAllMsgResponse), 0);
	}

	// Token: 0x0601057D RID: 66941 RVA: 0x004C5070 File Offset: 0x004C3270
	[NullableContext(2)]
	private void HandleRequestAllMsgResponse(IMessage msg, Net.CallbackStatus _)
	{
		ShortMessageInfoResponse shortMessageInfoResponse = (ShortMessageInfoResponse)msg;
		if (shortMessageInfoResponse == null)
		{
			return;
		}
		RepeatedField<ShortMessageInfo> shortMessageInfos = shortMessageInfoResponse.ShortMessageInfos;
		if (shortMessageInfos != null)
		{
			PhoneMsgModel.Instance.InitChatShow(shortMessageInfoResponse.BubbleId, shortMessageInfoResponse.ChatBgId, shortMessageInfoResponse.ChatThemeId, shortMessageInfoResponse.ChatCharmId, new List<int>(shortMessageInfoResponse.BubbleIds), new List<int>(shortMessageInfoResponse.ChatBgIds), new List<int>(shortMessageInfoResponse.ChatThemeIds), new List<int>(shortMessageInfoResponse.ChatCharmIds));
			PhoneMsgModel.Instance.AddMessages(shortMessageInfos, null, false, true);
		}
	}

	// Token: 0x0601057E RID: 66942 RVA: 0x004C50F8 File Offset: 0x004C32F8
	public UniTask<bool> SetOneMessageAsReadAsync(int shortMessageId)
	{
		PhoneMsgController.<SetOneMessageAsReadAsync>d__19 <SetOneMessageAsReadAsync>d__;
		<SetOneMessageAsReadAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<SetOneMessageAsReadAsync>d__.shortMessageId = shortMessageId;
		<SetOneMessageAsReadAsync>d__.<>1__state = -1;
		<SetOneMessageAsReadAsync>d__.<>t__builder.Start<PhoneMsgController.<SetOneMessageAsReadAsync>d__19>(ref <SetOneMessageAsReadAsync>d__);
		return <SetOneMessageAsReadAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601057F RID: 66943 RVA: 0x004C513C File Offset: 0x004C333C
	public UniTask<bool> ShortMessageReplyAsync(int shortMessageId, int talkIndex, int selectId)
	{
		PhoneMsgController.<ShortMessageReplyAsync>d__20 <ShortMessageReplyAsync>d__;
		<ShortMessageReplyAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<ShortMessageReplyAsync>d__.shortMessageId = shortMessageId;
		<ShortMessageReplyAsync>d__.talkIndex = talkIndex;
		<ShortMessageReplyAsync>d__.selectId = selectId;
		<ShortMessageReplyAsync>d__.<>1__state = -1;
		<ShortMessageReplyAsync>d__.<>t__builder.Start<PhoneMsgController.<ShortMessageReplyAsync>d__20>(ref <ShortMessageReplyAsync>d__);
		return <ShortMessageReplyAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010580 RID: 66944 RVA: 0x004C5190 File Offset: 0x004C3390
	public UniTask<bool> ShortMessageReceiveAsync(int shortMessageId)
	{
		PhoneMsgController.<ShortMessageReceiveAsync>d__21 <ShortMessageReceiveAsync>d__;
		<ShortMessageReceiveAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<ShortMessageReceiveAsync>d__.shortMessageId = shortMessageId;
		<ShortMessageReceiveAsync>d__.<>1__state = -1;
		<ShortMessageReceiveAsync>d__.<>t__builder.Start<PhoneMsgController.<ShortMessageReceiveAsync>d__21>(ref <ShortMessageReceiveAsync>d__);
		return <ShortMessageReceiveAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010581 RID: 66945 RVA: 0x004C51D4 File Offset: 0x004C33D4
	public UniTask<bool> UpdateProgressOfOneMessageAsync(int shortMessageId, int readIndex, bool isFinish)
	{
		PhoneMsgController.<UpdateProgressOfOneMessageAsync>d__22 <UpdateProgressOfOneMessageAsync>d__;
		<UpdateProgressOfOneMessageAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<UpdateProgressOfOneMessageAsync>d__.shortMessageId = shortMessageId;
		<UpdateProgressOfOneMessageAsync>d__.readIndex = readIndex;
		<UpdateProgressOfOneMessageAsync>d__.isFinish = isFinish;
		<UpdateProgressOfOneMessageAsync>d__.<>1__state = -1;
		<UpdateProgressOfOneMessageAsync>d__.<>t__builder.Start<PhoneMsgController.<UpdateProgressOfOneMessageAsync>d__22>(ref <UpdateProgressOfOneMessageAsync>d__);
		return <UpdateProgressOfOneMessageAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010582 RID: 66946 RVA: 0x004C5228 File Offset: 0x004C3428
	public void SendChangeChatDialogAndBgRequest(int chatDialogId, int chatBgId)
	{
		ShortMessageShowChangeRequest shortMessageShowChangeRequest = ShortMessageShowChangeRequest.Create();
		shortMessageShowChangeRequest.BubbleId = chatDialogId;
		shortMessageShowChangeRequest.ChatBgId = chatBgId;
		Net.Instance.Call(ERequestMessageId.ShortMessageShowChangeRequest, shortMessageShowChangeRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ShortMessageShowChangeResponse shortMessageShowChangeResponse = (ShortMessageShowChangeResponse)msg;
			if (shortMessageShowChangeResponse == null)
			{
				return;
			}
			if (shortMessageShowChangeResponse.ErrCode == Aki.Protocol.ErrorCode.Success)
			{
				PhoneMsgModel.Instance.CurrentUsingChatDialogId = chatDialogId;
				PhoneMsgModel.Instance.CurrentUsingChatBgId = chatBgId;
				EventSystem.Instance.Emit(EEventName.OnPhoneMsgChatShowChange);
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(shortMessageShowChangeResponse.ErrCode, 27652, null, true, true);
		}, 0);
	}

	// Token: 0x06010583 RID: 66947 RVA: 0x004C5284 File Offset: 0x004C3484
	public void SendChangeChatThemeRequest(int chatThemeId)
	{
		ShortMessageChatThemeChangeRequest shortMessageChatThemeChangeRequest = ShortMessageChatThemeChangeRequest.Create();
		shortMessageChatThemeChangeRequest.ChatThemeId = chatThemeId;
		Net.Instance.Call(ERequestMessageId.ShortMessageChatThemeChangeRequest, shortMessageChatThemeChangeRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ShortMessageChatThemeChangeResponse shortMessageChatThemeChangeResponse = (ShortMessageChatThemeChangeResponse)msg;
			if (shortMessageChatThemeChangeResponse == null)
			{
				return;
			}
			if (shortMessageChatThemeChangeResponse.ErrCode == Aki.Protocol.ErrorCode.Success)
			{
				PhoneMsgModel.Instance.CurrentUsingChatThemeId = chatThemeId;
				EventSystem.Instance.Emit(EEventName.OnPhoneMsgChatShowChange);
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(shortMessageChatThemeChangeResponse.ErrCode, 21146, null, true, true);
		}, 0);
	}

	// Token: 0x06010584 RID: 66948 RVA: 0x004C52D0 File Offset: 0x004C34D0
	public void SendChangeChatCharmRequest(int chatCharmId)
	{
		ShortMessageChatCharmChangeRequest shortMessageChatCharmChangeRequest = ShortMessageChatCharmChangeRequest.Create();
		shortMessageChatCharmChangeRequest.ChatCharmId = chatCharmId;
		Net.Instance.Call(ERequestMessageId.ShortMessageChatCharmChangeRequest, shortMessageChatCharmChangeRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ShortMessageChatCharmChangeResponse shortMessageChatCharmChangeResponse = (ShortMessageChatCharmChangeResponse)msg;
			if (shortMessageChatCharmChangeResponse == null)
			{
				return;
			}
			if (shortMessageChatCharmChangeResponse.ErrCode == Aki.Protocol.ErrorCode.Success)
			{
				PhoneMsgModel.Instance.CurrentUsingChatCharmId = chatCharmId;
				EventSystem.Instance.Emit(EEventName.OnPhoneMsgChatShowChange);
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(shortMessageChatCharmChangeResponse.ErrCode, 15958, null, true, true);
		}, 0);
	}

	// Token: 0x06010585 RID: 66949 RVA: 0x004C531C File Offset: 0x004C351C
	public void OpenAttachmentImgView(int attachmentId)
	{
		PhoneMessageAttachment? config = ConfigPhoneMessageAttachmentById.GetConfig(attachmentId, true);
		if (config != null && !string.IsNullOrEmpty(config.Value.AttachmentPath))
		{
			bool flag = PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male;
			string text = config.Value.AttachmentPathMaleVariant;
			string type = config.Value.Type;
			if (type == EAttachmentType.Image.ToEnumString())
			{
				InfoDisplayModel.Instance.SetCurrentShowAttachmentType(EAttachmentType.Image);
				if (string.IsNullOrEmpty(text))
				{
					text = config.Value.AttachmentPath;
				}
				else
				{
					text = (flag ? config.Value.AttachmentPathMaleVariant : config.Value.AttachmentPath);
				}
				InfoDisplayModel.Instance.SetCurrentOpenInformationTexture(text);
			}
			else if (type == EAttachmentType.Spine.ToEnumString())
			{
				string currentShowSpineAtlasPath = "";
				string currentShowSpineDataPath = "";
				if (string.IsNullOrEmpty(text))
				{
					string[] array = config.Value.AttachmentPath.Split(',', StringSplitOptions.None);
					if (array.Length >= 2)
					{
						currentShowSpineAtlasPath = array[0];
						currentShowSpineDataPath = array[1];
					}
					InfoDisplayModel.Instance.SetAnimName("idle");
				}
				else
				{
					string text2 = flag ? config.Value.AttachmentPathMaleVariant : config.Value.AttachmentPath;
					string animName = flag ? "nan" : "nv";
					string[] array2 = config.Value.AttachmentPath.Split(',', StringSplitOptions.None);
					if (array2.Length >= 2)
					{
						currentShowSpineAtlasPath = array2[0];
						currentShowSpineDataPath = array2[1];
					}
					InfoDisplayModel.Instance.SetAnimName(animName);
				}
				InfoDisplayModel.Instance.SetCurrentShowSpineAtlasPath(currentShowSpineAtlasPath);
				InfoDisplayModel.Instance.SetCurrentShowSpineDataPath(currentShowSpineDataPath);
				InfoDisplayModel.Instance.SetCurrentShowAttachmentType(EAttachmentType.Spine);
			}
			else
			{
				if (type == EAttachmentType.Mp4.ToEnumString())
				{
					InfoDisplayModel.Instance.SetCurrentShowAttachmentType(EAttachmentType.Mp4);
					Log.Instance.Error(ELogModule.PhoneSystem, ELogAuthor.LZK, "尚未支持附件类型为 " + type + ",的放大功能。 附件Id: " + attachmentId.ToString(), default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				Log.Instance.Error(ELogModule.PhoneSystem, ELogAuthor.LZK, "未知的附件类型 " + type + ", 附件Id: " + attachmentId.ToString(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			InfoDisplayController.Instance.OpenInfoDisplayAttachmentBigImgView();
		}
	}

	// Token: 0x17001907 RID: 6407
	// (get) Token: 0x06010586 RID: 66950 RVA: 0x004C5573 File Offset: 0x004C3773
	[Nullable(1)]
	public static PhoneMsgController Instance
	{
		[NullableContext(1)]
		get
		{
			return PhoneMsgController._Instance;
		}
	}

	// Token: 0x06010587 RID: 66951 RVA: 0x004C557A File Offset: 0x004C377A
	[NullableContext(1)]
	public static PhoneMsgController GetOrCreateInstance()
	{
		if (PhoneMsgController._Instance == null)
		{
			PhoneMsgController.CreateInstance();
		}
		return PhoneMsgController._Instance;
	}

	// Token: 0x06010588 RID: 66952 RVA: 0x004C558E File Offset: 0x004C378E
	public static bool CreateInstance()
	{
		if (PhoneMsgController._Instance != null)
		{
			return true;
		}
		PhoneMsgController._Instance = new PhoneMsgController();
		return true;
	}

	// Token: 0x06010589 RID: 66953 RVA: 0x004C55A4 File Offset: 0x004C37A4
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601058A RID: 66954 RVA: 0x004C55A6 File Offset: 0x004C37A6
	public static void ResetStaticDefaultValue()
	{
		PhoneMsgController._Instance = null;
	}

	// Token: 0x0601058B RID: 66955 RVA: 0x004C55AE File Offset: 0x004C37AE
	static PhoneMsgController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhoneMsgController.CreateStaticDefaultValue), new Action(PhoneMsgController.ResetStaticDefaultValue));
	}

	// Token: 0x040090B8 RID: 37048
	public bool IsPhoneMsgTipEnable = true;

	// Token: 0x040090B9 RID: 37049
	[Nullable(2)]
	private static PhoneMsgController _Instance;
}
