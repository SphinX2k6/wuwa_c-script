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

// Token: 0x02002E44 RID: 11844
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsMoveBlueprintFunctionLibrary.TsMoveBlueprintFunctionLibrary_C")]
public class TsMoveBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601933B RID: 103227 RVA: 0x0067C8DC File Offset: 0x0067AADC
	static TsMoveBlueprintFunctionLibrary()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsMoveBlueprintFunctionLibrary.CreateStaticDefaultValue), new Action(TsMoveBlueprintFunctionLibrary.ResetStaticDefaultValue));
	}

	// Token: 0x0601933C RID: 103228 RVA: 0x0067C960 File Offset: 0x0067AB60
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool SetActorRotationWithPriority(int entityId, FRotator value, bool sweep = false, string context = "unknown")
	{
		CharacterActorComponent component = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityId);
		return component != null && component.SetActorRotationWithPriority(value, "BlueprintAPI." + context, ESetRotationPriority.Movement, true, sweep);
	}

	// Token: 0x0601933D RID: 103229 RVA: 0x0067C994 File Offset: 0x0067AB94
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool SetActorLocationWithContext(int entityId, FVectorDouble location, bool sweep = false, string context = "unknown")
	{
		BaseActorComponent component = EntitySystem.Instance.GetComponent<BaseActorComponent>(entityId);
		return component != null && component.SetActorLocation(location, "BlueprintAPI." + context, sweep);
	}

	// Token: 0x0601933E RID: 103230 RVA: 0x0067C9C8 File Offset: 0x0067ABC8
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

	// Token: 0x0601933F RID: 103231 RVA: 0x0067CA04 File Offset: 0x0067AC04
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool SetActorRotationWithContext(int entityId, FRotator rotation, bool sweep, string context)
	{
		BaseActorComponent component = EntitySystem.Instance.GetComponent<BaseActorComponent>(entityId);
		return component != null && component.SetActorRotation(rotation, "BlueprintAPI." + context, sweep);
	}

	// Token: 0x06019340 RID: 103232 RVA: 0x0067CA38 File Offset: 0x0067AC38
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

	// Token: 0x06019341 RID: 103233 RVA: 0x0067CA68 File Offset: 0x0067AC68
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

	// Token: 0x06019342 RID: 103234 RVA: 0x0067CA98 File Offset: 0x0067AC98
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

	// Token: 0x06019343 RID: 103235 RVA: 0x0067CAC8 File Offset: 0x0067ACC8
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

	// Token: 0x06019344 RID: 103236 RVA: 0x0067CAF8 File Offset: 0x0067ACF8
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

	// Token: 0x06019345 RID: 103237 RVA: 0x0067CB28 File Offset: 0x0067AD28
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

	// Token: 0x06019346 RID: 103238 RVA: 0x0067CB5C File Offset: 0x0067AD5C
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

	// Token: 0x06019347 RID: 103239 RVA: 0x0067CBF8 File Offset: 0x0067ADF8
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

	// Token: 0x06019348 RID: 103240 RVA: 0x0067CC28 File Offset: 0x0067AE28
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

	// Token: 0x06019349 RID: 103241 RVA: 0x0067CC44 File Offset: 0x0067AE44
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetInputDirect(int entityId, FVectorDouble direct)
	{
		CharacterActorComponent component = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.SetInputDirect(global::Vector.Create(direct), false);
	}

	// Token: 0x0601934A RID: 103242 RVA: 0x0067CC6C File Offset: 0x0067AE6C
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

	// Token: 0x0601934B RID: 103243 RVA: 0x0067CC8D File Offset: 0x0067AE8D
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

	// Token: 0x0601934C RID: 103244 RVA: 0x0067CCAC File Offset: 0x0067AEAC
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

	// Token: 0x0601934D RID: 103245 RVA: 0x0067CD27 File Offset: 0x0067AF27
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

	// Token: 0x0601934E RID: 103246 RVA: 0x0067CD3F File Offset: 0x0067AF3F
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool CanResponseInput(int entityId)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		return component != null && component.CanResponseInput();
	}

	// Token: 0x0601934F RID: 103247 RVA: 0x0067CD57 File Offset: 0x0067AF57
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool CanJumpPress(int entityId)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		return component != null && component.CanJumpPress();
	}

	// Token: 0x06019350 RID: 103248 RVA: 0x0067CD6F File Offset: 0x0067AF6F
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool CanWalkPress(int entityId)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		return component != null && component.CanWalkPress();
	}

	// Token: 0x06019351 RID: 103249 RVA: 0x0067CD88 File Offset: 0x0067AF88
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

	// Token: 0x06019352 RID: 103250 RVA: 0x0067CDD7 File Offset: 0x0067AFD7
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

	// Token: 0x06019353 RID: 103251 RVA: 0x0067CDF8 File Offset: 0x0067AFF8
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

	// Token: 0x06019354 RID: 103252 RVA: 0x0067CE14 File Offset: 0x0067B014
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static SMovementSetting_State GetMovementData(int entityId)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		return ((component != null) ? component.MovementData : null) ?? new SMovementSetting_State();
	}

	// Token: 0x06019355 RID: 103253 RVA: 0x0067CE36 File Offset: 0x0067B036
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

	// Token: 0x06019356 RID: 103254 RVA: 0x0067CE61 File Offset: 0x0067B061
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool HasMoveInput(int entityId)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		return component != null && component.HasMoveInput;
	}

	// Token: 0x06019357 RID: 103255 RVA: 0x0067CE7C File Offset: 0x0067B07C
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

	// Token: 0x06019358 RID: 103256 RVA: 0x0067CED4 File Offset: 0x0067B0D4
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool HasRotatorInput(int entityId)
	{
		CharacterActorComponent component = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityId);
		return GravityUtils.Instance.GetAngleOffsetFromCurrentToInputAbs(component) > 10f;
	}

	// Token: 0x06019359 RID: 103257 RVA: 0x0067CEFF File Offset: 0x0067B0FF
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool IsMoving(int entityId)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		return component != null && component.IsMoving;
	}

	// Token: 0x0601935A RID: 103258 RVA: 0x0067CF17 File Offset: 0x0067B117
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool IsJump(int entityId)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		return component != null && component.IsJump;
	}

	// Token: 0x0601935B RID: 103259 RVA: 0x0067CF2F File Offset: 0x0067B12F
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

	// Token: 0x0601935C RID: 103260 RVA: 0x0067CF4B File Offset: 0x0067B14B
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

	// Token: 0x0601935D RID: 103261 RVA: 0x0067CF67 File Offset: 0x0067B167
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool IsFallingIntoWater(int entityId)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		return component != null && component.IsFallingIntoWater;
	}

	// Token: 0x0601935E RID: 103262 RVA: 0x0067CF80 File Offset: 0x0067B180
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

	// Token: 0x0601935F RID: 103263 RVA: 0x0067CFC4 File Offset: 0x0067B1C4
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

	// Token: 0x06019360 RID: 103264 RVA: 0x0067CFE0 File Offset: 0x0067B1E0
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

	// Token: 0x06019361 RID: 103265 RVA: 0x0067CFFC File Offset: 0x0067B1FC
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

	// Token: 0x06019362 RID: 103266 RVA: 0x0067D092 File Offset: 0x0067B292
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

	// Token: 0x06019363 RID: 103267 RVA: 0x0067D0A9 File Offset: 0x0067B2A9
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

	// Token: 0x06019364 RID: 103268 RVA: 0x0067D0C5 File Offset: 0x0067B2C5
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

	// Token: 0x06019365 RID: 103269 RVA: 0x0067D0DE File Offset: 0x0067B2DE
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

	// Token: 0x06019366 RID: 103270 RVA: 0x0067D0FB File Offset: 0x0067B2FB
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

	// Token: 0x06019367 RID: 103271 RVA: 0x0067D113 File Offset: 0x0067B313
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

	// Token: 0x06019368 RID: 103272 RVA: 0x0067D12C File Offset: 0x0067B32C
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

	// Token: 0x06019369 RID: 103273 RVA: 0x0067D157 File Offset: 0x0067B357
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

	// Token: 0x0601936A RID: 103274 RVA: 0x0067D174 File Offset: 0x0067B374
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

	// Token: 0x0601936B RID: 103275 RVA: 0x0067D19F File Offset: 0x0067B39F
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

	// Token: 0x0601936C RID: 103276 RVA: 0x0067D1B6 File Offset: 0x0067B3B6
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool CanClimbPress(int entityId)
	{
		CharacterClimbComponent component = EntitySystem.Instance.GetComponent<CharacterClimbComponent>(entityId);
		return component != null && component.CanClimbPress();
	}

	// Token: 0x0601936D RID: 103277 RVA: 0x0067D1CE File Offset: 0x0067B3CE
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

	// Token: 0x0601936E RID: 103278 RVA: 0x0067D1E5 File Offset: 0x0067B3E5
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

	// Token: 0x0601936F RID: 103279 RVA: 0x0067D1FC File Offset: 0x0067B3FC
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

	// Token: 0x06019370 RID: 103280 RVA: 0x0067D213 File Offset: 0x0067B413
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

	// Token: 0x06019371 RID: 103281 RVA: 0x0067D22A File Offset: 0x0067B42A
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

	// Token: 0x06019372 RID: 103282 RVA: 0x0067D241 File Offset: 0x0067B441
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

	// Token: 0x06019373 RID: 103283 RVA: 0x0067D259 File Offset: 0x0067B459
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

	// Token: 0x06019374 RID: 103284 RVA: 0x0067D271 File Offset: 0x0067B471
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

	// Token: 0x06019375 RID: 103285 RVA: 0x0067D289 File Offset: 0x0067B489
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

	// Token: 0x06019376 RID: 103286 RVA: 0x0067D2A5 File Offset: 0x0067B4A5
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

	// Token: 0x06019377 RID: 103287 RVA: 0x0067D2C1 File Offset: 0x0067B4C1
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetWaterVolume(int entityId)
	{
		CharacterSwimComponent component = EntitySystem.Instance.GetComponent<CharacterSwimComponent>(entityId);
		return component != null && component.GetWaterVolume();
	}

	// Token: 0x06019378 RID: 103288 RVA: 0x0067D2D9 File Offset: 0x0067B4D9
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

	// Token: 0x06019379 RID: 103289 RVA: 0x0067D2F5 File Offset: 0x0067B4F5
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

	// Token: 0x0601937A RID: 103290 RVA: 0x0067D30D File Offset: 0x0067B50D
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

	// Token: 0x0601937B RID: 103291 RVA: 0x0067D325 File Offset: 0x0067B525
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

	// Token: 0x0601937C RID: 103292 RVA: 0x0067D33D File Offset: 0x0067B53D
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetLockedRotation(int entityId)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		return component != null && component.LockedRotation;
	}

	// Token: 0x0601937D RID: 103293 RVA: 0x0067D355 File Offset: 0x0067B555
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

	// Token: 0x0601937E RID: 103294 RVA: 0x0067D36D File Offset: 0x0067B56D
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

	// Token: 0x0601937F RID: 103295 RVA: 0x0067D384 File Offset: 0x0067B584
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool DetectClimbWithDirect(int entityId, bool bSprintEnter, FVectorDouble direct)
	{
		CharacterClimbComponent component = EntitySystem.Instance.GetComponent<CharacterClimbComponent>(entityId);
		return component != null && component.DetectClimbWithDirect(bSprintEnter, direct, false);
	}

	// Token: 0x06019380 RID: 103296 RVA: 0x0067D3A0 File Offset: 0x0067B5A0
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

	// Token: 0x06019381 RID: 103297 RVA: 0x0067D46C File Offset: 0x0067B66C
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

	// Token: 0x06019382 RID: 103298 RVA: 0x0067D518 File Offset: 0x0067B718
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

	// Token: 0x06019383 RID: 103299 RVA: 0x0067D574 File Offset: 0x0067B774
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetRacingRightSpeed(int entityId)
	{
		CharacterSplineMoveComponent component = EntitySystem.Instance.GetComponent<CharacterSplineMoveComponent>(entityId);
		return (component != null) ? component.LastRightSpeed : 0f;
	}

	// Token: 0x06019384 RID: 103300 RVA: 0x0067D5A0 File Offset: 0x0067B7A0
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

	// Token: 0x06019385 RID: 103301 RVA: 0x0067D5F0 File Offset: 0x0067B7F0
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

	// Token: 0x06019386 RID: 103302 RVA: 0x0067D624 File Offset: 0x0067B824
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

	// Token: 0x06019387 RID: 103303 RVA: 0x0067D658 File Offset: 0x0067B858
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

	// Token: 0x06019388 RID: 103304 RVA: 0x0067D690 File Offset: 0x0067B890
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

	// Token: 0x06019389 RID: 103305 RVA: 0x0067D6C4 File Offset: 0x0067B8C4
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetHooked(int entityId)
	{
		CharacterPendulumComponent component = EntitySystem.Instance.GetComponent<CharacterPendulumComponent>(entityId);
		return component != null && component.Valid && component.Hooked;
	}

	// Token: 0x0601938A RID: 103306 RVA: 0x0067D6F8 File Offset: 0x0067B8F8
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

	// Token: 0x0601938B RID: 103307 RVA: 0x0067D72C File Offset: 0x0067B92C
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

	// Token: 0x0601938C RID: 103308 RVA: 0x0067D760 File Offset: 0x0067B960
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

	// Token: 0x0601938D RID: 103309 RVA: 0x0067D798 File Offset: 0x0067B998
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

	// Token: 0x0601938E RID: 103310 RVA: 0x0067D7CC File Offset: 0x0067B9CC
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

	// Token: 0x0601938F RID: 103311 RVA: 0x0067D804 File Offset: 0x0067BA04
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

	// Token: 0x06019390 RID: 103312 RVA: 0x0067D838 File Offset: 0x0067BA38
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

	// Token: 0x06019391 RID: 103313 RVA: 0x0067D870 File Offset: 0x0067BA70
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

	// Token: 0x06019392 RID: 103314 RVA: 0x0067D8A4 File Offset: 0x0067BAA4
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

	// Token: 0x06019393 RID: 103315 RVA: 0x0067D8D8 File Offset: 0x0067BAD8
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

	// Token: 0x06019394 RID: 103316 RVA: 0x0067DCB0 File Offset: 0x0067BEB0
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

	// Token: 0x06019395 RID: 103317 RVA: 0x0067DD98 File Offset: 0x0067BF98
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

	// Token: 0x06019396 RID: 103318 RVA: 0x0067DFB0 File Offset: 0x0067C1B0
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

	// Token: 0x06019397 RID: 103319 RVA: 0x0067DFDC File Offset: 0x0067C1DC
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void TurnOffAutomaticFlightMode(int entityId)
	{
		CharacterInputComponent component = EntitySystem.Instance.GetComponent<CharacterInputComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.TurnOffAutomaticFlightMode();
		}
	}

	// Token: 0x06019398 RID: 103320 RVA: 0x0067E008 File Offset: 0x0067C208
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

	// Token: 0x06019399 RID: 103321 RVA: 0x0067E034 File Offset: 0x0067C234
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void TurnOffCameraDrivenAutoFlightMode(int entityId)
	{
		CharacterInputComponent component = EntitySystem.Instance.GetComponent<CharacterInputComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.TurnOffCameraDrivenAutoFlightMode();
		}
	}

	// Token: 0x17002299 RID: 8857
	// (get) Token: 0x0601939A RID: 103322 RVA: 0x0067E060 File Offset: 0x0067C260
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

	// Token: 0x1700229A RID: 8858
	// (get) Token: 0x0601939B RID: 103323 RVA: 0x0067E0C0 File Offset: 0x0067C2C0
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

	// Token: 0x0601939C RID: 103324 RVA: 0x0067E120 File Offset: 0x0067C320
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

	// Token: 0x0601939D RID: 103325 RVA: 0x0067E4A4 File Offset: 0x0067C6A4
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

	// Token: 0x0601939E RID: 103326 RVA: 0x0067E4C4 File Offset: 0x0067C6C4
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

	// Token: 0x0601939F RID: 103327 RVA: 0x0067E4DC File Offset: 0x0067C6DC
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool EnterKite(int entityId)
	{
		CharacterKiteComponent component = EntitySystem.Instance.GetComponent<CharacterKiteComponent>(entityId);
		BaseSceneInteractComponent component2 = EntitySystem.Instance.GetComponent<BaseSceneInteractComponent>(entityId);
		return component != null && component.Valid && component2 != null && component2.Valid && component.EnterKite(component2.GetCurrentTarget());
	}

	// Token: 0x060193A0 RID: 103328 RVA: 0x0067E528 File Offset: 0x0067C728
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

	// Token: 0x060193A1 RID: 103329 RVA: 0x0067E614 File Offset: 0x0067C814
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

	// Token: 0x060193A2 RID: 103330 RVA: 0x0067E73C File Offset: 0x0067C93C
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

	// Token: 0x060193A3 RID: 103331 RVA: 0x0067E87D File Offset: 0x0067CA7D
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

	// Token: 0x060193A4 RID: 103332 RVA: 0x0067E899 File Offset: 0x0067CA99
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

	// Token: 0x060193A5 RID: 103333 RVA: 0x0067E8B5 File Offset: 0x0067CAB5
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

	// Token: 0x060193A6 RID: 103334 RVA: 0x0067E8D1 File Offset: 0x0067CAD1
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

	// Token: 0x060193A7 RID: 103335 RVA: 0x0067E8ED File Offset: 0x0067CAED
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

	// Token: 0x060193A8 RID: 103336 RVA: 0x0067E904 File Offset: 0x0067CB04
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

	// Token: 0x060193A9 RID: 103337 RVA: 0x0067E91B File Offset: 0x0067CB1B
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

	// Token: 0x060193AA RID: 103338 RVA: 0x0067E932 File Offset: 0x0067CB32
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

	// Token: 0x060193AB RID: 103339 RVA: 0x0067E94A File Offset: 0x0067CB4A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060193AC RID: 103340 RVA: 0x0067E94C File Offset: 0x0067CB4C
	public static void ResetStaticDefaultValue()
	{
		TsMoveBlueprintFunctionLibrary.WaterTraceInternal = null;
		TsMoveBlueprintFunctionLibrary.GroundTraceInternal = null;
	}

	// Token: 0x060193AD RID: 103341 RVA: 0x0067E95C File Offset: 0x0067CB5C
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

	// Token: 0x060193AE RID: 103342 RVA: 0x0067E9A0 File Offset: 0x0067CBA0
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

	// Token: 0x060193AF RID: 103343 RVA: 0x0067E9D7 File Offset: 0x0067CBD7
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsMoveBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsMoveBlueprintFunctionLibrary.TsMoveBlueprintFunctionLibrary_C");
		}
		return TsMoveBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x060193B0 RID: 103344 RVA: 0x0067E9FC File Offset: 0x0067CBFC
	public TsMoveBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(TsMoveBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060193B1 RID: 103345 RVA: 0x0067EA24 File Offset: 0x0067CC24
	[NullableContext(1)]
	public TsMoveBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsMoveBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060193B2 RID: 103346 RVA: 0x0067EA57 File Offset: 0x0067CC57
	protected TsMoveBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060193B3 RID: 103347 RVA: 0x0067EA60 File Offset: 0x0067CC60
	protected unsafe static void __CPPCALL_SetActorRotationWithPriority_Implementation(TsMoveBlueprintFunctionLibrary.__SetActorRotationWithPriority_FunctionParams* __Params)
	{
		string context = FString.ToString((void*)(&__Params->context));
		__Params->__Result = TsMoveBlueprintFunctionLibrary.SetActorRotationWithPriority(__Params->entityId, __Params->value, __Params->sweep, context);
	}

	// Token: 0x060193B4 RID: 103348 RVA: 0x0067EA98 File Offset: 0x0067CC98
	protected unsafe static void __CPPCALL_SetActorLocationWithContext_Implementation(TsMoveBlueprintFunctionLibrary.__SetActorLocationWithContext_FunctionParams* __Params)
	{
		string context = FString.ToString((void*)(&__Params->context));
		__Params->__Result = TsMoveBlueprintFunctionLibrary.SetActorLocationWithContext(__Params->entityId, __Params->location, __Params->sweep, context);
	}

	// Token: 0x060193B5 RID: 103349 RVA: 0x0067EAD0 File Offset: 0x0067CCD0
	protected unsafe static void __CPPCALL_SetActorLocationAndRotationWithContext_Implementation(TsMoveBlueprintFunctionLibrary.__SetActorLocationAndRotationWithContext_FunctionParams* __Params)
	{
		string context = FString.ToString((void*)(&__Params->context));
		TsMoveBlueprintFunctionLibrary.SetActorLocationAndRotationWithContext(__Params->entityId, __Params->location, __Params->rotation, __Params->sweep, context);
	}

	// Token: 0x060193B6 RID: 103350 RVA: 0x0067EB08 File Offset: 0x0067CD08
	protected unsafe static void __CPPCALL_SetActorRotationWithContext_Implementation(TsMoveBlueprintFunctionLibrary.__SetActorRotationWithContext_FunctionParams* __Params)
	{
		string context = FString.ToString((void*)(&__Params->context));
		__Params->__Result = TsMoveBlueprintFunctionLibrary.SetActorRotationWithContext(__Params->entityId, __Params->rotation, __Params->sweep, context);
	}

	// Token: 0x060193B7 RID: 103351 RVA: 0x0067EB40 File Offset: 0x0067CD40
	protected unsafe static void __CPPCALL_AddActorWorldOffsetWithContext_Implementation(TsMoveBlueprintFunctionLibrary.__AddActorWorldOffsetWithContext_FunctionParams* __Params)
	{
		string context = FString.ToString((void*)(&__Params->context));
		TsMoveBlueprintFunctionLibrary.AddActorWorldOffsetWithContext(__Params->entityId, __Params->offset, __Params->sweep, context);
	}

	// Token: 0x060193B8 RID: 103352 RVA: 0x0067EB74 File Offset: 0x0067CD74
	protected unsafe static void __CPPCALL_AddActorWorldOffsetWithContextAndReset_Implementation(TsMoveBlueprintFunctionLibrary.__AddActorWorldOffsetWithContextAndReset_FunctionParams* __Params)
	{
		string context = FString.ToString((void*)(&__Params->context));
		TsMoveBlueprintFunctionLibrary.AddActorWorldOffsetWithContextAndReset(__Params->entityId, __Params->offset, __Params->sweep, context);
	}

	// Token: 0x060193B9 RID: 103353 RVA: 0x0067EBA8 File Offset: 0x0067CDA8
	protected unsafe static void __CPPCALL_AddActorLocalOffsetWithContext_Implementation(TsMoveBlueprintFunctionLibrary.__AddActorLocalOffsetWithContext_FunctionParams* __Params)
	{
		string context = FString.ToString((void*)(&__Params->context));
		TsMoveBlueprintFunctionLibrary.AddActorLocalOffsetWithContext(__Params->entityId, __Params->offset, __Params->sweep, context);
	}

	// Token: 0x060193BA RID: 103354 RVA: 0x0067EBDC File Offset: 0x0067CDDC
	protected unsafe static void __CPPCALL_AddActorWorldRotationWithContext_Implementation(TsMoveBlueprintFunctionLibrary.__AddActorWorldRotationWithContext_FunctionParams* __Params)
	{
		string context = FString.ToString((void*)(&__Params->context));
		TsMoveBlueprintFunctionLibrary.AddActorWorldRotationWithContext(__Params->entityId, __Params->rotation, __Params->sweep, context);
	}

	// Token: 0x060193BB RID: 103355 RVA: 0x0067EC10 File Offset: 0x0067CE10
	protected unsafe static void __CPPCALL_AddActorLocalRotationWithContext_Implementation(TsMoveBlueprintFunctionLibrary.__AddActorLocalRotationWithContext_FunctionParams* __Params)
	{
		string context = FString.ToString((void*)(&__Params->context));
		TsMoveBlueprintFunctionLibrary.AddActorLocalRotationWithContext(__Params->entityId, __Params->rotation, __Params->sweep, context);
	}

	// Token: 0x060193BC RID: 103356 RVA: 0x0067EC44 File Offset: 0x0067CE44
	protected unsafe static void __CPPCALL_ActorTeleportToWithContext_Implementation(TsMoveBlueprintFunctionLibrary.__ActorTeleportToWithContext_FunctionParams* __Params)
	{
		string context = FString.ToString((void*)(&__Params->context));
		TsMoveBlueprintFunctionLibrary.ActorTeleportToWithContext(__Params->entityId, __Params->location, __Params->rotation, context);
	}

	// Token: 0x060193BD RID: 103357 RVA: 0x0067EC78 File Offset: 0x0067CE78
	protected unsafe static void __CPPCALL_SetActorLookAtWithContext_Implementation(TsMoveBlueprintFunctionLibrary.__SetActorLookAtWithContext_FunctionParams* __Params)
	{
		string context = FString.ToString((void*)(&__Params->context));
		__Params->__Result = TsMoveBlueprintFunctionLibrary.SetActorLookAtWithContext(__Params->entityId, __Params->targetPoint, context);
	}

	// Token: 0x060193BE RID: 103358 RVA: 0x0067ECAC File Offset: 0x0067CEAC
	protected unsafe static void __CPPCALL_ActorKuroMoveAlongFloorWithContext_Implementation(TsMoveBlueprintFunctionLibrary.__ActorKuroMoveAlongFloorWithContext_FunctionParams* __Params)
	{
		string context = FString.ToString((void*)(&__Params->context));
		TsMoveBlueprintFunctionLibrary.ActorKuroMoveAlongFloorWithContext(__Params->entityId, __Params->velocity, __Params->deltaSeconds, context);
	}

	// Token: 0x060193BF RID: 103359 RVA: 0x0067ECDE File Offset: 0x0067CEDE
	protected unsafe static void __CPPCALL_GetInputDirect_Implementation(TsMoveBlueprintFunctionLibrary.__GetInputDirect_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetInputDirect(__Params->entityId);
	}

	// Token: 0x060193C0 RID: 103360 RVA: 0x0067ECF1 File Offset: 0x0067CEF1
	protected unsafe static void __CPPCALL_SetInputDirect_Implementation(TsMoveBlueprintFunctionLibrary.__SetInputDirect_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.SetInputDirect(__Params->entityId, __Params->direct);
	}

	// Token: 0x060193C1 RID: 103361 RVA: 0x0067ED04 File Offset: 0x0067CF04
	protected unsafe static void __CPPCALL_GetInputRotator_Implementation(TsMoveBlueprintFunctionLibrary.__GetInputRotator_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetInputRotator(__Params->entityId);
	}

	// Token: 0x060193C2 RID: 103362 RVA: 0x0067ED17 File Offset: 0x0067CF17
	protected unsafe static void __CPPCALL_SetInputRotator_Implementation(TsMoveBlueprintFunctionLibrary.__SetInputRotator_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.SetInputRotator(__Params->entityId, __Params->rotator);
	}

	// Token: 0x060193C3 RID: 103363 RVA: 0x0067ED2C File Offset: 0x0067CF2C
	protected unsafe static void __CPPCALL_SetCharacterHidden_Implementation(TsMoveBlueprintFunctionLibrary.__SetCharacterHidden_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->callObject);
		string reason = FString.ToString((void*)(&__Params->reason));
		TsMoveBlueprintFunctionLibrary.SetCharacterHidden(__Params->entityId, __Params->isHidden, orCreateUObjectByNativePointer, reason);
	}

	// Token: 0x060193C4 RID: 103364 RVA: 0x0067ED65 File Offset: 0x0067CF65
	protected unsafe static void __CPPCALL_SetHiddenMovementMode_Implementation(TsMoveBlueprintFunctionLibrary.__SetHiddenMovementMode_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.SetHiddenMovementMode(__Params->entityId, __Params->isHidden);
	}

	// Token: 0x060193C5 RID: 103365 RVA: 0x0067ED78 File Offset: 0x0067CF78
	protected unsafe static void __CPPCALL_CanResponseInput_Implementation(TsMoveBlueprintFunctionLibrary.__CanResponseInput_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.CanResponseInput(__Params->entityId);
	}

	// Token: 0x060193C6 RID: 103366 RVA: 0x0067ED8B File Offset: 0x0067CF8B
	protected unsafe static void __CPPCALL_CanJumpPress_Implementation(TsMoveBlueprintFunctionLibrary.__CanJumpPress_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.CanJumpPress(__Params->entityId);
	}

	// Token: 0x060193C7 RID: 103367 RVA: 0x0067ED9E File Offset: 0x0067CF9E
	protected unsafe static void __CPPCALL_CanWalkPress_Implementation(TsMoveBlueprintFunctionLibrary.__CanWalkPress_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.CanWalkPress(__Params->entityId);
	}

	// Token: 0x060193C8 RID: 103368 RVA: 0x0067EDB1 File Offset: 0x0067CFB1
	protected unsafe static void __CPPCALL_GetHeightAboveGround_Implementation(TsMoveBlueprintFunctionLibrary.__GetHeightAboveGround_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetHeightAboveGround(__Params->entityId, __Params->detectedHeight);
	}

	// Token: 0x060193C9 RID: 103369 RVA: 0x0067EDCA File Offset: 0x0067CFCA
	protected unsafe static void __CPPCALL_GetAcceleration_Implementation(TsMoveBlueprintFunctionLibrary.__GetAcceleration_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetAcceleration(__Params->entityId);
	}

	// Token: 0x060193CA RID: 103370 RVA: 0x0067EDDD File Offset: 0x0067CFDD
	protected unsafe static void __CPPCALL_GetAimYawRate_Implementation(TsMoveBlueprintFunctionLibrary.__GetAimYawRate_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetAimYawRate(__Params->entityId);
	}

	// Token: 0x060193CB RID: 103371 RVA: 0x0067EDF0 File Offset: 0x0067CFF0
	protected unsafe static void __CPPCALL_GetMovementData_Implementation(TsMoveBlueprintFunctionLibrary.__GetMovementData_FunctionParams* __Params)
	{
		UScriptStructStackOnlyPtr nativeUStructPtr = SMovementSetting_State.StaticStruct();
		IntPtr dest = &__Params->__Result;
		SMovementSetting_State movementData = TsMoveBlueprintFunctionLibrary.GetMovementData(__Params->entityId);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (movementData != null) ? movementData.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x060193CC RID: 103372 RVA: 0x0067EE20 File Offset: 0x0067D020
	protected unsafe static void __CPPCALL_SmoothCharacterRotation_Implementation(TsMoveBlueprintFunctionLibrary.__SmoothCharacterRotation_FunctionParams* __Params)
	{
		string context = FString.ToString((void*)(&__Params->context));
		TsMoveBlueprintFunctionLibrary.SmoothCharacterRotation(__Params->entityId, __Params->target, __Params->speed, context);
	}

	// Token: 0x060193CD RID: 103373 RVA: 0x0067EE52 File Offset: 0x0067D052
	protected unsafe static void __CPPCALL_HasMoveInput_Implementation(TsMoveBlueprintFunctionLibrary.__HasMoveInput_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.HasMoveInput(__Params->entityId);
	}

	// Token: 0x060193CE RID: 103374 RVA: 0x0067EE65 File Offset: 0x0067D065
	protected unsafe static void __CPPCALL_HasMoveInputOrTickIntervalAndModelBuffer_Implementation(TsMoveBlueprintFunctionLibrary.__HasMoveInputOrTickIntervalAndModelBuffer_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.HasMoveInputOrTickIntervalAndModelBuffer(__Params->entityId);
	}

	// Token: 0x060193CF RID: 103375 RVA: 0x0067EE78 File Offset: 0x0067D078
	protected unsafe static void __CPPCALL_HasRotatorInput_Implementation(TsMoveBlueprintFunctionLibrary.__HasRotatorInput_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.HasRotatorInput(__Params->entityId);
	}

	// Token: 0x060193D0 RID: 103376 RVA: 0x0067EE8B File Offset: 0x0067D08B
	protected unsafe static void __CPPCALL_IsMoving_Implementation(TsMoveBlueprintFunctionLibrary.__IsMoving_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.IsMoving(__Params->entityId);
	}

	// Token: 0x060193D1 RID: 103377 RVA: 0x0067EE9E File Offset: 0x0067D09E
	protected unsafe static void __CPPCALL_IsJump_Implementation(TsMoveBlueprintFunctionLibrary.__IsJump_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.IsJump(__Params->entityId);
	}

	// Token: 0x060193D2 RID: 103378 RVA: 0x0067EEB1 File Offset: 0x0067D0B1
	protected unsafe static void __CPPCALL_GetSpeed_Implementation(TsMoveBlueprintFunctionLibrary.__GetSpeed_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetSpeed(__Params->entityId);
	}

	// Token: 0x060193D3 RID: 103379 RVA: 0x0067EEC4 File Offset: 0x0067D0C4
	protected unsafe static void __CPPCALL_GetGroundedTime_Implementation(TsMoveBlueprintFunctionLibrary.__GetGroundedTime_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetGroundedTime(__Params->entityId);
	}

	// Token: 0x060193D4 RID: 103380 RVA: 0x0067EED7 File Offset: 0x0067D0D7
	protected unsafe static void __CPPCALL_IsFallingIntoWater_Implementation(TsMoveBlueprintFunctionLibrary.__IsFallingIntoWater_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.IsFallingIntoWater(__Params->entityId);
	}

	// Token: 0x060193D5 RID: 103381 RVA: 0x0067EEEA File Offset: 0x0067D0EA
	protected unsafe static void __CPPCALL_SetForceSpeed_Implementation(TsMoveBlueprintFunctionLibrary.__SetForceSpeed_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.SetForceSpeed(__Params->entityId, __Params->speed);
	}

	// Token: 0x060193D6 RID: 103382 RVA: 0x0067EF00 File Offset: 0x0067D100
	protected unsafe static void __CPPCALL_SetAddMove_Implementation(TsMoveBlueprintFunctionLibrary.__SetAddMove_FunctionParams* __Params)
	{
		UMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMeshComponent>(__Params->mesh);
		UCurveFloat orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UCurveFloat>(__Params->curve);
		TsMoveBlueprintFunctionLibrary.SetAddMove(__Params->entityId, orCreateUObjectByNativePointer, __Params->speed, __Params->timeLength, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060193D7 RID: 103383 RVA: 0x0067EF40 File Offset: 0x0067D140
	protected unsafe static void __CPPCALL_StopAddMove_Implementation(TsMoveBlueprintFunctionLibrary.__StopAddMove_FunctionParams* __Params)
	{
		UMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMeshComponent>(__Params->mesh);
		TsMoveBlueprintFunctionLibrary.StopAddMove(__Params->entityId, orCreateUObjectByNativePointer);
	}

	// Token: 0x060193D8 RID: 103384 RVA: 0x0067EF65 File Offset: 0x0067D165
	protected unsafe static void __CPPCALL_FixActorLocation_Implementation(TsMoveBlueprintFunctionLibrary.__FixActorLocation_FunctionParams* __Params)
	{
		UScriptStructStackOnlyPtr nativeUStructPtr = FHitResult.StaticStruct();
		IntPtr dest = &__Params->__Result;
		FHitResult fhitResult = TsMoveBlueprintFunctionLibrary.FixActorLocation(__Params->entityId, __Params->target, __Params->offset);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (fhitResult != null) ? fhitResult.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x060193D9 RID: 103385 RVA: 0x0067EF9E File Offset: 0x0067D19E
	protected unsafe static void __CPPCALL_StopAllAddMove_Implementation(TsMoveBlueprintFunctionLibrary.__StopAllAddMove_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.StopAllAddMove(__Params->entityId);
	}

	// Token: 0x060193DA RID: 103386 RVA: 0x0067EFAC File Offset: 0x0067D1AC
	protected unsafe static void __CPPCALL_SetAddMoveWorld_Implementation(TsMoveBlueprintFunctionLibrary.__SetAddMoveWorld_FunctionParams* __Params)
	{
		UMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMeshComponent>(__Params->mesh);
		UCurveFloat orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UCurveFloat>(__Params->curve);
		TsMoveBlueprintFunctionLibrary.SetAddMoveWorld(__Params->entityId, orCreateUObjectByNativePointer, __Params->speed, __Params->timeLength, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060193DB RID: 103387 RVA: 0x0067EFEC File Offset: 0x0067D1EC
	protected unsafe static void __CPPCALL_SetAddMoveWorldSpeed_Implementation(TsMoveBlueprintFunctionLibrary.__SetAddMoveWorldSpeed_FunctionParams* __Params)
	{
		UMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMeshComponent>(__Params->mesh);
		TsMoveBlueprintFunctionLibrary.SetAddMoveWorldSpeed(__Params->entityId, orCreateUObjectByNativePointer, __Params->speed);
	}

	// Token: 0x060193DC RID: 103388 RVA: 0x0067F017 File Offset: 0x0067D217
	protected unsafe static void __CPPCALL_SetAddMoveOffset_Implementation(TsMoveBlueprintFunctionLibrary.__SetAddMoveOffset_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.SetAddMoveOffset(__Params->entityId, __Params->offset);
	}

	// Token: 0x060193DD RID: 103389 RVA: 0x0067F02A File Offset: 0x0067D22A
	protected unsafe static void __CPPCALL_SetAddMoveRotation_Implementation(TsMoveBlueprintFunctionLibrary.__SetAddMoveRotation_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.SetAddMoveRotation(__Params->entityId, __Params->rotation);
	}

	// Token: 0x060193DE RID: 103390 RVA: 0x0067F03D File Offset: 0x0067D23D
	protected unsafe static void __CPPCALL_SetEnterWaterState_Implementation(TsMoveBlueprintFunctionLibrary.__SetEnterWaterState_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.SetEnterWaterState(__Params->entityId, __Params->isEnter);
	}

	// Token: 0x060193DF RID: 103391 RVA: 0x0067F050 File Offset: 0x0067D250
	protected unsafe static void __CPPCALL_GetClimbState_Implementation(TsMoveBlueprintFunctionLibrary.__GetClimbState_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetClimbState(__Params->entityId);
	}

	// Token: 0x060193E0 RID: 103392 RVA: 0x0067F063 File Offset: 0x0067D263
	protected unsafe static void __CPPCALL_GetClimbRadius_Implementation(TsMoveBlueprintFunctionLibrary.__GetClimbRadius_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetClimbRadius(__Params->entityId);
	}

	// Token: 0x060193E1 RID: 103393 RVA: 0x0067F076 File Offset: 0x0067D276
	protected unsafe static void __CPPCALL_GetClimbInfo_Implementation(TsMoveBlueprintFunctionLibrary.__GetClimbInfo_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetClimbInfo(__Params->entityId);
	}

	// Token: 0x060193E2 RID: 103394 RVA: 0x0067F089 File Offset: 0x0067D289
	protected unsafe static void __CPPCALL_KickExitCheck_Implementation(TsMoveBlueprintFunctionLibrary.__KickExitCheck_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.KickExitCheck(__Params->entityId);
	}

	// Token: 0x060193E3 RID: 103395 RVA: 0x0067F096 File Offset: 0x0067D296
	protected unsafe static void __CPPCALL_CanClimbPress_Implementation(TsMoveBlueprintFunctionLibrary.__CanClimbPress_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.CanClimbPress(__Params->entityId);
	}

	// Token: 0x060193E4 RID: 103396 RVA: 0x0067F0A9 File Offset: 0x0067D2A9
	protected unsafe static void __CPPCALL_OnEnterClimb_Implementation(TsMoveBlueprintFunctionLibrary.__OnEnterClimb_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.OnEnterClimb(__Params->entityId);
	}

	// Token: 0x060193E5 RID: 103397 RVA: 0x0067F0B6 File Offset: 0x0067D2B6
	protected unsafe static void __CPPCALL_OnExitClimb_Implementation(TsMoveBlueprintFunctionLibrary.__OnExitClimb_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.OnExitClimb(__Params->entityId);
	}

	// Token: 0x060193E6 RID: 103398 RVA: 0x0067F0C3 File Offset: 0x0067D2C3
	protected unsafe static void __CPPCALL_DealClimbUpStart_Implementation(TsMoveBlueprintFunctionLibrary.__DealClimbUpStart_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.DealClimbUpStart(__Params->entityId);
	}

	// Token: 0x060193E7 RID: 103399 RVA: 0x0067F0D0 File Offset: 0x0067D2D0
	protected unsafe static void __CPPCALL_FinishClimbDown_Implementation(TsMoveBlueprintFunctionLibrary.__FinishClimbDown_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.FinishClimbDown(__Params->entityId);
	}

	// Token: 0x060193E8 RID: 103400 RVA: 0x0067F0DD File Offset: 0x0067D2DD
	protected unsafe static void __CPPCALL_DealClimbUpFinish_Implementation(TsMoveBlueprintFunctionLibrary.__DealClimbUpFinish_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.DealClimbUpFinish(__Params->entityId);
	}

	// Token: 0x060193E9 RID: 103401 RVA: 0x0067F0EC File Offset: 0x0067D2EC
	protected unsafe static void __CPPCALL_SetClimbState_Implementation(TsMoveBlueprintFunctionLibrary.__SetClimbState_FunctionParams* __Params)
	{
		EClimbState climbState = (EClimbState)__Params->climbState;
		TsMoveBlueprintFunctionLibrary.SetClimbState(__Params->entityId, climbState);
	}

	// Token: 0x060193EA RID: 103402 RVA: 0x0067F10C File Offset: 0x0067D30C
	protected unsafe static void __CPPCALL_SetEnterClimbType_Implementation(TsMoveBlueprintFunctionLibrary.__SetEnterClimbType_FunctionParams* __Params)
	{
		EEnterClimb enterType = (EEnterClimb)__Params->enterType;
		TsMoveBlueprintFunctionLibrary.SetEnterClimbType(__Params->entityId, enterType);
	}

	// Token: 0x060193EB RID: 103403 RVA: 0x0067F12C File Offset: 0x0067D32C
	protected unsafe static void __CPPCALL_SetExitClimbType_Implementation(TsMoveBlueprintFunctionLibrary.__SetExitClimbType_FunctionParams* __Params)
	{
		EExitClimb exitType = (EExitClimb)__Params->exitType;
		TsMoveBlueprintFunctionLibrary.SetExitClimbType(__Params->entityId, exitType);
	}

	// Token: 0x060193EC RID: 103404 RVA: 0x0067F14C File Offset: 0x0067D34C
	protected unsafe static void __CPPCALL_GetSwimLocation_Implementation(TsMoveBlueprintFunctionLibrary.__GetSwimLocation_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetSwimLocation(__Params->entityId);
	}

	// Token: 0x060193ED RID: 103405 RVA: 0x0067F15F File Offset: 0x0067D35F
	protected unsafe static void __CPPCALL_GetWaterLocation_Implementation(TsMoveBlueprintFunctionLibrary.__GetWaterLocation_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetWaterLocation(__Params->entityId);
	}

	// Token: 0x060193EE RID: 103406 RVA: 0x0067F172 File Offset: 0x0067D372
	protected unsafe static void __CPPCALL_GetWaterVolume_Implementation(TsMoveBlueprintFunctionLibrary.__GetWaterVolume_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetWaterVolume(__Params->entityId);
	}

	// Token: 0x060193EF RID: 103407 RVA: 0x0067F185 File Offset: 0x0067D385
	protected unsafe static void __CPPCALL_GetClimbOnWallAngle_Implementation(TsMoveBlueprintFunctionLibrary.__GetClimbOnWallAngle_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetClimbOnWallAngle(__Params->entityId);
	}

	// Token: 0x060193F0 RID: 103408 RVA: 0x0067F198 File Offset: 0x0067D398
	protected unsafe static void __CPPCALL_SetUseDebugMovementSetting_Implementation(TsMoveBlueprintFunctionLibrary.__SetUseDebugMovementSetting_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.SetUseDebugMovementSetting(__Params->entityId, __Params->newSelect);
	}

	// Token: 0x060193F1 RID: 103409 RVA: 0x0067F1AC File Offset: 0x0067D3AC
	protected unsafe static void __CPPCALL_SetDebugMovementSetting_Implementation(TsMoveBlueprintFunctionLibrary.__SetDebugMovementSetting_FunctionParams* __Params)
	{
		SMovementSetting newSetting = new SMovementSetting(&__Params->newSetting, true, true);
		TsMoveBlueprintFunctionLibrary.SetDebugMovementSetting(__Params->entityId, newSetting);
	}

	// Token: 0x060193F2 RID: 103410 RVA: 0x0067F1D4 File Offset: 0x0067D3D4
	protected unsafe static void __CPPCALL_SetLockedRotation_Implementation(TsMoveBlueprintFunctionLibrary.__SetLockedRotation_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.SetLockedRotation(__Params->entityId, __Params->lockedRotation);
	}

	// Token: 0x060193F3 RID: 103411 RVA: 0x0067F1E7 File Offset: 0x0067D3E7
	protected unsafe static void __CPPCALL_GetLockedRotation_Implementation(TsMoveBlueprintFunctionLibrary.__GetLockedRotation_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetLockedRotation(__Params->entityId);
	}

	// Token: 0x060193F4 RID: 103412 RVA: 0x0067F1FA File Offset: 0x0067D3FA
	protected unsafe static void __CPPCALL_SetFallingHorizontalMaxSpeed_Implementation(TsMoveBlueprintFunctionLibrary.__SetFallingHorizontalMaxSpeed_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.SetFallingHorizontalMaxSpeed(__Params->entityId, __Params->speed);
	}

	// Token: 0x060193F5 RID: 103413 RVA: 0x0067F20D File Offset: 0x0067D40D
	protected unsafe static void __CPPCALL_ClearFallingHorizontalMaxSpeed_Implementation(TsMoveBlueprintFunctionLibrary.__ClearFallingHorizontalMaxSpeed_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.ClearFallingHorizontalMaxSpeed(__Params->entityId);
	}

	// Token: 0x060193F6 RID: 103414 RVA: 0x0067F21A File Offset: 0x0067D41A
	protected unsafe static void __CPPCALL_DetectClimbWithDirect_Implementation(TsMoveBlueprintFunctionLibrary.__DetectClimbWithDirect_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.DetectClimbWithDirect(__Params->entityId, __Params->bSprintEnter, __Params->direct);
	}

	// Token: 0x060193F7 RID: 103415 RVA: 0x0067F23C File Offset: 0x0067D43C
	protected unsafe static void __CPPCALL_TurnToTarget_Implementation(TsMoveBlueprintFunctionLibrary.__TurnToTarget_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->target);
		TsMoveBlueprintFunctionLibrary.TurnToTarget(__Params->entityId, orCreateUObjectByNativePointer, __Params->speed);
	}

	// Token: 0x060193F8 RID: 103416 RVA: 0x0067F267 File Offset: 0x0067D467
	protected unsafe static void __CPPCALL_GetMonsterMoveDirection_Implementation(TsMoveBlueprintFunctionLibrary.__GetMonsterMoveDirection_FunctionParams* __Params)
	{
		*(&__Params->__Result) = (byte)TsMoveBlueprintFunctionLibrary.GetMonsterMoveDirection(__Params->entityId);
	}

	// Token: 0x060193F9 RID: 103417 RVA: 0x0067F27C File Offset: 0x0067D47C
	protected unsafe static void __CPPCALL_GetRoleBody_Implementation(TsMoveBlueprintFunctionLibrary.__GetRoleBody_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsMoveBlueprintFunctionLibrary.GetRoleBody(__Params->entityId));
	}

	// Token: 0x060193FA RID: 103418 RVA: 0x0067F295 File Offset: 0x0067D495
	protected unsafe static void __CPPCALL_GetRacingRightSpeed_Implementation(TsMoveBlueprintFunctionLibrary.__GetRacingRightSpeed_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetRacingRightSpeed(__Params->entityId);
	}

	// Token: 0x060193FB RID: 103419 RVA: 0x0067F2A8 File Offset: 0x0067D4A8
	protected unsafe static void __CPPCALL_SetPendulumData_Implementation(TsMoveBlueprintFunctionLibrary.__SetPendulumData_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.SetPendulumData(__Params->entityId, __Params->addVelocityX, __Params->addVelocityY, __Params->addVelocityZ, __Params->forwardLossPercentage, __Params->lossPercentage, __Params->gravity, __Params->friction, __Params->deceleration, __Params->accelerator, __Params->maxSpeed, __Params->maxFallingSpeed);
	}

	// Token: 0x060193FC RID: 103420 RVA: 0x0067F302 File Offset: 0x0067D502
	protected unsafe static void __CPPCALL_Reset_Implementation(TsMoveBlueprintFunctionLibrary.__Reset_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.Reset(__Params->entityId);
	}

	// Token: 0x060193FD RID: 103421 RVA: 0x0067F30F File Offset: 0x0067D50F
	protected unsafe static void __CPPCALL_SetGrabPoint_Implementation(TsMoveBlueprintFunctionLibrary.__SetGrabPoint_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.SetGrabPoint(__Params->entityId, __Params->point);
	}

	// Token: 0x060193FE RID: 103422 RVA: 0x0067F322 File Offset: 0x0067D522
	protected unsafe static void __CPPCALL_GetGrabPoint_Implementation(TsMoveBlueprintFunctionLibrary.__GetGrabPoint_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetGrabPoint(__Params->entityId);
	}

	// Token: 0x060193FF RID: 103423 RVA: 0x0067F335 File Offset: 0x0067D535
	protected unsafe static void __CPPCALL_SetHooked_Implementation(TsMoveBlueprintFunctionLibrary.__SetHooked_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.SetHooked(__Params->entityId, __Params->isHooked);
	}

	// Token: 0x06019400 RID: 103424 RVA: 0x0067F348 File Offset: 0x0067D548
	protected unsafe static void __CPPCALL_GetHooked_Implementation(TsMoveBlueprintFunctionLibrary.__GetHooked_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetHooked(__Params->entityId);
	}

	// Token: 0x06019401 RID: 103425 RVA: 0x0067F35C File Offset: 0x0067D55C
	protected unsafe static void __CPPCALL_SetSocketName_Implementation(TsMoveBlueprintFunctionLibrary.__SetSocketName_FunctionParams* __Params)
	{
		string socketName = FString.ToString((void*)(&__Params->socketName));
		TsMoveBlueprintFunctionLibrary.SetSocketName(__Params->entityId, socketName);
	}

	// Token: 0x06019402 RID: 103426 RVA: 0x0067F382 File Offset: 0x0067D582
	protected unsafe static void __CPPCALL_SetRopeForce_Implementation(TsMoveBlueprintFunctionLibrary.__SetRopeForce_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.SetRopeForce(__Params->entityId, __Params->ropeForce);
	}

	// Token: 0x06019403 RID: 103427 RVA: 0x0067F395 File Offset: 0x0067D595
	protected unsafe static void __CPPCALL_GetRopeForce_Implementation(TsMoveBlueprintFunctionLibrary.__GetRopeForce_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetRopeForce(__Params->entityId);
	}

	// Token: 0x06019404 RID: 103428 RVA: 0x0067F3A8 File Offset: 0x0067D5A8
	protected unsafe static void __CPPCALL_SetDistanceRopeToActor_Implementation(TsMoveBlueprintFunctionLibrary.__SetDistanceRopeToActor_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.SetDistanceRopeToActor(__Params->entityId, __Params->ropeForce);
	}

	// Token: 0x06019405 RID: 103429 RVA: 0x0067F3BB File Offset: 0x0067D5BB
	protected unsafe static void __CPPCALL_GetDistanceRopeToActor_Implementation(TsMoveBlueprintFunctionLibrary.__GetDistanceRopeToActor_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetDistanceRopeToActor(__Params->entityId);
	}

	// Token: 0x06019406 RID: 103430 RVA: 0x0067F3CE File Offset: 0x0067D5CE
	protected unsafe static void __CPPCALL_SetAirControl_Implementation(TsMoveBlueprintFunctionLibrary.__SetAirControl_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.SetAirControl(__Params->entityId, __Params->airControl);
	}

	// Token: 0x06019407 RID: 103431 RVA: 0x0067F3E1 File Offset: 0x0067D5E1
	protected unsafe static void __CPPCALL_GetAirControl_Implementation(TsMoveBlueprintFunctionLibrary.__GetAirControl_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.GetAirControl(__Params->entityId);
	}

	// Token: 0x06019408 RID: 103432 RVA: 0x0067F3F4 File Offset: 0x0067D5F4
	protected unsafe static void __CPPCALL_SetUpLength_Implementation(TsMoveBlueprintFunctionLibrary.__SetUpLength_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.SetUpLength(__Params->entityId, __Params->length);
	}

	// Token: 0x06019409 RID: 103433 RVA: 0x0067F407 File Offset: 0x0067D607
	protected unsafe static void __CPPCALL_SetCanMoveFromInput_Implementation(TsMoveBlueprintFunctionLibrary.__SetCanMoveFromInput_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.SetCanMoveFromInput(__Params->entityId, __Params->canMove);
	}

	// Token: 0x0601940A RID: 103434 RVA: 0x0067F41C File Offset: 0x0067D61C
	protected unsafe static void __CPPCALL_UpdateAnimInfoMove_Implementation(TsMoveBlueprintFunctionLibrary.__UpdateAnimInfoMove_FunctionParams* __Params)
	{
		BP_ABPLogicParams_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_ABPLogicParams_C>(__Params->animLogicParams);
		TsMoveBlueprintFunctionLibrary.UpdateAnimInfoMove(__Params->entityId, orCreateUObjectByNativePointer);
	}

	// Token: 0x0601940B RID: 103435 RVA: 0x0067F444 File Offset: 0x0067D644
	protected unsafe static void __CPPCALL_UpdateAnimInfoMoveMonster_Implementation(TsMoveBlueprintFunctionLibrary.__UpdateAnimInfoMoveMonster_FunctionParams* __Params)
	{
		BP_ABPLogicParams_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_ABPLogicParams_C>(__Params->animLogicParams);
		TsMoveBlueprintFunctionLibrary.UpdateAnimInfoMoveMonster(__Params->entityId, orCreateUObjectByNativePointer);
	}

	// Token: 0x0601940C RID: 103436 RVA: 0x0067F46C File Offset: 0x0067D66C
	protected unsafe static void __CPPCALL_UpdateAnimInfoMoveRoleNpc_Implementation(TsMoveBlueprintFunctionLibrary.__UpdateAnimInfoMoveRoleNpc_FunctionParams* __Params)
	{
		BP_ABPLogicParams_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_ABPLogicParams_C>(__Params->animLogicParams);
		TsMoveBlueprintFunctionLibrary.UpdateAnimInfoMoveRoleNpc(__Params->entityId, orCreateUObjectByNativePointer);
	}

	// Token: 0x0601940D RID: 103437 RVA: 0x0067F494 File Offset: 0x0067D694
	protected unsafe static void __CPPCALL_TurnOnAutomaticFlightMode_Implementation(TsMoveBlueprintFunctionLibrary.__TurnOnAutomaticFlightMode_FunctionParams* __Params)
	{
		ICM_AutomaticFlight_DataBase_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ICM_AutomaticFlight_DataBase_C>(__Params->dataAsset);
		TsMoveBlueprintFunctionLibrary.TurnOnAutomaticFlightMode(__Params->entityId, orCreateUObjectByNativePointer);
	}

	// Token: 0x0601940E RID: 103438 RVA: 0x0067F4B9 File Offset: 0x0067D6B9
	protected unsafe static void __CPPCALL_TurnOffAutomaticFlightMode_Implementation(TsMoveBlueprintFunctionLibrary.__TurnOffAutomaticFlightMode_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.TurnOffAutomaticFlightMode(__Params->entityId);
	}

	// Token: 0x0601940F RID: 103439 RVA: 0x0067F4C8 File Offset: 0x0067D6C8
	protected unsafe static void __CPPCALL_TurnOnCameraDrivenAutoFlightMode_Implementation(TsMoveBlueprintFunctionLibrary.__TurnOnCameraDrivenAutoFlightMode_FunctionParams* __Params)
	{
		BP_CameraDrivenAutoFlightData_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_CameraDrivenAutoFlightData_C>(__Params->dataAsset);
		TsMoveBlueprintFunctionLibrary.TurnOnCameraDrivenAutoFlightMode(__Params->entityId, orCreateUObjectByNativePointer);
	}

	// Token: 0x06019410 RID: 103440 RVA: 0x0067F4ED File Offset: 0x0067D6ED
	protected unsafe static void __CPPCALL_TurnOffCameraDrivenAutoFlightMode_Implementation(TsMoveBlueprintFunctionLibrary.__TurnOffCameraDrivenAutoFlightMode_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.TurnOffCameraDrivenAutoFlightMode(__Params->entityId);
	}

	// Token: 0x06019411 RID: 103441 RVA: 0x0067F4FA File Offset: 0x0067D6FA
	protected unsafe static void __CPPCALL_SimpleSwim_Implementation(TsMoveBlueprintFunctionLibrary.__SimpleSwim_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.SimpleSwim(__Params->entityId, __Params->deltaSeconds, __Params->detectedHeight, __Params->currentSpeed);
	}

	// Token: 0x06019412 RID: 103442 RVA: 0x0067F51F File Offset: 0x0067D71F
	protected unsafe static void __CPPCALL_EnterRoll_Implementation(TsMoveBlueprintFunctionLibrary.__EnterRoll_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.EnterRoll(__Params->entityId, __Params->targetSpeed, __Params->friction, __Params->accelOnGround, __Params->gravity, __Params->stepUpHeight, __Params->maxSpeed);
	}

	// Token: 0x06019413 RID: 103443 RVA: 0x0067F550 File Offset: 0x0067D750
	protected unsafe static void __CPPCALL_LeaveRoll_Implementation(TsMoveBlueprintFunctionLibrary.__LeaveRoll_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.LeaveRoll(__Params->entityId);
	}

	// Token: 0x06019414 RID: 103444 RVA: 0x0067F55D File Offset: 0x0067D75D
	protected unsafe static void __CPPCALL_EnterKite_Implementation(TsMoveBlueprintFunctionLibrary.__EnterKite_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.EnterKite(__Params->entityId);
	}

	// Token: 0x06019415 RID: 103445 RVA: 0x0067F570 File Offset: 0x0067D770
	protected unsafe static void __CPPCALL_LerpVelocityBlend_Implementation(TsMoveBlueprintFunctionLibrary.__LerpVelocityBlend_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.LerpVelocityBlend(__Params->outVeloctiyBlend, __Params->to, __Params->alpha);
	}

	// Token: 0x06019416 RID: 103446 RVA: 0x0067F58F File Offset: 0x0067D78F
	protected unsafe static void __CPPCALL_MoveCharacter_Implementation(TsMoveBlueprintFunctionLibrary.__MoveCharacter_FunctionParams* __Params)
	{
		__Params->__Result = TsMoveBlueprintFunctionLibrary.MoveCharacter(__Params->entityId, __Params->targetLocation, __Params->speed, __Params->arriveDist);
	}

	// Token: 0x06019417 RID: 103447 RVA: 0x0067F5B4 File Offset: 0x0067D7B4
	protected unsafe static void __CPPCALL_StartAssistedWalk_Implementation(TsMoveBlueprintFunctionLibrary.__StartAssistedWalk_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.StartAssistedWalk(__Params->entityId);
	}

	// Token: 0x06019418 RID: 103448 RVA: 0x0067F5C1 File Offset: 0x0067D7C1
	protected unsafe static void __CPPCALL_EnterAssistedWalkIdle_Implementation(TsMoveBlueprintFunctionLibrary.__EnterAssistedWalkIdle_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.EnterAssistedWalkIdle(__Params->entityId);
	}

	// Token: 0x06019419 RID: 103449 RVA: 0x0067F5CE File Offset: 0x0067D7CE
	protected unsafe static void __CPPCALL_EnterAssistedWalking_Implementation(TsMoveBlueprintFunctionLibrary.__EnterAssistedWalking_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.EnterAssistedWalking(__Params->entityId);
	}

	// Token: 0x0601941A RID: 103450 RVA: 0x0067F5DB File Offset: 0x0067D7DB
	protected unsafe static void __CPPCALL_LeftAssistedWalking_Implementation(TsMoveBlueprintFunctionLibrary.__LeftAssistedWalking_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.LeftAssistedWalking(__Params->entityId);
	}

	// Token: 0x0601941B RID: 103451 RVA: 0x0067F5E8 File Offset: 0x0067D7E8
	protected unsafe static void __CPPCALL_LeftStartSwing_Implementation(TsMoveBlueprintFunctionLibrary.__LeftStartSwing_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.LeftStartSwing(__Params->entityId);
	}

	// Token: 0x0601941C RID: 103452 RVA: 0x0067F5F5 File Offset: 0x0067D7F5
	protected unsafe static void __CPPCALL_LeftLoopSwing_Implementation(TsMoveBlueprintFunctionLibrary.__LeftLoopSwing_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.LeftLoopSwing(__Params->entityId);
	}

	// Token: 0x0601941D RID: 103453 RVA: 0x0067F602 File Offset: 0x0067D802
	protected unsafe static void __CPPCALL_LeftEndSwing_Implementation(TsMoveBlueprintFunctionLibrary.__LeftEndSwing_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.LeftEndSwing(__Params->entityId);
	}

	// Token: 0x0601941E RID: 103454 RVA: 0x0067F610 File Offset: 0x0067D810
	protected unsafe static void __CPPCALL_ResetClimbConfig_Implementation(TsMoveBlueprintFunctionLibrary.__ResetClimbConfig_FunctionParams* __Params)
	{
		string key = FString.ToString((void*)(&__Params->key));
		TsMoveBlueprintFunctionLibrary.ResetClimbConfig(__Params->entityId, key);
	}

	// Token: 0x0601941F RID: 103455 RVA: 0x0067F636 File Offset: 0x0067D836
	protected unsafe static void __CPPCALL_EnableGoThrough_Implementation(TsMoveBlueprintFunctionLibrary.__EnableGoThrough_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.EnableGoThrough(__Params->entityId, __Params->goThroughPriority);
	}

	// Token: 0x06019420 RID: 103456 RVA: 0x0067F649 File Offset: 0x0067D849
	protected unsafe static void __CPPCALL_DisableGoThrough_Implementation(TsMoveBlueprintFunctionLibrary.__DisableGoThrough_FunctionParams* __Params)
	{
		TsMoveBlueprintFunctionLibrary.DisableGoThrough(__Params->entityId);
	}

	// Token: 0x0400BBA4 RID: 48036
	private const int MIN_ROTATOR_ANGLE = 10;

	// Token: 0x0400BBA5 RID: 48037
	private const float MAX_SIMPLE_SWIM_DELTA = 0.15f;

	// Token: 0x0400BBA6 RID: 48038
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static global::Vector tmpVector = global::Vector.Create();

	// Token: 0x0400BBA7 RID: 48039
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static global::Vector tmpVector2 = global::Vector.Create();

	// Token: 0x0400BBA8 RID: 48040
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static Quat tmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400BBA9 RID: 48041
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static global::Rotator tmpRotator = global::Rotator.Create();

	// Token: 0x0400BBAA RID: 48042
	[Nullable(2)]
	private static UTraceLineElement WaterTraceInternal = null;

	// Token: 0x0400BBAB RID: 48043
	[Nullable(2)]
	private static UTraceLineElement GroundTraceInternal = null;

	// Token: 0x0400BBAC RID: 48044
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsMoveBlueprintFunctionLibrary.TsMoveBlueprintFunctionLibrary_C";

	// Token: 0x0400BBAD RID: 48045
	private static IntPtr _ClassPtr;

	// Token: 0x0400BBAE RID: 48046
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x02009534 RID: 38196
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __SetActorRotationWithPriority_FunctionParams
	{
		// Token: 0x0402FF60 RID: 196448
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF61 RID: 196449
		[FieldOffset(4)]
		public FRotator value;

		// Token: 0x0402FF62 RID: 196450
		[FieldOffset(16)]
		public bool sweep;

		// Token: 0x0402FF63 RID: 196451
		[FieldOffset(24)]
		public FString context;

		// Token: 0x0402FF64 RID: 196452
		[FieldOffset(40)]
		public IntPtr __WorldContext;

		// Token: 0x0402FF65 RID: 196453
		[FieldOffset(48)]
		public bool __Result;
	}

	// Token: 0x02009535 RID: 38197
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 72)]
	protected ref struct __SetActorLocationWithContext_FunctionParams
	{
		// Token: 0x0402FF66 RID: 196454
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF67 RID: 196455
		[FieldOffset(8)]
		public FVectorDouble location;

		// Token: 0x0402FF68 RID: 196456
		[FieldOffset(32)]
		public bool sweep;

		// Token: 0x0402FF69 RID: 196457
		[FieldOffset(40)]
		public FString context;

		// Token: 0x0402FF6A RID: 196458
		[FieldOffset(56)]
		public IntPtr __WorldContext;

		// Token: 0x0402FF6B RID: 196459
		[FieldOffset(64)]
		public bool __Result;
	}

	// Token: 0x02009536 RID: 38198
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 72)]
	protected ref struct __SetActorLocationAndRotationWithContext_FunctionParams
	{
		// Token: 0x0402FF6C RID: 196460
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF6D RID: 196461
		[FieldOffset(8)]
		public FVectorDouble location;

		// Token: 0x0402FF6E RID: 196462
		[FieldOffset(32)]
		public FRotator rotation;

		// Token: 0x0402FF6F RID: 196463
		[FieldOffset(44)]
		public bool sweep;

		// Token: 0x0402FF70 RID: 196464
		[FieldOffset(48)]
		public FString context;

		// Token: 0x0402FF71 RID: 196465
		[FieldOffset(64)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009537 RID: 38199
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __SetActorRotationWithContext_FunctionParams
	{
		// Token: 0x0402FF72 RID: 196466
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF73 RID: 196467
		[FieldOffset(4)]
		public FRotator rotation;

		// Token: 0x0402FF74 RID: 196468
		[FieldOffset(16)]
		public bool sweep;

		// Token: 0x0402FF75 RID: 196469
		[FieldOffset(24)]
		public FString context;

		// Token: 0x0402FF76 RID: 196470
		[FieldOffset(40)]
		public IntPtr __WorldContext;

		// Token: 0x0402FF77 RID: 196471
		[FieldOffset(48)]
		public bool __Result;
	}

	// Token: 0x02009538 RID: 38200
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __AddActorWorldOffsetWithContext_FunctionParams
	{
		// Token: 0x0402FF78 RID: 196472
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF79 RID: 196473
		[FieldOffset(8)]
		public FVectorDouble offset;

		// Token: 0x0402FF7A RID: 196474
		[FieldOffset(32)]
		public bool sweep;

		// Token: 0x0402FF7B RID: 196475
		[FieldOffset(40)]
		public FString context;

		// Token: 0x0402FF7C RID: 196476
		[FieldOffset(56)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009539 RID: 38201
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __AddActorWorldOffsetWithContextAndReset_FunctionParams
	{
		// Token: 0x0402FF7D RID: 196477
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF7E RID: 196478
		[FieldOffset(8)]
		public FVectorDouble offset;

		// Token: 0x0402FF7F RID: 196479
		[FieldOffset(32)]
		public bool sweep;

		// Token: 0x0402FF80 RID: 196480
		[FieldOffset(40)]
		public FString context;

		// Token: 0x0402FF81 RID: 196481
		[FieldOffset(56)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200953A RID: 38202
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __AddActorLocalOffsetWithContext_FunctionParams
	{
		// Token: 0x0402FF82 RID: 196482
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF83 RID: 196483
		[FieldOffset(8)]
		public FVectorDouble offset;

		// Token: 0x0402FF84 RID: 196484
		[FieldOffset(32)]
		public bool sweep;

		// Token: 0x0402FF85 RID: 196485
		[FieldOffset(40)]
		public FString context;

		// Token: 0x0402FF86 RID: 196486
		[FieldOffset(56)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200953B RID: 38203
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __AddActorWorldRotationWithContext_FunctionParams
	{
		// Token: 0x0402FF87 RID: 196487
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF88 RID: 196488
		[FieldOffset(4)]
		public FRotator rotation;

		// Token: 0x0402FF89 RID: 196489
		[FieldOffset(16)]
		public bool sweep;

		// Token: 0x0402FF8A RID: 196490
		[FieldOffset(24)]
		public FString context;

		// Token: 0x0402FF8B RID: 196491
		[FieldOffset(40)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200953C RID: 38204
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __AddActorLocalRotationWithContext_FunctionParams
	{
		// Token: 0x0402FF8C RID: 196492
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF8D RID: 196493
		[FieldOffset(4)]
		public FRotator rotation;

		// Token: 0x0402FF8E RID: 196494
		[FieldOffset(16)]
		public bool sweep;

		// Token: 0x0402FF8F RID: 196495
		[FieldOffset(24)]
		public FString context;

		// Token: 0x0402FF90 RID: 196496
		[FieldOffset(40)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200953D RID: 38205
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 72)]
	protected ref struct __ActorTeleportToWithContext_FunctionParams
	{
		// Token: 0x0402FF91 RID: 196497
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF92 RID: 196498
		[FieldOffset(8)]
		public FVectorDouble location;

		// Token: 0x0402FF93 RID: 196499
		[FieldOffset(32)]
		public FRotator rotation;

		// Token: 0x0402FF94 RID: 196500
		[FieldOffset(48)]
		public FString context;

		// Token: 0x0402FF95 RID: 196501
		[FieldOffset(64)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200953E RID: 38206
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __SetActorLookAtWithContext_FunctionParams
	{
		// Token: 0x0402FF96 RID: 196502
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF97 RID: 196503
		[FieldOffset(8)]
		public FVectorDouble targetPoint;

		// Token: 0x0402FF98 RID: 196504
		[FieldOffset(32)]
		public FString context;

		// Token: 0x0402FF99 RID: 196505
		[FieldOffset(48)]
		public IntPtr __WorldContext;

		// Token: 0x0402FF9A RID: 196506
		[FieldOffset(56)]
		public bool __Result;
	}

	// Token: 0x0200953F RID: 38207
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __ActorKuroMoveAlongFloorWithContext_FunctionParams
	{
		// Token: 0x0402FF9B RID: 196507
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FF9C RID: 196508
		[FieldOffset(4)]
		public FVector velocity;

		// Token: 0x0402FF9D RID: 196509
		[FieldOffset(16)]
		public float deltaSeconds;

		// Token: 0x0402FF9E RID: 196510
		[FieldOffset(24)]
		public FString context;

		// Token: 0x0402FF9F RID: 196511
		[FieldOffset(40)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009540 RID: 38208
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __GetInputDirect_FunctionParams
	{
		// Token: 0x0402FFA0 RID: 196512
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FFA1 RID: 196513
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FFA2 RID: 196514
		[FieldOffset(16)]
		public FVectorDouble __Result;
	}

	// Token: 0x02009541 RID: 38209
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SetInputDirect_FunctionParams
	{
		// Token: 0x0402FFA3 RID: 196515
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FFA4 RID: 196516
		[FieldOffset(8)]
		public FVectorDouble direct;

		// Token: 0x0402FFA5 RID: 196517
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009542 RID: 38210
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetInputRotator_FunctionParams
	{
		// Token: 0x0402FFA6 RID: 196518
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FFA7 RID: 196519
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FFA8 RID: 196520
		[FieldOffset(16)]
		public FRotator __Result;
	}

	// Token: 0x02009543 RID: 38211
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetInputRotator_FunctionParams
	{
		// Token: 0x0402FFA9 RID: 196521
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FFAA RID: 196522
		[FieldOffset(4)]
		public FRotator rotator;

		// Token: 0x0402FFAB RID: 196523
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009544 RID: 38212
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SetCharacterHidden_FunctionParams
	{
		// Token: 0x0402FFAC RID: 196524
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FFAD RID: 196525
		[FieldOffset(4)]
		public bool isHidden;

		// Token: 0x0402FFAE RID: 196526
		[FieldOffset(8)]
		public IntPtr callObject;

		// Token: 0x0402FFAF RID: 196527
		[FieldOffset(16)]
		public FString reason;

		// Token: 0x0402FFB0 RID: 196528
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009545 RID: 38213
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetHiddenMovementMode_FunctionParams
	{
		// Token: 0x0402FFB1 RID: 196529
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FFB2 RID: 196530
		[FieldOffset(4)]
		public bool isHidden;

		// Token: 0x0402FFB3 RID: 196531
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009546 RID: 38214
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __CanResponseInput_FunctionParams
	{
		// Token: 0x0402FFB4 RID: 196532
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FFB5 RID: 196533
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FFB6 RID: 196534
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009547 RID: 38215
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __CanJumpPress_FunctionParams
	{
		// Token: 0x0402FFB7 RID: 196535
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FFB8 RID: 196536
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FFB9 RID: 196537
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009548 RID: 38216
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __CanWalkPress_FunctionParams
	{
		// Token: 0x0402FFBA RID: 196538
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FFBB RID: 196539
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FFBC RID: 196540
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009549 RID: 38217
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetHeightAboveGround_FunctionParams
	{
		// Token: 0x0402FFBD RID: 196541
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FFBE RID: 196542
		[FieldOffset(4)]
		public float detectedHeight;

		// Token: 0x0402FFBF RID: 196543
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FFC0 RID: 196544
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x0200954A RID: 38218
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetAcceleration_FunctionParams
	{
		// Token: 0x0402FFC1 RID: 196545
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FFC2 RID: 196546
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FFC3 RID: 196547
		[FieldOffset(16)]
		public FVector __Result;
	}

	// Token: 0x0200954B RID: 38219
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetAimYawRate_FunctionParams
	{
		// Token: 0x0402FFC4 RID: 196548
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FFC5 RID: 196549
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FFC6 RID: 196550
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x0200954C RID: 38220
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1768)]
	protected ref struct __GetMovementData_FunctionParams
	{
		// Token: 0x0402FFC7 RID: 196551
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FFC8 RID: 196552
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FFC9 RID: 196553
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x0200954D RID: 38221
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __SmoothCharacterRotation_FunctionParams
	{
		// Token: 0x0402FFCA RID: 196554
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FFCB RID: 196555
		[FieldOffset(4)]
		public FRotator target;

		// Token: 0x0402FFCC RID: 196556
		[FieldOffset(16)]
		public float speed;

		// Token: 0x0402FFCD RID: 196557
		[FieldOffset(24)]
		public FString context;

		// Token: 0x0402FFCE RID: 196558
		[FieldOffset(40)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200954E RID: 38222
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __HasMoveInput_FunctionParams
	{
		// Token: 0x0402FFCF RID: 196559
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FFD0 RID: 196560
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FFD1 RID: 196561
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200954F RID: 38223
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __HasMoveInputOrTickIntervalAndModelBuffer_FunctionParams
	{
		// Token: 0x0402FFD2 RID: 196562
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FFD3 RID: 196563
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FFD4 RID: 196564
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009550 RID: 38224
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __HasRotatorInput_FunctionParams
	{
		// Token: 0x0402FFD5 RID: 196565
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FFD6 RID: 196566
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FFD7 RID: 196567
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009551 RID: 38225
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __IsMoving_FunctionParams
	{
		// Token: 0x0402FFD8 RID: 196568
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FFD9 RID: 196569
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FFDA RID: 196570
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009552 RID: 38226
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __IsJump_FunctionParams
	{
		// Token: 0x0402FFDB RID: 196571
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FFDC RID: 196572
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FFDD RID: 196573
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009553 RID: 38227
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetSpeed_FunctionParams
	{
		// Token: 0x0402FFDE RID: 196574
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FFDF RID: 196575
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FFE0 RID: 196576
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02009554 RID: 38228
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetGroundedTime_FunctionParams
	{
		// Token: 0x0402FFE1 RID: 196577
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FFE2 RID: 196578
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FFE3 RID: 196579
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02009555 RID: 38229
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __IsFallingIntoWater_FunctionParams
	{
		// Token: 0x0402FFE4 RID: 196580
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FFE5 RID: 196581
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FFE6 RID: 196582
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009556 RID: 38230
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SetForceSpeed_FunctionParams
	{
		// Token: 0x0402FFE7 RID: 196583
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FFE8 RID: 196584
		[FieldOffset(8)]
		public FVectorDouble speed;

		// Token: 0x0402FFE9 RID: 196585
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009557 RID: 38231
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __SetAddMove_FunctionParams
	{
		// Token: 0x0402FFEA RID: 196586
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FFEB RID: 196587
		[FieldOffset(8)]
		public IntPtr mesh;

		// Token: 0x0402FFEC RID: 196588
		[FieldOffset(16)]
		public FVectorDouble speed;

		// Token: 0x0402FFED RID: 196589
		[FieldOffset(40)]
		public float timeLength;

		// Token: 0x0402FFEE RID: 196590
		[FieldOffset(48)]
		public IntPtr curve;

		// Token: 0x0402FFEF RID: 196591
		[FieldOffset(56)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009558 RID: 38232
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __StopAddMove_FunctionParams
	{
		// Token: 0x0402FFF0 RID: 196592
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FFF1 RID: 196593
		[FieldOffset(8)]
		public IntPtr mesh;

		// Token: 0x0402FFF2 RID: 196594
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009559 RID: 38233
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 200)]
	protected ref struct __FixActorLocation_FunctionParams
	{
		// Token: 0x0402FFF3 RID: 196595
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FFF4 RID: 196596
		[FieldOffset(8)]
		public FVectorDouble target;

		// Token: 0x0402FFF5 RID: 196597
		[FieldOffset(32)]
		public float offset;

		// Token: 0x0402FFF6 RID: 196598
		[FieldOffset(40)]
		public IntPtr __WorldContext;

		// Token: 0x0402FFF7 RID: 196599
		[FieldOffset(48)]
		public byte __Result;
	}

	// Token: 0x0200955A RID: 38234
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __StopAllAddMove_FunctionParams
	{
		// Token: 0x0402FFF8 RID: 196600
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FFF9 RID: 196601
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200955B RID: 38235
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __SetAddMoveWorld_FunctionParams
	{
		// Token: 0x0402FFFA RID: 196602
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FFFB RID: 196603
		[FieldOffset(8)]
		public IntPtr mesh;

		// Token: 0x0402FFFC RID: 196604
		[FieldOffset(16)]
		public FVectorDouble speed;

		// Token: 0x0402FFFD RID: 196605
		[FieldOffset(40)]
		public float timeLength;

		// Token: 0x0402FFFE RID: 196606
		[FieldOffset(48)]
		public IntPtr curve;

		// Token: 0x0402FFFF RID: 196607
		[FieldOffset(56)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200955C RID: 38236
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __SetAddMoveWorldSpeed_FunctionParams
	{
		// Token: 0x04030000 RID: 196608
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030001 RID: 196609
		[FieldOffset(8)]
		public IntPtr mesh;

		// Token: 0x04030002 RID: 196610
		[FieldOffset(16)]
		public FVectorDouble speed;

		// Token: 0x04030003 RID: 196611
		[FieldOffset(40)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200955D RID: 38237
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SetAddMoveOffset_FunctionParams
	{
		// Token: 0x04030004 RID: 196612
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030005 RID: 196613
		[FieldOffset(8)]
		public FVectorDouble offset;

		// Token: 0x04030006 RID: 196614
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200955E RID: 38238
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetAddMoveRotation_FunctionParams
	{
		// Token: 0x04030007 RID: 196615
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030008 RID: 196616
		[FieldOffset(4)]
		public FRotator rotation;

		// Token: 0x04030009 RID: 196617
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200955F RID: 38239
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetEnterWaterState_FunctionParams
	{
		// Token: 0x0403000A RID: 196618
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0403000B RID: 196619
		[FieldOffset(4)]
		public bool isEnter;

		// Token: 0x0403000C RID: 196620
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009560 RID: 38240
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetClimbState_FunctionParams
	{
		// Token: 0x0403000D RID: 196621
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0403000E RID: 196622
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0403000F RID: 196623
		[FieldOffset(16)]
		public AkiClient.Game.Aki.Character.BaseCharacter.SClimbState __Result;
	}

	// Token: 0x02009561 RID: 38241
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetClimbRadius_FunctionParams
	{
		// Token: 0x04030010 RID: 196624
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030011 RID: 196625
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x04030012 RID: 196626
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02009562 RID: 38242
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __GetClimbInfo_FunctionParams
	{
		// Token: 0x04030013 RID: 196627
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030014 RID: 196628
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x04030015 RID: 196629
		[FieldOffset(16)]
		public AkiClient.Game.Aki.Character.BaseCharacter.SClimbInfo __Result;
	}

	// Token: 0x02009563 RID: 38243
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __KickExitCheck_FunctionParams
	{
		// Token: 0x04030016 RID: 196630
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030017 RID: 196631
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009564 RID: 38244
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __CanClimbPress_FunctionParams
	{
		// Token: 0x04030018 RID: 196632
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030019 RID: 196633
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0403001A RID: 196634
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009565 RID: 38245
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __OnEnterClimb_FunctionParams
	{
		// Token: 0x0403001B RID: 196635
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0403001C RID: 196636
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009566 RID: 38246
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __OnExitClimb_FunctionParams
	{
		// Token: 0x0403001D RID: 196637
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0403001E RID: 196638
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009567 RID: 38247
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __DealClimbUpStart_FunctionParams
	{
		// Token: 0x0403001F RID: 196639
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030020 RID: 196640
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009568 RID: 38248
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __FinishClimbDown_FunctionParams
	{
		// Token: 0x04030021 RID: 196641
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030022 RID: 196642
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009569 RID: 38249
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __DealClimbUpFinish_FunctionParams
	{
		// Token: 0x04030023 RID: 196643
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030024 RID: 196644
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200956A RID: 38250
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetClimbState_FunctionParams
	{
		// Token: 0x04030025 RID: 196645
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030026 RID: 196646
		[FieldOffset(4)]
		public byte climbState;

		// Token: 0x04030027 RID: 196647
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200956B RID: 38251
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetEnterClimbType_FunctionParams
	{
		// Token: 0x04030028 RID: 196648
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030029 RID: 196649
		[FieldOffset(4)]
		public byte enterType;

		// Token: 0x0403002A RID: 196650
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200956C RID: 38252
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetExitClimbType_FunctionParams
	{
		// Token: 0x0403002B RID: 196651
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0403002C RID: 196652
		[FieldOffset(4)]
		public byte exitType;

		// Token: 0x0403002D RID: 196653
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200956D RID: 38253
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __GetSwimLocation_FunctionParams
	{
		// Token: 0x0403002E RID: 196654
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0403002F RID: 196655
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x04030030 RID: 196656
		[FieldOffset(16)]
		public FVectorDouble __Result;
	}

	// Token: 0x0200956E RID: 38254
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __GetWaterLocation_FunctionParams
	{
		// Token: 0x04030031 RID: 196657
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030032 RID: 196658
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x04030033 RID: 196659
		[FieldOffset(16)]
		public FVectorDouble __Result;
	}

	// Token: 0x0200956F RID: 38255
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetWaterVolume_FunctionParams
	{
		// Token: 0x04030034 RID: 196660
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030035 RID: 196661
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x04030036 RID: 196662
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009570 RID: 38256
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetClimbOnWallAngle_FunctionParams
	{
		// Token: 0x04030037 RID: 196663
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030038 RID: 196664
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x04030039 RID: 196665
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02009571 RID: 38257
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetUseDebugMovementSetting_FunctionParams
	{
		// Token: 0x0403003A RID: 196666
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0403003B RID: 196667
		[FieldOffset(4)]
		public bool newSelect;

		// Token: 0x0403003C RID: 196668
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009572 RID: 38258
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 112)]
	protected ref struct __SetDebugMovementSetting_FunctionParams
	{
		// Token: 0x0403003D RID: 196669
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0403003E RID: 196670
		[FieldOffset(8)]
		public byte newSetting;

		// Token: 0x0403003F RID: 196671
		[FieldOffset(104)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009573 RID: 38259
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetLockedRotation_FunctionParams
	{
		// Token: 0x04030040 RID: 196672
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030041 RID: 196673
		[FieldOffset(4)]
		public bool lockedRotation;

		// Token: 0x04030042 RID: 196674
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009574 RID: 38260
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetLockedRotation_FunctionParams
	{
		// Token: 0x04030043 RID: 196675
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030044 RID: 196676
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x04030045 RID: 196677
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009575 RID: 38261
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetFallingHorizontalMaxSpeed_FunctionParams
	{
		// Token: 0x04030046 RID: 196678
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030047 RID: 196679
		[FieldOffset(4)]
		public float speed;

		// Token: 0x04030048 RID: 196680
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009576 RID: 38262
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ClearFallingHorizontalMaxSpeed_FunctionParams
	{
		// Token: 0x04030049 RID: 196681
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0403004A RID: 196682
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009577 RID: 38263
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __DetectClimbWithDirect_FunctionParams
	{
		// Token: 0x0403004B RID: 196683
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0403004C RID: 196684
		[FieldOffset(4)]
		public bool bSprintEnter;

		// Token: 0x0403004D RID: 196685
		[FieldOffset(8)]
		public FVectorDouble direct;

		// Token: 0x0403004E RID: 196686
		[FieldOffset(32)]
		public IntPtr __WorldContext;

		// Token: 0x0403004F RID: 196687
		[FieldOffset(40)]
		public bool __Result;
	}

	// Token: 0x02009578 RID: 38264
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __TurnToTarget_FunctionParams
	{
		// Token: 0x04030050 RID: 196688
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030051 RID: 196689
		[FieldOffset(8)]
		public IntPtr target;

		// Token: 0x04030052 RID: 196690
		[FieldOffset(16)]
		public float speed;

		// Token: 0x04030053 RID: 196691
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009579 RID: 38265
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetMonsterMoveDirection_FunctionParams
	{
		// Token: 0x04030054 RID: 196692
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030055 RID: 196693
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x04030056 RID: 196694
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x0200957A RID: 38266
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetRoleBody_FunctionParams
	{
		// Token: 0x04030057 RID: 196695
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030058 RID: 196696
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x04030059 RID: 196697
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x0200957B RID: 38267
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetRacingRightSpeed_FunctionParams
	{
		// Token: 0x0403005A RID: 196698
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0403005B RID: 196699
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0403005C RID: 196700
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x0200957C RID: 38268
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __SetPendulumData_FunctionParams
	{
		// Token: 0x0403005D RID: 196701
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0403005E RID: 196702
		[FieldOffset(4)]
		public float addVelocityX;

		// Token: 0x0403005F RID: 196703
		[FieldOffset(8)]
		public float addVelocityY;

		// Token: 0x04030060 RID: 196704
		[FieldOffset(12)]
		public float addVelocityZ;

		// Token: 0x04030061 RID: 196705
		[FieldOffset(16)]
		public float forwardLossPercentage;

		// Token: 0x04030062 RID: 196706
		[FieldOffset(20)]
		public float lossPercentage;

		// Token: 0x04030063 RID: 196707
		[FieldOffset(24)]
		public float gravity;

		// Token: 0x04030064 RID: 196708
		[FieldOffset(28)]
		public float friction;

		// Token: 0x04030065 RID: 196709
		[FieldOffset(32)]
		public float deceleration;

		// Token: 0x04030066 RID: 196710
		[FieldOffset(36)]
		public float accelerator;

		// Token: 0x04030067 RID: 196711
		[FieldOffset(40)]
		public float maxSpeed;

		// Token: 0x04030068 RID: 196712
		[FieldOffset(44)]
		public float maxFallingSpeed;

		// Token: 0x04030069 RID: 196713
		[FieldOffset(48)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200957D RID: 38269
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __Reset_FunctionParams
	{
		// Token: 0x0403006A RID: 196714
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0403006B RID: 196715
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200957E RID: 38270
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SetGrabPoint_FunctionParams
	{
		// Token: 0x0403006C RID: 196716
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0403006D RID: 196717
		[FieldOffset(8)]
		public FVectorDouble point;

		// Token: 0x0403006E RID: 196718
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200957F RID: 38271
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __GetGrabPoint_FunctionParams
	{
		// Token: 0x0403006F RID: 196719
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030070 RID: 196720
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x04030071 RID: 196721
		[FieldOffset(16)]
		public FVectorDouble __Result;
	}

	// Token: 0x02009580 RID: 38272
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetHooked_FunctionParams
	{
		// Token: 0x04030072 RID: 196722
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030073 RID: 196723
		[FieldOffset(4)]
		public bool isHooked;

		// Token: 0x04030074 RID: 196724
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009581 RID: 38273
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetHooked_FunctionParams
	{
		// Token: 0x04030075 RID: 196725
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030076 RID: 196726
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x04030077 RID: 196727
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009582 RID: 38274
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __SetSocketName_FunctionParams
	{
		// Token: 0x04030078 RID: 196728
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030079 RID: 196729
		[FieldOffset(8)]
		public FString socketName;

		// Token: 0x0403007A RID: 196730
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009583 RID: 38275
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetRopeForce_FunctionParams
	{
		// Token: 0x0403007B RID: 196731
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0403007C RID: 196732
		[FieldOffset(4)]
		public float ropeForce;

		// Token: 0x0403007D RID: 196733
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009584 RID: 38276
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetRopeForce_FunctionParams
	{
		// Token: 0x0403007E RID: 196734
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0403007F RID: 196735
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x04030080 RID: 196736
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02009585 RID: 38277
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetDistanceRopeToActor_FunctionParams
	{
		// Token: 0x04030081 RID: 196737
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030082 RID: 196738
		[FieldOffset(4)]
		public float ropeForce;

		// Token: 0x04030083 RID: 196739
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009586 RID: 38278
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetDistanceRopeToActor_FunctionParams
	{
		// Token: 0x04030084 RID: 196740
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030085 RID: 196741
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x04030086 RID: 196742
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02009587 RID: 38279
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetAirControl_FunctionParams
	{
		// Token: 0x04030087 RID: 196743
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030088 RID: 196744
		[FieldOffset(4)]
		public float airControl;

		// Token: 0x04030089 RID: 196745
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009588 RID: 38280
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetAirControl_FunctionParams
	{
		// Token: 0x0403008A RID: 196746
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0403008B RID: 196747
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0403008C RID: 196748
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02009589 RID: 38281
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetUpLength_FunctionParams
	{
		// Token: 0x0403008D RID: 196749
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0403008E RID: 196750
		[FieldOffset(4)]
		public float length;

		// Token: 0x0403008F RID: 196751
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200958A RID: 38282
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetCanMoveFromInput_FunctionParams
	{
		// Token: 0x04030090 RID: 196752
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030091 RID: 196753
		[FieldOffset(4)]
		public bool canMove;

		// Token: 0x04030092 RID: 196754
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200958B RID: 38283
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __UpdateAnimInfoMove_FunctionParams
	{
		// Token: 0x04030093 RID: 196755
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030094 RID: 196756
		[FieldOffset(8)]
		public IntPtr animLogicParams;

		// Token: 0x04030095 RID: 196757
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200958C RID: 38284
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __UpdateAnimInfoMoveMonster_FunctionParams
	{
		// Token: 0x04030096 RID: 196758
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030097 RID: 196759
		[FieldOffset(8)]
		public IntPtr animLogicParams;

		// Token: 0x04030098 RID: 196760
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200958D RID: 38285
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __UpdateAnimInfoMoveRoleNpc_FunctionParams
	{
		// Token: 0x04030099 RID: 196761
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0403009A RID: 196762
		[FieldOffset(8)]
		public IntPtr animLogicParams;

		// Token: 0x0403009B RID: 196763
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200958E RID: 38286
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __TurnOnAutomaticFlightMode_FunctionParams
	{
		// Token: 0x0403009C RID: 196764
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0403009D RID: 196765
		[FieldOffset(8)]
		public IntPtr dataAsset;

		// Token: 0x0403009E RID: 196766
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200958F RID: 38287
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __TurnOffAutomaticFlightMode_FunctionParams
	{
		// Token: 0x0403009F RID: 196767
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040300A0 RID: 196768
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009590 RID: 38288
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __TurnOnCameraDrivenAutoFlightMode_FunctionParams
	{
		// Token: 0x040300A1 RID: 196769
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040300A2 RID: 196770
		[FieldOffset(8)]
		public IntPtr dataAsset;

		// Token: 0x040300A3 RID: 196771
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009591 RID: 38289
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __TurnOffCameraDrivenAutoFlightMode_FunctionParams
	{
		// Token: 0x040300A4 RID: 196772
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040300A5 RID: 196773
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009592 RID: 38290
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 72)]
	protected ref struct __SimpleSwim_FunctionParams
	{
		// Token: 0x040300A6 RID: 196774
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040300A7 RID: 196775
		[FieldOffset(4)]
		public float deltaSeconds;

		// Token: 0x040300A8 RID: 196776
		[FieldOffset(8)]
		public float detectedHeight;

		// Token: 0x040300A9 RID: 196777
		[FieldOffset(16)]
		public FVectorDouble currentSpeed;

		// Token: 0x040300AA RID: 196778
		[FieldOffset(40)]
		public IntPtr __WorldContext;

		// Token: 0x040300AB RID: 196779
		[FieldOffset(48)]
		public FVectorDouble __Result;
	}

	// Token: 0x02009593 RID: 38291
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __EnterRoll_FunctionParams
	{
		// Token: 0x040300AC RID: 196780
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040300AD RID: 196781
		[FieldOffset(4)]
		public float targetSpeed;

		// Token: 0x040300AE RID: 196782
		[FieldOffset(8)]
		public float friction;

		// Token: 0x040300AF RID: 196783
		[FieldOffset(12)]
		public float accelOnGround;

		// Token: 0x040300B0 RID: 196784
		[FieldOffset(16)]
		public float gravity;

		// Token: 0x040300B1 RID: 196785
		[FieldOffset(20)]
		public float stepUpHeight;

		// Token: 0x040300B2 RID: 196786
		[FieldOffset(24)]
		public float maxSpeed;

		// Token: 0x040300B3 RID: 196787
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009594 RID: 38292
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __LeaveRoll_FunctionParams
	{
		// Token: 0x040300B4 RID: 196788
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040300B5 RID: 196789
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009595 RID: 38293
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __EnterKite_FunctionParams
	{
		// Token: 0x040300B6 RID: 196790
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040300B7 RID: 196791
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x040300B8 RID: 196792
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009596 RID: 38294
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __LerpVelocityBlend_FunctionParams
	{
		// Token: 0x040300B9 RID: 196793
		[FieldOffset(0)]
		public FVeloctiyBlend outVeloctiyBlend;

		// Token: 0x040300BA RID: 196794
		[FieldOffset(16)]
		public FVeloctiyBlend to;

		// Token: 0x040300BB RID: 196795
		[FieldOffset(32)]
		public float alpha;

		// Token: 0x040300BC RID: 196796
		[FieldOffset(40)]
		public IntPtr __WorldContext;

		// Token: 0x040300BD RID: 196797
		[FieldOffset(48)]
		public FVeloctiyBlend __Result;
	}

	// Token: 0x02009597 RID: 38295
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __MoveCharacter_FunctionParams
	{
		// Token: 0x040300BE RID: 196798
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040300BF RID: 196799
		[FieldOffset(8)]
		public FVectorDouble targetLocation;

		// Token: 0x040300C0 RID: 196800
		[FieldOffset(32)]
		public float speed;

		// Token: 0x040300C1 RID: 196801
		[FieldOffset(36)]
		public int arriveDist;

		// Token: 0x040300C2 RID: 196802
		[FieldOffset(40)]
		public IntPtr __WorldContext;

		// Token: 0x040300C3 RID: 196803
		[FieldOffset(48)]
		public bool __Result;
	}

	// Token: 0x02009598 RID: 38296
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __StartAssistedWalk_FunctionParams
	{
		// Token: 0x040300C4 RID: 196804
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040300C5 RID: 196805
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009599 RID: 38297
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EnterAssistedWalkIdle_FunctionParams
	{
		// Token: 0x040300C6 RID: 196806
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040300C7 RID: 196807
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200959A RID: 38298
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EnterAssistedWalking_FunctionParams
	{
		// Token: 0x040300C8 RID: 196808
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040300C9 RID: 196809
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200959B RID: 38299
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __LeftAssistedWalking_FunctionParams
	{
		// Token: 0x040300CA RID: 196810
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040300CB RID: 196811
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200959C RID: 38300
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __LeftStartSwing_FunctionParams
	{
		// Token: 0x040300CC RID: 196812
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040300CD RID: 196813
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200959D RID: 38301
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __LeftLoopSwing_FunctionParams
	{
		// Token: 0x040300CE RID: 196814
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040300CF RID: 196815
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200959E RID: 38302
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __LeftEndSwing_FunctionParams
	{
		// Token: 0x040300D0 RID: 196816
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040300D1 RID: 196817
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200959F RID: 38303
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __ResetClimbConfig_FunctionParams
	{
		// Token: 0x040300D2 RID: 196818
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040300D3 RID: 196819
		[FieldOffset(8)]
		public FString key;

		// Token: 0x040300D4 RID: 196820
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020095A0 RID: 38304
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EnableGoThrough_FunctionParams
	{
		// Token: 0x040300D5 RID: 196821
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040300D6 RID: 196822
		[FieldOffset(4)]
		public int goThroughPriority;

		// Token: 0x040300D7 RID: 196823
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020095A1 RID: 38305
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __DisableGoThrough_FunctionParams
	{
		// Token: 0x040300D8 RID: 196824
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040300D9 RID: 196825
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}
}
