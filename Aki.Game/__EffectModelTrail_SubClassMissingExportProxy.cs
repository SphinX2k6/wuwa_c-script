using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039A9 RID: 14761
public class __EffectModelTrail_SubClassMissingExportProxy : __EffectModelTrail_InheritProxy
{
	// Token: 0x0601EE37 RID: 126519 RVA: 0x008A05D4 File Offset: 0x0089E7D4
	[NullableContext(1)]
	protected __EffectModelTrail_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelTrail.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE38 RID: 126520 RVA: 0x008A0607 File Offset: 0x0089E807
	protected __EffectModelTrail_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
