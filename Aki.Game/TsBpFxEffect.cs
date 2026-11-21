using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002897 RID: 10391
[UClass("/Game/Aki/TypeScript/Game/Recorder/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Recorder/TsBpFxEffect.TsBpFxEffect_C")]
public class TsBpFxEffect : AActor, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002B2D RID: 11053
	// (get) Token: 0x0601A54E RID: 107854 RVA: 0x008263EB File Offset: 0x008245EB
	// (set) Token: 0x0601A54F RID: 107855 RVA: 0x008263FB File Offset: 0x008245FB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsRecorderActor
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsBpFxEffect.__PropertyOffset_IsRecorderActor) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsBpFxEffect.__PropertyOffset_IsRecorderActor) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002B2E RID: 11054
	// (get) Token: 0x0601A550 RID: 107856 RVA: 0x0082640C File Offset: 0x0082460C
	// (set) Token: 0x0601A551 RID: 107857 RVA: 0x0082641C File Offset: 0x0082461C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float RecordTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsBpFxEffect.__PropertyOffset_RecordTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsBpFxEffect.__PropertyOffset_RecordTime) = value;
		}
	}

	// Token: 0x17002B2F RID: 11055
	// (get) Token: 0x0601A552 RID: 107858 RVA: 0x0082642D File Offset: 0x0082462D
	// (set) Token: 0x0601A553 RID: 107859 RVA: 0x00826441 File Offset: 0x00824641
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe TsBpFxEffect RecorderShadow
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<TsBpFxEffect>(base.NativePtr / (IntPtr)sizeof(void*) + TsBpFxEffect.__PropertyOffset_RecorderShadow);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsBpFxEffect.__PropertyOffset_RecorderShadow, value);
		}
	}

	// Token: 0x0601A554 RID: 107860 RVA: 0x00826458 File Offset: 0x00824658
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void ReceiveBeginPlay()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsBpFxEffect) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveBeginPlay"), TsBpFxEffect.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ReceiveBeginPlay_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601A555 RID: 107861 RVA: 0x008264B1 File Offset: 0x008246B1
	protected void ReceiveBeginPlay_Implementation()
	{
		this.OnPlay();
	}

	// Token: 0x0601A556 RID: 107862 RVA: 0x008264BC File Offset: 0x008246BC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ReceiveEndPlay(TEnumAsByte<EEndPlayReason> endPlayReason)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsBpFxEffect) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveEndPlay"), TsBpFxEffect.StaticClass(), out intPtr, out num))
		{
			this.ReceiveEndPlay_Implementation(endPlayReason);
			return;
		}
		TsBpFxEffect.__ReceiveEndPlay_FunctionParams* ptr = stackalloc TsBpFxEffect.__ReceiveEndPlay_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsBpFxEffect.__ReceiveEndPlay_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->endPlayReason = endPlayReason;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601A557 RID: 107863 RVA: 0x00826548 File Offset: 0x00824748
	protected virtual void ReceiveEndPlay_Implementation(TEnumAsByte<EEndPlayReason> endPlayReason)
	{
		this.OnStop();
	}

	// Token: 0x0601A558 RID: 107864 RVA: 0x00826550 File Offset: 0x00824750
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void TryRecord()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsBpFxEffect) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("TryRecord"), TsBpFxEffect.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.TryRecord_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601A559 RID: 107865 RVA: 0x008265A9 File Offset: 0x008247A9
	protected void TryRecord_Implementation()
	{
		this.OnPlay();
	}

	// Token: 0x0601A55A RID: 107866 RVA: 0x008265B4 File Offset: 0x008247B4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void AddAutoFloatTrack(FName propertyName)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsBpFxEffect) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AddAutoFloatTrack"), TsBpFxEffect.StaticClass(), out intPtr, out num))
		{
			this.AddAutoFloatTrack_Implementation(propertyName);
			return;
		}
		TsBpFxEffect.__AddAutoFloatTrack_FunctionParams* ptr = stackalloc TsBpFxEffect.__AddAutoFloatTrack_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsBpFxEffect.__AddAutoFloatTrack_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->propertyName = propertyName;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601A55B RID: 107867 RVA: 0x00826640 File Offset: 0x00824840
	protected void AddAutoFloatTrack_Implementation(FName propertyName)
	{
	}

	// Token: 0x0601A55C RID: 107868 RVA: 0x00826644 File Offset: 0x00824844
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void AddAutoVectorTrack(FName propertyName)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsBpFxEffect) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AddAutoVectorTrack"), TsBpFxEffect.StaticClass(), out intPtr, out num))
		{
			this.AddAutoVectorTrack_Implementation(propertyName);
			return;
		}
		TsBpFxEffect.__AddAutoVectorTrack_FunctionParams* ptr = stackalloc TsBpFxEffect.__AddAutoVectorTrack_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsBpFxEffect.__AddAutoVectorTrack_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->propertyName = propertyName;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601A55D RID: 107869 RVA: 0x008266D0 File Offset: 0x008248D0
	protected virtual void AddAutoVectorTrack_Implementation(FName propertyName)
	{
	}

	// Token: 0x0601A55E RID: 107870 RVA: 0x008266D4 File Offset: 0x008248D4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void AddAutoObjectTrack(FName propertyName)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsBpFxEffect) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AddAutoObjectTrack"), TsBpFxEffect.StaticClass(), out intPtr, out num))
		{
			this.AddAutoObjectTrack_Implementation(propertyName);
			return;
		}
		TsBpFxEffect.__AddAutoObjectTrack_FunctionParams* ptr = stackalloc TsBpFxEffect.__AddAutoObjectTrack_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsBpFxEffect.__AddAutoObjectTrack_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->propertyName = propertyName;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601A55F RID: 107871 RVA: 0x00826760 File Offset: 0x00824960
	protected virtual void AddAutoObjectTrack_Implementation(FName propertyName)
	{
	}

	// Token: 0x0601A560 RID: 107872 RVA: 0x00826764 File Offset: 0x00824964
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void OnRecordStart()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsBpFxEffect) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnRecordStart"), TsBpFxEffect.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.OnRecordStart_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601A561 RID: 107873 RVA: 0x008267BD File Offset: 0x008249BD
	protected virtual void OnRecordStart_Implementation()
	{
	}

	// Token: 0x0601A562 RID: 107874 RVA: 0x008267C0 File Offset: 0x008249C0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void OnRecordTick(float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsBpFxEffect) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnRecordTick"), TsBpFxEffect.StaticClass(), out intPtr, out num))
		{
			this.OnRecordTick_Implementation(deltaSeconds);
			return;
		}
		TsBpFxEffect.__OnRecordTick_FunctionParams* ptr = stackalloc TsBpFxEffect.__OnRecordTick_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsBpFxEffect.__OnRecordTick_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->deltaSeconds = deltaSeconds;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601A563 RID: 107875 RVA: 0x0082684C File Offset: 0x00824A4C
	protected virtual void OnRecordTick_Implementation(float deltaSeconds)
	{
	}

	// Token: 0x0601A564 RID: 107876 RVA: 0x00826850 File Offset: 0x00824A50
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void OnRecordStop()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsBpFxEffect) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnRecordStop"), TsBpFxEffect.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.OnRecordStop_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601A565 RID: 107877 RVA: 0x008268A9 File Offset: 0x00824AA9
	protected virtual void OnRecordStop_Implementation()
	{
	}

	// Token: 0x0601A566 RID: 107878 RVA: 0x008268AB File Offset: 0x00824AAB
	private void OnPlay()
	{
	}

	// Token: 0x0601A567 RID: 107879 RVA: 0x008268AD File Offset: 0x00824AAD
	private void OnStop()
	{
	}

	// Token: 0x0601A568 RID: 107880 RVA: 0x008268AF File Offset: 0x00824AAF
	public void ClearRecorder()
	{
		this.RecorderShadow = null;
	}

	// Token: 0x0601A569 RID: 107881 RVA: 0x008268B8 File Offset: 0x00824AB8
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsBpFxEffect._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Recorder/TsBpFxEffect.TsBpFxEffect_C");
		}
		return TsBpFxEffect._ClassPtr;
	}

	// Token: 0x0601A56A RID: 107882 RVA: 0x008268DC File Offset: 0x00824ADC
	public TsBpFxEffect() : this(BuiltinUtils.AllocNativeUObject(TsBpFxEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601A56B RID: 107883 RVA: 0x00826904 File Offset: 0x00824B04
	[NullableContext(1)]
	public TsBpFxEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBpFxEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601A56C RID: 107884 RVA: 0x00826937 File Offset: 0x00824B37
	protected TsBpFxEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x17002B30 RID: 11056
	// (get) Token: 0x0601A56D RID: 107885 RVA: 0x00826940 File Offset: 0x00824B40
	[Nullable(2)]
	public unsafe USceneComponent DefaultSceneRoot
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + TsBpFxEffect.__PropertyOffset_DefaultSceneRoot);
		}
	}

	// Token: 0x0601A56E RID: 107886 RVA: 0x00826954 File Offset: 0x00824B54
	protected virtual void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		this.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601A56F RID: 107887 RVA: 0x0082695C File Offset: 0x00824B5C
	protected unsafe virtual void __CPPCALL_ReceiveEndPlay_Implementation(TsBpFxEffect.__ReceiveEndPlay_FunctionParams* __Params)
	{
		this.ReceiveEndPlay_Implementation(__Params->endPlayReason);
	}

	// Token: 0x0601A570 RID: 107888 RVA: 0x0082696A File Offset: 0x00824B6A
	protected virtual void __CPPCALL_TryRecord_Implementation()
	{
		this.TryRecord_Implementation();
	}

	// Token: 0x0601A571 RID: 107889 RVA: 0x00826972 File Offset: 0x00824B72
	protected unsafe virtual void __CPPCALL_AddAutoFloatTrack_Implementation(TsBpFxEffect.__AddAutoFloatTrack_FunctionParams* __Params)
	{
		this.AddAutoFloatTrack_Implementation(__Params->propertyName);
	}

	// Token: 0x0601A572 RID: 107890 RVA: 0x00826980 File Offset: 0x00824B80
	protected unsafe virtual void __CPPCALL_AddAutoVectorTrack_Implementation(TsBpFxEffect.__AddAutoVectorTrack_FunctionParams* __Params)
	{
		this.AddAutoVectorTrack_Implementation(__Params->propertyName);
	}

	// Token: 0x0601A573 RID: 107891 RVA: 0x0082698E File Offset: 0x00824B8E
	protected unsafe virtual void __CPPCALL_AddAutoObjectTrack_Implementation(TsBpFxEffect.__AddAutoObjectTrack_FunctionParams* __Params)
	{
		this.AddAutoObjectTrack_Implementation(__Params->propertyName);
	}

	// Token: 0x0601A574 RID: 107892 RVA: 0x0082699C File Offset: 0x00824B9C
	protected virtual void __CPPCALL_OnRecordStart_Implementation()
	{
		this.OnRecordStart_Implementation();
	}

	// Token: 0x0601A575 RID: 107893 RVA: 0x008269A4 File Offset: 0x00824BA4
	protected unsafe virtual void __CPPCALL_OnRecordTick_Implementation(TsBpFxEffect.__OnRecordTick_FunctionParams* __Params)
	{
		this.OnRecordTick_Implementation(__Params->deltaSeconds);
	}

	// Token: 0x0601A576 RID: 107894 RVA: 0x008269B2 File Offset: 0x00824BB2
	protected virtual void __CPPCALL_OnRecordStop_Implementation()
	{
		this.OnRecordStop_Implementation();
	}

	// Token: 0x0400E749 RID: 59209
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Recorder/TsBpFxEffect.TsBpFxEffect_C";

	// Token: 0x0400E74A RID: 59210
	private static IntPtr _ClassPtr;

	// Token: 0x0400E74B RID: 59211
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E74C RID: 59212
	private static int __PropertyOffset_DefaultSceneRoot;

	// Token: 0x0400E74D RID: 59213
	private static int __PropertyOffset_IsRecorderActor;

	// Token: 0x0400E74E RID: 59214
	private static int __PropertyOffset_RecordTime;

	// Token: 0x0400E74F RID: 59215
	private static int __PropertyOffset_RecorderShadow;

	// Token: 0x020089C0 RID: 35264
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected new ref struct __ReceiveEndPlay_FunctionParams
	{
		// Token: 0x0402BDDE RID: 179678
		[FieldOffset(0)]
		public TEnumAsByte<EEndPlayReason> endPlayReason;
	}

	// Token: 0x020089C1 RID: 35265
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 12)]
	protected ref struct __AddAutoFloatTrack_FunctionParams
	{
		// Token: 0x0402BDDF RID: 179679
		[FieldOffset(0)]
		public FName propertyName;
	}

	// Token: 0x020089C2 RID: 35266
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 12)]
	protected ref struct __AddAutoVectorTrack_FunctionParams
	{
		// Token: 0x0402BDE0 RID: 179680
		[FieldOffset(0)]
		public FName propertyName;
	}

	// Token: 0x020089C3 RID: 35267
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 12)]
	protected ref struct __AddAutoObjectTrack_FunctionParams
	{
		// Token: 0x0402BDE1 RID: 179681
		[FieldOffset(0)]
		public FName propertyName;
	}

	// Token: 0x020089C4 RID: 35268
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __OnRecordTick_FunctionParams
	{
		// Token: 0x0402BDE2 RID: 179682
		[FieldOffset(0)]
		public float deltaSeconds;
	}
}
