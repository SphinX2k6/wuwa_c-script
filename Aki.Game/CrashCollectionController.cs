using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Typing;
using UnrealEngine;

// Token: 0x0200025F RID: 607
[NullableContext(1)]
[Nullable(0)]
[StaticVariableRuleIgnore]
public class CrashCollectionController : ControllerBase
{
	// Token: 0x060025C4 RID: 9668 RVA: 0x000E6720 File Offset: 0x000E4920
	[NullableContext(2)]
	private static Stat CreateOriginIsFightDebugStat()
	{
		return null;
	}

	// Token: 0x060025C5 RID: 9669 RVA: 0x000E6723 File Offset: 0x000E4923
	[NullableContext(2)]
	private static Stat CreateGameBudgetIsFightDebugStat()
	{
		return null;
	}

	// Token: 0x060025C6 RID: 9670 RVA: 0x000E6726 File Offset: 0x000E4926
	[NullableContext(2)]
	private static Stat CreateOriginIsCutsceneDebugStat()
	{
		return null;
	}

	// Token: 0x060025C7 RID: 9671 RVA: 0x000E6729 File Offset: 0x000E4929
	[NullableContext(2)]
	private static Stat CreateGameBudgetIsCutsceneDebugStat()
	{
		return null;
	}

	// Token: 0x060025C8 RID: 9672 RVA: 0x000E672C File Offset: 0x000E492C
	[NullableContext(2)]
	private static Stat CreateQualityLevelDebugStat(EGameQualitySettingLevel level)
	{
		return null;
	}

	// Token: 0x060025C9 RID: 9673 RVA: 0x000E672F File Offset: 0x000E492F
	[NullableContext(2)]
	private static Stat CreateLoadModeDebugStat()
	{
		return null;
	}

	// Token: 0x060025CA RID: 9674 RVA: 0x000E6734 File Offset: 0x000E4934
	protected override bool OnInit()
	{
		CrashCollectionController.OnAddEvents();
		FKuroCrashCollectionController.Initialize(GlobalData.World, new FName("ActorLocation"), new FName("ActorRotation"), new FName("CameraLocation"), new FName("CameraRotation"), new FName("World"));
		return base.OnInit();
	}

	// Token: 0x060025CB RID: 9675 RVA: 0x000E6788 File Offset: 0x000E4988
	protected override bool OnClear()
	{
		CrashCollectionController.OnRemoveEvents();
		return base.OnClear();
	}

	// Token: 0x060025CC RID: 9676 RVA: 0x000E6798 File Offset: 0x000E4998
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

	// Token: 0x060025CD RID: 9677 RVA: 0x000E6928 File Offset: 0x000E4B28
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

	// Token: 0x060025CE RID: 9678 RVA: 0x000E6AB5 File Offset: 0x000E4CB5
	protected override void OnTick(float delta)
	{
		CrashCollectionController.GatherCrashInfo();
	}

	// Token: 0x060025CF RID: 9679 RVA: 0x000E6ABC File Offset: 0x000E4CBC
	private static void OnTodTimeChange()
	{
		CrashCollectionController.GatherTODInfo();
	}

	// Token: 0x060025D0 RID: 9680 RVA: 0x000E6AC3 File Offset: 0x000E4CC3
	private static void GatherCrashInfo()
	{
		CrashCollectionController.CreateOriginIsFightDebugStat();
		CrashCollectionController.CreateGameBudgetIsFightDebugStat();
		CrashCollectionController.CreateOriginIsCutsceneDebugStat();
		CrashCollectionController.CreateGameBudgetIsCutsceneDebugStat();
		CrashCollectionController.CreateLoadModeDebugStat();
	}

	// Token: 0x060025D1 RID: 9681 RVA: 0x000E6AE4 File Offset: 0x000E4CE4
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

	// Token: 0x060025D2 RID: 9682 RVA: 0x000E6B14 File Offset: 0x000E4D14
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

	// Token: 0x060025D3 RID: 9683 RVA: 0x000E6B64 File Offset: 0x000E4D64
	private static void GatherRayTracing(int rayTracing)
	{
		Log.Instance.Info(ELogModule.Game, ELogAuthor.WLJ, "CrashSight GatherRayTracing", default(ReadOnlySpan<ValueTuple<string, object>>));
		FCrashSightProxy.SetCustomData(CrashCollectionController.RayTracingName, rayTracing.ToString());
	}

	// Token: 0x060025D4 RID: 9684 RVA: 0x000E6BA0 File Offset: 0x000E4DA0
	private static void GatherDlssFg(int dlssFg)
	{
		Log.Instance.Info(ELogModule.Game, ELogAuthor.WLJ, "CrashSight GatherDlssFg", default(ReadOnlySpan<ValueTuple<string, object>>));
		FCrashSightProxy.SetCustomData(CrashCollectionController.DlssFgName, dlssFg.ToString());
	}

	// Token: 0x060025D5 RID: 9685 RVA: 0x000E6BDC File Offset: 0x000E4DDC
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

	// Token: 0x060025D6 RID: 9686 RVA: 0x000E6C2B File Offset: 0x000E4E2B
	private static void OnChangeRole(EntityHandle newEntity, EntityHandle oldEntity)
	{
		SceneTeamModel.Instance.GetCurrentEntity.Entity.GetComponent<CharacterActorComponent>();
	}

	// Token: 0x060025D7 RID: 9687 RVA: 0x000E6C44 File Offset: 0x000E4E44
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

	// Token: 0x060025D8 RID: 9688 RVA: 0x000E6CAC File Offset: 0x000E4EAC
	private static void CollectionQuest()
	{
		FCrashSightProxy.SetCustomDataByFName(CrashCollectionController.QuestIdsName, string.Join<int>(", ", CrashCollectionController.ProcessingQuestIds));
	}

	// Token: 0x060025D9 RID: 9689 RVA: 0x000E6CC7 File Offset: 0x000E4EC7
	private static void OnLoginSuccess(string account)
	{
		CrashCollectionController.GatherGateWayInfo();
	}

	// Token: 0x060025DA RID: 9690 RVA: 0x000E6CCE File Offset: 0x000E4ECE
	private static void ReConnectSuccess()
	{
		CrashCollectionController.GatherGateWayInfo();
	}

	// Token: 0x060025DB RID: 9691 RVA: 0x000E6CD8 File Offset: 0x000E4ED8
	private static void GatherGateWayInfo()
	{
		string reconnectHost = LoginModel.Instance.GetReconnectHost();
		int? reconnectPort = LoginModel.Instance.GetReconnectPort();
		string str = reconnectHost;
		string str2 = ":";
		int? num = reconnectPort;
		FCrashSightProxy.SetCustomDataByFName(CrashCollectionController.GateWayName, str + str2 + num.ToString());
	}

	// Token: 0x060025DC RID: 9692 RVA: 0x000E6D1F File Offset: 0x000E4F1F
	public static void RecordHttpInfo(string info)
	{
		FCrashSightProxy.SetCustomDataByFName(CrashCollectionController.HttpInfoName, info);
	}

	// Token: 0x170005C2 RID: 1474
	// (get) Token: 0x060025DD RID: 9693 RVA: 0x000E6D2C File Offset: 0x000E4F2C
	public static CrashCollectionController Instance
	{
		get
		{
			return CrashCollectionController._Instance;
		}
	}

	// Token: 0x060025DE RID: 9694 RVA: 0x000E6D33 File Offset: 0x000E4F33
	public static CrashCollectionController GetOrCreateInstance()
	{
		if (CrashCollectionController._Instance == null)
		{
			CrashCollectionController.CreateInstance();
		}
		return CrashCollectionController._Instance;
	}

	// Token: 0x060025DF RID: 9695 RVA: 0x000E6D47 File Offset: 0x000E4F47
	public static bool CreateInstance()
	{
		if (CrashCollectionController._Instance != null)
		{
			return true;
		}
		CrashCollectionController._Instance = new CrashCollectionController();
		return true;
	}

	// Token: 0x060025E0 RID: 9696 RVA: 0x000E6D5D File Offset: 0x000E4F5D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060025E1 RID: 9697 RVA: 0x000E6D5F File Offset: 0x000E4F5F
	public static void ResetStaticDefaultValue()
	{
		CrashCollectionController._Instance = null;
	}

	// Token: 0x060025E2 RID: 9698 RVA: 0x000E6D68 File Offset: 0x000E4F68
	static CrashCollectionController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CrashCollectionController.CreateStaticDefaultValue), new Action(CrashCollectionController.ResetStaticDefaultValue));
	}

	// Token: 0x0400247E RID: 9342
	private static readonly Stat Stat = Stat.Create("CrashCollectionController.GatherCrashInfo", "", "");

	// Token: 0x0400247F RID: 9343
	private static readonly Stat QualityStat = Stat.Create("CrashCollectionController.GatherQualityLevel", "", "");

	// Token: 0x04002480 RID: 9344
	private static readonly Stat QuestStat = Stat.Create("CrashCollectionController.GatherQuestInfo", "", "");

	// Token: 0x04002481 RID: 9345
	private static readonly Stat TodStat = Stat.Create("CrashCollectionController.GatherTODInfo", "", "");

	// Token: 0x04002482 RID: 9346
	private static readonly Stat GateWayStat = Stat.Create("CrashCollectionController.GatherGateWayInfo", "", "");

	// Token: 0x04002483 RID: 9347
	private static readonly Stat HttpInfoStat = Stat.Create("CrashCollectionController.RecordHttpInfo", "", "");

	// Token: 0x04002484 RID: 9348
	private static readonly FName TODTimeName = FNameUtil.GetCheckDynamicFName("TODTime");

	// Token: 0x04002485 RID: 9349
	private static readonly FName QualityLevelName = FNameUtil.GetCheckDynamicFName("QualityLevel");

	// Token: 0x04002486 RID: 9350
	private static readonly string RayTracingName = "RayTracing";

	// Token: 0x04002487 RID: 9351
	private static readonly string DlssFgName = "DlssFG";

	// Token: 0x04002488 RID: 9352
	private static readonly FName QuestIdsName = FNameUtil.GetCheckDynamicFName("QuestIds");

	// Token: 0x04002489 RID: 9353
	private static readonly FName GateWayName = FNameUtil.GetCheckDynamicFName("GateWay");

	// Token: 0x0400248A RID: 9354
	private static readonly FName HttpInfoName = FNameUtil.GetCheckDynamicFName("HttpInfo");

	// Token: 0x0400248B RID: 9355
	private static readonly Stat IsOriginFightTrueDebugStat = Stat.Create("Origin IsFight: True", "", "");

	// Token: 0x0400248C RID: 9356
	private static readonly Stat IsOriginFightFalseDebugStat = Stat.Create("Origin IsFight: False", "", "");

	// Token: 0x0400248D RID: 9357
	private static readonly Stat IsOriginCutsceneTrueDebugStat = Stat.Create("Origin IsCutscene: True", "", "");

	// Token: 0x0400248E RID: 9358
	private static readonly Stat IsOriginCutsceneFalseDebugStat = Stat.Create("Origin IsCutscene: False", "", "");

	// Token: 0x0400248F RID: 9359
	private static readonly Stat IsGameBudgetFightTrueDebugStat = Stat.Create("GameBudget IsFight: True", "", "");

	// Token: 0x04002490 RID: 9360
	private static readonly Stat IsGameBudgetFightFalseDebugStat = Stat.Create("GameBudget IsFight: False", "", "");

	// Token: 0x04002491 RID: 9361
	private static readonly Stat IsGameBudgetCutsceneTrueDebugStat = Stat.Create("GameBudget IsCutscene: True", "", "");

	// Token: 0x04002492 RID: 9362
	private static readonly Stat IsGameBudgetCutsceneFalseDebugStat = Stat.Create("GameBudget IsCutscene: False", "", "");

	// Token: 0x04002493 RID: 9363
	private static readonly Stat LoadModeInGameDebugStat = Stat.Create("LoadModel: InGame", "", "");

	// Token: 0x04002494 RID: 9364
	private static readonly Stat LoadModeInLoadingDebugStat = Stat.Create("LoadModel: InLoading", "", "");

	// Token: 0x04002495 RID: 9365
	private static readonly List<int> ProcessingQuestIds = new List<int>();

	// Token: 0x04002496 RID: 9366
	[Nullable(2)]
	private static CrashCollectionController _Instance;

	// Token: 0x020065E2 RID: 26082
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04021B7D RID: 138109
		[Nullable(0)]
		public static Action <0>__OnTodTimeChange;

		// Token: 0x04021B7E RID: 138110
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Action<string> <1>__OnLoginSuccess;

		// Token: 0x04021B7F RID: 138111
		[Nullable(0)]
		public static Action <2>__ReConnectSuccess;

		// Token: 0x04021B80 RID: 138112
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Action<TQuest> <3>__OnAddNewQuest;

		// Token: 0x04021B81 RID: 138113
		[Nullable(0)]
		public static Action<int, QuestState, EQuestStatusUpdateReason> <4>__OnQuestStateChange;

		// Token: 0x04021B82 RID: 138114
		[Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public static Action<EntityHandle, EntityHandle> <5>__OnChangeRole;

		// Token: 0x04021B83 RID: 138115
		[Nullable(0)]
		public static Action<int> <6>__GatherQualityLevel;

		// Token: 0x04021B84 RID: 138116
		[Nullable(0)]
		public static Action<int> <7>__GatherRayTracing;

		// Token: 0x04021B85 RID: 138117
		[Nullable(0)]
		public static Action<int> <8>__GatherDlssFg;
	}
}
