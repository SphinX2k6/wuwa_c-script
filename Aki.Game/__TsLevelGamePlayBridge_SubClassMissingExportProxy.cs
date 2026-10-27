using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038B3 RID: 14515
[NullableContext(1)]
[Nullable(0)]
public class __TsLevelGamePlayBridge_SubClassMissingExportProxy : __TsLevelGamePlayBridge_InheritProxy
{
	// Token: 0x0601EA84 RID: 125572 RVA: 0x00896194 File Offset: 0x00894394
	protected __TsLevelGamePlayBridge_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsLevelGamePlayBridge.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EA85 RID: 125573 RVA: 0x008961C7 File Offset: 0x008943C7
	protected __TsLevelGamePlayBridge_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EA86 RID: 125574 RVA: 0x008961D0 File Offset: 0x008943D0
	public unsafe override void UpdateGamePlayTimerBridge(float inGamePlayTimerId, float inActivate)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EA87 RID: 125575 RVA: 0x00896250 File Offset: 0x00894450
	public unsafe override float GetDragonPoolState(float inDragonId)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		float _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601EA88 RID: 125576 RVA: 0x008962D0 File Offset: 0x008944D0
	public unsafe override void ApplyScanEffect(AActor inActor)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EA89 RID: 125577 RVA: 0x00896358 File Offset: 0x00894558
	public unsafe override void ClearAllScanEffects()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ClearAllScanEffects"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* ptr2 = null;
		if (num != 0)
		{
			ptr2 = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}
}
