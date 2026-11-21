using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EDB RID: 11995
public class __TsRecordEffect_InheritProxy : TsRecordEffect
{
	// Token: 0x0601C940 RID: 117056 RVA: 0x008BE44C File Offset: 0x008BC64C
	[NullableContext(1)]
	public __TsRecordEffect_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsRecordEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C941 RID: 117057 RVA: 0x008BE47F File Offset: 0x008BC67F
	protected __TsRecordEffect_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C942 RID: 117058 RVA: 0x008BE488 File Offset: 0x008BC688
	protected override void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601C943 RID: 117059 RVA: 0x008BE490 File Offset: 0x008BC690
	protected unsafe override void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		base.ReceiveEndPlay_Implementation(endPlayReason);
	}

	// Token: 0x0601C944 RID: 117060 RVA: 0x008BE4B0 File Offset: 0x008BC6B0
	protected unsafe override void __CPPCALL_ReceiveTick_Implementation(AActor.__ReceiveTick_FunctionParams* __Params)
	{
		base.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x0601C945 RID: 117061 RVA: 0x008BE4BE File Offset: 0x008BC6BE
	protected override void __CPPCALL_OnPlay_Implementation()
	{
		base.OnPlay_Implementation();
	}

	// Token: 0x0601C946 RID: 117062 RVA: 0x008BE4C6 File Offset: 0x008BC6C6
	protected override void __CPPCALL_OnStop_Implementation()
	{
		base.OnStop_Implementation();
	}
}
