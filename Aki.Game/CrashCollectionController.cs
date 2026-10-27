using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Typing;
using UnrealEngine;

// Token: 0x0200025B RID: 603
[NullableContext(1)]
[Nullable(0)]
[StaticVariableRuleIgnore]
public class CrashCollectionController : ControllerBase
{
	// Token: 0x0600250D RID: 9485 RVA: 0x000E02E4 File Offset: 0x000DE4E4
	[NullableContext(2)]
	private static Stat CreateOriginIsFightDebugStat()
	{
		if (!Stat.Enable)
		{
			return null;
		}
		if (!FormationDataController.Instance.GlobalIsInFight)
		{
			return CrashCollectionController.IsOriginFightFalseDebugStat;
		}
		return CrashCollectionController.IsOriginFightTrueDebugStat;
	}

	// Token: 0x0600250E RID: 9486 RVA: 0x000E0306 File Offset: 0x000DE506
	[NullableContext(2)]
	private static Stat CreateGameBudgetIsFightDebugStat()
	{
		if (!Stat.Enable)
		{
			return null;
		}
		if (!GameBudgetInterfaceController.Instance.IsInFight)
		{
			return CrashCollectionController.IsGameBudgetFightFalseDebugStat;
		}
		return CrashCollectionController.IsGameBudgetFightTrueDebugStat;
	}

	// Token: 0x0600250F RID: 9487 RVA: 0x000E0328 File Offset: 0x000DE528
	[NullableContext(2)]
	private static Stat CreateOriginIsCutsceneDebugStat()
	{
		if (!Stat.Enable)
		{
			return null;
		}
		if (!PlotModel.Instance.IsInPlot)
		{
			return CrashCollectionController.IsOriginCutsceneFalseDebugStat;
		}
		return CrashCollectionController.IsOriginCutsceneTrueDebugStat;
	}

	// Token: 0x06002510 RID: 9488 RVA: 0x000E034A File Offset: 0x000DE54A
	[NullableContext(2)]
	private static Stat CreateGameBudgetIsCutsceneDebugStat()
	{
		if (!Stat.Enable)
		{
			return null;
		}
		if (!GameBudgetInterfaceController.Instance.IsInPlot)
		{
			return CrashCollectionController.IsGameBudgetCutsceneFalseDebugStat;
		}
		return CrashCollectionController.IsGameBudgetCutsceneTrueDebugStat;
	}

	// Token: 0x06002511 RID: 9489 RVA: 0x000E036C File Offset: 0x000DE56C
	[NullableContext(2)]
	private static Stat CreateQualityLevelDebugStat(EGameQualitySettingLevel level)
	{
		bool enable = Stat.Enable;
		return null;
	}

	// Token: 0x06002512 RID: 9490 RVA: 0x000E0375 File Offset: 0x000DE575
	[NullableContext(2)]
	private static Stat CreateLoadModeDebugStat()
	{
		if (!Stat.Enable)
		{
			return null;
		}
		if (!LoadModeManager.Instance.IsLoadModeInGameOrForceInGame())
		{
			return CrashCollectionController.LoadModeInLoadingDebugStat;
		}
		return CrashCollectionController.LoadModeInGameDebugStat;
	}

	// Token: 0x06002513 RID: 9491 RVA: 0x000E0398 File Offset: 0x000DE598
	protected override bool OnInit()
	{
		CrashCollectionController.OnAddEvents();
		FKuroCrashCollectionController.Initialize(GlobalData.World, new FName("ActorLocation"), new FName("ActorRotation"), new FName("CameraLocation"), new FName("CameraRotation"), new FName("World"));
		return base.OnInit();
	}

	// Token: 0x06002514 RID: 9492 RVA: 0x000E03EC File Offset: 0x000DE5EC
	protected override bool OnClear()
	{
		CrashCollectionController.OnRemoveEvents();
		return base.OnClear();
	}

	// Token: 0x06002515 RID: 9493 RVA: 0x000E03FC File Offset: 0x000DE5FC
	private static void OnAddEvents()
	{
		EventSystem instance = EventSystem.Instance;
		EEventName name = EEventName.TodTimeChange;
		Action handle;
		if ((handle = CrashCollectionController.<>O.<0>__OnTodTimeChange) == null)
		{
			handle = (CrashCollectionController.<>O.<0>__OnTodTimeChange = new Action(CrashCollectionController.OnTodTimeChange));
		}
		instance.Add(name, handle);
		EventSystem instance2 = EventSystem.Instance;
		EEventName name2 = EEventName.LoginSuccess;
		Action<string> handle2;
		if ((handle2 = CrashCollectionController.<>O.<1>__OnLoginSuccess) == null)
		{
			handle2 = (CrashCollectionController.<>O.<1>__OnLoginSuccess = new Action<string>(CrashCollectionController.OnLoginSuccess));
		}
		instance2.Add(name2, handle2);
		EventSystem instance3 = EventSystem.Instance;
		EEventName name3 = EEventName.ReConnectSuccess;
		Action handle3;
		if ((handle3 = CrashCollectionController.<>O.<2>__ReConnectSuccess) == null)
		{
			handle3 = (CrashCollectionController.<>O.<2>__ReConnectSuccess = new Action(CrashCollectionController.ReConnectSuccess));
		}
		instance3.Add(name3, handle3);
		EventSystem instance4 = EventSystem.Instance;
		EEventName name4 = EEventName.OnAddNewQuest;
		Action<TQuest> handle4;
		if ((handle4 = CrashCollectionController.<>O.<3>__OnAddNewQuest) == null)
		{
			handle4 = (CrashCollectionController.<>O.<3>__OnAddNewQuest = new Action<TQuest>(CrashCollectionController.OnAddNewQuest));
		}
		instance4.Add(name4, handle4);
		EventSystem instance5 = EventSystem.Instance;
		EEventName name5 = EEventName.OnQuestStateChange;
		Action<int, QuestState, EQuestStatusUpdateReason> handle5;
		if ((handle5 = CrashCollectionController.<>O.<4>__OnQuestStateChange) == null)
		{
			handle5 = (CrashCollectionController.<>O.<4>__OnQuestStateChange = new Action<int, QuestState, EQuestStatusUpdateReason>(CrashCollectionController.OnQuestStateChange));
		}
		instance5.Add(name5, handle5);
		EventSystem instance6 = EventSystem.Instance;
		EEventName name6 = EEventName.OnChangeRole;
		Action<EntityHandle, EntityHandle> handle6;
		if ((handle6 = CrashCollectionController.<>O.<5>__OnChangeRole) == null)
		{
			handle6 = (CrashCollectionController.<>O.<5>__OnChangeRole = new Action<EntityHandle, EntityHandle>(CrashCollectionController.OnChangeRole));
		}
		instance6.Add(name6, handle6);
		EventSystem instance7 = EventSystem.Instance;
		EEventName name7 = EEventName.SetImageQualityWithValue;
		Action<int> handle7;
		if ((handle7 = CrashCollectionController.<>O.<6>__GatherQualityLevel) == null)
		{
			handle7 = (CrashCollectionController.<>O.<6>__GatherQualityLevel = new Action<int>(CrashCollectionController.GatherQualityLevel));
		}
		instance7.Add(name7, handle7);
		EventSystem instance8 = EventSystem.Instance;
		EEventName name8 = EEventName.SetRayTracingWithValue;
		Action<int> handle8;
		if ((handle8 = CrashCollectionController.<>O.<7>__GatherRayTracing) == null)
		{
			handle8 = (CrashCollectionController.<>O.<7>__GatherRayTracing = new Action<int>(CrashCollectionController.GatherRayTracing));
		}
		instance8.Add(name8, handle8);
		EventSystem instance9 = EventSystem.Instance;
		EEventName name9 = EEventName.SetDLSSFGWithValue;
		Action<int> handle9;
		if ((handle9 = CrashCollectionController.<>O.<8>__GatherDlssFg) == null)
		{
			handle9 = (CrashCollectionController.<>O.<8>__GatherDlssFg = new Action<int>(CrashCollectionController.GatherDlssFg));
		}
		instance9.Add(name9, handle9);
	}

	// Token: 0x06002516 RID: 9494 RVA: 0x000E058C File Offset: 0x000DE78C
	private static void OnRemoveEvents()
	{
		EventSystem instance = EventSystem.Instance;
		EEventName name = EEventName.TodTimeChange;
		Action handle;
		if ((handle = CrashCollectionController.<>O.<0>__OnTodTimeChange) == null)
		{
			handle = (CrashCollectionController.<>O.<0>__OnTodTimeChange = new Action(CrashCollectionController.OnTodTimeChange));
		}
		instance.Remove(name, handle);
		EventSystem instance2 = EventSystem.Instance;
		EEventName name2 = EEventName.LoginSuccess;
		Action<string> handle2;
		if ((handle2 = CrashCollectionController.<>O.<1>__OnLoginSuccess) == null)
		{
			handle2 = (CrashCollectionController.<>O.<1>__OnLoginSuccess = new Action<string>(CrashCollectionController.OnLoginSuccess));
		}
		instance2.Remove(name2, handle2);
		EventSystem instance3 = EventSystem.Instance;
		EEventName name3 = EEventName.ReConnectSuccess;
		Action handle3;
		if ((handle3 = CrashCollectionController.<>O.<2>__ReConnectSuccess) == null)
		{
			handle3 = (CrashCollectionController.<>O.<2>__ReConnectSuccess = new Action(CrashCollectionController.ReConnectSuccess));
		}
		instance3.Remove(name3, handle3);
		EventSystem instance4 = EventSystem.Instance;
		EEventName name4 = EEventName.OnAddNewQuest;
		Action<TQuest> handle4;
		if ((handle4 = CrashCollectionController.<>O.<3>__OnAddNewQuest) == null)
		{
			handle4 = (CrashCollectionController.<>O.<3>__OnAddNewQuest = new Action<TQuest>(CrashCollectionController.OnAddNewQuest));
		}
		instance4.Remove(name4, handle4);
		EventSystem instance5 = EventSystem.Instance;
		EEventName name5 = EEventName.OnQuestStateChange;
		Action<int, QuestState, EQuestStatusUpdateReason> handle5;
		if ((handle5 = CrashCollectionController.<>O.<4>__OnQuestStateChange) == null)
		{
			handle5 = (CrashCollectionController.<>O.<4>__OnQuestStateChange = new Action<int, QuestState, EQuestStatusUpdateReason>(CrashCollectionController.OnQuestStateChange));
		}
		instance5.Remove(name5, handle5);
		EventSystem instance6 = EventSystem.Instance;
		EEventName name6 = EEventName.OnChangeRole;
		Action<EntityHandle, EntityHandle> handle6;
		if ((handle6 = CrashCollectionController.<>O.<5>__OnChangeRole) == null)
		{
			handle6 = (CrashCollectionController.<>O.<5>__OnChangeRole = new Action<EntityHandle, EntityHandle>(CrashCollectionController.OnChangeRole));
		}
		instance6.Remove(name6, handle6);
		EventSystem instance7 = EventSystem.Instance;
		EEventName name7 = EEventName.SetImageQualityWithValue;
		Action<int> handle7;
		if ((handle7 = CrashCollectionController.<>O.<6>__GatherQualityLevel) == null)
		{
			handle7 = (CrashCollectionController.<>O.<6>__GatherQualityLevel = new Action<int>(CrashCollectionController.GatherQualityLevel));
		}
		instance7.Remove(name7, handle7);
		EventSystem instance8 = EventSystem.Instance;
		EEventName name8 = EEventName.SetRayTracingWithValue;
		Action<int> handle8;
		if ((handle8 = CrashCollectionController.<>O.<7>__GatherRayTracing) == null)
		{
			handle8 = (CrashCollectionController.<>O.<7>__GatherRayTracing = new Action<int>(CrashCollectionController.GatherRayTracing));
		}
		instance8.Remove(name8, handle8);
		EventSystem instance9 = EventSystem.Instance;
		EEventName name9 = EEventName.SetDLSSFGWithValue;
		Action<int> handle9;
		if ((handle9 = CrashCollectionController.<>O.<8>__GatherDlssFg) == null)
		{
			handle9 = (CrashCollectionController.<>O.<8>__GatherDlssFg = new Action<int>(CrashCollectionController.GatherDlssFg));
		}
		instance9.Remove(name9, handle9);
	}

	// Token: 0x06002517 RID: 9495 RVA: 0x000E0719 File Offset: 0x000DE919
	protected override void OnTick(float delta)
	{
		CrashCollectionController.GatherCrashInfo();
	}

	// Token: 0x06002518 RID: 9496 RVA: 0x000E0720 File Offset: 0x000DE920
	private static void OnTodTimeChange()
	{
		CrashCollectionController.GatherTODInfo();
	}

	// Token: 0x06002519 RID: 9497 RVA: 0x000E0727 File Offset: 0x000DE927
	private static void GatherCrashInfo()
	{
		CrashCollectionController.CreateOriginIsFightDebugStat();
		CrashCollectionController.CreateGameBudgetIsFightDebugStat();
		CrashCollectionController.CreateOriginIsCutsceneDebugStat();
		CrashCollectionController.CreateGameBudgetIsCutsceneDebugStat();
		CrashCollectionController.CreateLoadModeDebugStat();
	}

	// Token: 0x0600251A RID: 9498 RVA: 0x000E0748 File Offset: 0x000DE948
	private static void GatherTODInfo()
	{
		TimeOfDayModel instance = TimeOfDayModel.Instance;
		if (instance == null)
		{
			return;
		}
		string hourMinuteString = instance.GameTime.HourMinuteString;
		FCrashSightProxy.SetCustomDataByFName(CrashCollectionController.TODTimeName, hourMinuteString);
	}

	// Token: 0x0600251B RID: 9499 RVA: 0x000E0778 File Offset: 0x000DE978
	private static void GatherQualityLevel(int settingLevel)
	{
		EGameQualitySettingLevel gameQualitySettingLevel = GameSettingsDeviceRender.Instance.GameQualitySettingLevel;
		if (settingLevel != (int)gameQualitySettingLevel)
		{
			Log.Instance.Info(ELogModule.Game, ELogAuthor.WLJ, "CrashSight GatherQualityLevel", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		CrashCollectionController.CreateQualityLevelDebugStat(gameQualitySettingLevel);
		FCrashSightProxy.SetCustomDataByFName(CrashCollectionController.QualityLevelName, settingLevel.ToString());
	}

	// Token: 0x0600251C RID: 9500 RVA: 0x000E07C8 File Offset: 0x000DE9C8
	private static void GatherRayTracing(int rayTracing)
	{
		Log.Instance.Info(ELogModule.Game, ELogAuthor.WLJ, "CrashSight GatherRayTracing", default(ReadOnlySpan<ValueTuple<string, object>>));
		FCrashSightProxy.SetCustomData(CrashCollectionController.RayTracingName, rayTracing.ToString());
	}

	// Token: 0x0600251D RID: 9501 RVA: 0x000E0804 File Offset: 0x000DEA04
	private static void GatherDlssFg(int dlssFg)
	{
		Log.Instance.Info(ELogModule.Game, ELogAuthor.WLJ, "CrashSight GatherDlssFg", default(ReadOnlySpan<ValueTuple<string, object>>));
		FCrashSightProxy.SetCustomData(CrashCollectionController.DlssFgName, dlssFg.ToString());
	}

	// Token: 0x0600251E RID: 9502 RVA: 0x000E0840 File Offset: 0x000DEA40
	private static void OnAddNewQuest(TQuest tQuest)
	{
		global::Quest quest = (global::Quest)tQuest;
		if (quest.Type != EQuest.Main)
		{
			return;
		}
		if (!quest.IsProgressing)
		{
			return;
		}
		if (CrashCollectionController.ProcessingQuestIds.Contains(quest.Id))
		{
			return;
		}
		CrashCollectionController.ProcessingQuestIds.Add(quest.Id);
		CrashCollectionController.CollectionQuest();
	}

	// Token: 0x0600251F RID: 9503 RVA: 0x000E088F File Offset: 0x000DEA8F
	private static void OnChangeRole(EntityHandle newEntity, EntityHandle oldEntity)
	{
		SceneTeamModel.Instance.GetCurrentEntity.Entity.GetComponent<CharacterActorComponent>();
	}

	// Token: 0x06002520 RID: 9504 RVA: 0x000E08A8 File Offset: 0x000DEAA8
	private static void OnQuestStateChange(int questId, QuestState state, EQuestStatusUpdateReason reason)
	{
		global::Quest quest = QuestNewModel.Instance.GetQuest(questId);
		if (quest == null || quest.Type != EQuest.Main)
		{
			return;
		}
		if (state == QuestState.Progress)
		{
			if (!CrashCollectionController.ProcessingQuestIds.Contains(questId))
			{
				CrashCollectionController.ProcessingQuestIds.Add(questId);
				CrashCollectionController.CollectionQuest();
				return;
			}
		}
		else
		{
			int num = CrashCollectionController.ProcessingQuestIds.IndexOf(questId);
			if (num > -1)
			{
				CrashCollectionController.ProcessingQuestIds.RemoveAt(num);
				CrashCollectionController.CollectionQuest();
			}
		}
	}

	// Token: 0x06002521 RID: 9505 RVA: 0x000E0910 File Offset: 0x000DEB10
	private static void CollectionQuest()
	{
		FCrashSightProxy.SetCustomDataByFName(CrashCollectionController.QuestIdsName, string.Join<int>(", ", CrashCollectionController.ProcessingQuestIds));
	}

	// Token: 0x06002522 RID: 9506 RVA: 0x000E092B File Offset: 0x000DEB2B
	private static void OnLoginSuccess(string account)
	{
		CrashCollectionController.GatherGateWayInfo();
	}

	// Token: 0x06002523 RID: 9507 RVA: 0x000E0932 File Offset: 0x000DEB32
	private static void ReConnectSuccess()
	{
		CrashCollectionController.GatherGateWayInfo();
	}

	// Token: 0x06002524 RID: 9508 RVA: 0x000E093C File Offset: 0x000DEB3C
	private static void GatherGateWayInfo()
	{
		string reconnectHost = LoginModel.Instance.GetReconnectHost();
		int? reconnectPort = LoginModel.Instance.GetReconnectPort();
		string str = reconnectHost;
		string str2 = ":";
		int? num = reconnectPort;
		FCrashSightProxy.SetCustomDataByFName(CrashCollectionController.GateWayName, str + str2 + num.ToString());
	}

	// Token: 0x06002525 RID: 9509 RVA: 0x000E0983 File Offset: 0x000DEB83
	public static void RecordHttpInfo(string info)
	{
		FCrashSightProxy.SetCustomDataByFName(CrashCollectionController.HttpInfoName, info);
	}

	// Token: 0x1700059B RID: 1435
	// (get) Token: 0x06002526 RID: 9510 RVA: 0x000E0990 File Offset: 0x000DEB90
	public static CrashCollectionController Instance
	{
		get
		{
			return CrashCollectionController._Instance;
		}
	}

	// Token: 0x06002527 RID: 9511 RVA: 0x000E0997 File Offset: 0x000DEB97
	public static CrashCollectionController GetOrCreateInstance()
	{
		if (CrashCollectionController._Instance == null)
		{
			CrashCollectionController.CreateInstance();
		}
		return CrashCollectionController._Instance;
	}

	// Token: 0x06002528 RID: 9512 RVA: 0x000E09AB File Offset: 0x000DEBAB
	public static bool CreateInstance()
	{
		if (CrashCollectionController._Instance != null)
		{
			return true;
		}
		CrashCollectionController._Instance = new CrashCollectionController();
		return true;
	}

	// Token: 0x06002529 RID: 9513 RVA: 0x000E09C1 File Offset: 0x000DEBC1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600252A RID: 9514 RVA: 0x000E09C3 File Offset: 0x000DEBC3
	public static void ResetStaticDefaultValue()
	{
		CrashCollectionController._Instance = null;
	}

	// Token: 0x0600252B RID: 9515 RVA: 0x000E09CC File Offset: 0x000DEBCC
	static CrashCollectionController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CrashCollectionController.CreateStaticDefaultValue), new Action(CrashCollectionController.ResetStaticDefaultValue));
	}

	// Token: 0x04002400 RID: 9216
	private static readonly Stat Stat = Stat.Create("CrashCollectionController.GatherCrashInfo", "", "");

	// Token: 0x04002401 RID: 9217
	private static readonly Stat QualityStat = Stat.Create("CrashCollectionController.GatherQualityLevel", "", "");

	// Token: 0x04002402 RID: 9218
	private static readonly Stat QuestStat = Stat.Create("CrashCollectionController.GatherQuestInfo", "", "");

	// Token: 0x04002403 RID: 9219
	private static readonly Stat TodStat = Stat.Create("CrashCollectionController.GatherTODInfo", "", "");

	// Token: 0x04002404 RID: 9220
	private static readonly Stat GateWayStat = Stat.Create("CrashCollectionController.GatherGateWayInfo", "", "");

	// Token: 0x04002405 RID: 9221
	private static readonly Stat HttpInfoStat = Stat.Create("CrashCollectionController.RecordHttpInfo", "", "");

	// Token: 0x04002406 RID: 9222
	private static readonly FName TODTimeName = FNameUtil.GetCheckDynamicFName("TODTime");

	// Token: 0x04002407 RID: 9223
	private static readonly FName QualityLevelName = FNameUtil.GetCheckDynamicFName("QualityLevel");

	// Token: 0x04002408 RID: 9224
	private static readonly string RayTracingName = "RayTracing";

	// Token: 0x04002409 RID: 9225
	private static readonly string DlssFgName = "DlssFG";

	// Token: 0x0400240A RID: 9226
	private static readonly FName QuestIdsName = FNameUtil.GetCheckDynamicFName("QuestIds");

	// Token: 0x0400240B RID: 9227
	private static readonly FName GateWayName = FNameUtil.GetCheckDynamicFName("GateWay");

	// Token: 0x0400240C RID: 9228
	private static readonly FName HttpInfoName = FNameUtil.GetCheckDynamicFName("HttpInfo");

	// Token: 0x0400240D RID: 9229
	private static readonly Stat IsOriginFightTrueDebugStat = Stat.Create("Origin IsFight: True", "", "");

	// Token: 0x0400240E RID: 9230
	private static readonly Stat IsOriginFightFalseDebugStat = Stat.Create("Origin IsFight: False", "", "");

	// Token: 0x0400240F RID: 9231
	private static readonly Stat IsOriginCutsceneTrueDebugStat = Stat.Create("Origin IsCutscene: True", "", "");

	// Token: 0x04002410 RID: 9232
	private static readonly Stat IsOriginCutsceneFalseDebugStat = Stat.Create("Origin IsCutscene: False", "", "");

	// Token: 0x04002411 RID: 9233
	private static readonly Stat IsGameBudgetFightTrueDebugStat = Stat.Create("GameBudget IsFight: True", "", "");

	// Token: 0x04002412 RID: 9234
	private static readonly Stat IsGameBudgetFightFalseDebugStat = Stat.Create("GameBudget IsFight: False", "", "");

	// Token: 0x04002413 RID: 9235
	private static readonly Stat IsGameBudgetCutsceneTrueDebugStat = Stat.Create("GameBudget IsCutscene: True", "", "");

	// Token: 0x04002414 RID: 9236
	private static readonly Stat IsGameBudgetCutsceneFalseDebugStat = Stat.Create("GameBudget IsCutscene: False", "", "");

	// Token: 0x04002415 RID: 9237
	private static readonly Stat LoadModeInGameDebugStat = Stat.Create("LoadModel: InGame", "", "");

	// Token: 0x04002416 RID: 9238
	private static readonly Stat LoadModeInLoadingDebugStat = Stat.Create("LoadModel: InLoading", "", "");

	// Token: 0x04002417 RID: 9239
	private static readonly List<int> ProcessingQuestIds = new List<int>();

	// Token: 0x04002418 RID: 9240
	[Nullable(2)]
	private static CrashCollectionController _Instance;

	// Token: 0x02007451 RID: 29777
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402683F RID: 157759
		[Nullable(0)]
		public static Action <0>__OnTodTimeChange;

		// Token: 0x04026840 RID: 157760
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Action<string> <1>__OnLoginSuccess;

		// Token: 0x04026841 RID: 157761
		[Nullable(0)]
		public static Action <2>__ReConnectSuccess;

		// Token: 0x04026842 RID: 157762
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Action<TQuest> <3>__OnAddNewQuest;

		// Token: 0x04026843 RID: 157763
		[Nullable(0)]
		public static Action<int, QuestState, EQuestStatusUpdateReason> <4>__OnQuestStateChange;

		// Token: 0x04026844 RID: 157764
		[Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public static Action<EntityHandle, EntityHandle> <5>__OnChangeRole;

		// Token: 0x04026845 RID: 157765
		[Nullable(0)]
		public static Action<int> <6>__GatherQualityLevel;

		// Token: 0x04026846 RID: 157766
		[Nullable(0)]
		public static Action<int> <7>__GatherRayTracing;

		// Token: 0x04026847 RID: 157767
		[Nullable(0)]
		public static Action<int> <8>__GatherDlssFg;
	}
}
