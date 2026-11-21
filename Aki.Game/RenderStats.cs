using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;

// Token: 0x020029F9 RID: 10745
[NullableContext(2)]
[Nullable(0)]
[StaticVariableRuleIgnore]
public class RenderStats
{
	// Token: 0x0601AF5B RID: 110427 RVA: 0x0084655C File Offset: 0x0084475C
	public static void Init()
	{
		if (RenderStats.IsInit || !Info.Instance.IsGameRunning())
		{
			return;
		}
		RenderStats.IsInit = true;
		RenderStats.StatRenderModuleModelAddTickable = Stat.Create("Render_RenderModuleModel_AddTickable", "", "");
		RenderStats.StatRenderModuleModelTickTickable = Stat.Create("Render_RenderModuleModel_TickTickable", "", "");
		RenderStats.StatRenderModuleModelTickRenderShell = Stat.Create("Render_RenderModuleModel_TickRenderShell", "", "");
		RenderStats.StatBadSignalUpdate = Stat.Create("Render_BadSignal_Update", "", "");
		RenderStats.StatComplexBrokenUpdate = Stat.Create("Render_ComplexBroken_Update", "", "");
		RenderStats.StatCharRenderingComponentAddData = Stat.Create("Render_CharRenderComponent_AddMaterialControlData", "", "");
		RenderStats.StatCharRenderingComponentDataCache = Stat.Create("Render_CharRenderComponent_CacheData", "", "");
		RenderStats.StatCharRenderingComponentInit = Stat.Create("Render_CharRenderComponent_Init", "", "");
		RenderStats.StatCharRenderingComponentUpdate = Stat.Create("Render_CharRenderComponent_Update", "", "");
		RenderStats.StatCharRenderingComponentDataGroupBeforeUpdate = Stat.Create("Render_CharRenderComponent_DataGroupBeforeUpdate", "", "");
		RenderStats.StatCharRenderingComponentDataGroupAfterUpdate = Stat.Create("Render_CharRenderComponent_DataGroupAfterUpdate", "", "");
		RenderStats.StatCharRenderingComponentUpdateInner = Stat.Create("Render_CharRenderComponent_UpdateInner", "", "");
		RenderStats.StatCharRenderingComponentLateUpdate = Stat.Create("Render_CharRenderComponent_LateUpdate", "", "");
		RenderStats.StatCharRenderingComponentRuntimeDataUpdateState = Stat.Create("Render_CharRenderComponent_RuntimeDataUpdateState", "", "");
		RenderStats.StatCharRenderingComponentRuntimeDataUpdateEffect = Stat.Create("Render_CharRenderComponent_RuntimeDataUpdateEffect", "", "");
		RenderStats.StatCharRenderingComponentRuntimeDataSetSpecified = Stat.Create("Render_CharRenderComponent_RuntimeDataSetSpecified", "", "");
		RenderStats.StatCharRenderShellTick = Stat.Create("Render_RenderShell_Tick", "", "");
		RenderStats.StatRenderBillboardTick = Stat.Create("Render_Billboard_Tick", "", "");
		RenderStats.StatEffectBaseActorTick = Stat.Create("Render_EffectBaseActor_Tick", "", "");
		RenderStats.StatEffectBaseActorInit = Stat.Create("Render_EffectBaseActor_Init", "", "");
		RenderStats.StatEffectBaseActorComplete = Stat.Create("Render_EffectBaseActor_Complete", "", "");
		RenderStats.StatEffectBaseActorUpdateTime = Stat.Create("Render_EffectBaseActor_UpdateTime", "", "");
		RenderStats.StatEffectBaseActorUpdateNiagara = Stat.Create("Render_EffectBaseActor_UpdateNiagara", "", "");
		RenderStats.StatEffectBaseActorUpdateTsUpdate = Stat.Create("Render_EffectBaseActor_TsUpdate", "", "");
		RenderStats.StatSceneCharLimbTick = Stat.Create("Render_SceneCharLimb_Tick", "", "");
		RenderStats.StatSceneInteractionManagerTick = Stat.Create("Render_SceneInteraction_Tick", "", "");
		RenderStats.StatSceneInteractionGrass = Stat.Create("Render_SceneInteraction_Grass_Tick", "", "");
		RenderStats.StatSceneInteractionPc = Stat.Create("Render_SceneInteraction_PC_Tick", "", "");
		RenderStats.StatSceneInteractionWater = Stat.Create("Render_SceneInteraction_Water_Tick", "", "");
		RenderStats.StatSceneInteractionOthers = Stat.Create("Render_SceneInteraction_Others_Tick", "", "");
		RenderStats.StatRenderDataManagerTick = Stat.Create("Render_RenderDataManager_Tick", "", "");
		RenderStats.StatItemMaterialManagerTick = Stat.Create("Render_ItemMaterialManager_Tick", "", "");
		RenderStats.StatItemMaterialControllerCollectParameter = Stat.Create("Render_ItemMaterialController_CollectParameter", "", "");
		RenderStats.StatEffectTick = Stat.Create("Render_Effect_Tick", "", "");
		RenderStats.StatFoliageClusteredEffectTick = Stat.Create("Render_FoliageClusteredEffect_Tick", "", "");
		RenderStats.StatAudioVisualizationManagerTick = Stat.Create("Render_AudioVisualizationManager_Tick", "", "");
		RenderStats.StatCharMaterialControllerUpdateRim = Stat.Create("Render_StatCharMaterialControllerUpdateRim_Tick", "", "");
		RenderStats.StatCharMaterialControllerUpdateDissolve = Stat.Create("Render_StatCharMaterialControllerUpdateDissolve_Tick", "", "");
		RenderStats.StatCharMaterialControllerUpdateOutline = Stat.Create("Render_StatCharMaterialControllerUpdateOutline_Tick", "", "");
		RenderStats.StatCharMaterialControllerUpdateModifyOtherParameters = Stat.Create("Render_StatCharMaterialControllerUpdateModifyOtherParameters_Tick", "", "");
		RenderStats.StatCharMaterialControllerUpdateSampleTexture = Stat.Create("Render_StatCharMaterialControllerUpdateSampleTexture_Tick", "", "");
		RenderStats.StatCharMaterialControllerUpdateTransfer = Stat.Create("Render_StatCharMaterialControllerUpdateTransfer_Tick", "", "");
		RenderStats.StatCharMaterialControllerUpdateMotionOffset = Stat.Create("Render_StatCharMaterialControllerUpdateMotionOffset_Tick", "", "");
		RenderStats.StatCharMaterialControllerUpdateAbsorbed = Stat.Create("Render_StatCharMaterialControllerUpdateAbsorbed_Tick", "", "");
		RenderStats.StatCharMaterialControllerUpdateStripMask = Stat.Create("Render_StatCharMaterialControllerUpdateStripMask_Tick", "", "");
		RenderStats.StatCharMaterialControllerUpdateDither = Stat.Create("Render_StatCharMaterialControllerUpdateDither_Tick", "", "");
		RenderStats.StatCharMaterialControllerUpdateCustomMaterialEffect = Stat.Create("Render_StatCharMaterialControllerUpdateCustomMaterialEffect_Tick", "", "");
		RenderStats.StatCharMaterialControllerUpdateHairReplace = Stat.Create("Render_StatCharMaterialControllerUpdateHairReplace_Tick", "", "");
		RenderStats.StatCharMaterialControllerUpdateMaterialReplace = Stat.Create("Render_StatCharMaterialControllerUpdateMaterialReplace_Tick", "", "");
	}

	// Token: 0x0400EA30 RID: 59952
	private static bool IsInit;

	// Token: 0x0400EA31 RID: 59953
	public static Stat StatRenderModuleModelAddTickable;

	// Token: 0x0400EA32 RID: 59954
	public static Stat StatRenderModuleModelTickTickable;

	// Token: 0x0400EA33 RID: 59955
	public static Stat StatRenderModuleModelTickRenderShell;

	// Token: 0x0400EA34 RID: 59956
	public static Stat StatBadSignalUpdate;

	// Token: 0x0400EA35 RID: 59957
	public static Stat StatComplexBrokenUpdate;

	// Token: 0x0400EA36 RID: 59958
	public static Stat StatCharRenderingComponentAddData;

	// Token: 0x0400EA37 RID: 59959
	public static Stat StatCharRenderingComponentDataCache;

	// Token: 0x0400EA38 RID: 59960
	public static Stat StatCharRenderingComponentInit;

	// Token: 0x0400EA39 RID: 59961
	public static Stat StatCharRenderingComponentUpdate;

	// Token: 0x0400EA3A RID: 59962
	public static Stat StatCharRenderingComponentDataGroupBeforeUpdate;

	// Token: 0x0400EA3B RID: 59963
	public static Stat StatCharRenderingComponentDataGroupAfterUpdate;

	// Token: 0x0400EA3C RID: 59964
	public static Stat StatCharRenderingComponentUpdateInner;

	// Token: 0x0400EA3D RID: 59965
	public static Stat StatCharRenderingComponentLateUpdate;

	// Token: 0x0400EA3E RID: 59966
	public static Stat StatCharRenderingComponentRuntimeDataUpdateState;

	// Token: 0x0400EA3F RID: 59967
	public static Stat StatCharRenderingComponentRuntimeDataUpdateEffect;

	// Token: 0x0400EA40 RID: 59968
	public static Stat StatCharRenderingComponentRuntimeDataSetSpecified;

	// Token: 0x0400EA41 RID: 59969
	public static Stat StatCharRenderShellTick;

	// Token: 0x0400EA42 RID: 59970
	public static Stat StatRenderBillboardTick;

	// Token: 0x0400EA43 RID: 59971
	public static Stat StatEffectBaseActorTick;

	// Token: 0x0400EA44 RID: 59972
	public static Stat StatEffectBaseActorInit;

	// Token: 0x0400EA45 RID: 59973
	public static Stat StatEffectBaseActorComplete;

	// Token: 0x0400EA46 RID: 59974
	public static Stat StatEffectBaseActorUpdateTime;

	// Token: 0x0400EA47 RID: 59975
	public static Stat StatEffectBaseActorUpdateNiagara;

	// Token: 0x0400EA48 RID: 59976
	public static Stat StatEffectBaseActorUpdateTsUpdate;

	// Token: 0x0400EA49 RID: 59977
	public static Stat StatSceneCharLimbTick;

	// Token: 0x0400EA4A RID: 59978
	public static Stat StatSceneInteractionManagerTick;

	// Token: 0x0400EA4B RID: 59979
	public static Stat StatSceneInteractionPc;

	// Token: 0x0400EA4C RID: 59980
	public static Stat StatSceneInteractionGrass;

	// Token: 0x0400EA4D RID: 59981
	public static Stat StatSceneInteractionWater;

	// Token: 0x0400EA4E RID: 59982
	public static Stat StatSceneInteractionOthers;

	// Token: 0x0400EA4F RID: 59983
	public static Stat StatRenderDataManagerTick;

	// Token: 0x0400EA50 RID: 59984
	public static Stat StatItemMaterialManagerTick;

	// Token: 0x0400EA51 RID: 59985
	public static Stat StatItemMaterialControllerCollectParameter;

	// Token: 0x0400EA52 RID: 59986
	public static Stat StatEffectTick;

	// Token: 0x0400EA53 RID: 59987
	public static Stat StatFoliageClusteredEffectTick;

	// Token: 0x0400EA54 RID: 59988
	public static Stat StatAudioVisualizationManagerTick;

	// Token: 0x0400EA55 RID: 59989
	public static Stat StatCharMaterialControllerUpdateRim;

	// Token: 0x0400EA56 RID: 59990
	public static Stat StatCharMaterialControllerUpdateDissolve;

	// Token: 0x0400EA57 RID: 59991
	public static Stat StatCharMaterialControllerUpdateOutline;

	// Token: 0x0400EA58 RID: 59992
	public static Stat StatCharMaterialControllerUpdateModifyOtherParameters;

	// Token: 0x0400EA59 RID: 59993
	public static Stat StatCharMaterialControllerUpdateSampleTexture;

	// Token: 0x0400EA5A RID: 59994
	public static Stat StatCharMaterialControllerUpdateTransfer;

	// Token: 0x0400EA5B RID: 59995
	public static Stat StatCharMaterialControllerUpdateMotionOffset;

	// Token: 0x0400EA5C RID: 59996
	public static Stat StatCharMaterialControllerUpdateAbsorbed;

	// Token: 0x0400EA5D RID: 59997
	public static Stat StatCharMaterialControllerUpdateStripMask;

	// Token: 0x0400EA5E RID: 59998
	public static Stat StatCharMaterialControllerUpdateDither;

	// Token: 0x0400EA5F RID: 59999
	public static Stat StatCharMaterialControllerUpdateCustomMaterialEffect;

	// Token: 0x0400EA60 RID: 60000
	public static Stat StatCharMaterialControllerUpdateHairReplace;

	// Token: 0x0400EA61 RID: 60001
	public static Stat StatCharMaterialControllerUpdateMaterialReplace;

	// Token: 0x0400EA62 RID: 60002
	public static Stat StatSceneInteractionActor;
}
