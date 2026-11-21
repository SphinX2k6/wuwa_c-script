using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F0C RID: 12044
public class __EffectModelDecal_SubClassMissingExportProxy : __EffectModelDecal_InheritProxy
{
	// Token: 0x0601CA34 RID: 117300 RVA: 0x008BFEF0 File Offset: 0x008BE0F0
	[NullableContext(1)]
	protected __EffectModelDecal_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelDecal.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA35 RID: 117301 RVA: 0x008BFF23 File Offset: 0x008BE123
	protected __EffectModelDecal_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
