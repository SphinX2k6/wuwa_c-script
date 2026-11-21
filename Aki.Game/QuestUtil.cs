using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.PhoneMessage;
using CSharpScript.Game.Module.QuestMultiLine;
using CSharpScript.Game.Module.Sheriff;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001B44 RID: 6980
[NullableContext(1)]
[Nullable(0)]
public class QuestUtil : Singleton
{
	// Token: 0x06011643 RID: 71235 RVA: 0x0051ECB8 File Offset: 0x0051CEB8
	public bool SetTrackDistanceText([Nullable(2)] UUIText uiText, global::Vector inLocation)
	{
		if (uiText == null || !ObjectUtils.IsValid(uiText))
		{
			return false;
		}
		if (inLocation == null)
		{
			return false;
		}
		global::Vector playerLocation = GeneralLogicTreeUtil.Instance.GetPlayerLocation();
		if (playerLocation == null)
		{
			return false;
		}
		double a = global::Vector.Dist(inLocation, playerLocation) * 0.009999999776482582;
		a = Math.Round(a);
		double num = inLocation.Z - playerLocation.Z;
		string item = a.ToString();
		LguiUtil.Instance.SetLocalText(uiText, "Meter", new <>z__ReadOnlySingleElementList<object>(item));
		string text = uiText.GetText();
		if (num > 300.0)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_YellowArrowUp");
			text = text + "<texture=" + resourcePath + "/>";
		}
		else if (num < -300.0)
		{
			string resourcePath2 = UiResourceConfig.Instance.GetResourcePath("T_YellowArrowDown");
			text = text + "<texture=" + resourcePath2 + "/>";
		}
		uiText.SetText(text, true);
		return true;
	}

	// Token: 0x06011644 RID: 71236 RVA: 0x0051EDA4 File Offset: 0x0051CFA4
	[NullableContext(2)]
	public bool SetTrackDistanceText(UUIText uiText, FVector inLocation)
	{
		if (uiText == null || !ObjectUtils.IsValid(uiText))
		{
			return false;
		}
		global::Vector playerLocation = GeneralLogicTreeUtil.Instance.GetPlayerLocation();
		if (playerLocation == null)
		{
			return false;
		}
		FVector fvector = playerLocation.ToUeVectorOld();
		double a = (double)(FVector.Dist(inLocation, fvector) * 0.01f);
		a = Math.Round(a);
		double num = (double)inLocation.Z - playerLocation.Z;
		string item = a.ToString();
		LguiUtil.Instance.SetLocalText(uiText, "Meter", new <>z__ReadOnlySingleElementList<object>(item));
		string text = uiText.GetText();
		if (num > 300.0)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_YellowArrowUp");
			text = text + "<texture=" + resourcePath + "/>";
		}
		else if (num < -300.0)
		{
			string resourcePath2 = UiResourceConfig.Instance.GetResourcePath("T_YellowArrowDown");
			text = text + "<texture=" + resourcePath2 + "/>";
		}
		uiText.SetText(text, true);
		return true;
	}

	// Token: 0x06011645 RID: 71237 RVA: 0x0051EE94 File Offset: 0x0051D094
	public int? GetQuestMarkId(int questType, int? questId = null)
	{
		if (questId != null && questId.GetValueOrDefault() != 0)
		{
			TaskMark? taskMarkConfigByQuestId = MapConfig.Instance.GetTaskMarkConfigByQuestId(questId.Value);
			if (taskMarkConfigByQuestId != null)
			{
				return new int?(taskMarkConfigByQuestId.Value.MarkId);
			}
		}
		return QuestNewConfig.Instance.GetQuestTypeMarkId(questType);
	}

	// Token: 0x06011646 RID: 71238 RVA: 0x0051EEF0 File Offset: 0x0051D0F0
	public string GetQuestMarkIconPathByQuestId(int questId)
	{
		IQuest questConfig = QuestNewModel.Instance.GetQuestConfig(questId);
		QuestType? questTypeConfig = QuestNewConfig.Instance.GetQuestTypeConfig((int)((questConfig != null) ? questConfig.Type : ((EQuest)0)));
		if (questTypeConfig == null)
		{
			return "";
		}
		int valueOrDefault = this.GetQuestMarkId(questTypeConfig.Value.MainId, new int?(questId)).GetValueOrDefault();
		return QuestNewConfig.Instance.GetQuestTypeMark(valueOrDefault);
	}

	// Token: 0x06011647 RID: 71239 RVA: 0x0051EF60 File Offset: 0x0051D160
	[NullableContext(2)]
	public bool HandleTrackCustomBoard(ITrackCustomBoard trackCustomBoard, bool isFromHotKey = false)
	{
		if (trackCustomBoard == null)
		{
			return false;
		}
		if (isFromHotKey && !InputManager.Instance.IsAllowOpenViewByShortcutKey())
		{
			return false;
		}
		if (trackCustomBoard.TrackPhoneMessageBoard != null)
		{
			int valueOrDefault = trackCustomBoard.TrackPhoneMessageBoard.PhoneMessageId.GetValueOrDefault();
			ShortMessage? phoneMsgConfig = PhoneMsgConfig.Instance.GetPhoneMsgConfig(valueOrDefault);
			if (phoneMsgConfig == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Quest;
				ELogAuthor author = ELogAuthor.HYF;
				string message = "找不到对应的短信配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("短信ID", valueOrDefault);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			if (!PhoneMsgModel.Instance.IsPhoneMsgUnlock(valueOrDefault))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Quest;
				ELogAuthor author2 = ELogAuthor.HYF;
				string message2 = "短信未解锁，无法追踪";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("短信ID", valueOrDefault);
				instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
			if (UiManager.Instance.IsViewOpen(EUiViewName.PhoneMsgPanelViewBig) || UiManager.Instance.IsViewOpen(EUiViewName.PhoneMsgPanelViewSmall))
			{
				Log.Instance.Info(ELogModule.Quest, ELogAuthor.HYF, "手机短信界面已打开，无需重复打开", default(ReadOnlySpan<ValueTuple<string, object>>));
				return true;
			}
			PhoneMsgPanelViewData param = new PhoneMsgPanelViewData
			{
				ShortMessage = phoneMsgConfig,
				NeedShowTips = false,
				NeedForceReadAllMsg = false,
				OpenWay = EPhoneMsgOpenWay.QuestTrack,
				ViewType = EPhoneMsgViewType.Big
			};
			UiManager.Instance.OpenView(EUiViewName.PhoneMsgPanelViewBig, param, null);
			return true;
		}
		else
		{
			ITrackQuestBranchBoardConfig trackQuestBranchBoard = trackCustomBoard.TrackQuestBranchBoard;
			if (trackQuestBranchBoard != null)
			{
				if (UiManager.Instance.IsViewOpen(EUiViewName.QuestMultiLineView))
				{
					Log.Instance.Info(ELogModule.QuestMultiLine, ELogAuthor.CCJ, "分线界面已打开，无需重复打开", default(ReadOnlySpan<ValueTuple<string, object>>));
					return true;
				}
				int id = trackQuestBranchBoard.Id;
				bool valueOrDefault2 = trackQuestBranchBoard.EnableAnimation.GetValueOrDefault();
				QuestMultiLineController.Instance.OpenQuestMultiLineView(id, valueOrDefault2, false).Forget<int?>();
				return true;
			}
			else
			{
				if (trackCustomBoard.SheriffAnomalyProgressBoard != null)
				{
					return this.HandleAnomalyProgressBoard(trackCustomBoard);
				}
				if (trackCustomBoard.SheriffReasoningBoard != null)
				{
					return this.HandleSheriffReasoningBoard(trackCustomBoard);
				}
				return trackCustomBoard.SheriffClueDetailBoard != null && this.HandleSheriffClueDetailBoard(trackCustomBoard);
			}
		}
	}

	// Token: 0x06011648 RID: 71240 RVA: 0x0051F144 File Offset: 0x0051D344
	private bool HandleAnomalyProgressBoard(ITrackCustomBoard trackCustomBoard)
	{
		ISheriffAnomalyProgressBoardConfig sheriffAnomalyProgressBoard = trackCustomBoard.SheriffAnomalyProgressBoard;
		if (sheriffAnomalyProgressBoard == null)
		{
			return false;
		}
		if (UiManager.Instance.IsViewOpen(EUiViewName.SheriffReportPop))
		{
			Log.Instance.Info(ELogModule.Sheriff, ELogAuthor.SYB, "案情进展界面已打开，无需重复打开", default(ReadOnlySpan<ValueTuple<string, object>>));
			return true;
		}
		int anomalyId = sheriffAnomalyProgressBoard.AnomalyId;
		SheriffAnomaly? anomalyConfigById = SheriffConfig.Instance.GetAnomalyConfigById(anomalyId);
		if (anomalyConfigById == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Sheriff;
			ELogAuthor author = ELogAuthor.SYB;
			string message = "找不到对应的案情事件配置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("事件Id", anomalyId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		int criminalId = anomalyConfigById.Value.CriminalId;
		SheriffController.Instance.OpenSheriffReportPop(criminalId, true);
		return true;
	}

	// Token: 0x06011649 RID: 71241 RVA: 0x0051F200 File Offset: 0x0051D400
	private bool HandleSheriffReasoningBoard(ITrackCustomBoard trackCustomBoard)
	{
		ISheriffReasoningBoardConfig sheriffReasoningBoard = trackCustomBoard.SheriffReasoningBoard;
		if (sheriffReasoningBoard == null)
		{
			return false;
		}
		if (UiManager.Instance.IsViewOpen(EUiViewName.SheriffMainView))
		{
			Log.Instance.Info(ELogModule.Sheriff, ELogAuthor.WHJ, "推理进展界面已打开，无需重复打开", default(ReadOnlySpan<ValueTuple<string, object>>));
			return true;
		}
		int id = sheriffReasoningBoard.Id;
		SheriffController.Instance.OpenAnalysisClueView(id);
		return true;
	}

	// Token: 0x0601164A RID: 71242 RVA: 0x0051F260 File Offset: 0x0051D460
	private bool HandleSheriffClueDetailBoard(ITrackCustomBoard trackCustomBoard)
	{
		if (trackCustomBoard.SheriffClueDetailBoard == null)
		{
			return false;
		}
		if (UiManager.Instance.IsViewOpen(EUiViewName.SheriffShowClueViewPop))
		{
			Log.Instance.Info(ELogModule.Sheriff, ELogAuthor.WHJ, "推理线索界面已打开，无需重复打开", default(ReadOnlySpan<ValueTuple<string, object>>));
			return true;
		}
		SheriffController.Instance.OpenDetailClueFromQuestPanel();
		return true;
	}

	// Token: 0x170019D4 RID: 6612
	// (get) Token: 0x0601164B RID: 71243 RVA: 0x0051F2B4 File Offset: 0x0051D4B4
	public static QuestUtil Instance
	{
		get
		{
			if (QuestUtil._instance == null)
			{
				QuestUtil._instance = new QuestUtil();
				QuestUtil._instance.OnInit();
			}
			return QuestUtil._instance;
		}
	}

	// Token: 0x0601164C RID: 71244 RVA: 0x0051F2D7 File Offset: 0x0051D4D7
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601164D RID: 71245 RVA: 0x0051F2D9 File Offset: 0x0051D4D9
	public static void ResetStaticDefaultValue()
	{
		QuestUtil instance = QuestUtil._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		QuestUtil._instance = null;
	}

	// Token: 0x0601164E RID: 71246 RVA: 0x0051F2F2 File Offset: 0x0051D4F2
	static QuestUtil()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(QuestUtil.CreateStaticDefaultValue), new Action(QuestUtil.ResetStaticDefaultValue));
	}

	// Token: 0x040098CD RID: 39117
	[Nullable(2)]
	private static QuestUtil _instance;
}
