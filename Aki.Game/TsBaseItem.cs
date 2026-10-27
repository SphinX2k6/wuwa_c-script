using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020032A9 RID: 12969
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/SceneItem/BaseItem/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/SceneItem/BaseItem/TsBaseItem.TsBaseItem_C")]
public class TsBaseItem : AActor, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601C111 RID: 114961 RVA: 0x007CDF0C File Offset: 0x007CC10C
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

	// Token: 0x0601C112 RID: 114962 RVA: 0x007CDF7C File Offset: 0x007CC17C
	protected virtual void ReceiveBeginPlay_Implementation()
	{
		this.EntityHandle = ActorUtils.GetEntityByActor(this, true);
		this.DebugComp = this.EntityHandle.Entity.GetComponent<SceneItemDebugComponent>();
	}

	// Token: 0x0601C113 RID: 114963 RVA: 0x007CDFA4 File Offset: 0x007CC1A4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual string GetTagDebugStrings()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetTagDebugStrings"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBaseItem.__GetTagDebugStrings_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBaseItem.__GetTagDebugStrings_FunctionParams*)ptr + 15L / (long)sizeof(TsBaseItem.__GetTagDebugStrings_FunctionParams) & -16L);
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

	// Token: 0x0601C114 RID: 114964 RVA: 0x007CE01F File Offset: 0x007CC21F
	protected string GetTagDebugStrings_Implementation()
	{
		return this.DebugComp.GetTagDebugStrings();
	}

	// Token: 0x0601C115 RID: 114965 RVA: 0x007CE02C File Offset: 0x007CC22C
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsBaseItem._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/SceneItem/BaseItem/TsBaseItem.TsBaseItem_C");
		}
		return TsBaseItem._ClassPtr;
	}

	// Token: 0x0601C116 RID: 114966 RVA: 0x007CE050 File Offset: 0x007CC250
	public TsBaseItem() : this(BuiltinUtils.AllocNativeUObject(TsBaseItem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601C117 RID: 114967 RVA: 0x007CE078 File Offset: 0x007CC278
	public TsBaseItem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBaseItem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C118 RID: 114968 RVA: 0x007CE0AB File Offset: 0x007CC2AB
	protected TsBaseItem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x170026C1 RID: 9921
	// (get) Token: 0x0601C119 RID: 114969 RVA: 0x007CE0B4 File Offset: 0x007CC2B4
	public unsafe FPointerToUberGraphFrame UberGraphFrame
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsBaseItem.__PropertyOffset_UberGraphFrame);
		}
	}

	// Token: 0x170026C2 RID: 9922
	// (get) Token: 0x0601C11A RID: 114970 RVA: 0x007CE0C4 File Offset: 0x007CC2C4
	[Nullable(2)]
	public unsafe USceneComponent DefaultSceneRoot
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + TsBaseItem.__PropertyOffset_DefaultSceneRoot);
		}
	}

	// Token: 0x0601C11B RID: 114971 RVA: 0x007CE0D8 File Offset: 0x007CC2D8
	protected virtual void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		this.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601C11C RID: 114972 RVA: 0x007CE0E0 File Offset: 0x007CC2E0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetTagDebugStrings_Implementation(TsBaseItem.__GetTagDebugStrings_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetTagDebugStrings_Implementation());
	}

	// Token: 0x0400DDDD RID: 56797
	[Nullable(2)]
	public EntityHandle EntityHandle;

	// Token: 0x0400DDDE RID: 56798
	[Nullable(2)]
	private SceneItemDebugComponent DebugComp;

	// Token: 0x0400DDDF RID: 56799
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/SceneItem/BaseItem/TsBaseItem.TsBaseItem_C";

	// Token: 0x0400DDE0 RID: 56800
	private static IntPtr _ClassPtr;

	// Token: 0x0400DDE1 RID: 56801
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400DDE2 RID: 56802
	private static int __PropertyOffset_UberGraphFrame;

	// Token: 0x0400DDE3 RID: 56803
	private static int __PropertyOffset_DefaultSceneRoot;

	// Token: 0x02009740 RID: 38720
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetTagDebugStrings_FunctionParams
	{
		// Token: 0x04030656 RID: 198230
		[FieldOffset(0)]
		public FString __Result;
	}
}
