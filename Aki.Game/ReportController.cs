using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x02002757 RID: 10071
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ReportController : UiControllerBase
{
	// Token: 0x06014A89 RID: 84617 RVA: 0x00539E48 File Offset: 0x00538048
	public static void ReportPlayerRequest(ReportPersonInfo targetPlayerInfo, int reportReason, string reportMessage, [Nullable(2)] ReportChatInfo reportChatInfo = null)
	{
		ReportPlayerRequest reportPlayerRequest = Aki.Protocol.ReportPlayerRequest.Create();
		reportPlayerRequest.TargetPlayerId = targetPlayerInfo.GetPlayerId();
		reportPlayerRequest.ReportReason = reportReason;
		reportPlayerRequest.ReportMessage = reportMessage;
		reportPlayerRequest.ReportSource = (int)targetPlayerInfo.GetSourceType();
		if (reportChatInfo != null)
		{
			reportPlayerRequest.ChatInfo = reportChatInfo;
		}
		else
		{
			ReportChatInfo reportChatInfo2 = ReportChatInfo.Create();
			reportChatInfo2.ChatMessage = string.Empty;
			reportPlayerRequest.ChatInfo = reportChatInfo2;
		}
		ReportTargetInfo reportTargetInfo = ReportTargetInfo.Create();
		reportTargetInfo.Name = targetPlayerInfo.GetName();
		reportTargetInfo.Signature = targetPlayerInfo.GetSignature();
		reportPlayerRequest.TargetInfo = reportTargetInfo;
		Net.Instance.Call(ERequestMessageId.ReportPlayerRequest, reportPlayerRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ReportPlayerResponse reportPlayerResponse = (ReportPlayerResponse)msg;
			if (reportPlayerResponse == null)
			{
				return;
			}
			if (reportPlayerResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(reportPlayerResponse.ErrorCode, 23940, null, true, true);
				return;
			}
			ScrollingTipsController.Instance.ShowTipsById("ReportSuccess", Array.Empty<object>());
			if (UiManager.Instance.IsViewShow(EUiViewName.ReportView))
			{
				UiManager.Instance.CloseView(EUiViewName.ReportView, null);
			}
		}, 0);
	}

	// Token: 0x06014A8A RID: 84618 RVA: 0x00539EFC File Offset: 0x005380FC
	public void OpenReportView(IPlayerData friendData, EReportSourceType sourceType)
	{
		ReportPersonInfo param = new ReportPersonInfo(friendData.PlayerId, friendData.PlayerName, friendData.Signature, sourceType);
		UiManager.Instance.OpenView(EUiViewName.ReportView, param, null);
	}

	// Token: 0x17001B11 RID: 6929
	// (get) Token: 0x06014A8B RID: 84619 RVA: 0x00539F33 File Offset: 0x00538133
	public static ReportController Instance
	{
		get
		{
			return ReportController._Instance;
		}
	}

	// Token: 0x06014A8C RID: 84620 RVA: 0x00539F3A File Offset: 0x0053813A
	public static ReportController GetOrCreateInstance()
	{
		if (ReportController._Instance == null)
		{
			ReportController.CreateInstance();
		}
		return ReportController._Instance;
	}

	// Token: 0x06014A8D RID: 84621 RVA: 0x00539F4E File Offset: 0x0053814E
	public static bool CreateInstance()
	{
		if (ReportController._Instance != null)
		{
			return true;
		}
		ReportController._Instance = new ReportController();
		return true;
	}

	// Token: 0x06014A8E RID: 84622 RVA: 0x00539F64 File Offset: 0x00538164
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06014A8F RID: 84623 RVA: 0x00539F66 File Offset: 0x00538166
	public static void ResetStaticDefaultValue()
	{
		ReportController._Instance = null;
	}

	// Token: 0x06014A90 RID: 84624 RVA: 0x00539F6E File Offset: 0x0053816E
	static ReportController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ReportController.CreateStaticDefaultValue), new Action(ReportController.ResetStaticDefaultValue));
	}

	// Token: 0x04009B49 RID: 39753
	[Nullable(2)]
	private static ReportController _Instance;
}
