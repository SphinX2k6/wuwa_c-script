using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F2E RID: 12078
public class __EffectViewComponent_SubClassMissingExportProxy : __EffectViewComponent_InheritProxy
{
	// Token: 0x0601CA7C RID: 117372 RVA: 0x008C071C File Offset: 0x008BE91C
	[NullableContext(1)]
	protected __EffectViewComponent_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectViewComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA7D RID: 117373 RVA: 0x008C074F File Offset: 0x008BE94F
	protected __EffectViewComponent_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
