using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F10 RID: 12048
public class __EffectModelGpuParticle_SubClassMissingExportProxy : __EffectModelGpuParticle_InheritProxy
{
	// Token: 0x0601CA3C RID: 117308 RVA: 0x008BFFE0 File Offset: 0x008BE1E0
	[NullableContext(1)]
	protected __EffectModelGpuParticle_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelGpuParticle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA3D RID: 117309 RVA: 0x008C0013 File Offset: 0x008BE213
	protected __EffectModelGpuParticle_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
