using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E20 RID: 11808
public class __TsAreaBlockingVolume_SubClassMissingExportProxy : __TsAreaBlockingVolume_InheritProxy
{
	// Token: 0x0601C72E RID: 116526 RVA: 0x008BAD94 File Offset: 0x008B8F94
	[NullableContext(1)]
	protected __TsAreaBlockingVolume_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAreaBlockingVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C72F RID: 116527 RVA: 0x008BADC7 File Offset: 0x008B8FC7
	protected __TsAreaBlockingVolume_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
