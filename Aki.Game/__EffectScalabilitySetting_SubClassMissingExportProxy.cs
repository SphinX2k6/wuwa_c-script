using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F26 RID: 12070
public class __EffectScalabilitySetting_SubClassMissingExportProxy : __EffectScalabilitySetting_InheritProxy
{
	// Token: 0x0601CA68 RID: 117352 RVA: 0x008C0508 File Offset: 0x008BE708
	[NullableContext(1)]
	protected __EffectScalabilitySetting_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectScalabilitySetting.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA69 RID: 117353 RVA: 0x008C053B File Offset: 0x008BE73B
	protected __EffectScalabilitySetting_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
