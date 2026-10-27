using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x02002501 RID: 9473
[Controller(0)]
public class PhoneMsgController : ControllerBase
{
	// Token: 0x060130AD RID: 77997 RVA: 0x004B6E34 File Offset: 0x004B5034
	protected override bool OnInit()
	{
		this.OnAddEvents();
		this.OnRegisterNetEvent();
		InputManager.Instance.RegisterOpenViewFunc(EUiViewName.PhoneMsgPanelViewBig, new Action(this.OpenPhoneMsgPanelViewBigByShortKey));
		return true;
	}

	// Token: 0x060130AE RID: 77998 RVA: 0x004B6E5E File Offset: 0x004B505E
	protected override bool OnClear()
	{
		this.OnRemoveEvents();
		this.OnUnRegisterNetEvent();
		return true;
	}

	// Token: 0x060130AF RID: 77999 RVA: 0x004B6E70 File Offset: 0x004B5070
	protected void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Add(EEventName.ShowFloatTips, new Action(this.TryShowPhoneMsgTipView));
		EventSystem.Instance.Add(EEventName.OnNewPhoneMsgNeedShowTips, new Action(this.TryShowPhoneMsgTipView));
	}

	// Token: 0x060130B0 RID: 78000 RVA: 0x004B6ED4 File Offset: 0x004B50D4
	protected void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Remove(EEventName.ShowFloatTips, new Action(this.TryShowPhoneMsgTipView));
		EventSystem.Instance.Remove(EEventName.OnNewPhoneMsgNeedShowTips, new Action(this.TryShowPhoneMsgTipView));
	}

	// Token: 0x060130B1 RID: 78001 RVA: 0x004B6F35 File Offset: 0x004B5135
	protected void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.ShortMessageUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPhoneMsgNotify));
		Net.Instance.Register(ENotifyMessageId.ShortMessageItemUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPhoneMsgDialogAndBgAddNotify));
	}

	// Token: 0x060130B2 RID: 78002 RVA: 0x004B6F6F File Offset: 0x004B516F
	protected void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.ShortMessageUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.ShortMessageItemUpdateNotify);
	}

	// Token: 0x060130B3 RID: 78003 RVA: 0x004B6F91 File Offset: 0x004B5191
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

	// Token: 0x060130B4 RID: 78004 RVA: 0x004B6FD0 File Offset: 0x004B51D0
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

	// Token: 0x060130B5 RID: 78005 RVA: 0x004B7054 File Offset: 0x004B5254
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

	// Token: 0x060130B6 RID: 78006 RVA: 0x004B70D8 File Offset: 0x004B52D8
	[NullableContext(2)]
	private void OnPhoneMsgNotify(IMessage msg, Net.CallbackStatus _)
	{
		ShortMessageUpdateNotify shortMessageUpdateNotify = (ShortMessageUpdateNotify)msg;
		if (shortMessageUpdateNotify != null)
		{
			PhoneMsgModel.Instance.OnPhoneMsgUpdateNotify(shortMessageUpdateNotify);
		}
	}

	// Token: 0x060130B7 RID: 78007 RVA: 0x004B70FA File Offset: 0x004B52FA
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

	// Token: 0x060130B8 RID: 78008 RVA: 0x004B712C File Offset: 0x004B532C
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

	// Token: 0x060130B9 RID: 78009 RVA: 0x004B72BC File Offset: 0x004B54BC
	[NullableContext(2)]
	private void OnPhoneMsgDialogAndBgAddNotify(IMessage msg, Net.CallbackStatus _)
	{
		ShortMessageItemUpdateNotify shortMessageItemUpdateNotify = (ShortMessageItemUpdateNotify)msg;
		if (shortMessageItemUpdateNotify != null)
		{
			PhoneMsgModel.Instance.OnPhoneMsgDialogAndBgAddNotify(shortMessageItemUpdateNotify);
		}
	}

	// Token: 0x060130BA RID: 78010 RVA: 0x004B72DE File Offset: 0x004B54DE
	private void OnWorldDone()
	{
		this.RequestAllMsg();
	}

	// Token: 0x060130BB RID: 78011 RVA: 0x004B72E8 File Offset: 0x004B54E8
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

	// Token: 0x060130BC RID: 78012 RVA: 0x004B733C File Offset: 0x004B553C
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

	// Token: 0x060130BD RID: 78013 RVA: 0x004B73B0 File Offset: 0x004B55B0
	public void RequestAllMsg()
	{
		ShortMessageInfoRequest message = ShortMessageInfoRequest.Create();
		Net.Instance.Call(ERequestMessageId.ShortMessageInfoRequest, message, new Action<IMessage, Net.CallbackStatus>(this.HandleRequestAllMsgResponse), 0);
	}

	// Token: 0x060130BE RID: 78014 RVA: 0x004B73E0 File Offset: 0x004B55E0
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
			PhoneMsgModel.Instance.AddMessages(shortMessageInfos.ToList<ShortMessageInfo>(), null, false, true);
		}
	}

	// Token: 0x060130BF RID: 78015 RVA: 0x004B746C File Offset: 0x004B566C
	public UniTask<bool> SetOneMessageAsReadAsync(int shortMessageId)
	{
		PhoneMsgController.<SetOneMessageAsReadAsync>d__19 <SetOneMessageAsReadAsync>d__;
		<SetOneMessageAsReadAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<SetOneMessageAsReadAsync>d__.shortMessageId = shortMessageId;
		<SetOneMessageAsReadAsync>d__.<>1__state = -1;
		<SetOneMessageAsReadAsync>d__.<>t__builder.Start<PhoneMsgController.<SetOneMessageAsReadAsync>d__19>(ref <SetOneMessageAsReadAsync>d__);
		return <SetOneMessageAsReadAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060130C0 RID: 78016 RVA: 0x004B74B0 File Offset: 0x004B56B0
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

	// Token: 0x060130C1 RID: 78017 RVA: 0x004B7504 File Offset: 0x004B5704
	public UniTask<bool> ShortMessageReceiveAsync(int shortMessageId)
	{
		PhoneMsgController.<ShortMessageReceiveAsync>d__21 <ShortMessageReceiveAsync>d__;
		<ShortMessageReceiveAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<ShortMessageReceiveAsync>d__.shortMessageId = shortMessageId;
		<ShortMessageReceiveAsync>d__.<>1__state = -1;
		<ShortMessageReceiveAsync>d__.<>t__builder.Start<PhoneMsgController.<ShortMessageReceiveAsync>d__21>(ref <ShortMessageReceiveAsync>d__);
		return <ShortMessageReceiveAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060130C2 RID: 78018 RVA: 0x004B7548 File Offset: 0x004B5748
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

	// Token: 0x060130C3 RID: 78019 RVA: 0x004B759C File Offset: 0x004B579C
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
			ErrorCodeController.Instance.OpenErrorCodeTipView(shortMessageShowChangeResponse.ErrCode, 29072, null, true, true);
		}, 0);
	}

	// Token: 0x060130C4 RID: 78020 RVA: 0x004B75F8 File Offset: 0x004B57F8
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
			ErrorCodeController.Instance.OpenErrorCodeTipView(shortMessageChatThemeChangeResponse.ErrCode, 19186, null, true, true);
		}, 0);
	}

	// Token: 0x060130C5 RID: 78021 RVA: 0x004B7644 File Offset: 0x004B5844
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
			ErrorCodeController.Instance.OpenErrorCodeTipView(shortMessageChatCharmChangeResponse.ErrCode, 18908, null, true, true);
		}, 0);
	}

	// Token: 0x060130C6 RID: 78022 RVA: 0x004B7690 File Offset: 0x004B5890
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

	// Token: 0x170018CD RID: 6349
	// (get) Token: 0x060130C7 RID: 78023 RVA: 0x004B78E7 File Offset: 0x004B5AE7
	[Nullable(1)]
	public static PhoneMsgController Instance
	{
		[NullableContext(1)]
		get
		{
			return PhoneMsgController._Instance;
		}
	}

	// Token: 0x060130C8 RID: 78024 RVA: 0x004B78EE File Offset: 0x004B5AEE
	[NullableContext(1)]
	public static PhoneMsgController GetOrCreateInstance()
	{
		if (PhoneMsgController._Instance == null)
		{
			PhoneMsgController.CreateInstance();
		}
		return PhoneMsgController._Instance;
	}

	// Token: 0x060130C9 RID: 78025 RVA: 0x004B7902 File Offset: 0x004B5B02
	public static bool CreateInstance()
	{
		if (PhoneMsgController._Instance != null)
		{
			return true;
		}
		PhoneMsgController._Instance = new PhoneMsgController();
		return true;
	}

	// Token: 0x060130CA RID: 78026 RVA: 0x004B7918 File Offset: 0x004B5B18
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060130CB RID: 78027 RVA: 0x004B791A File Offset: 0x004B5B1A
	public static void ResetStaticDefaultValue()
	{
		PhoneMsgController._Instance = null;
	}

	// Token: 0x060130CC RID: 78028 RVA: 0x004B7922 File Offset: 0x004B5B22
	static PhoneMsgController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhoneMsgController.CreateStaticDefaultValue), new Action(PhoneMsgController.ResetStaticDefaultValue));
	}

	// Token: 0x04008F6E RID: 36718
	public bool IsPhoneMsgTipEnable = true;

	// Token: 0x04008F6F RID: 36719
	[Nullable(2)]
	private static PhoneMsgController _Instance;
}
