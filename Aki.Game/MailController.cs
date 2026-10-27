using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Functional;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x020021CA RID: 8650
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class MailController : UiControllerBase
{
	// Token: 0x06010CF7 RID: 68855 RVA: 0x004154B0 File Offset: 0x004136B0
	public static void ShowMailFloatTipsByTextKey(string textKey)
	{
		string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(textKey, "");
		if (StringUtils.IsEmpty(multiTextByKey))
		{
			return;
		}
		ScrollingTipsController.Instance.ShowTipsByText(multiTextByKey);
	}

	// Token: 0x06010CF8 RID: 68856 RVA: 0x004154E2 File Offset: 0x004136E2
	public static bool CanOpenView(EUiViewName viewName, object param)
	{
		return FunctionModel.Instance.IsOpen(10020);
	}

	// Token: 0x06010CF9 RID: 68857 RVA: 0x004154F3 File Offset: 0x004136F3
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

	// Token: 0x06010CFA RID: 68858 RVA: 0x00415524 File Offset: 0x00413724
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

	// Token: 0x06010CFB RID: 68859 RVA: 0x00415550 File Offset: 0x00413750
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

	// Token: 0x06010CFC RID: 68860 RVA: 0x0041557D File Offset: 0x0041377D
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

	// Token: 0x06010CFD RID: 68861 RVA: 0x004155AC File Offset: 0x004137AC
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

	// Token: 0x06010CFE RID: 68862 RVA: 0x0041563A File Offset: 0x0041383A
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.MailInfosNotify);
		Net.Instance.UnRegister(ENotifyMessageId.MailDeleteNotify);
		Net.Instance.UnRegister(ENotifyMessageId.MailAddNotify);
	}

	// Token: 0x06010CFF RID: 68863 RVA: 0x0041566C File Offset: 0x0041386C
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

	// Token: 0x06010D00 RID: 68864 RVA: 0x0041574C File Offset: 0x0041394C
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

	// Token: 0x06010D01 RID: 68865 RVA: 0x00415808 File Offset: 0x00413A08
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

	// Token: 0x06010D02 RID: 68866 RVA: 0x00415930 File Offset: 0x00413B30
	private static void OnWorldDoneAndCloseLoading()
	{
		MailController.TryShowNewMailTips("NewMail");
	}

	// Token: 0x06010D03 RID: 68867 RVA: 0x0041593C File Offset: 0x00413B3C
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

	// Token: 0x06010D04 RID: 68868 RVA: 0x00415A04 File Offset: 0x00413C04
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

	// Token: 0x06010D05 RID: 68869 RVA: 0x00415A5C File Offset: 0x00413C5C
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

	// Token: 0x06010D06 RID: 68870 RVA: 0x00415AC8 File Offset: 0x00413CC8
	private static void OnReadMailResponse(MailReadResponse response, int configId)
	{
		if (response == null)
		{
			return;
		}
		if (response.ErrorCode != Aki.Protocol.ErrorCode.Success)
		{
			ErrorCodeController.Instance.OpenErrorCodeTipView(response.ErrorCode, 28318, null, true, true);
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

	// Token: 0x06010D07 RID: 68871 RVA: 0x00415BBC File Offset: 0x00413DBC
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

	// Token: 0x06010D08 RID: 68872 RVA: 0x00415C6C File Offset: 0x00413E6C
	private static void OnPickMailAttachmentResponse(MailGetAttachmentResponse response, EMailAttachmentPickType pickType)
	{
		if (response == null)
		{
			return;
		}
		if (response.ErrorCode == Aki.Protocol.ErrorCode.Success)
		{
			Dictionary<string, int> successIdMap = response.SuccessIdMap.ToDictionary((KeyValuePair<string, int> pair) => pair.Key, (KeyValuePair<string, int> pair) => pair.Value);
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
		ErrorCodeController.Instance.OpenErrorCodeTipView(response.ErrorCode, 27409, null, true, true);
	}

	// Token: 0x06010D09 RID: 68873 RVA: 0x00415D6C File Offset: 0x00413F6C
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
						ErrorCodeController.Instance.OpenErrorCodeTipView(mailFavoriteResponse.ErrorCode, 26065, null, true, true);
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

	// Token: 0x06010D0A RID: 68874 RVA: 0x00415DF0 File Offset: 0x00413FF0
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

	// Token: 0x06010D0B RID: 68875 RVA: 0x00415E58 File Offset: 0x00414058
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

	// Token: 0x06010D0C RID: 68876 RVA: 0x00415ED0 File Offset: 0x004140D0
	private static void OnDeleteMailResponse(MailDeleteResponse response)
	{
		if (response.ErrorCode != Aki.Protocol.ErrorCode.Success)
		{
			ErrorCodeController.Instance.OpenErrorCodeTipView(response.ErrorCode, 20393, null, true, true);
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

	// Token: 0x06010D0D RID: 68877 RVA: 0x00415FAC File Offset: 0x004141AC
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

	// Token: 0x06010D0E RID: 68878 RVA: 0x0041602C File Offset: 0x0041422C
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

	// Token: 0x06010D0F RID: 68879 RVA: 0x00416160 File Offset: 0x00414360
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

	// Token: 0x06010D10 RID: 68880 RVA: 0x0041627C File Offset: 0x0041447C
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
			AdventureGuideController.Instance.OpenGuideView(new EUiTabViewName?(euiTabViewName), num, null);
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

	// Token: 0x06010D11 RID: 68881 RVA: 0x00416400 File Offset: 0x00414600
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

	// Token: 0x06010D12 RID: 68882 RVA: 0x004164CC File Offset: 0x004146CC
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

	// Token: 0x06010D13 RID: 68883 RVA: 0x0041655C File Offset: 0x0041475C
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

	// Token: 0x06010D14 RID: 68884 RVA: 0x004165E8 File Offset: 0x004147E8
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

	// Token: 0x1700155A RID: 5466
	// (get) Token: 0x06010D15 RID: 68885 RVA: 0x00416648 File Offset: 0x00414848
	public static MailController Instance
	{
		get
		{
			return MailController._Instance;
		}
	}

	// Token: 0x06010D16 RID: 68886 RVA: 0x0041664F File Offset: 0x0041484F
	public static MailController GetOrCreateInstance()
	{
		if (MailController._Instance == null)
		{
			MailController.CreateInstance();
		}
		return MailController._Instance;
	}

	// Token: 0x06010D17 RID: 68887 RVA: 0x00416663 File Offset: 0x00414863
	public static bool CreateInstance()
	{
		if (MailController._Instance != null)
		{
			return true;
		}
		MailController._Instance = new MailController();
		return true;
	}

	// Token: 0x06010D18 RID: 68888 RVA: 0x00416679 File Offset: 0x00414879
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06010D19 RID: 68889 RVA: 0x0041667B File Offset: 0x0041487B
	public static void ResetStaticDefaultValue()
	{
		MailController._Instance = null;
	}

	// Token: 0x06010D1A RID: 68890 RVA: 0x00416683 File Offset: 0x00414883
	static MailController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MailController.CreateStaticDefaultValue), new Action(MailController.ResetStaticDefaultValue));
	}

	// Token: 0x04007FD3 RID: 32723
	[Nullable(2)]
	private static MailController _Instance;

	// Token: 0x02008707 RID: 34567
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402BEBA RID: 179898
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Func<EUiViewName, object, bool> <0>__CanOpenView;

		// Token: 0x0402BEBB RID: 179899
		[Nullable(0)]
		public static Action <1>__OnWorldDoneAndCloseLoading;

		// Token: 0x0402BEBC RID: 179900
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <2>__OnMailInfosNotify;

		// Token: 0x0402BEBD RID: 179901
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <3>__OnMailDeleteNotify;

		// Token: 0x0402BEBE RID: 179902
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <4>__OnMailAddNotify;
	}
}
