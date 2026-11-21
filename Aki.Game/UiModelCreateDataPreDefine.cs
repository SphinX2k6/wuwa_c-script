using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020021C7 RID: 8647
public class UiModelCreateDataPreDefine : IStaticVariableResetter
{
	// Token: 0x06015494 RID: 87188 RVA: 0x00630169 File Offset: 0x0062E369
	static UiModelCreateDataPreDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiModelCreateDataPreDefine.CreateStaticDefaultValue), new Action(UiModelCreateDataPreDefine.ResetStaticDefaultValue));
	}

	// Token: 0x06015495 RID: 87189 RVA: 0x00630188 File Offset: 0x0062E388
	[NullableContext(1)]
	public static Dictionary<EUiModelUseWay, UiModelCreateData> GetUiModelCreateDataPreDefine()
	{
		if (UiModelCreateDataPreDefine.uiModelCreateDataPreDefine == null)
		{
			Dictionary<EUiModelUseWay, UiModelCreateData> dictionary = new Dictionary<EUiModelUseWay, UiModelCreateData>();
			dictionary[EUiModelUseWay.RoleInLogin] = new UiModelCreateData(EUiModelType.Role, EUiModelActorType.TsUiSceneRoleActor, EUiModelUseWay.RoleInLogin, new Type[]
			{
				typeof(UiModelDataComponent),
				typeof(UiModelActorComponent),
				typeof(UiModelEffectComponent),
				typeof(UiModelRenderingMaterialComponent),
				typeof(UiModelAnsControllerComponent),
				typeof(UiRoleDataComponent),
				typeof(UiRoleHuluComponent),
				typeof(UiRoleLoadComponent),
				typeof(UiRoleStateMachineComponent),
				typeof(UiModelTagComponent)
			});
			dictionary[EUiModelUseWay.RoleInRoleView] = new UiModelCreateData(EUiModelType.Role, EUiModelActorType.TsUiSceneRoleActor, EUiModelUseWay.RoleInRoleView, new Type[]
			{
				typeof(UiModelDataComponent),
				typeof(UiModelActorComponent),
				typeof(UiModelLoadingIconComponent),
				typeof(UiModelEffectComponent),
				typeof(UiModelRenderingMaterialComponent),
				typeof(UiModelAnsControllerComponent),
				typeof(UiModelFadeComponent),
				typeof(UiModelTagComponent),
				typeof(UiRoleDataComponent),
				typeof(UiRoleLoadComponent),
				typeof(UiRoleStateMachineComponent),
				typeof(UiRoleWeaponComponent),
				typeof(UiRoleHuluComponent),
				typeof(UiRoleEyeHighLightComponent),
				typeof(UiRoleHuluLightSequenceComponent),
				typeof(UiRoleBuffComponent),
				typeof(UiRoleMorphComponent),
				typeof(UiRoleOrnamentComponent),
				typeof(UiRoleSpecialCaseComponent)
			});
			dictionary[EUiModelUseWay.WeaponOnRole] = new UiModelCreateData(EUiModelType.Weapon, EUiModelActorType.TsSkeletalObserver, EUiModelUseWay.WeaponOnRole, new Type[]
			{
				typeof(UiModelDataComponent),
				typeof(UiModelActorComponent),
				typeof(UiModelLoadComponent),
				typeof(UiModelEffectComponent),
				typeof(UiModelRenderingMaterialComponent),
				typeof(UiModelAnsControllerComponent),
				typeof(UiWeaponDataComponent),
				typeof(UiWeaponLevelMaterialComponent)
			});
			dictionary[EUiModelUseWay.WeaponInWeaponView] = new UiModelCreateData(EUiModelType.Weapon, EUiModelActorType.TsSkeletalObserver, EUiModelUseWay.WeaponInWeaponView, new Type[]
			{
				typeof(UiModelDataComponent),
				typeof(UiModelActorComponent),
				typeof(UiModelLoadComponent),
				typeof(UiModelEffectComponent),
				typeof(UiModelRenderingMaterialComponent),
				typeof(UiModelAnsControllerComponent),
				typeof(UiModelRotateComponent),
				typeof(UiWeaponDataComponent),
				typeof(UiWeaponLevelMaterialComponent)
			});
			dictionary[EUiModelUseWay.WeaponWithLoadingIcon] = new UiModelCreateData(EUiModelType.Weapon, EUiModelActorType.TsSkeletalObserver, EUiModelUseWay.WeaponWithLoadingIcon, new Type[]
			{
				typeof(UiModelDataComponent),
				typeof(UiModelActorComponent),
				typeof(UiModelLoadComponent),
				typeof(UiModelLoadingIconComponent),
				typeof(UiModelEffectComponent),
				typeof(UiModelRenderingMaterialComponent),
				typeof(UiModelAnsControllerComponent),
				typeof(UiModelRotateComponent),
				typeof(UiWeaponDataComponent),
				typeof(UiWeaponLevelMaterialComponent)
			});
			dictionary[EUiModelUseWay.HuluOnRole] = new UiModelCreateData(EUiModelType.Hulu, EUiModelActorType.TsSkeletalObserver, EUiModelUseWay.HuluOnRole, new Type[]
			{
				typeof(UiModelDataComponent),
				typeof(UiModelActorComponent),
				typeof(UiModelLoadComponent),
				typeof(UiModelRotateComponent),
				typeof(UiModelRenderingMaterialComponent),
				typeof(UiHuluSkinDataComponent)
			});
			dictionary[EUiModelUseWay.HuluInSkinView] = new UiModelCreateData(EUiModelType.Hulu, EUiModelActorType.TsSkeletalObserver, EUiModelUseWay.HuluInSkinView, new Type[]
			{
				typeof(UiModelDataComponent),
				typeof(UiModelLoadingIconComponent),
				typeof(UiModelActorComponent),
				typeof(UiModelLoadComponent),
				typeof(UiModelRotateComponent),
				typeof(UiModelRenderingMaterialComponent),
				typeof(UiHuluSkinDataComponent),
				typeof(UiModelEffectComponent),
				typeof(UiModelAnsControllerComponent)
			});
			dictionary[EUiModelUseWay.VisionInHandleBook] = new UiModelCreateData(EUiModelType.Vision, EUiModelActorType.TsSkeletalObserver, EUiModelUseWay.VisionInHandleBook, new Type[]
			{
				typeof(UiModelDataComponent),
				typeof(UiModelActorComponent)
			});
			dictionary[EUiModelUseWay.VisionInRoleView] = new UiModelCreateData(EUiModelType.Vision, EUiModelActorType.TsSkeletalObserver, EUiModelUseWay.VisionInRoleView, new Type[]
			{
				typeof(UiModelDataComponent),
				typeof(UiModelActorComponent),
				typeof(UiModelLoadComponent),
				typeof(UiModelLoadingIconComponent),
				typeof(UiModelRenderingMaterialComponent),
				typeof(UiModelEffectComponent),
				typeof(UiModelAnimationComponent),
				typeof(UiModelAnsControllerComponent)
			});
			dictionary[EUiModelUseWay.RoleInRogueView] = new UiModelCreateData(EUiModelType.Role, EUiModelActorType.TsUiSceneRoleActor, EUiModelUseWay.RoleInRogueView, new Type[]
			{
				typeof(UiModelDataComponent),
				typeof(UiModelActorComponent),
				typeof(UiModelEffectComponent),
				typeof(UiModelRenderingMaterialComponent),
				typeof(UiModelAnsControllerComponent),
				typeof(UiRoleDataComponent),
				typeof(UiRoleLoadComponent),
				typeof(UiModelLoadingIconComponent),
				typeof(UiRoleStateMachineComponent),
				typeof(UiModelTagComponent),
				typeof(UiRoleOrnamentComponent),
				typeof(UiRoleBuffComponent),
				typeof(UiRoleSpecialCaseComponent)
			});
			dictionary[EUiModelUseWay.RoleInDreamLinkView] = new UiModelCreateData(EUiModelType.Role, EUiModelActorType.TsUiSceneRoleActor, EUiModelUseWay.RoleInDreamLinkView, new Type[]
			{
				typeof(UiModelDataComponent),
				typeof(UiModelActorComponent),
				typeof(UiModelRenderingMaterialComponent),
				typeof(UiModelEffectComponent),
				typeof(UiModelAnimationComponent),
				typeof(UiModelAnsControllerComponent),
				typeof(UiRoleLoadComponent),
				typeof(UiRoleDataComponent),
				typeof(UiModelTagComponent),
				typeof(UiRoleOrnamentComponent),
				typeof(UiRoleBuffComponent),
				typeof(UiRoleSpecialCaseComponent)
			});
			dictionary[EUiModelUseWay.WeaponInDreamLinkView] = new UiModelCreateData(EUiModelType.Weapon, EUiModelActorType.TsSkeletalObserver, EUiModelUseWay.WeaponInDreamLinkView, new Type[]
			{
				typeof(UiModelDataComponent),
				typeof(UiModelActorComponent),
				typeof(UiModelLoadComponent),
				typeof(UiModelAnimationComponent),
				typeof(UiModelRenderingMaterialComponent),
				typeof(UiModelEffectComponent),
				typeof(UiModelAnsControllerComponent),
				typeof(UiModelRotateComponent)
			});
			dictionary[EUiModelUseWay.RoleInSkinView] = new UiModelCreateData(EUiModelType.Role, EUiModelActorType.TsUiSceneRoleActor, EUiModelUseWay.RoleInSkinView, new Type[]
			{
				typeof(UiModelDataComponent),
				typeof(UiModelActorComponent),
				typeof(UiModelLoadComponent),
				typeof(UiModelAnimationComponent),
				typeof(UiModelRenderingMaterialComponent),
				typeof(UiModelEffectComponent),
				typeof(UiModelAnsControllerComponent),
				typeof(UiModelRotateComponent),
				typeof(UiRoleWeaponComponent),
				typeof(UiRoleDataComponent),
				typeof(UiRoleStateMachineComponent),
				typeof(UiRoleLoadComponent),
				typeof(UiModelFadeComponent),
				typeof(UiModelTagComponent),
				typeof(UiRoleOrnamentComponent),
				typeof(UiRoleBuffComponent),
				typeof(UiRoleSpecialCaseComponent)
			});
			dictionary[EUiModelUseWay.VisionInLordGymView] = new UiModelCreateData(EUiModelType.Vision, EUiModelActorType.TsSkeletalObserver, EUiModelUseWay.VisionInRoleView, new Type[]
			{
				typeof(UiModelDataComponent),
				typeof(UiModelActorComponent),
				typeof(UiModelLoadComponent),
				typeof(UiModelLoadingIconComponent),
				typeof(UiModelRenderingMaterialComponent),
				typeof(UiModelEffectComponent),
				typeof(UiModelAnimationComponent),
				typeof(UiModelAnsControllerComponent)
			});
			dictionary[EUiModelUseWay.AdamSmasher] = new UiModelCreateData(EUiModelType.Vision, EUiModelActorType.TsSkeletalObserver, EUiModelUseWay.AdamSmasher, new Type[]
			{
				typeof(UiModelDataComponent),
				typeof(UiModelActorComponent),
				typeof(UiModelLoadComponent),
				typeof(UiModelLoadingIconComponent),
				typeof(UiModelRenderingMaterialComponent),
				typeof(UiModelEffectComponent),
				typeof(UiModelAnimationComponent),
				typeof(UiModelAnsControllerComponent)
			});
			dictionary[EUiModelUseWay.Dango] = new UiModelCreateData(EUiModelType.Dango, EUiModelActorType.TsUiSceneDangoActor, EUiModelUseWay.Dango, new Type[]
			{
				typeof(UiModelDataComponent),
				typeof(UiDangoDataComponent),
				typeof(UiModelActorComponent),
				typeof(UiDangoLoadComponent),
				typeof(UiModelEffectComponent),
				typeof(UiModelFadeComponent),
				typeof(UiDangoStateMachineComponent),
				typeof(UiModelAnsControllerComponent)
			});
			dictionary[EUiModelUseWay.OddsDango] = new UiModelCreateData(EUiModelType.Dango, EUiModelActorType.TsUiSceneDangoActor, EUiModelUseWay.OddsDango, new Type[]
			{
				typeof(UiModelDataComponent),
				typeof(UiDangoDataComponent),
				typeof(UiModelActorComponent),
				typeof(UiDangoLoadComponent),
				typeof(UiModelEffectComponent),
				typeof(UiModelFadeComponent),
				typeof(UiDangoStateMachineComponent),
				typeof(UiModelAnsControllerComponent),
				typeof(UiDangoOddsComponent),
				typeof(UiDangoCollisionComponent),
				typeof(UiDangoMaterialChangeComponent)
			});
			dictionary[EUiModelUseWay.AbyssDango] = new UiModelCreateData(EUiModelType.Dango, EUiModelActorType.TsUiSceneDangoActor, EUiModelUseWay.AbyssDango, new Type[]
			{
				typeof(UiModelDataComponent),
				typeof(UiDangoDataComponent),
				typeof(UiModelActorComponent),
				typeof(UiAbyssDangoLoadComponent),
				typeof(UiModelLoadingIconComponent),
				typeof(UiModelEffectComponent),
				typeof(UiModelAnimationComponent),
				typeof(UiModelAnsControllerComponent)
			});
			dictionary[EUiModelUseWay.BrawlDango] = new UiModelCreateData(EUiModelType.Dango, EUiModelActorType.TsUiSceneDangoActor, EUiModelUseWay.BrawlDango, new Type[]
			{
				typeof(UiModelDataComponent),
				typeof(UiDangoDataComponent),
				typeof(UiModelActorComponent),
				typeof(UiModelLoadComponent),
				typeof(UiModelLoadingIconComponent),
				typeof(UiModelEffectComponent),
				typeof(UiModelAnimationComponent),
				typeof(UiModelAnsControllerComponent)
			});
			dictionary[EUiModelUseWay.GliderInSkinView] = new UiModelCreateData(EUiModelType.Glider, EUiModelActorType.TsSkeletalObserver, EUiModelUseWay.GliderInSkinView, new Type[]
			{
				typeof(UiModelDataComponent),
				typeof(UiModelActorComponent),
				typeof(UiModelLoadComponent),
				typeof(UiModelLoadingIconComponent),
				typeof(UiModelEffectComponent),
				typeof(UiModelRenderingMaterialComponent),
				typeof(UiModelAnimationComponent),
				typeof(UiModelAnsControllerComponent)
			});
			dictionary[EUiModelUseWay.SpecialItemSummonInSkinView] = new UiModelCreateData(EUiModelType.SpecialItemSummon, EUiModelActorType.TsSkeletalObserver, EUiModelUseWay.SpecialItemSummonInSkinView, new Type[]
			{
				typeof(UiModelDataComponent),
				typeof(UiModelActorComponent),
				typeof(UiModelLoadComponent),
				typeof(UiModelLoadingIconComponent),
				typeof(UiModelEffectComponent),
				typeof(UiModelRenderingMaterialComponent),
				typeof(UiModelAnimationComponent),
				typeof(UiModelAnsControllerComponent)
			});
			dictionary[EUiModelUseWay.MotorInMotorView] = new UiModelCreateData(EUiModelType.Motor, EUiModelActorType.TsSkeletalObserver, EUiModelUseWay.MotorInMotorView, new Type[]
			{
				typeof(UiModelDataComponent),
				typeof(UiModelActorComponent),
				typeof(UiModelLoadComponent),
				typeof(UiModelLoadingIconComponent),
				typeof(UiModelEffectComponent),
				typeof(UiModelAnimationComponent),
				typeof(UiModelAnsControllerComponent),
				typeof(UiModelRenderingMaterialComponent),
				typeof(UiModelRotateComponent),
				typeof(UiModelInputDataComponent),
				typeof(UiModelControlRotateComponent),
				typeof(UiModelBuffComponent),
				typeof(UiMotorDataComponent),
				typeof(UiMotorLoadComponent),
				typeof(UiMotorStickerComponent),
				typeof(UiMotorDecorationComponent),
				typeof(UiMotorSoarWingComponent)
			});
			dictionary[EUiModelUseWay.MotorDecorationOnMotor] = new UiModelCreateData(EUiModelType.MotorDecoration, EUiModelActorType.TsSkeletalObserver, EUiModelUseWay.MotorDecorationOnMotor, new Type[]
			{
				typeof(UiModelDataComponent),
				typeof(UiModelActorComponent),
				typeof(UiDecorationLoadComponent),
				typeof(UiModelLoadingIconComponent),
				typeof(UiModelEffectComponent),
				typeof(UiModelAnsControllerComponent),
				typeof(UiModelRenderingMaterialComponent)
			});
			dictionary[EUiModelUseWay.MotorSoarWingOnMotor] = new UiModelCreateData(EUiModelType.MotorSoarWing, EUiModelActorType.TsSkeletalObserver, EUiModelUseWay.MotorSoarWingOnMotor, new Type[]
			{
				typeof(UiModelDataComponent),
				typeof(UiModelActorComponent),
				typeof(UiDecorationLoadComponent),
				typeof(UiModelEffectComponent),
				typeof(UiModelAnsControllerComponent)
			});
			dictionary[EUiModelUseWay.MotorTakeRole] = new UiModelCreateData(EUiModelType.Motor, EUiModelActorType.TsSkeletalObserver, EUiModelUseWay.MotorTakeRole, new Type[]
			{
				typeof(UiModelDataComponent),
				typeof(UiModelActorComponent),
				typeof(UiModelLoadComponent),
				typeof(UiModelLoadingIconComponent),
				typeof(UiModelEffectComponent),
				typeof(UiModelAnimationComponent),
				typeof(UiModelAnsControllerComponent),
				typeof(UiModelRenderingMaterialComponent),
				typeof(UiModelRotateComponent),
				typeof(UiModelBuffComponent),
				typeof(UiMotorDataComponent),
				typeof(UiMotorLoadComponent),
				typeof(UiMotorStickerComponent),
				typeof(UiMotorDecorationComponent),
				typeof(UiMotorSoarWingComponent),
				typeof(UiMotorRoleComponent)
			});
			dictionary[EUiModelUseWay.RoleOnMotor] = new UiModelCreateData(EUiModelType.Role, EUiModelActorType.TsUiSceneRoleActor, EUiModelUseWay.RoleOnMotor, new Type[]
			{
				typeof(UiModelDataComponent),
				typeof(UiModelActorComponent),
				typeof(UiModelLoadingIconComponent),
				typeof(UiModelRenderingMaterialComponent),
				typeof(UiModelEffectComponent),
				typeof(UiModelAnimationComponent),
				typeof(UiModelAnsControllerComponent),
				typeof(UiRoleLoadComponent),
				typeof(UiRoleDataComponent),
				typeof(UiModelTagComponent),
				typeof(UiRoleOrnamentComponent),
				typeof(UiRoleBuffComponent),
				typeof(UiRoleSpecialCaseComponent)
			});
			dictionary[EUiModelUseWay.RoleInEquipBuffItemPreview] = new UiModelCreateData(EUiModelType.Role, EUiModelActorType.TsUiSceneRoleActor, EUiModelUseWay.RoleInEquipBuffItemPreview, new Type[]
			{
				typeof(UiModelDataComponent),
				typeof(UiModelActorComponent),
				typeof(UiModelLoadComponent),
				typeof(UiModelAnimationComponent),
				typeof(UiModelRenderingMaterialComponent),
				typeof(UiModelEffectComponent),
				typeof(UiModelAnsControllerComponent),
				typeof(UiModelRotateComponent),
				typeof(UiRoleWeaponComponent),
				typeof(UiRoleDataComponent),
				typeof(UiRoleStateMachineComponent),
				typeof(UiRoleLoadComponent),
				typeof(UiModelFadeComponent),
				typeof(UiRoleBuffPreviewComponent),
				typeof(UiModelTagComponent),
				typeof(UiRoleOrnamentComponent),
				typeof(UiRoleBuffComponent),
				typeof(UiRoleSpecialCaseComponent)
			});
			dictionary[EUiModelUseWay.RoleInFormation] = new UiModelCreateData(EUiModelType.Role, EUiModelActorType.TsUiSceneRoleActor, EUiModelUseWay.RoleInFormation, new Type[]
			{
				typeof(UiModelDataComponent),
				typeof(UiModelActorComponent),
				typeof(UiModelLoadingIconComponent),
				typeof(UiFormationRoleLoadComponent),
				typeof(UiModelAnimationComponent),
				typeof(UiModelRenderingMaterialComponent),
				typeof(UiModelEffectComponent),
				typeof(UiModelAnsControllerComponent),
				typeof(UiRoleDataComponent),
				typeof(UiFormationRoleDataComponent),
				typeof(UiRoleWeaponComponent),
				typeof(UiModelFadeComponent),
				typeof(UiModelTagComponent),
				typeof(UiRoleOrnamentComponent),
				typeof(UiRoleBuffComponent),
				typeof(UiRoleSpecialCaseComponent)
			});
			dictionary[EUiModelUseWay.OrnamentOnRole] = new UiModelCreateData(EUiModelType.RoleOrnament, EUiModelActorType.TsSkeletalObserver, EUiModelUseWay.OrnamentOnRole, new Type[]
			{
				typeof(UiModelDataComponent),
				typeof(UiModelActorComponent),
				typeof(UiModelLoadComponent),
				typeof(UiModelEffectComponent),
				typeof(UiModelRenderingMaterialComponent),
				typeof(UiModelAnsControllerComponent),
				typeof(UiDecorationLoadComponent)
			});
			UiModelCreateDataPreDefine.uiModelCreateDataPreDefine = dictionary;
		}
		return UiModelCreateDataPreDefine.uiModelCreateDataPreDefine;
	}

	// Token: 0x06015496 RID: 87190 RVA: 0x0063139D File Offset: 0x0062F59D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06015497 RID: 87191 RVA: 0x0063139F File Offset: 0x0062F59F
	public static void ResetStaticDefaultValue()
	{
		UiModelCreateDataPreDefine.uiModelCreateDataPreDefine = null;
	}

	// Token: 0x0400B484 RID: 46212
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<EUiModelUseWay, UiModelCreateData> uiModelCreateDataPreDefine;
}
