using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F18 RID: 12056
public class __EffectModelNDC_SubClassMissingExportProxy : __EffectModelNDC_InheritProxy
{
	// Token: 0x0601CA4C RID: 117324 RVA: 0x008C01C0 File Offset: 0x008BE3C0
	[NullableContext(1)]
	protected __EffectModelNDC_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelNDC.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA4D RID: 117325 RVA: 0x008C01F3 File Offset: 0x008BE3F3
	protected __EffectModelNDC_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
