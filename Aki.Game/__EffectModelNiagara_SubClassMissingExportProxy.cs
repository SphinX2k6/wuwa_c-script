using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F1A RID: 12058
public class __EffectModelNiagara_SubClassMissingExportProxy : __EffectModelNiagara_InheritProxy
{
	// Token: 0x0601CA50 RID: 117328 RVA: 0x008C0238 File Offset: 0x008BE438
	[NullableContext(1)]
	protected __EffectModelNiagara_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelNiagara.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA51 RID: 117329 RVA: 0x008C026B File Offset: 0x008BE46B
	protected __EffectModelNiagara_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
