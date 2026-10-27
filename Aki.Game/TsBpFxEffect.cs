using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02003325 RID: 13093
[UClass("/Game/Aki/TypeScript/Game/Recorder/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Recorder/TsBpFxEffect.TsBpFxEffect_C")]
public class TsBpFxEffect : AActor, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002790 RID: 10128
	// (get) Token: 0x0601C855 RID: 116821 RVA: 0x007FFE1F File Offset: 0x007FE01F
	// (set) Token: 0x0601C856 RID: 116822 RVA: 0x007FFE2F File Offset: 0x007FE02F
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

	// Token: 0x17002791 RID: 10129
	// (get) Token: 0x0601C857 RID: 116823 RVA: 0x007FFE40 File Offset: 0x007FE040
	// (set) Token: 0x0601C858 RID: 116824 RVA: 0x007FFE50 File Offset: 0x007FE050
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

	// Token: 0x17002792 RID: 10130
	// (get) Token: 0x0601C859 RID: 116825 RVA: 0x007FFE61 File Offset: 0x007FE061
	// (set) Token: 0x0601C85A RID: 116826 RVA: 0x007FFE75 File Offset: 0x007FE075
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

	// Token: 0x0601C85B RID: 116827 RVA: 0x007FFE8C File Offset: 0x007FE08C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveBeginPlay()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveBeginPlay"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601C85C RID: 116828 RVA: 0x007FFEFC File Offset: 0x007FE0FC
	protected virtual void ReceiveBeginPlay_Implementation()
	{
		this.OnPlay();
	}

	// Token: 0x0601C85D RID: 116829 RVA: 0x007FFF04 File Offset: 0x007FE104
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ReceiveEndPlay(TEnumAsByte<EEndPlayReason> endPlayReason)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveEndPlay"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBpFxEffect.__ReceiveEndPlay_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBpFxEffect.__ReceiveEndPlay_FunctionParams*)ptr + 15L / (long)sizeof(TsBpFxEffect.__ReceiveEndPlay_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->endPlayReason = endPlayReason;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601C85E RID: 116830 RVA: 0x007FFF7A File Offset: 0x007FE17A
	protected virtual void ReceiveEndPlay_Implementation(TEnumAsByte<EEndPlayReason> endPlayReason)
	{
		this.OnStop();
	}

	// Token: 0x0601C85F RID: 116831 RVA: 0x007FFF84 File Offset: 0x007FE184
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void TryRecord()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("TryRecord"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601C860 RID: 116832 RVA: 0x007FFFF4 File Offset: 0x007FE1F4
	protected void TryRecord_Implementation()
	{
		this.OnPlay();
	}

	// Token: 0x0601C861 RID: 116833 RVA: 0x007FFFFC File Offset: 0x007FE1FC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void AddAutoFloatTrack(FName propertyName)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AddAutoFloatTrack"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBpFxEffect.__AddAutoFloatTrack_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBpFxEffect.__AddAutoFloatTrack_FunctionParams*)ptr + 15L / (long)sizeof(TsBpFxEffect.__AddAutoFloatTrack_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->propertyName = propertyName;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601C862 RID: 116834 RVA: 0x00800072 File Offset: 0x007FE272
	protected void AddAutoFloatTrack_Implementation(FName propertyName)
	{
	}

	// Token: 0x0601C863 RID: 116835 RVA: 0x00800074 File Offset: 0x007FE274
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void AddAutoVectorTrack(FName propertyName)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AddAutoVectorTrack"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBpFxEffect.__AddAutoVectorTrack_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBpFxEffect.__AddAutoVectorTrack_FunctionParams*)ptr + 15L / (long)sizeof(TsBpFxEffect.__AddAutoVectorTrack_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->propertyName = propertyName;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601C864 RID: 116836 RVA: 0x008000EA File Offset: 0x007FE2EA
	protected virtual void AddAutoVectorTrack_Implementation(FName propertyName)
	{
	}

	// Token: 0x0601C865 RID: 116837 RVA: 0x008000EC File Offset: 0x007FE2EC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void AddAutoObjectTrack(FName propertyName)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AddAutoObjectTrack"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBpFxEffect.__AddAutoObjectTrack_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBpFxEffect.__AddAutoObjectTrack_FunctionParams*)ptr + 15L / (long)sizeof(TsBpFxEffect.__AddAutoObjectTrack_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->propertyName = propertyName;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601C866 RID: 116838 RVA: 0x00800162 File Offset: 0x007FE362
	protected virtual void AddAutoObjectTrack_Implementation(FName propertyName)
	{
	}

	// Token: 0x0601C867 RID: 116839 RVA: 0x00800164 File Offset: 0x007FE364
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void OnRecordStart()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnRecordStart"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601C868 RID: 116840 RVA: 0x008001D4 File Offset: 0x007FE3D4
	protected virtual void OnRecordStart_Implementation()
	{
	}

	// Token: 0x0601C869 RID: 116841 RVA: 0x008001D8 File Offset: 0x007FE3D8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void OnRecordTick(float deltaSeconds)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnRecordTick"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBpFxEffect.__OnRecordTick_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBpFxEffect.__OnRecordTick_FunctionParams*)ptr + 15L / (long)sizeof(TsBpFxEffect.__OnRecordTick_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->deltaSeconds = deltaSeconds;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601C86A RID: 116842 RVA: 0x0080024E File Offset: 0x007FE44E
	protected virtual void OnRecordTick_Implementation(float deltaSeconds)
	{
	}

	// Token: 0x0601C86B RID: 116843 RVA: 0x00800250 File Offset: 0x007FE450
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void OnRecordStop()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnRecordStop"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601C86C RID: 116844 RVA: 0x008002C0 File Offset: 0x007FE4C0
	protected virtual void OnRecordStop_Implementation()
	{
	}

	// Token: 0x0601C86D RID: 116845 RVA: 0x008002C2 File Offset: 0x007FE4C2
	private void OnPlay()
	{
	}

	// Token: 0x0601C86E RID: 116846 RVA: 0x008002C4 File Offset: 0x007FE4C4
	private void OnStop()
	{
	}

	// Token: 0x0601C86F RID: 116847 RVA: 0x008002C6 File Offset: 0x007FE4C6
	public void ClearRecorder()
	{
		this.RecorderShadow = null;
	}

	// Token: 0x0601C870 RID: 116848 RVA: 0x008002CF File Offset: 0x007FE4CF
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsBpFxEffect._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Recorder/TsBpFxEffect.TsBpFxEffect_C");
		}
		return TsBpFxEffect._ClassPtr;
	}

	// Token: 0x0601C871 RID: 116849 RVA: 0x008002F4 File Offset: 0x007FE4F4
	public TsBpFxEffect() : this(BuiltinUtils.AllocNativeUObject(TsBpFxEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601C872 RID: 116850 RVA: 0x0080031C File Offset: 0x007FE51C
	[NullableContext(1)]
	public TsBpFxEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBpFxEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C873 RID: 116851 RVA: 0x0080034F File Offset: 0x007FE54F
	protected TsBpFxEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x17002793 RID: 10131
	// (get) Token: 0x0601C874 RID: 116852 RVA: 0x00800358 File Offset: 0x007FE558
	[Nullable(1)]
	public unsafe FPointerToUberGraphFrame UberGraphFrame
	{
		[NullableContext(1)]
		get
		{
			return *(base.NativePtr + (IntPtr)TsBpFxEffect.__PropertyOffset_UberGraphFrame);
		}
	}

	// Token: 0x17002794 RID: 10132
	// (get) Token: 0x0601C875 RID: 116853 RVA: 0x00800368 File Offset: 0x007FE568
	[Nullable(2)]
	public unsafe USceneComponent DefaultSceneRoot
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + TsBpFxEffect.__PropertyOffset_DefaultSceneRoot);
		}
	}

	// Token: 0x0601C876 RID: 116854 RVA: 0x0080037C File Offset: 0x007FE57C
	protected virtual void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		this.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601C877 RID: 116855 RVA: 0x00800384 File Offset: 0x007FE584
	protected unsafe virtual void __CPPCALL_ReceiveEndPlay_Implementation(TsBpFxEffect.__ReceiveEndPlay_FunctionParams* __Params)
	{
		this.ReceiveEndPlay_Implementation(__Params->endPlayReason);
	}

	// Token: 0x0601C878 RID: 116856 RVA: 0x00800392 File Offset: 0x007FE592
	protected virtual void __CPPCALL_TryRecord_Implementation()
	{
		this.TryRecord_Implementation();
	}

	// Token: 0x0601C879 RID: 116857 RVA: 0x0080039A File Offset: 0x007FE59A
	protected unsafe virtual void __CPPCALL_AddAutoFloatTrack_Implementation(TsBpFxEffect.__AddAutoFloatTrack_FunctionParams* __Params)
	{
		this.AddAutoFloatTrack_Implementation(__Params->propertyName);
	}

	// Token: 0x0601C87A RID: 116858 RVA: 0x008003A8 File Offset: 0x007FE5A8
	protected unsafe virtual void __CPPCALL_AddAutoVectorTrack_Implementation(TsBpFxEffect.__AddAutoVectorTrack_FunctionParams* __Params)
	{
		this.AddAutoVectorTrack_Implementation(__Params->propertyName);
	}

	// Token: 0x0601C87B RID: 116859 RVA: 0x008003B6 File Offset: 0x007FE5B6
	protected unsafe virtual void __CPPCALL_AddAutoObjectTrack_Implementation(TsBpFxEffect.__AddAutoObjectTrack_FunctionParams* __Params)
	{
		this.AddAutoObjectTrack_Implementation(__Params->propertyName);
	}

	// Token: 0x0601C87C RID: 116860 RVA: 0x008003C4 File Offset: 0x007FE5C4
	protected virtual void __CPPCALL_OnRecordStart_Implementation()
	{
		this.OnRecordStart_Implementation();
	}

	// Token: 0x0601C87D RID: 116861 RVA: 0x008003CC File Offset: 0x007FE5CC
	protected unsafe virtual void __CPPCALL_OnRecordTick_Implementation(TsBpFxEffect.__OnRecordTick_FunctionParams* __Params)
	{
		this.OnRecordTick_Implementation(__Params->deltaSeconds);
	}

	// Token: 0x0601C87E RID: 116862 RVA: 0x008003DA File Offset: 0x007FE5DA
	protected virtual void __CPPCALL_OnRecordStop_Implementation()
	{
		this.OnRecordStop_Implementation();
	}

	// Token: 0x0400E298 RID: 58008
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Recorder/TsBpFxEffect.TsBpFxEffect_C";

	// Token: 0x0400E299 RID: 58009
	private static IntPtr _ClassPtr;

	// Token: 0x0400E29A RID: 58010
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E29B RID: 58011
	private static int __PropertyOffset_UberGraphFrame;

	// Token: 0x0400E29C RID: 58012
	private static int __PropertyOffset_DefaultSceneRoot;

	// Token: 0x0400E29D RID: 58013
	private static int __PropertyOffset_IsRecorderActor;

	// Token: 0x0400E29E RID: 58014
	private static int __PropertyOffset_RecordTime;

	// Token: 0x0400E29F RID: 58015
	private static int __PropertyOffset_RecorderShadow;

	// Token: 0x0200979D RID: 38813
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected new ref struct __ReceiveEndPlay_FunctionParams
	{
		// Token: 0x04030751 RID: 198481
		[FieldOffset(0)]
		public TEnumAsByte<EEndPlayReason> endPlayReason;
	}

	// Token: 0x0200979E RID: 38814
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 12)]
	protected ref struct __AddAutoFloatTrack_FunctionParams
	{
		// Token: 0x04030752 RID: 198482
		[FieldOffset(0)]
		public FName propertyName;
	}

	// Token: 0x0200979F RID: 38815
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 12)]
	protected ref struct __AddAutoVectorTrack_FunctionParams
	{
		// Token: 0x04030753 RID: 198483
		[FieldOffset(0)]
		public FName propertyName;
	}

	// Token: 0x020097A0 RID: 38816
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 12)]
	protected ref struct __AddAutoObjectTrack_FunctionParams
	{
		// Token: 0x04030754 RID: 198484
		[FieldOffset(0)]
		public FName propertyName;
	}

	// Token: 0x020097A1 RID: 38817
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __OnRecordTick_FunctionParams
	{
		// Token: 0x04030755 RID: 198485
		[FieldOffset(0)]
		public float deltaSeconds;
	}
}
