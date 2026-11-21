using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F02 RID: 12034
public class __EffectClusteredStuffDefaultSettings_SubClassMissingExportProxy : __EffectClusteredStuffDefaultSettings_InheritProxy
{
	// Token: 0x0601CA20 RID: 117280 RVA: 0x008BFC98 File Offset: 0x008BDE98
	[NullableContext(1)]
	protected __EffectClusteredStuffDefaultSettings_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectClusteredStuffDefaultSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA21 RID: 117281 RVA: 0x008BFCCB File Offset: 0x008BDECB
	protected __EffectClusteredStuffDefaultSettings_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
