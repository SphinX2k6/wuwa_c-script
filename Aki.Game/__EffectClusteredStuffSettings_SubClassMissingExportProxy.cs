using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003989 RID: 14729
public class __EffectClusteredStuffSettings_SubClassMissingExportProxy : __EffectClusteredStuffSettings_InheritProxy
{
	// Token: 0x0601EDF7 RID: 126455 RVA: 0x0089FE54 File Offset: 0x0089E054
	[NullableContext(1)]
	protected __EffectClusteredStuffSettings_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectClusteredStuffSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EDF8 RID: 126456 RVA: 0x0089FE87 File Offset: 0x0089E087
	protected __EffectClusteredStuffSettings_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
