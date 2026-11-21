using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E91 RID: 11921
public class __LogicDataSummonRandom_InheritProxy : LogicDataSummonRandom
{
	// Token: 0x0601C860 RID: 116832 RVA: 0x008BCD3C File Offset: 0x008BAF3C
	[NullableContext(1)]
	public __LogicDataSummonRandom_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSummonRandom.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C861 RID: 116833 RVA: 0x008BCD6F File Offset: 0x008BAF6F
	protected __LogicDataSummonRandom_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
