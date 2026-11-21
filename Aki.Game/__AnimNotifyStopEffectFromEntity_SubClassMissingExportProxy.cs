using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F00 RID: 12032
public class __AnimNotifyStopEffectFromEntity_SubClassMissingExportProxy : __AnimNotifyStopEffectFromEntity_InheritProxy
{
	// Token: 0x0601CA1C RID: 117276 RVA: 0x008BFC20 File Offset: 0x008BDE20
	[NullableContext(1)]
	protected __AnimNotifyStopEffectFromEntity_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyStopEffectFromEntity.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA1D RID: 117277 RVA: 0x008BFC53 File Offset: 0x008BDE53
	protected __AnimNotifyStopEffectFromEntity_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
