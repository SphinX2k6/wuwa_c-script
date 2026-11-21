using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F0F RID: 12047
public class __EffectModelGpuParticle_InheritProxy : EffectModelGpuParticle
{
	// Token: 0x0601CA3A RID: 117306 RVA: 0x008BFFA4 File Offset: 0x008BE1A4
	[NullableContext(1)]
	public __EffectModelGpuParticle_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelGpuParticle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA3B RID: 117307 RVA: 0x008BFFD7 File Offset: 0x008BE1D7
	protected __EffectModelGpuParticle_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
