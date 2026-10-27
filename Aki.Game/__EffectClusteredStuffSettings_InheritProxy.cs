using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003988 RID: 14728
public class __EffectClusteredStuffSettings_InheritProxy : EffectClusteredStuffSettings
{
	// Token: 0x0601EDF5 RID: 126453 RVA: 0x0089FE18 File Offset: 0x0089E018
	[NullableContext(1)]
	public __EffectClusteredStuffSettings_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectClusteredStuffSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EDF6 RID: 126454 RVA: 0x0089FE4B File Offset: 0x0089E04B
	protected __EffectClusteredStuffSettings_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
