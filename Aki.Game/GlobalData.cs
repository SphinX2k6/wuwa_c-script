using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core;
using AkiClient.Game.Aki.Core.Fight.Manager;
using AkiClient.Game.Aki.UI.Manager;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Launcher.Platform;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x02000DDE RID: 3550
[NullableContext(2)]
[Nullable(0)]
public class GlobalData : IStaticVariableResetter
{
	// Token: 0x06005525 RID: 21797 RVA: 0x000F588A File Offset: 0x000F3A8A
	static GlobalData()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GlobalData.CreateStaticDefaultValue), new Action(GlobalData.ResetStaticDefaultValue));
	}

	// Token: 0x06005526 RID: 21798 RVA: 0x000F58A9 File Offset: 0x000F3AA9
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06005527 RID: 21799 RVA: 0x000F58AB File Offset: 0x000F3AAB
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

	// Token: 0x06005528 RID: 21800 RVA: 0x000F58E7 File Offset: 0x000F3AE7
	private GlobalData()
	{
	}

	// Token: 0x06005529 RID: 21801 RVA: 0x000F58EF File Offset: 0x000F3AEF
	[NullableContext(1)]
	public static void Init(UGameInstance gameInstance)
	{
		GlobalData.GameInstanceInternal = (BP_MainGameInstance_C)gameInstance;
		GlobalData.IsEditor = UKuroStaticLibrary.IsEditor(gameInstance.GetWorld());
		GlobalData.BpEventManagerInternal = new BP_EventManager_C(gameInstance, null, EObjectFlags.RF_NoFlags);
		GlobalData.BpFightManagerInternal = new BP_FightManager_C(gameInstance, null, EObjectFlags.RF_NoFlags);
	}

	// Token: 0x0600552A RID: 21802 RVA: 0x000F5926 File Offset: 0x000F3B26
	public static void SetUiState(EKuroUI3DState state)
	{
		if (GlobalData.UiSceneState != state)
		{
			GlobalData.UiSceneState = state;
			EventSystem.Instance.Emit<EKuroUI3DState>(EEventName.OnGlobalUiSceneStateChanged, state);
		}
	}

	// Token: 0x170005F1 RID: 1521
	// (get) Token: 0x0600552B RID: 21803 RVA: 0x000F5947 File Offset: 0x000F3B47
	public static bool IsUiSceneLoading
	{
		get
		{
			return GlobalData.UiSceneState == EKuroUI3DState.Loading;
		}
	}

	// Token: 0x170005F2 RID: 1522
	// (get) Token: 0x0600552C RID: 21804 RVA: 0x000F5951 File Offset: 0x000F3B51
	public static bool IsUiSceneOpen
	{
		get
		{
			return GlobalData.UiSceneState == EKuroUI3DState.Loaded;
		}
	}

	// Token: 0x170005F3 RID: 1523
	// (get) Token: 0x0600552D RID: 21805 RVA: 0x000F595B File Offset: 0x000F3B5B
	public static bool IsPlayInEditor
	{
		get
		{
			return GlobalData.IsEditor;
		}
	}

	// Token: 0x170005F4 RID: 1524
	// (get) Token: 0x0600552E RID: 21806 RVA: 0x000F5962 File Offset: 0x000F3B62
	public static BP_MainGameInstance_C GameInstance
	{
		get
		{
			return GlobalData.GameInstanceInternal;
		}
	}

	// Token: 0x170005F5 RID: 1525
	// (get) Token: 0x0600552F RID: 21807 RVA: 0x000F5969 File Offset: 0x000F3B69
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

	// Token: 0x170005F6 RID: 1526
	// (get) Token: 0x06005530 RID: 21808 RVA: 0x000F597B File Offset: 0x000F3B7B
	[Nullable(1)]
	public static BP_EventManager_C BpEventManager
	{
		[NullableContext(1)]
		get
		{
			return GlobalData.BpEventManagerInternal;
		}
	}

	// Token: 0x170005F7 RID: 1527
	// (get) Token: 0x06005531 RID: 21809 RVA: 0x000F5982 File Offset: 0x000F3B82
	[Nullable(1)]
	public static BP_FightManager_C BpFightManager
	{
		[NullableContext(1)]
		get
		{
			return GlobalData.BpFightManagerInternal;
		}
	}

	// Token: 0x170005F8 RID: 1528
	// (get) Token: 0x06005532 RID: 21810 RVA: 0x000F5989 File Offset: 0x000F3B89
	public static bool IsEs3
	{
		get
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.GetWorldFeatureLevel(GlobalData.World) == KuroFeatureLevel.ES3_1;
		}
	}

	// Token: 0x170005F9 RID: 1529
	// (get) Token: 0x06005533 RID: 21811 RVA: 0x000F5998 File Offset: 0x000F3B98
	public static bool IsSm5
	{
		get
		{
			return UKuroRenderingRuntimeBPPluginBPLibrary.GetWorldFeatureLevel(GlobalData.World) == KuroFeatureLevel.SM5;
		}
	}

	// Token: 0x06005534 RID: 21812 RVA: 0x000F59A7 File Offset: 0x000F3BA7
	public static bool Networking()
	{
		if (GlobalData.NetworkState != null)
		{
			return GlobalData.NetworkState.Value;
		}
		GlobalData.NetworkState = new bool?(AActor.GetKuroNetMode() == EKuroNetMode.KNM_Net);
		return GlobalData.NetworkState.Value;
	}

	// Token: 0x06005535 RID: 21813 RVA: 0x000F59E4 File Offset: 0x000F3BE4
	public static bool IsRunWithEditorStartConfig()
	{
		if (GlobalData.IsRunWithEditorConfig != null)
		{
			return GlobalData.IsRunWithEditorConfig.Value;
		}
		if (!GlobalData.IsPlayInEditor && !Info.Instance.IsBuildShipping && Platform.Instance.IsWindowsPlatform())
		{
			string inPath = UBlueprintPathsLibrary.ProjectDir() + "../Config/Raw/Tables/k.可视化编辑/__Temp__/EditorStartConfig.json";
			string commandLine = UKismetSystemLibrary.GetCommandLine();
			GlobalData.IsRunWithEditorConfig = new bool?((commandLine.IndexOf("-StartWithEditorConfig") >= 0 || commandLine.IndexOf("-SessionName=\"Play in Standalone Game\"") >= 0) && UBlueprintPathsLibrary.FileExists(inPath));
		}
		else
		{
			GlobalData.IsRunWithEditorConfig = new bool?(false);
		}
		return GlobalData.IsRunWithEditorConfig.Value;
	}

	// Token: 0x170005FA RID: 1530
	// (get) Token: 0x06005536 RID: 21814 RVA: 0x000F5A83 File Offset: 0x000F3C83
	public static bool IsSceneClearing
	{
		get
		{
			return GlobalData.ClearSceneDone != null;
		}
	}

	// Token: 0x040026B6 RID: 9910
	private static bool IsEditor;

	// Token: 0x040026B7 RID: 9911
	private static EKuroUI3DState UiSceneState;

	// Token: 0x040026B8 RID: 9912
	private static BP_MainGameInstance_C GameInstanceInternal;

	// Token: 0x040026B9 RID: 9913
	private static BP_EventManager_C BpEventManagerInternal;

	// Token: 0x040026BA RID: 9914
	private static BP_FightManager_C BpFightManagerInternal;

	// Token: 0x040026BB RID: 9915
	private static bool? NetworkState;

	// Token: 0x040026BC RID: 9916
	private static bool? IsRunWithEditorConfig;

	// Token: 0x040026BD RID: 9917
	public static CustomPromise ClearSceneDone;
}
