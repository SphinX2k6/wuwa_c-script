using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using AkiClient.Game.Aki.AI.AIFunctionCommon;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.Input.Blueprints;
using AkiClient.Game.Aki.Character.Input.ControlMonster;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move;
using CSharpScript.Game.Utils;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020023A0 RID: 9120
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsMoveBlueprintFunctionLibrary.TsMoveBlueprintFunctionLibrary_C")]
public class TsMoveBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x06016C0C RID: 93196 RVA: 0x006A27B0 File Offset: 0x006A09B0
	static TsMoveBlueprintFunctionLibrary()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsMoveBlueprintFunctionLibrary.CreateStaticDefaultValue), new Action(TsMoveBlueprintFunctionLibrary.ResetStaticDefaultValue));
	}

	// Token: 0x06016C0D RID: 93197 RVA: 0x006A2834 File Offset: 0x006A0A34
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool SetActorRotationWithPriority(int entityId, FRotator value, bool sweep = false, string context = "unknown")
	{
		CharacterActorComponent component = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityId);
		return component != null && component.SetActorRotationWithPriority(value, "BlueprintAPI." + context, ESetRotationPriority.Movement, true, sweep);
	}

	// Token: 0x06016C0E RID: 93198 RVA: 0x006A2868 File Offset: 0x006A0A68
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool SetActorLocationWithContext(int entityId, FVectorDouble location, bool sweep = false, string context = "unknown")
	{
		BaseActorComponent component = EntitySystem.Instance.GetComponent<BaseActorComponent>(entityId);
		return component != null && component.SetActorLocation(location, "BlueprintAPI." + context, sweep);
	}

	// Token: 0x06016C0F RID: 93199 RVA: 0x006A289C File Offset: 0x006A0A9C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetActorLocationAndRotationWithContext(int entityId, FVectorDouble location, FRotator rotation, bool sweep = false, string context = "unknown")
	{
		BaseActorComponent component = EntitySystem.Instance.GetComponent<BaseActorComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.SetActorLocationAndRotation(location, rotation, "BlueprintAPI." + context, sweep, null);
	}

	// Token: 0x06016C10 RID: 93200 RVA: 0x006A28D8 File Offset: 0x006A0AD8
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool SetActorRotationWithContext(int entityId, FRotator rotation, bool sweep, string context)
	{
		BaseActorComponent component = EntitySystem.Instance.GetComponent<BaseActorComponent>(entityId);
		return component != null && component.SetActorRotation(rotation, "BlueprintAPI." + context, sweep);
	}

	// Token: 0x06016C11 RID: 93201 RVA: 0x006A290C File Offset: 0x006A0B0C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void AddActorWorldOffsetWithContext(int entityId, FVectorDouble offset, bool sweep = true, string context = "unknown")
	{
		BaseActorComponent component = EntitySystem.Instance.GetComponent<BaseActorComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.AddActorWorldOffset(offset, "BlueprintAPI." + context, sweep);
	}

	// Token: 0x06016C12 RID: 93202 RVA: 0x006A293C File Offset: 0x006A0B3C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void AddActorWorldOffsetWithContextAndReset(int entityId, FVectorDouble offset, bool sweep = true, string context = "unknown")
	{
		CharacterActorComponent component = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.AddActorWorldOffsetWithReset(offset, "BlueprintAPI." + context, sweep);
	}

	// Token: 0x06016C13 RID: 93203 RVA: 0x006A296C File Offset: 0x006A0B6C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void AddActorLocalOffsetWithContext(int entityId, FVectorDouble offset, bool sweep = true, string context = "unknown")
	{
		BaseActorComponent component = EntitySystem.Instance.GetComponent<BaseActorComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.AddActorLocalOffset(offset, "BlueprintAPI." + context, sweep);
	}

	// Token: 0x06016C14 RID: 93204 RVA: 0x006A299C File Offset: 0x006A0B9C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void AddActorWorldRotationWithContext(int entityId, FRotator rotation, bool sweep = false, string context = "unknown")
	{
		BaseActorComponent component = EntitySystem.Instance.GetComponent<BaseActorComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.AddActorWorldRotation(rotation, "BlueprintAPI." + context, sweep);
	}

	// Token: 0x06016C15 RID: 93205 RVA: 0x006A29CC File Offset: 0x006A0BCC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void AddActorLocalRotationWithContext(int entityId, FRotator rotation, bool sweep = false, string context = "unknown")
	{
		BaseActorComponent component = EntitySystem.Instance.GetComponent<BaseActorComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.AddActorLocalRotation(rotation, "BlueprintAPI." + context, sweep);
	}

	// Token: 0x06016C16 RID: 93206 RVA: 0x006A29FC File Offset: 0x006A0BFC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void ActorTeleportToWithContext(int entityId, FVectorDouble location, FRotator rotation, string context = "unknown")
	{
		BaseActorComponent component = EntitySystem.Instance.GetComponent<BaseActorComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.TeleportTo(location, rotation, "BlueprintAPI." + context);
	}

	// Token: 0x06016C17 RID: 93207 RVA: 0x006A2A30 File Offset: 0x006A0C30
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool SetActorLookAtWithContext(int entityId, FVectorDouble targetPoint, string context)
	{
		BaseActorComponent component = EntitySystem.Instance.GetComponent<BaseActorComponent>(entityId);
		if (component == null)
		{
			return false;
		}
		TsMoveBlueprintFunctionLibrary.tmpVector.FromUeVector(targetPoint);
		TsMoveBlueprintFunctionLibrary.tmpVector.SubtractionEqual(component.ActorLocationProxy);
		MathUtils instance = MathUtils.Instance;
		global::Vector forward = TsMoveBlueprintFunctionLibrary.tmpVector;
		BaseMoveComponent moveComp = component.MoveComp;
		instance.LookRotationUpFirst(forward, ((moveComp != null) ? moveComp.GravityUp : null) ?? global::Vector.UpVectorProxy, TsMoveBlueprintFunctionLibrary.tmpQuat);
		TsMoveBlueprintFunctionLibrary.tmpQuat.Rotator(TsMoveBlueprintFunctionLibrary.tmpRotator);
		return component.SetActorRotation(TsMoveBlueprintFunctionLibrary.tmpRotator.ToUeRotator(), "BlueprintAPI." + context + ".LookAt", false);
	}

	// Token: 0x06016C18 RID: 93208 RVA: 0x006A2ACC File Offset: 0x006A0CCC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void ActorKuroMoveAlongFloorWithContext(int entityId, FVector velocity, float deltaSeconds, string context = "unknown")
	{
		CharacterActorComponent component = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.KuroMoveAlongFloor(velocity, deltaSeconds, "BlueprintAPI." + context);
	}

	// Token: 0x06016C19 RID: 93209 RVA: 0x006A2AFC File Offset: 0x006A0CFC
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static FVectorDouble GetInputDirect(int entityId)
	{
		CharacterActorComponent component = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityId);
		if (component == null)
		{
			return global::Vector.ZeroVectorDouble;
		}
		return component.InputDirect;
	}

	// Token: 0x06016C1A RID: 93210 RVA: 0x006A2B18 File Offset: 0x006A0D18
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetInputDirect(int entityId, FVectorDouble direct)
	{
		CharacterActorComponent component = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.SetInputDirect(global::Vector.Create(direct), false, EInputDirectSpace.World);
	}

	// Token: 0x06016C1B RID: 93211 RVA: 0x006A2B41 File Offset: 0x006A0D41
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static FRotator GetInputRotator(int entityId)
	{
		CharacterActorComponent component = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityId);
		if (component == null)
		{
			return global::Rotator.ZeroRotator;
		}
		return component.InputRotatorProxy.ToUeRotator();
	}

	// Token: 0x06016C1C RID: 93212 RVA: 0x006A2B62 File Offset: 0x006A0D62
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetInputRotator(int entityId, FRotator rotator)
	{
		CharacterActorComponent component = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.SetInputRotator(rotator);
	}

	// Token: 0x06016C1D RID: 93213 RVA: 0x006A2B80 File Offset: 0x006A0D80
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetCharacterHidden(int entityId, bool isHidden, UObject callObject, string reason)
	{
		if (callObject == null || !callObject.IsValid())
		{
			Log.Instance.Error(ELogModule.Entity, ELogAuthor.LFJW, "调用SetCharacterHidden失败，因为callObject为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		string reason2 = "[蓝图:" + callObject.GetName() + "] " + reason;
		Entity entity = EntitySystem.Instance.Get(entityId);
		if (entity != null && entity.Valid)
		{
			CreatureController.Instance.SetActorVisible(entity, !isHidden, !isHidden, !isHidden, reason2, true);
		}
	}

	// Token: 0x06016C1E RID: 93214 RVA: 0x006A2BFB File Offset: 0x006A0DFB
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetHiddenMovementMode(int entityId, bool isHidden)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.SetHiddenMovementMode(isHidden);
	}

	// Token: 0x06016C1F RID: 93215 RVA: 0x006A2C13 File Offset: 0x006A0E13
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool CanResponseInput(int entityId)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		return component != null && component.CanResponseInput();
	}

	// Token: 0x06016C20 RID: 93216 RVA: 0x006A2C2B File Offset: 0x006A0E2B
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool CanJumpPress(int entityId)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		return component != null && component.CanJumpPress();
	}

	// Token: 0x06016C21 RID: 93217 RVA: 0x006A2C43 File Offset: 0x006A0E43
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool CanWalkPress(int entityId)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		return component != null && component.CanWalkPress();
	}

	// Token: 0x06016C22 RID: 93218 RVA: 0x006A2C5C File Offset: 0x006A0E5C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetHeightAboveGround(int entityId, float detectedHeight = 500f)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		if (component != null)
		{
			return component.GetHeightAboveGround(Math.Max(500f, detectedHeight));
		}
		VehicleMoveComponent component2 = EntitySystem.Instance.GetComponent<VehicleMoveComponent>(entityId);
		if (component2 == null)
		{
			return detectedHeight;
		}
		return component2.GetHeightAboveGround(Math.Max(500f, detectedHeight));
	}

	// Token: 0x06016C23 RID: 93219 RVA: 0x006A2CAB File Offset: 0x006A0EAB
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static FVector GetAcceleration(int entityId)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		if (component == null)
		{
			return new FVector();
		}
		return component.Acceleration.ToUeVectorOld();
	}

	// Token: 0x06016C24 RID: 93220 RVA: 0x006A2CCC File Offset: 0x006A0ECC
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetAimYawRate(int entityId)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		if (component == null)
		{
			return 0f;
		}
		return component.AimYawRate;
	}

	// Token: 0x06016C25 RID: 93221 RVA: 0x006A2CE8 File Offset: 0x006A0EE8
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static SMovementSetting_State GetMovementData(int entityId)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		return ((component != null) ? component.MovementData : null) ?? new SMovementSetting_State();
	}

	// Token: 0x06016C26 RID: 93222 RVA: 0x006A2D0A File Offset: 0x006A0F0A
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SmoothCharacterRotation(int entityId, FRotator target, float speed, string context)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.SmoothCharacterRotation(target, speed, Time.Instance.DeltaTimeSeconds, false, context, true);
	}

	// Token: 0x06016C27 RID: 93223 RVA: 0x006A2D35 File Offset: 0x006A0F35
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool HasMoveInput(int entityId)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		return component != null && component.HasMoveInput;
	}

	// Token: 0x06016C28 RID: 93224 RVA: 0x006A2D50 File Offset: 0x006A0F50
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool HasMoveInputOrTickIntervalAndModelBuffer(int entityId)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		if (component != null && component.HasMoveInput)
		{
			return true;
		}
		Entity entity = EntitySystem.Instance.Get(entityId);
		if (entity == null || entity.GetTickInterval() <= 1)
		{
			return false;
		}
		CharacterAnimationComponent component2 = EntitySystem.Instance.GetComponent<CharacterAnimationComponent>(entityId);
		return component2 != null && component2.HasLocationModelBuffer();
	}

	// Token: 0x06016C29 RID: 93225 RVA: 0x006A2DA8 File Offset: 0x006A0FA8
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool HasRotatorInput(int entityId)
	{
		CharacterActorComponent component = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityId);
		return GravityUtils.Instance.GetAngleOffsetFromCurrentToInputAbs(component) > 10f;
	}

	// Token: 0x06016C2A RID: 93226 RVA: 0x006A2DD3 File Offset: 0x006A0FD3
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool IsMoving(int entityId)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		return component != null && component.IsMoving;
	}

	// Token: 0x06016C2B RID: 93227 RVA: 0x006A2DEB File Offset: 0x006A0FEB
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool IsJump(int entityId)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		return component != null && component.IsJump;
	}

	// Token: 0x06016C2C RID: 93228 RVA: 0x006A2E03 File Offset: 0x006A1003
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetSpeed(int entityId)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		if (component == null)
		{
			return 0f;
		}
		return component.Speed;
	}

	// Token: 0x06016C2D RID: 93229 RVA: 0x006A2E1F File Offset: 0x006A101F
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetGroundedTime(int entityId)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		if (component == null)
		{
			return 0f;
		}
		return component.GroundedTimeUe;
	}

	// Token: 0x06016C2E RID: 93230 RVA: 0x006A2E3B File Offset: 0x006A103B
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool IsFallingIntoWater(int entityId)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		return component != null && component.IsFallingIntoWater;
	}

	// Token: 0x06016C2F RID: 93231 RVA: 0x006A2E54 File Offset: 0x006A1054
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetForceSpeed(int entityId, FVectorDouble speed)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		if (component != null)
		{
			component.SetForceSpeed(speed);
			return;
		}
		VehicleMoveComponent component2 = EntitySystem.Instance.GetComponent<VehicleMoveComponent>(entityId);
		if (component2 == null)
		{
			return;
		}
		component2.SetForceSpeed(speed);
	}

	// Token: 0x06016C30 RID: 93232 RVA: 0x006A2E98 File Offset: 0x006A1098
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetAddMove(int entityId, UMeshComponent mesh, FVectorDouble speed, float timeLength, UCurveFloat curve)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.SetAddMoveWithMesh(mesh, speed, timeLength, curve);
	}

	// Token: 0x06016C31 RID: 93233 RVA: 0x006A2EB4 File Offset: 0x006A10B4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void StopAddMove(int entityId, UMeshComponent mesh)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.StopAddMoveWithMesh(mesh);
	}

	// Token: 0x06016C32 RID: 93234 RVA: 0x006A2ED0 File Offset: 0x006A10D0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static FHitResult FixActorLocation(int entityId, FVectorDouble target, float offset)
	{
		CharacterActorComponent component = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityId);
		FHitResult fhitResult = new FHitResult();
		if (component != null && component.Valid)
		{
			global::Vector commonTempVector = MathUtils.Instance.CommonTempVector;
			commonTempVector.FromUeVector(target);
			ValueTuple<bool, global::Vector> valueTuple = component.FixActorLocation(offset, true, commonTempVector, "TsMoveBlueprintFunctionLibrary.FixActorLocation", true, false);
			if (valueTuple.Item1)
			{
				fhitResult.bBlockingHit = true;
				fhitResult.Location = new FVector_NetQuantize((float)valueTuple.Item2.X, (float)valueTuple.Item2.Y, (float)valueTuple.Item2.Z);
				return fhitResult;
			}
		}
		fhitResult.bBlockingHit = false;
		return fhitResult;
	}

	// Token: 0x06016C33 RID: 93235 RVA: 0x006A2F66 File Offset: 0x006A1166
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void StopAllAddMove(int entityId)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.StopAllAddMove();
	}

	// Token: 0x06016C34 RID: 93236 RVA: 0x006A2F7D File Offset: 0x006A117D
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetAddMoveWorld(int entityId, UMeshComponent mesh, FVectorDouble speed, float timeLength, UCurveFloat curve)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.SetAddMoveWorldWithMesh(mesh, speed, timeLength, curve);
	}

	// Token: 0x06016C35 RID: 93237 RVA: 0x006A2F99 File Offset: 0x006A1199
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetAddMoveWorldSpeed(int entityId, UMeshComponent mesh, FVectorDouble speed)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.SetAddMoveWorldSpeedWithMesh(mesh, speed);
	}

	// Token: 0x06016C36 RID: 93238 RVA: 0x006A2FB2 File Offset: 0x006A11B2
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetAddMoveOffset(int entityId, FVectorDouble offset)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.SetAddMoveOffset(new FVectorDouble?(offset));
	}

	// Token: 0x06016C37 RID: 93239 RVA: 0x006A2FCF File Offset: 0x006A11CF
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetAddMoveRotation(int entityId, FRotator rotation)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.SetAddMoveRotation(rotation);
	}

	// Token: 0x06016C38 RID: 93240 RVA: 0x006A2FE7 File Offset: 0x006A11E7
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetEnterWaterState(int entityId, bool isEnter)
	{
		CharacterSwimComponent component = EntitySystem.Instance.GetComponent<CharacterSwimComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.SetEnterWaterState(isEnter);
	}

	// Token: 0x06016C39 RID: 93241 RVA: 0x006A3000 File Offset: 0x006A1200
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static AkiClient.Game.Aki.Character.BaseCharacter.SClimbState GetClimbState(int entityId)
	{
		CharacterClimbComponent component = EntitySystem.Instance.GetComponent<CharacterClimbComponent>(entityId);
		if (component == null)
		{
			return default(AkiClient.Game.Aki.Character.BaseCharacter.SClimbState);
		}
		return component.GetClimbState();
	}

	// Token: 0x06016C3A RID: 93242 RVA: 0x006A302B File Offset: 0x006A122B
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetClimbRadius(int entityId)
	{
		CharacterClimbComponent component = EntitySystem.Instance.GetComponent<CharacterClimbComponent>(entityId);
		if (component == null)
		{
			return 0f;
		}
		return component.GetClimbRadius();
	}

	// Token: 0x06016C3B RID: 93243 RVA: 0x006A3048 File Offset: 0x006A1248
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static AkiClient.Game.Aki.Character.BaseCharacter.SClimbInfo GetClimbInfo(int entityId)
	{
		CharacterClimbComponent component = EntitySystem.Instance.GetComponent<CharacterClimbComponent>(entityId);
		if (component == null)
		{
			return default(AkiClient.Game.Aki.Character.BaseCharacter.SClimbInfo);
		}
		return component.GetClimbInfo();
	}

	// Token: 0x06016C3C RID: 93244 RVA: 0x006A3073 File Offset: 0x006A1273
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void KickExitCheck(int entityId)
	{
		CharacterClimbComponent component = EntitySystem.Instance.GetComponent<CharacterClimbComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.KickExitCheck();
	}

	// Token: 0x06016C3D RID: 93245 RVA: 0x006A308A File Offset: 0x006A128A
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool CanClimbPress(int entityId)
	{
		CharacterClimbComponent component = EntitySystem.Instance.GetComponent<CharacterClimbComponent>(entityId);
		return component != null && component.CanClimbPress();
	}

	// Token: 0x06016C3E RID: 93246 RVA: 0x006A30A2 File Offset: 0x006A12A2
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void OnEnterClimb(int entityId)
	{
		CharacterClimbComponent component = EntitySystem.Instance.GetComponent<CharacterClimbComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.OnEnterClimb();
	}

	// Token: 0x06016C3F RID: 93247 RVA: 0x006A30B9 File Offset: 0x006A12B9
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void OnExitClimb(int entityId)
	{
		CharacterClimbComponent component = EntitySystem.Instance.GetComponent<CharacterClimbComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.OnExitClimb();
	}

	// Token: 0x06016C40 RID: 93248 RVA: 0x006A30D0 File Offset: 0x006A12D0
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void DealClimbUpStart(int entityId)
	{
		CharacterClimbComponent component = EntitySystem.Instance.GetComponent<CharacterClimbComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.DealClimbUpStart();
	}

	// Token: 0x06016C41 RID: 93249 RVA: 0x006A30E7 File Offset: 0x006A12E7
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void FinishClimbDown(int entityId)
	{
		CharacterClimbComponent component = EntitySystem.Instance.GetComponent<CharacterClimbComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.FinishClimbDown();
	}

	// Token: 0x06016C42 RID: 93250 RVA: 0x006A30FE File Offset: 0x006A12FE
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void DealClimbUpFinish(int entityId)
	{
		CharacterClimbComponent component = EntitySystem.Instance.GetComponent<CharacterClimbComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.DealClimbUpFinish();
	}

	// Token: 0x06016C43 RID: 93251 RVA: 0x006A3115 File Offset: 0x006A1315
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetClimbState(int entityId, EClimbState climbState)
	{
		CharacterClimbComponent component = EntitySystem.Instance.GetComponent<CharacterClimbComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.SetClimbState(climbState);
	}

	// Token: 0x06016C44 RID: 93252 RVA: 0x006A312D File Offset: 0x006A132D
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetEnterClimbType(int entityId, EEnterClimb enterType)
	{
		CharacterClimbComponent component = EntitySystem.Instance.GetComponent<CharacterClimbComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.SetEnterClimbType(enterType);
	}

	// Token: 0x06016C45 RID: 93253 RVA: 0x006A3145 File Offset: 0x006A1345
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetExitClimbType(int entityId, EExitClimb exitType)
	{
		CharacterClimbComponent component = EntitySystem.Instance.GetComponent<CharacterClimbComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.SetExitClimbType(exitType);
	}

	// Token: 0x06016C46 RID: 93254 RVA: 0x006A315D File Offset: 0x006A135D
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static FVectorDouble GetSwimLocation(int entityId)
	{
		CharacterSwimComponent component = EntitySystem.Instance.GetComponent<CharacterSwimComponent>(entityId);
		if (component == null)
		{
			return new FVectorDouble();
		}
		return component.GetSwimLocation();
	}

	// Token: 0x06016C47 RID: 93255 RVA: 0x006A3179 File Offset: 0x006A1379
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static FVectorDouble GetWaterLocation(int entityId)
	{
		CharacterSwimComponent component = EntitySystem.Instance.GetComponent<CharacterSwimComponent>(entityId);
		if (component == null)
		{
			return new FVectorDouble();
		}
		return component.GetWaterLocation();
	}

	// Token: 0x06016C48 RID: 93256 RVA: 0x006A3195 File Offset: 0x006A1395
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetWaterVolume(int entityId)
	{
		CharacterSwimComponent component = EntitySystem.Instance.GetComponent<CharacterSwimComponent>(entityId);
		return component != null && component.GetWaterVolume();
	}

	// Token: 0x06016C49 RID: 93257 RVA: 0x006A31AD File Offset: 0x006A13AD
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetClimbOnWallAngle(int entityId)
	{
		CharacterClimbComponent component = EntitySystem.Instance.GetComponent<CharacterClimbComponent>(entityId);
		if (component == null)
		{
			return 0f;
		}
		return component.GetOnWallAngle();
	}

	// Token: 0x06016C4A RID: 93258 RVA: 0x006A31C9 File Offset: 0x006A13C9
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetUseDebugMovementSetting(int entityId, bool newSelect)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.SetUseDebugMovementSetting(newSelect);
	}

	// Token: 0x06016C4B RID: 93259 RVA: 0x006A31E1 File Offset: 0x006A13E1
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetDebugMovementSetting(int entityId, SMovementSetting newSetting)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.SetDebugMovementSetting(newSetting);
	}

	// Token: 0x06016C4C RID: 93260 RVA: 0x006A31F9 File Offset: 0x006A13F9
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetLockedRotation(int entityId, bool lockedRotation)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.SetLockedRotation(lockedRotation);
	}

	// Token: 0x06016C4D RID: 93261 RVA: 0x006A3211 File Offset: 0x006A1411
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetLockedRotation(int entityId)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		return component != null && component.LockedRotation;
	}

	// Token: 0x06016C4E RID: 93262 RVA: 0x006A3229 File Offset: 0x006A1429
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetFallingHorizontalMaxSpeed(int entityId, float speed)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.SetFallingHorizontalMaxSpeed(speed);
	}

	// Token: 0x06016C4F RID: 93263 RVA: 0x006A3241 File Offset: 0x006A1441
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void ClearFallingHorizontalMaxSpeed(int entityId)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.ClearFallingHorizontalMaxSpeed();
	}

	// Token: 0x06016C50 RID: 93264 RVA: 0x006A3258 File Offset: 0x006A1458
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool DetectClimbWithDirect(int entityId, bool bSprintEnter, FVectorDouble direct)
	{
		CharacterClimbComponent component = EntitySystem.Instance.GetComponent<CharacterClimbComponent>(entityId);
		return component != null && component.DetectClimbWithDirect(bSprintEnter, direct, false);
	}

	// Token: 0x06016C51 RID: 93265 RVA: 0x006A3274 File Offset: 0x006A1474
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void TurnToTarget(int entityId, AActor target, float speed)
	{
		CharacterActorComponent component = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityId);
		if (component == null)
		{
			return;
		}
		if (target is TsBaseCharacter)
		{
			CharacterAnimationComponent component2 = EntitySystem.Instance.GetComponent<CharacterAnimationComponent>(entityId);
			if (component2 != null)
			{
				component2.MontageManager.StopMontage(new IStopMontageParam
				{
					Method = new EStopMethod?(EStopMethod.BlendOut),
					BlendOutTime = new float?(0f)
				});
			}
			global::Vector actorLocationProxy = component.ActorLocationProxy;
			global::Vector actorLocationProxy2 = ((TsBaseCharacter)target).CharacterActorComponent.ActorLocationProxy;
			global::Vector commonTempVector = MathUtils.Instance.CommonTempVector;
			actorLocationProxy2.Subtraction(actorLocationProxy, commonTempVector);
			global::Rotator commonTempRotator = MathUtils.Instance.CommonTempRotator;
			BaseMoveComponent component3 = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
			commonTempVector.ToOrientationRotator(commonTempRotator);
			if (component3 == null)
			{
				return;
			}
			component3.SmoothCharacterRotation(commonTempRotator, speed, Time.Instance.DeltaTimeSeconds, false, "Movement.SmoothCharacterRotation", true);
		}
	}

	// Token: 0x06016C52 RID: 93266 RVA: 0x006A3340 File Offset: 0x006A1540
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static EMovementDirection GetMonsterMoveDirection(int entityId)
	{
		CharacterActorComponent component = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityId);
		if (component == null)
		{
			return EMovementDirection.停;
		}
		if (component.InputDirectProxy.IsNearlyZero(9.999999747378752E-05))
		{
			return EMovementDirection.停;
		}
		component.ActorQuatProxy.Inverse(TsMoveBlueprintFunctionLibrary.tmpQuat);
		TsMoveBlueprintFunctionLibrary.tmpQuat.RotateVector(component.InputDirectProxy, TsMoveBlueprintFunctionLibrary.tmpVector);
		if (Math.Abs(TsMoveBlueprintFunctionLibrary.tmpVector.X) > Math.Abs(TsMoveBlueprintFunctionLibrary.tmpVector.Y))
		{
			if (TsMoveBlueprintFunctionLibrary.tmpVector.X <= 0.0)
			{
				return EMovementDirection.后;
			}
			return EMovementDirection.前;
		}
		else
		{
			if (TsMoveBlueprintFunctionLibrary.tmpVector.Y <= 0.0)
			{
				return EMovementDirection.左;
			}
			return EMovementDirection.右;
		}
	}

	// Token: 0x06016C53 RID: 93267 RVA: 0x006A33EC File Offset: 0x006A15EC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetRoleBody(int entityId)
	{
		CharacterActorComponent component = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityId);
		if (component == null)
		{
			return "";
		}
		CreatureDataComponent creatureData = component.CreatureData;
		if (creatureData != null && creatureData.GetEntityType() == EEntityType.Player)
		{
			return component.CreatureData.GetRoleConfig().Value.RoleBody;
		}
		return "";
	}

	// Token: 0x06016C54 RID: 93268 RVA: 0x006A3448 File Offset: 0x006A1648
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetRacingRightSpeed(int entityId)
	{
		CharacterSplineMoveComponent component = EntitySystem.Instance.GetComponent<CharacterSplineMoveComponent>(entityId);
		return (component != null) ? component.LastRightSpeed : 0f;
	}

	// Token: 0x06016C55 RID: 93269 RVA: 0x006A3474 File Offset: 0x006A1674
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetPendulumData(int entityId, float addVelocityX, float addVelocityY, float addVelocityZ, float forwardLossPercentage, float lossPercentage, float gravity, float friction, float deceleration, float accelerator, float maxSpeed, float maxFallingSpeed)
	{
		CharacterPendulumComponent component = EntitySystem.Instance.GetComponent<CharacterPendulumComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		component.SetPendulumData((double)addVelocityX, (double)addVelocityY, (double)addVelocityZ, (double)forwardLossPercentage, (double)lossPercentage, (double)gravity, (double)friction, (double)deceleration, (double)accelerator, (double)maxSpeed, (double)maxFallingSpeed);
	}

	// Token: 0x06016C56 RID: 93270 RVA: 0x006A34C4 File Offset: 0x006A16C4
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void Reset(int entityId)
	{
		CharacterPendulumComponent component = EntitySystem.Instance.GetComponent<CharacterPendulumComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		component.Reset();
	}

	// Token: 0x06016C57 RID: 93271 RVA: 0x006A34F8 File Offset: 0x006A16F8
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetGrabPoint(int entityId, FVectorDouble point)
	{
		CharacterPendulumComponent component = EntitySystem.Instance.GetComponent<CharacterPendulumComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		component.GrabPoint = point;
	}

	// Token: 0x06016C58 RID: 93272 RVA: 0x006A352C File Offset: 0x006A172C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static FVectorDouble GetGrabPoint(int entityId)
	{
		CharacterPendulumComponent component = EntitySystem.Instance.GetComponent<CharacterPendulumComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return new FVectorDouble();
		}
		return component.GrabPoint;
	}

	// Token: 0x06016C59 RID: 93273 RVA: 0x006A3564 File Offset: 0x006A1764
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetHooked(int entityId, bool isHooked)
	{
		CharacterPendulumComponent component = EntitySystem.Instance.GetComponent<CharacterPendulumComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		component.Hooked = isHooked;
	}

	// Token: 0x06016C5A RID: 93274 RVA: 0x006A3598 File Offset: 0x006A1798
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetHooked(int entityId)
	{
		CharacterPendulumComponent component = EntitySystem.Instance.GetComponent<CharacterPendulumComponent>(entityId);
		return component != null && component.Valid && component.Hooked;
	}

	// Token: 0x06016C5B RID: 93275 RVA: 0x006A35CC File Offset: 0x006A17CC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetSocketName(int entityId, string socketName)
	{
		CharacterPendulumComponent component = EntitySystem.Instance.GetComponent<CharacterPendulumComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		component.SocketName = socketName;
	}

	// Token: 0x06016C5C RID: 93276 RVA: 0x006A3600 File Offset: 0x006A1800
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetRopeForce(int entityId, float ropeForce)
	{
		CharacterPendulumComponent component = EntitySystem.Instance.GetComponent<CharacterPendulumComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		component.RopeForce = (double)ropeForce;
	}

	// Token: 0x06016C5D RID: 93277 RVA: 0x006A3634 File Offset: 0x006A1834
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetRopeForce(int entityId)
	{
		CharacterPendulumComponent component = EntitySystem.Instance.GetComponent<CharacterPendulumComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return 0f;
		}
		return (float)component.RopeForce;
	}

	// Token: 0x06016C5E RID: 93278 RVA: 0x006A366C File Offset: 0x006A186C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetDistanceRopeToActor(int entityId, float ropeForce)
	{
		CharacterPendulumComponent component = EntitySystem.Instance.GetComponent<CharacterPendulumComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		component.DistanceRopeToActor = (double)ropeForce;
	}

	// Token: 0x06016C5F RID: 93279 RVA: 0x006A36A0 File Offset: 0x006A18A0
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetDistanceRopeToActor(int entityId)
	{
		CharacterPendulumComponent component = EntitySystem.Instance.GetComponent<CharacterPendulumComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return 0f;
		}
		return (float)component.DistanceRopeToActor;
	}

	// Token: 0x06016C60 RID: 93280 RVA: 0x006A36D8 File Offset: 0x006A18D8
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetAirControl(int entityId, float airControl)
	{
		CharacterPendulumComponent component = EntitySystem.Instance.GetComponent<CharacterPendulumComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		component.AirControl = airControl;
	}

	// Token: 0x06016C61 RID: 93281 RVA: 0x006A370C File Offset: 0x006A190C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetAirControl(int entityId)
	{
		CharacterPendulumComponent component = EntitySystem.Instance.GetComponent<CharacterPendulumComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return 0f;
		}
		return component.AirControl;
	}

	// Token: 0x06016C62 RID: 93282 RVA: 0x006A3744 File Offset: 0x006A1944
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetUpLength(int entityId, float length)
	{
		CharacterPendulumComponent component = EntitySystem.Instance.GetComponent<CharacterPendulumComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		component.UpLength = (double)length;
	}

	// Token: 0x06016C63 RID: 93283 RVA: 0x006A3778 File Offset: 0x006A1978
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetCanMoveFromInput(int entityId, bool canMove)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		component.CanMoveFromInput = canMove;
	}

	// Token: 0x06016C64 RID: 93284 RVA: 0x006A37AC File Offset: 0x006A19AC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void UpdateAnimInfoMove(int entityId, BP_ABPLogicParams_C animLogicParams)
	{
		CharacterAnimationComponent component = EntitySystem.Instance.GetComponent<CharacterAnimationComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		AnimLogicParamsSetter animLogicParamsSetter = component.AnimLogicParamsSetter;
		CharacterActorComponent component2 = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityId);
		if (component2 != null && component2.Valid)
		{
			global::Vector inputDirectProxy = component2.InputDirectProxy;
			if (!animLogicParamsSetter.InputDirect.Equals(inputDirectProxy, 9.999999747378752E-05))
			{
				animLogicParamsSetter.InputDirect.DeepCopy(inputDirectProxy);
				animLogicParams.InputDirectRef = inputDirectProxy.ToUeVectorOld();
			}
			global::Rotator inputRotatorProxy = component2.InputRotatorProxy;
			if (!animLogicParamsSetter.InputRotator.Equals(inputRotatorProxy, 0.0001f))
			{
				animLogicParamsSetter.InputRotator.DeepCopy(inputRotatorProxy);
				animLogicParams.InputRotatorRef = inputRotatorProxy.ToUeRotator();
			}
		}
		BaseMoveComponent component3 = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		if (component3 != null && component3.Valid)
		{
			global::Vector acceleration = component3.Acceleration;
			if (!animLogicParamsSetter.Acceleration.Equals(acceleration, 9.999999747378752E-05))
			{
				animLogicParamsSetter.Acceleration.DeepCopy(acceleration);
				animLogicParams.AccelerationRef = acceleration.ToUeVectorOld();
			}
			bool isMoving = component3.IsMoving;
			if (animLogicParamsSetter.IsMoving != isMoving)
			{
				animLogicParamsSetter.IsMoving = isMoving;
				animLogicParams.IsMovingRef = isMoving;
			}
			bool hasMoveInput = component3.HasMoveInput;
			if (animLogicParamsSetter.HasMoveInput != hasMoveInput)
			{
				animLogicParamsSetter.HasMoveInput = hasMoveInput;
				animLogicParams.HasMoveInputRef = hasMoveInput;
			}
			float speed = component3.Speed;
			if (animLogicParamsSetter.Speed != speed)
			{
				animLogicParamsSetter.Speed = speed;
				animLogicParams.SpeedRef = speed;
			}
			bool isJump = component3.IsJump;
			if (animLogicParamsSetter.IsJump != isJump)
			{
				animLogicParamsSetter.IsJump = isJump;
				animLogicParams.IsJumpRef = isJump;
			}
			float groundedTimeUe = component3.GroundedTimeUe;
			if (animLogicParamsSetter.GroundedTime != groundedTimeUe)
			{
				animLogicParamsSetter.GroundedTime = groundedTimeUe;
				animLogicParams.GroundedTimeRef = groundedTimeUe;
			}
			bool isFallingIntoWater = component3.IsFallingIntoWater;
			if (animLogicParamsSetter.IsFallingIntoWater != isFallingIntoWater)
			{
				animLogicParamsSetter.IsFallingIntoWater = isFallingIntoWater;
				animLogicParams.IsFallingIntoWaterRef = isFallingIntoWater;
			}
			float jumpUpRate = component3.JumpUpRate;
			if (animLogicParamsSetter.JumpUpRate != jumpUpRate)
			{
				animLogicParamsSetter.JumpUpRate = jumpUpRate;
				animLogicParams.JumpUpRateRef = jumpUpRate;
			}
		}
		CharacterClimbComponent component4 = EntitySystem.Instance.GetComponent<CharacterClimbComponent>(entityId);
		if (component4 != null && component4.Valid)
		{
			CSharpScript.Game.NewWorld.Character.Common.Component.Move.SClimbInfo tsClimbInfo = component4.GetTsClimbInfo();
			if (!animLogicParamsSetter.ClimbInfo.Equals(tsClimbInfo))
			{
				animLogicParamsSetter.ClimbInfo.DeepCopy(tsClimbInfo);
				animLogicParams.ClimbInfoRef = component4.GetClimbInfo();
			}
			CSharpScript.Game.NewWorld.Character.Common.Component.Move.SClimbState tsClimbState = component4.GetTsClimbState();
			if (!animLogicParamsSetter.ClimbState.Equals(tsClimbState))
			{
				animLogicParamsSetter.ClimbState.DeepCopy(tsClimbState);
				animLogicParams.ClimbStateRef = component4.GetClimbState();
			}
			float climbRadius = component4.GetClimbRadius();
			if (animLogicParamsSetter.ClimbRadius != climbRadius)
			{
				animLogicParamsSetter.ClimbRadius = climbRadius;
				animLogicParams.ClimbRadiusRef = climbRadius;
			}
			float onWallAngle = component4.GetOnWallAngle();
			if (animLogicParamsSetter.ClimbOnWallAngle != onWallAngle)
			{
				animLogicParamsSetter.ClimbOnWallAngle = onWallAngle;
				animLogicParams.ClimbOnWallAngleRef = onWallAngle;
			}
		}
		CharacterSwimComponent component5 = EntitySystem.Instance.GetComponent<CharacterSwimComponent>(entityId);
		if (component5 != null && component5.Valid)
		{
			float sprintSwimOffset = component5.SprintSwimOffset;
			if (animLogicParamsSetter.SprintSwimOffset != sprintSwimOffset)
			{
				animLogicParamsSetter.SprintSwimOffset = sprintSwimOffset;
				animLogicParams.SprintSwimOffsetRef = sprintSwimOffset;
			}
			float sprintSwimOffsetLerpSpeed = component5.SprintSwimOffsetLerpSpeed;
			if (animLogicParamsSetter.SprintSwimOffsetLerpSpeed != sprintSwimOffsetLerpSpeed)
			{
				animLogicParamsSetter.SprintSwimOffsetLerpSpeed = sprintSwimOffsetLerpSpeed;
				animLogicParams.SprintSwimOffsetLerpSpeedRef = sprintSwimOffsetLerpSpeed;
			}
		}
		CharacterSlideComponent component6 = EntitySystem.Instance.GetComponent<CharacterSlideComponent>(entityId);
		if (component6 != null && component6.Valid)
		{
			global::Vector slideForward = component6.SlideForward;
			if (!animLogicParamsSetter.SlideForward.Equals(slideForward, 9.999999747378752E-05))
			{
				animLogicParamsSetter.SlideForward.DeepCopy(slideForward);
				animLogicParams.SlideForwardRef = slideForward.ToUeVectorOld();
			}
			bool slideSwitchThisFrame = component6.SlideSwitchThisFrame;
			if (animLogicParamsSetter.SlideSwitchThisFrame != slideSwitchThisFrame)
			{
				animLogicParamsSetter.SlideSwitchThisFrame = slideSwitchThisFrame;
				animLogicParams.SlideSwitchThisFrameRef = slideSwitchThisFrame;
			}
			bool standMode = component6.StandMode;
			if (animLogicParamsSetter.SlideStandMode != standMode)
			{
				animLogicParamsSetter.SlideStandMode = standMode;
				animLogicParams.SlideStandModeRef = standMode;
			}
		}
	}

	// Token: 0x06016C65 RID: 93285 RVA: 0x006A3B84 File Offset: 0x006A1D84
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void UpdateAnimInfoMoveMonster(int entityId, BP_ABPLogicParams_C animLogicParams)
	{
		CharacterAnimationComponent component = EntitySystem.Instance.GetComponent<CharacterAnimationComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		AnimLogicParamsSetter animLogicParamsSetter = component.AnimLogicParamsSetter;
		CharacterActorComponent component2 = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityId);
		if (component2 != null && component2.Valid)
		{
			global::Vector inputDirectProxy = component2.InputDirectProxy;
			if (!animLogicParamsSetter.InputDirect.Equals(inputDirectProxy, 9.999999747378752E-05))
			{
				animLogicParamsSetter.InputDirect.DeepCopy(inputDirectProxy);
				animLogicParams.InputDirectRef = inputDirectProxy.ToUeVectorOld();
			}
		}
		BaseMoveComponent component3 = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		if (component3 != null && component3.Valid)
		{
			bool isMoving = component3.IsMoving;
			if (animLogicParamsSetter.IsMoving != isMoving)
			{
				animLogicParamsSetter.IsMoving = isMoving;
				animLogicParams.IsMovingRef = isMoving;
			}
			bool hasMoveInput = component3.HasMoveInput;
			if (animLogicParamsSetter.HasMoveInput != hasMoveInput)
			{
				animLogicParamsSetter.HasMoveInput = hasMoveInput;
				animLogicParams.HasMoveInputRef = hasMoveInput;
			}
		}
	}

	// Token: 0x06016C66 RID: 93286 RVA: 0x006A3C6C File Offset: 0x006A1E6C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void UpdateAnimInfoMoveRoleNpc(int entityId, BP_ABPLogicParams_C animLogicParams)
	{
		CharacterAnimationComponent component = EntitySystem.Instance.GetComponent<CharacterAnimationComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		AnimLogicParamsSetter animLogicParamsSetter = component.AnimLogicParamsSetter;
		CharacterActorComponent component2 = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityId);
		if (component2 != null && component2.Valid)
		{
			global::Vector inputDirectProxy = component2.InputDirectProxy;
			if (!animLogicParamsSetter.InputDirect.Equals(inputDirectProxy, 9.999999747378752E-05))
			{
				animLogicParamsSetter.InputDirect.DeepCopy(inputDirectProxy);
				animLogicParams.InputDirectRef = inputDirectProxy.ToUeVectorOld();
			}
		}
		BaseMoveComponent component3 = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		if (component3 != null && component3.Valid)
		{
			global::Vector acceleration = component3.Acceleration;
			if (!animLogicParamsSetter.Acceleration.Equals(acceleration, 9.999999747378752E-05))
			{
				animLogicParamsSetter.Acceleration.DeepCopy(acceleration);
				animLogicParams.AccelerationRef = acceleration.ToUeVectorOld();
			}
			bool isMoving = component3.IsMoving;
			if (animLogicParamsSetter.IsMoving != isMoving)
			{
				animLogicParamsSetter.IsMoving = isMoving;
				animLogicParams.IsMovingRef = isMoving;
			}
			bool hasMoveInput = component3.HasMoveInput;
			if (animLogicParamsSetter.HasMoveInput != hasMoveInput)
			{
				animLogicParamsSetter.HasMoveInput = hasMoveInput;
				animLogicParams.HasMoveInputRef = hasMoveInput;
			}
			float speed = component3.Speed;
			if (animLogicParamsSetter.Speed != speed)
			{
				animLogicParamsSetter.Speed = speed;
				animLogicParams.SpeedRef = speed;
			}
			bool isRegionMoveMode = component3.IsRegionMoveMode;
			if (animLogicParamsSetter.IsRegionMoveMode != isRegionMoveMode)
			{
				animLogicParamsSetter.IsRegionMoveMode = isRegionMoveMode;
				animLogicParams.IsRegionMoveModeRef = isRegionMoveMode;
			}
		}
		CharacterDriveVehicleComponent component4 = EntitySystem.Instance.GetComponent<CharacterDriveVehicleComponent>(entityId);
		if (component4 != null && component4.Valid)
		{
			bool isDriver = component4.IsDriver;
			if (animLogicParamsSetter.IsDriver != isDriver)
			{
				animLogicParamsSetter.IsDriver = isDriver;
				animLogicParams.IsDriver = isDriver;
			}
			bool isOnVehicle = component4.IsOnVehicle;
			if (animLogicParamsSetter.IsOnVehicle != isOnVehicle)
			{
				animLogicParamsSetter.IsOnVehicle = isOnVehicle;
				animLogicParams.IsOnVehicle = isOnVehicle;
			}
			bool isOnVehicleWithOther = component4.IsOnVehicleWithOther;
			if (animLogicParamsSetter.IsOnVehicleWithOther != isOnVehicleWithOther)
			{
				animLogicParamsSetter.IsOnVehicleWithOther = isOnVehicleWithOther;
				animLogicParams.IsOnVehicleWithOther = isOnVehicleWithOther;
			}
			int vehicleTypeInt = (int)component4.VehicleTypeInt;
			if (animLogicParamsSetter.VehicleType != vehicleTypeInt)
			{
				animLogicParamsSetter.VehicleType = vehicleTypeInt;
				animLogicParams.VehicleType = vehicleTypeInt;
			}
		}
	}

	// Token: 0x06016C67 RID: 93287 RVA: 0x006A3E84 File Offset: 0x006A2084
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void TurnOnAutomaticFlightMode(int entityId, ICM_AutomaticFlight_DataBase_C dataAsset)
	{
		CharacterInputComponent component = EntitySystem.Instance.GetComponent<CharacterInputComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.TurnOnAutomaticFlightMode(dataAsset);
		}
	}

	// Token: 0x06016C68 RID: 93288 RVA: 0x006A3EB0 File Offset: 0x006A20B0
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void TurnOffAutomaticFlightMode(int entityId)
	{
		CharacterInputComponent component = EntitySystem.Instance.GetComponent<CharacterInputComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.TurnOffAutomaticFlightMode();
		}
	}

	// Token: 0x06016C69 RID: 93289 RVA: 0x006A3EDC File Offset: 0x006A20DC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void TurnOnCameraDrivenAutoFlightMode(int entityId, BP_CameraDrivenAutoFlightData_C dataAsset)
	{
		CharacterInputComponent component = EntitySystem.Instance.GetComponent<CharacterInputComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.TurnOnCameraDrivenAutoFlightMode(dataAsset);
		}
	}

	// Token: 0x06016C6A RID: 93290 RVA: 0x006A3F08 File Offset: 0x006A2108
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void TurnOffCameraDrivenAutoFlightMode(int entityId)
	{
		CharacterInputComponent component = EntitySystem.Instance.GetComponent<CharacterInputComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.TurnOffCameraDrivenAutoFlightMode();
		}
	}

	// Token: 0x1700230C RID: 8972
	// (get) Token: 0x06016C6B RID: 93291 RVA: 0x006A3F34 File Offset: 0x006A2134
	[Nullable(1)]
	private static UTraceLineElement WaterTrace
	{
		[NullableContext(1)]
		get
		{
			if (TsMoveBlueprintFunctionLibrary.WaterTraceInternal == null)
			{
				UTraceLineElement utraceLineElement = new UTraceLineElement();
				utraceLineElement.bIsSingle = true;
				utraceLineElement.bIgnoreSelf = true;
				utraceLineElement.SetTraceTypeQuery(KuroTraceTypeQuery.Water);
				TraceElementCommon.Instance.SetTraceColor(utraceLineElement, ColorUtils.LinearGreen);
				TraceElementCommon.Instance.SetTraceHitColor(utraceLineElement, ColorUtils.LinearRed);
				TsMoveBlueprintFunctionLibrary.WaterTraceInternal = utraceLineElement;
			}
			return TsMoveBlueprintFunctionLibrary.WaterTraceInternal;
		}
	}

	// Token: 0x1700230D RID: 8973
	// (get) Token: 0x06016C6C RID: 93292 RVA: 0x006A3F94 File Offset: 0x006A2194
	[Nullable(1)]
	private static UTraceLineElement GroundTrace
	{
		[NullableContext(1)]
		get
		{
			if (TsMoveBlueprintFunctionLibrary.GroundTraceInternal == null)
			{
				UTraceLineElement utraceLineElement = new UTraceLineElement();
				utraceLineElement.bIsSingle = true;
				utraceLineElement.bIgnoreSelf = true;
				utraceLineElement.SetTraceTypeQuery(KuroTraceTypeQuery.IkGround);
				TraceElementCommon.Instance.SetTraceColor(utraceLineElement, ColorUtils.LinearGreen);
				TraceElementCommon.Instance.SetTraceHitColor(utraceLineElement, ColorUtils.LinearRed);
				TsMoveBlueprintFunctionLibrary.GroundTraceInternal = utraceLineElement;
			}
			return TsMoveBlueprintFunctionLibrary.GroundTraceInternal;
		}
	}

	// Token: 0x06016C6D RID: 93293 RVA: 0x006A3FF4 File Offset: 0x006A21F4
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static FVectorDouble SimpleSwim(int entityId, float deltaSeconds, float detectedHeight, FVectorDouble currentSpeed)
	{
		CharacterActorComponent component = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return global::Vector.ZeroVectorDouble;
		}
		float num = MathUtils.Instance.Clamp(deltaSeconds, 0f, 0.15f);
		UTraceLineElement waterTrace = TsMoveBlueprintFunctionLibrary.WaterTrace;
		waterTrace.WorldContextObject = component.Actor;
		component.ActorUpProxy.Multiply((double)detectedHeight, TsMoveBlueprintFunctionLibrary.tmpVector);
		TsMoveBlueprintFunctionLibrary.tmpVector.AdditionEqual(component.ActorLocationProxy);
		TraceElementCommon.Instance.SetStartLocation(waterTrace, TsMoveBlueprintFunctionLibrary.tmpVector);
		component.ActorUpProxy.Multiply((double)(-(double)component.ScaledHalfHeight), TsMoveBlueprintFunctionLibrary.tmpVector);
		TsMoveBlueprintFunctionLibrary.tmpVector.AdditionEqual(component.ActorLocationProxy);
		TraceElementCommon.Instance.SetEndLocation(waterTrace, TsMoveBlueprintFunctionLibrary.tmpVector);
		float num2 = 0f;
		if (TraceElementCommon.Instance.LineTrace(waterTrace, "SimpleSwim"))
		{
			UTraceLineElement groundTrace = TsMoveBlueprintFunctionLibrary.GroundTrace;
			groundTrace.WorldContextObject = component.Actor;
			TraceElementCommon.Instance.GetHitLocation(waterTrace.HitResult, 0, TsMoveBlueprintFunctionLibrary.tmpVector);
			TraceElementCommon.Instance.SetStartLocation(groundTrace, TsMoveBlueprintFunctionLibrary.tmpVector);
			TraceElementCommon.Instance.SetEndLocation(groundTrace, component.ActorLocationProxy);
			if (!TraceElementCommon.Instance.LineTrace(groundTrace, "SimpleSwim_Ground"))
			{
				TsMoveBlueprintFunctionLibrary.tmpVector.SubtractionEqual(component.ActorLocationProxy);
				num2 = (float)MathUtils.Instance.Clamp(TsMoveBlueprintFunctionLibrary.tmpVector.DotProduct(component.ActorUpProxy) / (double)component.ScaledHalfHeight * 0.5 + 0.5, 0.0, 1.0);
			}
		}
		else
		{
			UTraceLineElement groundTrace2 = TsMoveBlueprintFunctionLibrary.GroundTrace;
			groundTrace2.WorldContextObject = component.Actor;
			component.ActorUpProxy.Multiply((double)(-(double)component.ScaledHalfHeight - 2f), TsMoveBlueprintFunctionLibrary.tmpVector);
			TsMoveBlueprintFunctionLibrary.tmpVector.AdditionEqual(component.ActorLocationProxy);
			TraceElementCommon.Instance.SetStartLocation(groundTrace2, component.ActorLocationProxy);
			TraceElementCommon.Instance.SetEndLocation(groundTrace2, TsMoveBlueprintFunctionLibrary.tmpVector);
			if (TraceElementCommon.Instance.LineTrace(groundTrace2, "SimpleSwim_Ground"))
			{
				return global::Vector.ZeroVectorDouble;
			}
		}
		BaseMoveComponent component2 = component.Entity.GetComponent<BaseMoveComponent>();
		TsMoveBlueprintFunctionLibrary.tmpVector.FromUeVector(currentSpeed);
		double num4;
		double num3 = num4 = GravityUtils.Instance.GetZnInGravityForActor(component, TsMoveBlueprintFunctionLibrary.tmpVector);
		if (component2 != null && component2.Valid)
		{
			num4 += (double)(component2.CharacterMovement.GetGravityZ() * num) * (1.0 - (double)num2 * 1.4);
		}
		else
		{
			num4 += (double)(1960f * num) * (1.0 - (double)num2 * 1.4);
		}
		num4 *= (double)((float)Math.Pow(0.05999999865889549, (double)num));
		double num5 = (num3 + num4) / 2.0 * (double)num;
		num5 = MathUtils.Instance.Clamp(num5, (double)((num2 - 1f) * 2f * component.ScaledHalfHeight), (double)(num2 * 2f * component.ScaledHalfHeight));
		TsMoveBlueprintFunctionLibrary.tmpVector.Reset();
		GravityUtils.Instance.AddZnInGravityForActor(component, TsMoveBlueprintFunctionLibrary.tmpVector, num5);
		if (component2 != null && component2.Valid)
		{
			component2.MoveCharacter(TsMoveBlueprintFunctionLibrary.tmpVector, num, "SimpleSwim");
		}
		else
		{
			component.AddActorWorldOffset(TsMoveBlueprintFunctionLibrary.tmpVector.ToUeVector(false), "SimpleSwim", true);
		}
		TsMoveBlueprintFunctionLibrary.tmpVector2.Reset();
		GravityUtils.Instance.AddZnInGravityForActor(component, TsMoveBlueprintFunctionLibrary.tmpVector2, num4);
		return TsMoveBlueprintFunctionLibrary.tmpVector2.ToUeVector(false);
	}

	// Token: 0x06016C6E RID: 93294 RVA: 0x006A4378 File Offset: 0x006A2578
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void EnterRoll(int entityId, float targetSpeed, float friction, float accelOnGround, float gravity, float stepUpHeight, float maxSpeed)
	{
		CharacterRollComponent component = EntitySystem.Instance.GetComponent<CharacterRollComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.EnterRoll(targetSpeed, friction, accelOnGround, gravity, stepUpHeight, maxSpeed);
	}

	// Token: 0x06016C6F RID: 93295 RVA: 0x006A4398 File Offset: 0x006A2598
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void LeaveRoll(int entityId)
	{
		CharacterRollComponent component = EntitySystem.Instance.GetComponent<CharacterRollComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.LeaveRoll();
	}

	// Token: 0x06016C70 RID: 93296 RVA: 0x006A43B0 File Offset: 0x006A25B0
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool EnterKite(int entityId)
	{
		CharacterKiteComponent component = EntitySystem.Instance.GetComponent<CharacterKiteComponent>(entityId);
		BaseSceneInteractComponent component2 = EntitySystem.Instance.GetComponent<BaseSceneInteractComponent>(entityId);
		return component != null && component.Valid && component2 != null && component2.Valid && component.EnterKite(component2.GetCurrentTarget());
	}

	// Token: 0x06016C71 RID: 93297 RVA: 0x006A43FC File Offset: 0x006A25FC
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static FVeloctiyBlend LerpVelocityBlend(FVeloctiyBlend outVeloctiyBlend, FVeloctiyBlend to, float alpha)
	{
		outVeloctiyBlend.Forward = MathUtils.Instance.Lerp(outVeloctiyBlend.Forward, to.Forward, alpha);
		outVeloctiyBlend.Backward = MathUtils.Instance.Lerp(outVeloctiyBlend.Backward, to.Backward, alpha);
		outVeloctiyBlend.Left = MathUtils.Instance.Lerp(outVeloctiyBlend.Left, to.Left, alpha);
		outVeloctiyBlend.Right = MathUtils.Instance.Lerp(outVeloctiyBlend.Right, to.Right, alpha);
		float num = 1f / (outVeloctiyBlend.Forward + outVeloctiyBlend.Backward + outVeloctiyBlend.Left + outVeloctiyBlend.Right);
		if (num < 1f)
		{
			outVeloctiyBlend.Forward *= num;
			outVeloctiyBlend.Backward *= num;
			outVeloctiyBlend.Left *= num;
			outVeloctiyBlend.Right *= num;
		}
		return outVeloctiyBlend;
	}

	// Token: 0x06016C72 RID: 93298 RVA: 0x006A44E8 File Offset: 0x006A26E8
	[NullableContext(1)]
	private static void MoveCharacterDetectFloor(CharacterActorComponent actor, global::Vector loc)
	{
		UTraceSphereElement actorTrace = TraceElementModel.Instance.GetActorTrace();
		actorTrace.WorldContextObject = actor.Owner;
		actorTrace.Radius = actor.ScaledRadius;
		foreach (AActor value in WorldModel.Instance.ActorsToIgnoreSet)
		{
			actorTrace.ActorsToIgnore.Add(value);
		}
		TsMoveBlueprintFunctionLibrary.tmpVector.DeepCopy(loc);
		TsMoveBlueprintFunctionLibrary.tmpVector.AdditionEqual(actor.ActorLocationProxy);
		TraceElementCommon.Instance.SetStartLocation(actorTrace, TsMoveBlueprintFunctionLibrary.tmpVector);
		GravityUtils.Instance.AddZnInGravityForActor(actor, TsMoveBlueprintFunctionLibrary.tmpVector, (double)(-(double)actor.ScaledHalfHeight));
		TraceElementCommon.Instance.SetEndLocation(actorTrace, TsMoveBlueprintFunctionLibrary.tmpVector);
		string text = "MoveCharacterDetectFloor";
		if (TraceElementCommon.Instance.ShapeTrace(actor.Actor.CapsuleComponent, actorTrace, text, text))
		{
			TraceElementCommon.Instance.GetHitLocation(actorTrace.HitResult, 0, loc);
			GravityUtils.Instance.AddZnInGravityForActor(actor, loc, (double)actor.ScaledHalfHeight);
			loc.SubtractionEqual(actor.ActorLocationProxy);
		}
	}

	// Token: 0x06016C73 RID: 93299 RVA: 0x006A4610 File Offset: 0x006A2810
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool MoveCharacter(int entityId, FVectorDouble targetLocation, float speed, int arriveDist)
	{
		CharacterMoveComponent component = EntitySystem.Instance.GetComponent<CharacterMoveComponent>(entityId);
		if (((component != null) ? component.ActorComp : null) == null)
		{
			return true;
		}
		MathUtils.Instance.CommonTempVector.DeepCopy(targetLocation);
		MathUtils.Instance.CommonTempVector.SubtractionEqual(component.ActorComp.ActorLocationProxy);
		float num = speed * Time.Instance.DeltaTimeSeconds;
		double num2 = Math.Max(0.0, MathUtils.Instance.CommonTempVector.Size() - (double)arriveDist);
		MathUtils.Instance.CommonTempVector.Normalize(9.99999993922529E-09);
		if (num2 > (double)num)
		{
			MathUtils.Instance.CommonTempVector.MultiplyEqual((double)num);
			TsMoveBlueprintFunctionLibrary.MoveCharacterDetectFloor(component.ActorComp, MathUtils.Instance.CommonTempVector);
			if (component != null)
			{
				component.MoveCharacter(MathUtils.Instance.CommonTempVector, Time.Instance.DeltaTimeSeconds, "TsMoveBlueprintFunctionLibrary.MoveCharacter");
			}
			return false;
		}
		if (num2 > 0.0)
		{
			MathUtils.Instance.CommonTempVector.MultiplyEqual(num2);
			TsMoveBlueprintFunctionLibrary.MoveCharacterDetectFloor(component.ActorComp, MathUtils.Instance.CommonTempVector);
			if (component != null)
			{
				component.MoveCharacter(MathUtils.Instance.CommonTempVector, Time.Instance.DeltaTimeSeconds, "TsMoveBlueprintFunctionLibrary.MoveCharacter");
			}
		}
		return true;
	}

	// Token: 0x06016C74 RID: 93300 RVA: 0x006A4751 File Offset: 0x006A2951
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void StartAssistedWalk(int entityId)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.MoveController.StartAssistedWalk();
	}

	// Token: 0x06016C75 RID: 93301 RVA: 0x006A476D File Offset: 0x006A296D
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void EnterAssistedWalkIdle(int entityId)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.MoveController.EnterAssistedWalkIdle();
	}

	// Token: 0x06016C76 RID: 93302 RVA: 0x006A4789 File Offset: 0x006A2989
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void EnterAssistedWalking(int entityId)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.MoveController.EnterAssistedWalking();
	}

	// Token: 0x06016C77 RID: 93303 RVA: 0x006A47A5 File Offset: 0x006A29A5
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void LeftAssistedWalking(int entityId)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.MoveController.LeftAssistedWalking();
	}

	// Token: 0x06016C78 RID: 93304 RVA: 0x006A47C1 File Offset: 0x006A29C1
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void LeftStartSwing(int entityId)
	{
		CharacterSwingComponent component = EntitySystem.Instance.GetComponent<CharacterSwingComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.LeftStartSwing();
	}

	// Token: 0x06016C79 RID: 93305 RVA: 0x006A47D8 File Offset: 0x006A29D8
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void LeftLoopSwing(int entityId)
	{
		CharacterSwingComponent component = EntitySystem.Instance.GetComponent<CharacterSwingComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.LeftLoopSwing();
	}

	// Token: 0x06016C7A RID: 93306 RVA: 0x006A47EF File Offset: 0x006A29EF
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void LeftEndSwing(int entityId)
	{
		CharacterSwingComponent component = EntitySystem.Instance.GetComponent<CharacterSwingComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.LeftEndSwing();
	}

	// Token: 0x06016C7B RID: 93307 RVA: 0x006A4806 File Offset: 0x006A2A06
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void ResetClimbConfig(int entityId, string key)
	{
		CharacterClimbComponent component = EntitySystem.Instance.GetComponent<CharacterClimbComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.ResetClimbObjectConfig(key);
	}

	// Token: 0x06016C7C RID: 93308 RVA: 0x006A481E File Offset: 0x006A2A1E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06016C7D RID: 93309 RVA: 0x006A4820 File Offset: 0x006A2A20
	public static void ResetStaticDefaultValue()
	{
		TsMoveBlueprintFunctionLibrary.WaterTraceInternal = null;
		TsMoveBlueprintFunctionLibrary.GroundTraceInternal = null;
	}

	// Token: 0x06016C7E RID: 93310 RVA: 0x006A4830 File Offset: 0x006A2A30
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void EnableGoThrough(int entityId, int goThroughPriority)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		if (component == null || component.CharacterMovement == null)
		{
			return;
		}
		component.CharacterMovement.GoThroughLower = true;
		if (goThroughPriority >= 0)
		{
			component.CharacterMovement.GoThroughPriority = goThroughPriority;
		}
	}

	// Token: 0x06016C7F RID: 93311 RVA: 0x006A4874 File Offset: 0x006A2A74
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void DisableGoThrough(int entityId)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		if (component == null || component.CharacterMovement == null)
		{
			return;
		}
		component.CharacterMovement.GoThroughLower = false;
		component.ResetHitPriorityAndGoThrough();
	}

	// Token: 0x06016C80 RID: 93312 RVA: 0x006A48AC File Offset: 0x006A2AAC
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void AnimTurnStart(int entityId)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		component.StartCacheRootMotionRotationSpeedBlend();
	}

	// Token: 0x06016C81 RID: 93313 RVA: 0x006A48D8 File Offset: 0x006A2AD8
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void AnimTurnFinish(int entityId, bool isGoingMove)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		bool flag = component.RootMotionAfterTickId != -1 || isGoingMove;
		component.FinishCacheRootMotionRotationSpeedBlend(isGoingMove);
	}

	// Token: 0x06016C82 RID: 93314 RVA: 0x006A4914 File Offset: 0x006A2B14
	[NullableContext(2)]
	public static UKuroCustomMovementFlowerFlying GetCustomMovementFlowerFlying(int entityId)
	{
		CharacterFlowerFlyingComponent component = EntitySystem.Instance.GetComponent<CharacterFlowerFlyingComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return null;
		}
		return component.FlowerFlyingExtension;
	}

	// Token: 0x06016C83 RID: 93315 RVA: 0x006A4946 File Offset: 0x006A2B46
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsMoveBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsMoveBlueprintFunctionLibrary.TsMoveBlueprintFunctionLibrary_C");
		}
		return TsMoveBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x06016C84 RID: 93316 RVA: 0x006A496C File Offset: 0x006A2B6C
	public TsMoveBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(TsMoveBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06016C85 RID: 93317 RVA: 0x006A4994 File Offset: 0x006A2B94
	[NullableContext(1)]
	public TsMoveBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsMoveBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06016C86 RID: 93318 RVA: 0x006A49C7 File Offset: 0x006A2BC7
	protected TsMoveBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06016C87 RID: 93319 RVA: 0x006A49D0 File Offset: 0x006A2BD0
	protected unsafe static void __CPPCALL_SetActorRotationWithPriority_Implementation(TsMoveBlueprintFunctionLibrary.__SetActorRotationWithPriority_FunctionParams* __Params)
	{
		string context = FString.ToString((void*)(&__Params->context));
		__Params->__Result = TsMoveBlueprintFunctionLibrary.SetActorRotationWithPriority(__Params->entityId, __Params->value, __Params->sweep, context);
	}

	// Token: 0x06016C88 RID: 93320 RVA: 0x006A4A08 File Offset: 0x006A2C08
	protected unsafe static void __CPPCALL_SetActorLocationWithContext_Implementation(TsMoveBlueprintFunctionLibrary.__SetActorLocationWithContext_FunctionParams* __Params)
	{
		string context = FString.ToString((void*)(&__Params->context));
		__Params->__Result = TsMoveBlueprintFunctionLibrary.SetActorLocationWithContext(__Params->entityId, __Params->location, __Params->sweep, context);
	}

	// Token: 0x06016C89 RID: 93321 RVA: 0x006A4A40 File Offset: 0x006A2C40
	protected unsafe static void __CPPCALL_SetActorLocationAndRotationWithContext_Implementation(TsMoveBlueprintFunctionLibrary.__SetActorLocationAndRotationWithContext_FunctionParams* __Params)
	{
		string context = FString.ToString((void*)(&__Params->context));
		TsMoveBlueprintFunctionLibrary.SetActorLocationAndRotationWithContext(__Params->entityId, __Params->location, __Params->rotation, __Params->sweep, context);
	}

	// Token: 0x06016C8A RID: 93322 RVA: 0x006A4A78 File Offset: 0x006A2C78
	protected unsafe static void __CPPCALL_SetActorRotationWithContext_Implementation(TsMoveBlueprintFunctionLibrary.__SetActorRotationWithContext_FunctionParams* __Params)
	{
		string context = FString.ToString((void*)(&__Params->context));
		__Params->__Result = TsMoveBlueprintFunctionLibrary.SetActorRotationWithContext(__Params->entityId, __Params->rotation, __Params->sweep, context);
	}

	// Token: 0x06016C8B RID: 93323 RVA: 0x006A4AB0 File Offset: 0x006A2CB0
	protected unsafe static void __CPPCALL_AddActorWorldOffsetWithContext_Implementation(TsMoveBlueprintFunctionLibrary.__AddActorWorldOffsetWithContext_FunctionParams* __Params)
	{
		string context = FString.ToString((void*)(&__Params->context));
		TsMoveBlueprintFunctionLibrary.AddActorWorldOffsetWithContext(__Params->entityId, __Params->offset, __Params->sweep, context);
	}

	// Token: 0x06016C8C RID: 93324 RVA: 0x006A4AE4 File Offset: 0x006A2CE4
	protected unsafe static void __CPPCALL_AddActorWorldOffsetWithContextAndReset_Implementation(TsMoveBlueprintFunctionLibrary.__AddActorWorldOffsetWithContextAndReset_FunctionParams* __Params)
	{
		string context = FString.ToString((void*)(&__Params->context));
		TsMoveBlueprintFunctionLibrary.AddActorWorldOffsetWithContextAndReset(__Params->entityId, __Params->offset, __Params->sweep, context);
	}

	// Token: 0x06016C8D RID: 93325 RVA: 0x006A4B18 File Offset: 0x006A2D18
	protected unsafe static void __CPPCALL_AddActorLocalOffsetWithContext_Implementation(TsMoveBlueprintFunctionLibrary.__AddActorLocalOffsetWithContext_FunctionParams* __Params)
	{
		string context = FString.ToString((void*)(&__Params->context));
		TsMoveBlueprintFunctionLibrary.AddActorLocalOffsetWithContext(__Params->entityId, __Params->offset, __Params->sweep, context);
	}

	// Token: 0x06016C8E RID: 93326 RVA: 0x006A4B4C File Offset: 0x006A2D4C
	protected unsafe static void __CPPCALL_AddActorWorldRotationWithContext_Implementation(TsMoveBlueprintFunctionLibrary.__AddActorWorldRotationWithContext_FunctionParams* __Params)
	{
		string context = FString.ToString((void*)(&__Params->context));
		TsMoveBlueprintFunctionLibrary.AddActorWorldRotationWithContext(__Params->entityId, __Params->rotation, __Params->sweep, context);
	}

	// Token: 0x06016C8F RID: 93327 RVA: 0x006A4B80 File Offset: 0x006A2D80
	protected unsafe static void __CPPCALL_AddActorLocalRotationWithContext_Implementation(TsMoveBlueprintFunctionLibrary.__AddActorLocalRotationWithContext_FunctionParams* __Params)
	{
		string context = FString.ToString((void*)(&__Params->context));
		TsMoveBlueprintFunctionLibrary.AddActorLocalRotationWithContext(__Params->entityId, __Params->rotation, __Params->sweep, context);
	}

	// Token: 0x06016C90 RID: 93328 RVA: 0x006A4BB4 File Offset: 0x006A2DB4
	protected unsafe static void __CPPCALL_ActorTeleportToWithContext_Implementation(TsMoveBlueprintFunctionLibrary.__ActorTeleportToWithContext_FunctionParams* __Params)
	{
		string context = FString.ToString((void*)(&__Params->context));
		TsMoveBlueprintFunctionLibrary.ActorTeleportToWithContext(__Params->entityId, __Params->location, __Params->rotation, context);
	}

	// Token: 0x06016C91 RID: 93329 RVA: 0x006A4BE8 File Offset: 0x006A2DE8
	protected unsafe static void __CPPCALL_SetActorLookAtWithContext_Implementation(TsMoveBlueprintFunctionLibrary.__SetActorLookAtWithContext_FunctionParams* __Params)
	{
		string context = FString.ToString((void*)(&__Params->context));
		__Params->__Result = TsMoveBlueprintFunctionLibrary.SetActorLookAtWithContext(__Params->entityId, __Params->targetPoint, context);
	}

	// Token: 0x06016C92 RID: 93330 RVA: 0x006A4C1C File Offset: 0x006A2E1C
	protected unsafe static void __CPPCALL_ActorKuroMoveAlongFloorWithContext_Implementation(TsMoveBlueprintFunctionLibrary.__ActorKuroMoveAlongFloorWithContext_FunctionParams* __Params)
	{
		string context = FString.ToString((void*)(&__Params->context));
		TsMoveBlueprintFunctionLibrary.ActorKuroMoveAlongFloorWithContext(__Params->entityId, __Params->velocity, __Params->deltaSeconds, context);
	}

	// Token: 0x06016C93 RID: 93331 RVA: 0x006A4C4E File Offset: 0x006A2E4E
	protected unsafe static void __CPPCALL_GetInputDirect_Implementation(TsMoveBlueprintFunctionLibrary.__GetInputDirect_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetInputDirect(__Params->entityId);
	}

	// Token: 0x06016C94 RID: 93332 RVA: 0x006A4C61 File Offset: 0x006A2E61
	protected unsafe static void __CPPCALL_SetInputDirect_Implementation(TsMoveBlueprintFunctionLibrary.__SetInputDirect_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.SetInputDirect(__Params->entityId, __Params->direct);
	}

	// Token: 0x06016C95 RID: 93333 RVA: 0x006A4C74 File Offset: 0x006A2E74
	protected unsafe static void __CPPCALL_GetInputRotator_Implementation(TsMoveBlueprintFunctionLibrary.__GetInputRotator_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetInputRotator(__Params->entityId);
	}

	// Token: 0x06016C96 RID: 93334 RVA: 0x006A4C87 File Offset: 0x006A2E87
	protected unsafe static void __CPPCALL_SetInputRotator_Implementation(TsMoveBlueprintFunctionLibrary.__SetInputRotator_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.SetInputRotator(__Params->entityId, __Params->rotator);
	}

	// Token: 0x06016C97 RID: 93335 RVA: 0x006A4C9C File Offset: 0x006A2E9C
	protected unsafe static void __CPPCALL_SetCharacterHidden_Implementation(TsMoveBlueprintFunctionLibrary.__SetCharacterHidden_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->callObject);
		string reason = FString.ToString((void*)(&__Params->reason));
		TsMoveBlueprintFunctionLibrary.SetCharacterHidden(__Params->entityId, __Params->isHidden, orCreateUObjectByNativePointer, reason);
	}

	// Token: 0x06016C98 RID: 93336 RVA: 0x006A4CD5 File Offset: 0x006A2ED5
	protected unsafe static void __CPPCALL_SetHiddenMovementMode_Implementation(TsMoveBlueprintFunctionLibrary.__SetHiddenMovementMode_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.SetHiddenMovementMode(__Params->entityId, __Params->isHidden);
	}

	// Token: 0x06016C99 RID: 93337 RVA: 0x006A4CE8 File Offset: 0x006A2EE8
	protected unsafe static void __CPPCALL_CanResponseInput_Implementation(TsMoveBlueprintFunctionLibrary.__CanResponseInput_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.CanResponseInput(__Params->entityId);
	}

	// Token: 0x06016C9A RID: 93338 RVA: 0x006A4CFB File Offset: 0x006A2EFB
	protected unsafe static void __CPPCALL_CanJumpPress_Implementation(TsMoveBlueprintFunctionLibrary.__CanJumpPress_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.CanJumpPress(__Params->entityId);
	}

	// Token: 0x06016C9B RID: 93339 RVA: 0x006A4D0E File Offset: 0x006A2F0E
	protected unsafe static void __CPPCALL_CanWalkPress_Implementation(TsMoveBlueprintFunctionLibrary.__CanWalkPress_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.CanWalkPress(__Params->entityId);
	}

	// Token: 0x06016C9C RID: 93340 RVA: 0x006A4D21 File Offset: 0x006A2F21
	protected unsafe static void __CPPCALL_GetHeightAboveGround_Implementation(TsMoveBlueprintFunctionLibrary.__GetHeightAboveGround_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetHeightAboveGround(__Params->entityId, __Params->detectedHeight);
	}

	// Token: 0x06016C9D RID: 93341 RVA: 0x006A4D3A File Offset: 0x006A2F3A
	protected unsafe static void __CPPCALL_GetAcceleration_Implementation(TsMoveBlueprintFunctionLibrary.__GetAcceleration_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetAcceleration(__Params->entityId);
	}

	// Token: 0x06016C9E RID: 93342 RVA: 0x006A4D4D File Offset: 0x006A2F4D
	protected unsafe static void __CPPCALL_GetAimYawRate_Implementation(TsMoveBlueprintFunctionLibrary.__GetAimYawRate_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetAimYawRate(__Params->entityId);
	}

	// Token: 0x06016C9F RID: 93343 RVA: 0x006A4D60 File Offset: 0x006A2F60
	protected unsafe static void __CPPCALL_GetMovementData_Implementation(TsMoveBlueprintFunctionLibrary.__GetMovementData_FunctionParams* __Params)
	{
		UScriptStructStackOnlyPtr nativeUStructPtr = SMovementSetting_State.StaticStruct();
		IntPtr dest = &__Params->__Result;
		SMovementSetting_State movementData = TsMoveBlueprintFunctionLibrary.GetMovementData(__Params->entityId);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (movementData != null) ? movementData.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x06016CA0 RID: 93344 RVA: 0x006A4D90 File Offset: 0x006A2F90
	protected unsafe static void __CPPCALL_SmoothCharacterRotation_Implementation(TsMoveBlueprintFunctionLibrary.__SmoothCharacterRotation_FunctionParams* __Params)
	{
		string context = FString.ToString((void*)(&__Params->context));
		TsMoveBlueprintFunctionLibrary.SmoothCharacterRotation(__Params->entityId, __Params->target, __Params->speed, context);
	}

	// Token: 0x06016CA1 RID: 93345 RVA: 0x006A4DC2 File Offset: 0x006A2FC2
	protected unsafe static void __CPPCALL_HasMoveInput_Implementation(TsMoveBlueprintFunctionLibrary.__HasMoveInput_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.HasMoveInput(__Params->entityId);
	}

	// Token: 0x06016CA2 RID: 93346 RVA: 0x006A4DD5 File Offset: 0x006A2FD5
	protected unsafe static void __CPPCALL_HasMoveInputOrTickIntervalAndModelBuffer_Implementation(TsMoveBlueprintFunctionLibrary.__HasMoveInputOrTickIntervalAndModelBuffer_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.HasMoveInputOrTickIntervalAndModelBuffer(__Params->entityId);
	}

	// Token: 0x06016CA3 RID: 93347 RVA: 0x006A4DE8 File Offset: 0x006A2FE8
	protected unsafe static void __CPPCALL_HasRotatorInput_Implementation(TsMoveBlueprintFunctionLibrary.__HasRotatorInput_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.HasRotatorInput(__Params->entityId);
	}

	// Token: 0x06016CA4 RID: 93348 RVA: 0x006A4DFB File Offset: 0x006A2FFB
	protected unsafe static void __CPPCALL_IsMoving_Implementation(TsMoveBlueprintFunctionLibrary.__IsMoving_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.IsMoving(__Params->entityId);
	}

	// Token: 0x06016CA5 RID: 93349 RVA: 0x006A4E0E File Offset: 0x006A300E
	protected unsafe static void __CPPCALL_IsJump_Implementation(TsMoveBlueprintFunctionLibrary.__IsJump_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.IsJump(__Params->entityId);
	}

	// Token: 0x06016CA6 RID: 93350 RVA: 0x006A4E21 File Offset: 0x006A3021
	protected unsafe static void __CPPCALL_GetSpeed_Implementation(TsMoveBlueprintFunctionLibrary.__GetSpeed_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetSpeed(__Params->entityId);
	}

	// Token: 0x06016CA7 RID: 93351 RVA: 0x006A4E34 File Offset: 0x006A3034
	protected unsafe static void __CPPCALL_GetGroundedTime_Implementation(TsMoveBlueprintFunctionLibrary.__GetGroundedTime_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetGroundedTime(__Params->entityId);
	}

	// Token: 0x06016CA8 RID: 93352 RVA: 0x006A4E47 File Offset: 0x006A3047
	protected unsafe static void __CPPCALL_IsFallingIntoWater_Implementation(TsMoveBlueprintFunctionLibrary.__IsFallingIntoWater_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.IsFallingIntoWater(__Params->entityId);
	}

	// Token: 0x06016CA9 RID: 93353 RVA: 0x006A4E5A File Offset: 0x006A305A
	protected unsafe static void __CPPCALL_SetForceSpeed_Implementation(TsMoveBlueprintFunctionLibrary.__SetForceSpeed_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.SetForceSpeed(__Params->entityId, __Params->speed);
	}

	// Token: 0x06016CAA RID: 93354 RVA: 0x006A4E70 File Offset: 0x006A3070
	protected unsafe static void __CPPCALL_SetAddMove_Implementation(TsMoveBlueprintFunctionLibrary.__SetAddMove_FunctionParams* __Params)
	{
		UMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMeshComponent>(__Params->mesh);
		UCurveFloat orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UCurveFloat>(__Params->curve);
		TsMoveBlueprintFunctionLibrary.SetAddMove(__Params->entityId, orCreateUObjectByNativePointer, __Params->speed, __Params->timeLength, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06016CAB RID: 93355 RVA: 0x006A4EB0 File Offset: 0x006A30B0
	protected unsafe static void __CPPCALL_StopAddMove_Implementation(TsMoveBlueprintFunctionLibrary.__StopAddMove_FunctionParams* __Params)
	{
		UMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMeshComponent>(__Params->mesh);
		TsMoveBlueprintFunctionLibrary.StopAddMove(__Params->entityId, orCreateUObjectByNativePointer);
	}

	// Token: 0x06016CAC RID: 93356 RVA: 0x006A4ED5 File Offset: 0x006A30D5
	protected unsafe static void __CPPCALL_FixActorLocation_Implementation(TsMoveBlueprintFunctionLibrary.__FixActorLocation_FunctionParams* __Params)
	{
		UScriptStructStackOnlyPtr nativeUStructPtr = FHitResult.StaticStruct();
		IntPtr dest = &__Params->__Result;
		FHitResult fhitResult = TsMoveBlueprintFunctionLibrary.FixActorLocation(__Params->entityId, __Params->target, __Params->offset);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (fhitResult != null) ? fhitResult.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x06016CAD RID: 93357 RVA: 0x006A4F0E File Offset: 0x006A310E
	protected unsafe static void __CPPCALL_StopAllAddMove_Implementation(TsMoveBlueprintFunctionLibrary.__StopAllAddMove_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.StopAllAddMove(__Params->entityId);
	}

	// Token: 0x06016CAE RID: 93358 RVA: 0x006A4F1C File Offset: 0x006A311C
	protected unsafe static void __CPPCALL_SetAddMoveWorld_Implementation(TsMoveBlueprintFunctionLibrary.__SetAddMoveWorld_FunctionParams* __Params)
	{
		UMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMeshComponent>(__Params->mesh);
		UCurveFloat orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UCurveFloat>(__Params->curve);
		TsMoveBlueprintFunctionLibrary.SetAddMoveWorld(__Params->entityId, orCreateUObjectByNativePointer, __Params->speed, __Params->timeLength, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06016CAF RID: 93359 RVA: 0x006A4F5C File Offset: 0x006A315C
	protected unsafe static void __CPPCALL_SetAddMoveWorldSpeed_Implementation(TsMoveBlueprintFunctionLibrary.__SetAddMoveWorldSpeed_FunctionParams* __Params)
	{
		UMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMeshComponent>(__Params->mesh);
		TsMoveBlueprintFunctionLibrary.SetAddMoveWorldSpeed(__Params->entityId, orCreateUObjectByNativePointer, __Params->speed);
	}

	// Token: 0x06016CB0 RID: 93360 RVA: 0x006A4F87 File Offset: 0x006A3187
	protected unsafe static void __CPPCALL_SetAddMoveOffset_Implementation(TsMoveBlueprintFunctionLibrary.__SetAddMoveOffset_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.SetAddMoveOffset(__Params->entityId, __Params->offset);
	}

	// Token: 0x06016CB1 RID: 93361 RVA: 0x006A4F9A File Offset: 0x006A319A
	protected unsafe static void __CPPCALL_SetAddMoveRotation_Implementation(TsMoveBlueprintFunctionLibrary.__SetAddMoveRotation_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.SetAddMoveRotation(__Params->entityId, __Params->rotation);
	}

	// Token: 0x06016CB2 RID: 93362 RVA: 0x006A4FAD File Offset: 0x006A31AD
	protected unsafe static void __CPPCALL_SetEnterWaterState_Implementation(TsMoveBlueprintFunctionLibrary.__SetEnterWaterState_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.SetEnterWaterState(__Params->entityId, __Params->isEnter);
	}

	// Token: 0x06016CB3 RID: 93363 RVA: 0x006A4FC0 File Offset: 0x006A31C0
	protected unsafe static void __CPPCALL_GetClimbState_Implementation(TsMoveBlueprintFunctionLibrary.__GetClimbState_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetClimbState(__Params->entityId);
	}

	// Token: 0x06016CB4 RID: 93364 RVA: 0x006A4FD3 File Offset: 0x006A31D3
	protected unsafe static void __CPPCALL_GetClimbRadius_Implementation(TsMoveBlueprintFunctionLibrary.__GetClimbRadius_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetClimbRadius(__Params->entityId);
	}

	// Token: 0x06016CB5 RID: 93365 RVA: 0x006A4FE6 File Offset: 0x006A31E6
	protected unsafe static void __CPPCALL_GetClimbInfo_Implementation(TsMoveBlueprintFunctionLibrary.__GetClimbInfo_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetClimbInfo(__Params->entityId);
	}

	// Token: 0x06016CB6 RID: 93366 RVA: 0x006A4FF9 File Offset: 0x006A31F9
	protected unsafe static void __CPPCALL_KickExitCheck_Implementation(TsMoveBlueprintFunctionLibrary.__KickExitCheck_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.KickExitCheck(__Params->entityId);
	}

	// Token: 0x06016CB7 RID: 93367 RVA: 0x006A5006 File Offset: 0x006A3206
	protected unsafe static void __CPPCALL_CanClimbPress_Implementation(TsMoveBlueprintFunctionLibrary.__CanClimbPress_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.CanClimbPress(__Params->entityId);
	}

	// Token: 0x06016CB8 RID: 93368 RVA: 0x006A5019 File Offset: 0x006A3219
	protected unsafe static void __CPPCALL_OnEnterClimb_Implementation(TsMoveBlueprintFunctionLibrary.__OnEnterClimb_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.OnEnterClimb(__Params->entityId);
	}

	// Token: 0x06016CB9 RID: 93369 RVA: 0x006A5026 File Offset: 0x006A3226
	protected unsafe static void __CPPCALL_OnExitClimb_Implementation(TsMoveBlueprintFunctionLibrary.__OnExitClimb_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.OnExitClimb(__Params->entityId);
	}

	// Token: 0x06016CBA RID: 93370 RVA: 0x006A5033 File Offset: 0x006A3233
	protected unsafe static void __CPPCALL_DealClimbUpStart_Implementation(TsMoveBlueprintFunctionLibrary.__DealClimbUpStart_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.DealClimbUpStart(__Params->entityId);
	}

	// Token: 0x06016CBB RID: 93371 RVA: 0x006A5040 File Offset: 0x006A3240
	protected unsafe static void __CPPCALL_FinishClimbDown_Implementation(TsMoveBlueprintFunctionLibrary.__FinishClimbDown_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.FinishClimbDown(__Params->entityId);
	}

	// Token: 0x06016CBC RID: 93372 RVA: 0x006A504D File Offset: 0x006A324D
	protected unsafe static void __CPPCALL_DealClimbUpFinish_Implementation(TsMoveBlueprintFunctionLibrary.__DealClimbUpFinish_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.DealClimbUpFinish(__Params->entityId);
	}

	// Token: 0x06016CBD RID: 93373 RVA: 0x006A505C File Offset: 0x006A325C
	protected unsafe static void __CPPCALL_SetClimbState_Implementation(TsMoveBlueprintFunctionLibrary.__SetClimbState_FunctionParams* __Params)
	{
		EClimbState climbState = (EClimbState)__Params->climbState;
		TsMoveBlueprintFunctionLibrary.SetClimbState(__Params->entityId, climbState);
	}

	// Token: 0x06016CBE RID: 93374 RVA: 0x006A507C File Offset: 0x006A327C
	protected unsafe static void __CPPCALL_SetEnterClimbType_Implementation(TsMoveBlueprintFunctionLibrary.__SetEnterClimbType_FunctionParams* __Params)
	{
		EEnterClimb enterType = (EEnterClimb)__Params->enterType;
		TsMoveBlueprintFunctionLibrary.SetEnterClimbType(__Params->entityId, enterType);
	}

	// Token: 0x06016CBF RID: 93375 RVA: 0x006A509C File Offset: 0x006A329C
	protected unsafe static void __CPPCALL_SetExitClimbType_Implementation(TsMoveBlueprintFunctionLibrary.__SetExitClimbType_FunctionParams* __Params)
	{
		EExitClimb exitType = (EExitClimb)__Params->exitType;
		TsMoveBlueprintFunctionLibrary.SetExitClimbType(__Params->entityId, exitType);
	}

	// Token: 0x06016CC0 RID: 93376 RVA: 0x006A50BC File Offset: 0x006A32BC
	protected unsafe static void __CPPCALL_GetSwimLocation_Implementation(TsMoveBlueprintFunctionLibrary.__GetSwimLocation_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetSwimLocation(__Params->entityId);
	}

	// Token: 0x06016CC1 RID: 93377 RVA: 0x006A50CF File Offset: 0x006A32CF
	protected unsafe static void __CPPCALL_GetWaterLocation_Implementation(TsMoveBlueprintFunctionLibrary.__GetWaterLocation_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetWaterLocation(__Params->entityId);
	}

	// Token: 0x06016CC2 RID: 93378 RVA: 0x006A50E2 File Offset: 0x006A32E2
	protected unsafe static void __CPPCALL_GetWaterVolume_Implementation(TsMoveBlueprintFunctionLibrary.__GetWaterVolume_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetWaterVolume(__Params->entityId);
	}

	// Token: 0x06016CC3 RID: 93379 RVA: 0x006A50F5 File Offset: 0x006A32F5
	protected unsafe static void __CPPCALL_GetClimbOnWallAngle_Implementation(TsMoveBlueprintFunctionLibrary.__GetClimbOnWallAngle_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetClimbOnWallAngle(__Params->entityId);
	}

	// Token: 0x06016CC4 RID: 93380 RVA: 0x006A5108 File Offset: 0x006A3308
	protected unsafe static void __CPPCALL_SetUseDebugMovementSetting_Implementation(TsMoveBlueprintFunctionLibrary.__SetUseDebugMovementSetting_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.SetUseDebugMovementSetting(__Params->entityId, __Params->newSelect);
	}

	// Token: 0x06016CC5 RID: 93381 RVA: 0x006A511C File Offset: 0x006A331C
	protected unsafe static void __CPPCALL_SetDebugMovementSetting_Implementation(TsMoveBlueprintFunctionLibrary.__SetDebugMovementSetting_FunctionParams* __Params)
	{
		SMovementSetting newSetting = new SMovementSetting(&__Params->newSetting, true, true);
		TsMoveBlueprintFunctionLibrary.SetDebugMovementSetting(__Params->entityId, newSetting);
	}

	// Token: 0x06016CC6 RID: 93382 RVA: 0x006A5144 File Offset: 0x006A3344
	protected unsafe static void __CPPCALL_SetLockedRotation_Implementation(TsMoveBlueprintFunctionLibrary.__SetLockedRotation_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.SetLockedRotation(__Params->entityId, __Params->lockedRotation);
	}

	// Token: 0x06016CC7 RID: 93383 RVA: 0x006A5157 File Offset: 0x006A3357
	protected unsafe static void __CPPCALL_GetLockedRotation_Implementation(TsMoveBlueprintFunctionLibrary.__GetLockedRotation_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetLockedRotation(__Params->entityId);
	}

	// Token: 0x06016CC8 RID: 93384 RVA: 0x006A516A File Offset: 0x006A336A
	protected unsafe static void __CPPCALL_SetFallingHorizontalMaxSpeed_Implementation(TsMoveBlueprintFunctionLibrary.__SetFallingHorizontalMaxSpeed_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.SetFallingHorizontalMaxSpeed(__Params->entityId, __Params->speed);
	}

	// Token: 0x06016CC9 RID: 93385 RVA: 0x006A517D File Offset: 0x006A337D
	protected unsafe static void __CPPCALL_ClearFallingHorizontalMaxSpeed_Implementation(TsMoveBlueprintFunctionLibrary.__ClearFallingHorizontalMaxSpeed_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.ClearFallingHorizontalMaxSpeed(__Params->entityId);
	}

	// Token: 0x06016CCA RID: 93386 RVA: 0x006A518A File Offset: 0x006A338A
	protected unsafe static void __CPPCALL_DetectClimbWithDirect_Implementation(TsMoveBlueprintFunctionLibrary.__DetectClimbWithDirect_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.DetectClimbWithDirect(__Params->entityId, __Params->bSprintEnter, __Params->direct);
	}

	// Token: 0x06016CCB RID: 93387 RVA: 0x006A51AC File Offset: 0x006A33AC
	protected unsafe static void __CPPCALL_TurnToTarget_Implementation(TsMoveBlueprintFunctionLibrary.__TurnToTarget_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->target);
		TsMoveBlueprintFunctionLibrary.TurnToTarget(__Params->entityId, orCreateUObjectByNativePointer, __Params->speed);
	}

	// Token: 0x06016CCC RID: 93388 RVA: 0x006A51D7 File Offset: 0x006A33D7
	protected unsafe static void __CPPCALL_GetMonsterMoveDirection_Implementation(TsMoveBlueprintFunctionLibrary.__GetMonsterMoveDirection_FunctionParams* __Params)
	{
		*(&__Params->__Result) = (byte)TsMoveBlueprintFunctionLibrary.GetMonsterMoveDirection(__Params->entityId);
	}

	// Token: 0x06016CCD RID: 93389 RVA: 0x006A51EC File Offset: 0x006A33EC
	protected unsafe static void __CPPCALL_GetRoleBody_Implementation(TsMoveBlueprintFunctionLibrary.__GetRoleBody_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsMoveBlueprintFunctionLibrary.GetRoleBody(__Params->entityId));
	}

	// Token: 0x06016CCE RID: 93390 RVA: 0x006A5205 File Offset: 0x006A3405
	protected unsafe static void __CPPCALL_GetRacingRightSpeed_Implementation(TsMoveBlueprintFunctionLibrary.__GetRacingRightSpeed_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetRacingRightSpeed(__Params->entityId);
	}

	// Token: 0x06016CCF RID: 93391 RVA: 0x006A5218 File Offset: 0x006A3418
	protected unsafe static void __CPPCALL_SetPendulumData_Implementation(TsMoveBlueprintFunctionLibrary.__SetPendulumData_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.SetPendulumData(__Params->entityId, __Params->addVelocityX, __Params->addVelocityY, __Params->addVelocityZ, __Params->forwardLossPercentage, __Params->lossPercentage, __Params->gravity, __Params->friction, __Params->deceleration, __Params->accelerator, __Params->maxSpeed, __Params->maxFallingSpeed);
	}

	// Token: 0x06016CD0 RID: 93392 RVA: 0x006A5272 File Offset: 0x006A3472
	protected unsafe static void __CPPCALL_Reset_Implementation(TsMoveBlueprintFunctionLibrary.__Reset_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.Reset(__Params->entityId);
	}

	// Token: 0x06016CD1 RID: 93393 RVA: 0x006A527F File Offset: 0x006A347F
	protected unsafe static void __CPPCALL_SetGrabPoint_Implementation(TsMoveBlueprintFunctionLibrary.__SetGrabPoint_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.SetGrabPoint(__Params->entityId, __Params->point);
	}

	// Token: 0x06016CD2 RID: 93394 RVA: 0x006A5292 File Offset: 0x006A3492
	protected unsafe static void __CPPCALL_GetGrabPoint_Implementation(TsMoveBlueprintFunctionLibrary.__GetGrabPoint_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetGrabPoint(__Params->entityId);
	}

	// Token: 0x06016CD3 RID: 93395 RVA: 0x006A52A5 File Offset: 0x006A34A5
	protected unsafe static void __CPPCALL_SetHooked_Implementation(TsMoveBlueprintFunctionLibrary.__SetHooked_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.SetHooked(__Params->entityId, __Params->isHooked);
	}

	// Token: 0x06016CD4 RID: 93396 RVA: 0x006A52B8 File Offset: 0x006A34B8
	protected unsafe static void __CPPCALL_GetHooked_Implementation(TsMoveBlueprintFunctionLibrary.__GetHooked_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetHooked(__Params->entityId);
	}

	// Token: 0x06016CD5 RID: 93397 RVA: 0x006A52CC File Offset: 0x006A34CC
	protected unsafe static void __CPPCALL_SetSocketName_Implementation(TsMoveBlueprintFunctionLibrary.__SetSocketName_FunctionParams* __Params)
	{
		string socketName = FString.ToString((void*)(&__Params->socketName));
		TsMoveBlueprintFunctionLibrary.SetSocketName(__Params->entityId, socketName);
	}

	// Token: 0x06016CD6 RID: 93398 RVA: 0x006A52F2 File Offset: 0x006A34F2
	protected unsafe static void __CPPCALL_SetRopeForce_Implementation(TsMoveBlueprintFunctionLibrary.__SetRopeForce_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.SetRopeForce(__Params->entityId, __Params->ropeForce);
	}

	// Token: 0x06016CD7 RID: 93399 RVA: 0x006A5305 File Offset: 0x006A3505
	protected unsafe static void __CPPCALL_GetRopeForce_Implementation(TsMoveBlueprintFunctionLibrary.__GetRopeForce_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetRopeForce(__Params->entityId);
	}

	// Token: 0x06016CD8 RID: 93400 RVA: 0x006A5318 File Offset: 0x006A3518
	protected unsafe static void __CPPCALL_SetDistanceRopeToActor_Implementation(TsMoveBlueprintFunctionLibrary.__SetDistanceRopeToActor_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.SetDistanceRopeToActor(__Params->entityId, __Params->ropeForce);
	}

	// Token: 0x06016CD9 RID: 93401 RVA: 0x006A532B File Offset: 0x006A352B
	protected unsafe static void __CPPCALL_GetDistanceRopeToActor_Implementation(TsMoveBlueprintFunctionLibrary.__GetDistanceRopeToActor_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetDistanceRopeToActor(__Params->entityId);
	}

	// Token: 0x06016CDA RID: 93402 RVA: 0x006A533E File Offset: 0x006A353E
	protected unsafe static void __CPPCALL_SetAirControl_Implementation(TsMoveBlueprintFunctionLibrary.__SetAirControl_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.SetAirControl(__Params->entityId, __Params->airControl);
	}

	// Token: 0x06016CDB RID: 93403 RVA: 0x006A5351 File Offset: 0x006A3551
	protected unsafe static void __CPPCALL_GetAirControl_Implementation(TsMoveBlueprintFunctionLibrary.__GetAirControl_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetAirControl(__Params->entityId);
	}

	// Token: 0x06016CDC RID: 93404 RVA: 0x006A5364 File Offset: 0x006A3564
	protected unsafe static void __CPPCALL_SetUpLength_Implementation(TsMoveBlueprintFunctionLibrary.__SetUpLength_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.SetUpLength(__Params->entityId, __Params->length);
	}

	// Token: 0x06016CDD RID: 93405 RVA: 0x006A5377 File Offset: 0x006A3577
	protected unsafe static void __CPPCALL_SetCanMoveFromInput_Implementation(TsMoveBlueprintFunctionLibrary.__SetCanMoveFromInput_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.SetCanMoveFromInput(__Params->entityId, __Params->canMove);
	}

	// Token: 0x06016CDE RID: 93406 RVA: 0x006A538C File Offset: 0x006A358C
	protected unsafe static void __CPPCALL_UpdateAnimInfoMove_Implementation(TsMoveBlueprintFunctionLibrary.__UpdateAnimInfoMove_FunctionParams* __Params)
	{
		BP_ABPLogicParams_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_ABPLogicParams_C>(__Params->animLogicParams);
		TsMoveBlueprintFunctionLibrary.UpdateAnimInfoMove(__Params->entityId, orCreateUObjectByNativePointer);
	}

	// Token: 0x06016CDF RID: 93407 RVA: 0x006A53B4 File Offset: 0x006A35B4
	protected unsafe static void __CPPCALL_UpdateAnimInfoMoveMonster_Implementation(TsMoveBlueprintFunctionLibrary.__UpdateAnimInfoMoveMonster_FunctionParams* __Params)
	{
		BP_ABPLogicParams_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_ABPLogicParams_C>(__Params->animLogicParams);
		TsMoveBlueprintFunctionLibrary.UpdateAnimInfoMoveMonster(__Params->entityId, orCreateUObjectByNativePointer);
	}

	// Token: 0x06016CE0 RID: 93408 RVA: 0x006A53DC File Offset: 0x006A35DC
	protected unsafe static void __CPPCALL_UpdateAnimInfoMoveRoleNpc_Implementation(TsMoveBlueprintFunctionLibrary.__UpdateAnimInfoMoveRoleNpc_FunctionParams* __Params)
	{
		BP_ABPLogicParams_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_ABPLogicParams_C>(__Params->animLogicParams);
		TsMoveBlueprintFunctionLibrary.UpdateAnimInfoMoveRoleNpc(__Params->entityId, orCreateUObjectByNativePointer);
	}

	// Token: 0x06016CE1 RID: 93409 RVA: 0x006A5404 File Offset: 0x006A3604
	protected unsafe static void __CPPCALL_TurnOnAutomaticFlightMode_Implementation(TsMoveBlueprintFunctionLibrary.__TurnOnAutomaticFlightMode_FunctionParams* __Params)
	{
		ICM_AutomaticFlight_DataBase_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ICM_AutomaticFlight_DataBase_C>(__Params->dataAsset);
		TsMoveBlueprintFunctionLibrary.TurnOnAutomaticFlightMode(__Params->entityId, orCreateUObjectByNativePointer);
	}

	// Token: 0x06016CE2 RID: 93410 RVA: 0x006A5429 File Offset: 0x006A3629
	protected unsafe static void __CPPCALL_TurnOffAutomaticFlightMode_Implementation(TsMoveBlueprintFunctionLibrary.__TurnOffAutomaticFlightMode_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.TurnOffAutomaticFlightMode(__Params->entityId);
	}

	// Token: 0x06016CE3 RID: 93411 RVA: 0x006A5438 File Offset: 0x006A3638
	protected unsafe static void __CPPCALL_TurnOnCameraDrivenAutoFlightMode_Implementation(TsMoveBlueprintFunctionLibrary.__TurnOnCameraDrivenAutoFlightMode_FunctionParams* __Params)
	{
		BP_CameraDrivenAutoFlightData_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_CameraDrivenAutoFlightData_C>(__Params->dataAsset);
		TsMoveBlueprintFunctionLibrary.TurnOnCameraDrivenAutoFlightMode(__Params->entityId, orCreateUObjectByNativePointer);
	}

	// Token: 0x06016CE4 RID: 93412 RVA: 0x006A545D File Offset: 0x006A365D
	protected unsafe static void __CPPCALL_TurnOffCameraDrivenAutoFlightMode_Implementation(TsMoveBlueprintFunctionLibrary.__TurnOffCameraDrivenAutoFlightMode_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.TurnOffCameraDrivenAutoFlightMode(__Params->entityId);
	}

	// Token: 0x06016CE5 RID: 93413 RVA: 0x006A546A File Offset: 0x006A366A
	protected unsafe static void __CPPCALL_SimpleSwim_Implementation(TsMoveBlueprintFunctionLibrary.__SimpleSwim_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.SimpleSwim(__Params->entityId, __Params->deltaSeconds, __Params->detectedHeight, __Params->currentSpeed);
	}

	// Token: 0x06016CE6 RID: 93414 RVA: 0x006A548F File Offset: 0x006A368F
	protected unsafe static void __CPPCALL_EnterRoll_Implementation(TsMoveBlueprintFunctionLibrary.__EnterRoll_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.EnterRoll(__Params->entityId, __Params->targetSpeed, __Params->friction, __Params->accelOnGround, __Params->gravity, __Params->stepUpHeight, __Params->maxSpeed);
	}

	// Token: 0x06016CE7 RID: 93415 RVA: 0x006A54C0 File Offset: 0x006A36C0
	protected unsafe static void __CPPCALL_LeaveRoll_Implementation(TsMoveBlueprintFunctionLibrary.__LeaveRoll_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.LeaveRoll(__Params->entityId);
	}

	// Token: 0x06016CE8 RID: 93416 RVA: 0x006A54CD File Offset: 0x006A36CD
	protected unsafe static void __CPPCALL_EnterKite_Implementation(TsMoveBlueprintFunctionLibrary.__EnterKite_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.EnterKite(__Params->entityId);
	}

	// Token: 0x06016CE9 RID: 93417 RVA: 0x006A54E0 File Offset: 0x006A36E0
	protected unsafe static void __CPPCALL_LerpVelocityBlend_Implementation(TsMoveBlueprintFunctionLibrary.__LerpVelocityBlend_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.LerpVelocityBlend(__Params->outVeloctiyBlend, __Params->to, __Params->alpha);
	}

	// Token: 0x06016CEA RID: 93418 RVA: 0x006A54FF File Offset: 0x006A36FF
	protected unsafe static void __CPPCALL_MoveCharacter_Implementation(TsMoveBlueprintFunctionLibrary.__MoveCharacter_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.MoveCharacter(__Params->entityId, __Params->targetLocation, __Params->speed, __Params->arriveDist);
	}

	// Token: 0x06016CEB RID: 93419 RVA: 0x006A5524 File Offset: 0x006A3724
	protected unsafe static void __CPPCALL_StartAssistedWalk_Implementation(TsMoveBlueprintFunctionLibrary.__StartAssistedWalk_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.StartAssistedWalk(__Params->entityId);
	}

	// Token: 0x06016CEC RID: 93420 RVA: 0x006A5531 File Offset: 0x006A3731
	protected unsafe static void __CPPCALL_EnterAssistedWalkIdle_Implementation(TsMoveBlueprintFunctionLibrary.__EnterAssistedWalkIdle_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.EnterAssistedWalkIdle(__Params->entityId);
	}

	// Token: 0x06016CED RID: 93421 RVA: 0x006A553E File Offset: 0x006A373E
	protected unsafe static void __CPPCALL_EnterAssistedWalking_Implementation(TsMoveBlueprintFunctionLibrary.__EnterAssistedWalking_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.EnterAssistedWalking(__Params->entityId);
	}

	// Token: 0x06016CEE RID: 93422 RVA: 0x006A554B File Offset: 0x006A374B
	protected unsafe static void __CPPCALL_LeftAssistedWalking_Implementation(TsMoveBlueprintFunctionLibrary.__LeftAssistedWalking_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.LeftAssistedWalking(__Params->entityId);
	}

	// Token: 0x06016CEF RID: 93423 RVA: 0x006A5558 File Offset: 0x006A3758
	protected unsafe static void __CPPCALL_LeftStartSwing_Implementation(TsMoveBlueprintFunctionLibrary.__LeftStartSwing_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.LeftStartSwing(__Params->entityId);
	}

	// Token: 0x06016CF0 RID: 93424 RVA: 0x006A5565 File Offset: 0x006A3765
	protected unsafe static void __CPPCALL_LeftLoopSwing_Implementation(TsMoveBlueprintFunctionLibrary.__LeftLoopSwing_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.LeftLoopSwing(__Params->entityId);
	}

	// Token: 0x06016CF1 RID: 93425 RVA: 0x006A5572 File Offset: 0x006A3772
	protected unsafe static void __CPPCALL_LeftEndSwing_Implementation(TsMoveBlueprintFunctionLibrary.__LeftEndSwing_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.LeftEndSwing(__Params->entityId);
	}

	// Token: 0x06016CF2 RID: 93426 RVA: 0x006A5580 File Offset: 0x006A3780
	protected unsafe static void __CPPCALL_ResetClimbConfig_Implementation(TsMoveBlueprintFunctionLibrary.__ResetClimbConfig_FunctionParams* __Params)
	{
		string key = FString.ToString((void*)(&__Params->key));
		TsMoveBlueprintFunctionLibrary.ResetClimbConfig(__Params->entityId, key);
	}

	// Token: 0x06016CF3 RID: 93427 RVA: 0x006A55A6 File Offset: 0x006A37A6
	protected unsafe static void __CPPCALL_EnableGoThrough_Implementation(TsMoveBlueprintFunctionLibrary.__EnableGoThrough_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.EnableGoThrough(__Params->entityId, __Params->goThroughPriority);
	}

	// Token: 0x06016CF4 RID: 93428 RVA: 0x006A55B9 File Offset: 0x006A37B9
	protected unsafe static void __CPPCALL_DisableGoThrough_Implementation(TsMoveBlueprintFunctionLibrary.__DisableGoThrough_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.DisableGoThrough(__Params->entityId);
	}

	// Token: 0x06016CF5 RID: 93429 RVA: 0x006A55C6 File Offset: 0x006A37C6
	protected unsafe static void __CPPCALL_AnimTurnStart_Implementation(TsMoveBlueprintFunctionLibrary.__AnimTurnStart_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.AnimTurnStart(__Params->entityId);
	}

	// Token: 0x06016CF6 RID: 93430 RVA: 0x006A55D3 File Offset: 0x006A37D3
	protected unsafe static void __CPPCALL_AnimTurnFinish_Implementation(TsMoveBlueprintFunctionLibrary.__AnimTurnFinish_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.AnimTurnFinish(__Params->entityId, __Params->isGoingMove);
	}

	// Token: 0x0400BF32 RID: 48946
	private const int MIN_ROTATOR_ANGLE = 10;

	// Token: 0x0400BF33 RID: 48947
	private const float MAX_SIMPLE_SWIM_DELTA = 0.15f;

	// Token: 0x0400BF34 RID: 48948
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static global::Vector tmpVector = global::Vector.Create();

	// Token: 0x0400BF35 RID: 48949
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static global::Vector tmpVector2 = global::Vector.Create();

	// Token: 0x0400BF36 RID: 48950
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static Quat tmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400BF37 RID: 48951
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static global::Rotator tmpRotator = global::Rotator.Create();

	// Token: 0x0400BF38 RID: 48952
	[Nullable(2)]
	private static UTraceLineElement WaterTraceInternal = null;

	// Token: 0x0400BF39 RID: 48953
	[Nullable(2)]
	private static UTraceLineElement GroundTraceInternal = null;

	// Token: 0x0400BF3A RID: 48954
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsMoveBlueprintFunctionLibrary.TsMoveBlueprintFunctionLibrary_C";

	// Token: 0x0400BF3B RID: 48955
	private static IntPtr _ClassPtr;

	// Token: 0x0400BF3C RID: 48956
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0200875C RID: 34652
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __SetActorRotationWithPriority_FunctionParams
	{
		// Token: 0x0402B5EE RID: 177646
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B5EF RID: 177647
		[FieldOffset(4)]
		public FRotator value;

		// Token: 0x0402B5F0 RID: 177648
		[FieldOffset(16)]
		public bool sweep;

		// Token: 0x0402B5F1 RID: 177649
		[FieldOffset(24)]
		public FString context;

		// Token: 0x0402B5F2 RID: 177650
		[FieldOffset(40)]
		public IntPtr __WorldContext;

		// Token: 0x0402B5F3 RID: 177651
		[FieldOffset(48)]
		public bool __Result;
	}

	// Token: 0x0200875D RID: 34653
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 72)]
	protected ref struct __SetActorLocationWithContext_FunctionParams
	{
		// Token: 0x0402B5F4 RID: 177652
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B5F5 RID: 177653
		[FieldOffset(8)]
		public FVectorDouble location;

		// Token: 0x0402B5F6 RID: 177654
		[FieldOffset(32)]
		public bool sweep;

		// Token: 0x0402B5F7 RID: 177655
		[FieldOffset(40)]
		public FString context;

		// Token: 0x0402B5F8 RID: 177656
		[FieldOffset(56)]
		public IntPtr __WorldContext;

		// Token: 0x0402B5F9 RID: 177657
		[FieldOffset(64)]
		public bool __Result;
	}

	// Token: 0x0200875E RID: 34654
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 72)]
	protected ref struct __SetActorLocationAndRotationWithContext_FunctionParams
	{
		// Token: 0x0402B5FA RID: 177658
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B5FB RID: 177659
		[FieldOffset(8)]
		public FVectorDouble location;

		// Token: 0x0402B5FC RID: 177660
		[FieldOffset(32)]
		public FRotator rotation;

		// Token: 0x0402B5FD RID: 177661
		[FieldOffset(44)]
		public bool sweep;

		// Token: 0x0402B5FE RID: 177662
		[FieldOffset(48)]
		public FString context;

		// Token: 0x0402B5FF RID: 177663
		[FieldOffset(64)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200875F RID: 34655
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __SetActorRotationWithContext_FunctionParams
	{
		// Token: 0x0402B600 RID: 177664
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B601 RID: 177665
		[FieldOffset(4)]
		public FRotator rotation;

		// Token: 0x0402B602 RID: 177666
		[FieldOffset(16)]
		public bool sweep;

		// Token: 0x0402B603 RID: 177667
		[FieldOffset(24)]
		public FString context;

		// Token: 0x0402B604 RID: 177668
		[FieldOffset(40)]
		public IntPtr __WorldContext;

		// Token: 0x0402B605 RID: 177669
		[FieldOffset(48)]
		public bool __Result;
	}

	// Token: 0x02008760 RID: 34656
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __AddActorWorldOffsetWithContext_FunctionParams
	{
		// Token: 0x0402B606 RID: 177670
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B607 RID: 177671
		[FieldOffset(8)]
		public FVectorDouble offset;

		// Token: 0x0402B608 RID: 177672
		[FieldOffset(32)]
		public bool sweep;

		// Token: 0x0402B609 RID: 177673
		[FieldOffset(40)]
		public FString context;

		// Token: 0x0402B60A RID: 177674
		[FieldOffset(56)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008761 RID: 34657
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __AddActorWorldOffsetWithContextAndReset_FunctionParams
	{
		// Token: 0x0402B60B RID: 177675
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B60C RID: 177676
		[FieldOffset(8)]
		public FVectorDouble offset;

		// Token: 0x0402B60D RID: 177677
		[FieldOffset(32)]
		public bool sweep;

		// Token: 0x0402B60E RID: 177678
		[FieldOffset(40)]
		public FString context;

		// Token: 0x0402B60F RID: 177679
		[FieldOffset(56)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008762 RID: 34658
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __AddActorLocalOffsetWithContext_FunctionParams
	{
		// Token: 0x0402B610 RID: 177680
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B611 RID: 177681
		[FieldOffset(8)]
		public FVectorDouble offset;

		// Token: 0x0402B612 RID: 177682
		[FieldOffset(32)]
		public bool sweep;

		// Token: 0x0402B613 RID: 177683
		[FieldOffset(40)]
		public FString context;

		// Token: 0x0402B614 RID: 177684
		[FieldOffset(56)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008763 RID: 34659
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __AddActorWorldRotationWithContext_FunctionParams
	{
		// Token: 0x0402B615 RID: 177685
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B616 RID: 177686
		[FieldOffset(4)]
		public FRotator rotation;

		// Token: 0x0402B617 RID: 177687
		[FieldOffset(16)]
		public bool sweep;

		// Token: 0x0402B618 RID: 177688
		[FieldOffset(24)]
		public FString context;

		// Token: 0x0402B619 RID: 177689
		[FieldOffset(40)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008764 RID: 34660
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __AddActorLocalRotationWithContext_FunctionParams
	{
		// Token: 0x0402B61A RID: 177690
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B61B RID: 177691
		[FieldOffset(4)]
		public FRotator rotation;

		// Token: 0x0402B61C RID: 177692
		[FieldOffset(16)]
		public bool sweep;

		// Token: 0x0402B61D RID: 177693
		[FieldOffset(24)]
		public FString context;

		// Token: 0x0402B61E RID: 177694
		[FieldOffset(40)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008765 RID: 34661
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 72)]
	protected ref struct __ActorTeleportToWithContext_FunctionParams
	{
		// Token: 0x0402B61F RID: 177695
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B620 RID: 177696
		[FieldOffset(8)]
		public FVectorDouble location;

		// Token: 0x0402B621 RID: 177697
		[FieldOffset(32)]
		public FRotator rotation;

		// Token: 0x0402B622 RID: 177698
		[FieldOffset(48)]
		public FString context;

		// Token: 0x0402B623 RID: 177699
		[FieldOffset(64)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008766 RID: 34662
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __SetActorLookAtWithContext_FunctionParams
	{
		// Token: 0x0402B624 RID: 177700
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B625 RID: 177701
		[FieldOffset(8)]
		public FVectorDouble targetPoint;

		// Token: 0x0402B626 RID: 177702
		[FieldOffset(32)]
		public FString context;

		// Token: 0x0402B627 RID: 177703
		[FieldOffset(48)]
		public IntPtr __WorldContext;

		// Token: 0x0402B628 RID: 177704
		[FieldOffset(56)]
		public bool __Result;
	}

	// Token: 0x02008767 RID: 34663
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __ActorKuroMoveAlongFloorWithContext_FunctionParams
	{
		// Token: 0x0402B629 RID: 177705
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B62A RID: 177706
		[FieldOffset(4)]
		public FVector velocity;

		// Token: 0x0402B62B RID: 177707
		[FieldOffset(16)]
		public float deltaSeconds;

		// Token: 0x0402B62C RID: 177708
		[FieldOffset(24)]
		public FString context;

		// Token: 0x0402B62D RID: 177709
		[FieldOffset(40)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008768 RID: 34664
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __GetInputDirect_FunctionParams
	{
		// Token: 0x0402B62E RID: 177710
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B62F RID: 177711
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B630 RID: 177712
		[FieldOffset(16)]
		public FVectorDouble __Result;
	}

	// Token: 0x02008769 RID: 34665
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SetInputDirect_FunctionParams
	{
		// Token: 0x0402B631 RID: 177713
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B632 RID: 177714
		[FieldOffset(8)]
		public FVectorDouble direct;

		// Token: 0x0402B633 RID: 177715
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200876A RID: 34666
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetInputRotator_FunctionParams
	{
		// Token: 0x0402B634 RID: 177716
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B635 RID: 177717
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B636 RID: 177718
		[FieldOffset(16)]
		public FRotator __Result;
	}

	// Token: 0x0200876B RID: 34667
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetInputRotator_FunctionParams
	{
		// Token: 0x0402B637 RID: 177719
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B638 RID: 177720
		[FieldOffset(4)]
		public FRotator rotator;

		// Token: 0x0402B639 RID: 177721
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200876C RID: 34668
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SetCharacterHidden_FunctionParams
	{
		// Token: 0x0402B63A RID: 177722
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B63B RID: 177723
		[FieldOffset(4)]
		public bool isHidden;

		// Token: 0x0402B63C RID: 177724
		[FieldOffset(8)]
		public IntPtr callObject;

		// Token: 0x0402B63D RID: 177725
		[FieldOffset(16)]
		public FString reason;

		// Token: 0x0402B63E RID: 177726
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200876D RID: 34669
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetHiddenMovementMode_FunctionParams
	{
		// Token: 0x0402B63F RID: 177727
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B640 RID: 177728
		[FieldOffset(4)]
		public bool isHidden;

		// Token: 0x0402B641 RID: 177729
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200876E RID: 34670
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __CanResponseInput_FunctionParams
	{
		// Token: 0x0402B642 RID: 177730
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B643 RID: 177731
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B644 RID: 177732
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200876F RID: 34671
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __CanJumpPress_FunctionParams
	{
		// Token: 0x0402B645 RID: 177733
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B646 RID: 177734
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B647 RID: 177735
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02008770 RID: 34672
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __CanWalkPress_FunctionParams
	{
		// Token: 0x0402B648 RID: 177736
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B649 RID: 177737
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B64A RID: 177738
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02008771 RID: 34673
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetHeightAboveGround_FunctionParams
	{
		// Token: 0x0402B64B RID: 177739
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B64C RID: 177740
		[FieldOffset(4)]
		public float detectedHeight;

		// Token: 0x0402B64D RID: 177741
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B64E RID: 177742
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02008772 RID: 34674
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetAcceleration_FunctionParams
	{
		// Token: 0x0402B64F RID: 177743
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B650 RID: 177744
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B651 RID: 177745
		[FieldOffset(16)]
		public FVector __Result;
	}

	// Token: 0x02008773 RID: 34675
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetAimYawRate_FunctionParams
	{
		// Token: 0x0402B652 RID: 177746
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B653 RID: 177747
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B654 RID: 177748
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02008774 RID: 34676
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1928)]
	protected ref struct __GetMovementData_FunctionParams
	{
		// Token: 0x0402B655 RID: 177749
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B656 RID: 177750
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B657 RID: 177751
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x02008775 RID: 34677
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __SmoothCharacterRotation_FunctionParams
	{
		// Token: 0x0402B658 RID: 177752
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B659 RID: 177753
		[FieldOffset(4)]
		public FRotator target;

		// Token: 0x0402B65A RID: 177754
		[FieldOffset(16)]
		public float speed;

		// Token: 0x0402B65B RID: 177755
		[FieldOffset(24)]
		public FString context;

		// Token: 0x0402B65C RID: 177756
		[FieldOffset(40)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008776 RID: 34678
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __HasMoveInput_FunctionParams
	{
		// Token: 0x0402B65D RID: 177757
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B65E RID: 177758
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B65F RID: 177759
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02008777 RID: 34679
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __HasMoveInputOrTickIntervalAndModelBuffer_FunctionParams
	{
		// Token: 0x0402B660 RID: 177760
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B661 RID: 177761
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B662 RID: 177762
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02008778 RID: 34680
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __HasRotatorInput_FunctionParams
	{
		// Token: 0x0402B663 RID: 177763
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B664 RID: 177764
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B665 RID: 177765
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02008779 RID: 34681
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __IsMoving_FunctionParams
	{
		// Token: 0x0402B666 RID: 177766
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B667 RID: 177767
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B668 RID: 177768
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200877A RID: 34682
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __IsJump_FunctionParams
	{
		// Token: 0x0402B669 RID: 177769
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B66A RID: 177770
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B66B RID: 177771
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200877B RID: 34683
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetSpeed_FunctionParams
	{
		// Token: 0x0402B66C RID: 177772
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B66D RID: 177773
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B66E RID: 177774
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x0200877C RID: 34684
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetGroundedTime_FunctionParams
	{
		// Token: 0x0402B66F RID: 177775
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B670 RID: 177776
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B671 RID: 177777
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x0200877D RID: 34685
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __IsFallingIntoWater_FunctionParams
	{
		// Token: 0x0402B672 RID: 177778
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B673 RID: 177779
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B674 RID: 177780
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200877E RID: 34686
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SetForceSpeed_FunctionParams
	{
		// Token: 0x0402B675 RID: 177781
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B676 RID: 177782
		[FieldOffset(8)]
		public FVectorDouble speed;

		// Token: 0x0402B677 RID: 177783
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200877F RID: 34687
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __SetAddMove_FunctionParams
	{
		// Token: 0x0402B678 RID: 177784
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B679 RID: 177785
		[FieldOffset(8)]
		public IntPtr mesh;

		// Token: 0x0402B67A RID: 177786
		[FieldOffset(16)]
		public FVectorDouble speed;

		// Token: 0x0402B67B RID: 177787
		[FieldOffset(40)]
		public float timeLength;

		// Token: 0x0402B67C RID: 177788
		[FieldOffset(48)]
		public IntPtr curve;

		// Token: 0x0402B67D RID: 177789
		[FieldOffset(56)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008780 RID: 34688
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __StopAddMove_FunctionParams
	{
		// Token: 0x0402B67E RID: 177790
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B67F RID: 177791
		[FieldOffset(8)]
		public IntPtr mesh;

		// Token: 0x0402B680 RID: 177792
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008781 RID: 34689
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 200)]
	protected ref struct __FixActorLocation_FunctionParams
	{
		// Token: 0x0402B681 RID: 177793
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B682 RID: 177794
		[FieldOffset(8)]
		public FVectorDouble target;

		// Token: 0x0402B683 RID: 177795
		[FieldOffset(32)]
		public float offset;

		// Token: 0x0402B684 RID: 177796
		[FieldOffset(40)]
		public IntPtr __WorldContext;

		// Token: 0x0402B685 RID: 177797
		[FieldOffset(48)]
		public byte __Result;
	}

	// Token: 0x02008782 RID: 34690
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __StopAllAddMove_FunctionParams
	{
		// Token: 0x0402B686 RID: 177798
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B687 RID: 177799
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008783 RID: 34691
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __SetAddMoveWorld_FunctionParams
	{
		// Token: 0x0402B688 RID: 177800
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B689 RID: 177801
		[FieldOffset(8)]
		public IntPtr mesh;

		// Token: 0x0402B68A RID: 177802
		[FieldOffset(16)]
		public FVectorDouble speed;

		// Token: 0x0402B68B RID: 177803
		[FieldOffset(40)]
		public float timeLength;

		// Token: 0x0402B68C RID: 177804
		[FieldOffset(48)]
		public IntPtr curve;

		// Token: 0x0402B68D RID: 177805
		[FieldOffset(56)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008784 RID: 34692
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __SetAddMoveWorldSpeed_FunctionParams
	{
		// Token: 0x0402B68E RID: 177806
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B68F RID: 177807
		[FieldOffset(8)]
		public IntPtr mesh;

		// Token: 0x0402B690 RID: 177808
		[FieldOffset(16)]
		public FVectorDouble speed;

		// Token: 0x0402B691 RID: 177809
		[FieldOffset(40)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008785 RID: 34693
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SetAddMoveOffset_FunctionParams
	{
		// Token: 0x0402B692 RID: 177810
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B693 RID: 177811
		[FieldOffset(8)]
		public FVectorDouble offset;

		// Token: 0x0402B694 RID: 177812
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008786 RID: 34694
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetAddMoveRotation_FunctionParams
	{
		// Token: 0x0402B695 RID: 177813
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B696 RID: 177814
		[FieldOffset(4)]
		public FRotator rotation;

		// Token: 0x0402B697 RID: 177815
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008787 RID: 34695
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetEnterWaterState_FunctionParams
	{
		// Token: 0x0402B698 RID: 177816
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B699 RID: 177817
		[FieldOffset(4)]
		public bool isEnter;

		// Token: 0x0402B69A RID: 177818
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008788 RID: 34696
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetClimbState_FunctionParams
	{
		// Token: 0x0402B69B RID: 177819
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B69C RID: 177820
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B69D RID: 177821
		[FieldOffset(16)]
		public AkiClient.Game.Aki.Character.BaseCharacter.SClimbState __Result;
	}

	// Token: 0x02008789 RID: 34697
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetClimbRadius_FunctionParams
	{
		// Token: 0x0402B69E RID: 177822
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B69F RID: 177823
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B6A0 RID: 177824
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x0200878A RID: 34698
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __GetClimbInfo_FunctionParams
	{
		// Token: 0x0402B6A1 RID: 177825
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B6A2 RID: 177826
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B6A3 RID: 177827
		[FieldOffset(16)]
		public AkiClient.Game.Aki.Character.BaseCharacter.SClimbInfo __Result;
	}

	// Token: 0x0200878B RID: 34699
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __KickExitCheck_FunctionParams
	{
		// Token: 0x0402B6A4 RID: 177828
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B6A5 RID: 177829
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200878C RID: 34700
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __CanClimbPress_FunctionParams
	{
		// Token: 0x0402B6A6 RID: 177830
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B6A7 RID: 177831
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B6A8 RID: 177832
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200878D RID: 34701
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __OnEnterClimb_FunctionParams
	{
		// Token: 0x0402B6A9 RID: 177833
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B6AA RID: 177834
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200878E RID: 34702
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __OnExitClimb_FunctionParams
	{
		// Token: 0x0402B6AB RID: 177835
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B6AC RID: 177836
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200878F RID: 34703
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __DealClimbUpStart_FunctionParams
	{
		// Token: 0x0402B6AD RID: 177837
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B6AE RID: 177838
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008790 RID: 34704
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __FinishClimbDown_FunctionParams
	{
		// Token: 0x0402B6AF RID: 177839
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B6B0 RID: 177840
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008791 RID: 34705
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __DealClimbUpFinish_FunctionParams
	{
		// Token: 0x0402B6B1 RID: 177841
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B6B2 RID: 177842
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008792 RID: 34706
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetClimbState_FunctionParams
	{
		// Token: 0x0402B6B3 RID: 177843
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B6B4 RID: 177844
		[FieldOffset(4)]
		public byte climbState;

		// Token: 0x0402B6B5 RID: 177845
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008793 RID: 34707
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetEnterClimbType_FunctionParams
	{
		// Token: 0x0402B6B6 RID: 177846
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B6B7 RID: 177847
		[FieldOffset(4)]
		public byte enterType;

		// Token: 0x0402B6B8 RID: 177848
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008794 RID: 34708
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetExitClimbType_FunctionParams
	{
		// Token: 0x0402B6B9 RID: 177849
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B6BA RID: 177850
		[FieldOffset(4)]
		public byte exitType;

		// Token: 0x0402B6BB RID: 177851
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008795 RID: 34709
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __GetSwimLocation_FunctionParams
	{
		// Token: 0x0402B6BC RID: 177852
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B6BD RID: 177853
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B6BE RID: 177854
		[FieldOffset(16)]
		public FVectorDouble __Result;
	}

	// Token: 0x02008796 RID: 34710
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __GetWaterLocation_FunctionParams
	{
		// Token: 0x0402B6BF RID: 177855
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B6C0 RID: 177856
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B6C1 RID: 177857
		[FieldOffset(16)]
		public FVectorDouble __Result;
	}

	// Token: 0x02008797 RID: 34711
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetWaterVolume_FunctionParams
	{
		// Token: 0x0402B6C2 RID: 177858
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B6C3 RID: 177859
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B6C4 RID: 177860
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02008798 RID: 34712
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetClimbOnWallAngle_FunctionParams
	{
		// Token: 0x0402B6C5 RID: 177861
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B6C6 RID: 177862
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B6C7 RID: 177863
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02008799 RID: 34713
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetUseDebugMovementSetting_FunctionParams
	{
		// Token: 0x0402B6C8 RID: 177864
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B6C9 RID: 177865
		[FieldOffset(4)]
		public bool newSelect;

		// Token: 0x0402B6CA RID: 177866
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200879A RID: 34714
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 112)]
	protected ref struct __SetDebugMovementSetting_FunctionParams
	{
		// Token: 0x0402B6CB RID: 177867
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B6CC RID: 177868
		[FieldOffset(8)]
		public byte newSetting;

		// Token: 0x0402B6CD RID: 177869
		[FieldOffset(104)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200879B RID: 34715
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetLockedRotation_FunctionParams
	{
		// Token: 0x0402B6CE RID: 177870
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B6CF RID: 177871
		[FieldOffset(4)]
		public bool lockedRotation;

		// Token: 0x0402B6D0 RID: 177872
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200879C RID: 34716
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetLockedRotation_FunctionParams
	{
		// Token: 0x0402B6D1 RID: 177873
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B6D2 RID: 177874
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B6D3 RID: 177875
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200879D RID: 34717
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetFallingHorizontalMaxSpeed_FunctionParams
	{
		// Token: 0x0402B6D4 RID: 177876
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B6D5 RID: 177877
		[FieldOffset(4)]
		public float speed;

		// Token: 0x0402B6D6 RID: 177878
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200879E RID: 34718
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ClearFallingHorizontalMaxSpeed_FunctionParams
	{
		// Token: 0x0402B6D7 RID: 177879
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B6D8 RID: 177880
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200879F RID: 34719
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __DetectClimbWithDirect_FunctionParams
	{
		// Token: 0x0402B6D9 RID: 177881
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B6DA RID: 177882
		[FieldOffset(4)]
		public bool bSprintEnter;

		// Token: 0x0402B6DB RID: 177883
		[FieldOffset(8)]
		public FVectorDouble direct;

		// Token: 0x0402B6DC RID: 177884
		[FieldOffset(32)]
		public IntPtr __WorldContext;

		// Token: 0x0402B6DD RID: 177885
		[FieldOffset(40)]
		public bool __Result;
	}

	// Token: 0x020087A0 RID: 34720
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __TurnToTarget_FunctionParams
	{
		// Token: 0x0402B6DE RID: 177886
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B6DF RID: 177887
		[FieldOffset(8)]
		public IntPtr target;

		// Token: 0x0402B6E0 RID: 177888
		[FieldOffset(16)]
		public float speed;

		// Token: 0x0402B6E1 RID: 177889
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020087A1 RID: 34721
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetMonsterMoveDirection_FunctionParams
	{
		// Token: 0x0402B6E2 RID: 177890
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B6E3 RID: 177891
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B6E4 RID: 177892
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x020087A2 RID: 34722
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetRoleBody_FunctionParams
	{
		// Token: 0x0402B6E5 RID: 177893
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B6E6 RID: 177894
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B6E7 RID: 177895
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x020087A3 RID: 34723
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetRacingRightSpeed_FunctionParams
	{
		// Token: 0x0402B6E8 RID: 177896
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B6E9 RID: 177897
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B6EA RID: 177898
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x020087A4 RID: 34724
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __SetPendulumData_FunctionParams
	{
		// Token: 0x0402B6EB RID: 177899
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B6EC RID: 177900
		[FieldOffset(4)]
		public float addVelocityX;

		// Token: 0x0402B6ED RID: 177901
		[FieldOffset(8)]
		public float addVelocityY;

		// Token: 0x0402B6EE RID: 177902
		[FieldOffset(12)]
		public float addVelocityZ;

		// Token: 0x0402B6EF RID: 177903
		[FieldOffset(16)]
		public float forwardLossPercentage;

		// Token: 0x0402B6F0 RID: 177904
		[FieldOffset(20)]
		public float lossPercentage;

		// Token: 0x0402B6F1 RID: 177905
		[FieldOffset(24)]
		public float gravity;

		// Token: 0x0402B6F2 RID: 177906
		[FieldOffset(28)]
		public float friction;

		// Token: 0x0402B6F3 RID: 177907
		[FieldOffset(32)]
		public float deceleration;

		// Token: 0x0402B6F4 RID: 177908
		[FieldOffset(36)]
		public float accelerator;

		// Token: 0x0402B6F5 RID: 177909
		[FieldOffset(40)]
		public float maxSpeed;

		// Token: 0x0402B6F6 RID: 177910
		[FieldOffset(44)]
		public float maxFallingSpeed;

		// Token: 0x0402B6F7 RID: 177911
		[FieldOffset(48)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020087A5 RID: 34725
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __Reset_FunctionParams
	{
		// Token: 0x0402B6F8 RID: 177912
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B6F9 RID: 177913
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020087A6 RID: 34726
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SetGrabPoint_FunctionParams
	{
		// Token: 0x0402B6FA RID: 177914
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B6FB RID: 177915
		[FieldOffset(8)]
		public FVectorDouble point;

		// Token: 0x0402B6FC RID: 177916
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020087A7 RID: 34727
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __GetGrabPoint_FunctionParams
	{
		// Token: 0x0402B6FD RID: 177917
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B6FE RID: 177918
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B6FF RID: 177919
		[FieldOffset(16)]
		public FVectorDouble __Result;
	}

	// Token: 0x020087A8 RID: 34728
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetHooked_FunctionParams
	{
		// Token: 0x0402B700 RID: 177920
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B701 RID: 177921
		[FieldOffset(4)]
		public bool isHooked;

		// Token: 0x0402B702 RID: 177922
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020087A9 RID: 34729
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetHooked_FunctionParams
	{
		// Token: 0x0402B703 RID: 177923
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B704 RID: 177924
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B705 RID: 177925
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020087AA RID: 34730
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __SetSocketName_FunctionParams
	{
		// Token: 0x0402B706 RID: 177926
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B707 RID: 177927
		[FieldOffset(8)]
		public FString socketName;

		// Token: 0x0402B708 RID: 177928
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020087AB RID: 34731
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetRopeForce_FunctionParams
	{
		// Token: 0x0402B709 RID: 177929
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B70A RID: 177930
		[FieldOffset(4)]
		public float ropeForce;

		// Token: 0x0402B70B RID: 177931
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020087AC RID: 34732
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetRopeForce_FunctionParams
	{
		// Token: 0x0402B70C RID: 177932
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B70D RID: 177933
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B70E RID: 177934
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x020087AD RID: 34733
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetDistanceRopeToActor_FunctionParams
	{
		// Token: 0x0402B70F RID: 177935
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B710 RID: 177936
		[FieldOffset(4)]
		public float ropeForce;

		// Token: 0x0402B711 RID: 177937
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020087AE RID: 34734
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetDistanceRopeToActor_FunctionParams
	{
		// Token: 0x0402B712 RID: 177938
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B713 RID: 177939
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B714 RID: 177940
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x020087AF RID: 34735
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetAirControl_FunctionParams
	{
		// Token: 0x0402B715 RID: 177941
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B716 RID: 177942
		[FieldOffset(4)]
		public float airControl;

		// Token: 0x0402B717 RID: 177943
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020087B0 RID: 34736
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetAirControl_FunctionParams
	{
		// Token: 0x0402B718 RID: 177944
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B719 RID: 177945
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B71A RID: 177946
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x020087B1 RID: 34737
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetUpLength_FunctionParams
	{
		// Token: 0x0402B71B RID: 177947
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B71C RID: 177948
		[FieldOffset(4)]
		public float length;

		// Token: 0x0402B71D RID: 177949
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020087B2 RID: 34738
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetCanMoveFromInput_FunctionParams
	{
		// Token: 0x0402B71E RID: 177950
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B71F RID: 177951
		[FieldOffset(4)]
		public bool canMove;

		// Token: 0x0402B720 RID: 177952
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020087B3 RID: 34739
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __UpdateAnimInfoMove_FunctionParams
	{
		// Token: 0x0402B721 RID: 177953
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B722 RID: 177954
		[FieldOffset(8)]
		public IntPtr animLogicParams;

		// Token: 0x0402B723 RID: 177955
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020087B4 RID: 34740
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __UpdateAnimInfoMoveMonster_FunctionParams
	{
		// Token: 0x0402B724 RID: 177956
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B725 RID: 177957
		[FieldOffset(8)]
		public IntPtr animLogicParams;

		// Token: 0x0402B726 RID: 177958
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020087B5 RID: 34741
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __UpdateAnimInfoMoveRoleNpc_FunctionParams
	{
		// Token: 0x0402B727 RID: 177959
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B728 RID: 177960
		[FieldOffset(8)]
		public IntPtr animLogicParams;

		// Token: 0x0402B729 RID: 177961
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020087B6 RID: 34742
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __TurnOnAutomaticFlightMode_FunctionParams
	{
		// Token: 0x0402B72A RID: 177962
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B72B RID: 177963
		[FieldOffset(8)]
		public IntPtr dataAsset;

		// Token: 0x0402B72C RID: 177964
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020087B7 RID: 34743
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __TurnOffAutomaticFlightMode_FunctionParams
	{
		// Token: 0x0402B72D RID: 177965
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B72E RID: 177966
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020087B8 RID: 34744
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __TurnOnCameraDrivenAutoFlightMode_FunctionParams
	{
		// Token: 0x0402B72F RID: 177967
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B730 RID: 177968
		[FieldOffset(8)]
		public IntPtr dataAsset;

		// Token: 0x0402B731 RID: 177969
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020087B9 RID: 34745
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __TurnOffCameraDrivenAutoFlightMode_FunctionParams
	{
		// Token: 0x0402B732 RID: 177970
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B733 RID: 177971
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020087BA RID: 34746
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 72)]
	protected ref struct __SimpleSwim_FunctionParams
	{
		// Token: 0x0402B734 RID: 177972
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B735 RID: 177973
		[FieldOffset(4)]
		public float deltaSeconds;

		// Token: 0x0402B736 RID: 177974
		[FieldOffset(8)]
		public float detectedHeight;

		// Token: 0x0402B737 RID: 177975
		[FieldOffset(16)]
		public FVectorDouble currentSpeed;

		// Token: 0x0402B738 RID: 177976
		[FieldOffset(40)]
		public IntPtr __WorldContext;

		// Token: 0x0402B739 RID: 177977
		[FieldOffset(48)]
		public FVectorDouble __Result;
	}

	// Token: 0x020087BB RID: 34747
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __EnterRoll_FunctionParams
	{
		// Token: 0x0402B73A RID: 177978
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B73B RID: 177979
		[FieldOffset(4)]
		public float targetSpeed;

		// Token: 0x0402B73C RID: 177980
		[FieldOffset(8)]
		public float friction;

		// Token: 0x0402B73D RID: 177981
		[FieldOffset(12)]
		public float accelOnGround;

		// Token: 0x0402B73E RID: 177982
		[FieldOffset(16)]
		public float gravity;

		// Token: 0x0402B73F RID: 177983
		[FieldOffset(20)]
		public float stepUpHeight;

		// Token: 0x0402B740 RID: 177984
		[FieldOffset(24)]
		public float maxSpeed;

		// Token: 0x0402B741 RID: 177985
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020087BC RID: 34748
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __LeaveRoll_FunctionParams
	{
		// Token: 0x0402B742 RID: 177986
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B743 RID: 177987
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020087BD RID: 34749
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __EnterKite_FunctionParams
	{
		// Token: 0x0402B744 RID: 177988
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B745 RID: 177989
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B746 RID: 177990
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020087BE RID: 34750
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __LerpVelocityBlend_FunctionParams
	{
		// Token: 0x0402B747 RID: 177991
		[FieldOffset(0)]
		public FVeloctiyBlend outVeloctiyBlend;

		// Token: 0x0402B748 RID: 177992
		[FieldOffset(16)]
		public FVeloctiyBlend to;

		// Token: 0x0402B749 RID: 177993
		[FieldOffset(32)]
		public float alpha;

		// Token: 0x0402B74A RID: 177994
		[FieldOffset(40)]
		public IntPtr __WorldContext;

		// Token: 0x0402B74B RID: 177995
		[FieldOffset(48)]
		public FVeloctiyBlend __Result;
	}

	// Token: 0x020087BF RID: 34751
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __MoveCharacter_FunctionParams
	{
		// Token: 0x0402B74C RID: 177996
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B74D RID: 177997
		[FieldOffset(8)]
		public FVectorDouble targetLocation;

		// Token: 0x0402B74E RID: 177998
		[FieldOffset(32)]
		public float speed;

		// Token: 0x0402B74F RID: 177999
		[FieldOffset(36)]
		public int arriveDist;

		// Token: 0x0402B750 RID: 178000
		[FieldOffset(40)]
		public IntPtr __WorldContext;

		// Token: 0x0402B751 RID: 178001
		[FieldOffset(48)]
		public bool __Result;
	}

	// Token: 0x020087C0 RID: 34752
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __StartAssistedWalk_FunctionParams
	{
		// Token: 0x0402B752 RID: 178002
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B753 RID: 178003
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020087C1 RID: 34753
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EnterAssistedWalkIdle_FunctionParams
	{
		// Token: 0x0402B754 RID: 178004
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B755 RID: 178005
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020087C2 RID: 34754
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EnterAssistedWalking_FunctionParams
	{
		// Token: 0x0402B756 RID: 178006
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B757 RID: 178007
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020087C3 RID: 34755
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __LeftAssistedWalking_FunctionParams
	{
		// Token: 0x0402B758 RID: 178008
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B759 RID: 178009
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020087C4 RID: 34756
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __LeftStartSwing_FunctionParams
	{
		// Token: 0x0402B75A RID: 178010
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B75B RID: 178011
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020087C5 RID: 34757
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __LeftLoopSwing_FunctionParams
	{
		// Token: 0x0402B75C RID: 178012
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B75D RID: 178013
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020087C6 RID: 34758
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __LeftEndSwing_FunctionParams
	{
		// Token: 0x0402B75E RID: 178014
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B75F RID: 178015
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020087C7 RID: 34759
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __ResetClimbConfig_FunctionParams
	{
		// Token: 0x0402B760 RID: 178016
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B761 RID: 178017
		[FieldOffset(8)]
		public FString key;

		// Token: 0x0402B762 RID: 178018
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020087C8 RID: 34760
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EnableGoThrough_FunctionParams
	{
		// Token: 0x0402B763 RID: 178019
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B764 RID: 178020
		[FieldOffset(4)]
		public int goThroughPriority;

		// Token: 0x0402B765 RID: 178021
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020087C9 RID: 34761
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __DisableGoThrough_FunctionParams
	{
		// Token: 0x0402B766 RID: 178022
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B767 RID: 178023
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020087CA RID: 34762
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __AnimTurnStart_FunctionParams
	{
		// Token: 0x0402B768 RID: 178024
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B769 RID: 178025
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020087CB RID: 34763
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __AnimTurnFinish_FunctionParams
	{
		// Token: 0x0402B76A RID: 178026
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B76B RID: 178027
		[FieldOffset(4)]
		public bool isGoingMove;

		// Token: 0x0402B76C RID: 178028
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}
}
