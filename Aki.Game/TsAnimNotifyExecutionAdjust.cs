using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001BB RID: 443
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyExecutionAdjust.TsAnimNotifyExecutionAdjust_C")]
public class TsAnimNotifyExecutionAdjust : TsAnimNotifyBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000493 RID: 1171
	// (get) Token: 0x06001C36 RID: 7222 RVA: 0x00094913 File Offset: 0x00092B13
	// (set) Token: 0x06001C37 RID: 7223 RVA: 0x00094923 File Offset: 0x00092B23
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float DetectionRadius
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyExecutionAdjust.__PropertyOffset_DetectionRadius);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyExecutionAdjust.__PropertyOffset_DetectionRadius) = value;
		}
	}

	// Token: 0x17000494 RID: 1172
	// (get) Token: 0x06001C38 RID: 7224 RVA: 0x00094934 File Offset: 0x00092B34
	// (set) Token: 0x06001C39 RID: 7225 RVA: 0x00094948 File Offset: 0x00092B48
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string CaughtId
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyExecutionAdjust.__PropertyOffset_CaughtId)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyExecutionAdjust.__PropertyOffset_CaughtId)), value);
		}
	}

	// Token: 0x06001C3A RID: 7226 RVA: 0x0009495D File Offset: 0x00092B5D
	static TsAnimNotifyExecutionAdjust()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyExecutionAdjust.CreateStaticDefaultValue), new Action(TsAnimNotifyExecutionAdjust.ResetStaticDefaultValue));
	}

	// Token: 0x06001C3B RID: 7227 RVA: 0x0009497C File Offset: 0x00092B7C
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyExecutionAdjust.SphereTrace = null;
	}

	// Token: 0x06001C3C RID: 7228 RVA: 0x00094984 File Offset: 0x00092B84
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyExecutionAdjust.SphereTrace = null;
	}

	// Token: 0x06001C3D RID: 7229 RVA: 0x0009498C File Offset: 0x00092B8C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyExecutionAdjust) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyExecutionAdjust.StaticClass(), out intPtr, out num))
		{
			return this.K2_Notify_Implementation(meshComp, animation);
		}
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr = stackalloc UKuroAnimNotify.__K2_Notify_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001C3E RID: 7230 RVA: 0x00094A44 File Offset: 0x00092C44
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return true;
		}
		CharacterCaughtNewComponent component = tsBaseCharacter.CharacterActorComponent.Entity.GetComponent<CharacterCaughtNewComponent>();
		if (component == null)
		{
			return true;
		}
		ValueTuple<Entity, long, float> valueTuple;
		if (!component.PendingCaughtList.TryGetValue(this.CaughtId, out valueTuple))
		{
			return true;
		}
		TsAnimNotifyExecutionAdjust.InitTrace();
		CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
		global::Vector vector = (characterActorComponent != null) ? characterActorComponent.ActorLocationProxy : null;
		UTraceSphereElement sphereTrace = TsAnimNotifyExecutionAdjust.SphereTrace;
		TraceElementCommon.Instance.SetStartLocation(sphereTrace, vector);
		TraceElementCommon.Instance.SetEndLocation(sphereTrace, vector);
		sphereTrace.Radius = this.DetectionRadius;
		if (!TraceElementCommon.Instance.SphereTrace(sphereTrace, "FightCameraLogicComponent_CheckCollision_ExecutionAdjust"))
		{
			return true;
		}
		bool flag = false;
		TArray<int> itemArray = sphereTrace.HitResult.ItemArray;
		for (int i = 0; i < sphereTrace.HitResult.GetHitCount(); i++)
		{
			int instanceIndex = itemArray.Get(i);
			UKuroHitResult hitResult = sphereTrace.HitResult;
			TWeakObjectPtr<UPrimitiveComponent>? tweakObjectPtr = (hitResult != null) ? new TWeakObjectPtr<UPrimitiveComponent>?(hitResult.Components.Get(i)) : null;
			if (UKuroCollisionLibrary.GetCollisionProfileName((tweakObjectPtr != null) ? tweakObjectPtr.GetValueOrDefault() : null, instanceIndex).ToString().Contains("InvisibleWall"))
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			return true;
		}
		CreatureDataComponent component2 = valueTuple.Item1.GetComponent<CreatureDataComponent>();
		if (component2 != null && component2.GetEntityType() == EEntityType.Monster)
		{
			global::Vector vector2 = global::Vector.Create((component2 != null) ? component2.GetInitLocation() : null);
			global::Vector inB = global::Vector.Create(vector);
			global::Vector vector3 = global::Vector.Create();
			vector2.Subtraction(inB, vector3);
			vector3.Normalize(9.99999993922529E-09);
			vector3.Multiply((double)this.DetectionRadius, vector3);
			CharacterActorComponent characterActorComponent2 = tsBaseCharacter.CharacterActorComponent;
			global::Vector vector4 = global::Vector.Create((characterActorComponent2 != null) ? new FVectorDouble?(characterActorComponent2.ActorLocation) : null).AdditionEqual(vector3);
			CharacterActorComponent characterActorComponent3 = tsBaseCharacter.CharacterActorComponent;
			if (characterActorComponent3 != null)
			{
				characterActorComponent3.SetActorLocation(vector4.ToUeVector(false), "ExecutionAdjustMove", false);
			}
			CharacterActorComponent component3 = valueTuple.Item1.GetComponent<CharacterActorComponent>();
			global::Vector vector5 = global::Vector.Create((component3 != null) ? new FVectorDouble?(component3.ActorLocation) : null).AdditionEqual(vector3);
			CharacterActorComponent component4 = valueTuple.Item1.GetComponent<CharacterActorComponent>();
			if (component4 != null)
			{
				component4.SetActorLocation(vector5.ToUeVector(false), "ExecutionAdjustMove", false);
			}
		}
		return true;
	}

	// Token: 0x06001C3F RID: 7231 RVA: 0x00094CB4 File Offset: 0x00092EB4
	public static void InitTrace()
	{
		TsAnimNotifyExecutionAdjust.SphereTrace = new UTraceSphereElement();
		TsAnimNotifyExecutionAdjust.SphereTrace.bIsSingle = false;
		TsAnimNotifyExecutionAdjust.SphereTrace.bIgnoreSelf = true;
		TsAnimNotifyExecutionAdjust.SphereTrace.bTraceComplex = false;
		TsAnimNotifyExecutionAdjust.SphereTrace.AddObjectTypeQuery(KuroObjectTypeQuery.WorldStatic);
		TsAnimNotifyExecutionAdjust.SphereTrace.AddObjectTypeQuery(KuroObjectTypeQuery.WorldStaticIgnoreBullet);
		TsAnimNotifyExecutionAdjust.SphereTrace.WorldContextObject = GlobalData.World;
	}

	// Token: 0x06001C40 RID: 7232 RVA: 0x00094D1C File Offset: 0x00092F1C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyExecutionAdjust) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyExecutionAdjust.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotify.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotify.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x06001C41 RID: 7233 RVA: 0x00094DAC File Offset: 0x00092FAC
	protected override string GetNotifyName_Implementation()
	{
		return "处决调整位置";
	}

	// Token: 0x06001C42 RID: 7234 RVA: 0x00094DB3 File Offset: 0x00092FB3
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyExecutionAdjust._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyExecutionAdjust.TsAnimNotifyExecutionAdjust_C");
		}
		return TsAnimNotifyExecutionAdjust._ClassPtr;
	}

	// Token: 0x06001C43 RID: 7235 RVA: 0x00094DD8 File Offset: 0x00092FD8
	public TsAnimNotifyExecutionAdjust() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyExecutionAdjust.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001C44 RID: 7236 RVA: 0x00094E00 File Offset: 0x00093000
	public TsAnimNotifyExecutionAdjust(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyExecutionAdjust.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001C45 RID: 7237 RVA: 0x00094E33 File Offset: 0x00093033
	protected TsAnimNotifyExecutionAdjust(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001C46 RID: 7238 RVA: 0x00094E3C File Offset: 0x0009303C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001C47 RID: 7239 RVA: 0x00094E6F File Offset: 0x0009306F
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040011DB RID: 4571
	private const string PROFILE_KEY = "FightCameraLogicComponent_CheckCollision_ExecutionAdjust";

	// Token: 0x040011DC RID: 4572
	private const string AIRWALL_PORFILENAME = "InvisibleWall";

	// Token: 0x040011DD RID: 4573
	[Nullable(2)]
	private static UTraceSphereElement SphereTrace;

	// Token: 0x040011DE RID: 4574
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyExecutionAdjust.TsAnimNotifyExecutionAdjust_C";

	// Token: 0x040011DF RID: 4575
	private static IntPtr _ClassPtr;

	// Token: 0x040011E0 RID: 4576
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040011E1 RID: 4577
	private static int __PropertyOffset_DetectionRadius;

	// Token: 0x040011E2 RID: 4578
	private static int __PropertyOffset_CaughtId;
}
