using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E67 RID: 11879
public class __LogicDataAdditiveAccelerate_InheritProxy : LogicDataAdditiveAccelerate
{
	// Token: 0x0601C80C RID: 116748 RVA: 0x008BC364 File Offset: 0x008BA564
	[NullableContext(1)]
	public __LogicDataAdditiveAccelerate_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataAdditiveAccelerate.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C80D RID: 116749 RVA: 0x008BC397 File Offset: 0x008BA597
	protected __LogicDataAdditiveAccelerate_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
