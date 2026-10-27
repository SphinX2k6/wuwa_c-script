using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003899 RID: 14489
public class __CounterAttackEffectData_SubClassMissingExportProxy : __CounterAttackEffectData_InheritProxy
{
	// Token: 0x0601EA2E RID: 125486 RVA: 0x008952C4 File Offset: 0x008934C4
	[NullableContext(1)]
	protected __CounterAttackEffectData_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CounterAttackEffectData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EA2F RID: 125487 RVA: 0x008952F7 File Offset: 0x008934F7
	protected __CounterAttackEffectData_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
