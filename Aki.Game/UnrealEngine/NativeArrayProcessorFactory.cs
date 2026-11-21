using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.AI.AIFunctionCommon.KFCS_WandersData;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera.MovieCamera;
using AkiClient.Game.Aki.Character.Input.Structures;
using AkiClient.Game.Aki.Character.Monster.Common;
using AkiClient.Game.Aki.Character.NPC.GPUNPC.BP.CrowdAi;
using AkiClient.Game.Aki.Core.Fight;
using AkiClient.Game.Aki.Data.AIGearStrategy.AIRaceStrategy;
using AkiClient.Game.Aki.Data.Camera.CameraDebugTool;
using AkiClient.Game.Aki.Data.Common.Struct;
using AkiClient.Game.Aki.Data.Entity.Struct;
using AkiClient.Game.Aki.Data.Fight.Struct;
using AkiClient.Game.Aki.Data.Fight.UI;
using AkiClient.Game.Aki.Data.Gameplay.RhythmGame;
using AkiClient.Game.Aki.Data.Gameplay.ZoneFollowCamera;
using AkiClient.Game.Aki.Data.Interaction.Struct;
using AkiClient.Game.Aki.Data.Level.Swing;
using AkiClient.Game.Aki.Data.Level.Vehicle;
using AkiClient.Game.Aki.Data.Manipulate;
using AkiClient.Game.Aki.Data.NPC.SimpleNpcFlow;
using AkiClient.Game.Aki.Data.Qte;
using AkiClient.Game.Aki.Data.QuickTimeAction;
using AkiClient.Game.Aki.Data.QuickTimeAction.Customization;
using AkiClient.Game.Aki.Data.Sequence.Struct;
using AkiClient.Game.Aki.Data.Server.Struct;
using AkiClient.Game.Aki.Data.SpineMouthAnimation.Struct;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.ClusteredStuff;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.Data;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.WaterInteraction;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interaction;
using AkiClient.Game.Aki.Sequence.Manager;
using AkiClient.Game.Aki.UI.Module.ActiveDebug;

namespace UnrealEngine
{
	// Token: 0x02002F4E RID: 12110
	[NullableContext(1)]
	[Nullable(0)]
	public static class NativeArrayProcessorFactory
	{
		// Token: 0x17002D24 RID: 11556
		// (get) Token: 0x0601CB11 RID: 117521 RVA: 0x008C3339 File Offset: 0x008C1539
		private static BlittableUnrealScriptStructArrayProcessor<SCounterAttackBuff> SCounterAttackBuff_ArrayProcessor
		{
			get
			{
				return new BlittableUnrealScriptStructArrayProcessor<SCounterAttackBuff>();
			}
		}

		// Token: 0x17002D25 RID: 11557
		// (get) Token: 0x0601CB12 RID: 117522 RVA: 0x008C3340 File Offset: 0x008C1540
		private static BlittableUnrealScriptStructArrayProcessor<SSkillBehaviorCue> SSkillBehaviorCue_ArrayProcessor
		{
			get
			{
				return new BlittableUnrealScriptStructArrayProcessor<SSkillBehaviorCue>();
			}
		}

		// Token: 0x17002D26 RID: 11558
		// (get) Token: 0x0601CB13 RID: 117523 RVA: 0x008C3347 File Offset: 0x008C1547
		private static BlittableUnrealScriptStructArrayProcessor<SInputAction> SInputAction_ArrayProcessor
		{
			get
			{
				return new BlittableUnrealScriptStructArrayProcessor<SInputAction>();
			}
		}

		// Token: 0x17002D27 RID: 11559
		// (get) Token: 0x0601CB14 RID: 117524 RVA: 0x008C334E File Offset: 0x008C154E
		private static BlittableUnrealScriptStructArrayProcessor<SAiAttributeRate> SAiAttributeRate_ArrayProcessor
		{
			get
			{
				return new BlittableUnrealScriptStructArrayProcessor<SAiAttributeRate>();
			}
		}

		// Token: 0x17002D28 RID: 11560
		// (get) Token: 0x0601CB15 RID: 117525 RVA: 0x008C3355 File Offset: 0x008C1555
		private static BlittableUnrealScriptStructArrayProcessor<SFollowShooterEnablePriorityInfo> SFollowShooterEnablePriorityInfo_ArrayProcessor
		{
			get
			{
				return new BlittableUnrealScriptStructArrayProcessor<SFollowShooterEnablePriorityInfo>();
			}
		}

		// Token: 0x17002D29 RID: 11561
		// (get) Token: 0x0601CB16 RID: 117526 RVA: 0x008C335C File Offset: 0x008C155C
		private static BlittableUnrealScriptStructArrayProcessor<SSpecialEnergyBarKey> SSpecialEnergyBarKey_ArrayProcessor
		{
			get
			{
				return new BlittableUnrealScriptStructArrayProcessor<SSpecialEnergyBarKey>();
			}
		}

		// Token: 0x17002D2A RID: 11562
		// (get) Token: 0x0601CB17 RID: 117527 RVA: 0x008C3363 File Offset: 0x008C1563
		private static BlittableUnrealScriptStructArrayProcessor<SFloatThresholdAndBuff> SFloatThresholdAndBuff_ArrayProcessor
		{
			get
			{
				return new BlittableUnrealScriptStructArrayProcessor<SFloatThresholdAndBuff>();
			}
		}

		// Token: 0x17002D2B RID: 11563
		// (get) Token: 0x0601CB18 RID: 117528 RVA: 0x008C336A File Offset: 0x008C156A
		private static BlittableUnrealScriptStructArrayProcessor<SManipulatePointInfo> SManipulatePointInfo_ArrayProcessor
		{
			get
			{
				return new BlittableUnrealScriptStructArrayProcessor<SManipulatePointInfo>();
			}
		}

		// Token: 0x17002D2C RID: 11564
		// (get) Token: 0x0601CB19 RID: 117529 RVA: 0x008C3371 File Offset: 0x008C1571
		private static BlittableUnrealScriptStructArrayProcessor<SSpineMouthKey> SSpineMouthKey_ArrayProcessor
		{
			get
			{
				return new BlittableUnrealScriptStructArrayProcessor<SSpineMouthKey>();
			}
		}

		// Token: 0x17002D2D RID: 11565
		// (get) Token: 0x0601CB1A RID: 117530 RVA: 0x008C3378 File Offset: 0x008C1578
		private static BlittableUnrealScriptStructArrayProcessor<SEffectColorParameter> SEffectColorParameter_ArrayProcessor
		{
			get
			{
				return new BlittableUnrealScriptStructArrayProcessor<SEffectColorParameter>();
			}
		}

		// Token: 0x17002D2E RID: 11566
		// (get) Token: 0x0601CB1B RID: 117531 RVA: 0x008C337F File Offset: 0x008C157F
		private static BlittableUnrealScriptStructArrayProcessor<SEffectFloatParameter> SEffectFloatParameter_ArrayProcessor
		{
			get
			{
				return new BlittableUnrealScriptStructArrayProcessor<SEffectFloatParameter>();
			}
		}

		// Token: 0x17002D2F RID: 11567
		// (get) Token: 0x0601CB1C RID: 117532 RVA: 0x008C3386 File Offset: 0x008C1586
		private static BlittableUnrealScriptStructArrayProcessor<SEffectVectorParameter> SEffectVectorParameter_ArrayProcessor
		{
			get
			{
				return new BlittableUnrealScriptStructArrayProcessor<SEffectVectorParameter>();
			}
		}

		// Token: 0x17002D30 RID: 11568
		// (get) Token: 0x0601CB1D RID: 117533 RVA: 0x008C338D File Offset: 0x008C158D
		private static UnrealScriptStructProxyArrayProcessor<SCamp> SCamp_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SCamp>();
			}
		}

		// Token: 0x17002D31 RID: 11569
		// (get) Token: 0x0601CB1E RID: 117534 RVA: 0x008C3394 File Offset: 0x008C1594
		private static UnrealScriptStructProxyArrayProcessor<SMovieCameraConfigItem> SMovieCameraConfigItem_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SMovieCameraConfigItem>();
			}
		}

		// Token: 0x17002D32 RID: 11570
		// (get) Token: 0x0601CB1F RID: 117535 RVA: 0x008C339B File Offset: 0x008C159B
		private static UnrealScriptStructProxyArrayProcessor<SCamera_Setting> SCamera_Setting_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SCamera_Setting>();
			}
		}

		// Token: 0x17002D33 RID: 11571
		// (get) Token: 0x0601CB20 RID: 117536 RVA: 0x008C33A2 File Offset: 0x008C15A2
		private static UnrealScriptStructProxyArrayProcessor<SCameraConfig> SCameraConfig_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SCameraConfig>();
			}
		}

		// Token: 0x17002D34 RID: 11572
		// (get) Token: 0x0601CB21 RID: 117537 RVA: 0x008C33A9 File Offset: 0x008C15A9
		private static UnrealScriptStructProxyArrayProcessor<SCameraModifier_Condition> SCameraModifier_Condition_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SCameraModifier_Condition>();
			}
		}

		// Token: 0x17002D35 RID: 11573
		// (get) Token: 0x0601CB22 RID: 117538 RVA: 0x008C33B0 File Offset: 0x008C15B0
		private static UnrealScriptStructProxyArrayProcessor<SCameraModifier_Settings_ArmLengthDynamicValue> SCameraModifier_Settings_ArmLengthDynamicValue_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SCameraModifier_Settings_ArmLengthDynamicValue>();
			}
		}

		// Token: 0x17002D36 RID: 11574
		// (get) Token: 0x0601CB23 RID: 117539 RVA: 0x008C33B7 File Offset: 0x008C15B7
		private static UnrealScriptStructProxyArrayProcessor<SCustomValueFormula> SCustomValueFormula_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SCustomValueFormula>();
			}
		}

		// Token: 0x17002D37 RID: 11575
		// (get) Token: 0x0601CB24 RID: 117540 RVA: 0x008C33BE File Offset: 0x008C15BE
		private static UnrealScriptStructProxyArrayProcessor<SDangoPerformEffectData> SDangoPerformEffectData_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SDangoPerformEffectData>();
			}
		}

		// Token: 0x17002D38 RID: 11576
		// (get) Token: 0x0601CB25 RID: 117541 RVA: 0x008C33C5 File Offset: 0x008C15C5
		private static UnrealScriptStructProxyArrayProcessor<SGameplayTagProbabilityCooldownInfo> SGameplayTagProbabilityCooldownInfo_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SGameplayTagProbabilityCooldownInfo>();
			}
		}

		// Token: 0x17002D39 RID: 11577
		// (get) Token: 0x0601CB26 RID: 117542 RVA: 0x008C33CC File Offset: 0x008C15CC
		private static UnrealScriptStructProxyArrayProcessor<SInputActiveCondition> SInputActiveCondition_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SInputActiveCondition>();
			}
		}

		// Token: 0x17002D3A RID: 11578
		// (get) Token: 0x0601CB27 RID: 117543 RVA: 0x008C33D3 File Offset: 0x008C15D3
		private static UnrealScriptStructProxyArrayProcessor<SInputBehaviorAction> SInputBehaviorAction_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SInputBehaviorAction>();
			}
		}

		// Token: 0x17002D3B RID: 11579
		// (get) Token: 0x0601CB28 RID: 117544 RVA: 0x008C33DA File Offset: 0x008C15DA
		private static UnrealScriptStructProxyArrayProcessor<SInputBehaviorCondition> SInputBehaviorCondition_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SInputBehaviorCondition>();
			}
		}

		// Token: 0x17002D3C RID: 11580
		// (get) Token: 0x0601CB29 RID: 117545 RVA: 0x008C33E1 File Offset: 0x008C15E1
		private static UnrealScriptStructProxyArrayProcessor<SSkillBehavior> SSkillBehavior_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SSkillBehavior>();
			}
		}

		// Token: 0x17002D3D RID: 11581
		// (get) Token: 0x0601CB2A RID: 117546 RVA: 0x008C33E8 File Offset: 0x008C15E8
		private static UnrealScriptStructProxyArrayProcessor<SSkillBehaviorAction> SSkillBehaviorAction_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SSkillBehaviorAction>();
			}
		}

		// Token: 0x17002D3E RID: 11582
		// (get) Token: 0x0601CB2B RID: 117547 RVA: 0x008C33EF File Offset: 0x008C15EF
		private static UnrealScriptStructProxyArrayProcessor<SSkillBehaviorBullet> SSkillBehaviorBullet_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SSkillBehaviorBullet>();
			}
		}

		// Token: 0x17002D3F RID: 11583
		// (get) Token: 0x0601CB2C RID: 117548 RVA: 0x008C33F6 File Offset: 0x008C15F6
		private static UnrealScriptStructProxyArrayProcessor<SSkillBehaviorCondition> SSkillBehaviorCondition_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SSkillBehaviorCondition>();
			}
		}

		// Token: 0x17002D40 RID: 11584
		// (get) Token: 0x0601CB2D RID: 117549 RVA: 0x008C33FD File Offset: 0x008C15FD
		private static UnrealScriptStructProxyArrayProcessor<SSkillTrigger> SSkillTrigger_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SSkillTrigger>();
			}
		}

		// Token: 0x17002D41 RID: 11585
		// (get) Token: 0x0601CB2E RID: 117550 RVA: 0x008C3404 File Offset: 0x008C1604
		private static UnrealScriptStructProxyArrayProcessor<SWeaponMesh> SWeaponMesh_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SWeaponMesh>();
			}
		}

		// Token: 0x17002D42 RID: 11586
		// (get) Token: 0x0601CB2F RID: 117551 RVA: 0x008C340B File Offset: 0x008C160B
		private static UnrealScriptStructProxyArrayProcessor<BP_Struct_CrowdAiBoidConfig> BP_Struct_CrowdAiBoidConfig_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<BP_Struct_CrowdAiBoidConfig>();
			}
		}

		// Token: 0x17002D43 RID: 11587
		// (get) Token: 0x0601CB30 RID: 117552 RVA: 0x008C3412 File Offset: 0x008C1612
		private static UnrealScriptStructProxyArrayProcessor<SBulletEffectOnHitConf> SBulletEffectOnHitConf_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SBulletEffectOnHitConf>();
			}
		}

		// Token: 0x17002D44 RID: 11588
		// (get) Token: 0x0601CB31 RID: 117553 RVA: 0x008C3419 File Offset: 0x008C1619
		private static UnrealScriptStructProxyArrayProcessor<SReBulletDataChildren> SReBulletDataChildren_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SReBulletDataChildren>();
			}
		}

		// Token: 0x17002D45 RID: 11589
		// (get) Token: 0x0601CB32 RID: 117554 RVA: 0x008C3420 File Offset: 0x008C1620
		private static UnrealScriptStructProxyArrayProcessor<SAiRaceStrategyOneParamFunction> SAiRaceStrategyOneParamFunction_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SAiRaceStrategyOneParamFunction>();
			}
		}

		// Token: 0x17002D46 RID: 11590
		// (get) Token: 0x0601CB33 RID: 117555 RVA: 0x008C3427 File Offset: 0x008C1627
		private static UnrealScriptStructProxyArrayProcessor<SCameraDebugTool_CameraFrameInfo> SCameraDebugTool_CameraFrameInfo_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SCameraDebugTool_CameraFrameInfo>();
			}
		}

		// Token: 0x17002D47 RID: 11591
		// (get) Token: 0x0601CB34 RID: 117556 RVA: 0x008C342E File Offset: 0x008C162E
		private static UnrealScriptStructProxyArrayProcessor<SCameraDebugTool_CameraProperty> SCameraDebugTool_CameraProperty_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SCameraDebugTool_CameraProperty>();
			}
		}

		// Token: 0x17002D48 RID: 11592
		// (get) Token: 0x0601CB35 RID: 117557 RVA: 0x008C3435 File Offset: 0x008C1635
		private static UnrealScriptStructProxyArrayProcessor<SCameraDebugTool_ControllerModification> SCameraDebugTool_ControllerModification_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SCameraDebugTool_ControllerModification>();
			}
		}

		// Token: 0x17002D49 RID: 11593
		// (get) Token: 0x0601CB36 RID: 117558 RVA: 0x008C343C File Offset: 0x008C163C
		private static UnrealScriptStructProxyArrayProcessor<SCameraDebugTool_SubCameraModification> SCameraDebugTool_SubCameraModification_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SCameraDebugTool_SubCameraModification>();
			}
		}

		// Token: 0x17002D4A RID: 11594
		// (get) Token: 0x0601CB37 RID: 117559 RVA: 0x008C3443 File Offset: 0x008C1643
		private static UnrealScriptStructProxyArrayProcessor<SVectorArray> SVectorArray_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SVectorArray>();
			}
		}

		// Token: 0x17002D4B RID: 11595
		// (get) Token: 0x0601CB38 RID: 117560 RVA: 0x008C344A File Offset: 0x008C164A
		private static UnrealScriptStructProxyArrayProcessor<SDecorationConfig_Effect> SDecorationConfig_Effect_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SDecorationConfig_Effect>();
			}
		}

		// Token: 0x17002D4C RID: 11596
		// (get) Token: 0x0601CB39 RID: 117561 RVA: 0x008C3451 File Offset: 0x008C1651
		private static UnrealScriptStructProxyArrayProcessor<SModelChildMeshConfig> SModelChildMeshConfig_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SModelChildMeshConfig>();
			}
		}

		// Token: 0x17002D4D RID: 11597
		// (get) Token: 0x0601CB3A RID: 117562 RVA: 0x008C3458 File Offset: 0x008C1658
		private static UnrealScriptStructProxyArrayProcessor<SModelDecorationConfig> SModelDecorationConfig_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SModelDecorationConfig>();
			}
		}

		// Token: 0x17002D4E RID: 11598
		// (get) Token: 0x0601CB3B RID: 117563 RVA: 0x008C345F File Offset: 0x008C165F
		private static UnrealScriptStructProxyArrayProcessor<SAimPart> SAimPart_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SAimPart>();
			}
		}

		// Token: 0x17002D4F RID: 11599
		// (get) Token: 0x0601CB3C RID: 117564 RVA: 0x008C3466 File Offset: 0x008C1666
		private static UnrealScriptStructProxyArrayProcessor<SFollowShooterTagConfig> SFollowShooterTagConfig_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SFollowShooterTagConfig>();
			}
		}

		// Token: 0x17002D50 RID: 11600
		// (get) Token: 0x0601CB3D RID: 117565 RVA: 0x008C346D File Offset: 0x008C166D
		private static UnrealScriptStructProxyArrayProcessor<SLockOnFollowShooterAutoAim> SLockOnFollowShooterAutoAim_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SLockOnFollowShooterAutoAim>();
			}
		}

		// Token: 0x17002D51 RID: 11601
		// (get) Token: 0x0601CB3E RID: 117566 RVA: 0x008C3474 File Offset: 0x008C1674
		private static UnrealScriptStructProxyArrayProcessor<SLockOnPart> SLockOnPart_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SLockOnPart>();
			}
		}

		// Token: 0x17002D52 RID: 11602
		// (get) Token: 0x0601CB3F RID: 117567 RVA: 0x008C347B File Offset: 0x008C167B
		private static UnrealScriptStructProxyArrayProcessor<SPartHitEffect> SPartHitEffect_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SPartHitEffect>();
			}
		}

		// Token: 0x17002D53 RID: 11603
		// (get) Token: 0x0601CB40 RID: 117568 RVA: 0x008C3482 File Offset: 0x008C1682
		private static UnrealScriptStructProxyArrayProcessor<SSkillMontage> SSkillMontage_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SSkillMontage>();
			}
		}

		// Token: 0x17002D54 RID: 11604
		// (get) Token: 0x0601CB41 RID: 117569 RVA: 0x008C3489 File Offset: 0x008C1689
		private static UnrealScriptStructProxyArrayProcessor<SPanelQteAction> SPanelQteAction_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SPanelQteAction>();
			}
		}

		// Token: 0x17002D55 RID: 11605
		// (get) Token: 0x0601CB42 RID: 117570 RVA: 0x008C3490 File Offset: 0x008C1690
		private static UnrealScriptStructProxyArrayProcessor<RhythmGameSpeedLevelConfig> RhythmGameSpeedLevelConfig_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<RhythmGameSpeedLevelConfig>();
			}
		}

		// Token: 0x17002D56 RID: 11606
		// (get) Token: 0x0601CB43 RID: 117571 RVA: 0x008C3497 File Offset: 0x008C1697
		private static UnrealScriptStructProxyArrayProcessor<SZoneFollowCameraZoneSetting> SZoneFollowCameraZoneSetting_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SZoneFollowCameraZoneSetting>();
			}
		}

		// Token: 0x17002D57 RID: 11607
		// (get) Token: 0x0601CB44 RID: 117572 RVA: 0x008C349E File Offset: 0x008C169E
		private static UnrealScriptStructProxyArrayProcessor<SInteractionOption> SInteractionOption_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SInteractionOption>();
			}
		}

		// Token: 0x17002D58 RID: 11608
		// (get) Token: 0x0601CB45 RID: 117573 RVA: 0x008C34A5 File Offset: 0x008C16A5
		private static UnrealScriptStructProxyArrayProcessor<SRoleSwingConfig> SRoleSwingConfig_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SRoleSwingConfig>();
			}
		}

		// Token: 0x17002D59 RID: 11609
		// (get) Token: 0x0601CB46 RID: 117574 RVA: 0x008C34AC File Offset: 0x008C16AC
		private static UnrealScriptStructProxyArrayProcessor<SFloatThresholdAndCameraShake> SFloatThresholdAndCameraShake_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SFloatThresholdAndCameraShake>();
			}
		}

		// Token: 0x17002D5A RID: 11610
		// (get) Token: 0x0601CB47 RID: 117575 RVA: 0x008C34B3 File Offset: 0x008C16B3
		private static UnrealScriptStructProxyArrayProcessor<SimpleNpcFlowData> SimpleNpcFlowData_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SimpleNpcFlowData>();
			}
		}

		// Token: 0x17002D5B RID: 11611
		// (get) Token: 0x0601CB48 RID: 117576 RVA: 0x008C34BA File Offset: 0x008C16BA
		private static UnrealScriptStructProxyArrayProcessor<SBattleQteAction> SBattleQteAction_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SBattleQteAction>();
			}
		}

		// Token: 0x17002D5C RID: 11612
		// (get) Token: 0x0601CB49 RID: 117577 RVA: 0x008C34C1 File Offset: 0x008C16C1
		private static UnrealScriptStructProxyArrayProcessor<SCommonQteButton> SCommonQteButton_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SCommonQteButton>();
			}
		}

		// Token: 0x17002D5D RID: 11613
		// (get) Token: 0x0601CB4A RID: 117578 RVA: 0x008C34C8 File Offset: 0x008C16C8
		private static UnrealScriptStructProxyArrayProcessor<SQtaCustomizationParam_BgBar> SQtaCustomizationParam_BgBar_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SQtaCustomizationParam_BgBar>();
			}
		}

		// Token: 0x17002D5E RID: 11614
		// (get) Token: 0x0601CB4B RID: 117579 RVA: 0x008C34CF File Offset: 0x008C16CF
		private static UnrealScriptStructProxyArrayProcessor<SQtaCustomizationParam_Event> SQtaCustomizationParam_Event_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SQtaCustomizationParam_Event>();
			}
		}

		// Token: 0x17002D5F RID: 11615
		// (get) Token: 0x0601CB4C RID: 117580 RVA: 0x008C34D6 File Offset: 0x008C16D6
		private static UnrealScriptStructProxyArrayProcessor<SQtaCondition_Content> SQtaCondition_Content_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SQtaCondition_Content>();
			}
		}

		// Token: 0x17002D60 RID: 11616
		// (get) Token: 0x0601CB4D RID: 117581 RVA: 0x008C34DD File Offset: 0x008C16DD
		private static UnrealScriptStructProxyArrayProcessor<SQtaPrompt> SQtaPrompt_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SQtaPrompt>();
			}
		}

		// Token: 0x17002D61 RID: 11617
		// (get) Token: 0x0601CB4E RID: 117582 RVA: 0x008C34E4 File Offset: 0x008C16E4
		private static UnrealScriptStructProxyArrayProcessor<SQtaResultAction> SQtaResultAction_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SQtaResultAction>();
			}
		}

		// Token: 0x17002D62 RID: 11618
		// (get) Token: 0x0601CB4F RID: 117583 RVA: 0x008C34EB File Offset: 0x008C16EB
		private static UnrealScriptStructProxyArrayProcessor<SpineThingsInfo> SpineThingsInfo_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SpineThingsInfo>();
			}
		}

		// Token: 0x17002D63 RID: 11619
		// (get) Token: 0x0601CB50 RID: 117584 RVA: 0x008C34F2 File Offset: 0x008C16F2
		private static UnrealScriptStructProxyArrayProcessor<SServerInfo> SServerInfo_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SServerInfo>();
			}
		}

		// Token: 0x17002D64 RID: 11620
		// (get) Token: 0x0601CB51 RID: 117585 RVA: 0x008C34F9 File Offset: 0x008C16F9
		private static UnrealScriptStructProxyArrayProcessor<SMaterialControllerColorParameter> SMaterialControllerColorParameter_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SMaterialControllerColorParameter>();
			}
		}

		// Token: 0x17002D65 RID: 11621
		// (get) Token: 0x0601CB52 RID: 117586 RVA: 0x008C3500 File Offset: 0x008C1700
		private static UnrealScriptStructProxyArrayProcessor<SMaterialControllerFloatParameter> SMaterialControllerFloatParameter_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SMaterialControllerFloatParameter>();
			}
		}

		// Token: 0x17002D66 RID: 11622
		// (get) Token: 0x0601CB53 RID: 117587 RVA: 0x008C3507 File Offset: 0x008C1707
		private static UnrealScriptStructProxyArrayProcessor<SMaterialControllerTextureParameter> SMaterialControllerTextureParameter_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SMaterialControllerTextureParameter>();
			}
		}

		// Token: 0x17002D67 RID: 11623
		// (get) Token: 0x0601CB54 RID: 117588 RVA: 0x008C350E File Offset: 0x008C170E
		private static UnrealScriptStructProxyArrayProcessor<SNpcChildPart> SNpcChildPart_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SNpcChildPart>();
			}
		}

		// Token: 0x17002D68 RID: 11624
		// (get) Token: 0x0601CB55 RID: 117589 RVA: 0x008C3515 File Offset: 0x008C1715
		private static UnrealScriptStructProxyArrayProcessor<SNpcHookPart> SNpcHookPart_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SNpcHookPart>();
			}
		}

		// Token: 0x17002D69 RID: 11625
		// (get) Token: 0x0601CB56 RID: 117590 RVA: 0x008C351C File Offset: 0x008C171C
		private static UnrealScriptStructProxyArrayProcessor<SNpcHookPartMaterial> SNpcHookPartMaterial_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SNpcHookPartMaterial>();
			}
		}

		// Token: 0x17002D6A RID: 11626
		// (get) Token: 0x0601CB57 RID: 117591 RVA: 0x008C3523 File Offset: 0x008C1723
		private static UnrealScriptStructProxyArrayProcessor<SFoliageClusteredEffectEntry> SFoliageClusteredEffectEntry_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SFoliageClusteredEffectEntry>();
			}
		}

		// Token: 0x17002D6B RID: 11627
		// (get) Token: 0x0601CB58 RID: 117592 RVA: 0x008C352A File Offset: 0x008C172A
		private static UnrealScriptStructProxyArrayProcessor<SWaterEffectGroup> SWaterEffectGroup_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SWaterEffectGroup>();
			}
		}

		// Token: 0x17002D6C RID: 11628
		// (get) Token: 0x0601CB59 RID: 117593 RVA: 0x008C3531 File Offset: 0x008C1731
		private static UnrealScriptStructProxyArrayProcessor<SWaterEffectItem> SWaterEffectItem_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SWaterEffectItem>();
			}
		}

		// Token: 0x17002D6D RID: 11629
		// (get) Token: 0x0601CB5A RID: 117594 RVA: 0x008C3538 File Offset: 0x008C1738
		private static UnrealScriptStructProxyArrayProcessor<SSceneInteractionCrossStateEffect> SSceneInteractionCrossStateEffect_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SSceneInteractionCrossStateEffect>();
			}
		}

		// Token: 0x17002D6E RID: 11630
		// (get) Token: 0x0601CB5B RID: 117595 RVA: 0x008C353F File Offset: 0x008C173F
		private static UnrealScriptStructProxyArrayProcessor<SSceneInteractionMaterialController> SSceneInteractionMaterialController_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SSceneInteractionMaterialController>();
			}
		}

		// Token: 0x17002D6F RID: 11631
		// (get) Token: 0x0601CB5C RID: 117596 RVA: 0x008C3546 File Offset: 0x008C1746
		private static UnrealScriptStructProxyArrayProcessor<SStateBasedEffect> SStateBasedEffect_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SStateBasedEffect>();
			}
		}

		// Token: 0x17002D70 RID: 11632
		// (get) Token: 0x0601CB5D RID: 117597 RVA: 0x008C354D File Offset: 0x008C174D
		private static UnrealScriptStructProxyArrayProcessor<SSequencesKeyFrames> SSequencesKeyFrames_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<SSequencesKeyFrames>();
			}
		}

		// Token: 0x17002D71 RID: 11633
		// (get) Token: 0x0601CB5E RID: 117598 RVA: 0x008C3554 File Offset: 0x008C1754
		private static UnrealScriptStructProxyArrayProcessor<BvbCardItemData> BvbCardItemData_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<BvbCardItemData>();
			}
		}

		// Token: 0x17002D72 RID: 11634
		// (get) Token: 0x0601CB5F RID: 117599 RVA: 0x008C355B File Offset: 0x008C175B
		private static UnrealScriptStructProxyArrayProcessor<BvbEffectItemData> BvbEffectItemData_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<BvbEffectItemData>();
			}
		}
	}
}
