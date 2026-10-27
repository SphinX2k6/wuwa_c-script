using System;
using System.Runtime.CompilerServices;

// Token: 0x02003501 RID: 13569
[NullableContext(1)]
public interface IGamebudgetAllocatorConfigPlatformCreator
{
	// Token: 0x0601DBF7 RID: 121847
	GameBudgetAllocatorConfig CreateNormalEntityConfig();

	// Token: 0x0601DBF8 RID: 121848
	GameBudgetAllocatorConfig CreateBossEntityConfig();

	// Token: 0x0601DBF9 RID: 121849
	GameBudgetAllocatorConfig CreateCharacterEntityConfig();

	// Token: 0x0601DBFA RID: 121850
	GameBudgetAllocatorConfig CreateNormalNpcEntityConfig();

	// Token: 0x0601DBFB RID: 121851
	GameBudgetAllocatorConfig CreateSimpleNpcEntityConfig();

	// Token: 0x0601DBFC RID: 121852
	TsGameBudgetAllocatorTickIntervalDetailConfig CreateFightEffectConfig();

	// Token: 0x0601DBFD RID: 121853
	GameBudgetAllocatorConfig CreateEffectConfig();

	// Token: 0x0601DBFE RID: 121854
	GameBudgetAllocatorConfig CreateEffectImportanceConfig();

	// Token: 0x0601DBFF RID: 121855
	GameBudgetAllocatorConfig CreateStabilizeLowEntityConfig();

	// Token: 0x0601DC00 RID: 121856
	GameBudgetAllocatorConfig CreateAlwaysTickHotfixConfig();

	// Token: 0x0601DC01 RID: 121857
	GameBudgetAllocatorConfig CreateMoveSceneItemEntityConfig();

	// Token: 0x0601DC02 RID: 121858
	TsGameBudgetAllocatorTickIntervalDetailConfig CreatePlayerAlwaysTickConfig();

	// Token: 0x0601DC03 RID: 121859
	GameBudgetAllocatorConfig CreateNormalEntityAlwaysTickConfig();

	// Token: 0x0601DC04 RID: 121860
	GameBudgetAllocatorConfig CreateNormalEntityAlwaysTickWithoutNotRenderedConfig();

	// Token: 0x0601DC05 RID: 121861
	TsGameBudgetAllocatorTickIntervalDetailConfig CreateAlwaysTickConfig();

	// Token: 0x0601DC06 RID: 121862
	TsGameBudgetAllocatorTickIntervalDetailConfig CreateCameraAlwaysTickConfig();

	// Token: 0x0601DC07 RID: 121863
	TsGameBudgetAllocatorTickIntervalDetailConfig CreateIdleExecConfig();

	// Token: 0x0601DC08 RID: 121864
	TsGameBudgetAllocatorTickIntervalDetailConfig CreateHUDTickConfig();

	// Token: 0x0601DC09 RID: 121865
	GameBudgetAllocatorConfig CreateCharacterRenderConfig();

	// Token: 0x0601DC0A RID: 121866
	GameBudgetAllocatorConfig CreateNpcRenderConfig();

	// Token: 0x0601DC0B RID: 121867
	TsGameBudgetAllocatorTickIntervalDetailConfig CreateBattleHeadViewConfig();

	// Token: 0x0601DC0C RID: 121868
	GameBudgetAllocatorConfig CreateCollisionPlantConfig();

	// Token: 0x0601DC0D RID: 121869
	TsGameBudgetAllocatorTickIntervalDetailConfig CreateBlueprintSingletonConfig();

	// Token: 0x0601DC0E RID: 121870
	GameBudgetAllocatorConfig CreateSceneBlueprintActorConfig();

	// Token: 0x0601DC0F RID: 121871
	GameBudgetAllocatorConfig CreateFarBlueprintActorConfig();

	// Token: 0x0601DC10 RID: 121872
	GameBudgetAllocatorConfig CreateSuperFarBlueprintActorConfig();

	// Token: 0x0601DC11 RID: 121873
	GameBudgetAllocatorConfig CreateDynamicPhysicsInteractionActorConfig();

	// Token: 0x0601DC12 RID: 121874
	GameBudgetAllocatorConfig CreateStaticPhysicsInteractionActorConfig();

	// Token: 0x0601DC13 RID: 121875
	GameBudgetAllocatorConfig CreateHighPriorityPhysicsInteractionActorConfig();

	// Token: 0x0601DC14 RID: 121876
	GameBudgetAllocatorConfig CreateSpecialBlueprintActorConfig();
}
