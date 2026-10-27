using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003954 RID: 14676
public class __TsTriggerVolume_InheritProxy : TsTriggerVolume
{
	// Token: 0x0601EC7E RID: 126078 RVA: 0x0089ADB0 File Offset: 0x00898FB0
	[NullableContext(1)]
	public __TsTriggerVolume_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTriggerVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EC7F RID: 126079 RVA: 0x0089ADE3 File Offset: 0x00898FE3
	protected __TsTriggerVolume_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EC80 RID: 126080 RVA: 0x0089ADEC File Offset: 0x00898FEC
	protected override void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601EC81 RID: 126081 RVA: 0x0089ADF4 File Offset: 0x00898FF4
	protected unsafe override void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		base.ReceiveEndPlay_Implementation(endPlayReason);
	}

	// Token: 0x0601EC82 RID: 126082 RVA: 0x0089AE14 File Offset: 0x00899014
	protected unsafe override void __CPPCALL_ReceiveTick_Implementation(AActor.__ReceiveTick_FunctionParams* __Params)
	{
		base.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x0601EC83 RID: 126083 RVA: 0x0089AE22 File Offset: 0x00899022
	protected unsafe override void __CPPCALL_AddBuffInner_Implementation(TsTriggerVolume.__AddBuffInner_FunctionParams* __Params)
	{
		base.AddBuffInner_Implementation(__Params->buffId);
	}

	// Token: 0x0601EC84 RID: 126084 RVA: 0x0089AE30 File Offset: 0x00899030
	protected override void __CPPCALL_TryReportSelfBuffDamageLog_Implementation()
	{
		base.TryReportSelfBuffDamageLog_Implementation();
	}
}
