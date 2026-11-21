using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F14 RID: 12052
public class __EffectModelLight_SubClassMissingExportProxy : __EffectModelLight_InheritProxy
{
	// Token: 0x0601CA44 RID: 117316 RVA: 0x008C00D0 File Offset: 0x008BE2D0
	[NullableContext(1)]
	protected __EffectModelLight_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelLight.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA45 RID: 117317 RVA: 0x008C0103 File Offset: 0x008BE303
	protected __EffectModelLight_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
