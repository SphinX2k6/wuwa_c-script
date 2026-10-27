using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003960 RID: 14688
public class __TsRecordEffect_InheritProxy : TsRecordEffect
{
	// Token: 0x0601ECB7 RID: 126135 RVA: 0x0089B7D8 File Offset: 0x008999D8
	[NullableContext(1)]
	public __TsRecordEffect_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsRecordEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601ECB8 RID: 126136 RVA: 0x0089B80B File Offset: 0x00899A0B
	protected __TsRecordEffect_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601ECB9 RID: 126137 RVA: 0x0089B814 File Offset: 0x00899A14
	protected override void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601ECBA RID: 126138 RVA: 0x0089B81C File Offset: 0x00899A1C
	protected unsafe override void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		base.ReceiveEndPlay_Implementation(endPlayReason);
	}

	// Token: 0x0601ECBB RID: 126139 RVA: 0x0089B83C File Offset: 0x00899A3C
	protected unsafe override void __CPPCALL_ReceiveTick_Implementation(AActor.__ReceiveTick_FunctionParams* __Params)
	{
		base.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x0601ECBC RID: 126140 RVA: 0x0089B84A File Offset: 0x00899A4A
	protected override void __CPPCALL_OnPlay_Implementation()
	{
		base.OnPlay_Implementation();
	}

	// Token: 0x0601ECBD RID: 126141 RVA: 0x0089B852 File Offset: 0x00899A52
	protected override void __CPPCALL_OnStop_Implementation()
	{
		base.OnStop_Implementation();
	}
}
