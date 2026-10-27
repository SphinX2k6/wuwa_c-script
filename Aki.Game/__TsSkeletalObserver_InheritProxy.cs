using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038CC RID: 14540
public class __TsSkeletalObserver_InheritProxy : TsSkeletalObserver
{
	// Token: 0x0601EAE6 RID: 125670 RVA: 0x008973DC File Offset: 0x008955DC
	[NullableContext(1)]
	public __TsSkeletalObserver_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSkeletalObserver.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EAE7 RID: 125671 RVA: 0x0089740F File Offset: 0x0089560F
	protected __TsSkeletalObserver_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EAE8 RID: 125672 RVA: 0x00897418 File Offset: 0x00895618
	protected unsafe override void __CPPCALL_ReceiveTick_Implementation(AActor.__ReceiveTick_FunctionParams* __Params)
	{
		base.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}
}
