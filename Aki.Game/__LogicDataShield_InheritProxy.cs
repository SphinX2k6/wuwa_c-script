using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E83 RID: 11907
public class __LogicDataShield_InheritProxy : LogicDataShield
{
	// Token: 0x0601C844 RID: 116804 RVA: 0x008BC9F4 File Offset: 0x008BABF4
	[NullableContext(1)]
	public __LogicDataShield_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataShield.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C845 RID: 116805 RVA: 0x008BCA27 File Offset: 0x008BAC27
	protected __LogicDataShield_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
