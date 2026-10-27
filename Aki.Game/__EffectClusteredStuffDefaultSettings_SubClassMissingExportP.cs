using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003987 RID: 14727
public class __EffectClusteredStuffDefaultSettings_SubClassMissingExportProxy : __EffectClusteredStuffDefaultSettings_InheritProxy
{
	// Token: 0x0601EDF3 RID: 126451 RVA: 0x0089FDDC File Offset: 0x0089DFDC
	[NullableContext(1)]
	protected __EffectClusteredStuffDefaultSettings_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectClusteredStuffDefaultSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EDF4 RID: 126452 RVA: 0x0089FE0F File Offset: 0x0089E00F
	protected __EffectClusteredStuffDefaultSettings_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
