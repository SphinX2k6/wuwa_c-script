using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E2B RID: 11819
public class __TsLevelGamePlayBridge_InheritProxy : TsLevelGamePlayBridge
{
	// Token: 0x0601C74F RID: 116559 RVA: 0x008BB15C File Offset: 0x008B935C
	[NullableContext(1)]
	public __TsLevelGamePlayBridge_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsLevelGamePlayBridge.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C750 RID: 116560 RVA: 0x008BB18F File Offset: 0x008B938F
	protected __TsLevelGamePlayBridge_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C751 RID: 116561 RVA: 0x008BB198 File Offset: 0x008B9398
	protected unsafe override void __CPPCALL_UpdateGamePlayTimerBridge_Implementation(TsLevelGamePlayBridge.__UpdateGamePlayTimerBridge_FunctionParams* __Params)
	{
		base.UpdateGamePlayTimerBridge_Implementation(__Params->inGamePlayTimerId, __Params->inActivate);
	}

	// Token: 0x0601C752 RID: 116562 RVA: 0x008BB1AC File Offset: 0x008B93AC
	protected unsafe override void __CPPCALL_GetDragonPoolState_Implementation(TsLevelGamePlayBridge.__GetDragonPoolState_FunctionParams* __Params)
	{
		__Params->__Result = base.GetDragonPoolState_Implementation(__Params->inDragonId);
	}

	// Token: 0x0601C753 RID: 116563 RVA: 0x008BB1C0 File Offset: 0x008B93C0
	protected unsafe override void __CPPCALL_ApplyScanEffect_Implementation(TsLevelGamePlayBridge.__ApplyScanEffect_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->inActor);
		base.ApplyScanEffect_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601C754 RID: 116564 RVA: 0x008BB1E0 File Offset: 0x008B93E0
	protected override void __CPPCALL_ClearAllScanEffects_Implementation()
	{
		base.ClearAllScanEffects_Implementation();
	}
}
