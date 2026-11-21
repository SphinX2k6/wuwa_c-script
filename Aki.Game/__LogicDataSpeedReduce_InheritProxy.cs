using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E89 RID: 11913
public class __LogicDataSpeedReduce_InheritProxy : LogicDataSpeedReduce
{
	// Token: 0x0601C850 RID: 116816 RVA: 0x008BCB5C File Offset: 0x008BAD5C
	[NullableContext(1)]
	public __LogicDataSpeedReduce_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSpeedReduce.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C851 RID: 116817 RVA: 0x008BCB8F File Offset: 0x008BAD8F
	protected __LogicDataSpeedReduce_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
