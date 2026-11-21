using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F28 RID: 12072
public class __EffectModelMultiEffect_SubClassMissingExportProxy : __EffectModelMultiEffect_InheritProxy
{
	// Token: 0x0601CA6C RID: 117356 RVA: 0x008C0580 File Offset: 0x008BE780
	[NullableContext(1)]
	protected __EffectModelMultiEffect_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelMultiEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA6D RID: 117357 RVA: 0x008C05B3 File Offset: 0x008BE7B3
	protected __EffectModelMultiEffect_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
