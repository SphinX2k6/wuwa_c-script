using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E12 RID: 11794
public class __CounterAttackEffectData_SubClassMissingExportProxy : __CounterAttackEffectData_InheritProxy
{
	// Token: 0x0601C70C RID: 116492 RVA: 0x008BA99C File Offset: 0x008B8B9C
	[NullableContext(1)]
	protected __CounterAttackEffectData_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CounterAttackEffectData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C70D RID: 116493 RVA: 0x008BA9CF File Offset: 0x008B8BCF
	protected __CounterAttackEffectData_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
