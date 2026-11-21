using System;
using System.Collections.Generic;
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

// Token: 0x02001B21 RID: 6945
[NullableContext(2)]
[Nullable(0)]
[TickController(0)]
public class QuestNewController : ControllerWithAssistantBase
{
	// Token: 0x170019AB RID: 6571
	// (get) Token: 0x060114FF RID: 70911 RVA: 0x00518721 File Offset: 0x00516921
	// (set) Token: 0x06011500 RID: 70912 RVA: 0x00518729 File Offset: 0x00516929
	[Nullable(1)]
	private QuestRedDotNotify CachedRedDotNotify { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x170019AC RID: 6572
	// (get) Token: 0x06011501 RID: 70913 RVA: 0x00518732 File Offset: 0x00516932
	// (set) Token: 0x06011502 RID: 70914 RVA: 0x0051873A File Offset: 0x0051693A
	public long QuestRangeFailWarningTreeId { get; set; }

	// Token: 0x170019AD RID: 6573
	// (get) Token: 0x06011503 RID: 70915 RVA: 0x00518743 File Offset: 0x00516943
	// (set) Token: 0x06011504 RID: 70916 RVA: 0x0051874B File Offset: 0x0051694B
	private bool IsHidingQuestRangeFailWarning { get; set; }

	// Token: 0x170019AE RID: 6574
	// (get) Token: 0x06011505 RID: 70917 RVA: 0x00518754 File Offset: 0x00516954
	// (set) Token: 0x06011506 RID: 70918 RVA: 0x0051875C File Offset: 0x0051695C
	private float HidingQuestRangeFialWarningTime { get; set; }

	// Token: 0x170019AF RID: 6575
	// (get) Token: 0x06011507 RID: 70919 RVA: 0x00518765 File Offset: 0x00516965
	// (set) Token: 0x06011508 RID: 70920 RVA: 0x0051876D File Offset: 0x0051696D
	private bool IsShowingQuestRangeFailWarning { get; set; }

	// Token: 0x170019B0 RID: 6576
	// (get) Token: 0x06011509 RID: 70921 RVA: 0x00518776 File Offset: 0x00516976
	// (set) Token: 0x0601150A RID: 70922 RVA: 0x0051877E File Offset: 0x0051697E
	private float ShowQuestRangeFialWarningTime { get; set; }

	// Token: 0x170019B1 RID: 6577
	// (get) Token: 0x0601150B RID: 70923 RVA: 0x00518787 File Offset: 0x00516987
	// (set) Token: 0x0601150C RID: 70924 RVA: 0x0051878F File Offset: 0x0051698F
	private bool IsShowQuestRangeFailWarning { get; set; }

	// Token: 0x170019B2 RID: 6578
	// (get) Token: 0x0601150D RID: 70925 RVA: 0x00518798 File Offset: 0x00516998
	// (set) Token: 0x0601150E RID: 70926 RVA: 0x005187A0 File Offset: 0x005169A0
	private float StartShowQuestRangeFialWarningTime { get; set; }

	// Token: 0x170019B3 RID: 6579
	// (get) Token: 0x0601150F RID: 70927 RVA: 0x005187A9 File Offset: 0x005169A9
	// (set) Token: 0x06011510 RID: 70928 RVA: 0x005187B1 File Offset: 0x005169B1
	private TimerHandle DelayTimerHandle { get; set; }

	// Token: 0x170019B4 RID: 6580
	// (get) Token: 0x06011511 RID: 70929 RVA: 0x005187BA File Offset: 0x005169BA
	// (set) Token: 0x06011512 RID: 70930 RVA: 0x005187C2 File Offset: 0x005169C2
	private int? VideoResourceDownloadTriggerId { get; set; }

	// Token: 0x170019B5 RID: 6581
	// (get) Token: 0x06011513 RID: 70931 RVA: 0x005187CB File Offset: 0x005169CB
	// (set) Token: 0x06011514 RID: 70932 RVA: 0x005187D3 File Offset: 0x005169D3
	private bool? IsReportDownloadNotEnoughSpace { get; set; }

	// Token: 0x06011515 RID: 70933 RVA: 0x005187DC File Offset: 0x005169DC
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

	// Token: 0x06011516 RID: 70934 RVA: 0x00518994 File Offset: 0x00516B94
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

	// Token: 0x06011517 RID: 70935 RVA: 0x00518A87 File Offset: 0x00516C87
	protected override bool OnInit()
	{
		base.InitTickOptimize(30, -1);
		return base.OnInit();
	}

	// Token: 0x06011518 RID: 70936 RVA: 0x00518A98 File Offset: 0x00516C98
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

	// Token: 0x06011519 RID: 70937 RVA: 0x00518BAC File Offset: 0x00516DAC
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

	// Token: 0x0601151A RID: 70938 RVA: 0x00518C84 File Offset: 0x00516E84
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

	// Token: 0x0601151B RID: 70939 RVA: 0x00518E08 File Offset: 0x00517008
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

	// Token: 0x0601151C RID: 70940 RVA: 0x00518E58 File Offset: 0x00517058
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

	// Token: 0x0601151D RID: 70941 RVA: 0x00518E8A File Offset: 0x0051708A
	public void AddQuestTraceEffect(int questId, float showTime, int splineEntityId)
	{
		GuideEffectAssistant assistant = this.GetAssistant<GuideEffectAssistant>(QuestNewController.EAssistantType.GuideEffect);
		if (assistant == null)
		{
			return;
		}
		assistant.AddQuestTraceEffect(questId, showTime, splineEntityId);
	}

	// Token: 0x0601151E RID: 70942 RVA: 0x00518EA0 File Offset: 0x005170A0
	public void RemoveQuestTraceEffect(int questId, int splineEntityId)
	{
		GuideEffectAssistant assistant = this.GetAssistant<GuideEffectAssistant>(QuestNewController.EAssistantType.GuideEffect);
		if (assistant == null)
		{
			return;
		}
		assistant.RemoveQuestTraceEffect(questId, splineEntityId);
	}

	// Token: 0x0601151F RID: 70943 RVA: 0x00518EB5 File Offset: 0x005170B5
	public void ClearQuestTraceEffect(int questId)
	{
		GuideEffectAssistant assistant = this.GetAssistant<GuideEffectAssistant>(QuestNewController.EAssistantType.GuideEffect);
		if (assistant == null)
		{
			return;
		}
		assistant.ClearQuestTraceEffect(questId);
	}

	// Token: 0x06011520 RID: 70944 RVA: 0x00518ECC File Offset: 0x005170CC
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

	// Token: 0x06011521 RID: 70945 RVA: 0x00518F1C File Offset: 0x0051711C
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

	// Token: 0x06011522 RID: 70946 RVA: 0x00518FD0 File Offset: 0x005171D0
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

	// Token: 0x06011523 RID: 70947 RVA: 0x00519130 File Offset: 0x00517330
	private void OnWorldDone()
	{
		this.AreaChanged(null, 0);
	}

	// Token: 0x06011524 RID: 70948 RVA: 0x00519150 File Offset: 0x00517350
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

	// Token: 0x06011525 RID: 70949 RVA: 0x00519260 File Offset: 0x00517460
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

	// Token: 0x06011526 RID: 70950 RVA: 0x005192A8 File Offset: 0x005174A8
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

	// Token: 0x06011527 RID: 70951 RVA: 0x0051939C File Offset: 0x0051759C
	private void OnQuestFinishListNotify(IMessage msg, Net.CallbackStatus status)
	{
		QuestFinishListNotify questFinishListNotify = (QuestFinishListNotify)msg;
		FinishListNotifyData finishListNotifyData = new FinishListNotifyData();
		finishListNotifyData.QuestIds = new List<int>(questFinishListNotify.QuestId);
		finishListNotifyData.EmitEventName = EEventName.OnQuestFinishListNotify;
		finishListNotifyData.TryChangeTrackedQuest = delegate()
		{
			QuestNewController.Instance.TryChangeTrackedQuest2(null);
		};
		QuestNewController.HandleFinishListNotify(finishListNotifyData);
		EventSystem.Instance.Emit(EEventName.OnNormalQuestFinishListNotify);
	}

	// Token: 0x06011528 RID: 70952 RVA: 0x0051940C File Offset: 0x0051760C
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

	// Token: 0x06011529 RID: 70953 RVA: 0x00519449 File Offset: 0x00517649
	public ESetTrackResult RequestTrackQuest(int questId, bool bTrack, ERequestTrackOperate operate, ESetTrackReason reason = ESetTrackReason.None, Action finishCallback = null)
	{
		QuestTrackAssistant assistant = this.GetAssistant<QuestTrackAssistant>(QuestNewController.EAssistantType.Track);
		if (assistant == null)
		{
			return ESetTrackResult.QuestNotExist;
		}
		return assistant.RequestTrackQuest(questId, bTrack, operate, reason, finishCallback);
	}

	// Token: 0x0601152A RID: 70954 RVA: 0x00519464 File Offset: 0x00517664
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

	// Token: 0x0601152B RID: 70955 RVA: 0x005194B3 File Offset: 0x005176B3
	public bool TryChangeTrackedQuest(int newQuestId)
	{
		QuestTrackAssistant assistant = QuestNewController.Instance.GetAssistant<QuestTrackAssistant>(QuestNewController.EAssistantType.Track);
		return assistant != null && assistant.TryChangeTrackedQuest(newQuestId);
	}

	// Token: 0x0601152C RID: 70956 RVA: 0x005194CC File Offset: 0x005176CC
	public bool TryChangeTrackedQuest2(int? newQuestId)
	{
		QuestTrackAssistant assistant = QuestNewController.Instance.GetAssistant<QuestTrackAssistant>(QuestNewController.EAssistantType.Track);
		return assistant != null && assistant.TryChangeTrackedQuest2(newQuestId);
	}

	// Token: 0x0601152D RID: 70957 RVA: 0x005194E5 File Offset: 0x005176E5
	[NullableContext(1)]
	private bool CanOpenView(EUiViewName viewName, object o)
	{
		return FunctionModel.Instance.IsOpen(10004);
	}

	// Token: 0x0601152E RID: 70958 RVA: 0x005194F8 File Offset: 0x005176F8
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

	// Token: 0x0601152F RID: 70959 RVA: 0x00519564 File Offset: 0x00517764
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

	// Token: 0x06011530 RID: 70960 RVA: 0x005195D4 File Offset: 0x005177D4
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

	// Token: 0x06011531 RID: 70961 RVA: 0x0051966C File Offset: 0x0051786C
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(questReadyForGiveUpResponse.ErrorCode, 19178, null, true, true);
				}
			}, 0);
		}, "任务结束打断剧情");
	}

	// Token: 0x06011532 RID: 70962 RVA: 0x005196BC File Offset: 0x005178BC
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
						ErrorCodeController.Instance.OpenErrorCodeTipView(recallQuestReadyForGiveUpResponse.ErrorId, 21194, null, true, true);
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(questReadyForGiveUpResponse.ErrorCode, 19178, null, true, true);
				}
			}, 0);
		}
	}

	// Token: 0x06011533 RID: 70963 RVA: 0x0051977C File Offset: 0x0051797C
	private void OnBtCancelRangeFailWarningNotify(IMessage msg, Net.CallbackStatus status)
	{
		if (this.IsShowQuestRangeFailWarning)
		{
			this.HideCancelRangeFailWaringEffect();
		}
	}

	// Token: 0x06011534 RID: 70964 RVA: 0x0051978C File Offset: 0x0051798C
	public void HideCancelRangeFailWaringEffect()
	{
		this.IsHidingQuestRangeFailWarning = true;
		this.IsShowingQuestRangeFailWarning = false;
		this.HidingQuestRangeFialWarningTime = 0f;
		this.QuestRangeFailWarningTreeId = 0L;
		this.IsShowQuestRangeFailWarning = false;
	}

	// Token: 0x06011535 RID: 70965 RVA: 0x005197B8 File Offset: 0x005179B8
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(questRedDotResponse.ErrorId, 29563, null, true, true);
			}
			QuestNewModel.Instance.SetQuestRedDot(questId, operate == EQuestRedDotOperate.Add);
		}, 0);
	}

	// Token: 0x06011536 RID: 70966 RVA: 0x00519814 File Offset: 0x00517A14
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

	// Token: 0x06011537 RID: 70967 RVA: 0x00519880 File Offset: 0x00517A80
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

	// Token: 0x06011538 RID: 70968 RVA: 0x005198EC File Offset: 0x00517AEC
	public void SetVideoResourceDownloadTriggerId(int questId)
	{
		this.VideoResourceDownloadTriggerId = new int?(questId);
	}

	// Token: 0x06011539 RID: 70969 RVA: 0x005198FA File Offset: 0x00517AFA
	public void SetIsReportDownloadNotEnoughSpace(bool result)
	{
		this.IsReportDownloadNotEnoughSpace = new bool?(result);
	}

	// Token: 0x0601153A RID: 70970 RVA: 0x00519908 File Offset: 0x00517B08
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

	// Token: 0x0601153B RID: 70971 RVA: 0x00519A94 File Offset: 0x00517C94
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(confirmQuestResourceResponse.ErrorId, 24175, null, true, true);
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

	// Token: 0x0601153C RID: 70972 RVA: 0x00519AEC File Offset: 0x00517CEC
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
						ErrorCodeController.Instance.OpenErrorCodeTipView(setQuestFocusModeResponse.ErrorCode, 22593, null, true, true);
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

	// Token: 0x0601153D RID: 70973 RVA: 0x00519B30 File Offset: 0x00517D30
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(cancelQuestFocusModeResponse.ErrorCode, 28253, null, true, true);
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

	// Token: 0x0601153E RID: 70974 RVA: 0x00519B74 File Offset: 0x00517D74
	public void RequestSetFocusModeDeterCondition(bool deterCond)
	{
		SetFocusModeDeterCondRequest setFocusModeDeterCondRequest = SetFocusModeDeterCondRequest.Create();
		setFocusModeDeterCondRequest.DeterCond = deterCond;
		Net.Instance.Call(ERequestMessageId.SetFocusModeDeterCondRequest, setFocusModeDeterCondRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			SetFocusModeDeterCondResponse setFocusModeDeterCondResponse = (SetFocusModeDeterCondResponse)msg;
			if (setFocusModeDeterCondResponse != null && setFocusModeDeterCondResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(setFocusModeDeterCondResponse.ErrorCode, 23033, null, true, true);
			}
		}, 0);
	}

	// Token: 0x0601153F RID: 70975 RVA: 0x00519BC0 File Offset: 0x00517DC0
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(acceptFocusWaitQuestResponse.ErrorCode, 23033, null, true, true);
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

	// Token: 0x06011540 RID: 70976 RVA: 0x00519C10 File Offset: 0x00517E10
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

	// Token: 0x06011541 RID: 70977 RVA: 0x00519C98 File Offset: 0x00517E98
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

	// Token: 0x06011542 RID: 70978 RVA: 0x00519D20 File Offset: 0x00517F20
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

	// Token: 0x06011543 RID: 70979 RVA: 0x00519DC4 File Offset: 0x00517FC4
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

	// Token: 0x06011544 RID: 70980 RVA: 0x00519E44 File Offset: 0x00518044
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

	// Token: 0x06011545 RID: 70981 RVA: 0x00519EB8 File Offset: 0x005180B8
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

	// Token: 0x06011546 RID: 70982 RVA: 0x00519F80 File Offset: 0x00518180
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

	// Token: 0x06011547 RID: 70983 RVA: 0x0051A018 File Offset: 0x00518218
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

	// Token: 0x06011548 RID: 70984 RVA: 0x0051A1C8 File Offset: 0x005183C8
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

	// Token: 0x06011549 RID: 70985 RVA: 0x0051A240 File Offset: 0x00518440
	public static void NotifyTraceQuestFromServer(int questId)
	{
		if (questId == 0)
		{
			return;
		}
		QuestNewModel.Instance.SetQuestTrackState(questId, true, ESetTrackReason.None);
	}

	// Token: 0x0601154A RID: 70986 RVA: 0x0051A254 File Offset: 0x00518454
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(questNpcMoveOverResponse.ErrorId, 21885, null, true, true);
			}
		}, 0);
	}

	// Token: 0x170019B6 RID: 6582
	// (get) Token: 0x0601154B RID: 70987 RVA: 0x0051A2B6 File Offset: 0x005184B6
	[Nullable(1)]
	public static QuestNewController Instance
	{
		[NullableContext(1)]
		get
		{
			return QuestNewController._Instance;
		}
	}

	// Token: 0x0601154C RID: 70988 RVA: 0x0051A2BD File Offset: 0x005184BD
	[NullableContext(1)]
	public static QuestNewController GetOrCreateInstance()
	{
		if (QuestNewController._Instance == null)
		{
			QuestNewController.CreateInstance();
		}
		return QuestNewController._Instance;
	}

	// Token: 0x0601154D RID: 70989 RVA: 0x0051A2D1 File Offset: 0x005184D1
	public static bool CreateInstance()
	{
		if (QuestNewController._Instance != null)
		{
			return true;
		}
		QuestNewController._Instance = new QuestNewController();
		return true;
	}

	// Token: 0x0601154E RID: 70990 RVA: 0x0051A2E7 File Offset: 0x005184E7
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601154F RID: 70991 RVA: 0x0051A2E9 File Offset: 0x005184E9
	public static void ResetStaticDefaultValue()
	{
		QuestNewController._Instance = null;
	}

	// Token: 0x06011550 RID: 70992 RVA: 0x0051A2F1 File Offset: 0x005184F1
	static QuestNewController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(QuestNewController.CreateStaticDefaultValue), new Action(QuestNewController.ResetStaticDefaultValue));
	}

	// Token: 0x0400984E RID: 38990
	private readonly float ShowQuestRangeFailWarningTime = 300f;

	// Token: 0x04009852 RID: 38994
	[Nullable(1)]
	private const string TIPS_NAME = "QuestRangeFailWarning";

	// Token: 0x04009853 RID: 38995
	private static QuestNewController _Instance;

	// Token: 0x02007E10 RID: 32272
	[NullableContext(0)]
	private enum EAssistantType
	{
		// Token: 0x04028CFD RID: 167165
		GuideLine,
		// Token: 0x04028CFE RID: 167166
		Track,
		// Token: 0x04028CFF RID: 167167
		GuideEffect,
		// Token: 0x04028D00 RID: 167168
		DailyQuest
	}
}
