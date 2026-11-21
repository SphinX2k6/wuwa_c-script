using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Functional;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x020016AE RID: 5806
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class MailController : UiControllerBase
{
	// Token: 0x0600E188 RID: 57736 RVA: 0x00421D90 File Offset: 0x0041FF90
	public static void ShowMailFloatTipsByTextKey(string textKey)
	{
		string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(textKey, "");
		if (StringUtils.IsEmpty(multiTextByKey))
		{
			return;
		}
		ScrollingTipsController.Instance.ShowTipsByText(multiTextByKey);
	}

	// Token: 0x0600E189 RID: 57737 RVA: 0x00421DC2 File Offset: 0x0041FFC2
	public static bool CanOpenView(EUiViewName viewName, object param)
	{
		return FunctionModel.Instance.IsOpen(10020);
	}

	// Token: 0x0600E18A RID: 57738 RVA: 0x00421DD3 File Offset: 0x0041FFD3
	protected override void OnAddOpenViewCheckFunction()
	{
		UiManager instance = UiManager.Instance;
		EUiViewName mailBoxView = EUiViewName.MailBoxView;
		Func<EUiViewName, object, bool> func;
		if ((func = MailController.<>O.<0>__CanOpenView) == null)
		{
			func = (MailController.<>O.<0>__CanOpenView = new Func<EUiViewName, object, bool>(MailController.CanOpenView));
		}
		instance.AddOpenViewCheckFunction(mailBoxView, func, "MailController.CanOpenView");
	}

	// Token: 0x0600E18B RID: 57739 RVA: 0x00421E04 File Offset: 0x00420004
	protected override void OnRemoveOpenViewCheckFunction()
	{
		UiManager instance = UiManager.Instance;
		EUiViewName formation2DView = EUiViewName.Formation2DView;
		Func<EUiViewName, object, bool> func;
		if ((func = MailController.<>O.<0>__CanOpenView) == null)
		{
			func = (MailController.<>O.<0>__CanOpenView = new Func<EUiViewName, object, bool>(MailController.CanOpenView));
		}
		instance.RemoveOpenViewCheckFunction(formation2DView, func);
	}

	// Token: 0x0600E18C RID: 57740 RVA: 0x00421E30 File Offset: 0x00420030
	protected override void OnAddEvents()
	{
		EventSystem instance = EventSystem.Instance;
		EEventName name = EEventName.WorldDoneAndCloseLoading;
		Action handle;
		if ((handle = MailController.<>O.<1>__OnWorldDoneAndCloseLoading) == null)
		{
			handle = (MailController.<>O.<1>__OnWorldDoneAndCloseLoading = new Action(MailController.OnWorldDoneAndCloseLoading));
		}
		instance.Add(name, handle);
	}

	// Token: 0x0600E18D RID: 57741 RVA: 0x00421E5D File Offset: 0x0042005D
	protected override void OnRemoveEvents()
	{
		EventSystem instance = EventSystem.Instance;
		EEventName name = EEventName.WorldDoneAndCloseLoading;
		Action handle;
		if ((handle = MailController.<>O.<1>__OnWorldDoneAndCloseLoading) == null)
		{
			handle = (MailController.<>O.<1>__OnWorldDoneAndCloseLoading = new Action(MailController.OnWorldDoneAndCloseLoading));
		}
		instance.Remove(name, handle);
	}

	// Token: 0x0600E18E RID: 57742 RVA: 0x00421E8C File Offset: 0x0042008C
	protected override void OnRegisterNetEvent()
	{
		Net instance = Net.Instance;
		ENotifyMessageId id = ENotifyMessageId.MailInfosNotify;
		Action<IMessage, Net.CallbackStatus> callback;
		if ((callback = MailController.<>O.<2>__OnMailInfosNotify) == null)
		{
			callback = (MailController.<>O.<2>__OnMailInfosNotify = new Action<IMessage, Net.CallbackStatus>(MailController.OnMailInfosNotify));
		}
		instance.Register(id, callback);
		Net instance2 = Net.Instance;
		ENotifyMessageId id2 = ENotifyMessageId.MailDeleteNotify;
		Action<IMessage, Net.CallbackStatus> callback2;
		if ((callback2 = MailController.<>O.<3>__OnMailDeleteNotify) == null)
		{
			callback2 = (MailController.<>O.<3>__OnMailDeleteNotify = new Action<IMessage, Net.CallbackStatus>(MailController.OnMailDeleteNotify));
		}
		instance2.Register(id2, callback2);
		Net instance3 = Net.Instance;
		ENotifyMessageId id3 = ENotifyMessageId.MailAddNotify;
		Action<IMessage, Net.CallbackStatus> callback3;
		if ((callback3 = MailController.<>O.<4>__OnMailAddNotify) == null)
		{
			callback3 = (MailController.<>O.<4>__OnMailAddNotify = new Action<IMessage, Net.CallbackStatus>(MailController.OnMailAddNotify));
		}
		instance3.Register(id3, callback3);
	}

	// Token: 0x0600E18F RID: 57743 RVA: 0x00421F1A File Offset: 0x0042011A
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.MailInfosNotify);
		Net.Instance.UnRegister(ENotifyMessageId.MailDeleteNotify);
		Net.Instance.UnRegister(ENotifyMessageId.MailAddNotify);
	}

	// Token: 0x0600E190 RID: 57744 RVA: 0x00421F4C File Offset: 0x0042014C
	[NullableContext(2)]
	private static void OnMailInfosNotify(IMessage msg, Net.CallbackStatus status)
	{
		MailInfosNotify mailInfosNotify = (MailInfosNotify)msg;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Mail;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "邮件控制器：OnMailInfosNotify [Mail]6100 Mails response, length: ";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("response.MailInfos.length", mailInfosNotify.MailInfos.Count);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		foreach (PbMailInfo mailInfo in mailInfosNotify.MailInfos)
		{
			if (MailModel.Instance.GetMailListLength() >= MailModel.Instance.GetMailCapacity())
			{
				Log.Instance.Error(ELogModule.Mail, ELogAuthor.YZY, "[MailError]MailBox is fulfilled", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			MailModel.Instance.AddMail(mailInfo, false);
		}
		MailModel.Instance.ReloadMailList();
		MailModel.Instance.RefreshLocalNewMailMap();
		MailController.TryShowNewMailTips("NewMail");
	}

	// Token: 0x0600E191 RID: 57745 RVA: 0x0042202C File Offset: 0x0042022C
	[NullableContext(2)]
	private static void OnMailDeleteNotify(IMessage msg, Net.CallbackStatus status)
	{
		MailDeleteNotify mailDeleteNotify = (MailDeleteNotify)msg;
		string id = mailDeleteNotify.Id;
		MailModel.Instance.DeleteMail(id);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Mail;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "邮件控制器：OnMailDeleteNotify A mail was deleted, id: ";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("deletingMailId", id);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (UiManager.Instance.IsViewShow(EUiViewName.MailContentView))
		{
			UiManager.Instance.CloseView(EUiViewName.MailContentView, null);
		}
		if (mailDeleteNotify.Reason == MailDeleteReason.PublicCancelled)
		{
			GenericPromptController.Instance.ShowPromptByCode("MailRecall", Array.Empty<object>());
		}
		else
		{
			GenericPromptController.Instance.ShowPromptByCode("MailDelete", Array.Empty<object>());
		}
		MailModel.Instance.RefreshLocalNewMailMap();
		EventSystem.Instance.Emit(EEventName.DeletingMailPassively);
	}

	// Token: 0x0600E192 RID: 57746 RVA: 0x004220E8 File Offset: 0x004202E8
	[NullableContext(2)]
	private static void OnMailAddNotify(IMessage msg, Net.CallbackStatus status)
	{
		MailAddNotify mailAddNotify = (MailAddNotify)msg;
		if (mailAddNotify.NewMail == null)
		{
			return;
		}
		if (MailModel.Instance.GetMailListLength() >= MailModel.Instance.GetMailCapacity())
		{
			Log.Instance.Error(ELogModule.Mail, ELogAuthor.YZY, "邮件控制器：MailBox is fulfilled!", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		PbMailInfo newMail = mailAddNotify.NewMail;
		if (MailModel.Instance.GetMailInstanceById(newMail.Id) != null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Mail;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "邮件控制器：This mail exist! id: ";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("newMailInfo.Id", newMail.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.Mail;
		ELogAuthor author2 = ELogAuthor.YZY;
		string message2 = "邮件控制器：OnMailAddNotify New mail added, id: ";
		ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("newMailInfo.Id", newMail.Id);
		instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		MailModel.Instance.AddMail(newMail, true);
		MailData mailInstanceById = MailModel.Instance.GetMailInstanceById(newMail.Id);
		if (mailInstanceById != null)
		{
			mailInstanceById.SetAddReason((int)mailAddNotify.Reason);
		}
		MailModel.Instance.RefreshLocalNewMailMap();
		if (mailAddNotify.Reason == MailAddReason.BagFull)
		{
			MailController.TryShowNewMailTips("BagOverLimit");
		}
		else
		{
			MailController.TryShowNewMailTips("NewMail");
		}
		EventSystem.Instance.Emit(EEventName.AddingNewMail);
	}

	// Token: 0x0600E193 RID: 57747 RVA: 0x00422210 File Offset: 0x00420410
	private static void OnWorldDoneAndCloseLoading()
	{
		MailController.TryShowNewMailTips("NewMail");
	}

	// Token: 0x0600E194 RID: 57748 RVA: 0x0042221C File Offset: 0x0042041C
	private static void TryShowNewMailTips(string promptId = "NewMail")
	{
		if (!GameModeModel.Instance.WorldDoneAndLoadingClosed)
		{
			return;
		}
		double num = Time.Instance.NowSeconds - MailModel.Instance.LastTimeShowNewMailTipsTime;
		int? newMailGap = CommonConfig.Instance.GetNewMailGap();
		double? num2 = (newMailGap != null) ? new double?((double)newMailGap.GetValueOrDefault()) : null;
		bool flag = num > num2.GetValueOrDefault() & num2 != null;
		if (flag && MailModel.Instance.IfNeedShowNewMail())
		{
			GenericPromptController.Instance.ShowPromptByCode(promptId, Array.Empty<object>());
			MailModel.Instance.SaveShowNewMailMap();
			MailModel.Instance.LastTimeShowNewMailTipsTime = Time.Instance.NowSeconds;
			return;
		}
		if (!flag && MailModel.Instance.IfNeedShowNewMail())
		{
			MailModel.Instance.SaveShowNewMailMap();
		}
	}

	// Token: 0x0600E195 RID: 57749 RVA: 0x004222E4 File Offset: 0x004204E4
	public static void SelectedMail(MailData selectedMail)
	{
		if (selectedMail != null)
		{
			if (selectedMail.GetWasScanned())
			{
				EventSystem.Instance.Emit<string, int>(EEventName.SelectedMail, selectedMail.Id, selectedMail.ConfigId);
				EventSystem.Instance.Emit(EEventName.SwitchUnfinishedFlag);
				return;
			}
			MailController.RequestReadMail(selectedMail.Id, selectedMail.ConfigId);
		}
	}

	// Token: 0x0600E196 RID: 57750 RVA: 0x0042233C File Offset: 0x0042053C
	public static void RequestReadMail(string mailId, int configId)
	{
		MailReadRequest mailReadRequest = MailReadRequest.Create();
		mailReadRequest.Id = mailId;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Mail;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "邮件控制器：RequestReadMail 未阅读邮件，申请阅读";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("mailId", mailId);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		Net.Instance.Call(ERequestMessageId.MailReadRequest, mailReadRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			MailController.OnReadMailResponse((MailReadResponse)msg, configId);
		}, 0);
	}

	// Token: 0x0600E197 RID: 57751 RVA: 0x004223A8 File Offset: 0x004205A8
	private static void OnReadMailResponse(MailReadResponse response, int configId)
	{
		if (response == null)
		{
			return;
		}
		if (response.ErrorCode != Aki.Protocol.ErrorCode.Success)
		{
			ErrorCodeController.Instance.OpenErrorCodeTipView(response.ErrorCode, 23666, null, true, true);
			return;
		}
		MailData mailInstanceById = MailModel.Instance.GetMailInstanceById(response.Id);
		if (mailInstanceById != null)
		{
			mailInstanceById.ReadTime = MathUtils.Instance.LongToNumber(response.ReadTime);
			mailInstanceById.ExpiryTime = MathUtils.Instance.LongToNumber(response.ExpiryTime);
			if (mailInstanceById.IsIntervalMail)
			{
				mailInstanceById.IntervalExpiryTime = mailInstanceById.ExpiryTime;
			}
			MailModel.Instance.SetMailStatusByStatusCode(response.State, mailInstanceById);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Mail;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "邮件控制器：OnReadMailResponse 阅读选中，状态码";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("response.State", response.State);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			EventSystem.Instance.Emit<string, int>(EEventName.SelectedMail, response.Id, configId);
			EventSystem.Instance.Emit(EEventName.SwitchUnfinishedFlag);
		}
	}

	// Token: 0x0600E198 RID: 57752 RVA: 0x0042249C File Offset: 0x0042069C
	public static void RequestPickAttachment(List<string> attachmentIds, EMailAttachmentPickType pickType)
	{
		MailGetAttachmentRequest mailGetAttachmentRequest = MailGetAttachmentRequest.Create();
		int value = ConfigCommonParamById.GetIntConfig("mail_take_limit").Value;
		int num = Math.Min(attachmentIds.Count, value);
		for (int i = 0; i < num; i++)
		{
			mailGetAttachmentRequest.MailIds.Add(attachmentIds[i]);
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Mail;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "邮件控制器：RequestPickAttachment 申请领取附件";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("attachmentIds", mailGetAttachmentRequest.MailIds);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		Net.Instance.Call(ERequestMessageId.MailGetAttachmentRequest, mailGetAttachmentRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			MailController.OnPickMailAttachmentResponse((MailGetAttachmentResponse)msg, pickType);
		}, 0);
	}

	// Token: 0x0600E199 RID: 57753 RVA: 0x0042254C File Offset: 0x0042074C
	private static void OnPickMailAttachmentResponse(MailGetAttachmentResponse response, EMailAttachmentPickType pickType)
	{
		if (response == null)
		{
			return;
		}
		if (response.ErrorCode == Aki.Protocol.ErrorCode.Success)
		{
			Dictionary<string, int> successIdMap = new Dictionary<string, int>(response.SuccessIdMap);
			MailModel.Instance.SetLastPickedAttachments(successIdMap, pickType);
			return;
		}
		int id = ConfigErrorCodeById.GetConfig((int)response.ErrorCode, true).Value.Id;
		string text = "";
		if (id != 10000)
		{
			if (id != 10008)
			{
				if (id == 400012)
				{
					text = "MailOverLimit";
				}
			}
			else
			{
				text = "MailOverLimit";
			}
		}
		else
		{
			text = "MailOutOfDate";
		}
		if (text != "")
		{
			GenericPromptController.Instance.ShowPromptByCode(text, Array.Empty<object>());
			return;
		}
		ErrorCodeController.Instance.OpenErrorCodeTipView(response.ErrorCode, 26747, null, true, true);
	}

	// Token: 0x0600E19A RID: 57754 RVA: 0x0042260C File Offset: 0x0042080C
	public static void RequestMailFavorite(string mailId, bool isFavorite, Action onFailed = null, Action onSuccess = null)
	{
		if (MailModel.Instance.CanRequestMailFavorite(mailId, isFavorite))
		{
			MailFavoriteRequest mailFavoriteRequest = MailFavoriteRequest.Create();
			mailFavoriteRequest.Id = mailId;
			mailFavoriteRequest.IsFavorite = isFavorite;
			Net.Instance.Call(ERequestMessageId.MailFavoriteRequest, mailFavoriteRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				MailFavoriteResponse mailFavoriteResponse = (MailFavoriteResponse)msg;
				if (mailFavoriteResponse == null)
				{
					Action onFailed3 = onFailed;
					if (onFailed3 == null)
					{
						return;
					}
					onFailed3();
					return;
				}
				else
				{
					long expiryTime = MathUtils.Instance.LongToNumber(mailFavoriteResponse.ExpiryTime);
					if (mailFavoriteResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
					{
						ErrorCodeController.Instance.OpenErrorCodeTipView(mailFavoriteResponse.ErrorCode, 17919, null, true, true);
						Action onFailed4 = onFailed;
						if (onFailed4 == null)
						{
							return;
						}
						onFailed4();
						return;
					}
					else
					{
						MailModel.Instance.ApplyMailFavoriteResponse(mailFavoriteResponse.Id, isFavorite, mailFavoriteResponse.State, expiryTime);
						Action onSuccess2 = onSuccess;
						if (onSuccess2 == null)
						{
							return;
						}
						onSuccess2();
						return;
					}
				}
			}, 0);
			return;
		}
		Action onFailed2 = onFailed;
		if (onFailed2 == null)
		{
			return;
		}
		onFailed2();
	}

	// Token: 0x0600E19B RID: 57755 RVA: 0x00422690 File Offset: 0x00420890
	public static void RequestDeleteFavoriteMail(string mailId)
	{
		MailData mailInstanceById = MailModel.Instance.GetMailInstanceById(mailId);
		if (mailInstanceById == null)
		{
			return;
		}
		if (!mailInstanceById.IsFavorite)
		{
			MailController.RequestDeleteMail(new List<string>
			{
				mailId
			});
			return;
		}
		MailController.RequestMailFavorite(mailId, false, null, delegate
		{
			MailController.RequestDeleteMail(new List<string>
			{
				mailId
			});
		});
	}

	// Token: 0x0600E19C RID: 57756 RVA: 0x004226F8 File Offset: 0x004208F8
	public static void RequestDeleteMail(List<string> mailIds)
	{
		MailDeleteRequest mailDeleteRequest = MailDeleteRequest.Create();
		mailDeleteRequest.MailIds.AddRange(mailIds);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Mail;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "邮件控制器：RequestDeleteMail请求删除邮件";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("mailId", mailIds);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		Net.Instance.Call(ERequestMessageId.MailDeleteRequest, mailDeleteRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			MailDeleteResponse mailDeleteResponse = (MailDeleteResponse)msg;
			if (mailDeleteResponse == null)
			{
				return;
			}
			MailController.OnDeleteMailResponse(mailDeleteResponse);
		}, 0);
	}

	// Token: 0x0600E19D RID: 57757 RVA: 0x00422770 File Offset: 0x00420970
	private static void OnDeleteMailResponse(MailDeleteResponse response)
	{
		if (response.ErrorCode != Aki.Protocol.ErrorCode.Success)
		{
			ErrorCodeController.Instance.OpenErrorCodeTipView(response.ErrorCode, 22089, null, true, true);
			return;
		}
		if (response.SuccessIds.Count > 0)
		{
			foreach (string mailId in response.SuccessIds)
			{
				MailModel.Instance.DeleteMail(mailId);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Mail;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "邮件控制器：删除邮件";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("邮件id", response.SuccessIds);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			GenericPromptController.Instance.ShowPromptByCode("MailDelete", Array.Empty<object>());
			EventSystem.Instance.Emit<IReadOnlyList<string>>(EEventName.DeletingMail, response.SuccessIds);
		}
	}

	// Token: 0x0600E19E RID: 57758 RVA: 0x0042284C File Offset: 0x00420A4C
	public static void OpenMailJumpView(MailData mailData)
	{
		int subContentJumpId = mailData.GetSubContentJumpId();
		int subContentJumpParam = mailData.GetSubContentJumpParam();
		int subContentJumpParam2 = mailData.GetSubContentJumpParam2();
		MailTo? mailToConfigById = MailConfig.Instance.GetMailToConfigById(subContentJumpId);
		if (mailToConfigById != null)
		{
			if (MailController.TryOpenMailToInventoryJump(mailToConfigById.Value.JumpId, subContentJumpParam, subContentJumpParam2))
			{
				return;
			}
			SkipTaskManager.RunByConfigId(mailToConfigById.Value.JumpId, null);
			return;
		}
		else
		{
			if (MailController.TryMailJump((EFunctionType)subContentJumpId, subContentJumpParam, subContentJumpParam2))
			{
				return;
			}
			FunctionController.Instance.OpenFunctionRelateView((EFunctionType)subContentJumpId);
			return;
		}
	}

	// Token: 0x0600E19F RID: 57759 RVA: 0x004228CC File Offset: 0x00420ACC
	private static bool TryOpenMailToInventoryJump(int accessPathId, int jumpParam, int jumpParam2)
	{
		AccessPath? accessPathConfig = SkipInterfaceConfig.Instance.GetAccessPathConfig(accessPathId);
		if (accessPathConfig == null)
		{
			return false;
		}
		if (accessPathConfig.Value.SkipName != 38)
		{
			return false;
		}
		if (accessPathConfig.Value.Val1 != EUiViewName.InventoryView)
		{
			return false;
		}
		FunctionModel instance = FunctionModel.Instance;
		foreach (KeyValuePair<int, string> keyValuePair in accessPathConfig.Value.FunctionOpenCheckMap())
		{
			if (!instance.IsOpen(keyValuePair.Key))
			{
				GenericPromptController.Instance.ShowPromptByCode(keyValuePair.Value, Array.Empty<object>());
				return true;
			}
		}
		int num2;
		int num = int.TryParse(accessPathConfig.Value.Val2, out num2) ? num2 : 0;
		int num3 = (jumpParam > 0) ? jumpParam : num;
		int num4 = (jumpParam2 > 0) ? jumpParam2 : 0;
		if (num3 <= 0 && num4 <= 0)
		{
			UiManager.Instance.OpenView(EUiViewName.InventoryView, null, null);
			return true;
		}
		return MailController.OpenMailBagJump(num3, num4);
	}

	// Token: 0x0600E1A0 RID: 57760 RVA: 0x00422A00 File Offset: 0x00420C00
	private static bool TryMailJump(EFunctionType jumpId, int jumpParam, int jumpParam2)
	{
		if (jumpParam <= 0 && jumpParam2 <= 0)
		{
			return false;
		}
		if (jumpId <= EFunctionType.Shop)
		{
			switch (jumpId)
			{
			case EFunctionType.Role:
			case EFunctionType.Calabash:
				break;
			case EFunctionType.Bag:
				return MailController.OpenMailBagJump(jumpParam, jumpParam2);
			default:
				if (jumpId != EFunctionType.Gacha)
				{
					if (jumpId != EFunctionType.Shop)
					{
						return false;
					}
					if (jumpParam > 0)
					{
						MailController.OpenMailShopJump(jumpParam, jumpParam2);
						return true;
					}
					return false;
				}
				else
				{
					if (jumpParam > 0)
					{
						GachaController.Instance.OpenGachaView(jumpParam);
						return true;
					}
					return false;
				}
				break;
			}
		}
		else if (jumpId <= EFunctionType.AdventureGuide)
		{
			if (jumpId != EFunctionType.Tutorial)
			{
				if (jumpId != EFunctionType.AdventureGuide)
				{
					return false;
				}
			}
			else
			{
				if (jumpParam > 0)
				{
					UiManager.Instance.OpenView(EUiViewName.TutorialView, new TutorialViewParam
					{
						TutorialId = new int?(jumpParam)
					}, null);
					return true;
				}
				return false;
			}
		}
		else if (jumpId != EFunctionType.HandBookSystem)
		{
			if (jumpId != EFunctionType.Activity)
			{
				return false;
			}
			if (jumpParam > 0)
			{
				ActivityController.Instance.OpenActivityById(jumpParam, EActivityViewOpenType.Other, null, null);
				return true;
			}
			return false;
		}
		else
		{
			if (jumpParam > 0)
			{
				UiManager.Instance.OpenView(EUiViewName.HandBookEntranceView, new HandBookEntranceViewParam
				{
					SelectedTabType = (EHandBookTabType)jumpParam
				}, null);
				return true;
			}
			return false;
		}
		return MailController.OpenMailJumpSubTab(jumpId, jumpParam, jumpParam2);
	}

	// Token: 0x0600E1A1 RID: 57761 RVA: 0x00422B1C File Offset: 0x00420D1C
	private static bool OpenMailJumpSubTab(EFunctionType jumpId, int jumpParam, int jumpParam2)
	{
		if (jumpParam <= 0)
		{
			return false;
		}
		EUiViewName? euiViewName = null;
		if (jumpId != EFunctionType.Role)
		{
			if (jumpId != EFunctionType.Calabash)
			{
				if (jumpId != EFunctionType.AdventureGuide)
				{
					return false;
				}
				euiViewName = new EUiViewName?(EUiViewName.AdventureGuideView);
			}
			else
			{
				euiViewName = new EUiViewName?(EUiViewName.CalabashRootView);
			}
		}
		else
		{
			euiViewName = new EUiViewName?(EUiViewName.RoleRootView);
		}
		List<UiDynamicTab> tabList;
		if (jumpId == EFunctionType.AdventureGuide)
		{
			tabList = new List<UiDynamicTab>(AdventureGuideModel.Instance.GetAdventureGuideTabList());
		}
		else
		{
			tabList = DynamicTabConfig.Instance.GetViewTabList(euiViewName.Value);
		}
		UiDynamicTab? uiDynamicTab = MailController.FindMailJumpTab(tabList, jumpParam);
		if (uiDynamicTab == null)
		{
			return false;
		}
		EUiTabViewName euiTabViewName = (EUiTabViewName)uiDynamicTab.Value.ChildViewName;
		int? num = (jumpParam2 > 0) ? new int?(jumpParam2) : null;
		if (euiViewName == EUiViewName.AdventureGuideView)
		{
			AdventureGuideController.Instance.OpenGuideView(new EUiTabViewName?(euiTabViewName), num, null, null);
			return true;
		}
		if (euiViewName == EUiViewName.CalabashRootView)
		{
			CalabashController.Instance.JumpToCalabashRootView(euiTabViewName, num);
			return true;
		}
		if (euiViewName == EUiViewName.RoleRootView)
		{
			RoleController.Instance.OpenRoleMainView(ERoleAgentType.Normal, 0, null, new EUiTabViewName?(euiTabViewName), null);
			return true;
		}
		return false;
	}

	// Token: 0x0600E1A2 RID: 57762 RVA: 0x00422CAC File Offset: 0x00420EAC
	private static UiDynamicTab? FindMailJumpTab(List<UiDynamicTab> tabList, int jumpParam)
	{
		foreach (UiDynamicTab value in tabList)
		{
			if (value.Id == jumpParam)
			{
				return new UiDynamicTab?(value);
			}
		}
		foreach (UiDynamicTab value2 in tabList)
		{
			if (value2.TabIndex == jumpParam)
			{
				return new UiDynamicTab?(value2);
			}
		}
		if (jumpParam >= 0 && jumpParam < tabList.Count)
		{
			return new UiDynamicTab?(tabList[jumpParam]);
		}
		return null;
	}

	// Token: 0x0600E1A3 RID: 57763 RVA: 0x00422D78 File Offset: 0x00420F78
	private static void OpenMailShopJump(int shopId, int subTabId)
	{
		if (!FunctionModel.Instance.IsOpen(10010))
		{
			GenericPromptController.Instance.ShowPromptByCode("FunctionDisable", Array.Empty<object>());
			return;
		}
		if (shopId == 1 && subTabId > 0)
		{
			PayShopViewData data = new PayShopViewData
			{
				PayShopId = PayShopDefine.EPayShopTabType.Recommend,
				RecommendId = new int?(subTabId)
			};
			if (UiManager.Instance.IsViewOpen(EUiViewName.PayShopRootView))
			{
				UiManager.Instance.CloseView(EUiViewName.PayShopRootView, null);
			}
			PayShopController.Instance.OpenPayShopView(data, null);
			return;
		}
		PayShopController.Instance.OpenPayShopViewWithTab((PayShopDefine.EPayShopTabType)shopId, subTabId);
	}

	// Token: 0x0600E1A4 RID: 57764 RVA: 0x00422E08 File Offset: 0x00421008
	private static bool OpenMailBagJump(int mainTypeId, int uniqueId)
	{
		if (mainTypeId <= 0 && uniqueId <= 0)
		{
			return false;
		}
		if (mainTypeId > 0)
		{
			int num = InventoryModel.Instance.GetOpenIdMainTypeConfig().FindIndex((ItemMainType item) => item.Id == mainTypeId);
			if (num >= 0)
			{
				InventoryModel.Instance.SetSelectedTypeIndex(num);
			}
		}
		if (uniqueId > 0)
		{
			UiManager.Instance.OpenView(EUiViewName.InventoryView, uniqueId, null);
		}
		else
		{
			UiManager.Instance.OpenView(EUiViewName.InventoryView, null, null);
		}
		return true;
	}

	// Token: 0x0600E1A5 RID: 57765 RVA: 0x00422E94 File Offset: 0x00421094
	public static void RecordMailJumpLog(MailData mailData)
	{
		MailJumpLogEvent logData = new MailJumpLogEvent
		{
			s_mail_id = mailData.Id,
			i_level = mailData.GetMailLevel(),
			l_received_time = (long)mailData.GetReceiveTime(),
			i_reason = mailData.GetAddReason(),
			l_take_time = (long)TimeUtil.Instance.GetServerTimeStamp()
		};
		LogReportController.Instance.LogReport(logData);
	}

	// Token: 0x17001591 RID: 5521
	// (get) Token: 0x0600E1A6 RID: 57766 RVA: 0x00422EF4 File Offset: 0x004210F4
	public static MailController Instance
	{
		get
		{
			return MailController._Instance;
		}
	}

	// Token: 0x0600E1A7 RID: 57767 RVA: 0x00422EFB File Offset: 0x004210FB
	public static MailController GetOrCreateInstance()
	{
		if (MailController._Instance == null)
		{
			MailController.CreateInstance();
		}
		return MailController._Instance;
	}

	// Token: 0x0600E1A8 RID: 57768 RVA: 0x00422F0F File Offset: 0x0042110F
	public static bool CreateInstance()
	{
		if (MailController._Instance != null)
		{
			return true;
		}
		MailController._Instance = new MailController();
		return true;
	}

	// Token: 0x0600E1A9 RID: 57769 RVA: 0x00422F25 File Offset: 0x00421125
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600E1AA RID: 57770 RVA: 0x00422F27 File Offset: 0x00421127
	public static void ResetStaticDefaultValue()
	{
		MailController._Instance = null;
	}

	// Token: 0x0600E1AB RID: 57771 RVA: 0x00422F2F File Offset: 0x0042112F
	static MailController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MailController.CreateStaticDefaultValue), new Action(MailController.ResetStaticDefaultValue));
	}

	// Token: 0x0400811A RID: 33050
	[Nullable(2)]
	private static MailController _Instance;

	// Token: 0x02007892 RID: 30866
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x040271D9 RID: 160217
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Func<EUiViewName, object, bool> <0>__CanOpenView;

		// Token: 0x040271DA RID: 160218
		[Nullable(0)]
		public static Action <1>__OnWorldDoneAndCloseLoading;

		// Token: 0x040271DB RID: 160219
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <2>__OnMailInfosNotify;

		// Token: 0x040271DC RID: 160220
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <3>__OnMailDeleteNotify;

		// Token: 0x040271DD RID: 160221
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <4>__OnMailAddNotify;
	}
}
