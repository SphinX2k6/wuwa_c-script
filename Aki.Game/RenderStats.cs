using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;

// Token: 0x02003485 RID: 13445
[NullableContext(2)]
[Nullable(0)]
[StaticVariableRuleIgnore]
public class RenderStats
{
	// Token: 0x0601D253 RID: 119379 RVA: 0x0081F22C File Offset: 0x0081D42C
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

	// Token: 0x0400E578 RID: 58744
	private static bool IsInit;

	// Token: 0x0400E579 RID: 58745
	public static Stat StatRenderModuleModelAddTickable;

	// Token: 0x0400E57A RID: 58746
	public static Stat StatRenderModuleModelTickTickable;

	// Token: 0x0400E57B RID: 58747
	public static Stat StatRenderModuleModelTickRenderShell;

	// Token: 0x0400E57C RID: 58748
	public static Stat StatBadSignalUpdate;

	// Token: 0x0400E57D RID: 58749
	public static Stat StatComplexBrokenUpdate;

	// Token: 0x0400E57E RID: 58750
	public static Stat StatCharRenderingComponentAddData;

	// Token: 0x0400E57F RID: 58751
	public static Stat StatCharRenderingComponentDataCache;

	// Token: 0x0400E580 RID: 58752
	public static Stat StatCharRenderingComponentInit;

	// Token: 0x0400E581 RID: 58753
	public static Stat StatCharRenderingComponentUpdate;

	// Token: 0x0400E582 RID: 58754
	public static Stat StatCharRenderingComponentDataGroupBeforeUpdate;

	// Token: 0x0400E583 RID: 58755
	public static Stat StatCharRenderingComponentDataGroupAfterUpdate;

	// Token: 0x0400E584 RID: 58756
	public static Stat StatCharRenderingComponentUpdateInner;

	// Token: 0x0400E585 RID: 58757
	public static Stat StatCharRenderingComponentLateUpdate;

	// Token: 0x0400E586 RID: 58758
	public static Stat StatCharRenderingComponentRuntimeDataUpdateState;

	// Token: 0x0400E587 RID: 58759
	public static Stat StatCharRenderingComponentRuntimeDataUpdateEffect;

	// Token: 0x0400E588 RID: 58760
	public static Stat StatCharRenderingComponentRuntimeDataSetSpecified;

	// Token: 0x0400E589 RID: 58761
	public static Stat StatCharRenderShellTick;

	// Token: 0x0400E58A RID: 58762
	public static Stat StatRenderBillboardTick;

	// Token: 0x0400E58B RID: 58763
	public static Stat StatEffectBaseActorTick;

	// Token: 0x0400E58C RID: 58764
	public static Stat StatEffectBaseActorInit;

	// Token: 0x0400E58D RID: 58765
	public static Stat StatEffectBaseActorComplete;

	// Token: 0x0400E58E RID: 58766
	public static Stat StatEffectBaseActorUpdateTime;

	// Token: 0x0400E58F RID: 58767
	public static Stat StatEffectBaseActorUpdateNiagara;

	// Token: 0x0400E590 RID: 58768
	public static Stat StatEffectBaseActorUpdateTsUpdate;

	// Token: 0x0400E591 RID: 58769
	public static Stat StatSceneCharLimbTick;

	// Token: 0x0400E592 RID: 58770
	public static Stat StatSceneInteractionManagerTick;

	// Token: 0x0400E593 RID: 58771
	public static Stat StatSceneInteractionPc;

	// Token: 0x0400E594 RID: 58772
	public static Stat StatSceneInteractionGrass;

	// Token: 0x0400E595 RID: 58773
	public static Stat StatSceneInteractionWater;

	// Token: 0x0400E596 RID: 58774
	public static Stat StatSceneInteractionOthers;

	// Token: 0x0400E597 RID: 58775
	public static Stat StatRenderDataManagerTick;

	// Token: 0x0400E598 RID: 58776
	public static Stat StatItemMaterialManagerTick;

	// Token: 0x0400E599 RID: 58777
	public static Stat StatItemMaterialControllerCollectParameter;

	// Token: 0x0400E59A RID: 58778
	public static Stat StatEffectTick;

	// Token: 0x0400E59B RID: 58779
	public static Stat StatFoliageClusteredEffectTick;

	// Token: 0x0400E59C RID: 58780
	public static Stat StatAudioVisualizationManagerTick;

	// Token: 0x0400E59D RID: 58781
	public static Stat StatCharMaterialControllerUpdateRim;

	// Token: 0x0400E59E RID: 58782
	public static Stat StatCharMaterialControllerUpdateDissolve;

	// Token: 0x0400E59F RID: 58783
	public static Stat StatCharMaterialControllerUpdateOutline;

	// Token: 0x0400E5A0 RID: 58784
	public static Stat StatCharMaterialControllerUpdateModifyOtherParameters;

	// Token: 0x0400E5A1 RID: 58785
	public static Stat StatCharMaterialControllerUpdateSampleTexture;

	// Token: 0x0400E5A2 RID: 58786
	public static Stat StatCharMaterialControllerUpdateTransfer;

	// Token: 0x0400E5A3 RID: 58787
	public static Stat StatCharMaterialControllerUpdateMotionOffset;

	// Token: 0x0400E5A4 RID: 58788
	public static Stat StatCharMaterialControllerUpdateAbsorbed;

	// Token: 0x0400E5A5 RID: 58789
	public static Stat StatCharMaterialControllerUpdateStripMask;

	// Token: 0x0400E5A6 RID: 58790
	public static Stat StatCharMaterialControllerUpdateDither;

	// Token: 0x0400E5A7 RID: 58791
	public static Stat StatCharMaterialControllerUpdateCustomMaterialEffect;

	// Token: 0x0400E5A8 RID: 58792
	public static Stat StatCharMaterialControllerUpdateHairReplace;

	// Token: 0x0400E5A9 RID: 58793
	public static Stat StatCharMaterialControllerUpdateMaterialReplace;

	// Token: 0x0400E5AA RID: 58794
	public static Stat StatSceneInteractionActor;
}
