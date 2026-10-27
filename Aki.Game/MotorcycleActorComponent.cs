using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Render;
using UnrealEngine;

// Token: 0x020032F6 RID: 13046
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleActorComponent : VehicleActorComponent
{
	// Token: 0x17002747 RID: 10055
	// (get) Token: 0x0601C641 RID: 116289 RVA: 0x007F323D File Offset: 0x007F143D
	public Vector AirRotateInputProxy
	{
		get
		{
			return this.AirRotateInputInternal;
		}
	}

	// Token: 0x0601C642 RID: 116290 RVA: 0x007F3245 File Offset: 0x007F1445
	public void SetAirRotateInput(IVector v)
	{
		this.AirRotateInputInternal.DeepCopy(v);
	}

	// Token: 0x0601C643 RID: 116291 RVA: 0x007F3254 File Offset: 0x007F1454
	public unsafe override bool SetActorLocation(FVectorDouble value, string context = "unknown", bool sweep = false)
	{
		if (!sweep)
		{
			return base.SetActorLocation(value, context, sweep);
		}
		if (!MathUtils.Instance.IsValidVector(value, 100000000))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "SetActorLocation的value无效";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("value", value);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item = "CreatureDataId";
			CreatureDataComponent creatureData = base.CreatureData;
			ptr = new ValueTuple<string, object>(item, (creatureData != null) ? new long?(creatureData.GetCreatureDataId()) : null);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		bool result = false;
		AActor actorInternal = this.ActorInternal;
		if (actorInternal != null && actorInternal.IsValid())
		{
			VehicleActorComponent.TmpVector.FromUeVector(value);
			VehicleActorComponent.TmpVector.SubtractionEqual(this.ActorLocationProxy);
			this.CachedDesiredActorLocation.FromUeVector(value);
			this.IsChangingLocation = true;
			this.VehicleMoveComp.VehicleMovement.MoveMotorcycle(VehicleActorComponent.TmpVector.ToUeVectorOld(), Quat.Identity, sweep);
			this.IsChangingLocation = false;
			base.CheckIsForbidSettingLocAndRot(true, false, true);
			if (this.DebugMovementComp != null)
			{
				this.DebugMovementComp.MarkDebugRecord(context + ".SetActorLocation", new EKDMRecordType?(EKDMRecordType.KDM_LOCATION), false);
			}
		}
		base.ResetLocationCachedTime();
		this.OnTeleport();
		return result;
	}

	// Token: 0x0601C644 RID: 116292 RVA: 0x007F33B0 File Offset: 0x007F15B0
	public unsafe override bool SetActorLocationNoTeleport(FVectorDouble value, string context = "unknown", bool sweep = false)
	{
		if (!sweep)
		{
			base.SetActorLocationNoTeleport(value, context, sweep);
		}
		if (!MathUtils.Instance.IsValidVector(value, 100000000))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "SetActorLocation的value无效";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("value", value);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item = "CreatureDataId";
			CreatureDataComponent creatureData = base.CreatureData;
			ptr = new ValueTuple<string, object>(item, (creatureData != null) ? new long?(creatureData.GetCreatureDataId()) : null);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		bool result = false;
		AActor actorInternal = this.ActorInternal;
		if (actorInternal != null && actorInternal.IsValid())
		{
			VehicleActorComponent.TmpVector.FromUeVector(value);
			VehicleActorComponent.TmpVector.SubtractionEqual(this.ActorLocationProxy);
			this.CachedDesiredActorLocation.FromUeVector(value);
			this.IsChangingLocation = true;
			this.VehicleMoveComp.VehicleMovement.MoveMotorcycle(VehicleActorComponent.TmpVector.ToUeVectorOld(), Quat.Identity, sweep);
			this.IsChangingLocation = false;
			base.CheckIsForbidSettingLocAndRot(true, false, true);
			if (this.DebugMovementComp != null)
			{
				this.DebugMovementComp.MarkDebugRecord(context + ".SetActorLocation", new EKDMRecordType?(EKDMRecordType.KDM_LOCATION), false);
			}
		}
		base.ResetLocationCachedTime();
		return result;
	}

	// Token: 0x0601C645 RID: 116293 RVA: 0x007F3504 File Offset: 0x007F1704
	public override bool SetActorRotation(FRotator value, string context, bool sweep = false)
	{
		if (!sweep)
		{
			return base.SetActorRotation(value, context, sweep);
		}
		bool result = false;
		if (!MathUtils.Instance.IsValidRotator(value, 100000000))
		{
			Log.Instance.Error(ELogModule.Entity, ELogAuthor.MZJ, "SetActorRotation NaN", default(ReadOnlySpan<ValueTuple<string, object>>));
			return result;
		}
		MotorcycleActorComponent.TmpRotator.FromUeRotator(value);
		MotorcycleActorComponent.TmpRotator.Quaternion(VehicleActorComponent.TmpQuat);
		base.ActorQuatProxy.Inverse(MotorcycleActorComponent.TmpQuat2);
		VehicleActorComponent.TmpQuat.Multiply(MotorcycleActorComponent.TmpQuat2, MotorcycleActorComponent.TmpQuat3);
		this.VehicleMoveComp.VehicleMovement.MoveMotorcycle(Vector.ZeroVector, MotorcycleActorComponent.TmpQuat3.ToUeQuat(), sweep);
		base.ResetRotationCachedTime();
		if (this.DebugMovementComp != null)
		{
			this.DebugMovementComp.MarkDebugRecord(context + ".SetActorRotation", new EKDMRecordType?(EKDMRecordType.KDM_LOCATION), false);
		}
		return result;
	}

	// Token: 0x0601C646 RID: 116294 RVA: 0x007F35E4 File Offset: 0x007F17E4
	public override bool SetActorLocationAndRotation(FVectorDouble location, FRotator rotation, string context, bool sweep = false, ESetRotationPriority? priority = null)
	{
		if (!sweep)
		{
			return base.SetActorLocationAndRotation(location, rotation, context, sweep, priority);
		}
		bool result = false;
		if (!MathUtils.Instance.IsValidVector(location, 100000000) || !MathUtils.Instance.IsValidRotator(rotation, 100000000))
		{
			Log.Instance.Error(ELogModule.Entity, ELogAuthor.MZJ, "SetActorLocationAndRotation NaN", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		VehicleActorComponent.TmpVector.FromUeVector(location);
		VehicleActorComponent.TmpVector.SubtractionEqual(this.ActorLocationProxy);
		MotorcycleActorComponent.TmpRotator.FromUeRotator(rotation);
		MotorcycleActorComponent.TmpRotator.Quaternion(VehicleActorComponent.TmpQuat);
		base.ActorQuatProxy.Inverse(MotorcycleActorComponent.TmpQuat2);
		if (priority != null)
		{
			FunctionRequestWithPriority<ESetRotationPriority> functionRequestWithPriority = new FunctionRequestWithPriority<ESetRotationPriority>();
			functionRequestWithPriority.ModuleName = context;
			functionRequestWithPriority.Priority = priority.Value;
			if (!this.SetRotationRequestProxy.DecideCall(functionRequestWithPriority))
			{
				VehicleActorComponent.TmpQuat.DeepCopy(Quat.IdentityProxy);
			}
		}
		VehicleActorComponent.TmpQuat.Multiply(MotorcycleActorComponent.TmpQuat2, MotorcycleActorComponent.TmpQuat3);
		this.VehicleMoveComp.VehicleMovement.MoveMotorcycle(VehicleActorComponent.TmpVector.ToUeVectorOld(), MotorcycleActorComponent.TmpQuat3.ToUeQuat(), sweep);
		if (this.DebugMovementComp != null)
		{
			this.DebugMovementComp.MarkDebugRecord(context + ".SetActorLocationAndRotation", new EKDMRecordType?(EKDMRecordType.KDM_LOCATION), false);
		}
		base.ResetTransformCachedTime();
		this.OnTeleport();
		return result;
	}

	// Token: 0x0601C647 RID: 116295 RVA: 0x007F3748 File Offset: 0x007F1948
	public override bool SetActorTransform(FTransformDouble value, string context, bool sweep = false, ESetRotationPriority? priority = null)
	{
		if (!sweep)
		{
			return base.SetActorTransform(value, context, sweep, priority);
		}
		bool result = false;
		if (priority != null)
		{
			FunctionRequestWithPriority<ESetRotationPriority> functionRequestWithPriority = new FunctionRequestWithPriority<ESetRotationPriority>();
			functionRequestWithPriority.ModuleName = context;
			functionRequestWithPriority.Priority = priority.Value;
			if (!this.SetRotationRequestProxy.DecideCall(functionRequestWithPriority))
			{
				FQuat fquat = base.ActorRotation.Quaternion();
				value.SetRotation(fquat);
			}
		}
		Vector tmpVector = VehicleActorComponent.TmpVector;
		FVectorDouble location = value.GetLocation();
		tmpVector.FromUeVector(location);
		VehicleActorComponent.TmpVector.SubtractionEqual(this.ActorLocationProxy);
		VehicleActorComponent.TmpQuat.FromUeQuat(value.GetRotation());
		base.ActorQuatProxy.Inverse(MotorcycleActorComponent.TmpQuat2);
		VehicleActorComponent.TmpQuat.Multiply(MotorcycleActorComponent.TmpQuat2, MotorcycleActorComponent.TmpQuat3);
		this.VehicleMoveComp.VehicleMovement.MoveMotorcycle(VehicleActorComponent.TmpVector.ToUeVectorOld(), MotorcycleActorComponent.TmpQuat3.ToUeQuat(), sweep);
		base.ResetTransformCachedTime();
		if (this.DebugMovementComp != null)
		{
			this.DebugMovementComp.MarkDebugRecord(context + ".SetActorTransform", new EKDMRecordType?(EKDMRecordType.KDM_LOCATION), false);
		}
		return result;
	}

	// Token: 0x0601C648 RID: 116296 RVA: 0x007F385C File Offset: 0x007F1A5C
	public override bool SetActorLocationAndRotationExceptMesh(FVectorDouble location, FRotator rotation, string context, bool sweep = false, ESetRotationPriority? priority = null)
	{
		if (this.SkeletalMesh != null)
		{
			return this.SetActorLocationAndRotation(location, rotation, context, sweep, priority);
		}
		FTransformDouble ftransformDouble = this.SkeletalMesh.D_K2_GetComponentToWorld();
		bool result = this.SetActorLocationAndRotation(location, rotation, context, sweep, priority);
		FHitResult fhitResult = new FHitResult();
		this.SkeletalMesh.D_K2_SetWorldTransform(ftransformDouble, false, ref fhitResult, true);
		return result;
	}

	// Token: 0x0601C649 RID: 116297 RVA: 0x007F38B0 File Offset: 0x007F1AB0
	public override bool SetActorTransformExceptMesh(FTransformDouble value, string context, bool sweep = false, ESetRotationPriority? priority = null)
	{
		if (this.SkeletalMesh != null)
		{
			return this.SetActorTransform(value, context, sweep, priority);
		}
		FTransformDouble ftransformDouble = this.SkeletalMesh.D_K2_GetComponentToWorld();
		bool result = this.SetActorTransform(value, context, sweep, priority);
		FHitResult fhitResult = new FHitResult();
		this.SkeletalMesh.D_K2_SetWorldTransform(ftransformDouble, false, ref fhitResult, true);
		return result;
	}

	// Token: 0x0601C64A RID: 116298 RVA: 0x007F3900 File Offset: 0x007F1B00
	public override void EnterFirstPersonMode()
	{
		base.EnterFirstPersonMode();
		TsBaseVehicle tsBaseVehicle = this.ActorInternal as TsBaseVehicle;
		if (tsBaseVehicle != null)
		{
			CharRenderingComponent charRenderingComponent = tsBaseVehicle.CharRenderingComponent;
			if (charRenderingComponent != null)
			{
				charRenderingComponent.SetMaterialPropertyFloatV2(RenderConfig.TexMipOffset, -10f, EKuroCharBodySpecifiedType.All, EKuroCharSlotSpecifiedType.All, EKuroCharMeshPart.ECharacterMeshPart_Max);
			}
		}
		Log.Instance.Info(ELogModule.Motor, ELogAuthor.LJM, "设置摩托第一人称材质参数", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0601C64B RID: 116299 RVA: 0x007F3964 File Offset: 0x007F1B64
	public override void ExitFirstPersonMode()
	{
		base.ExitFirstPersonMode();
		TsBaseVehicle tsBaseVehicle = this.ActorInternal as TsBaseVehicle;
		if (tsBaseVehicle != null)
		{
			CharRenderingComponent charRenderingComponent = tsBaseVehicle.CharRenderingComponent;
			if (charRenderingComponent != null)
			{
				charRenderingComponent.SetMaterialPropertyFloatV2(RenderConfig.TexMipOffset, 0f, EKuroCharBodySpecifiedType.All, EKuroCharSlotSpecifiedType.All, EKuroCharMeshPart.ECharacterMeshPart_Max);
			}
		}
		Log.Instance.Info(ELogModule.Motor, ELogAuthor.LJM, "还原摩托第一人称材质参数", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0601C64C RID: 116300 RVA: 0x007F39C8 File Offset: 0x007F1BC8
	public override void AddActorWorldOffset(FVectorDouble offset, string context = "unknown", bool sweep = false)
	{
		if (!sweep)
		{
			base.AddActorWorldOffset(offset, context, sweep);
			return;
		}
		if (base.CheckIsForbidSettingLocAndRot(true, false, true))
		{
			return;
		}
		VehicleActorComponent.TmpVector.FromUeVector(offset);
		this.VehicleMoveComp.VehicleMovement.MoveMotorcycle(VehicleActorComponent.TmpVector.ToUeVectorOld(), Quat.Identity, sweep);
		if (this.DebugMovementComp != null)
		{
			this.DebugMovementComp.MarkDebugRecord(context + ".AddActorWorldOffset", new EKDMRecordType?(EKDMRecordType.KDM_LOCATION), false);
		}
		base.ResetLocationCachedTime();
	}

	// Token: 0x0601C64D RID: 116301 RVA: 0x007F3A48 File Offset: 0x007F1C48
	public override void AddActorLocalOffset(FVectorDouble offset, string context = "unknown", bool sweep = false)
	{
		if (!sweep)
		{
			base.AddActorLocalOffset(offset, context, sweep);
			return;
		}
		if (base.CheckIsForbidSettingLocAndRot(true, false, true))
		{
			return;
		}
		VehicleActorComponent.TmpVector.FromUeVector(offset);
		base.ActorQuatProxy.RotateVector(VehicleActorComponent.TmpVector, VehicleActorComponent.TmpVector);
		this.VehicleMoveComp.VehicleMovement.MoveMotorcycle(VehicleActorComponent.TmpVector.ToUeVectorOld(), Quat.Identity, sweep);
		if (this.DebugMovementComp != null)
		{
			this.DebugMovementComp.MarkDebugRecord(context + ".AddActorLocalOffset", new EKDMRecordType?(EKDMRecordType.KDM_LOCATION), false);
		}
		base.ResetLocationCachedTime();
	}

	// Token: 0x0601C64E RID: 116302 RVA: 0x007F3ADC File Offset: 0x007F1CDC
	public override void AddActorWorldRotation(FRotator rotation, string context = "unknown", bool sweep = false)
	{
		if (!sweep)
		{
			base.AddActorWorldRotation(rotation, context, sweep);
			return;
		}
		MotorcycleActorComponent.TmpRotator.FromUeRotator(rotation);
		this.VehicleMoveComp.VehicleMovement.MoveMotorcycle(Vector.ZeroVector, MotorcycleActorComponent.TmpRotator.Quaternion(null).ToUeQuat(), sweep);
		if (this.DebugMovementComp != null)
		{
			this.DebugMovementComp.MarkDebugRecord(context + ".AddActorWorldRotation", new EKDMRecordType?(EKDMRecordType.KDM_LOCATION), false);
		}
		base.ResetRotationCachedTime();
	}

	// Token: 0x0601C64F RID: 116303 RVA: 0x007F3B54 File Offset: 0x007F1D54
	public override void AddActorLocalRotation(FRotator rotation, string context = "unknown", bool sweep = false)
	{
		if (!sweep)
		{
			base.AddActorLocalRotation(rotation, context, sweep);
			return;
		}
		MotorcycleActorComponent.TmpRotator.FromUeRotator(rotation);
		MotorcycleActorComponent.TmpRotator.Quaternion(VehicleActorComponent.TmpQuat);
		base.ActorQuatProxy.Multiply(VehicleActorComponent.TmpQuat, MotorcycleActorComponent.TmpQuat2);
		base.ActorQuatProxy.Inverse(VehicleActorComponent.TmpQuat);
		MotorcycleActorComponent.TmpQuat2.Multiply(VehicleActorComponent.TmpQuat, MotorcycleActorComponent.TmpQuat3);
		this.VehicleMoveComp.VehicleMovement.MoveMotorcycle(Vector.ZeroVector, MotorcycleActorComponent.TmpQuat3.ToUeQuat(), sweep);
		if (this.DebugMovementComp != null)
		{
			this.DebugMovementComp.MarkDebugRecord(context + ".AddActorWorldRotation", new EKDMRecordType?(EKDMRecordType.KDM_LOCATION), false);
		}
		base.ResetRotationCachedTime();
	}

	// Token: 0x0601C650 RID: 116304 RVA: 0x007F3C10 File Offset: 0x007F1E10
	public override void AddActorWorldOffsetAndQuat(FVectorDouble offset, FQuat quatOffset, string context = "unknown", bool sweep = false)
	{
		if (!sweep)
		{
			base.AddActorWorldOffsetAndQuat(offset, quatOffset, context, sweep);
			return;
		}
		VehicleActorComponent.TmpVector.FromUeVector(offset);
		this.VehicleMoveComp.VehicleMovement.MoveMotorcycle(VehicleActorComponent.TmpVector.ToUeVectorOld(), quatOffset, sweep);
		if (this.DebugMovementComp != null)
		{
			this.DebugMovementComp.MarkDebugRecord(context + ".AddActorWorldOffsetAndQuat", new EKDMRecordType?(EKDMRecordType.KDM_LOCATION), false);
		}
		base.ResetRotationCachedTime();
	}

	// Token: 0x0601C651 RID: 116305 RVA: 0x007F3C84 File Offset: 0x007F1E84
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		MotorcycleActorComponent motorcycleActorComponent = (MotorcycleActorComponent)componentTemplate;
		return !base.CanResetComponentProperty("AirRotateInputInternal") || motorcycleActorComponent.AirRotateInputInternal == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.AirRotateInputInternal), "AirRotateInputInternal");
	}

	// Token: 0x0400E143 RID: 57667
	private const int TEX_MIP_OFFSET = -10;

	// Token: 0x0400E144 RID: 57668
	private const int TEX_MIP_OFFSET_DEFAULT = 0;

	// Token: 0x0400E145 RID: 57669
	[StaticVariableRuleIgnore]
	protected static Rotator TmpRotator = Rotator.Create();

	// Token: 0x0400E146 RID: 57670
	[StaticVariableRuleIgnore]
	protected static Quat TmpQuat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400E147 RID: 57671
	[StaticVariableRuleIgnore]
	protected static Quat TmpQuat3 = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400E148 RID: 57672
	private readonly Vector AirRotateInputInternal = Vector.Create();
}
