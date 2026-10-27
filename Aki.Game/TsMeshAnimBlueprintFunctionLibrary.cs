using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Audio;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using CSharpScript.Game.Utils;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002E43 RID: 11843
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsMeshAnimBlueprintFunctionLibrary.TsMeshAnimBlueprintFunctionLibrary_C")]
public class TsMeshAnimBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x060192F0 RID: 103152 RVA: 0x0067B7A5 File Offset: 0x006799A5
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static UAnimInstance MainAnimInstance(int entityId)
	{
		CharacterAnimationComponent component = EntitySystem.Instance.GetComponent<CharacterAnimationComponent>(entityId);
		if (component == null)
		{
			return null;
		}
		return component.MainAnimInstance;
	}

	// Token: 0x060192F1 RID: 103153 RVA: 0x0067B7BD File Offset: 0x006799BD
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static UAnimInstance MainAnimInstanceForVehicle(int entityId)
	{
		VehicleAnimationComponent component = EntitySystem.Instance.GetComponent<VehicleAnimationComponent>(entityId);
		if (component == null)
		{
			return null;
		}
		return component.MainAnimInstance;
	}

	// Token: 0x060192F2 RID: 103154 RVA: 0x0067B7D8 File Offset: 0x006799D8
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static FVector GetSightDirect(int entityId)
	{
		BaseAnimationComponent component = EntitySystem.Instance.GetComponent<BaseAnimationComponent>(entityId);
		if (component == null)
		{
			return FVector.ZeroVector;
		}
		return component.GetSightDirect();
	}

	// Token: 0x060192F3 RID: 103155 RVA: 0x0067B800 File Offset: 0x00679A00
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetHeadBaseYawBuffer(int entityId)
	{
		BaseAnimationComponent component = EntitySystem.Instance.GetComponent<BaseAnimationComponent>(entityId);
		if (component == null)
		{
			return 0f;
		}
		return component.GetHeadBaseYawBuffer();
	}

	// Token: 0x060192F4 RID: 103156 RVA: 0x0067B81C File Offset: 0x00679A1C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static UMeshComponent GetHulu(int entityId)
	{
		CharacterWeaponComponent component = EntitySystem.Instance.GetComponent<CharacterWeaponComponent>(entityId);
		if (component == null)
		{
			return null;
		}
		return component.Hulu;
	}

	// Token: 0x060192F5 RID: 103157 RVA: 0x0067B834 File Offset: 0x00679A34
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetBattleIdleTime(int entityId)
	{
		CharacterAnimationComponent component = EntitySystem.Instance.GetComponent<CharacterAnimationComponent>(entityId);
		if (component == null)
		{
			return 0f;
		}
		return component.BattleIdleEndTime;
	}

	// Token: 0x060192F6 RID: 103158 RVA: 0x0067B850 File Offset: 0x00679A50
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetDisableBlink(int entityId)
	{
		BaseAnimationComponent component = EntitySystem.Instance.GetComponent<BaseAnimationComponent>(entityId);
		return component != null && component.DisableBlink;
	}

	// Token: 0x060192F7 RID: 103159 RVA: 0x0067B868 File Offset: 0x00679A68
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetIgnoreMontageBlinkCurve(int entityId)
	{
		BaseAnimationComponent component = EntitySystem.Instance.GetComponent<BaseAnimationComponent>(entityId);
		return component != null && component.IgnoreMontageBlinkCurve;
	}

	// Token: 0x060192F8 RID: 103160 RVA: 0x0067B880 File Offset: 0x00679A80
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void EnterBattleIdle(int entityId)
	{
		CharacterAnimationComponent component = EntitySystem.Instance.GetComponent<CharacterAnimationComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.EnterBattleIdle(null);
	}

	// Token: 0x060192F9 RID: 103161 RVA: 0x0067B8AC File Offset: 0x00679AAC
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetTransformWithModelBuffer(int entityId, FTransformDouble transform, float timeLength)
	{
		CharacterAnimationComponent component = EntitySystem.Instance.GetComponent<CharacterAnimationComponent>(entityId);
		if (component != null)
		{
			component.SetTransformWithModelBuffer(transform, timeLength, null, true);
			return;
		}
		VehicleAnimationComponent component2 = EntitySystem.Instance.GetComponent<VehicleAnimationComponent>(entityId);
		if (component2 != null)
		{
			component2.SetTransformWithModelBuffer(transform, timeLength, null);
		}
	}

	// Token: 0x060192FA RID: 103162 RVA: 0x0067B8FC File Offset: 0x00679AFC
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetSightDirectEnable(int entityId, bool v)
	{
		BaseAnimationComponent component = EntitySystem.Instance.GetComponent<BaseAnimationComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.EnableSightDirect = v;
	}

	// Token: 0x060192FB RID: 103163 RVA: 0x0067B920 File Offset: 0x00679B20
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void HideWeaponsWhenHideBones(int entityId, bool hide, FName socketName)
	{
		CharacterWeaponComponent component = EntitySystem.Instance.GetComponent<CharacterWeaponComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.HideWeaponsWhenHideBones(hide, socketName);
	}

	// Token: 0x060192FC RID: 103164 RVA: 0x0067B939 File Offset: 0x00679B39
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void ChangeWeaponHangState(int entityId, int weaponState, float lerpTime, ref TArray<FName> sockets, ref TArray<FTransform> transforms)
	{
		CharacterWeaponComponent component = EntitySystem.Instance.GetComponent<CharacterWeaponComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.ChangeWeaponHangState(weaponState, sockets, transforms, lerpTime, "TsMeshAnimBlueprintFunctionLibrary");
	}

	// Token: 0x060192FD RID: 103165 RVA: 0x0067B95D File Offset: 0x00679B5D
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static int GetCurrentWeaponHangState(int entityId)
	{
		CharacterWeaponComponent component = EntitySystem.Instance.GetComponent<CharacterWeaponComponent>(entityId);
		if (component == null)
		{
			return 0;
		}
		return component.CurrentHangState;
	}

	// Token: 0x060192FE RID: 103166 RVA: 0x0067B975 File Offset: 0x00679B75
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetIsCurrentWeaponHideEffectPlaying(int entityId)
	{
		CharacterWeaponComponent component = EntitySystem.Instance.GetComponent<CharacterWeaponComponent>(entityId);
		return component != null && component.IsCurrentWeaponHideEffectPlaying();
	}

	// Token: 0x060192FF RID: 103167 RVA: 0x0067B98D File Offset: 0x00679B8D
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void ChangeWeapon(int entityId, SWeaponSocketItem weaponSocket)
	{
		CharacterWeaponComponent component = EntitySystem.Instance.GetComponent<CharacterWeaponComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.ChangeWeaponByWeaponSocketItem(weaponSocket);
	}

	// Token: 0x06019300 RID: 103168 RVA: 0x0067B9A8 File Offset: 0x00679BA8
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetRandomStandActionIndex(int entityId)
	{
		CharacterAnimationComponent component = EntitySystem.Instance.GetComponent<CharacterAnimationComponent>(entityId);
		if (component == null)
		{
			return 0f;
		}
		return (float)component.GetRandomStandActionIndex();
	}

	// Token: 0x06019301 RID: 103169 RVA: 0x0067B9D1 File Offset: 0x00679BD1
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void HideWeapon(int entityId, bool hide, int index, bool hideEffect = true, bool useHighPriority = false)
	{
		CharacterWeaponComponent component = EntitySystem.Instance.GetComponent<CharacterWeaponComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.HideWeapon(index, hide, hideEffect, false, useHighPriority ? EWeaponExtraVisibleType.HighCustom : EWeaponExtraVisibleType.LowCustom, "Unknown");
	}

	// Token: 0x06019302 RID: 103170 RVA: 0x0067B9F9 File Offset: 0x00679BF9
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void HideHulu(int entityId, bool bHidden)
	{
		CharacterWeaponComponent component = EntitySystem.Instance.GetComponent<CharacterWeaponComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.SetHuluHidden(bHidden, true, false);
	}

	// Token: 0x06019303 RID: 103171 RVA: 0x0067BA13 File Offset: 0x00679C13
	[NullableContext(1)]
	protected static void ChangeMeshAnim(int entityId, USkeletalMesh meshClass, [Nullable(new byte[]
	{
		0,
		1
	})] TSubclassOf<UAnimInstance> animBlueprintClass)
	{
		CharacterActorComponent component = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.ChangeMeshAnim(meshClass, animBlueprintClass);
	}

	// Token: 0x06019304 RID: 103172 RVA: 0x0067BA2C File Offset: 0x00679C2C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetDegMovementSlope(int entityId)
	{
		CharacterAnimationComponent component = EntitySystem.Instance.GetComponent<CharacterAnimationComponent>(entityId);
		if (component == null)
		{
			return 0f;
		}
		return component.DegMovementSlope;
	}

	// Token: 0x06019305 RID: 103173 RVA: 0x0067BA48 File Offset: 0x00679C48
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetRoleFootStepState(int entityId)
	{
		CreatureDataComponent component = EntitySystem.Instance.GetComponent<CreatureDataComponent>(entityId);
		if (component == null)
		{
			return "";
		}
		if (component.GetEntityType() == EEntityType.Player)
		{
			int playerId = component.GetPlayerId();
			int? id = PlayerInfoModel.Instance.GetId();
			int num = playerId;
			bool isSelf = id.GetValueOrDefault() == num & id != null;
			int roleId = component.GetRoleId();
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, isSelf);
			if (roleDataById != null)
			{
				RoleInfo? roleInfo = new RoleInfo?(roleDataById.GetRoleConfig());
				if (roleInfo != null)
				{
					return roleInfo.Value.FootStepState;
				}
			}
		}
		return "";
	}

	// Token: 0x06019306 RID: 103174 RVA: 0x0067BAE0 File Offset: 0x00679CE0
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetIkMeshOffset(int entityId, float offset)
	{
		CharacterAnimationComponent component = EntitySystem.Instance.GetComponent<CharacterAnimationComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.IkMeshOffset = offset;
	}

	// Token: 0x06019307 RID: 103175 RVA: 0x0067BB04 File Offset: 0x00679D04
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetWeaponBreachLevel(int entityId)
	{
		CharacterWeaponComponent component = EntitySystem.Instance.GetComponent<CharacterWeaponComponent>(entityId);
		if (component != null)
		{
			return (float)component.GetWeaponBreachLevel();
		}
		return -1f;
	}

	// Token: 0x06019308 RID: 103176 RVA: 0x0067BB30 File Offset: 0x00679D30
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void UpdateAnimInfoMeshAnim(int entityId, BP_ABPLogicParams_C animLogicParams)
	{
		CharacterAnimationComponent component = EntitySystem.Instance.GetComponent<CharacterAnimationComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		AnimLogicParamsSetter animLogicParamsSetter = component.AnimLogicParamsSetter;
		float battleIdleEndTime = component.BattleIdleEndTime;
		if (animLogicParamsSetter.BattleIdleTime != battleIdleEndTime)
		{
			animLogicParamsSetter.BattleIdleTime = battleIdleEndTime;
			animLogicParams.BattleIdleTimeRef = battleIdleEndTime;
		}
		float degMovementSlope = component.DegMovementSlope;
		if (animLogicParamsSetter.DegMovementSlope != degMovementSlope)
		{
			animLogicParamsSetter.DegMovementSlope = degMovementSlope;
			animLogicParams.DegMovementSlopeRef = degMovementSlope;
		}
		global::Vector tsSightDirect = component.GetTsSightDirect();
		if (!animLogicParamsSetter.SightDirect.Equals(tsSightDirect, 9.999999747378752E-05))
		{
			animLogicParamsSetter.SightDirect.DeepCopy(tsSightDirect);
			animLogicParams.SightDirectRef = tsSightDirect.ToUeVectorOld();
		}
		bool disableBlink = component.DisableBlink;
		if (animLogicParamsSetter.DisableBlink != disableBlink)
		{
			animLogicParamsSetter.DisableBlink = disableBlink;
			animLogicParams.DisableBlinkRef = disableBlink;
		}
		bool ragRollQuitState = EntitySystem.Instance.GetComponent<CharacterPhysicsAssetComponent>(entityId).GetRagRollQuitState();
		if (animLogicParamsSetter.RagQuitState != ragRollQuitState)
		{
			animLogicParamsSetter.RagQuitState = ragRollQuitState;
			animLogicParams.RagQuitStateRef = ragRollQuitState;
		}
	}

	// Token: 0x06019309 RID: 103177 RVA: 0x0067BC28 File Offset: 0x00679E28
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void UpdateAnimInfoMeshAnimRoleNpc(int entityId, BP_ABPLogicParams_C animLogicParams)
	{
		CharacterAnimationComponent component = EntitySystem.Instance.GetComponent<CharacterAnimationComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		AnimLogicParamsSetter animLogicParamsSetter = component.AnimLogicParamsSetter;
		float degMovementSlope = component.DegMovementSlope;
		if (animLogicParamsSetter.DegMovementSlope != degMovementSlope)
		{
			animLogicParamsSetter.DegMovementSlope = degMovementSlope;
			animLogicParams.DegMovementSlopeRef = degMovementSlope;
		}
		global::Vector tsSightDirect = component.GetTsSightDirect();
		if (!animLogicParamsSetter.SightDirect.Equals(tsSightDirect, 9.999999747378752E-05))
		{
			animLogicParamsSetter.SightDirect.DeepCopy(tsSightDirect);
			animLogicParams.SightDirectRef = tsSightDirect.ToUeVectorOld();
		}
		bool disableBlink = component.DisableBlink;
		if (animLogicParamsSetter.DisableBlink != disableBlink)
		{
			animLogicParamsSetter.DisableBlink = disableBlink;
			animLogicParams.DisableBlinkRef = disableBlink;
		}
		Vector2D tsLookAt = component.GetTsLookAt();
		if (!animLogicParamsSetter.LookAt.Equals(tsLookAt, 9.999999747378752E-05))
		{
			animLogicParamsSetter.LookAt.DeepCopy(tsLookAt);
			animLogicParams.LookAtRef = tsLookAt.ToUeVector2D(false);
		}
		bool ignoreMontageBlinkCurve = component.IgnoreMontageBlinkCurve;
		if (animLogicParamsSetter.IgnoreMontageBlinkCurve != ignoreMontageBlinkCurve)
		{
			animLogicParamsSetter.IgnoreMontageBlinkCurve = ignoreMontageBlinkCurve;
			animLogicParams.IgnoreMontageBlinkCurve = ignoreMontageBlinkCurve;
		}
		if (animLogicParamsSetter.EnableBlendSpaceLookAt != component.EnableBlendSpaceLookAt)
		{
			animLogicParamsSetter.EnableBlendSpaceLookAt = component.EnableBlendSpaceLookAt;
			animLogicParams.EnableBlendSpaceLookAtRef = component.EnableBlendSpaceLookAt;
		}
		if (animLogicParamsSetter.EnableLowerBlend != component.EnableLowerBlend)
		{
			animLogicParamsSetter.EnableLowerBlend = component.EnableLowerBlend;
			animLogicParams.StateLowerBlend = component.EnableLowerBlend;
		}
		if (animLogicParamsSetter.EnableLeftArmBlend != component.EnableLeftArmBlend)
		{
			animLogicParamsSetter.EnableLeftArmBlend = component.EnableLeftArmBlend;
			animLogicParams.StateLeftArmBlend = component.EnableLeftArmBlend;
		}
		if (animLogicParamsSetter.EnableRightArmBlend != component.EnableRightArmBlend)
		{
			animLogicParamsSetter.EnableRightArmBlend = component.EnableRightArmBlend;
			animLogicParams.StateRightArmBlend = component.EnableRightArmBlend;
		}
		if (animLogicParamsSetter.DisableHumanIk != component.DisableHumanIk)
		{
			animLogicParamsSetter.DisableHumanIk = component.DisableHumanIk;
			animLogicParams.DisableHumanIkRef = component.DisableHumanIk;
		}
	}

	// Token: 0x0601930A RID: 103178 RVA: 0x0067BDEC File Offset: 0x00679FEC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void UpdateAnimInfoHoldingHandsRoleNpc(int entityId, BP_ABPLogicParams_C animLogicParams)
	{
		CharacterAnimationComponent component = EntitySystem.Instance.GetComponent<CharacterAnimationComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		CharacterHoldingHandsComponent component2 = EntitySystem.Instance.GetComponent<CharacterHoldingHandsComponent>(entityId);
		if (component2 == null)
		{
			return;
		}
		AnimLogicParamsSetter animLogicParamsSetter = component.AnimLogicParamsSetter;
		IkTarget handIkTarget = component2.GetHandIkTarget(EHandType.Left);
		if (handIkTarget != null && !animLogicParamsSetter.LeftHandIkTarget.Equals(handIkTarget))
		{
			animLogicParamsSetter.LeftHandIkTarget.DeepCopy(handIkTarget);
			FIKTarget handIkTargetUe = component2.GetHandIkTargetUe(EHandType.Left);
			if (handIkTargetUe != null)
			{
				animLogicParams.LeftHandIKTargetCS = handIkTargetUe;
			}
		}
		IkTarget handIkTarget2 = component2.GetHandIkTarget(EHandType.Right);
		if (handIkTarget2 != null && !animLogicParamsSetter.RightHandIkTarget.Equals(handIkTarget2))
		{
			animLogicParamsSetter.RightHandIkTarget.DeepCopy(handIkTarget2);
			FIKTarget handIkTargetUe2 = component2.GetHandIkTargetUe(EHandType.Right);
			if (handIkTargetUe2 != null)
			{
				animLogicParams.RightHandIKTargetCS = handIkTargetUe2;
			}
		}
		bool isHoldingHands = component2.GetIsHoldingHands();
		if (isHoldingHands != animLogicParamsSetter.IsHoldingHands)
		{
			animLogicParamsSetter.IsHoldingHands = isHoldingHands;
			animLogicParams.IsHoldingHands = isHoldingHands;
		}
		bool isBeHoldingHands = component2.GetIsBeHoldingHands();
		if (isBeHoldingHands != animLogicParamsSetter.IsBeHoldingHands)
		{
			animLogicParamsSetter.IsBeHoldingHands = isBeHoldingHands;
			animLogicParams.IsBeHoldingHands = isBeHoldingHands;
		}
		bool flag = component2.GetHandReachable(EHandType.Left) || component2.GetHandReachable(EHandType.Right);
		if (flag != animLogicParamsSetter.IsHoldingHandsReachable)
		{
			animLogicParamsSetter.IsHoldingHandsReachable = flag;
			animLogicParams.IsHoldingHandsReachable = flag;
		}
		bool isAcceptingInvitation = component2.GetIsAcceptingInvitation();
		if (isAcceptingInvitation != animLogicParamsSetter.IsAcceptingInvitation)
		{
			animLogicParamsSetter.IsAcceptingInvitation = isAcceptingInvitation;
			animLogicParams.IsAcceptingInvitation = isAcceptingInvitation;
		}
	}

	// Token: 0x0601930B RID: 103179 RVA: 0x0067BF48 File Offset: 0x0067A148
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void UpdateFootstepAudioEvent(int entityId, int roleEntityId, SFootstepAudioEventParam parameters)
	{
		FHitResult 碰撞信息 = parameters.碰撞信息;
		if (!parameters.状态_地面_Sprint && !碰撞信息.bBlockingHit)
		{
			return;
		}
		CharacterActorComponent component = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		AActor owner = component.Owner;
		if (!(owner is TsBaseCharacter))
		{
			return;
		}
		TsBaseCharacter tsBaseCharacter = (TsBaseCharacter)owner;
		EventSystem.Instance.EmitWithTarget<bool>(component.Entity, EEventName.OnCharFootOnTheGround, false);
		EventSystem.Instance.Emit<bool>(EEventName.OnCharFootOnTheGround, false);
		CharacterAkComponent component2 = component.Entity.GetComponent<CharacterAkComponent>();
		if (component2 == null || !component2.Valid)
		{
			return;
		}
		UAkComponent akComponentBySocketName = component2.GetAkComponentBySocketName(FNameUtil.GetDynamicFName("hitcase").Value);
		if (akComponentBySocketName == null || !akComponentBySocketName.IsValid())
		{
			return;
		}
		FVector fvector;
		if (!tsBaseCharacter.CharRenderingComponent.GetInWater(2f))
		{
			FVector_NetQuantize location = 碰撞信息.Location;
			fvector = location;
		}
		else
		{
			fvector = parameters.缓存角色位置;
		}
		FVector inVec = fvector;
		UWorld world = GlobalData.World;
		string text;
		if (tsBaseCharacter.CharRenderingComponent.GetInWater(2f))
		{
			UAkGameplayStatics.SetRTPCValue(null, (float)component2.WaterDepth, 0, null, FNameUtil.NONE);
			text = "WaterSurface";
		}
		else
		{
			if (world == null || !world.IsValid())
			{
				return;
			}
			FVectorDouble location2 = UKismetMathLibrary.Conv_VectorToVectorDouble(inVec);
			FoliageAudioInfo foliageAudioInfo = AudioUtils.Instance.QueryFoliageAudioPhysicalMaterial(location2, null);
			UPhysicalMaterial uphysicalMaterial = 碰撞信息.PhysMaterial.IsValid(false, false) ? 碰撞信息.PhysMaterial.Get() : null;
			if (foliageAudioInfo != null && foliageAudioInfo.IsHitFoliage && foliageAudioInfo.PhysicalMaterial != null)
			{
				uphysicalMaterial = foliageAudioInfo.PhysicalMaterial;
			}
			TEnumAsByte<EPhysicalSurface>? tenumAsByte = (uphysicalMaterial != null) ? new TEnumAsByte<EPhysicalSurface>?(uphysicalMaterial.SurfaceType) : null;
			FName a = (tenumAsByte != null) ? UKuroAudioMaterialSettings.GetFootstepTextureName(tenumAsByte.Value) : FNameUtil.NONE;
			text = ((a == FNameUtil.NONE) ? a.ToString() : "");
			text = ((text.Length > 0) ? text : CharacterFootEffectComponent.EFootstepTexture.DirtSurface.ToEnumString());
		}
		akComponentBySocketName.SetSwitch(null, "FootStep_Ground_Texture", text);
		component2.FootSwitch = text;
		akComponentBySocketName.SetSwitch(null, "FootStep_Shoes", TsMeshAnimBlueprintFunctionLibrary.GetRoleFootStepState(roleEntityId));
		FOnAkPostEventCallback fonAkPostEventCallback;
		if (parameters.状态_地面_Walk || parameters.状态_跑停_WalkStop)
		{
			UAkGameObject uakGameObject = akComponentBySocketName;
			UAkAudioEvent walkAkAudioEvent = parameters.WalkAkAudioEvent;
			int callbackMask = 0;
			fonAkPostEventCallback = null;
			uakGameObject.PostAkEvent(walkAkAudioEvent, callbackMask, fonAkPostEventCallback, "");
			return;
		}
		if (parameters.状态_地面_Run || parameters.状态_跑停_RunStop)
		{
			UAkGameObject uakGameObject2 = akComponentBySocketName;
			UAkAudioEvent runAkAudioEvent = parameters.RunAkAudioEvent;
			int callbackMask2 = 0;
			fonAkPostEventCallback = null;
			uakGameObject2.PostAkEvent(runAkAudioEvent, callbackMask2, fonAkPostEventCallback, "");
			return;
		}
		if (parameters.状态_地面_Sprint || parameters.状态_跑停_SprintStop)
		{
			UAkGameObject uakGameObject3 = akComponentBySocketName;
			UAkAudioEvent sprintAkAudioEvent = parameters.SprintAkAudioEvent;
			int callbackMask3 = 0;
			fonAkPostEventCallback = null;
			uakGameObject3.PostAkEvent(sprintAkAudioEvent, callbackMask3, fonAkPostEventCallback, "");
			return;
		}
		UAkGameObject uakGameObject4 = akComponentBySocketName;
		UAkAudioEvent fallbackAkAudioEvent = parameters.FallbackAkAudioEvent;
		int callbackMask4 = 0;
		fonAkPostEventCallback = null;
		uakGameObject4.PostAkEvent(fallbackAkAudioEvent, callbackMask4, fonAkPostEventCallback, "");
	}

	// Token: 0x0601930C RID: 103180 RVA: 0x0067C226 File Offset: 0x0067A426
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void ChangeTickOverlap(int entityId, bool overlap)
	{
		EntitySystem.Instance.GetComponent<UeSkeletalTickManageComponent>(entityId).SetTakeOverTick(overlap);
	}

	// Token: 0x0601930D RID: 103181 RVA: 0x0067C23C File Offset: 0x0067A43C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected unsafe static void AnimTurnLog(int entityId)
	{
		CharacterActorComponent component = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityId);
		if (component == null)
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Test;
		ELogAuthor author = ELogAuthor.LCZ;
		string message = "AnimTurn 1058338";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", entityId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CurrentFacing", component.ActorRotationProxy);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("InputFace", component.InputRotatorProxy);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
	}

	// Token: 0x0601930E RID: 103182 RVA: 0x0067C2D4 File Offset: 0x0067A4D4
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool IsNpcTurning(int entityId)
	{
		NpcMoveComponent component = EntitySystem.Instance.GetComponent<NpcMoveComponent>(entityId);
		return component != null && component.IsTurning;
	}

	// Token: 0x0601930F RID: 103183 RVA: 0x0067C2F8 File Offset: 0x0067A4F8
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetSightSpeedAndRatio(int entityId, float speed, float ratio)
	{
		CharacterAnimationComponent component = EntitySystem.Instance.GetComponent<CharacterAnimationComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.SetSightSpeedAndRatio(speed, ratio);
	}

	// Token: 0x06019310 RID: 103184 RVA: 0x0067C314 File Offset: 0x0067A514
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void UpdateAndGetRotateBonesMap(int entityId, float deltaSeconds, ref TMap<string, float> outMap, ref FVector outOffset)
	{
		CharacterAnimationComponent component = EntitySystem.Instance.GetComponent<CharacterAnimationComponent>(entityId);
		if (component == null || component.RotateBonesToTargetMgr == null)
		{
			return;
		}
		component.RotateBonesToTargetMgr.Update(deltaSeconds);
		component.RotateBonesToTargetMgr.GetActivateBones(outMap);
		component.RotateBonesToTargetMgr.GetTargetOffset(ref outOffset);
	}

	// Token: 0x06019311 RID: 103185 RVA: 0x0067C360 File Offset: 0x0067A560
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetSightDirectLimitAngles(int entityId, float horizontalAngle = 180f, float verticalDownAngle = -90f, float verticalUpAngle = 90f)
	{
		BaseAnimationComponent component = EntitySystem.Instance.GetComponent<BaseAnimationComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.SetSightLimit(new float[]
		{
			-horizontalAngle,
			horizontalAngle
		}, new float[]
		{
			verticalDownAngle,
			verticalUpAngle
		}, true);
	}

	// Token: 0x06019312 RID: 103186 RVA: 0x0067C3A4 File Offset: 0x0067A5A4
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetRotateBonesToTagertDefault(int entityId, FVector defaultTargetOffset, float lerpSpeed = 1000f, float targetUpdateThreshold = 100f)
	{
		CharacterAnimationComponent component = EntitySystem.Instance.GetComponent<CharacterAnimationComponent>(entityId);
		if (component == null || component.RotateBonesToTargetMgr == null)
		{
			return;
		}
		component.RotateBonesToTargetMgr.SetDefaultTarget(defaultTargetOffset, lerpSpeed, targetUpdateThreshold);
	}

	// Token: 0x06019313 RID: 103187 RVA: 0x0067C3D8 File Offset: 0x0067A5D8
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetRotateBonesToTagertWithTime(int entityId, ref TArray<string> boneNames, float timeLength)
	{
		CharacterAnimationComponent component = EntitySystem.Instance.GetComponent<CharacterAnimationComponent>(entityId);
		if (component == null || component.RotateBonesToTargetMgr == null)
		{
			return;
		}
		component.RotateBonesToTargetMgr.SetBoneToTarget(boneNames, timeLength);
	}

	// Token: 0x06019314 RID: 103188 RVA: 0x0067C40C File Offset: 0x0067A60C
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsMeshAnimBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsMeshAnimBlueprintFunctionLibrary.TsMeshAnimBlueprintFunctionLibrary_C");
		}
		return TsMeshAnimBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x06019315 RID: 103189 RVA: 0x0067C430 File Offset: 0x0067A630
	public TsMeshAnimBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(TsMeshAnimBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06019316 RID: 103190 RVA: 0x0067C458 File Offset: 0x0067A658
	[NullableContext(1)]
	public TsMeshAnimBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsMeshAnimBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06019317 RID: 103191 RVA: 0x0067C48B File Offset: 0x0067A68B
	protected TsMeshAnimBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06019318 RID: 103192 RVA: 0x0067C494 File Offset: 0x0067A694
	protected unsafe static void __CPPCALL_MainAnimInstance_Implementation(TsMeshAnimBlueprintFunctionLibrary.__MainAnimInstance_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		UAnimInstance uanimInstance = TsMeshAnimBlueprintFunctionLibrary.MainAnimInstance(__Params->entityId);
		ptr = ((uanimInstance != null) ? uanimInstance.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06019319 RID: 103193 RVA: 0x0067C4B6 File Offset: 0x0067A6B6
	protected unsafe static void __CPPCALL_MainAnimInstanceForVehicle_Implementation(TsMeshAnimBlueprintFunctionLibrary.__MainAnimInstanceForVehicle_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		UAnimInstance uanimInstance = TsMeshAnimBlueprintFunctionLibrary.MainAnimInstanceForVehicle(__Params->entityId);
		ptr = ((uanimInstance != null) ? uanimInstance.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0601931A RID: 103194 RVA: 0x0067C4D8 File Offset: 0x0067A6D8
	protected unsafe static void __CPPCALL_GetSightDirect_Implementation(TsMeshAnimBlueprintFunctionLibrary.__GetSightDirect_FunctionParams* __Params)
	{
		__Params->__Result = TsMeshAnimBlueprintFunctionLibrary.GetSightDirect(__Params->entityId);
	}

	// Token: 0x0601931B RID: 103195 RVA: 0x0067C4EB File Offset: 0x0067A6EB
	protected unsafe static void __CPPCALL_GetHeadBaseYawBuffer_Implementation(TsMeshAnimBlueprintFunctionLibrary.__GetHeadBaseYawBuffer_FunctionParams* __Params)
	{
		__Params->__Result = TsMeshAnimBlueprintFunctionLibrary.GetHeadBaseYawBuffer(__Params->entityId);
	}

	// Token: 0x0601931C RID: 103196 RVA: 0x0067C4FE File Offset: 0x0067A6FE
	protected unsafe static void __CPPCALL_GetHulu_Implementation(TsMeshAnimBlueprintFunctionLibrary.__GetHulu_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		UMeshComponent hulu = TsMeshAnimBlueprintFunctionLibrary.GetHulu(__Params->entityId);
		ptr = ((hulu != null) ? hulu.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0601931D RID: 103197 RVA: 0x0067C520 File Offset: 0x0067A720
	protected unsafe static void __CPPCALL_GetBattleIdleTime_Implementation(TsMeshAnimBlueprintFunctionLibrary.__GetBattleIdleTime_FunctionParams* __Params)
	{
		__Params->__Result = TsMeshAnimBlueprintFunctionLibrary.GetBattleIdleTime(__Params->entityId);
	}

	// Token: 0x0601931E RID: 103198 RVA: 0x0067C533 File Offset: 0x0067A733
	protected unsafe static void __CPPCALL_GetDisableBlink_Implementation(TsMeshAnimBlueprintFunctionLibrary.__GetDisableBlink_FunctionParams* __Params)
	{
		__Params->__Result = TsMeshAnimBlueprintFunctionLibrary.GetDisableBlink(__Params->entityId);
	}

	// Token: 0x0601931F RID: 103199 RVA: 0x0067C546 File Offset: 0x0067A746
	protected unsafe static void __CPPCALL_GetIgnoreMontageBlinkCurve_Implementation(TsMeshAnimBlueprintFunctionLibrary.__GetIgnoreMontageBlinkCurve_FunctionParams* __Params)
	{
		__Params->__Result = TsMeshAnimBlueprintFunctionLibrary.GetIgnoreMontageBlinkCurve(__Params->entityId);
	}

	// Token: 0x06019320 RID: 103200 RVA: 0x0067C559 File Offset: 0x0067A759
	protected unsafe static void __CPPCALL_EnterBattleIdle_Implementation(TsMeshAnimBlueprintFunctionLibrary.__EnterBattleIdle_FunctionParams* __Params)
	{
		TsMeshAnimBlueprintFunctionLibrary.EnterBattleIdle(__Params->entityId);
	}

	// Token: 0x06019321 RID: 103201 RVA: 0x0067C566 File Offset: 0x0067A766
	protected unsafe static void __CPPCALL_SetTransformWithModelBuffer_Implementation(TsMeshAnimBlueprintFunctionLibrary.__SetTransformWithModelBuffer_FunctionParams* __Params)
	{
		TsMeshAnimBlueprintFunctionLibrary.SetTransformWithModelBuffer(__Params->entityId, __Params->transform, __Params->timeLength);
	}

	// Token: 0x06019322 RID: 103202 RVA: 0x0067C57F File Offset: 0x0067A77F
	protected unsafe static void __CPPCALL_SetSightDirectEnable_Implementation(TsMeshAnimBlueprintFunctionLibrary.__SetSightDirectEnable_FunctionParams* __Params)
	{
		TsMeshAnimBlueprintFunctionLibrary.SetSightDirectEnable(__Params->entityId, __Params->v);
	}

	// Token: 0x06019323 RID: 103203 RVA: 0x0067C592 File Offset: 0x0067A792
	protected unsafe static void __CPPCALL_HideWeaponsWhenHideBones_Implementation(TsMeshAnimBlueprintFunctionLibrary.__HideWeaponsWhenHideBones_FunctionParams* __Params)
	{
		TsMeshAnimBlueprintFunctionLibrary.HideWeaponsWhenHideBones(__Params->entityId, __Params->hide, __Params->socketName);
	}

	// Token: 0x06019324 RID: 103204 RVA: 0x0067C5AC File Offset: 0x0067A7AC
	protected unsafe static void __CPPCALL_ChangeWeaponHangState_Implementation(TsMeshAnimBlueprintFunctionLibrary.__ChangeWeaponHangState_FunctionParams* __Params)
	{
		TArray<FName> tarray = new TArray<FName>(&__Params->sockets, true, true);
		TArray<FTransform> tarray2 = new TArray<FTransform>(&__Params->transforms, true, true);
		TsMeshAnimBlueprintFunctionLibrary.ChangeWeaponHangState(__Params->entityId, __Params->weaponState, __Params->lerpTime, ref tarray, ref tarray2);
		if (tarray != null)
		{
			tarray.CopyTo(&__Params->sockets, default(UScriptStructStackOnlyPtr));
		}
		if (tarray2 != null)
		{
			tarray2.CopyTo(&__Params->transforms, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x06019325 RID: 103205 RVA: 0x0067C624 File Offset: 0x0067A824
	protected unsafe static void __CPPCALL_GetCurrentWeaponHangState_Implementation(TsMeshAnimBlueprintFunctionLibrary.__GetCurrentWeaponHangState_FunctionParams* __Params)
	{
		__Params->__Result = TsMeshAnimBlueprintFunctionLibrary.GetCurrentWeaponHangState(__Params->entityId);
	}

	// Token: 0x06019326 RID: 103206 RVA: 0x0067C637 File Offset: 0x0067A837
	protected unsafe static void __CPPCALL_GetIsCurrentWeaponHideEffectPlaying_Implementation(TsMeshAnimBlueprintFunctionLibrary.__GetIsCurrentWeaponHideEffectPlaying_FunctionParams* __Params)
	{
		__Params->__Result = TsMeshAnimBlueprintFunctionLibrary.GetIsCurrentWeaponHideEffectPlaying(__Params->entityId);
	}

	// Token: 0x06019327 RID: 103207 RVA: 0x0067C64C File Offset: 0x0067A84C
	protected unsafe static void __CPPCALL_ChangeWeapon_Implementation(TsMeshAnimBlueprintFunctionLibrary.__ChangeWeapon_FunctionParams* __Params)
	{
		SWeaponSocketItem weaponSocket = new SWeaponSocketItem(&__Params->weaponSocket, true, true);
		TsMeshAnimBlueprintFunctionLibrary.ChangeWeapon(__Params->entityId, weaponSocket);
	}

	// Token: 0x06019328 RID: 103208 RVA: 0x0067C674 File Offset: 0x0067A874
	protected unsafe static void __CPPCALL_GetRandomStandActionIndex_Implementation(TsMeshAnimBlueprintFunctionLibrary.__GetRandomStandActionIndex_FunctionParams* __Params)
	{
		__Params->__Result = TsMeshAnimBlueprintFunctionLibrary.GetRandomStandActionIndex(__Params->entityId);
	}

	// Token: 0x06019329 RID: 103209 RVA: 0x0067C687 File Offset: 0x0067A887
	protected unsafe static void __CPPCALL_HideWeapon_Implementation(TsMeshAnimBlueprintFunctionLibrary.__HideWeapon_FunctionParams* __Params)
	{
		TsMeshAnimBlueprintFunctionLibrary.HideWeapon(__Params->entityId, __Params->hide, __Params->index, __Params->hideEffect, __Params->useHighPriority);
	}

	// Token: 0x0601932A RID: 103210 RVA: 0x0067C6AC File Offset: 0x0067A8AC
	protected unsafe static void __CPPCALL_HideHulu_Implementation(TsMeshAnimBlueprintFunctionLibrary.__HideHulu_FunctionParams* __Params)
	{
		TsMeshAnimBlueprintFunctionLibrary.HideHulu(__Params->entityId, __Params->bHidden);
	}

	// Token: 0x0601932B RID: 103211 RVA: 0x0067C6BF File Offset: 0x0067A8BF
	protected unsafe static void __CPPCALL_GetDegMovementSlope_Implementation(TsMeshAnimBlueprintFunctionLibrary.__GetDegMovementSlope_FunctionParams* __Params)
	{
		__Params->__Result = TsMeshAnimBlueprintFunctionLibrary.GetDegMovementSlope(__Params->entityId);
	}

	// Token: 0x0601932C RID: 103212 RVA: 0x0067C6D2 File Offset: 0x0067A8D2
	protected unsafe static void __CPPCALL_GetRoleFootStepState_Implementation(TsMeshAnimBlueprintFunctionLibrary.__GetRoleFootStepState_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsMeshAnimBlueprintFunctionLibrary.GetRoleFootStepState(__Params->entityId));
	}

	// Token: 0x0601932D RID: 103213 RVA: 0x0067C6EB File Offset: 0x0067A8EB
	protected unsafe static void __CPPCALL_SetIkMeshOffset_Implementation(TsMeshAnimBlueprintFunctionLibrary.__SetIkMeshOffset_FunctionParams* __Params)
	{
		TsMeshAnimBlueprintFunctionLibrary.SetIkMeshOffset(__Params->entityId, __Params->offset);
	}

	// Token: 0x0601932E RID: 103214 RVA: 0x0067C6FE File Offset: 0x0067A8FE
	protected unsafe static void __CPPCALL_GetWeaponBreachLevel_Implementation(TsMeshAnimBlueprintFunctionLibrary.__GetWeaponBreachLevel_FunctionParams* __Params)
	{
		__Params->__Result = TsMeshAnimBlueprintFunctionLibrary.GetWeaponBreachLevel(__Params->entityId);
	}

	// Token: 0x0601932F RID: 103215 RVA: 0x0067C714 File Offset: 0x0067A914
	protected unsafe static void __CPPCALL_UpdateAnimInfoMeshAnim_Implementation(TsMeshAnimBlueprintFunctionLibrary.__UpdateAnimInfoMeshAnim_FunctionParams* __Params)
	{
		BP_ABPLogicParams_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_ABPLogicParams_C>(__Params->animLogicParams);
		TsMeshAnimBlueprintFunctionLibrary.UpdateAnimInfoMeshAnim(__Params->entityId, orCreateUObjectByNativePointer);
	}

	// Token: 0x06019330 RID: 103216 RVA: 0x0067C73C File Offset: 0x0067A93C
	protected unsafe static void __CPPCALL_UpdateAnimInfoMeshAnimRoleNpc_Implementation(TsMeshAnimBlueprintFunctionLibrary.__UpdateAnimInfoMeshAnimRoleNpc_FunctionParams* __Params)
	{
		BP_ABPLogicParams_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_ABPLogicParams_C>(__Params->animLogicParams);
		TsMeshAnimBlueprintFunctionLibrary.UpdateAnimInfoMeshAnimRoleNpc(__Params->entityId, orCreateUObjectByNativePointer);
	}

	// Token: 0x06019331 RID: 103217 RVA: 0x0067C764 File Offset: 0x0067A964
	protected unsafe static void __CPPCALL_UpdateAnimInfoHoldingHandsRoleNpc_Implementation(TsMeshAnimBlueprintFunctionLibrary.__UpdateAnimInfoHoldingHandsRoleNpc_FunctionParams* __Params)
	{
		BP_ABPLogicParams_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_ABPLogicParams_C>(__Params->animLogicParams);
		TsMeshAnimBlueprintFunctionLibrary.UpdateAnimInfoHoldingHandsRoleNpc(__Params->entityId, orCreateUObjectByNativePointer);
	}

	// Token: 0x06019332 RID: 103218 RVA: 0x0067C78C File Offset: 0x0067A98C
	protected unsafe static void __CPPCALL_UpdateFootstepAudioEvent_Implementation(TsMeshAnimBlueprintFunctionLibrary.__UpdateFootstepAudioEvent_FunctionParams* __Params)
	{
		SFootstepAudioEventParam parameters = new SFootstepAudioEventParam(&__Params->parameters, true, true);
		TsMeshAnimBlueprintFunctionLibrary.UpdateFootstepAudioEvent(__Params->entityId, __Params->roleEntityId, parameters);
	}

	// Token: 0x06019333 RID: 103219 RVA: 0x0067C7BA File Offset: 0x0067A9BA
	protected unsafe static void __CPPCALL_ChangeTickOverlap_Implementation(TsMeshAnimBlueprintFunctionLibrary.__ChangeTickOverlap_FunctionParams* __Params)
	{
		TsMeshAnimBlueprintFunctionLibrary.ChangeTickOverlap(__Params->entityId, __Params->overlap);
	}

	// Token: 0x06019334 RID: 103220 RVA: 0x0067C7CD File Offset: 0x0067A9CD
	protected unsafe static void __CPPCALL_AnimTurnLog_Implementation(TsMeshAnimBlueprintFunctionLibrary.__AnimTurnLog_FunctionParams* __Params)
	{
		TsMeshAnimBlueprintFunctionLibrary.AnimTurnLog(__Params->entityId);
	}

	// Token: 0x06019335 RID: 103221 RVA: 0x0067C7DA File Offset: 0x0067A9DA
	protected unsafe static void __CPPCALL_IsNpcTurning_Implementation(TsMeshAnimBlueprintFunctionLibrary.__IsNpcTurning_FunctionParams* __Params)
	{
		__Params->__Result = TsMeshAnimBlueprintFunctionLibrary.IsNpcTurning(__Params->entityId);
	}

	// Token: 0x06019336 RID: 103222 RVA: 0x0067C7ED File Offset: 0x0067A9ED
	protected unsafe static void __CPPCALL_SetSightSpeedAndRatio_Implementation(TsMeshAnimBlueprintFunctionLibrary.__SetSightSpeedAndRatio_FunctionParams* __Params)
	{
		TsMeshAnimBlueprintFunctionLibrary.SetSightSpeedAndRatio(__Params->entityId, __Params->speed, __Params->ratio);
	}

	// Token: 0x06019337 RID: 103223 RVA: 0x0067C808 File Offset: 0x0067AA08
	protected unsafe static void __CPPCALL_UpdateAndGetRotateBonesMap_Implementation(TsMeshAnimBlueprintFunctionLibrary.__UpdateAndGetRotateBonesMap_FunctionParams* __Params)
	{
		TMap<string, float> tmap = new TMap<string, float>(&__Params->outMap, true, true);
		TsMeshAnimBlueprintFunctionLibrary.UpdateAndGetRotateBonesMap(__Params->entityId, __Params->deltaSeconds, ref tmap, ref __Params->outOffset);
		if (tmap != null)
		{
			tmap.CopyTo(&__Params->outMap, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x06019338 RID: 103224 RVA: 0x0067C856 File Offset: 0x0067AA56
	protected unsafe static void __CPPCALL_SetSightDirectLimitAngles_Implementation(TsMeshAnimBlueprintFunctionLibrary.__SetSightDirectLimitAngles_FunctionParams* __Params)
	{
		TsMeshAnimBlueprintFunctionLibrary.SetSightDirectLimitAngles(__Params->entityId, __Params->horizontalAngle, __Params->verticalDownAngle, __Params->verticalUpAngle);
	}

	// Token: 0x06019339 RID: 103225 RVA: 0x0067C875 File Offset: 0x0067AA75
	protected unsafe static void __CPPCALL_SetRotateBonesToTagertDefault_Implementation(TsMeshAnimBlueprintFunctionLibrary.__SetRotateBonesToTagertDefault_FunctionParams* __Params)
	{
		TsMeshAnimBlueprintFunctionLibrary.SetRotateBonesToTagertDefault(__Params->entityId, __Params->defaultTargetOffset, __Params->lerpSpeed, __Params->targetUpdateThreshold);
	}

	// Token: 0x0601933A RID: 103226 RVA: 0x0067C894 File Offset: 0x0067AA94
	protected unsafe static void __CPPCALL_SetRotateBonesToTagertWithTime_Implementation(TsMeshAnimBlueprintFunctionLibrary.__SetRotateBonesToTagertWithTime_FunctionParams* __Params)
	{
		TArray<string> tarray = new TArray<string>(&__Params->boneNames, true, true);
		TsMeshAnimBlueprintFunctionLibrary.SetRotateBonesToTagertWithTime(__Params->entityId, ref tarray, __Params->timeLength);
		if (tarray != null)
		{
			tarray.CopyTo(&__Params->boneNames, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x0400BBA1 RID: 48033
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsMeshAnimBlueprintFunctionLibrary.TsMeshAnimBlueprintFunctionLibrary_C";

	// Token: 0x0400BBA2 RID: 48034
	private static IntPtr _ClassPtr;

	// Token: 0x0400BBA3 RID: 48035
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x02009511 RID: 38161
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __MainAnimInstance_FunctionParams
	{
		// Token: 0x0402FEE8 RID: 196328
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FEE9 RID: 196329
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FEEA RID: 196330
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x02009512 RID: 38162
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __MainAnimInstanceForVehicle_FunctionParams
	{
		// Token: 0x0402FEEB RID: 196331
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FEEC RID: 196332
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FEED RID: 196333
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x02009513 RID: 38163
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetSightDirect_FunctionParams
	{
		// Token: 0x0402FEEE RID: 196334
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FEEF RID: 196335
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FEF0 RID: 196336
		[FieldOffset(16)]
		public FVector __Result;
	}

	// Token: 0x02009514 RID: 38164
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetHeadBaseYawBuffer_FunctionParams
	{
		// Token: 0x0402FEF1 RID: 196337
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FEF2 RID: 196338
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FEF3 RID: 196339
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02009515 RID: 38165
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetHulu_FunctionParams
	{
		// Token: 0x0402FEF4 RID: 196340
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FEF5 RID: 196341
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FEF6 RID: 196342
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x02009516 RID: 38166
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetBattleIdleTime_FunctionParams
	{
		// Token: 0x0402FEF7 RID: 196343
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FEF8 RID: 196344
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FEF9 RID: 196345
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02009517 RID: 38167
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetDisableBlink_FunctionParams
	{
		// Token: 0x0402FEFA RID: 196346
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FEFB RID: 196347
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FEFC RID: 196348
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009518 RID: 38168
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetIgnoreMontageBlinkCurve_FunctionParams
	{
		// Token: 0x0402FEFD RID: 196349
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FEFE RID: 196350
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FEFF RID: 196351
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009519 RID: 38169
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EnterBattleIdle_FunctionParams
	{
		// Token: 0x0402FF00 RID: 196352
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF01 RID: 196353
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200951A RID: 38170
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 96)]
	protected ref struct __SetTransformWithModelBuffer_FunctionParams
	{
		// Token: 0x0402FF02 RID: 196354
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF03 RID: 196355
		[FieldOffset(16)]
		public FTransformDouble transform;

		// Token: 0x0402FF04 RID: 196356
		[FieldOffset(80)]
		public float timeLength;

		// Token: 0x0402FF05 RID: 196357
		[FieldOffset(88)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200951B RID: 38171
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetSightDirectEnable_FunctionParams
	{
		// Token: 0x0402FF06 RID: 196358
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF07 RID: 196359
		[FieldOffset(4)]
		public bool v;

		// Token: 0x0402FF08 RID: 196360
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200951C RID: 38172
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __HideWeaponsWhenHideBones_FunctionParams
	{
		// Token: 0x0402FF09 RID: 196361
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF0A RID: 196362
		[FieldOffset(4)]
		public bool hide;

		// Token: 0x0402FF0B RID: 196363
		[FieldOffset(8)]
		public FName socketName;

		// Token: 0x0402FF0C RID: 196364
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200951D RID: 38173
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __ChangeWeaponHangState_FunctionParams
	{
		// Token: 0x0402FF0D RID: 196365
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF0E RID: 196366
		[FieldOffset(4)]
		public int weaponState;

		// Token: 0x0402FF0F RID: 196367
		[FieldOffset(8)]
		public float lerpTime;

		// Token: 0x0402FF10 RID: 196368
		[FieldOffset(16)]
		public byte sockets;

		// Token: 0x0402FF11 RID: 196369
		[FieldOffset(32)]
		public byte transforms;

		// Token: 0x0402FF12 RID: 196370
		[FieldOffset(48)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200951E RID: 38174
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetCurrentWeaponHangState_FunctionParams
	{
		// Token: 0x0402FF13 RID: 196371
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF14 RID: 196372
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FF15 RID: 196373
		[FieldOffset(16)]
		public int __Result;
	}

	// Token: 0x0200951F RID: 38175
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetIsCurrentWeaponHideEffectPlaying_FunctionParams
	{
		// Token: 0x0402FF16 RID: 196374
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF17 RID: 196375
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FF18 RID: 196376
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009520 RID: 38176
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 104)]
	protected ref struct __ChangeWeapon_FunctionParams
	{
		// Token: 0x0402FF19 RID: 196377
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF1A RID: 196378
		[FieldOffset(8)]
		public byte weaponSocket;

		// Token: 0x0402FF1B RID: 196379
		[FieldOffset(96)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009521 RID: 38177
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetRandomStandActionIndex_FunctionParams
	{
		// Token: 0x0402FF1C RID: 196380
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF1D RID: 196381
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FF1E RID: 196382
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02009522 RID: 38178
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __HideWeapon_FunctionParams
	{
		// Token: 0x0402FF1F RID: 196383
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF20 RID: 196384
		[FieldOffset(4)]
		public bool hide;

		// Token: 0x0402FF21 RID: 196385
		[FieldOffset(8)]
		public int index;

		// Token: 0x0402FF22 RID: 196386
		[FieldOffset(12)]
		public bool hideEffect;

		// Token: 0x0402FF23 RID: 196387
		[FieldOffset(13)]
		public bool useHighPriority;

		// Token: 0x0402FF24 RID: 196388
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009523 RID: 38179
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __HideHulu_FunctionParams
	{
		// Token: 0x0402FF25 RID: 196389
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF26 RID: 196390
		[FieldOffset(4)]
		public bool bHidden;

		// Token: 0x0402FF27 RID: 196391
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009524 RID: 38180
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetDegMovementSlope_FunctionParams
	{
		// Token: 0x0402FF28 RID: 196392
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF29 RID: 196393
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FF2A RID: 196394
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02009525 RID: 38181
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetRoleFootStepState_FunctionParams
	{
		// Token: 0x0402FF2B RID: 196395
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF2C RID: 196396
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FF2D RID: 196397
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x02009526 RID: 38182
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetIkMeshOffset_FunctionParams
	{
		// Token: 0x0402FF2E RID: 196398
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF2F RID: 196399
		[FieldOffset(4)]
		public float offset;

		// Token: 0x0402FF30 RID: 196400
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009527 RID: 38183
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetWeaponBreachLevel_FunctionParams
	{
		// Token: 0x0402FF31 RID: 196401
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF32 RID: 196402
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FF33 RID: 196403
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02009528 RID: 38184
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __UpdateAnimInfoMeshAnim_FunctionParams
	{
		// Token: 0x0402FF34 RID: 196404
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF35 RID: 196405
		[FieldOffset(8)]
		public IntPtr animLogicParams;

		// Token: 0x0402FF36 RID: 196406
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009529 RID: 38185
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __UpdateAnimInfoMeshAnimRoleNpc_FunctionParams
	{
		// Token: 0x0402FF37 RID: 196407
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF38 RID: 196408
		[FieldOffset(8)]
		public IntPtr animLogicParams;

		// Token: 0x0402FF39 RID: 196409
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200952A RID: 38186
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __UpdateAnimInfoHoldingHandsRoleNpc_FunctionParams
	{
		// Token: 0x0402FF3A RID: 196410
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF3B RID: 196411
		[FieldOffset(8)]
		public IntPtr animLogicParams;

		// Token: 0x0402FF3C RID: 196412
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200952B RID: 38187
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 216)]
	protected ref struct __UpdateFootstepAudioEvent_FunctionParams
	{
		// Token: 0x0402FF3D RID: 196413
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF3E RID: 196414
		[FieldOffset(4)]
		public int roleEntityId;

		// Token: 0x0402FF3F RID: 196415
		[FieldOffset(8)]
		public byte parameters;

		// Token: 0x0402FF40 RID: 196416
		[FieldOffset(208)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200952C RID: 38188
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ChangeTickOverlap_FunctionParams
	{
		// Token: 0x0402FF41 RID: 196417
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF42 RID: 196418
		[FieldOffset(4)]
		public bool overlap;

		// Token: 0x0402FF43 RID: 196419
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200952D RID: 38189
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __AnimTurnLog_FunctionParams
	{
		// Token: 0x0402FF44 RID: 196420
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF45 RID: 196421
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200952E RID: 38190
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __IsNpcTurning_FunctionParams
	{
		// Token: 0x0402FF46 RID: 196422
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF47 RID: 196423
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FF48 RID: 196424
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200952F RID: 38191
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetSightSpeedAndRatio_FunctionParams
	{
		// Token: 0x0402FF49 RID: 196425
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF4A RID: 196426
		[FieldOffset(4)]
		public float speed;

		// Token: 0x0402FF4B RID: 196427
		[FieldOffset(8)]
		public float ratio;

		// Token: 0x0402FF4C RID: 196428
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009530 RID: 38192
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 112)]
	protected ref struct __UpdateAndGetRotateBonesMap_FunctionParams
	{
		// Token: 0x0402FF4D RID: 196429
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF4E RID: 196430
		[FieldOffset(4)]
		public float deltaSeconds;

		// Token: 0x0402FF4F RID: 196431
		[FieldOffset(8)]
		public byte outMap;

		// Token: 0x0402FF50 RID: 196432
		[FieldOffset(88)]
		public FVector outOffset;

		// Token: 0x0402FF51 RID: 196433
		[FieldOffset(104)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009531 RID: 38193
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetSightDirectLimitAngles_FunctionParams
	{
		// Token: 0x0402FF52 RID: 196434
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF53 RID: 196435
		[FieldOffset(4)]
		public float horizontalAngle;

		// Token: 0x0402FF54 RID: 196436
		[FieldOffset(8)]
		public float verticalDownAngle;

		// Token: 0x0402FF55 RID: 196437
		[FieldOffset(12)]
		public float verticalUpAngle;

		// Token: 0x0402FF56 RID: 196438
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009532 RID: 38194
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __SetRotateBonesToTagertDefault_FunctionParams
	{
		// Token: 0x0402FF57 RID: 196439
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF58 RID: 196440
		[FieldOffset(4)]
		public FVector defaultTargetOffset;

		// Token: 0x0402FF59 RID: 196441
		[FieldOffset(16)]
		public float lerpSpeed;

		// Token: 0x0402FF5A RID: 196442
		[FieldOffset(20)]
		public float targetUpdateThreshold;

		// Token: 0x0402FF5B RID: 196443
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009533 RID: 38195
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SetRotateBonesToTagertWithTime_FunctionParams
	{
		// Token: 0x0402FF5C RID: 196444
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF5D RID: 196445
		[FieldOffset(8)]
		public byte boneNames;

		// Token: 0x0402FF5E RID: 196446
		[FieldOffset(24)]
		public float timeLength;

		// Token: 0x0402FF5F RID: 196447
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}
}
