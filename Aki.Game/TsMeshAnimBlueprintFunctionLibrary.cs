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

// Token: 0x0200239F RID: 9119
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsMeshAnimBlueprintFunctionLibrary.TsMeshAnimBlueprintFunctionLibrary_C")]
public class TsMeshAnimBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x06016BC1 RID: 93121 RVA: 0x006A1679 File Offset: 0x0069F879
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

	// Token: 0x06016BC2 RID: 93122 RVA: 0x006A1691 File Offset: 0x0069F891
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

	// Token: 0x06016BC3 RID: 93123 RVA: 0x006A16AC File Offset: 0x0069F8AC
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

	// Token: 0x06016BC4 RID: 93124 RVA: 0x006A16D4 File Offset: 0x0069F8D4
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

	// Token: 0x06016BC5 RID: 93125 RVA: 0x006A16F0 File Offset: 0x0069F8F0
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

	// Token: 0x06016BC6 RID: 93126 RVA: 0x006A1708 File Offset: 0x0069F908
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

	// Token: 0x06016BC7 RID: 93127 RVA: 0x006A1724 File Offset: 0x0069F924
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetDisableBlink(int entityId)
	{
		BaseAnimationComponent component = EntitySystem.Instance.GetComponent<BaseAnimationComponent>(entityId);
		return component != null && component.DisableBlink;
	}

	// Token: 0x06016BC8 RID: 93128 RVA: 0x006A173C File Offset: 0x0069F93C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetIgnoreMontageBlinkCurve(int entityId)
	{
		BaseAnimationComponent component = EntitySystem.Instance.GetComponent<BaseAnimationComponent>(entityId);
		return component != null && component.IgnoreMontageBlinkCurve;
	}

	// Token: 0x06016BC9 RID: 93129 RVA: 0x006A1754 File Offset: 0x0069F954
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

	// Token: 0x06016BCA RID: 93130 RVA: 0x006A1780 File Offset: 0x0069F980
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

	// Token: 0x06016BCB RID: 93131 RVA: 0x006A17D0 File Offset: 0x0069F9D0
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

	// Token: 0x06016BCC RID: 93132 RVA: 0x006A17F4 File Offset: 0x0069F9F4
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

	// Token: 0x06016BCD RID: 93133 RVA: 0x006A180D File Offset: 0x0069FA0D
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

	// Token: 0x06016BCE RID: 93134 RVA: 0x006A1831 File Offset: 0x0069FA31
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

	// Token: 0x06016BCF RID: 93135 RVA: 0x006A1849 File Offset: 0x0069FA49
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetIsCurrentWeaponHideEffectPlaying(int entityId)
	{
		CharacterWeaponComponent component = EntitySystem.Instance.GetComponent<CharacterWeaponComponent>(entityId);
		return component != null && component.IsCurrentWeaponHideEffectPlaying();
	}

	// Token: 0x06016BD0 RID: 93136 RVA: 0x006A1861 File Offset: 0x0069FA61
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

	// Token: 0x06016BD1 RID: 93137 RVA: 0x006A187C File Offset: 0x0069FA7C
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

	// Token: 0x06016BD2 RID: 93138 RVA: 0x006A18A5 File Offset: 0x0069FAA5
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

	// Token: 0x06016BD3 RID: 93139 RVA: 0x006A18CD File Offset: 0x0069FACD
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

	// Token: 0x06016BD4 RID: 93140 RVA: 0x006A18E7 File Offset: 0x0069FAE7
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

	// Token: 0x06016BD5 RID: 93141 RVA: 0x006A1900 File Offset: 0x0069FB00
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

	// Token: 0x06016BD6 RID: 93142 RVA: 0x006A191C File Offset: 0x0069FB1C
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

	// Token: 0x06016BD7 RID: 93143 RVA: 0x006A19B4 File Offset: 0x0069FBB4
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

	// Token: 0x06016BD8 RID: 93144 RVA: 0x006A19D8 File Offset: 0x0069FBD8
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

	// Token: 0x06016BD9 RID: 93145 RVA: 0x006A1A04 File Offset: 0x0069FC04
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

	// Token: 0x06016BDA RID: 93146 RVA: 0x006A1AFC File Offset: 0x0069FCFC
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

	// Token: 0x06016BDB RID: 93147 RVA: 0x006A1CC0 File Offset: 0x0069FEC0
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

	// Token: 0x06016BDC RID: 93148 RVA: 0x006A1E1C File Offset: 0x006A001C
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

	// Token: 0x06016BDD RID: 93149 RVA: 0x006A20FA File Offset: 0x006A02FA
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void ChangeTickOverlap(int entityId, bool overlap)
	{
		EntitySystem.Instance.GetComponent<UeSkeletalTickManageComponent>(entityId).SetTakeOverTick(overlap);
	}

	// Token: 0x06016BDE RID: 93150 RVA: 0x006A2110 File Offset: 0x006A0310
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

	// Token: 0x06016BDF RID: 93151 RVA: 0x006A21A8 File Offset: 0x006A03A8
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool IsNpcTurning(int entityId)
	{
		NpcMoveComponent component = EntitySystem.Instance.GetComponent<NpcMoveComponent>(entityId);
		return component != null && component.IsTurning;
	}

	// Token: 0x06016BE0 RID: 93152 RVA: 0x006A21CC File Offset: 0x006A03CC
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

	// Token: 0x06016BE1 RID: 93153 RVA: 0x006A21E8 File Offset: 0x006A03E8
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

	// Token: 0x06016BE2 RID: 93154 RVA: 0x006A2234 File Offset: 0x006A0434
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

	// Token: 0x06016BE3 RID: 93155 RVA: 0x006A2278 File Offset: 0x006A0478
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

	// Token: 0x06016BE4 RID: 93156 RVA: 0x006A22AC File Offset: 0x006A04AC
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

	// Token: 0x06016BE5 RID: 93157 RVA: 0x006A22E0 File Offset: 0x006A04E0
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsMeshAnimBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsMeshAnimBlueprintFunctionLibrary.TsMeshAnimBlueprintFunctionLibrary_C");
		}
		return TsMeshAnimBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x06016BE6 RID: 93158 RVA: 0x006A2304 File Offset: 0x006A0504
	public TsMeshAnimBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(TsMeshAnimBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06016BE7 RID: 93159 RVA: 0x006A232C File Offset: 0x006A052C
	[NullableContext(1)]
	public TsMeshAnimBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsMeshAnimBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06016BE8 RID: 93160 RVA: 0x006A235F File Offset: 0x006A055F
	protected TsMeshAnimBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06016BE9 RID: 93161 RVA: 0x006A2368 File Offset: 0x006A0568
	protected unsafe static void __CPPCALL_MainAnimInstance_Implementation(TsMeshAnimBlueprintFunctionLibrary.__MainAnimInstance_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		UAnimInstance uanimInstance = TsMeshAnimBlueprintFunctionLibrary.MainAnimInstance(__Params->entityId);
		ptr = ((uanimInstance != null) ? uanimInstance.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06016BEA RID: 93162 RVA: 0x006A238A File Offset: 0x006A058A
	protected unsafe static void __CPPCALL_MainAnimInstanceForVehicle_Implementation(TsMeshAnimBlueprintFunctionLibrary.__MainAnimInstanceForVehicle_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		UAnimInstance uanimInstance = TsMeshAnimBlueprintFunctionLibrary.MainAnimInstanceForVehicle(__Params->entityId);
		ptr = ((uanimInstance != null) ? uanimInstance.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06016BEB RID: 93163 RVA: 0x006A23AC File Offset: 0x006A05AC
	protected unsafe static void __CPPCALL_GetSightDirect_Implementation(TsMeshAnimBlueprintFunctionLibrary.__GetSightDirect_FunctionParams* __Params)
	{
		__Params->__Result = TsMeshAnimBlueprintFunctionLibrary.GetSightDirect(__Params->entityId);
	}

	// Token: 0x06016BEC RID: 93164 RVA: 0x006A23BF File Offset: 0x006A05BF
	protected unsafe static void __CPPCALL_GetHeadBaseYawBuffer_Implementation(TsMeshAnimBlueprintFunctionLibrary.__GetHeadBaseYawBuffer_FunctionParams* __Params)
	{
		__Params->__Result = TsMeshAnimBlueprintFunctionLibrary.GetHeadBaseYawBuffer(__Params->entityId);
	}

	// Token: 0x06016BED RID: 93165 RVA: 0x006A23D2 File Offset: 0x006A05D2
	protected unsafe static void __CPPCALL_GetHulu_Implementation(TsMeshAnimBlueprintFunctionLibrary.__GetHulu_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		UMeshComponent hulu = TsMeshAnimBlueprintFunctionLibrary.GetHulu(__Params->entityId);
		ptr = ((hulu != null) ? hulu.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06016BEE RID: 93166 RVA: 0x006A23F4 File Offset: 0x006A05F4
	protected unsafe static void __CPPCALL_GetBattleIdleTime_Implementation(TsMeshAnimBlueprintFunctionLibrary.__GetBattleIdleTime_FunctionParams* __Params)
	{
		__Params->__Result = TsMeshAnimBlueprintFunctionLibrary.GetBattleIdleTime(__Params->entityId);
	}

	// Token: 0x06016BEF RID: 93167 RVA: 0x006A2407 File Offset: 0x006A0607
	protected unsafe static void __CPPCALL_GetDisableBlink_Implementation(TsMeshAnimBlueprintFunctionLibrary.__GetDisableBlink_FunctionParams* __Params)
	{
		__Params->__Result = TsMeshAnimBlueprintFunctionLibrary.GetDisableBlink(__Params->entityId);
	}

	// Token: 0x06016BF0 RID: 93168 RVA: 0x006A241A File Offset: 0x006A061A
	protected unsafe static void __CPPCALL_GetIgnoreMontageBlinkCurve_Implementation(TsMeshAnimBlueprintFunctionLibrary.__GetIgnoreMontageBlinkCurve_FunctionParams* __Params)
	{
		__Params->__Result = TsMeshAnimBlueprintFunctionLibrary.GetIgnoreMontageBlinkCurve(__Params->entityId);
	}

	// Token: 0x06016BF1 RID: 93169 RVA: 0x006A242D File Offset: 0x006A062D
	protected unsafe static void __CPPCALL_EnterBattleIdle_Implementation(TsMeshAnimBlueprintFunctionLibrary.__EnterBattleIdle_FunctionParams* __Params)
	{
		TsMeshAnimBlueprintFunctionLibrary.EnterBattleIdle(__Params->entityId);
	}

	// Token: 0x06016BF2 RID: 93170 RVA: 0x006A243A File Offset: 0x006A063A
	protected unsafe static void __CPPCALL_SetTransformWithModelBuffer_Implementation(TsMeshAnimBlueprintFunctionLibrary.__SetTransformWithModelBuffer_FunctionParams* __Params)
	{
		TsMeshAnimBlueprintFunctionLibrary.SetTransformWithModelBuffer(__Params->entityId, __Params->transform, __Params->timeLength);
	}

	// Token: 0x06016BF3 RID: 93171 RVA: 0x006A2453 File Offset: 0x006A0653
	protected unsafe static void __CPPCALL_SetSightDirectEnable_Implementation(TsMeshAnimBlueprintFunctionLibrary.__SetSightDirectEnable_FunctionParams* __Params)
	{
		TsMeshAnimBlueprintFunctionLibrary.SetSightDirectEnable(__Params->entityId, __Params->v);
	}

	// Token: 0x06016BF4 RID: 93172 RVA: 0x006A2466 File Offset: 0x006A0666
	protected unsafe static void __CPPCALL_HideWeaponsWhenHideBones_Implementation(TsMeshAnimBlueprintFunctionLibrary.__HideWeaponsWhenHideBones_FunctionParams* __Params)
	{
		TsMeshAnimBlueprintFunctionLibrary.HideWeaponsWhenHideBones(__Params->entityId, __Params->hide, __Params->socketName);
	}

	// Token: 0x06016BF5 RID: 93173 RVA: 0x006A2480 File Offset: 0x006A0680
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

	// Token: 0x06016BF6 RID: 93174 RVA: 0x006A24F8 File Offset: 0x006A06F8
	protected unsafe static void __CPPCALL_GetCurrentWeaponHangState_Implementation(TsMeshAnimBlueprintFunctionLibrary.__GetCurrentWeaponHangState_FunctionParams* __Params)
	{
		__Params->__Result = TsMeshAnimBlueprintFunctionLibrary.GetCurrentWeaponHangState(__Params->entityId);
	}

	// Token: 0x06016BF7 RID: 93175 RVA: 0x006A250B File Offset: 0x006A070B
	protected unsafe static void __CPPCALL_GetIsCurrentWeaponHideEffectPlaying_Implementation(TsMeshAnimBlueprintFunctionLibrary.__GetIsCurrentWeaponHideEffectPlaying_FunctionParams* __Params)
	{
		__Params->__Result = TsMeshAnimBlueprintFunctionLibrary.GetIsCurrentWeaponHideEffectPlaying(__Params->entityId);
	}

	// Token: 0x06016BF8 RID: 93176 RVA: 0x006A2520 File Offset: 0x006A0720
	protected unsafe static void __CPPCALL_ChangeWeapon_Implementation(TsMeshAnimBlueprintFunctionLibrary.__ChangeWeapon_FunctionParams* __Params)
	{
		SWeaponSocketItem weaponSocket = new SWeaponSocketItem(&__Params->weaponSocket, true, true);
		TsMeshAnimBlueprintFunctionLibrary.ChangeWeapon(__Params->entityId, weaponSocket);
	}

	// Token: 0x06016BF9 RID: 93177 RVA: 0x006A2548 File Offset: 0x006A0748
	protected unsafe static void __CPPCALL_GetRandomStandActionIndex_Implementation(TsMeshAnimBlueprintFunctionLibrary.__GetRandomStandActionIndex_FunctionParams* __Params)
	{
		__Params->__Result = TsMeshAnimBlueprintFunctionLibrary.GetRandomStandActionIndex(__Params->entityId);
	}

	// Token: 0x06016BFA RID: 93178 RVA: 0x006A255B File Offset: 0x006A075B
	protected unsafe static void __CPPCALL_HideWeapon_Implementation(TsMeshAnimBlueprintFunctionLibrary.__HideWeapon_FunctionParams* __Params)
	{
		TsMeshAnimBlueprintFunctionLibrary.HideWeapon(__Params->entityId, __Params->hide, __Params->index, __Params->hideEffect, __Params->useHighPriority);
	}

	// Token: 0x06016BFB RID: 93179 RVA: 0x006A2580 File Offset: 0x006A0780
	protected unsafe static void __CPPCALL_HideHulu_Implementation(TsMeshAnimBlueprintFunctionLibrary.__HideHulu_FunctionParams* __Params)
	{
		TsMeshAnimBlueprintFunctionLibrary.HideHulu(__Params->entityId, __Params->bHidden);
	}

	// Token: 0x06016BFC RID: 93180 RVA: 0x006A2593 File Offset: 0x006A0793
	protected unsafe static void __CPPCALL_GetDegMovementSlope_Implementation(TsMeshAnimBlueprintFunctionLibrary.__GetDegMovementSlope_FunctionParams* __Params)
	{
		__Params->__Result = TsMeshAnimBlueprintFunctionLibrary.GetDegMovementSlope(__Params->entityId);
	}

	// Token: 0x06016BFD RID: 93181 RVA: 0x006A25A6 File Offset: 0x006A07A6
	protected unsafe static void __CPPCALL_GetRoleFootStepState_Implementation(TsMeshAnimBlueprintFunctionLibrary.__GetRoleFootStepState_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsMeshAnimBlueprintFunctionLibrary.GetRoleFootStepState(__Params->entityId));
	}

	// Token: 0x06016BFE RID: 93182 RVA: 0x006A25BF File Offset: 0x006A07BF
	protected unsafe static void __CPPCALL_SetIkMeshOffset_Implementation(TsMeshAnimBlueprintFunctionLibrary.__SetIkMeshOffset_FunctionParams* __Params)
	{
		TsMeshAnimBlueprintFunctionLibrary.SetIkMeshOffset(__Params->entityId, __Params->offset);
	}

	// Token: 0x06016BFF RID: 93183 RVA: 0x006A25D2 File Offset: 0x006A07D2
	protected unsafe static void __CPPCALL_GetWeaponBreachLevel_Implementation(TsMeshAnimBlueprintFunctionLibrary.__GetWeaponBreachLevel_FunctionParams* __Params)
	{
		__Params->__Result = TsMeshAnimBlueprintFunctionLibrary.GetWeaponBreachLevel(__Params->entityId);
	}

	// Token: 0x06016C00 RID: 93184 RVA: 0x006A25E8 File Offset: 0x006A07E8
	protected unsafe static void __CPPCALL_UpdateAnimInfoMeshAnim_Implementation(TsMeshAnimBlueprintFunctionLibrary.__UpdateAnimInfoMeshAnim_FunctionParams* __Params)
	{
		BP_ABPLogicParams_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_ABPLogicParams_C>(__Params->animLogicParams);
		TsMeshAnimBlueprintFunctionLibrary.UpdateAnimInfoMeshAnim(__Params->entityId, orCreateUObjectByNativePointer);
	}

	// Token: 0x06016C01 RID: 93185 RVA: 0x006A2610 File Offset: 0x006A0810
	protected unsafe static void __CPPCALL_UpdateAnimInfoMeshAnimRoleNpc_Implementation(TsMeshAnimBlueprintFunctionLibrary.__UpdateAnimInfoMeshAnimRoleNpc_FunctionParams* __Params)
	{
		BP_ABPLogicParams_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_ABPLogicParams_C>(__Params->animLogicParams);
		TsMeshAnimBlueprintFunctionLibrary.UpdateAnimInfoMeshAnimRoleNpc(__Params->entityId, orCreateUObjectByNativePointer);
	}

	// Token: 0x06016C02 RID: 93186 RVA: 0x006A2638 File Offset: 0x006A0838
	protected unsafe static void __CPPCALL_UpdateAnimInfoHoldingHandsRoleNpc_Implementation(TsMeshAnimBlueprintFunctionLibrary.__UpdateAnimInfoHoldingHandsRoleNpc_FunctionParams* __Params)
	{
		BP_ABPLogicParams_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_ABPLogicParams_C>(__Params->animLogicParams);
		TsMeshAnimBlueprintFunctionLibrary.UpdateAnimInfoHoldingHandsRoleNpc(__Params->entityId, orCreateUObjectByNativePointer);
	}

	// Token: 0x06016C03 RID: 93187 RVA: 0x006A2660 File Offset: 0x006A0860
	protected unsafe static void __CPPCALL_UpdateFootstepAudioEvent_Implementation(TsMeshAnimBlueprintFunctionLibrary.__UpdateFootstepAudioEvent_FunctionParams* __Params)
	{
		SFootstepAudioEventParam parameters = new SFootstepAudioEventParam(&__Params->parameters, true, true);
		TsMeshAnimBlueprintFunctionLibrary.UpdateFootstepAudioEvent(__Params->entityId, __Params->roleEntityId, parameters);
	}

	// Token: 0x06016C04 RID: 93188 RVA: 0x006A268E File Offset: 0x006A088E
	protected unsafe static void __CPPCALL_ChangeTickOverlap_Implementation(TsMeshAnimBlueprintFunctionLibrary.__ChangeTickOverlap_FunctionParams* __Params)
	{
		TsMeshAnimBlueprintFunctionLibrary.ChangeTickOverlap(__Params->entityId, __Params->overlap);
	}

	// Token: 0x06016C05 RID: 93189 RVA: 0x006A26A1 File Offset: 0x006A08A1
	protected unsafe static void __CPPCALL_AnimTurnLog_Implementation(TsMeshAnimBlueprintFunctionLibrary.__AnimTurnLog_FunctionParams* __Params)
	{
		TsMeshAnimBlueprintFunctionLibrary.AnimTurnLog(__Params->entityId);
	}

	// Token: 0x06016C06 RID: 93190 RVA: 0x006A26AE File Offset: 0x006A08AE
	protected unsafe static void __CPPCALL_IsNpcTurning_Implementation(TsMeshAnimBlueprintFunctionLibrary.__IsNpcTurning_FunctionParams* __Params)
	{
		__Params->__Result = TsMeshAnimBlueprintFunctionLibrary.IsNpcTurning(__Params->entityId);
	}

	// Token: 0x06016C07 RID: 93191 RVA: 0x006A26C1 File Offset: 0x006A08C1
	protected unsafe static void __CPPCALL_SetSightSpeedAndRatio_Implementation(TsMeshAnimBlueprintFunctionLibrary.__SetSightSpeedAndRatio_FunctionParams* __Params)
	{
		TsMeshAnimBlueprintFunctionLibrary.SetSightSpeedAndRatio(__Params->entityId, __Params->speed, __Params->ratio);
	}

	// Token: 0x06016C08 RID: 93192 RVA: 0x006A26DC File Offset: 0x006A08DC
	protected unsafe static void __CPPCALL_UpdateAndGetRotateBonesMap_Implementation(TsMeshAnimBlueprintFunctionLibrary.__UpdateAndGetRotateBonesMap_FunctionParams* __Params)
	{
		TMap<string, float> tmap = new TMap<string, float>(&__Params->outMap, true, true);
		TsMeshAnimBlueprintFunctionLibrary.UpdateAndGetRotateBonesMap(__Params->entityId, __Params->deltaSeconds, ref tmap, ref __Params->outOffset);
		if (tmap != null)
		{
			tmap.CopyTo(&__Params->outMap, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x06016C09 RID: 93193 RVA: 0x006A272A File Offset: 0x006A092A
	protected unsafe static void __CPPCALL_SetSightDirectLimitAngles_Implementation(TsMeshAnimBlueprintFunctionLibrary.__SetSightDirectLimitAngles_FunctionParams* __Params)
	{
		TsMeshAnimBlueprintFunctionLibrary.SetSightDirectLimitAngles(__Params->entityId, __Params->horizontalAngle, __Params->verticalDownAngle, __Params->verticalUpAngle);
	}

	// Token: 0x06016C0A RID: 93194 RVA: 0x006A2749 File Offset: 0x006A0949
	protected unsafe static void __CPPCALL_SetRotateBonesToTagertDefault_Implementation(TsMeshAnimBlueprintFunctionLibrary.__SetRotateBonesToTagertDefault_FunctionParams* __Params)
	{
		TsMeshAnimBlueprintFunctionLibrary.SetRotateBonesToTagertDefault(__Params->entityId, __Params->defaultTargetOffset, __Params->lerpSpeed, __Params->targetUpdateThreshold);
	}

	// Token: 0x06016C0B RID: 93195 RVA: 0x006A2768 File Offset: 0x006A0968
	protected unsafe static void __CPPCALL_SetRotateBonesToTagertWithTime_Implementation(TsMeshAnimBlueprintFunctionLibrary.__SetRotateBonesToTagertWithTime_FunctionParams* __Params)
	{
		TArray<string> tarray = new TArray<string>(&__Params->boneNames, true, true);
		TsMeshAnimBlueprintFunctionLibrary.SetRotateBonesToTagertWithTime(__Params->entityId, ref tarray, __Params->timeLength);
		if (tarray != null)
		{
			tarray.CopyTo(&__Params->boneNames, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x0400BF2F RID: 48943
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsMeshAnimBlueprintFunctionLibrary.TsMeshAnimBlueprintFunctionLibrary_C";

	// Token: 0x0400BF30 RID: 48944
	private static IntPtr _ClassPtr;

	// Token: 0x0400BF31 RID: 48945
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x02008739 RID: 34617
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __MainAnimInstance_FunctionParams
	{
		// Token: 0x0402B576 RID: 177526
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B577 RID: 177527
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B578 RID: 177528
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x0200873A RID: 34618
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __MainAnimInstanceForVehicle_FunctionParams
	{
		// Token: 0x0402B579 RID: 177529
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B57A RID: 177530
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B57B RID: 177531
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x0200873B RID: 34619
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetSightDirect_FunctionParams
	{
		// Token: 0x0402B57C RID: 177532
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B57D RID: 177533
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B57E RID: 177534
		[FieldOffset(16)]
		public FVector __Result;
	}

	// Token: 0x0200873C RID: 34620
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetHeadBaseYawBuffer_FunctionParams
	{
		// Token: 0x0402B57F RID: 177535
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B580 RID: 177536
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B581 RID: 177537
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x0200873D RID: 34621
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetHulu_FunctionParams
	{
		// Token: 0x0402B582 RID: 177538
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B583 RID: 177539
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B584 RID: 177540
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x0200873E RID: 34622
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetBattleIdleTime_FunctionParams
	{
		// Token: 0x0402B585 RID: 177541
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B586 RID: 177542
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B587 RID: 177543
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x0200873F RID: 34623
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetDisableBlink_FunctionParams
	{
		// Token: 0x0402B588 RID: 177544
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B589 RID: 177545
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B58A RID: 177546
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02008740 RID: 34624
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetIgnoreMontageBlinkCurve_FunctionParams
	{
		// Token: 0x0402B58B RID: 177547
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B58C RID: 177548
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B58D RID: 177549
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02008741 RID: 34625
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EnterBattleIdle_FunctionParams
	{
		// Token: 0x0402B58E RID: 177550
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B58F RID: 177551
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008742 RID: 34626
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 96)]
	protected ref struct __SetTransformWithModelBuffer_FunctionParams
	{
		// Token: 0x0402B590 RID: 177552
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B591 RID: 177553
		[FieldOffset(16)]
		public FTransformDouble transform;

		// Token: 0x0402B592 RID: 177554
		[FieldOffset(80)]
		public float timeLength;

		// Token: 0x0402B593 RID: 177555
		[FieldOffset(88)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008743 RID: 34627
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetSightDirectEnable_FunctionParams
	{
		// Token: 0x0402B594 RID: 177556
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B595 RID: 177557
		[FieldOffset(4)]
		public bool v;

		// Token: 0x0402B596 RID: 177558
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008744 RID: 34628
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __HideWeaponsWhenHideBones_FunctionParams
	{
		// Token: 0x0402B597 RID: 177559
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B598 RID: 177560
		[FieldOffset(4)]
		public bool hide;

		// Token: 0x0402B599 RID: 177561
		[FieldOffset(8)]
		public FName socketName;

		// Token: 0x0402B59A RID: 177562
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008745 RID: 34629
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __ChangeWeaponHangState_FunctionParams
	{
		// Token: 0x0402B59B RID: 177563
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B59C RID: 177564
		[FieldOffset(4)]
		public int weaponState;

		// Token: 0x0402B59D RID: 177565
		[FieldOffset(8)]
		public float lerpTime;

		// Token: 0x0402B59E RID: 177566
		[FieldOffset(16)]
		public byte sockets;

		// Token: 0x0402B59F RID: 177567
		[FieldOffset(32)]
		public byte transforms;

		// Token: 0x0402B5A0 RID: 177568
		[FieldOffset(48)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008746 RID: 34630
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetCurrentWeaponHangState_FunctionParams
	{
		// Token: 0x0402B5A1 RID: 177569
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B5A2 RID: 177570
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B5A3 RID: 177571
		[FieldOffset(16)]
		public int __Result;
	}

	// Token: 0x02008747 RID: 34631
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetIsCurrentWeaponHideEffectPlaying_FunctionParams
	{
		// Token: 0x0402B5A4 RID: 177572
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B5A5 RID: 177573
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B5A6 RID: 177574
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02008748 RID: 34632
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 104)]
	protected ref struct __ChangeWeapon_FunctionParams
	{
		// Token: 0x0402B5A7 RID: 177575
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B5A8 RID: 177576
		[FieldOffset(8)]
		public byte weaponSocket;

		// Token: 0x0402B5A9 RID: 177577
		[FieldOffset(96)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008749 RID: 34633
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetRandomStandActionIndex_FunctionParams
	{
		// Token: 0x0402B5AA RID: 177578
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B5AB RID: 177579
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B5AC RID: 177580
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x0200874A RID: 34634
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __HideWeapon_FunctionParams
	{
		// Token: 0x0402B5AD RID: 177581
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B5AE RID: 177582
		[FieldOffset(4)]
		public bool hide;

		// Token: 0x0402B5AF RID: 177583
		[FieldOffset(8)]
		public int index;

		// Token: 0x0402B5B0 RID: 177584
		[FieldOffset(12)]
		public bool hideEffect;

		// Token: 0x0402B5B1 RID: 177585
		[FieldOffset(13)]
		public bool useHighPriority;

		// Token: 0x0402B5B2 RID: 177586
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200874B RID: 34635
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __HideHulu_FunctionParams
	{
		// Token: 0x0402B5B3 RID: 177587
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B5B4 RID: 177588
		[FieldOffset(4)]
		public bool bHidden;

		// Token: 0x0402B5B5 RID: 177589
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200874C RID: 34636
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetDegMovementSlope_FunctionParams
	{
		// Token: 0x0402B5B6 RID: 177590
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B5B7 RID: 177591
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B5B8 RID: 177592
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x0200874D RID: 34637
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetRoleFootStepState_FunctionParams
	{
		// Token: 0x0402B5B9 RID: 177593
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B5BA RID: 177594
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B5BB RID: 177595
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x0200874E RID: 34638
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetIkMeshOffset_FunctionParams
	{
		// Token: 0x0402B5BC RID: 177596
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B5BD RID: 177597
		[FieldOffset(4)]
		public float offset;

		// Token: 0x0402B5BE RID: 177598
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200874F RID: 34639
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetWeaponBreachLevel_FunctionParams
	{
		// Token: 0x0402B5BF RID: 177599
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B5C0 RID: 177600
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B5C1 RID: 177601
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02008750 RID: 34640
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __UpdateAnimInfoMeshAnim_FunctionParams
	{
		// Token: 0x0402B5C2 RID: 177602
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B5C3 RID: 177603
		[FieldOffset(8)]
		public IntPtr animLogicParams;

		// Token: 0x0402B5C4 RID: 177604
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008751 RID: 34641
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __UpdateAnimInfoMeshAnimRoleNpc_FunctionParams
	{
		// Token: 0x0402B5C5 RID: 177605
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B5C6 RID: 177606
		[FieldOffset(8)]
		public IntPtr animLogicParams;

		// Token: 0x0402B5C7 RID: 177607
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008752 RID: 34642
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __UpdateAnimInfoHoldingHandsRoleNpc_FunctionParams
	{
		// Token: 0x0402B5C8 RID: 177608
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B5C9 RID: 177609
		[FieldOffset(8)]
		public IntPtr animLogicParams;

		// Token: 0x0402B5CA RID: 177610
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008753 RID: 34643
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 216)]
	protected ref struct __UpdateFootstepAudioEvent_FunctionParams
	{
		// Token: 0x0402B5CB RID: 177611
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B5CC RID: 177612
		[FieldOffset(4)]
		public int roleEntityId;

		// Token: 0x0402B5CD RID: 177613
		[FieldOffset(8)]
		public byte parameters;

		// Token: 0x0402B5CE RID: 177614
		[FieldOffset(208)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008754 RID: 34644
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ChangeTickOverlap_FunctionParams
	{
		// Token: 0x0402B5CF RID: 177615
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B5D0 RID: 177616
		[FieldOffset(4)]
		public bool overlap;

		// Token: 0x0402B5D1 RID: 177617
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008755 RID: 34645
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __AnimTurnLog_FunctionParams
	{
		// Token: 0x0402B5D2 RID: 177618
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B5D3 RID: 177619
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008756 RID: 34646
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __IsNpcTurning_FunctionParams
	{
		// Token: 0x0402B5D4 RID: 177620
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B5D5 RID: 177621
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B5D6 RID: 177622
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02008757 RID: 34647
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetSightSpeedAndRatio_FunctionParams
	{
		// Token: 0x0402B5D7 RID: 177623
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B5D8 RID: 177624
		[FieldOffset(4)]
		public float speed;

		// Token: 0x0402B5D9 RID: 177625
		[FieldOffset(8)]
		public float ratio;

		// Token: 0x0402B5DA RID: 177626
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008758 RID: 34648
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 112)]
	protected ref struct __UpdateAndGetRotateBonesMap_FunctionParams
	{
		// Token: 0x0402B5DB RID: 177627
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B5DC RID: 177628
		[FieldOffset(4)]
		public float deltaSeconds;

		// Token: 0x0402B5DD RID: 177629
		[FieldOffset(8)]
		public byte outMap;

		// Token: 0x0402B5DE RID: 177630
		[FieldOffset(88)]
		public FVector outOffset;

		// Token: 0x0402B5DF RID: 177631
		[FieldOffset(104)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008759 RID: 34649
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetSightDirectLimitAngles_FunctionParams
	{
		// Token: 0x0402B5E0 RID: 177632
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B5E1 RID: 177633
		[FieldOffset(4)]
		public float horizontalAngle;

		// Token: 0x0402B5E2 RID: 177634
		[FieldOffset(8)]
		public float verticalDownAngle;

		// Token: 0x0402B5E3 RID: 177635
		[FieldOffset(12)]
		public float verticalUpAngle;

		// Token: 0x0402B5E4 RID: 177636
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200875A RID: 34650
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __SetRotateBonesToTagertDefault_FunctionParams
	{
		// Token: 0x0402B5E5 RID: 177637
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B5E6 RID: 177638
		[FieldOffset(4)]
		public FVector defaultTargetOffset;

		// Token: 0x0402B5E7 RID: 177639
		[FieldOffset(16)]
		public float lerpSpeed;

		// Token: 0x0402B5E8 RID: 177640
		[FieldOffset(20)]
		public float targetUpdateThreshold;

		// Token: 0x0402B5E9 RID: 177641
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200875B RID: 34651
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SetRotateBonesToTagertWithTime_FunctionParams
	{
		// Token: 0x0402B5EA RID: 177642
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B5EB RID: 177643
		[FieldOffset(8)]
		public byte boneNames;

		// Token: 0x0402B5EC RID: 177644
		[FieldOffset(24)]
		public float timeLength;

		// Token: 0x0402B5ED RID: 177645
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}
}
