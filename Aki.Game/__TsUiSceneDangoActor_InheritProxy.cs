using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038D4 RID: 14548
public class __TsUiSceneDangoActor_InheritProxy : TsUiSceneDangoActor
{
	// Token: 0x0601EAFE RID: 125694 RVA: 0x00897688 File Offset: 0x00895888
	[NullableContext(1)]
	public __TsUiSceneDangoActor_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiSceneDangoActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EAFF RID: 125695 RVA: 0x008976BB File Offset: 0x008958BB
	protected __TsUiSceneDangoActor_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EB00 RID: 125696 RVA: 0x008976C4 File Offset: 0x008958C4
	protected unsafe override void __CPPCALL_ReceiveTick_Implementation(AActor.__ReceiveTick_FunctionParams* __Params)
	{
		base.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}
}
