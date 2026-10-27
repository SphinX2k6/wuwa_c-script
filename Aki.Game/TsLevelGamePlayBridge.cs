using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.MingSu;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000EEE RID: 3822
[UClass("/Game/Aki/TypeScript/Game/LevelGamePlay/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/LevelGamePlay/TsLevelGamePlayBridge.TsLevelGamePlayBridge_C")]
public class TsLevelGamePlayBridge : UObject, IUnrealUObject, IUnrealObject
{
	// Token: 0x06005FE5 RID: 24549 RVA: 0x0011FD98 File Offset: 0x0011DF98
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void UpdateGamePlayTimerBridge(float inGamePlayTimerId, float inActivate)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("UpdateGamePlayTimerBridge"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsLevelGamePlayBridge.__UpdateGamePlayTimerBridge_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsLevelGamePlayBridge.__UpdateGamePlayTimerBridge_FunctionParams*)ptr + 15L / (long)sizeof(TsLevelGamePlayBridge.__UpdateGamePlayTimerBridge_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->inGamePlayTimerId = inGamePlayTimerId;
			ptr2->inActivate = inActivate;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06005FE6 RID: 24550 RVA: 0x0011FE15 File Offset: 0x0011E015
	protected void UpdateGamePlayTimerBridge_Implementation(float inGamePlayTimerId, float inActivate)
	{
	}

	// Token: 0x06005FE7 RID: 24551 RVA: 0x0011FE18 File Offset: 0x0011E018
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual float GetDragonPoolState(float inDragonId)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetDragonPoolState"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsLevelGamePlayBridge.__GetDragonPoolState_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsLevelGamePlayBridge.__GetDragonPoolState_FunctionParams*)ptr + 15L / (long)sizeof(TsLevelGamePlayBridge.__GetDragonPoolState_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->inDragonId = inDragonId;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		float _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06005FE8 RID: 24552 RVA: 0x0011FE94 File Offset: 0x0011E094
	protected float GetDragonPoolState_Implementation(float inDragonId)
	{
		return (float)MingSuModel.Instance.GetTargetDragonPoolActiveById((int)inDragonId);
	}

	// Token: 0x06005FE9 RID: 24553 RVA: 0x0011FEA4 File Offset: 0x0011E0A4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ApplyScanEffect(AActor inActor)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ApplyScanEffect"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsLevelGamePlayBridge.__ApplyScanEffect_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsLevelGamePlayBridge.__ApplyScanEffect_FunctionParams*)ptr + 15L / (long)sizeof(TsLevelGamePlayBridge.__ApplyScanEffect_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->inActor) = ((inActor != null) ? inActor.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06005FEA RID: 24554 RVA: 0x0011FF28 File Offset: 0x0011E128
	[NullableContext(1)]
	protected void ApplyScanEffect_Implementation(AActor inActor)
	{
		LevelGamePlayController.Instance.HandleScanResponse(inActor, 0);
	}

	// Token: 0x06005FEB RID: 24555 RVA: 0x0011FF38 File Offset: 0x0011E138
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ClearAllScanEffects()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ClearAllScanEffects"), out num);
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

	// Token: 0x06005FEC RID: 24556 RVA: 0x0011FFA8 File Offset: 0x0011E1A8
	protected void ClearAllScanEffects_Implementation()
	{
		LevelGamePlayController.Instance.HandleClearAllScanEffect();
	}

	// Token: 0x06005FED RID: 24557 RVA: 0x0011FFB4 File Offset: 0x0011E1B4
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsLevelGamePlayBridge._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/LevelGamePlay/TsLevelGamePlayBridge.TsLevelGamePlayBridge_C");
		}
		return TsLevelGamePlayBridge._ClassPtr;
	}

	// Token: 0x06005FEE RID: 24558 RVA: 0x0011FFD8 File Offset: 0x0011E1D8
	public TsLevelGamePlayBridge() : this(BuiltinUtils.AllocNativeUObject(TsLevelGamePlayBridge.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06005FEF RID: 24559 RVA: 0x00120000 File Offset: 0x0011E200
	[NullableContext(1)]
	public TsLevelGamePlayBridge(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsLevelGamePlayBridge.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06005FF0 RID: 24560 RVA: 0x00120033 File Offset: 0x0011E233
	protected TsLevelGamePlayBridge(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06005FF1 RID: 24561 RVA: 0x0012003C File Offset: 0x0011E23C
	protected unsafe virtual void __CPPCALL_UpdateGamePlayTimerBridge_Implementation(TsLevelGamePlayBridge.__UpdateGamePlayTimerBridge_FunctionParams* __Params)
	{
		this.UpdateGamePlayTimerBridge_Implementation(__Params->inGamePlayTimerId, __Params->inActivate);
	}

	// Token: 0x06005FF2 RID: 24562 RVA: 0x00120050 File Offset: 0x0011E250
	protected unsafe virtual void __CPPCALL_GetDragonPoolState_Implementation(TsLevelGamePlayBridge.__GetDragonPoolState_FunctionParams* __Params)
	{
		__Params->__Result = this.GetDragonPoolState_Implementation(__Params->inDragonId);
	}

	// Token: 0x06005FF3 RID: 24563 RVA: 0x00120064 File Offset: 0x0011E264
	protected unsafe virtual void __CPPCALL_ApplyScanEffect_Implementation(TsLevelGamePlayBridge.__ApplyScanEffect_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->inActor);
		this.ApplyScanEffect_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x06005FF4 RID: 24564 RVA: 0x00120084 File Offset: 0x0011E284
	protected virtual void __CPPCALL_ClearAllScanEffects_Implementation()
	{
		this.ClearAllScanEffects_Implementation();
	}

	// Token: 0x04002B8C RID: 11148
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/LevelGamePlay/TsLevelGamePlayBridge.TsLevelGamePlayBridge_C";

	// Token: 0x04002B8D RID: 11149
	private static IntPtr _ClassPtr;

	// Token: 0x04002B8E RID: 11150
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x02007551 RID: 30033
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __UpdateGamePlayTimerBridge_FunctionParams
	{
		// Token: 0x04026CB3 RID: 158899
		[FieldOffset(0)]
		public float inGamePlayTimerId;

		// Token: 0x04026CB4 RID: 158900
		[FieldOffset(4)]
		public float inActivate;
	}

	// Token: 0x02007552 RID: 30034
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __GetDragonPoolState_FunctionParams
	{
		// Token: 0x04026CB5 RID: 158901
		[FieldOffset(0)]
		public float inDragonId;

		// Token: 0x04026CB6 RID: 158902
		[FieldOffset(4)]
		public float __Result;
	}

	// Token: 0x02007553 RID: 30035
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __ApplyScanEffect_FunctionParams
	{
		// Token: 0x04026CB7 RID: 158903
		[FieldOffset(0)]
		public IntPtr inActor;
	}
}
