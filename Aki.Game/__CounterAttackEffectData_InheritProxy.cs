using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E11 RID: 11793
public class __CounterAttackEffectData_InheritProxy : CounterAttackEffectData
{
	// Token: 0x0601C70A RID: 116490 RVA: 0x008BA960 File Offset: 0x008B8B60
	[NullableContext(1)]
	public __CounterAttackEffectData_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CounterAttackEffectData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C70B RID: 116491 RVA: 0x008BA993 File Offset: 0x008B8B93
	protected __CounterAttackEffectData_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
