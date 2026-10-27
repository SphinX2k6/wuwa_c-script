using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003995 RID: 14741
public class __EffectModelGpuParticle_SubClassMissingExportProxy : __EffectModelGpuParticle_InheritProxy
{
	// Token: 0x0601EE0F RID: 126479 RVA: 0x008A0124 File Offset: 0x0089E324
	[NullableContext(1)]
	protected __EffectModelGpuParticle_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelGpuParticle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE10 RID: 126480 RVA: 0x008A0157 File Offset: 0x0089E357
	protected __EffectModelGpuParticle_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
