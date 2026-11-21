using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E0D RID: 11789
public class __TsStartupPlayerController_InheritProxy : TsStartupPlayerController
{
	// Token: 0x0601C702 RID: 116482 RVA: 0x008BA870 File Offset: 0x008B8A70
	[NullableContext(1)]
	public __TsStartupPlayerController_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsStartupPlayerController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C703 RID: 116483 RVA: 0x008BA8A3 File Offset: 0x008B8AA3
	protected __TsStartupPlayerController_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
