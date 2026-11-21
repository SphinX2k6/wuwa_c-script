using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x02001C42 RID: 7234
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ReportController : UiControllerBase
{
	// Token: 0x06011F6C RID: 73580 RVA: 0x00548CDC File Offset: 0x00546EDC
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(reportPlayerResponse.ErrorCode, 22547, null, true, true);
				return;
			}
			ScrollingTipsController.Instance.ShowTipsById("ReportSuccess", Array.Empty<object>());
			if (UiManager.Instance.IsViewShow(EUiViewName.ReportView))
			{
				UiManager.Instance.CloseView(EUiViewName.ReportView, null);
			}
		}, 0);
	}

	// Token: 0x06011F6D RID: 73581 RVA: 0x00548D90 File Offset: 0x00546F90
	public void OpenReportView(IPlayerData friendData, EReportSourceType sourceType)
	{
		ReportPersonInfo param = new ReportPersonInfo(friendData.PlayerId, friendData.PlayerName, friendData.Signature, sourceType);
		UiManager.Instance.OpenView(EUiViewName.ReportView, param, null);
	}

	// Token: 0x17001B4A RID: 6986
	// (get) Token: 0x06011F6E RID: 73582 RVA: 0x00548DC7 File Offset: 0x00546FC7
	public static ReportController Instance
	{
		get
		{
			return ReportController._Instance;
		}
	}

	// Token: 0x06011F6F RID: 73583 RVA: 0x00548DCE File Offset: 0x00546FCE
	public static ReportController GetOrCreateInstance()
	{
		if (ReportController._Instance == null)
		{
			ReportController.CreateInstance();
		}
		return ReportController._Instance;
	}

	// Token: 0x06011F70 RID: 73584 RVA: 0x00548DE2 File Offset: 0x00546FE2
	public static bool CreateInstance()
	{
		if (ReportController._Instance != null)
		{
			return true;
		}
		ReportController._Instance = new ReportController();
		return true;
	}

	// Token: 0x06011F71 RID: 73585 RVA: 0x00548DF8 File Offset: 0x00546FF8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06011F72 RID: 73586 RVA: 0x00548DFA File Offset: 0x00546FFA
	public static void ResetStaticDefaultValue()
	{
		ReportController._Instance = null;
	}

	// Token: 0x06011F73 RID: 73587 RVA: 0x00548E02 File Offset: 0x00547002
	static ReportController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ReportController.CreateStaticDefaultValue), new Action(ReportController.ResetStaticDefaultValue));
	}

	// Token: 0x04009CA2 RID: 40098
	[Nullable(2)]
	private static ReportController _Instance;
}
