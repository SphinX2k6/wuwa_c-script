using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038B2 RID: 14514
public class __TsLevelGamePlayBridge_InheritProxy : TsLevelGamePlayBridge
{
	// Token: 0x0601EA7E RID: 125566 RVA: 0x00896108 File Offset: 0x00894308
	[NullableContext(1)]
	public __TsLevelGamePlayBridge_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsLevelGamePlayBridge.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EA7F RID: 125567 RVA: 0x0089613B File Offset: 0x0089433B
	protected __TsLevelGamePlayBridge_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EA80 RID: 125568 RVA: 0x00896144 File Offset: 0x00894344
	protected unsafe override void __CPPCALL_UpdateGamePlayTimerBridge_Implementation(TsLevelGamePlayBridge.__UpdateGamePlayTimerBridge_FunctionParams* __Params)
	{
		base.UpdateGamePlayTimerBridge_Implementation(__Params->inGamePlayTimerId, __Params->inActivate);
	}

	// Token: 0x0601EA81 RID: 125569 RVA: 0x00896158 File Offset: 0x00894358
	protected unsafe override void __CPPCALL_GetDragonPoolState_Implementation(TsLevelGamePlayBridge.__GetDragonPoolState_FunctionParams* __Params)
	{
		__Params->__Result = base.GetDragonPoolState_Implementation(__Params->inDragonId);
	}

	// Token: 0x0601EA82 RID: 125570 RVA: 0x0089616C File Offset: 0x0089436C
	protected unsafe override void __CPPCALL_ApplyScanEffect_Implementation(TsLevelGamePlayBridge.__ApplyScanEffect_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->inActor);
		base.ApplyScanEffect_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601EA83 RID: 125571 RVA: 0x0089618C File Offset: 0x0089438C
	protected override void __CPPCALL_ClearAllScanEffects_Implementation()
	{
		base.ClearAllScanEffects_Implementation();
	}
}
