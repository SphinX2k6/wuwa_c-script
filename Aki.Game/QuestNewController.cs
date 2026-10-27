using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.Scene;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Module.QuestNew.Controller;
using CSharpScript.Game.Module.RecallQuest;
using CSharpScript.Game.Module.RecallQuest.Model;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Render.Effect.PostProcess;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Update;
using Google.Protobuf;

// Token: 0x02002636 RID: 9782
[NullableContext(2)]
[Nullable(0)]
[TickController(0)]
public class QuestNewController : ControllerWithAssistantBase
{
	// Token: 0x17001973 RID: 6515
	// (get) Token: 0x0601401D RID: 81949 RVA: 0x00509811 File Offset: 0x00507A11
	// (set) Token: 0x0601401E RID: 81950 RVA: 0x00509819 File Offset: 0x00507A19
	[Nullable(1)]
	private QuestRedDotNotify CachedRedDotNotify { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17001974 RID: 6516
	// (get) Token: 0x0601401F RID: 81951 RVA: 0x00509822 File Offset: 0x00507A22
	// (set) Token: 0x06014020 RID: 81952 RVA: 0x0050982A File Offset: 0x00507A2A
	public long QuestRangeFailWarningTreeId { get; set; }

	// Token: 0x17001975 RID: 6517
	// (get) Token: 0x06014021 RID: 81953 RVA: 0x00509833 File Offset: 0x00507A33
	// (set) Token: 0x06014022 RID: 81954 RVA: 0x0050983B File Offset: 0x00507A3B
	private bool IsHidingQuestRangeFailWarning { get; set; }

	// Token: 0x17001976 RID: 6518
	// (get) Token: 0x06014023 RID: 81955 RVA: 0x00509844 File Offset: 0x00507A44
	// (set) Token: 0x06014024 RID: 81956 RVA: 0x0050984C File Offset: 0x00507A4C
	private float HidingQuestRangeFialWarningTime { get; set; }

	// Token: 0x17001977 RID: 6519
	// (get) Token: 0x06014025 RID: 81957 RVA: 0x00509855 File Offset: 0x00507A55
	// (set) Token: 0x06014026 RID: 81958 RVA: 0x0050985D File Offset: 0x00507A5D
	private bool IsShowingQuestRangeFailWarning { get; set; }

	// Token: 0x17001978 RID: 6520
	// (get) Token: 0x06014027 RID: 81959 RVA: 0x00509866 File Offset: 0x00507A66
	// (set) Token: 0x06014028 RID: 81960 RVA: 0x0050986E File Offset: 0x00507A6E
	private float ShowQuestRangeFialWarningTime { get; set; }

	// Token: 0x17001979 RID: 6521
	// (get) Token: 0x06014029 RID: 81961 RVA: 0x00509877 File Offset: 0x00507A77
	// (set) Token: 0x0601402A RID: 81962 RVA: 0x0050987F File Offset: 0x00507A7F
	private bool IsShowQuestRangeFailWarning { get; set; }

	// Token: 0x1700197A RID: 6522
	// (get) Token: 0x0601402B RID: 81963 RVA: 0x00509888 File Offset: 0x00507A88
	// (set) Token: 0x0601402C RID: 81964 RVA: 0x00509890 File Offset: 0x00507A90
	private float StartShowQuestRangeFialWarningTime { get; set; }

	// Token: 0x1700197B RID: 6523
	// (get) Token: 0x0601402D RID: 81965 RVA: 0x00509899 File Offset: 0x00507A99
	// (set) Token: 0x0601402E RID: 81966 RVA: 0x005098A1 File Offset: 0x00507AA1
	private TimerHandle DelayTimerHandle { get; set; }

	// Token: 0x1700197C RID: 6524
	// (get) Token: 0x0601402F RID: 81967 RVA: 0x005098AA File Offset: 0x00507AAA
	// (set) Token: 0x06014030 RID: 81968 RVA: 0x005098B2 File Offset: 0x00507AB2
	private int? VideoResourceDownloadTriggerId { get; set; }

	// Token: 0x1700197D RID: 6525
	// (get) Token: 0x06014031 RID: 81969 RVA: 0x005098BB File Offset: 0x00507ABB
	// (set) Token: 0x06014032 RID: 81970 RVA: 0x005098C3 File Offset: 0x00507AC3
	private bool? IsReportDownloadNotEnoughSpace { get; set; }

	// Token: 0x06014033 RID: 81971 RVA: 0x005098CC File Offset: 0x00507ACC
	protected override void OnRegisterNetEvent()
	{
		base.OnRegisterNetEvent();
		Net.Instance.Register(ENotifyMessageId.QuestListNotify, new Action<IMessage, Net.CallbackStatus>(this.OnQuestListNotify));
		Net.Instance.Register(ENotifyMessageId.QuestReadyListNotify, new Action<IMessage, Net.CallbackStatus>(this.OnQuestReadyListNotify));
		Net.Instance.Register(ENotifyMessageId.QuestShowListNotify, new Action<IMessage, Net.CallbackStatus>(this.OnQuestShowListNotify));
		Net.Instance.Register(ENotifyMessageId.QuestStateUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.QuestStateUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.QuestFinishListNotify, new Action<IMessage, Net.CallbackStatus>(this.OnQuestFinishListNotify));
		Net.Instance.Register(ENotifyMessageId.QuestRedDotNotify, new Action<IMessage, Net.CallbackStatus>(this.OnQuestRedDotNotify));
		Net.Instance.Register(ENotifyMessageId.BtRangeFailWarningNotify, new Action<IMessage, Net.CallbackStatus>(this.OnBtRangeFailWarningNotify));
		Net.Instance.Register(ENotifyMessageId.BtCancelRangeFailWarningNotify, new Action<IMessage, Net.CallbackStatus>(this.OnBtCancelRangeFailWarningNotify));
		Net.Instance.Register(ENotifyMessageId.QuestGiveUpNotify, new Action<IMessage, Net.CallbackStatus>(this.OnQuestGiveUpNotify));
		Net.Instance.Register(ENotifyMessageId.WaitQuestConfirmResourceNotify, new Action<IMessage, Net.CallbackStatus>(this.OnWaitQuestConfirmResourceNotify));
		Net.Instance.Register(ENotifyMessageId.StartSetQuestFocusNotify, new Action<IMessage, Net.CallbackStatus>(this.OnStartSetQuestFocusNotify));
		Net.Instance.Register(ENotifyMessageId.QuestFocusInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnQuestFocusInfoNotify));
		Net.Instance.Register(ENotifyMessageId.QuestLockInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnQuestLockInfoNotify));
		Net.Instance.Register(ENotifyMessageId.InteractQuestSuspendEntityNotify, new Action<IMessage, Net.CallbackStatus>(this.OnInteractQuestSuspendEntityNotify));
		Net.Instance.Register(ENotifyMessageId.ResetQuestFocusModeNotify, new Action<IMessage, Net.CallbackStatus>(this.OnResetQuestFocusModeNotify));
	}

	// Token: 0x06014034 RID: 81972 RVA: 0x00509A84 File Offset: 0x00507C84
	protected override void OnUnRegisterNetEvent()
	{
		base.OnUnRegisterNetEvent();
		Net.Instance.UnRegister(ENotifyMessageId.QuestListNotify);
		Net.Instance.UnRegister(ENotifyMessageId.QuestReadyListNotify);
		Net.Instance.UnRegister(ENotifyMessageId.QuestShowListNotify);
		Net.Instance.UnRegister(ENotifyMessageId.QuestStateUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.QuestFinishListNotify);
		Net.Instance.UnRegister(ENotifyMessageId.BtRangeFailWarningNotify);
		Net.Instance.UnRegister(ENotifyMessageId.BtCancelRangeFailWarningNotify);
		Net.Instance.UnRegister(ENotifyMessageId.QuestGiveUpNotify);
		Net.Instance.UnRegister(ENotifyMessageId.WaitQuestConfirmResourceNotify);
		Net.Instance.UnRegister(ENotifyMessageId.StartSetQuestFocusNotify);
		Net.Instance.UnRegister(ENotifyMessageId.QuestFocusInfoNotify);
		Net.Instance.UnRegister(ENotifyMessageId.QuestLockInfoNotify);
		Net.Instance.UnRegister(ENotifyMessageId.InteractQuestSuspendEntityNotify);
		Net.Instance.UnRegister(ENotifyMessageId.ResetQuestFocusModeNotify);
	}

	// Token: 0x06014035 RID: 81973 RVA: 0x00509B77 File Offset: 0x00507D77
	protected override bool OnInit()
	{
		base.InitTickOptimize(30, -1);
		return base.OnInit();
	}

	// Token: 0x06014036 RID: 81974 RVA: 0x00509B88 File Offset: 0x00507D88
	protected override void OnAddEvents()
	{
		base.OnAddEvents();
		EventSystem.Instance.Add(EEventName.GeneralLogicTreeWakeUp, new Action(this.OnGeneralLogicTreeWakeUp));
		EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		EventSystem.Instance.Add<int?, int>(EEventName.ChangeArea, new Action<int?, int>(this.AreaChanged));
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Add(EEventName.TsWorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Add<PlotResultInfo>(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.OnPlotSequenceEnd));
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.QuestView, new Func<EUiViewName, object, bool>(this.CanOpenView), "QuestNewController.CanOpenView");
		VideoUpdateManager.Instance.GetVideoUpdater(EVideoResSizeType.FemalePrepare).SetDownloadFinishCallBack(new Action<EVideoResSizeType>(this.OnQuestVideoResourceDownloadFinish));
		VideoUpdateManager.Instance.GetVideoUpdater(EVideoResSizeType.MalePrepare).SetDownloadFinishCallBack(new Action<EVideoResSizeType>(this.OnQuestVideoResourceDownloadFinish));
	}

	// Token: 0x06014037 RID: 81975 RVA: 0x00509C9C File Offset: 0x00507E9C
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.GeneralLogicTreeWakeUp, new Action(this.OnGeneralLogicTreeWakeUp));
		EventSystem.Instance.Remove(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		EventSystem.Instance.Remove(EEventName.ChangeArea, new Action<int?, int>(this.AreaChanged));
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Remove(EEventName.TsWorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Remove(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.OnPlotSequenceEnd));
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.QuestView, new Func<EUiViewName, object, bool>(this.CanOpenView));
		base.OnRemoveEvents();
	}

	// Token: 0x06014038 RID: 81976 RVA: 0x00509D74 File Offset: 0x00507F74
	protected override void OnTick(float delta)
	{
		if (!GeneralLogicTreeModel.Instance.IsWakeUp)
		{
			return;
		}
		GuideLineAssistant assistant = this.GetAssistant<GuideLineAssistant>(QuestNewController.EAssistantType.GuideLine);
		if (assistant != null)
		{
			assistant.Tick(delta);
		}
		GuideEffectAssistant assistant2 = this.GetAssistant<GuideEffectAssistant>(QuestNewController.EAssistantType.GuideEffect);
		if (assistant2 != null)
		{
			assistant2.UpdateQuestGuideEffect(delta);
		}
		if (this.IsHidingQuestRangeFailWarning)
		{
			this.HidingQuestRangeFialWarningTime += delta;
			double num = MathUtils.Instance.SafeDivide((double)(this.ShowQuestRangeFailWarningTime - this.HidingQuestRangeFialWarningTime), (double)this.ShowQuestRangeFailWarningTime);
			num = MathUtils.Instance.Clamp(num, 0.0, 1.0);
			SceneEffectStateManager.Instance.SetSceneEffectState(ESceneEffectStateType.AirWall, (float)num);
			if (this.HidingQuestRangeFialWarningTime > this.ShowQuestRangeFailWarningTime)
			{
				SceneEffectStateManager.Instance.SetSceneEffectState(ESceneEffectStateType.AirWall, 0f);
				this.IsHidingQuestRangeFailWarning = false;
			}
		}
		if (this.IsShowingQuestRangeFailWarning)
		{
			this.ShowQuestRangeFialWarningTime += delta;
			double num2 = MathUtils.Instance.SafeDivide((double)this.ShowQuestRangeFialWarningTime, (double)this.ShowQuestRangeFailWarningTime);
			num2 = MathUtils.Instance.Clamp(num2, 0.0, 1.0);
			SceneEffectStateManager.Instance.SetSceneEffectState(ESceneEffectStateType.AirWall, (float)num2);
			if (this.ShowQuestRangeFialWarningTime > this.ShowQuestRangeFailWarningTime)
			{
				SceneEffectStateManager.Instance.SetSceneEffectState(ESceneEffectStateType.AirWall, 1f);
				this.IsShowingQuestRangeFailWarning = false;
			}
		}
		if (this.IsShowQuestRangeFailWarning)
		{
			this.StartShowQuestRangeFialWarningTime += delta;
			int valueOrDefault = ConfigCommonParamById.GetIntConfig("CloseQuestRangeFailWarningTime").GetValueOrDefault(30000);
			if (this.StartShowQuestRangeFialWarningTime > (float)valueOrDefault)
			{
				this.HideCancelRangeFailWaringEffect();
			}
		}
	}

	// Token: 0x06014039 RID: 81977 RVA: 0x00509EF8 File Offset: 0x005080F8
	protected override void RegisterAssistant()
	{
		base.AddAssistant(0, new GuideLineAssistant(new <>z__ReadOnlyArray<BtType>(new BtType[]
		{
			BtType.Quest,
			BtType.Recall
		})));
		base.AddAssistant(1, new QuestTrackAssistant());
		base.AddAssistant(2, new GuideEffectAssistant());
		base.AddAssistant(3, new DailyQuestAssistant());
	}

	// Token: 0x0601403A RID: 81978 RVA: 0x00509F48 File Offset: 0x00508148
	[NullableContext(1)]
	private T GetAssistant<T>(QuestNewController.EAssistantType type) where T : class
	{
		ControllerAssistantBase controllerAssistantBase;
		if (!this.Assistants.TryGetValue((int)type, out controllerAssistantBase))
		{
			return default(T);
		}
		return controllerAssistantBase as T;
	}

	// Token: 0x0601403B RID: 81979 RVA: 0x00509F7A File Offset: 0x0050817A
	public void AddQuestTraceEffect(int questId, float showTime, int splineEntityId)
	{
		GuideEffectAssistant assistant = this.GetAssistant<GuideEffectAssistant>(QuestNewController.EAssistantType.GuideEffect);
		if (assistant == null)
		{
			return;
		}
		assistant.AddQuestTraceEffect(questId, showTime, splineEntityId);
	}

	// Token: 0x0601403C RID: 81980 RVA: 0x00509F90 File Offset: 0x00508190
	public void RemoveQuestTraceEffect(int questId, int splineEntityId)
	{
		GuideEffectAssistant assistant = this.GetAssistant<GuideEffectAssistant>(QuestNewController.EAssistantType.GuideEffect);
		if (assistant == null)
		{
			return;
		}
		assistant.RemoveQuestTraceEffect(questId, splineEntityId);
	}

	// Token: 0x0601403D RID: 81981 RVA: 0x00509FA5 File Offset: 0x005081A5
	public void ClearQuestTraceEffect(int questId)
	{
		GuideEffectAssistant assistant = this.GetAssistant<GuideEffectAssistant>(QuestNewController.EAssistantType.GuideEffect);
		if (assistant == null)
		{
			return;
		}
		assistant.ClearQuestTraceEffect(questId);
	}

	// Token: 0x0601403E RID: 81982 RVA: 0x00509FBC File Offset: 0x005081BC
	private void OnGeneralLogicTreeWakeUp()
	{
		QuestTrackAssistant assistant = this.GetAssistant<QuestTrackAssistant>(QuestNewController.EAssistantType.Track);
		if (assistant != null)
		{
			assistant.RefreshCurTrackQuest();
		}
		DailyQuestAssistant assistant2 = this.GetAssistant<DailyQuestAssistant>(QuestNewController.EAssistantType.DailyQuest);
		if (assistant2 != null)
		{
			assistant2.CreateMarksOnWakeUp();
		}
		if (this.CachedRedDotNotify != null)
		{
			this.OnQuestRedDotNotify(this.CachedRedDotNotify, null);
			this.CachedRedDotNotify = null;
		}
	}

	// Token: 0x0601403F RID: 81983 RVA: 0x0050A00C File Offset: 0x0050820C
	private void OnQuestListNotify(IMessage msg, Net.CallbackStatus status)
	{
		QuestListNotify questListNotify = (QuestListNotify)msg;
		List<QuestListItem> list = new List<QuestListItem>();
		foreach (QuestInfo questInfo in questListNotify.Quests)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Quest;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "上线下发进行中的任务";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("任务id", questInfo.QuestId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			list.Add(new QuestListItem
			{
				QuestId = questInfo.QuestId,
				State = questInfo.Status,
				UpdateReason = EQuestStatusUpdateReason.ReLogin
			});
		}
		QuestNewController.HandleQuestListNotify(list);
	}

	// Token: 0x06014040 RID: 81984 RVA: 0x0050A0C0 File Offset: 0x005082C0
	private void OnQuestReadyListNotify(IMessage msg, Net.CallbackStatus status)
	{
		QuestReadyListNotify questReadyListNotify = (QuestReadyListNotify)msg;
		int mapTrackQuestId = this.GetMapTrackQuestId();
		QuestNewModel instance = QuestNewModel.Instance;
		foreach (int num in questReadyListNotify.QuestId)
		{
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.Quest;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "下发可接任务";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("任务id", num);
			instance2.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (instance.GetQuest(num) == null)
			{
				IQuest questConfig = instance.GetQuestConfig(num);
				if (questConfig != null)
				{
					IAddInteractOption addInteractOption = questConfig.AddInteractOption;
					if (addInteractOption != null)
					{
						if (mapTrackQuestId == num)
						{
							global::Quest quest = instance.AddQuest(num);
							if (quest != null)
							{
								quest.UpdateState(QuestState.Ready, EQuestStatusUpdateReason.ReLogin);
							}
						}
						else
						{
							int entityAreaId = WorldMapModel.Instance.GetEntityAreaId(addInteractOption.EntityId, null);
							int levelOneAreaId = AreaConfig.Instance.GetLevelOneAreaId(entityAreaId);
							int currentAreaId = AreaModel.Instance.GetCurrentAreaId(null);
							int levelOneAreaId2 = AreaConfig.Instance.GetLevelOneAreaId(currentAreaId);
							if (levelOneAreaId == 0 || levelOneAreaId2 == 0 || levelOneAreaId == levelOneAreaId2)
							{
								global::Quest quest2 = instance.AddQuest(num);
								if (quest2 != null)
								{
									quest2.UpdateState(QuestState.Ready, EQuestStatusUpdateReason.ReLogin);
								}
							}
							else
							{
								instance.AddCanAcceptQuest(num);
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06014041 RID: 81985 RVA: 0x0050A220 File Offset: 0x00508420
	private void OnWorldDone()
	{
		this.AreaChanged(null, 0);
	}

	// Token: 0x06014042 RID: 81986 RVA: 0x0050A240 File Offset: 0x00508440
	private void AreaChanged(int? preAreaId, int curAreaId)
	{
		int currentAreaId = AreaModel.Instance.GetCurrentAreaId(null);
		int levelOneAreaId = AreaConfig.Instance.GetLevelOneAreaId(currentAreaId);
		if (levelOneAreaId == 0)
		{
			return;
		}
		int mapTrackQuestId = this.GetMapTrackQuestId();
		QuestNewModel instance = QuestNewModel.Instance;
		foreach (KeyValuePair<int, bool> keyValuePair in instance.GetCanAcceptQuest())
		{
			int num;
			bool flag;
			keyValuePair.Deconstruct(out num, out flag);
			int num2 = num;
			if (flag)
			{
				IQuest questConfig = instance.GetQuestConfig(num2);
				if (questConfig != null)
				{
					IAddInteractOption addInteractOption = questConfig.AddInteractOption;
					if (addInteractOption != null)
					{
						int entityAreaId = WorldMapModel.Instance.GetEntityAreaId(addInteractOption.EntityId, new int?(questConfig.DungeonId));
						if (AreaConfig.Instance.GetLevelOneAreaId(entityAreaId) == levelOneAreaId || mapTrackQuestId == num2)
						{
							if (instance.GetQuest(num2) == null)
							{
								global::Quest quest = instance.AddQuest(num2);
								if (quest != null)
								{
									quest.UpdateState(QuestState.Ready, EQuestStatusUpdateReason.ReLogin);
								}
							}
						}
						else
						{
							instance.RemoveQuest(num2);
						}
					}
				}
			}
		}
	}

	// Token: 0x06014043 RID: 81987 RVA: 0x0050A350 File Offset: 0x00508550
	private int GetMapTrackQuestId()
	{
		int result = 0;
		TrackMapMarkParams curTrackMark = MapModel.Instance.GetCurTrackMark();
		if (curTrackMark != null)
		{
			QuestMarkCreateInfo questMarkCreateInfo = MapModel.Instance.GetMark(curTrackMark.MarkType, curTrackMark.MarkId) as QuestMarkCreateInfo;
			if (questMarkCreateInfo != null)
			{
				result = (int)questMarkCreateInfo.TreeId;
			}
		}
		return result;
	}

	// Token: 0x06014044 RID: 81988 RVA: 0x0050A398 File Offset: 0x00508598
	private void OnQuestShowListNotify(IMessage msg, Net.CallbackStatus status)
	{
		QuestShowListNotify questShowListNotify = (QuestShowListNotify)msg;
		foreach (KeyValuePair<int, bool> keyValuePair in QuestNewModel.Instance.GetPreShowQuests())
		{
			int num;
			bool flag;
			keyValuePair.Deconstruct(out num, out flag);
			int num2 = num;
			if (!questShowListNotify.QuestId.Contains(num2))
			{
				QuestNewModel.Instance.RemovePreShowQuest(num2);
			}
		}
		foreach (int num3 in questShowListNotify.QuestId)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Quest;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "下发提前显示的任务";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("任务id", num3);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			QuestNewModel.Instance.AddPreShowQuest(num3);
		}
	}

	// Token: 0x06014045 RID: 81989 RVA: 0x0050A48C File Offset: 0x0050868C
	private void OnQuestFinishListNotify(IMessage msg, Net.CallbackStatus status)
	{
		QuestFinishListNotify questFinishListNotify = (QuestFinishListNotify)msg;
		FinishListNotifyData finishListNotifyData = new FinishListNotifyData();
		finishListNotifyData.QuestIds = questFinishListNotify.QuestId.ToList<int>();
		finishListNotifyData.EmitEventName = EEventName.OnQuestFinishListNotify;
		finishListNotifyData.TryChangeTrackedQuest = delegate()
		{
			QuestNewController.Instance.TryChangeTrackedQuest2(null);
		};
		QuestNewController.HandleFinishListNotify(finishListNotifyData);
	}

	// Token: 0x06014046 RID: 81990 RVA: 0x0050A4EC File Offset: 0x005086EC
	private void QuestStateUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		QuestStateUpdateNotify questStateUpdateNotify = (QuestStateUpdateNotify)msg;
		QuestNewController.HandleQuestStateUpdate(new QuestStateUpdateData
		{
			QuestId = questStateUpdateNotify.QuestId,
			State = questStateUpdateNotify.State,
			UpdateReason = EQuestStatusUpdateReason.NotifyChange
		});
	}

	// Token: 0x06014047 RID: 81991 RVA: 0x0050A529 File Offset: 0x00508729
	public ESetTrackResult RequestTrackQuest(int questId, bool bTrack, ERequestTrackOperate operate, ESetTrackReason reason = ESetTrackReason.None, Action finishCallback = null)
	{
		QuestTrackAssistant assistant = this.GetAssistant<QuestTrackAssistant>(QuestNewController.EAssistantType.Track);
		if (assistant == null)
		{
			return ESetTrackResult.QuestNotExist;
		}
		return assistant.RequestTrackQuest(questId, bTrack, operate, reason, finishCallback);
	}

	// Token: 0x06014048 RID: 81992 RVA: 0x0050A544 File Offset: 0x00508744
	public void TryTrackAndOpenWorldMap(int questId)
	{
		QuestNewController.<>c__DisplayClass67_0 CS$<>8__locals1 = new QuestNewController.<>c__DisplayClass67_0();
		CS$<>8__locals1.questId = questId;
		if (!QuestNewModel.Instance.IsTrackingQuest(CS$<>8__locals1.questId))
		{
			this.RequestTrackQuest(CS$<>8__locals1.questId, true, ERequestTrackOperate.Auto, ESetTrackReason.None, new Action(CS$<>8__locals1.<TryTrackAndOpenWorldMap>g__OpenWorldMapView|0));
			return;
		}
		CS$<>8__locals1.<TryTrackAndOpenWorldMap>g__OpenWorldMapView|0();
	}

	// Token: 0x06014049 RID: 81993 RVA: 0x0050A593 File Offset: 0x00508793
	public bool TryChangeTrackedQuest(int newQuestId)
	{
		QuestTrackAssistant assistant = QuestNewController.Instance.GetAssistant<QuestTrackAssistant>(QuestNewController.EAssistantType.Track);
		return assistant != null && assistant.TryChangeTrackedQuest(newQuestId);
	}

	// Token: 0x0601404A RID: 81994 RVA: 0x0050A5AC File Offset: 0x005087AC
	public bool TryChangeTrackedQuest2(int? newQuestId)
	{
		QuestTrackAssistant assistant = QuestNewController.Instance.GetAssistant<QuestTrackAssistant>(QuestNewController.EAssistantType.Track);
		return assistant != null && assistant.TryChangeTrackedQuest2(newQuestId);
	}

	// Token: 0x0601404B RID: 81995 RVA: 0x0050A5C5 File Offset: 0x005087C5
	[NullableContext(1)]
	private bool CanOpenView(EUiViewName viewName, object o)
	{
		return FunctionModel.Instance.IsOpen(10004);
	}

	// Token: 0x0601404C RID: 81996 RVA: 0x0050A5D8 File Offset: 0x005087D8
	private void OnQuestStateChange(int questId, QuestState state, EQuestStatusUpdateReason reason)
	{
		global::Quest quest = QuestNewModel.Instance.GetQuest(questId);
		if (quest == null)
		{
			return;
		}
		QuestType? questTypeConfig = QuestNewConfig.Instance.GetQuestTypeConfig((int)quest.Type);
		if (questTypeConfig == null || !questTypeConfig.Value.NeedRedDot || reason != EQuestStatusUpdateReason.NotifyChange)
		{
			return;
		}
		if (state == QuestState.Progress)
		{
			this.RedDotRequest(questId, EQuestRedDotOperate.Add);
			return;
		}
		if (state - QuestState.Finish > 1)
		{
			return;
		}
		this.RedDotRequest(questId, EQuestRedDotOperate.Delete);
	}

	// Token: 0x0601404D RID: 81997 RVA: 0x0050A644 File Offset: 0x00508844
	private void OnQuestRedDotNotify(IMessage msg, Net.CallbackStatus status)
	{
		QuestRedDotNotify questRedDotNotify = (QuestRedDotNotify)msg;
		if (!GeneralLogicTreeModel.Instance.IsWakeUp)
		{
			this.CachedRedDotNotify = questRedDotNotify;
			return;
		}
		foreach (int questId in questRedDotNotify.QuestId)
		{
			QuestNewModel.Instance.SetQuestRedDot(questId, true);
		}
	}

	// Token: 0x0601404E RID: 81998 RVA: 0x0050A6B4 File Offset: 0x005088B4
	private void OnBtRangeFailWarningNotify(IMessage msg, Net.CallbackStatus status)
	{
		BtRangeFailWarningNotify btRangeFailWarningNotify = (BtRangeFailWarningNotify)msg;
		this.QuestRangeFailWarningTreeId = MathUtils.Instance.LongToBigInt(btRangeFailWarningNotify.TreeIncId);
		this.IsHidingQuestRangeFailWarning = false;
		this.IsShowingQuestRangeFailWarning = true;
		this.IsShowQuestRangeFailWarning = true;
		this.ShowQuestRangeFialWarningTime = 0f;
		this.StartShowQuestRangeFialWarningTime = 0f;
		EUiViewName? viewNameByPromptId = GenericPromptController.Instance.GetViewNameByPromptId("QuestRangeFailWarning");
		if (viewNameByPromptId != null && !UiManager.Instance.IsViewOpen(viewNameByPromptId.Value))
		{
			GenericPromptController.Instance.ShowPromptByCode("QuestRangeFailWarning", Array.Empty<object>());
		}
	}

	// Token: 0x0601404F RID: 81999 RVA: 0x0050A74C File Offset: 0x0050894C
	private void OnQuestGiveUpNotify(IMessage __msg, Net.CallbackStatus status)
	{
		QuestGiveUpNotify questGiveUpNotify = (QuestGiveUpNotify)__msg;
		QuestNewController.HandleGiveUpNotify(questGiveUpNotify.QuestId, questGiveUpNotify.TreeIncId, questGiveUpNotify.FlowIncIds, delegate(int questId)
		{
			QuestReadyForGiveUpRequest questReadyForGiveUpRequest = new QuestReadyForGiveUpRequest();
			questReadyForGiveUpRequest.QuestId = questId;
			Net.Instance.Call(ERequestMessageId.QuestReadyForGiveUpRequest, questReadyForGiveUpRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				QuestReadyForGiveUpResponse questReadyForGiveUpResponse = (QuestReadyForGiveUpResponse)msg;
				if (questReadyForGiveUpResponse != null && questReadyForGiveUpResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(questReadyForGiveUpResponse.ErrorCode, 20397, null, true, true);
				}
			}, 0);
		}, "任务结束打断剧情");
	}

	// Token: 0x06014050 RID: 82000 RVA: 0x0050A79C File Offset: 0x0050899C
	[NullableContext(1)]
	private void OnPlotSequenceEnd(PlotResultInfo plotResultInfo)
	{
		if (QuestNewModel.Instance.IsServerNotifyEnd)
		{
			QuestNewModel.Instance.IsServerNotifyEnd = false;
			if (RecallQuestModel.Instance.IsInRecallInstance())
			{
				RecallQuestReadyForGiveUpRequest message = new RecallQuestReadyForGiveUpRequest
				{
					RecallQuestId = QuestNewModel.Instance.ServerNotifyEndQuestId
				};
				Net.Instance.Call(ERequestMessageId.RecallQuestReadyForGiveUpRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
				{
					RecallQuestReadyForGiveUpResponse recallQuestReadyForGiveUpResponse = (RecallQuestReadyForGiveUpResponse)msg;
					if (recallQuestReadyForGiveUpResponse != null && recallQuestReadyForGiveUpResponse.ErrorId != Aki.Protocol.ErrorCode.Success)
					{
						ErrorCodeController.Instance.OpenErrorCodeTipView(recallQuestReadyForGiveUpResponse.ErrorId, 19174, null, true, true);
					}
				}, 0);
				return;
			}
			QuestReadyForGiveUpRequest message2 = new QuestReadyForGiveUpRequest
			{
				QuestId = QuestNewModel.Instance.ServerNotifyEndQuestId
			};
			Net.Instance.Call(ERequestMessageId.QuestReadyForGiveUpRequest, message2, delegate(IMessage msg, Net.CallbackStatus _)
			{
				QuestReadyForGiveUpResponse questReadyForGiveUpResponse = (QuestReadyForGiveUpResponse)msg;
				if (questReadyForGiveUpResponse != null && questReadyForGiveUpResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(questReadyForGiveUpResponse.ErrorCode, 20397, null, true, true);
				}
			}, 0);
		}
	}

	// Token: 0x06014051 RID: 82001 RVA: 0x0050A85C File Offset: 0x00508A5C
	private void OnBtCancelRangeFailWarningNotify(IMessage msg, Net.CallbackStatus status)
	{
		if (this.IsShowQuestRangeFailWarning)
		{
			this.HideCancelRangeFailWaringEffect();
		}
	}

	// Token: 0x06014052 RID: 82002 RVA: 0x0050A86C File Offset: 0x00508A6C
	public void HideCancelRangeFailWaringEffect()
	{
		this.IsHidingQuestRangeFailWarning = true;
		this.IsShowingQuestRangeFailWarning = false;
		this.HidingQuestRangeFialWarningTime = 0f;
		this.QuestRangeFailWarningTreeId = 0L;
		this.IsShowQuestRangeFailWarning = false;
	}

	// Token: 0x06014053 RID: 82003 RVA: 0x0050A898 File Offset: 0x00508A98
	public void RedDotRequest(int questId, EQuestRedDotOperate operate)
	{
		QuestRedDotRequest questRedDotRequest = QuestRedDotRequest.Create();
		questRedDotRequest.QuestId = questId;
		questRedDotRequest.Operate = (int)operate;
		Net.Instance.Call(ERequestMessageId.QuestRedDotRequest, questRedDotRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			QuestRedDotResponse questRedDotResponse = (QuestRedDotResponse)msg;
			if (questRedDotResponse != null && questRedDotResponse.ErrorId != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(questRedDotResponse.ErrorId, 18604, null, true, true);
			}
			QuestNewModel.Instance.SetQuestRedDot(questId, operate == EQuestRedDotOperate.Add);
		}, 0);
	}

	// Token: 0x06014054 RID: 82004 RVA: 0x0050A8F4 File Offset: 0x00508AF4
	[NullableContext(1)]
	public bool IsTrackPositionOutFailRange(global::Vector position)
	{
		global::Quest curTrackedQuest = QuestNewModel.Instance.GetCurTrackedQuest();
		if (curTrackedQuest == null || curTrackedQuest.TreeId == null)
		{
			return false;
		}
		BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(curTrackedQuest.TreeId.Value), false);
		if (behaviorTree == null)
		{
			return false;
		}
		QuestFailedBehaviorNode processingFailedNode = behaviorTree.GetProcessingFailedNode();
		return processingFailedNode != null && !processingFailedNode.NeedRequiresSecondConfirmation && processingFailedNode.IsOutFailRange(position);
	}

	// Token: 0x06014055 RID: 82005 RVA: 0x0050A960 File Offset: 0x00508B60
	private void OnWaitQuestConfirmResourceNotify(IMessage msg, Net.CallbackStatus status)
	{
		WaitQuestConfirmResourceNotify waitQuestConfirmResourceNotify = (WaitQuestConfirmResourceNotify)msg;
		QuestNewModel instance = QuestNewModel.Instance;
		Log instance2 = Log.Instance;
		ELogModule module = ELogModule.QuestResource;
		ELogAuthor author = ELogAuthor.ZWY;
		string message = "WaitQuestConfirmResource";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("LackResourceQuestIds", string.Join<int>(",", waitQuestConfirmResourceNotify.LackResourceQuestIds));
		instance2.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (!instance.QuestVideoResourceDownloadFinished)
		{
			instance.IsLackQuestVideoResource = (waitQuestConfirmResourceNotify.LackResourceQuestIds.Count != 0);
		}
	}

	// Token: 0x06014056 RID: 82006 RVA: 0x0050A9CC File Offset: 0x00508BCC
	public void SetVideoResourceDownloadTriggerId(int questId)
	{
		this.VideoResourceDownloadTriggerId = new int?(questId);
	}

	// Token: 0x06014057 RID: 82007 RVA: 0x0050A9DA File Offset: 0x00508BDA
	public void SetIsReportDownloadNotEnoughSpace(bool result)
	{
		this.IsReportDownloadNotEnoughSpace = new bool?(result);
	}

	// Token: 0x06014058 RID: 82008 RVA: 0x0050A9E8 File Offset: 0x00508BE8
	private void OnQuestVideoResourceDownloadFinish(EVideoResSizeType resType)
	{
		EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
		if (playerGender != EPlayerGender.Female)
		{
			if (playerGender == EPlayerGender.Male && resType == EVideoResSizeType.MalePrepare)
			{
				QuestNewModel.Instance.IsLackQuestVideoResource = false;
				QuestNewModel.Instance.QuestVideoResourceDownloadFinished = true;
				EventSystem.Instance.Emit(EEventName.UpdateQuestListAndDetails);
			}
		}
		else if (resType == EVideoResSizeType.FemalePrepare)
		{
			QuestNewModel.Instance.IsLackQuestVideoResource = false;
			QuestNewModel.Instance.QuestVideoResourceDownloadFinished = true;
			EventSystem.Instance.Emit(EEventName.UpdateQuestListAndDetails);
		}
		if (resType == EVideoResSizeType.MalePrepare || resType == EVideoResSizeType.FemalePrepare)
		{
			DownloadVideoResLogData downloadVideoResLogData = new DownloadVideoResLogData();
			downloadVideoResLogData.i_task_id = this.VideoResourceDownloadTriggerId.GetValueOrDefault();
			downloadVideoResLogData.b_if_storage_alert = this.IsReportDownloadNotEnoughSpace.GetValueOrDefault();
			downloadVideoResLogData.i_role_id = ((playerGender == EPlayerGender.Female) ? 2 : 1);
			if (resType == EVideoResSizeType.FemalePrepare)
			{
				downloadVideoResLogData.i_resource_type = 2;
				ValueTuple<double, double, double, bool> reportLogData = VideoUpdateManager.Instance.GetVideoUpdater(EVideoResSizeType.FemalePrepare).GetReportLogData();
				double item = reportLogData.Item1;
				double item2 = reportLogData.Item2;
				double item3 = reportLogData.Item3;
				bool item4 = reportLogData.Item4;
				downloadVideoResLogData.i_peak_speed = (int)item;
				downloadVideoResLogData.i_resource_size = item2;
				downloadVideoResLogData.i_download_time = (int)item3;
				downloadVideoResLogData.b_if_storage_alert = item4;
				downloadVideoResLogData.i_download_status = 1;
			}
			else
			{
				downloadVideoResLogData.i_resource_type = 1;
				ValueTuple<double, double, double, bool> reportLogData2 = VideoUpdateManager.Instance.GetVideoUpdater(EVideoResSizeType.MalePrepare).GetReportLogData();
				double item5 = reportLogData2.Item1;
				double item6 = reportLogData2.Item2;
				double item7 = reportLogData2.Item3;
				bool item8 = reportLogData2.Item4;
				downloadVideoResLogData.i_peak_speed = (int)item5;
				downloadVideoResLogData.i_resource_size = item6;
				downloadVideoResLogData.i_download_time = (int)item7;
				downloadVideoResLogData.b_if_storage_alert = item8;
				downloadVideoResLogData.i_download_status = 1;
			}
			LogReportController.Instance.LogReport(downloadVideoResLogData);
		}
	}

	// Token: 0x06014059 RID: 82009 RVA: 0x0050AB74 File Offset: 0x00508D74
	[NullableContext(1)]
	public void ConfirmQuestResourceRequest(int questId, Action callback = null)
	{
		ConfirmQuestResourceRequest confirmQuestResourceRequest = Aki.Protocol.ConfirmQuestResourceRequest.Create();
		confirmQuestResourceRequest.QuestIds.Add(questId);
		Net.Instance.Call(ERequestMessageId.ConfirmQuestResourceRequest, confirmQuestResourceRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ConfirmQuestResourceResponse confirmQuestResourceResponse = (ConfirmQuestResourceResponse)msg;
			if (confirmQuestResourceResponse != null)
			{
				if (confirmQuestResourceResponse.ErrorId != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(confirmQuestResourceResponse.ErrorId, 26295, null, true, true);
				}
				QuestNewModel.Instance.RemoveLackResourceQuest(questId);
				Action callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2();
			}
		}, 0);
	}

	// Token: 0x0601405A RID: 82010 RVA: 0x0050ABCC File Offset: 0x00508DCC
	[NullableContext(1)]
	public void RequestSetQuestFocusMode(int questId, Action<bool> callback = null)
	{
		SetQuestFocusModeRequest setQuestFocusModeRequest = SetQuestFocusModeRequest.Create();
		setQuestFocusModeRequest.QuestId = questId;
		Net.Instance.Call(ERequestMessageId.SetQuestFocusModeRequest, setQuestFocusModeRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			SetQuestFocusModeResponse setQuestFocusModeResponse = (SetQuestFocusModeResponse)msg;
			if (setQuestFocusModeResponse != null)
			{
				if (setQuestFocusModeResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					if (setQuestFocusModeResponse.ErrorCode == Aki.Protocol.ErrorCode.ErrForcedOccupationResource || setQuestFocusModeResponse.ErrorCode == Aki.Protocol.ErrorCode.InstanceCannotSetQuestFocus || setQuestFocusModeResponse.ErrorCode == Aki.Protocol.ErrorCode.InstanceCannotCancelQuestFocus || setQuestFocusModeResponse.ErrorCode == Aki.Protocol.ErrorCode.DisabledFocusMode)
					{
						string textByErrorId = ErrorCodeConfig.Instance.GetTextByErrorId(setQuestFocusModeResponse.ErrorCode);
						ScrollingTipsController.Instance.ShowTipsByText(textByErrorId);
					}
					else
					{
						ErrorCodeController.Instance.OpenErrorCodeTipView(setQuestFocusModeResponse.ErrorCode, 21189, null, true, true);
					}
				}
				Action<bool> callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2(false);
			}
		}, 0);
	}

	// Token: 0x0601405B RID: 82011 RVA: 0x0050AC10 File Offset: 0x00508E10
	[NullableContext(1)]
	public void RequestCancelQuestFocusMode(int questId, Action callback)
	{
		CancelQuestFocusModeRequest cancelQuestFocusModeRequest = CancelQuestFocusModeRequest.Create();
		cancelQuestFocusModeRequest.QuestId = questId;
		Net.Instance.Call(ERequestMessageId.CancelQuestFocusModeRequest, cancelQuestFocusModeRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			CancelQuestFocusModeResponse cancelQuestFocusModeResponse = (CancelQuestFocusModeResponse)msg;
			if (cancelQuestFocusModeResponse != null)
			{
				if (cancelQuestFocusModeResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(cancelQuestFocusModeResponse.ErrorCode, 29321, null, true, true);
				}
				Action callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2();
			}
		}, 0);
	}

	// Token: 0x0601405C RID: 82012 RVA: 0x0050AC54 File Offset: 0x00508E54
	public void RequestSetFocusModeDeterCondition(bool deterCond)
	{
		SetFocusModeDeterCondRequest setFocusModeDeterCondRequest = SetFocusModeDeterCondRequest.Create();
		setFocusModeDeterCondRequest.DeterCond = deterCond;
		Net.Instance.Call(ERequestMessageId.SetFocusModeDeterCondRequest, setFocusModeDeterCondRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			SetFocusModeDeterCondResponse setFocusModeDeterCondResponse = (SetFocusModeDeterCondResponse)msg;
			if (setFocusModeDeterCondResponse != null && setFocusModeDeterCondResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(setFocusModeDeterCondResponse.ErrorCode, 17260, null, true, true);
			}
		}, 0);
	}

	// Token: 0x0601405D RID: 82013 RVA: 0x0050ACA0 File Offset: 0x00508EA0
	[NullableContext(1)]
	public void RequestAcceptFocusWaitQuest(int questId, Action callback)
	{
		AcceptFocusWaitQuestRequest acceptFocusWaitQuestRequest = AcceptFocusWaitQuestRequest.Create();
		acceptFocusWaitQuestRequest.QuestId = questId;
		Net.Instance.Call(ERequestMessageId.AcceptFocusWaitQuestRequest, acceptFocusWaitQuestRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			AcceptFocusWaitQuestResponse acceptFocusWaitQuestResponse = (AcceptFocusWaitQuestResponse)msg;
			if (acceptFocusWaitQuestResponse != null)
			{
				if (acceptFocusWaitQuestResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(acceptFocusWaitQuestResponse.ErrorCode, 17260, null, true, true);
				}
				QuestNewModel.Instance.RemovePendingAcceptQuestOnFocusMode(questId);
				if (callback != null)
				{
					Action callback2 = callback;
					if (callback2 == null)
					{
						return;
					}
					callback2();
				}
			}
		}, 0);
	}

	// Token: 0x0601405E RID: 82014 RVA: 0x0050ACF0 File Offset: 0x00508EF0
	private void OnStartSetQuestFocusNotify(IMessage msg, Net.CallbackStatus status)
	{
		StartSetQuestFocusNotify startSetQuestFocusNotify = (StartSetQuestFocusNotify)msg;
		QuestNewModel.Instance.SetFocusQuestId(startSetQuestFocusNotify.FocusQuestId);
		if (startSetQuestFocusNotify.Reason == QuestFocusReason.Inherit)
		{
			return;
		}
		LevelLoadingController.Instance.OpenLoading<ELoadingPerform>(ELoadingReason.QuestFocusMode, ELoadingPerform.VideoCenter, null, null, new object[]
		{
			"Task_Focus_EnterFocusMode"
		});
		this.DelayTimerHandle = TimerSystem.Instance.Delay(delegate(float _)
		{
			LevelLoadingController.Instance.CloseLoading(ELoadingReason.QuestFocusMode, null, null, null);
		}, 5000f, null, null, true, 1f);
	}

	// Token: 0x0601405F RID: 82015 RVA: 0x0050AD78 File Offset: 0x00508F78
	private void OnQuestFocusInfoNotify(IMessage msg, Net.CallbackStatus status)
	{
		QuestFocusInfoNotify notify = (QuestFocusInfoNotify)msg;
		QuestNewModel.Instance.SetFocusQuestId(notify.FocusQuestId);
		if (TimerSystem.Instance.Has(this.DelayTimerHandle))
		{
			TimerSystem.Instance.Remove(this.DelayTimerHandle);
		}
		this.DelayTimerHandle = TimerSystem.Instance.Delay(delegate(float _)
		{
			LevelLoadingController.Instance.CloseLoading(ELoadingReason.QuestFocusMode, null, null, null);
			if (notify.FocusQuestId != 0)
			{
				this.RequestTrackQuest(notify.FocusQuestId, true, ERequestTrackOperate.Auto, ESetTrackReason.None, null);
			}
			if (TimerSystem.Instance.Has(this.DelayTimerHandle))
			{
				TimerSystem.Instance.Remove(this.DelayTimerHandle);
			}
		}, 2000f, null, null, true, 1f);
	}

	// Token: 0x06014060 RID: 82016 RVA: 0x0050AE00 File Offset: 0x00509000
	private void OnQuestLockInfoNotify(IMessage msg, Net.CallbackStatus status)
	{
		QuestLockInfoNotify questLockInfoNotify = (QuestLockInfoNotify)msg;
		QuestNewModel instance = QuestNewModel.Instance;
		foreach (int questId in instance.GetAllLockQuests())
		{
			instance.LockQuestSuspendByOnline(questId, false);
		}
		foreach (QuestLockInfo lockInfo in questLockInfoNotify.QuestLockInfos)
		{
			instance.AddQuestLockInfo(lockInfo);
		}
	}

	// Token: 0x06014061 RID: 82017 RVA: 0x0050AEA4 File Offset: 0x005090A4
	private void OnInteractQuestSuspendEntityNotify(IMessage msg, Net.CallbackStatus status)
	{
		InteractQuestSuspendEntityNotify interactQuestSuspendEntityNotify = (InteractQuestSuspendEntityNotify)msg;
		global::Quest quest = QuestNewModel.Instance.GetQuest(interactQuestSuspendEntityNotify.QuestId);
		if (quest == null)
		{
			return;
		}
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew("Text_TaskSuspendedInteractionDisabled_Text", null);
		string item = ((localTextNew != null) ? localTextNew.Replace("{0}", quest.Name) : null) ?? "Text_TaskSuspendedInteractionDisabled_Text";
		GenericPromptController.Instance.ShowPromptByItsType<object>(EPromptSubViewType.FloatLinePrompt, null, null, new <>z__ReadOnlySingleElementList<object>(item), null, null, null, null, null, false, null);
	}

	// Token: 0x06014062 RID: 82018 RVA: 0x0050AF24 File Offset: 0x00509124
	private void OnResetQuestFocusModeNotify(IMessage msg, Net.CallbackStatus status)
	{
		ResetQuestFocusModeReason reason = ((ResetQuestFocusModeNotify)msg).Reason;
		string text;
		if (reason != ResetQuestFocusModeReason.EnterSealedArea)
		{
			if (reason == ResetQuestFocusModeReason.ForceOccupyFail)
			{
				text = "Task_Focus_Tips04";
			}
			else
			{
				text = null;
			}
		}
		else
		{
			text = "Task_Focus_Tips03";
		}
		string text2 = text;
		if (text2 == null)
		{
			return;
		}
		string item = ConfigMultiTextLang.GetLocalTextNew(text2, null) ?? text2;
		GenericPromptController.Instance.ShowPromptByItsType<object>(EPromptSubViewType.FloatLinePrompt, null, null, new <>z__ReadOnlySingleElementList<object>(item), null, null, null, null, null, false, null);
	}

	// Token: 0x06014063 RID: 82019 RVA: 0x0050AF98 File Offset: 0x00509198
	[NullableContext(1)]
	public static void HandleGiveUpNotify(int questId, long treeIncId, IReadOnlyList<long> flowIncIds, Action<int> sendReadyForGiveUpRequest, string reason)
	{
		long value = MathUtils.Instance.LongToBigInt(treeIncId);
		BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(value), false);
		if (behaviorTree != null)
		{
			behaviorTree.StopCurrentActions();
		}
		bool flag = false;
		long flowIncId = FlowController.Instance.GetFlowIncId();
		foreach (long num in flowIncIds)
		{
			if (flowIncId == num)
			{
				flag = true;
				break;
			}
		}
		if (PlotModel.Instance.IsInPlot && flag)
		{
			FlowController.Instance.FinishFlow(reason, null, false);
			QuestNewModel.Instance.IsServerNotifyEnd = true;
			QuestNewModel.Instance.ServerNotifyEndQuestId = questId;
			return;
		}
		sendReadyForGiveUpRequest(questId);
	}

	// Token: 0x06014064 RID: 82020 RVA: 0x0050B060 File Offset: 0x00509260
	[NullableContext(1)]
	public static void HandleQuestListNotify(IReadOnlyList<QuestListItem> items)
	{
		foreach (QuestListItem questListItem in items)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Quest;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "上线下发任务";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("任务id", questListItem.QuestId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			global::Quest quest = QuestNewModel.Instance.AddQuest(questListItem.QuestId);
			if (quest != null)
			{
				quest.UpdateState(questListItem.State, questListItem.UpdateReason);
			}
		}
	}

	// Token: 0x06014065 RID: 82021 RVA: 0x0050B0F8 File Offset: 0x005092F8
	[NullableContext(1)]
	public unsafe static void HandleQuestStateUpdate(QuestStateUpdateData data)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Quest;
		ELogAuthor author = ELogAuthor.YSQ;
		string message = "任务状态更新";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("任务Id", data.QuestId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("StateId", data.State);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		switch (data.State)
		{
		case QuestState.InActive:
		case QuestState.Ready:
		case QuestState.Progress:
		{
			global::Quest quest = QuestNewModel.Instance.AddQuest(data.QuestId);
			if (quest == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Quest;
				ELogAuthor author2 = ELogAuthor.YSQ;
				string message2 = "任务状态更新时：任务不存在";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("任务Id", data.QuestId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("StateId", data.State);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			}
			else
			{
				quest.UpdateState(data.State, data.UpdateReason);
			}
			break;
		}
		case QuestState.Finish:
		{
			QuestNewModel.Instance.AddFinishedQuest(data.QuestId);
			global::Quest quest2 = QuestNewModel.Instance.GetQuest(data.QuestId);
			if (quest2 != null)
			{
				quest2.UpdateState(data.State, data.UpdateReason);
			}
			break;
		}
		case QuestState.Delete:
		{
			global::Quest quest3 = QuestNewModel.Instance.GetQuest(data.QuestId);
			QuestNewModel.Instance.RemoveQuest(data.QuestId);
			if (quest3 != null)
			{
				quest3.UpdateState(data.State, data.UpdateReason);
			}
			break;
		}
		}
		Action onAfterUpdate = data.OnAfterUpdate;
		if (onAfterUpdate == null)
		{
			return;
		}
		onAfterUpdate();
	}

	// Token: 0x06014066 RID: 82022 RVA: 0x0050B2A8 File Offset: 0x005094A8
	[NullableContext(1)]
	public static void HandleFinishListNotify(FinishListNotifyData data)
	{
		foreach (int questId in data.QuestIds)
		{
			QuestNewModel.Instance.AddFinishedQuest(questId);
		}
		EventSystem.Instance.Emit(data.EmitEventName);
		Action tryChangeTrackedQuest = data.TryChangeTrackedQuest;
		if (tryChangeTrackedQuest == null)
		{
			return;
		}
		tryChangeTrackedQuest();
	}

	// Token: 0x06014067 RID: 82023 RVA: 0x0050B320 File Offset: 0x00509520
	public static void NotifyTraceQuestFromServer(int questId)
	{
		if (questId == 0)
		{
			return;
		}
		QuestNewModel.Instance.SetQuestTrackState(questId, true, ESetTrackReason.None);
	}

	// Token: 0x06014068 RID: 82024 RVA: 0x0050B334 File Offset: 0x00509534
	public void RequestQuestNpcMoveOver(long creatureDataId)
	{
		if (RecallQuestModel.Instance.IsInRecallInstance())
		{
			RecallQuestController.Instance.RequestRecallQuestNpcMoveOver(creatureDataId);
			return;
		}
		QuestNpcMoveOverRequest questNpcMoveOverRequest = QuestNpcMoveOverRequest.Create();
		questNpcMoveOverRequest.EntityId = creatureDataId;
		Net.Instance.Call(ERequestMessageId.QuestNpcMoveOverRequest, questNpcMoveOverRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			QuestNpcMoveOverResponse questNpcMoveOverResponse = (QuestNpcMoveOverResponse)msg;
			if (questNpcMoveOverResponse != null && questNpcMoveOverResponse.ErrorId != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(questNpcMoveOverResponse.ErrorId, 19722, null, true, true);
			}
		}, 0);
	}

	// Token: 0x1700197E RID: 6526
	// (get) Token: 0x06014069 RID: 82025 RVA: 0x0050B396 File Offset: 0x00509596
	[Nullable(1)]
	public static QuestNewController Instance
	{
		[NullableContext(1)]
		get
		{
			return QuestNewController._Instance;
		}
	}

	// Token: 0x0601406A RID: 82026 RVA: 0x0050B39D File Offset: 0x0050959D
	[NullableContext(1)]
	public static QuestNewController GetOrCreateInstance()
	{
		if (QuestNewController._Instance == null)
		{
			QuestNewController.CreateInstance();
		}
		return QuestNewController._Instance;
	}

	// Token: 0x0601406B RID: 82027 RVA: 0x0050B3B1 File Offset: 0x005095B1
	public static bool CreateInstance()
	{
		if (QuestNewController._Instance != null)
		{
			return true;
		}
		QuestNewController._Instance = new QuestNewController();
		return true;
	}

	// Token: 0x0601406C RID: 82028 RVA: 0x0050B3C7 File Offset: 0x005095C7
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601406D RID: 82029 RVA: 0x0050B3C9 File Offset: 0x005095C9
	public static void ResetStaticDefaultValue()
	{
		QuestNewController._Instance = null;
	}

	// Token: 0x0601406E RID: 82030 RVA: 0x0050B3D1 File Offset: 0x005095D1
	static QuestNewController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(QuestNewController.CreateStaticDefaultValue), new Action(QuestNewController.ResetStaticDefaultValue));
	}

	// Token: 0x040096F6 RID: 38646
	private readonly float ShowQuestRangeFailWarningTime = 300f;

	// Token: 0x040096FA RID: 38650
	[Nullable(1)]
	private const string TIPS_NAME = "QuestRangeFailWarning";

	// Token: 0x040096FB RID: 38651
	private static QuestNewController _Instance;

	// Token: 0x02008C87 RID: 35975
	[NullableContext(0)]
	private enum EAssistantType
	{
		// Token: 0x0402D9E6 RID: 186854
		GuideLine,
		// Token: 0x0402D9E7 RID: 186855
		Track,
		// Token: 0x0402D9E8 RID: 186856
		GuideEffect,
		// Token: 0x0402D9E9 RID: 186857
		DailyQuest
	}
}
