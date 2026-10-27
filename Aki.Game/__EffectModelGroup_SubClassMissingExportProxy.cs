using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003997 RID: 14743
public class __EffectModelGroup_SubClassMissingExportProxy : __EffectModelGroup_InheritProxy
{
	// Token: 0x0601EE13 RID: 126483 RVA: 0x008A019C File Offset: 0x0089E39C
	[NullableContext(1)]
	protected __EffectModelGroup_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelGroup.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE14 RID: 126484 RVA: 0x008A01CF File Offset: 0x0089E3CF
	protected __EffectModelGroup_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
