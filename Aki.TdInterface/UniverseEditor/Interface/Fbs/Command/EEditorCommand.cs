using System;

namespace Aki.UniverseEditor.Interface.Fbs.Command
{
	// Token: 0x02006521 RID: 25889
	public enum EEditorCommand : byte
	{
		// Token: 0x040106E9 RID: 67305
		RpcResp,
		// Token: 0x040106EA RID: 67306
		RestartEditor,
		// Token: 0x040106EB RID: 67307
		SilentSaveAndRestart,
		// Token: 0x040106EC RID: 67308
		ForceUpdateEditor,
		// Token: 0x040106ED RID: 67309
		ShowEntityView,
		// Token: 0x040106EE RID: 67310
		NavToEntity,
		// Token: 0x040106EF RID: 67311
		AsyncCheckResult,
		// Token: 0x040106F0 RID: 67312
		P4UniversePorxyResponse,
		// Token: 0x040106F1 RID: 67313
		LoadUseCase,
		// Token: 0x040106F2 RID: 67314
		NavToQuest,
		// Token: 0x040106F3 RID: 67315
		NavToLevelPlay,
		// Token: 0x040106F4 RID: 67316
		NavToEntityTemplate,
		// Token: 0x040106F5 RID: 67317
		NavToEntityBundle,
		// Token: 0x040106F6 RID: 67318
		NavToFlowList,
		// Token: 0x040106F7 RID: 67319
		NavToBehaviorTreeFragment,
		// Token: 0x040106F8 RID: 67320
		NavToWorldEditor,
		// Token: 0x040106F9 RID: 67321
		DeliverLevelPlay,
		// Token: 0x040106FA RID: 67322
		SetPlayerInfo,
		// Token: 0x040106FB RID: 67323
		SetBehaviorTreeRunningActions,
		// Token: 0x040106FC RID: 67324
		SetErrorActionsInRunningTree,
		// Token: 0x040106FD RID: 67325
		StartPreTestOperation,
		// Token: 0x040106FE RID: 67326
		StartPostTestOperation,
		// Token: 0x040106FF RID: 67327
		SpawnEntityByTemplateType,
		// Token: 0x04010700 RID: 67328
		EnterFunctionTestMode,
		// Token: 0x04010701 RID: 67329
		ExitFunctionTestMode,
		// Token: 0x04010702 RID: 67330
		DeleteEntityById,
		// Token: 0x04010703 RID: 67331
		GmResult,
		// Token: 0x04010704 RID: 67332
		OnGameLoginCompleted,
		// Token: 0x04010705 RID: 67333
		ExcuteGmCommand,
		// Token: 0x04010706 RID: 67334
		OnReceiveClickedEntities,
		// Token: 0x04010707 RID: 67335
		LoadArchive,
		// Token: 0x04010708 RID: 67336
		RefreshMainEditor,
		// Token: 0x04010709 RID: 67337
		RunPackage,
		// Token: 0x0401070A RID: 67338
		DevPkgHeartBeatResp,
		// Token: 0x0401070B RID: 67339
		ClientReady,
		// Token: 0x0401070C RID: 67340
		GameUseCaseTestResult,
		// Token: 0x0401070D RID: 67341
		OpenDiffToolInP4V,
		// Token: 0x0401070E RID: 67342
		OpenDiffToolByDepotPath,
		// Token: 0x0401070F RID: 67343
		SearchInEditor,
		// Token: 0x04010710 RID: 67344
		CreateRefreshGroupAndFillSelected,
		// Token: 0x04010711 RID: 67345
		NavToEditorByTidText,
		// Token: 0x04010712 RID: 67346
		SearchUassetReferences,
		// Token: 0x04010713 RID: 67347
		SearchBpReference,
		// Token: 0x04010714 RID: 67348
		OpenUassetFile,
		// Token: 0x04010715 RID: 67349
		OnClientExitGame,
		// Token: 0x04010716 RID: 67350
		CheckOutActor,
		// Token: 0x04010717 RID: 67351
		ShowUserDefinedEnum,
		// Token: 0x04010718 RID: 67352
		ReportAiMerge,
		// Token: 0x04010719 RID: 67353
		SetObjectField
	}
}
