using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Render;
using UnrealEngine;

// Token: 0x02002868 RID: 10344
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleActorComponent : VehicleActorComponent
{
	// Token: 0x17002AB8 RID: 10936
	// (get) Token: 0x0601A306 RID: 107270 RVA: 0x00819769 File Offset: 0x00817969
	public Vector AirRotateInputProxy
	{
		get
		{
			return this.AirRotateInputInternal;
		}
	}

	// Token: 0x0601A307 RID: 107271 RVA: 0x00819771 File Offset: 0x00817971
	public void SetAirRotateInput(IVector v)
	{
		this.AirRotateInputInternal.DeepCopy(v);
	}

	// Token: 0x0601A308 RID: 107272 RVA: 0x00819780 File Offset: 0x00817980
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

	// Token: 0x0601A309 RID: 107273 RVA: 0x008198DC File Offset: 0x00817ADC
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

	// Token: 0x0601A30A RID: 107274 RVA: 0x00819A30 File Offset: 0x00817C30
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

	// Token: 0x0601A30B RID: 107275 RVA: 0x00819B10 File Offset: 0x00817D10
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

	// Token: 0x0601A30C RID: 107276 RVA: 0x00819C74 File Offset: 0x00817E74
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

	// Token: 0x0601A30D RID: 107277 RVA: 0x00819D88 File Offset: 0x00817F88
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

	// Token: 0x0601A30E RID: 107278 RVA: 0x00819DDC File Offset: 0x00817FDC
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

	// Token: 0x0601A30F RID: 107279 RVA: 0x00819E2C File Offset: 0x0081802C
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

	// Token: 0x0601A310 RID: 107280 RVA: 0x00819E90 File Offset: 0x00818090
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

	// Token: 0x0601A311 RID: 107281 RVA: 0x00819EF4 File Offset: 0x008180F4
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

	// Token: 0x0601A312 RID: 107282 RVA: 0x00819F74 File Offset: 0x00818174
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

	// Token: 0x0601A313 RID: 107283 RVA: 0x0081A008 File Offset: 0x00818208
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

	// Token: 0x0601A314 RID: 107284 RVA: 0x0081A080 File Offset: 0x00818280
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

	// Token: 0x0601A315 RID: 107285 RVA: 0x0081A13C File Offset: 0x0081833C
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

	// Token: 0x0601A316 RID: 107286 RVA: 0x0081A1AE File Offset: 0x008183AE
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		return base.ClearComponent(componentTemplate) && (((MotorcycleActorComponent)componentTemplate).AirRotateInputInternal == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.AirRotateInputInternal), "AirRotateInputInternal"));
	}

	// Token: 0x17002AB9 RID: 10937
	// (get) Token: 0x0601A317 RID: 107287 RVA: 0x0081A1E3 File Offset: 0x008183E3
	public override bool NeedCreateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002ABA RID: 10938
	// (get) Token: 0x0601A318 RID: 107288 RVA: 0x0081A1E6 File Offset: 0x008183E6
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002ABB RID: 10939
	// (get) Token: 0x0601A319 RID: 107289 RVA: 0x0081A1E9 File Offset: 0x008183E9
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002ABC RID: 10940
	// (get) Token: 0x0601A31A RID: 107290 RVA: 0x0081A1EC File Offset: 0x008183EC
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002ABD RID: 10941
	// (get) Token: 0x0601A31B RID: 107291 RVA: 0x0081A1EF File Offset: 0x008183EF
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002ABE RID: 10942
	// (get) Token: 0x0601A31C RID: 107292 RVA: 0x0081A1F2 File Offset: 0x008183F2
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002ABF RID: 10943
	// (get) Token: 0x0601A31D RID: 107293 RVA: 0x0081A1F5 File Offset: 0x008183F5
	public override bool NeedEnableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002AC0 RID: 10944
	// (get) Token: 0x0601A31E RID: 107294 RVA: 0x0081A1F8 File Offset: 0x008183F8
	public override bool NeedDisableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002AC1 RID: 10945
	// (get) Token: 0x0601A31F RID: 107295 RVA: 0x0081A1FB File Offset: 0x008183FB
	public override bool NeedChangeTimeDilationInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400E5EE RID: 58862
	private const int TEX_MIP_OFFSET = -10;

	// Token: 0x0400E5EF RID: 58863
	private const int TEX_MIP_OFFSET_DEFAULT = 0;

	// Token: 0x0400E5F0 RID: 58864
	[StaticVariableRuleIgnore]
	protected static Rotator TmpRotator = Rotator.Create();

	// Token: 0x0400E5F1 RID: 58865
	[StaticVariableRuleIgnore]
	protected static Quat TmpQuat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400E5F2 RID: 58866
	[StaticVariableRuleIgnore]
	protected static Quat TmpQuat3 = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400E5F3 RID: 58867
	private readonly Vector AirRotateInputInternal = Vector.Create();
}
