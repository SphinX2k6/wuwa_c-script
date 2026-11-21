using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EBB RID: 11963
public class __TsBoxRangeItem_InheritProxy : TsBoxRangeItem
{
	// Token: 0x0601C8D0 RID: 116944 RVA: 0x008BD86C File Offset: 0x008BBA6C
	[NullableContext(1)]
	public __TsBoxRangeItem_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBoxRangeItem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C8D1 RID: 116945 RVA: 0x008BD89F File Offset: 0x008BBA9F
	protected __TsBoxRangeItem_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C8D2 RID: 116946 RVA: 0x008BD8A8 File Offset: 0x008BBAA8
	protected override void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601C8D3 RID: 116947 RVA: 0x008BD8B0 File Offset: 0x008BBAB0
	protected unsafe override void __CPPCALL_ReceiveTick_Implementation(AActor.__ReceiveTick_FunctionParams* __Params)
	{
		base.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x0601C8D4 RID: 116948 RVA: 0x008BD8C0 File Offset: 0x008BBAC0
	protected unsafe override void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		base.ReceiveEndPlay_Implementation(endPlayReason);
	}
}
