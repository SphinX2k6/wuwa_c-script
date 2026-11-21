using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E38 RID: 11832
public class __TsPhotographer_SubClassMissingExportProxy : __TsPhotographer_InheritProxy
{
	// Token: 0x0601C780 RID: 116608 RVA: 0x008BB614 File Offset: 0x008B9814
	[NullableContext(1)]
	protected __TsPhotographer_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsPhotographer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C781 RID: 116609 RVA: 0x008BB647 File Offset: 0x008B9847
	protected __TsPhotographer_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
