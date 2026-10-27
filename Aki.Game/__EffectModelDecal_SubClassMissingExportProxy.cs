using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003991 RID: 14737
public class __EffectModelDecal_SubClassMissingExportProxy : __EffectModelDecal_InheritProxy
{
	// Token: 0x0601EE07 RID: 126471 RVA: 0x008A0034 File Offset: 0x0089E234
	[NullableContext(1)]
	protected __EffectModelDecal_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelDecal.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE08 RID: 126472 RVA: 0x008A0067 File Offset: 0x0089E267
	protected __EffectModelDecal_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
