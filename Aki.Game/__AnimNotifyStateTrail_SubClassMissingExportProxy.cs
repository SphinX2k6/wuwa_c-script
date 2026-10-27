using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003983 RID: 14723
public class __AnimNotifyStateTrail_SubClassMissingExportProxy : __AnimNotifyStateTrail_InheritProxy
{
	// Token: 0x0601EDEA RID: 126442 RVA: 0x0089FCB8 File Offset: 0x0089DEB8
	[NullableContext(1)]
	protected __AnimNotifyStateTrail_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyStateTrail.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EDEB RID: 126443 RVA: 0x0089FCEB File Offset: 0x0089DEEB
	protected __AnimNotifyStateTrail_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
