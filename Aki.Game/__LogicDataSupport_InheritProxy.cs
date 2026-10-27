using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003918 RID: 14616
public class __LogicDataSupport_InheritProxy : LogicDataSupport
{
	// Token: 0x0601EBA8 RID: 125864 RVA: 0x00898898 File Offset: 0x00896A98
	[NullableContext(1)]
	public __LogicDataSupport_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSupport.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EBA9 RID: 125865 RVA: 0x008988CB File Offset: 0x00896ACB
	protected __LogicDataSupport_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
