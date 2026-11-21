using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F03 RID: 12035
public class __EffectClusteredStuffSettings_InheritProxy : EffectClusteredStuffSettings
{
	// Token: 0x0601CA22 RID: 117282 RVA: 0x008BFCD4 File Offset: 0x008BDED4
	[NullableContext(1)]
	public __EffectClusteredStuffSettings_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectClusteredStuffSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA23 RID: 117283 RVA: 0x008BFD07 File Offset: 0x008BDF07
	protected __EffectClusteredStuffSettings_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
