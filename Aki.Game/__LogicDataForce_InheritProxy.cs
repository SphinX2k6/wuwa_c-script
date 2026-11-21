using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E77 RID: 11895
public class __LogicDataForce_InheritProxy : LogicDataForce
{
	// Token: 0x0601C82C RID: 116780 RVA: 0x008BC724 File Offset: 0x008BA924
	[NullableContext(1)]
	public __LogicDataForce_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataForce.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C82D RID: 116781 RVA: 0x008BC757 File Offset: 0x008BA957
	protected __LogicDataForce_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
