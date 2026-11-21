using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002ECF RID: 11983
public class __TsTriggerVolume_InheritProxy : TsTriggerVolume
{
	// Token: 0x0601C913 RID: 117011 RVA: 0x008BDFAC File Offset: 0x008BC1AC
	[NullableContext(1)]
	public __TsTriggerVolume_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTriggerVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C914 RID: 117012 RVA: 0x008BDFDF File Offset: 0x008BC1DF
	protected __TsTriggerVolume_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C915 RID: 117013 RVA: 0x008BDFE8 File Offset: 0x008BC1E8
	protected override void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601C916 RID: 117014 RVA: 0x008BDFF0 File Offset: 0x008BC1F0
	protected unsafe override void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		base.ReceiveEndPlay_Implementation(endPlayReason);
	}

	// Token: 0x0601C917 RID: 117015 RVA: 0x008BE010 File Offset: 0x008BC210
	protected unsafe override void __CPPCALL_ReceiveTick_Implementation(AActor.__ReceiveTick_FunctionParams* __Params)
	{
		base.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x0601C918 RID: 117016 RVA: 0x008BE01E File Offset: 0x008BC21E
	protected unsafe override void __CPPCALL_AddBuffInner_Implementation(TsTriggerVolume.__AddBuffInner_FunctionParams* __Params)
	{
		base.AddBuffInner_Implementation(__Params->buffId);
	}

	// Token: 0x0601C919 RID: 117017 RVA: 0x008BE02C File Offset: 0x008BC22C
	protected override void __CPPCALL_TryReportSelfBuffDamageLog_Implementation()
	{
		base.TryReportSelfBuffDamageLog_Implementation();
	}
}
