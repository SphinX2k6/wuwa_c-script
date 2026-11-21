using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F04 RID: 12036
public class __EffectClusteredStuffSettings_SubClassMissingExportProxy : __EffectClusteredStuffSettings_InheritProxy
{
	// Token: 0x0601CA24 RID: 117284 RVA: 0x008BFD10 File Offset: 0x008BDF10
	[NullableContext(1)]
	protected __EffectClusteredStuffSettings_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectClusteredStuffSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA25 RID: 117285 RVA: 0x008BFD43 File Offset: 0x008BDF43
	protected __EffectClusteredStuffSettings_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
