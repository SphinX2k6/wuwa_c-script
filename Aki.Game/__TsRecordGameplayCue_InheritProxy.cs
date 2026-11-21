using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EDD RID: 11997
public class __TsRecordGameplayCue_InheritProxy : TsRecordGameplayCue
{
	// Token: 0x0601C949 RID: 117065 RVA: 0x008BE50C File Offset: 0x008BC70C
	[NullableContext(1)]
	public __TsRecordGameplayCue_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsRecordGameplayCue.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C94A RID: 117066 RVA: 0x008BE53F File Offset: 0x008BC73F
	protected __TsRecordGameplayCue_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C94B RID: 117067 RVA: 0x008BE548 File Offset: 0x008BC748
	protected override void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601C94C RID: 117068 RVA: 0x008BE550 File Offset: 0x008BC750
	protected unsafe override void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		base.ReceiveEndPlay_Implementation(endPlayReason);
	}

	// Token: 0x0601C94D RID: 117069 RVA: 0x008BE570 File Offset: 0x008BC770
	protected override void __CPPCALL_OnPlay_Implementation()
	{
		base.OnPlay_Implementation();
	}

	// Token: 0x0601C94E RID: 117070 RVA: 0x008BE578 File Offset: 0x008BC778
	protected override void __CPPCALL_OnStop_Implementation()
	{
		base.OnStop_Implementation();
	}

	// Token: 0x0601C94F RID: 117071 RVA: 0x008BE580 File Offset: 0x008BC780
	protected unsafe override void __CPPCALL_ReceiveTick_Implementation(AActor.__ReceiveTick_FunctionParams* __Params)
	{
		base.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}
}
