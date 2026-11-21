using System;
using System.Runtime.CompilerServices;

// Token: 0x02002A76 RID: 10870
[NullableContext(1)]
public interface IGamebudgetAllocatorConfigPlatformCreator
{
	// Token: 0x0601B90E RID: 112910
	GameBudgetAllocatorConfig CreateNormalEntityConfig();

	// Token: 0x0601B90F RID: 112911
	GameBudgetAllocatorConfig CreateBossEntityConfig();

	// Token: 0x0601B910 RID: 112912
	GameBudgetAllocatorConfig CreateCharacterEntityConfig();

	// Token: 0x0601B911 RID: 112913
	GameBudgetAllocatorConfig CreateNormalNpcEntityConfig();

	// Token: 0x0601B912 RID: 112914
	GameBudgetAllocatorConfig CreateSimpleNpcEntityConfig();

	// Token: 0x0601B913 RID: 112915
	TsGameBudgetAllocatorTickIntervalDetailConfig CreateFightEffectConfig();

	// Token: 0x0601B914 RID: 112916
	GameBudgetAllocatorConfig CreateEffectConfig();

	// Token: 0x0601B915 RID: 112917
	GameBudgetAllocatorConfig CreateEffectImportanceConfig();

	// Token: 0x0601B916 RID: 112918
	GameBudgetAllocatorConfig CreateStabilizeLowEntityConfig();

	// Token: 0x0601B917 RID: 112919
	GameBudgetAllocatorConfig CreateAlwaysTickHotfixConfig();

	// Token: 0x0601B918 RID: 112920
	GameBudgetAllocatorConfig CreateMoveSceneItemEntityConfig();

	// Token: 0x0601B919 RID: 112921
	TsGameBudgetAllocatorTickIntervalDetailConfig CreatePlayerAlwaysTickConfig();

	// Token: 0x0601B91A RID: 112922
	GameBudgetAllocatorConfig CreateNormalEntityAlwaysTickConfig();

	// Token: 0x0601B91B RID: 112923
	GameBudgetAllocatorConfig CreateNormalEntityAlwaysTickWithoutNotRenderedConfig();

	// Token: 0x0601B91C RID: 112924
	TsGameBudgetAllocatorTickIntervalDetailConfig CreateAlwaysTickConfig();

	// Token: 0x0601B91D RID: 112925
	TsGameBudgetAllocatorTickIntervalDetailConfig CreateCameraAlwaysTickConfig();

	// Token: 0x0601B91E RID: 112926
	TsGameBudgetAllocatorTickIntervalDetailConfig CreateIdleExecConfig();

	// Token: 0x0601B91F RID: 112927
	TsGameBudgetAllocatorTickIntervalDetailConfig CreateHUDTickConfig();

	// Token: 0x0601B920 RID: 112928
	GameBudgetAllocatorConfig CreateCharacterRenderConfig();

	// Token: 0x0601B921 RID: 112929
	GameBudgetAllocatorConfig CreateNpcRenderConfig();

	// Token: 0x0601B922 RID: 112930
	TsGameBudgetAllocatorTickIntervalDetailConfig CreateBattleHeadViewConfig();

	// Token: 0x0601B923 RID: 112931
	GameBudgetAllocatorConfig CreateCollisionPlantConfig();

	// Token: 0x0601B924 RID: 112932
	TsGameBudgetAllocatorTickIntervalDetailConfig CreateBlueprintSingletonConfig();

	// Token: 0x0601B925 RID: 112933
	GameBudgetAllocatorConfig CreateSceneBlueprintActorConfig();

	// Token: 0x0601B926 RID: 112934
	GameBudgetAllocatorConfig CreateFarBlueprintActorConfig();

	// Token: 0x0601B927 RID: 112935
	GameBudgetAllocatorConfig CreateSuperFarBlueprintActorConfig();

	// Token: 0x0601B928 RID: 112936
	GameBudgetAllocatorConfig CreateDynamicPhysicsInteractionActorConfig();

	// Token: 0x0601B929 RID: 112937
	GameBudgetAllocatorConfig CreateStaticPhysicsInteractionActorConfig();

	// Token: 0x0601B92A RID: 112938
	GameBudgetAllocatorConfig CreateHighPriorityPhysicsInteractionActorConfig();

	// Token: 0x0601B92B RID: 112939
	GameBudgetAllocatorConfig CreateSpecialBlueprintActorConfig();

	// Token: 0x0601B92C RID: 112940
	GameBudgetAllocatorConfig CreateScreenDecalActorConfig();
}
