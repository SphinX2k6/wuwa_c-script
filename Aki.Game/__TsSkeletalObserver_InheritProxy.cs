using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E45 RID: 11845
public class __TsSkeletalObserver_InheritProxy : TsSkeletalObserver
{
	// Token: 0x0601C7A0 RID: 116640 RVA: 0x008BB970 File Offset: 0x008B9B70
	[NullableContext(1)]
	public __TsSkeletalObserver_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSkeletalObserver.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C7A1 RID: 116641 RVA: 0x008BB9A3 File Offset: 0x008B9BA3
	protected __TsSkeletalObserver_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C7A2 RID: 116642 RVA: 0x008BB9AC File Offset: 0x008B9BAC
	protected unsafe override void __CPPCALL_ReceiveTick_Implementation(AActor.__ReceiveTick_FunctionParams* __Params)
	{
		base.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}
}
