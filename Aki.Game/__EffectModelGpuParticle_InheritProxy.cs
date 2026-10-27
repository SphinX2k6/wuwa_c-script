using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003994 RID: 14740
public class __EffectModelGpuParticle_InheritProxy : EffectModelGpuParticle
{
	// Token: 0x0601EE0D RID: 126477 RVA: 0x008A00E8 File Offset: 0x0089E2E8
	[NullableContext(1)]
	public __EffectModelGpuParticle_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelGpuParticle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE0E RID: 126478 RVA: 0x008A011B File Offset: 0x0089E31B
	protected __EffectModelGpuParticle_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
