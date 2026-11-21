using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core;
using AkiClient.Game.Aki.Core.Fight.Manager;
using AkiClient.Game.Aki.UI.Manager;
using CSharpScript.Game.Common.Event;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x02000290 RID: 656
[NullableContext(2)]
[Nullable(0)]
public class GlobalData : IStaticVariableResetter
{
	// Token: 0x060028AF RID: 10415 RVA: 0x000FCDE2 File Offset: 0x000FAFE2
	static GlobalData()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GlobalData.CreateStaticDefaultValue), new Action(GlobalData.ResetStaticDefaultValue));
	}

	// Token: 0x060028B0 RID: 10416 RVA: 0x000FCE01 File Offset: 0x000FB001
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060028B1 RID: 10417 RVA: 0x000FCE03 File Offset: 0x000FB003
	public static void ResetStaticDefaultValue()
	{
		GlobalData.UiSceneState = EKuroUI3DState.NotLoaded;
		GlobalData.IsEditor = false;
		GlobalData.GameInstanceInternal = null;
		GlobalData.BpEventManagerInternal = null;
		GlobalData.BpFightManagerInternal = null;
		GlobalData.NetworkState = null;
		GlobalData.IsRunWithEditorConfig = null;
		GlobalData.ClearSceneDone = null;
	}

	// Token: 0x060028B2 RID: 10418 RVA: 0x000FCE3F File Offset: 0x000FB03F
	private GlobalData()
	{
	}

	// Token: 0x060028B3 RID: 10419 RVA: 0x000FCE47 File Offset: 0x000FB047
	[NullableContext(1)]
	public static void Init(UGameInstance gameInstance)
	{
		GlobalData.GameInstanceInternal = (BP_MainGameInstance_C)gameInstance;
		GlobalData.IsEditor = UKuroStaticLibrary.IsEditor(gameInstance.GetWorld());
		GlobalData.BpEventManagerInternal = new BP_EventManager_C(gameInstance, null, EObjectFlags.RF_NoFlags);
		GlobalData.BpFightManagerInternal = new BP_FightManager_C(gameInstance, null, EObjectFlags.RF_NoFlags);
	}

	// Token: 0x060028B4 RID: 10420 RVA: 0x000FCE7E File Offset: 0x000FB07E
	public static void SetUiState(EKuroUI3DState state)
	{
		if (GlobalData.UiSceneState != state)
		{
			GlobalData.UiSceneState = state;
			EventSystem.Instance.Emit<EKuroUI3DState>(EEventName.OnGlobalUiSceneStateChanged, state);
		}
	}

	// Token: 0x17000615 RID: 1557
	// (get) Token: 0x060028B5 RID: 10421 RVA: 0x000FCE9F File Offset: 0x000FB09F
	public static bool IsUiSceneLoading
	{
		get
		{
			return GlobalData.UiSceneState == EKuroUI3DState.Loading;
		}
	}

	// Token: 0x17000616 RID: 1558
	// (get) Token: 0x060028B6 RID: 10422 RVA: 0x000FCEA9 File Offset: 0x000FB0A9
	public static bool IsUiSceneOpen
	{
		get
		{
			return GlobalData.UiSceneState == EKuroUI3DState.Loaded;
		}
	}

	// Token: 0x17000617 RID: 1559
	// (get) Token: 0x060028B7 RID: 10423 RVA: 0x000FCEB3 File Offset: 0x000FB0B3
	public static bool IsPlayInEditor
	{
		get
		{
			return GlobalData.IsEditor;
		}
	}

	// Token: 0x17000618 RID: 1560
	// (get) Token: 0x060028B8 RID: 10424 RVA: 0x000FCEBA File Offset: 0x000FB0BA
	public static BP_MainGameInstance_C GameInstance
	{
		get
		{
			return GlobalData.GameInstanceInternal;
		}
	}

	// Token: 0x17000619 RID: 1561
	// (get) Token: 0x060028B9 RID: 10425 RVA: 0x000FCEC1 File Offset: 0x000FB0C1
	public static UWorld World
	{
		get
		{
			BP_MainGameInstance_C gameInstanceInternal = GlobalData.GameInstanceInternal;
			if (gameInstanceInternal == null)
			{
				return null;
			}
			return gameInstanceInternal.GetWorld();
		}
	}

	// Token: 0x1700061A RID: 1562
	// (get) Token: 0x060028BA RID: 10426 RVA: 0x000FCED3 File Offset: 0x000FB0D3
	[Nullable(1)]
	public static BP_EventManager_C BpEventManager
	{
		[NullableContext(1)]
		get
		{
			return GlobalData.BpEventManagerInternal;
		}
	}

	// Token: 0x1700061B RID: 1563
	// (get) Token: 0x060028BB RID: 10427 RVA: 0x000FCEDA File Offset: 0x000FB0DA
	[Nullable(1)]
	public static BP_FightManager_C BpFightManager
	{
		[NullableContext(1)]
		get
		{
			return GlobalData.BpFightManagerInternal;
		}
	}

	// Token: 0x1700061C RID: 1564
	// (get) Token: 0x060028BC RID: 10428 RVA: 0x000FCEE1 File Offset: 0x000FB0E1
	public static bool IsEs3
	{
		get
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.GetWorldFeatureLevel(GlobalData.World) == KuroFeatureLevel.ES3_1;
		}
	}

	// Token: 0x1700061D RID: 1565
	// (get) Token: 0x060028BD RID: 10429 RVA: 0x000FCEF0 File Offset: 0x000FB0F0
	public static bool IsSm5
	{
		get
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.GetWorldFeatureLevel(GlobalData.World) == KuroFeatureLevel.SM5;
		}
	}

	// Token: 0x060028BE RID: 10430 RVA: 0x000FCEFF File Offset: 0x000FB0FF
	public static bool Networking()
	{
		if (GlobalData.NetworkState != null)
		{
			return GlobalData.NetworkState.Value;
		}
		GlobalData.NetworkState = new bool?(AActor.GetKuroNetMode() == EKuroNetMode.KNM_Net);
		return GlobalData.NetworkState.Value;
	}

	// Token: 0x060028BF RID: 10431 RVA: 0x000FCF3C File Offset: 0x000FB13C
	public static bool IsRunWithEditorStartConfig()
	{
		if (GlobalData.IsRunWithEditorConfig != null)
		{
			return GlobalData.IsRunWithEditorConfig.Value;
		}
		bool isPlayInEditor = GlobalData.IsPlayInEditor;
		GlobalData.IsRunWithEditorConfig = new bool?(false);
		return GlobalData.IsRunWithEditorConfig.Value;
	}

	// Token: 0x1700061E RID: 1566
	// (get) Token: 0x060028C0 RID: 10432 RVA: 0x000FCF7B File Offset: 0x000FB17B
	public static bool IsSceneClearing
	{
		get
		{
			return GlobalData.ClearSceneDone != null;
		}
	}

	// Token: 0x0400273E RID: 10046
	private static bool IsEditor;

	// Token: 0x0400273F RID: 10047
	private static EKuroUI3DState UiSceneState;

	// Token: 0x04002740 RID: 10048
	private static BP_MainGameInstance_C GameInstanceInternal;

	// Token: 0x04002741 RID: 10049
	private static BP_EventManager_C BpEventManagerInternal;

	// Token: 0x04002742 RID: 10050
	private static BP_FightManager_C BpFightManagerInternal;

	// Token: 0x04002743 RID: 10051
	private static bool? NetworkState;

	// Token: 0x04002744 RID: 10052
	private static bool? IsRunWithEditorConfig;

	// Token: 0x04002745 RID: 10053
	public static CustomPromise ClearSceneDone;
}
