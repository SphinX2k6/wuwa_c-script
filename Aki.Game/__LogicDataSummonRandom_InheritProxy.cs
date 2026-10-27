using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003916 RID: 14614
public class __LogicDataSummonRandom_InheritProxy : LogicDataSummonRandom
{
	// Token: 0x0601EBA4 RID: 125860 RVA: 0x00898820 File Offset: 0x00896A20
	[NullableContext(1)]
	public __LogicDataSummonRandom_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSummonRandom.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EBA5 RID: 125861 RVA: 0x00898853 File Offset: 0x00896A53
	protected __LogicDataSummonRandom_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
