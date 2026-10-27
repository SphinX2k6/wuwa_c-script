using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003999 RID: 14745
public class __EffectModelLight_SubClassMissingExportProxy : __EffectModelLight_InheritProxy
{
	// Token: 0x0601EE17 RID: 126487 RVA: 0x008A0214 File Offset: 0x0089E414
	[NullableContext(1)]
	protected __EffectModelLight_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelLight.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE18 RID: 126488 RVA: 0x008A0247 File Offset: 0x0089E447
	protected __EffectModelLight_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
