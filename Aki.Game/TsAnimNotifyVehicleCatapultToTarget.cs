using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;
using CSharpScript.Game.NewWorld.Character.Common.Component.Explore;
using CSharpScript.Game.NewWorld.Vehicle.Common;
using Cysharp.Threading.Tasks;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001E7 RID: 487
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyVehicleCatapultToTarget.TsAnimNotifyVehicleCatapultToTarget_C")]
public class TsAnimNotifyVehicleCatapultToTarget : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004FF RID: 1279
	// (get) Token: 0x06001EC0 RID: 7872 RVA: 0x0009DE67 File Offset: 0x0009C067
	// (set) Token: 0x06001EC1 RID: 7873 RVA: 0x0009DE7B File Offset: 0x0009C07B
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

	// Token: 0x17000500 RID: 1280
	// (get) Token: 0x06001EC2 RID: 7874 RVA: 0x0009DE90 File Offset: 0x0009C090
	// (set) Token: 0x06001EC3 RID: 7875 RVA: 0x0009DEA0 File Offset: 0x0009C0A0
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

	// Token: 0x17000501 RID: 1281
	// (get) Token: 0x06001EC4 RID: 7876 RVA: 0x0009DEB1 File Offset: 0x0009C0B1
	// (set) Token: 0x06001EC5 RID: 7877 RVA: 0x0009DEC1 File Offset: 0x0009C0C1
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

	// Token: 0x17000502 RID: 1282
	// (get) Token: 0x06001EC6 RID: 7878 RVA: 0x0009DED2 File Offset: 0x0009C0D2
	// (set) Token: 0x06001EC7 RID: 7879 RVA: 0x0009DEE2 File Offset: 0x0009C0E2
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

	// Token: 0x17000503 RID: 1283
	// (get) Token: 0x06001EC8 RID: 7880 RVA: 0x0009DEF3 File Offset: 0x0009C0F3
	// (set) Token: 0x06001EC9 RID: 7881 RVA: 0x0009DF03 File Offset: 0x0009C103
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

	// Token: 0x17000504 RID: 1284
	// (get) Token: 0x06001ECA RID: 7882 RVA: 0x0009DF14 File Offset: 0x0009C114
	// (set) Token: 0x06001ECB RID: 7883 RVA: 0x0009DF24 File Offset: 0x0009C124
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

	// Token: 0x06001ECC RID: 7884 RVA: 0x0009DF38 File Offset: 0x0009C138
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
		bool flag = this.Debug && false;
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

	// Token: 0x06001ECD RID: 7885 RVA: 0x0009E17D File Offset: 0x0009C37D
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public override string GetNotifyName()
	{
		return "载具弹射到目标";
	}

	// Token: 0x06001ECE RID: 7886 RVA: 0x0009E184 File Offset: 0x0009C384
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyVehicleCatapultToTarget._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyVehicleCatapultToTarget.TsAnimNotifyVehicleCatapultToTarget_C");
		}
		return TsAnimNotifyVehicleCatapultToTarget._ClassPtr;
	}

	// Token: 0x06001ECF RID: 7887 RVA: 0x0009E1A8 File Offset: 0x0009C3A8
	public TsAnimNotifyVehicleCatapultToTarget() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyVehicleCatapultToTarget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001ED0 RID: 7888 RVA: 0x0009E1D0 File Offset: 0x0009C3D0
	[NullableContext(1)]
	public TsAnimNotifyVehicleCatapultToTarget(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyVehicleCatapultToTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001ED1 RID: 7889 RVA: 0x0009E203 File Offset: 0x0009C403
	protected TsAnimNotifyVehicleCatapultToTarget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001ED2 RID: 7890 RVA: 0x0009E20C File Offset: 0x0009C40C
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001ED3 RID: 7891 RVA: 0x0009E23F File Offset: 0x0009C43F
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName());
	}

	// Token: 0x040012E0 RID: 4832
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpPos = Vector.Create();

	// Token: 0x040012E1 RID: 4833
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpOffset = Vector.Create();

	// Token: 0x040012E2 RID: 4834
	private const float DEBUG_SPHERE_RADIUS = 50f;

	// Token: 0x040012E3 RID: 4835
	private const int DEBUG_SPHERE_SEGMENTS = 12;

	// Token: 0x040012E4 RID: 4836
	private const float DEBUG_SPHERE_DURATION = 3f;

	// Token: 0x040012E5 RID: 4837
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyVehicleCatapultToTarget.TsAnimNotifyVehicleCatapultToTarget_C";

	// Token: 0x040012E6 RID: 4838
	private static IntPtr _ClassPtr;

	// Token: 0x040012E7 RID: 4839
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040012E8 RID: 4840
	private static int __PropertyOffset_LocationOffset;

	// Token: 0x040012E9 RID: 4841
	private static int __PropertyOffset_HeightOffset;

	// Token: 0x040012EA RID: 4842
	private static int __PropertyOffset_NoTargetCameraDistance;

	// Token: 0x040012EB RID: 4843
	private static int __PropertyOffset_NoTargetTraceRadius;

	// Token: 0x040012EC RID: 4844
	private static int __PropertyOffset_GravityMagnitude;

	// Token: 0x040012ED RID: 4845
	private static int __PropertyOffset_Debug;
}
