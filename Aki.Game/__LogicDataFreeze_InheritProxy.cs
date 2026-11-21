using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E79 RID: 11897
public class __LogicDataFreeze_InheritProxy : LogicDataFreeze
{
	// Token: 0x0601C830 RID: 116784 RVA: 0x008BC79C File Offset: 0x008BA99C
	[NullableContext(1)]
	public __LogicDataFreeze_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataFreeze.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C831 RID: 116785 RVA: 0x008BC7CF File Offset: 0x008BA9CF
	protected __LogicDataFreeze_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
