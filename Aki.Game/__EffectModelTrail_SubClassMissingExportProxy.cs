using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F24 RID: 12068
public class __EffectModelTrail_SubClassMissingExportProxy : __EffectModelTrail_InheritProxy
{
	// Token: 0x0601CA64 RID: 117348 RVA: 0x008C0490 File Offset: 0x008BE690
	[NullableContext(1)]
	protected __EffectModelTrail_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelTrail.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA65 RID: 117349 RVA: 0x008C04C3 File Offset: 0x008BE6C3
	protected __EffectModelTrail_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
