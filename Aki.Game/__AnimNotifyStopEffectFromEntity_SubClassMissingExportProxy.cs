using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003985 RID: 14725
public class __AnimNotifyStopEffectFromEntity_SubClassMissingExportProxy : __AnimNotifyStopEffectFromEntity_InheritProxy
{
	// Token: 0x0601EDEF RID: 126447 RVA: 0x0089FD64 File Offset: 0x0089DF64
	[NullableContext(1)]
	protected __AnimNotifyStopEffectFromEntity_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyStopEffectFromEntity.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EDF0 RID: 126448 RVA: 0x0089FD97 File Offset: 0x0089DF97
	protected __AnimNotifyStopEffectFromEntity_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
