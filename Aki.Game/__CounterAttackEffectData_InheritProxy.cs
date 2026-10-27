using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003898 RID: 14488
public class __CounterAttackEffectData_InheritProxy : CounterAttackEffectData
{
	// Token: 0x0601EA2C RID: 125484 RVA: 0x00895288 File Offset: 0x00893488
	[NullableContext(1)]
	public __CounterAttackEffectData_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CounterAttackEffectData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EA2D RID: 125485 RVA: 0x008952BB File Offset: 0x008934BB
	protected __CounterAttackEffectData_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
