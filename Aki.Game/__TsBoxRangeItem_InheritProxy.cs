using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003940 RID: 14656
public class __TsBoxRangeItem_InheritProxy : TsBoxRangeItem
{
	// Token: 0x0601EC2A RID: 125994 RVA: 0x00899D4C File Offset: 0x00897F4C
	[NullableContext(1)]
	public __TsBoxRangeItem_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBoxRangeItem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EC2B RID: 125995 RVA: 0x00899D7F File Offset: 0x00897F7F
	protected __TsBoxRangeItem_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EC2C RID: 125996 RVA: 0x00899D88 File Offset: 0x00897F88
	protected override void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601EC2D RID: 125997 RVA: 0x00899D90 File Offset: 0x00897F90
	protected unsafe override void __CPPCALL_ReceiveTick_Implementation(AActor.__ReceiveTick_FunctionParams* __Params)
	{
		base.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x0601EC2E RID: 125998 RVA: 0x00899DA0 File Offset: 0x00897FA0
	protected unsafe override void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		base.ReceiveEndPlay_Implementation(endPlayReason);
	}
}
