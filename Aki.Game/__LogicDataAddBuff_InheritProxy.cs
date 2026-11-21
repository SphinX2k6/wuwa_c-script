using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E65 RID: 11877
public class __LogicDataAddBuff_InheritProxy : LogicDataAddBuff
{
	// Token: 0x0601C808 RID: 116744 RVA: 0x008BC2EC File Offset: 0x008BA4EC
	[NullableContext(1)]
	public __LogicDataAddBuff_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataAddBuff.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C809 RID: 116745 RVA: 0x008BC31F File Offset: 0x008BA51F
	protected __LogicDataAddBuff_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
