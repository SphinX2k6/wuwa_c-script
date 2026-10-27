using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001B7 RID: 439
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyExecutionAdjust.TsAnimNotifyExecutionAdjust_C")]
public class TsAnimNotifyExecutionAdjust : TsAnimNotifyBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000471 RID: 1137
	// (get) Token: 0x06001B99 RID: 7065 RVA: 0x0008DF87 File Offset: 0x0008C187
	// (set) Token: 0x06001B9A RID: 7066 RVA: 0x0008DF97 File Offset: 0x0008C197
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

	// Token: 0x17000472 RID: 1138
	// (get) Token: 0x06001B9B RID: 7067 RVA: 0x0008DFA8 File Offset: 0x0008C1A8
	// (set) Token: 0x06001B9C RID: 7068 RVA: 0x0008DFBC File Offset: 0x0008C1BC
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

	// Token: 0x06001B9D RID: 7069 RVA: 0x0008DFD1 File Offset: 0x0008C1D1
	static TsAnimNotifyExecutionAdjust()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyExecutionAdjust.CreateStaticDefaultValue), new Action(TsAnimNotifyExecutionAdjust.ResetStaticDefaultValue));
	}

	// Token: 0x06001B9E RID: 7070 RVA: 0x0008DFF0 File Offset: 0x0008C1F0
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyExecutionAdjust.SphereTrace = null;
	}

	// Token: 0x06001B9F RID: 7071 RVA: 0x0008DFF8 File Offset: 0x0008C1F8
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyExecutionAdjust.SphereTrace = null;
	}

	// Token: 0x06001BA0 RID: 7072 RVA: 0x0008E000 File Offset: 0x0008C200
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_Notify"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotify.__K2_Notify_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06001BA1 RID: 7073 RVA: 0x0008E0A0 File Offset: 0x0008C2A0
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

	// Token: 0x06001BA2 RID: 7074 RVA: 0x0008E310 File Offset: 0x0008C510
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

	// Token: 0x06001BA3 RID: 7075 RVA: 0x0008E378 File Offset: 0x0008C578
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotify.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotify.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		string result = FString.ToString((void*)(&ptr2->__Result));
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return result;
	}

	// Token: 0x06001BA4 RID: 7076 RVA: 0x0008E3F3 File Offset: 0x0008C5F3
	protected override string GetNotifyName_Implementation()
	{
		return "处决调整位置";
	}

	// Token: 0x06001BA5 RID: 7077 RVA: 0x0008E3FA File Offset: 0x0008C5FA
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyExecutionAdjust._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyExecutionAdjust.TsAnimNotifyExecutionAdjust_C");
		}
		return TsAnimNotifyExecutionAdjust._ClassPtr;
	}

	// Token: 0x06001BA6 RID: 7078 RVA: 0x0008E420 File Offset: 0x0008C620
	public TsAnimNotifyExecutionAdjust() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyExecutionAdjust.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001BA7 RID: 7079 RVA: 0x0008E448 File Offset: 0x0008C648
	public TsAnimNotifyExecutionAdjust(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyExecutionAdjust.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001BA8 RID: 7080 RVA: 0x0008E47B File Offset: 0x0008C67B
	protected TsAnimNotifyExecutionAdjust(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001BA9 RID: 7081 RVA: 0x0008E484 File Offset: 0x0008C684
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001BAA RID: 7082 RVA: 0x0008E4B7 File Offset: 0x0008C6B7
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001198 RID: 4504
	private const string PROFILE_KEY = "FightCameraLogicComponent_CheckCollision_ExecutionAdjust";

	// Token: 0x04001199 RID: 4505
	private const string AIRWALL_PORFILENAME = "InvisibleWall";

	// Token: 0x0400119A RID: 4506
	[Nullable(2)]
	private static UTraceSphereElement SphereTrace;

	// Token: 0x0400119B RID: 4507
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyExecutionAdjust.TsAnimNotifyExecutionAdjust_C";

	// Token: 0x0400119C RID: 4508
	private static IntPtr _ClassPtr;

	// Token: 0x0400119D RID: 4509
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400119E RID: 4510
	private static int __PropertyOffset_DetectionRadius;

	// Token: 0x0400119F RID: 4511
	private static int __PropertyOffset_CaughtId;
}
