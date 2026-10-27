using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Camera;
using CSharpScript.Game.NewWorld.Character.Common.Component.Explore;
using CSharpScript.Game.NewWorld.Vehicle.Common;
using Cysharp.Threading.Tasks;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001E3 RID: 483
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyVehicleCatapultToTarget.TsAnimNotifyVehicleCatapultToTarget_C")]
public class TsAnimNotifyVehicleCatapultToTarget : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004DD RID: 1245
	// (get) Token: 0x06001E23 RID: 7715 RVA: 0x00096DE7 File Offset: 0x00094FE7
	// (set) Token: 0x06001E24 RID: 7716 RVA: 0x00096DFB File Offset: 0x00094FFB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector LocationOffset
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyVehicleCatapultToTarget.__PropertyOffset_LocationOffset);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyVehicleCatapultToTarget.__PropertyOffset_LocationOffset) = value;
		}
	}

	// Token: 0x170004DE RID: 1246
	// (get) Token: 0x06001E25 RID: 7717 RVA: 0x00096E10 File Offset: 0x00095010
	// (set) Token: 0x06001E26 RID: 7718 RVA: 0x00096E20 File Offset: 0x00095020
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float HeightOffset
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyVehicleCatapultToTarget.__PropertyOffset_HeightOffset);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyVehicleCatapultToTarget.__PropertyOffset_HeightOffset) = value;
		}
	}

	// Token: 0x170004DF RID: 1247
	// (get) Token: 0x06001E27 RID: 7719 RVA: 0x00096E31 File Offset: 0x00095031
	// (set) Token: 0x06001E28 RID: 7720 RVA: 0x00096E41 File Offset: 0x00095041
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float NoTargetCameraDistance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyVehicleCatapultToTarget.__PropertyOffset_NoTargetCameraDistance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyVehicleCatapultToTarget.__PropertyOffset_NoTargetCameraDistance) = value;
		}
	}

	// Token: 0x170004E0 RID: 1248
	// (get) Token: 0x06001E29 RID: 7721 RVA: 0x00096E52 File Offset: 0x00095052
	// (set) Token: 0x06001E2A RID: 7722 RVA: 0x00096E62 File Offset: 0x00095062
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float NoTargetTraceRadius
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyVehicleCatapultToTarget.__PropertyOffset_NoTargetTraceRadius);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyVehicleCatapultToTarget.__PropertyOffset_NoTargetTraceRadius) = value;
		}
	}

	// Token: 0x170004E1 RID: 1249
	// (get) Token: 0x06001E2B RID: 7723 RVA: 0x00096E73 File Offset: 0x00095073
	// (set) Token: 0x06001E2C RID: 7724 RVA: 0x00096E83 File Offset: 0x00095083
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float GravityMagnitude
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyVehicleCatapultToTarget.__PropertyOffset_GravityMagnitude);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyVehicleCatapultToTarget.__PropertyOffset_GravityMagnitude) = value;
		}
	}

	// Token: 0x170004E2 RID: 1250
	// (get) Token: 0x06001E2D RID: 7725 RVA: 0x00096E94 File Offset: 0x00095094
	// (set) Token: 0x06001E2E RID: 7726 RVA: 0x00096EA4 File Offset: 0x000950A4
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool Debug
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyVehicleCatapultToTarget.__PropertyOffset_Debug) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyVehicleCatapultToTarget.__PropertyOffset_Debug) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001E2F RID: 7727 RVA: 0x00096EB8 File Offset: 0x000950B8
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseVehicle tsBaseVehicle = meshComp.GetOwner() as TsBaseVehicle;
		if (tsBaseVehicle == null)
		{
			return false;
		}
		Entity entityNoBlueprint = tsBaseVehicle.GetEntityNoBlueprint();
		if (entityNoBlueprint == null)
		{
			return false;
		}
		VehicleActionComponent component = entityNoBlueprint.GetComponent<VehicleActionComponent>();
		if (component == null)
		{
			return false;
		}
		MotorcycleExploreComponent component2 = entityNoBlueprint.GetComponent<MotorcycleExploreComponent>();
		bool flag = this.Debug && Info.Instance.IsPlayInEditor;
		Vector tmpPos = TsAnimNotifyVehicleCatapultToTarget.TmpPos;
		Vector vector = (component2 != null) ? component2.GetInteractingTargetLocation() : null;
		if (vector != null)
		{
			tmpPos.DeepCopy(vector);
		}
		else
		{
			VehicleActorComponent component3 = entityNoBlueprint.GetComponent<VehicleActorComponent>();
			if (component3 == null)
			{
				return false;
			}
			Vector cameraForward = CameraController.Instance.MainModel.FightCamera.LogicComponent.CameraForward;
			Vector actorLocationProxy = component3.ActorLocationProxy;
			tmpPos.DeepCopy(actorLocationProxy);
			tmpPos.X += cameraForward.X * (double)this.NoTargetCameraDistance;
			tmpPos.Y += cameraForward.Y * (double)this.NoTargetCameraDistance;
			tmpPos.Z += cameraForward.Z * (double)this.NoTargetCameraDistance;
			UTraceSphereElement traceTypeElement = TraceElementModel.Instance.GetTraceTypeElement<UTraceSphereElement>(KuroTraceTypeQuery.Visible, GlobalData.World, true, true);
			traceTypeElement.Radius = this.NoTargetTraceRadius;
			traceTypeElement.ActorsToIgnore.Empty(true);
			if (flag)
			{
				traceTypeElement.SetDrawDebugTrace(EDrawDebugTrace.ForDuration);
			}
			TraceElementCommon.Instance.SetStartLocation(traceTypeElement, actorLocationProxy);
			TraceElementCommon.Instance.SetEndLocation(traceTypeElement, tmpPos);
			if (TraceElementCommon.Instance.SphereTrace(traceTypeElement, "VehicleCatapultToTarget") && traceTypeElement.HitResult.bBlockingHit)
			{
				TraceElementCommon.Instance.GetHitLocation(traceTypeElement.HitResult, 0, tmpPos);
			}
		}
		if (flag)
		{
			FLinearColor value = (vector != null) ? new FLinearColor(0f, 1f, 0f, 1f) : new FLinearColor(1f, 0f, 0f, 1f);
			UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.World, tmpPos.ToUeVector(false), 50f, 12, new FLinearColor?(value), 3f, 0f);
			VehicleCatapultComponent component4 = entityNoBlueprint.GetComponent<VehicleCatapultComponent>();
			if (component4 != null)
			{
				component4.DebugDraw = true;
			}
		}
		Vector tmpOffset = TsAnimNotifyVehicleCatapultToTarget.TmpOffset;
		Vector vector2 = tmpOffset;
		FVector locationOffset = this.LocationOffset;
		vector2.FromUeVector(locationOffset);
		component.StartCatapultToTarget(tmpPos, tmpOffset, this.HeightOffset, this.GravityMagnitude, vector != null, 0).Forget<bool>();
		return true;
	}

	// Token: 0x06001E30 RID: 7728 RVA: 0x00097106 File Offset: 0x00095306
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public override string GetNotifyName()
	{
		return "载具弹射到目标";
	}

	// Token: 0x06001E31 RID: 7729 RVA: 0x0009710D File Offset: 0x0009530D
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyVehicleCatapultToTarget._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyVehicleCatapultToTarget.TsAnimNotifyVehicleCatapultToTarget_C");
		}
		return TsAnimNotifyVehicleCatapultToTarget._ClassPtr;
	}

	// Token: 0x06001E32 RID: 7730 RVA: 0x00097134 File Offset: 0x00095334
	public TsAnimNotifyVehicleCatapultToTarget() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyVehicleCatapultToTarget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001E33 RID: 7731 RVA: 0x0009715C File Offset: 0x0009535C
	[NullableContext(1)]
	public TsAnimNotifyVehicleCatapultToTarget(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyVehicleCatapultToTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001E34 RID: 7732 RVA: 0x0009718F File Offset: 0x0009538F
	protected TsAnimNotifyVehicleCatapultToTarget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001E35 RID: 7733 RVA: 0x00097198 File Offset: 0x00095398
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001E36 RID: 7734 RVA: 0x000971CB File Offset: 0x000953CB
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName());
	}

	// Token: 0x0400129D RID: 4765
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpPos = Vector.Create();

	// Token: 0x0400129E RID: 4766
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpOffset = Vector.Create();

	// Token: 0x0400129F RID: 4767
	private const float DEBUG_SPHERE_RADIUS = 50f;

	// Token: 0x040012A0 RID: 4768
	private const int DEBUG_SPHERE_SEGMENTS = 12;

	// Token: 0x040012A1 RID: 4769
	private const float DEBUG_SPHERE_DURATION = 3f;

	// Token: 0x040012A2 RID: 4770
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyVehicleCatapultToTarget.TsAnimNotifyVehicleCatapultToTarget_C";

	// Token: 0x040012A3 RID: 4771
	private static IntPtr _ClassPtr;

	// Token: 0x040012A4 RID: 4772
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040012A5 RID: 4773
	private static int __PropertyOffset_LocationOffset;

	// Token: 0x040012A6 RID: 4774
	private static int __PropertyOffset_HeightOffset;

	// Token: 0x040012A7 RID: 4775
	private static int __PropertyOffset_NoTargetCameraDistance;

	// Token: 0x040012A8 RID: 4776
	private static int __PropertyOffset_NoTargetTraceRadius;

	// Token: 0x040012A9 RID: 4777
	private static int __PropertyOffset_GravityMagnitude;

	// Token: 0x040012AA RID: 4778
	private static int __PropertyOffset_Debug;
}
