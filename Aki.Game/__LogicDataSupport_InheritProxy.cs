using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E93 RID: 11923
public class __LogicDataSupport_InheritProxy : LogicDataSupport
{
	// Token: 0x0601C864 RID: 116836 RVA: 0x008BCDB4 File Offset: 0x008BAFB4
	[NullableContext(1)]
	public __LogicDataSupport_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSupport.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C865 RID: 116837 RVA: 0x008BCDE7 File Offset: 0x008BAFE7
	protected __LogicDataSupport_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
