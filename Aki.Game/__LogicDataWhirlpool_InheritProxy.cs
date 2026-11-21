using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E95 RID: 11925
public class __LogicDataWhirlpool_InheritProxy : LogicDataWhirlpool
{
	// Token: 0x0601C868 RID: 116840 RVA: 0x008BCE2C File Offset: 0x008BB02C
	[NullableContext(1)]
	public __LogicDataWhirlpool_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataWhirlpool.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C869 RID: 116841 RVA: 0x008BCE5F File Offset: 0x008BB05F
	protected __LogicDataWhirlpool_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
