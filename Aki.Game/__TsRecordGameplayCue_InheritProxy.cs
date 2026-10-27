using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003962 RID: 14690
public class __TsRecordGameplayCue_InheritProxy : TsRecordGameplayCue
{
	// Token: 0x0601ECC0 RID: 126144 RVA: 0x0089B898 File Offset: 0x00899A98
	[NullableContext(1)]
	public __TsRecordGameplayCue_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsRecordGameplayCue.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601ECC1 RID: 126145 RVA: 0x0089B8CB File Offset: 0x00899ACB
	protected __TsRecordGameplayCue_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601ECC2 RID: 126146 RVA: 0x0089B8D4 File Offset: 0x00899AD4
	protected override void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601ECC3 RID: 126147 RVA: 0x0089B8DC File Offset: 0x00899ADC
	protected unsafe override void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		base.ReceiveEndPlay_Implementation(endPlayReason);
	}

	// Token: 0x0601ECC4 RID: 126148 RVA: 0x0089B8FC File Offset: 0x00899AFC
	protected override void __CPPCALL_OnPlay_Implementation()
	{
		base.OnPlay_Implementation();
	}

	// Token: 0x0601ECC5 RID: 126149 RVA: 0x0089B904 File Offset: 0x00899B04
	protected override void __CPPCALL_OnStop_Implementation()
	{
		base.OnStop_Implementation();
	}

	// Token: 0x0601ECC6 RID: 126150 RVA: 0x0089B90C File Offset: 0x00899B0C
	protected unsafe override void __CPPCALL_ReceiveTick_Implementation(AActor.__ReceiveTick_FunctionParams* __Params)
	{
		base.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}
}
