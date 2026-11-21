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

// Token: 0x020003A3 RID: 931
[UClass("/Game/Aki/TypeScript/Game/LevelGamePlay/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/LevelGamePlay/TsLevelGamePlayBridge.TsLevelGamePlayBridge_C")]
public class TsLevelGamePlayBridge : UObject, IUnrealUObject, IUnrealObject
{
	// Token: 0x0600337B RID: 13179 RVA: 0x00127BF0 File Offset: 0x00125DF0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void UpdateGamePlayTimerBridge(float inGamePlayTimerId, float inActivate)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsLevelGamePlayBridge) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("UpdateGamePlayTimerBridge"), TsLevelGamePlayBridge.StaticClass(), out intPtr, out num))
		{
			this.UpdateGamePlayTimerBridge_Implementation(inGamePlayTimerId, inActivate);
			return;
		}
		TsLevelGamePlayBridge.__UpdateGamePlayTimerBridge_FunctionParams* ptr = stackalloc TsLevelGamePlayBridge.__UpdateGamePlayTimerBridge_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsLevelGamePlayBridge.__UpdateGamePlayTimerBridge_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->inGamePlayTimerId = inGamePlayTimerId;
		ptr->inActivate = inActivate;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0600337C RID: 13180 RVA: 0x00127C84 File Offset: 0x00125E84
	protected void UpdateGamePlayTimerBridge_Implementation(float inGamePlayTimerId, float inActivate)
	{
	}

	// Token: 0x0600337D RID: 13181 RVA: 0x00127C88 File Offset: 0x00125E88
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual float GetDragonPoolState(float inDragonId)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsLevelGamePlayBridge) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetDragonPoolState"), TsLevelGamePlayBridge.StaticClass(), out intPtr, out num))
		{
			return this.GetDragonPoolState_Implementation(inDragonId);
		}
		TsLevelGamePlayBridge.__GetDragonPoolState_FunctionParams* ptr = stackalloc TsLevelGamePlayBridge.__GetDragonPoolState_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsLevelGamePlayBridge.__GetDragonPoolState_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->inDragonId = inDragonId;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		float _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0600337E RID: 13182 RVA: 0x00127D1A File Offset: 0x00125F1A
	protected float GetDragonPoolState_Implementation(float inDragonId)
	{
		return (float)MingSuModel.Instance.GetTargetDragonPoolActiveById((int)inDragonId);
	}

	// Token: 0x0600337F RID: 13183 RVA: 0x00127D2C File Offset: 0x00125F2C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ApplyScanEffect(AActor inActor)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsLevelGamePlayBridge) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ApplyScanEffect"), TsLevelGamePlayBridge.StaticClass(), out intPtr, out num))
		{
			this.ApplyScanEffect_Implementation(inActor);
			return;
		}
		TsLevelGamePlayBridge.__ApplyScanEffect_FunctionParams* ptr = stackalloc TsLevelGamePlayBridge.__ApplyScanEffect_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsLevelGamePlayBridge.__ApplyScanEffect_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->inActor) = ((inActor != null) ? inActor.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06003380 RID: 13184 RVA: 0x00127DC6 File Offset: 0x00125FC6
	[NullableContext(1)]
	protected void ApplyScanEffect_Implementation(AActor inActor)
	{
		LevelGamePlayController.Instance.HandleScanResponse(inActor, 0);
	}

	// Token: 0x06003381 RID: 13185 RVA: 0x00127DD8 File Offset: 0x00125FD8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void ClearAllScanEffects()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsLevelGamePlayBridge) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ClearAllScanEffects"), TsLevelGamePlayBridge.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ClearAllScanEffects_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06003382 RID: 13186 RVA: 0x00127E31 File Offset: 0x00126031
	protected void ClearAllScanEffects_Implementation()
	{
		LevelGamePlayController.Instance.HandleClearAllScanEffect();
	}

	// Token: 0x06003383 RID: 13187 RVA: 0x00127E3D File Offset: 0x0012603D
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsLevelGamePlayBridge._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/LevelGamePlay/TsLevelGamePlayBridge.TsLevelGamePlayBridge_C");
		}
		return TsLevelGamePlayBridge._ClassPtr;
	}

	// Token: 0x06003384 RID: 13188 RVA: 0x00127E64 File Offset: 0x00126064
	public TsLevelGamePlayBridge() : this(BuiltinUtils.AllocNativeUObject(TsLevelGamePlayBridge.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06003385 RID: 13189 RVA: 0x00127E8C File Offset: 0x0012608C
	[NullableContext(1)]
	public TsLevelGamePlayBridge(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsLevelGamePlayBridge.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06003386 RID: 13190 RVA: 0x00127EBF File Offset: 0x001260BF
	protected TsLevelGamePlayBridge(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06003387 RID: 13191 RVA: 0x00127EC8 File Offset: 0x001260C8
	protected unsafe virtual void __CPPCALL_UpdateGamePlayTimerBridge_Implementation(TsLevelGamePlayBridge.__UpdateGamePlayTimerBridge_FunctionParams* __Params)
	{
		this.UpdateGamePlayTimerBridge_Implementation(__Params->inGamePlayTimerId, __Params->inActivate);
	}

	// Token: 0x06003388 RID: 13192 RVA: 0x00127EDC File Offset: 0x001260DC
	protected unsafe virtual void __CPPCALL_GetDragonPoolState_Implementation(TsLevelGamePlayBridge.__GetDragonPoolState_FunctionParams* __Params)
	{
		__Params->__Result = this.GetDragonPoolState_Implementation(__Params->inDragonId);
	}

	// Token: 0x06003389 RID: 13193 RVA: 0x00127EF0 File Offset: 0x001260F0
	protected unsafe virtual void __CPPCALL_ApplyScanEffect_Implementation(TsLevelGamePlayBridge.__ApplyScanEffect_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->inActor);
		this.ApplyScanEffect_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0600338A RID: 13194 RVA: 0x00127F10 File Offset: 0x00126110
	protected virtual void __CPPCALL_ClearAllScanEffects_Implementation()
	{
		this.ClearAllScanEffects_Implementation();
	}

	// Token: 0x04002C25 RID: 11301
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/LevelGamePlay/TsLevelGamePlayBridge.TsLevelGamePlayBridge_C";

	// Token: 0x04002C26 RID: 11302
	private static IntPtr _ClassPtr;

	// Token: 0x04002C27 RID: 11303
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x020066E5 RID: 26341
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __UpdateGamePlayTimerBridge_FunctionParams
	{
		// Token: 0x04021FFE RID: 139262
		[FieldOffset(0)]
		public float inGamePlayTimerId;

		// Token: 0x04021FFF RID: 139263
		[FieldOffset(4)]
		public float inActivate;
	}

	// Token: 0x020066E6 RID: 26342
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __GetDragonPoolState_FunctionParams
	{
		// Token: 0x04022000 RID: 139264
		[FieldOffset(0)]
		public float inDragonId;

		// Token: 0x04022001 RID: 139265
		[FieldOffset(4)]
		public float __Result;
	}

	// Token: 0x020066E7 RID: 26343
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __ApplyScanEffect_FunctionParams
	{
		// Token: 0x04022002 RID: 139266
		[FieldOffset(0)]
		public IntPtr inActor;
	}
}
