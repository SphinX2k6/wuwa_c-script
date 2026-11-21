using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F0E RID: 12046
public class __EffectModelGhost_SubClassMissingExportProxy : __EffectModelGhost_InheritProxy
{
	// Token: 0x0601CA38 RID: 117304 RVA: 0x008BFF68 File Offset: 0x008BE168
	[NullableContext(1)]
	protected __EffectModelGhost_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelGhost.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA39 RID: 117305 RVA: 0x008BFF9B File Offset: 0x008BE19B
	protected __EffectModelGhost_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
