using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200399D RID: 14749
public class __EffectModelNDC_SubClassMissingExportProxy : __EffectModelNDC_InheritProxy
{
	// Token: 0x0601EE1F RID: 126495 RVA: 0x008A0304 File Offset: 0x0089E504
	[NullableContext(1)]
	protected __EffectModelNDC_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelNDC.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE20 RID: 126496 RVA: 0x008A0337 File Offset: 0x0089E537
	protected __EffectModelNDC_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
