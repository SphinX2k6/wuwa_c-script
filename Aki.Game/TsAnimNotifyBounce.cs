using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200019C RID: 412
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBounce.TsAnimNotifyBounce_C")]
public class TsAnimNotifyBounce : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000458 RID: 1112
	// (get) Token: 0x06001A92 RID: 6802 RVA: 0x0008ED4B File Offset: 0x0008CF4B
	// (set) Token: 0x06001A93 RID: 6803 RVA: 0x0008ED5B File Offset: 0x0008CF5B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Time
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyBounce.__PropertyOffset_Time);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyBounce.__PropertyOffset_Time) = value;
		}
	}

	// Token: 0x17000459 RID: 1113
	// (get) Token: 0x06001A94 RID: 6804 RVA: 0x0008ED6C File Offset: 0x0008CF6C
	// (set) Token: 0x06001A95 RID: 6805 RVA: 0x0008ED7C File Offset: 0x0008CF7C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Height
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyBounce.__PropertyOffset_Height);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyBounce.__PropertyOffset_Height) = value;
		}
	}

	// Token: 0x1700045A RID: 1114
	// (get) Token: 0x06001A96 RID: 6806 RVA: 0x0008ED90 File Offset: 0x0008CF90
	// (set) Token: 0x06001A97 RID: 6807 RVA: 0x0008EDC9 File Offset: 0x0008CFC9
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<UCurveFloat> MotionCurve
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<UCurveFloat> result;
			if ((result = this._MotionCurve) == null)
			{
				result = (this._MotionCurve = new TSoftObjectPtr<UCurveFloat>(base.NativePtr + (IntPtr)TsAnimNotifyBounce.__PropertyOffset_MotionCurve, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)TsAnimNotifyBounce.__PropertyOffset_MotionCurve, 1);
		}
	}

	// Token: 0x06001A98 RID: 6808 RVA: 0x0008EDF0 File Offset: 0x0008CFF0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyBounce) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyBounce.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001A99 RID: 6809 RVA: 0x0008EEA8 File Offset: 0x0008D0A8
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return true;
		}
		CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
		Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
		CharacterActionComponent characterActionComponent = (entity != null) ? entity.GetComponent<CharacterActionComponent>() : null;
		CharacterCatapultComponent characterCatapultComponent = (entity != null) ? entity.GetComponent<CharacterCatapultComponent>() : null;
		if (characterActionComponent == null || characterCatapultComponent == null)
		{
			return true;
		}
		TSoftObjectPtr<UCurveFloat> motionCurve = this.MotionCurve;
		string curvePath = ((motionCurve != null) ? motionCurve.ToAssetPathName() : null) ?? "";
		characterActionComponent.StartBounceFromAns(this.Time, this.Height, curvePath);
		characterCatapultComponent.StartCatapult();
		return true;
	}

	// Token: 0x06001A9A RID: 6810 RVA: 0x0008EF38 File Offset: 0x0008D138
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyBounce) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyBounce.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001A9B RID: 6811 RVA: 0x0008EFC8 File Offset: 0x0008D1C8
	protected override string GetNotifyName_Implementation()
	{
		return "弹射运动";
	}

	// Token: 0x06001A9C RID: 6812 RVA: 0x0008EFCF File Offset: 0x0008D1CF
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyBounce._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBounce.TsAnimNotifyBounce_C");
		}
		return TsAnimNotifyBounce._ClassPtr;
	}

	// Token: 0x06001A9D RID: 6813 RVA: 0x0008EFF4 File Offset: 0x0008D1F4
	public TsAnimNotifyBounce() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyBounce.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001A9E RID: 6814 RVA: 0x0008F01C File Offset: 0x0008D21C
	public TsAnimNotifyBounce(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyBounce.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001A9F RID: 6815 RVA: 0x0008F04F File Offset: 0x0008D24F
	protected TsAnimNotifyBounce(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001AA0 RID: 6816 RVA: 0x0008F058 File Offset: 0x0008D258
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001AA1 RID: 6817 RVA: 0x0008F08B File Offset: 0x0008D28B
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001138 RID: 4408
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBounce.TsAnimNotifyBounce_C";

	// Token: 0x04001139 RID: 4409
	private static IntPtr _ClassPtr;

	// Token: 0x0400113A RID: 4410
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400113B RID: 4411
	private static int __PropertyOffset_Time;

	// Token: 0x0400113C RID: 4412
	private static int __PropertyOffset_Height;

	// Token: 0x0400113D RID: 4413
	private static int __PropertyOffset_MotionCurve;

	// Token: 0x0400113E RID: 4414
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UCurveFloat> _MotionCurve;
}
