using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E4D RID: 11853
public class __TsUiSceneDangoActor_InheritProxy : TsUiSceneDangoActor
{
	// Token: 0x0601C7B7 RID: 116663 RVA: 0x008BBBA4 File Offset: 0x008B9DA4
	[NullableContext(1)]
	public __TsUiSceneDangoActor_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiSceneDangoActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C7B8 RID: 116664 RVA: 0x008BBBD7 File Offset: 0x008B9DD7
	protected __TsUiSceneDangoActor_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C7B9 RID: 116665 RVA: 0x008BBBE0 File Offset: 0x008B9DE0
	protected unsafe override void __CPPCALL_ReceiveTick_Implementation(AActor.__ReceiveTick_FunctionParams* __Params)
	{
		base.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}
}
