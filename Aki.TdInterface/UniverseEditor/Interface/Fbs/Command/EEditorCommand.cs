using System;

namespace Aki.UniverseEditor.Interface.Fbs.Command
{
	// Token: 0x02005EDE RID: 24286
	public enum EEditorCommand : byte
	{
		// Token: 0x0400F986 RID: 63878
		RpcResp,
		// Token: 0x0400F987 RID: 63879
		RestartEditor,
		// Token: 0x0400F988 RID: 63880
		SilentSaveAndRestart,
		// Token: 0x0400F989 RID: 63881
		ForceUpdateEditor,
		// Token: 0x0400F98A RID: 63882
		ShowEntityView,
		// Token: 0x0400F98B RID: 63883
		NavToEntity,
		// Token: 0x0400F98C RID: 63884
		AsyncCheckResult,
		// Token: 0x0400F98D RID: 63885
		P4UniversePorxyResponse,
		// Token: 0x0400F98E RID: 63886
		LoadUseCase,
		// Token: 0x0400F98F RID: 63887
		NavToQuest,
		// Token: 0x0400F990 RID: 63888
		NavToLevelPlay,
		// Token: 0x0400F991 RID: 63889
		NavToEntityTemplate,
		// Token: 0x0400F992 RID: 63890
		NavToEntityBundle,
		// Token: 0x0400F993 RID: 63891
		NavToFlowList,
		// Token: 0x0400F994 RID: 63892
		NavToBehaviorTreeFragment,
		// Token: 0x0400F995 RID: 63893
		NavToWorldEditor,
		// Token: 0x0400F996 RID: 63894
		DeliverLevelPlay,
		// Token: 0x0400F997 RID: 63895
		SetPlayerInfo,
		// Token: 0x0400F998 RID: 63896
		SetBehaviorTreeRunningActions,
		// Token: 0x0400F999 RID: 63897
		SetErrorActionsInRunningTree,
		// Token: 0x0400F99A RID: 63898
		StartPreTestOperation,
		// Token: 0x0400F99B RID: 63899
		StartPostTestOperation,
		// Token: 0x0400F99C RID: 63900
		SpawnEntityByTemplateType,
		// Token: 0x0400F99D RID: 63901
		EnterFunctionTestMode,
		// Token: 0x0400F99E RID: 63902
		ExitFunctionTestMode,
		// Token: 0x0400F99F RID: 63903
		DeleteEntityById,
		// Token: 0x0400F9A0 RID: 63904
		GmResult,
		// Token: 0x0400F9A1 RID: 63905
		OnGameLoginCompleted,
		// Token: 0x0400F9A2 RID: 63906
		ExcuteGmCommand,
		// Token: 0x0400F9A3 RID: 63907
		OnReceiveClickedEntities,
		// Token: 0x0400F9A4 RID: 63908
		LoadArchive,
		// Token: 0x0400F9A5 RID: 63909
		RefreshMainEditor,
		// Token: 0x0400F9A6 RID: 63910
		RunPackage,
		// Token: 0x0400F9A7 RID: 63911
		DevPkgHeartBeatResp,
		// Token: 0x0400F9A8 RID: 63912
		ClientReady,
		// Token: 0x0400F9A9 RID: 63913
		GameUseCaseTestResult,
		// Token: 0x0400F9AA RID: 63914
		OpenDiffToolInP4V,
		// Token: 0x0400F9AB RID: 63915
		OpenDiffToolByDepotPath,
		// Token: 0x0400F9AC RID: 63916
		SearchInEditor,
		// Token: 0x0400F9AD RID: 63917
		CreateRefreshGroupAndFillSelected,
		// Token: 0x0400F9AE RID: 63918
		NavToEditorByTidText,
		// Token: 0x0400F9AF RID: 63919
		SearchUassetReferences,
		// Token: 0x0400F9B0 RID: 63920
		SearchBpReference,
		// Token: 0x0400F9B1 RID: 63921
		OpenUassetFile,
		// Token: 0x0400F9B2 RID: 63922
		OnClientExitGame,
		// Token: 0x0400F9B3 RID: 63923
		CheckOutActor,
		// Token: 0x0400F9B4 RID: 63924
		ShowUserDefinedEnum,
		// Token: 0x0400F9B5 RID: 63925
		ReportAiMerge
	}
}
