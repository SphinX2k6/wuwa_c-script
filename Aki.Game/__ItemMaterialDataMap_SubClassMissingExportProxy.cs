using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F38 RID: 12088
public class __ItemMaterialDataMap_SubClassMissingExportProxy : __ItemMaterialDataMap_InheritProxy
{
	// Token: 0x0601CA93 RID: 117395 RVA: 0x008C09B8 File Offset: 0x008BEBB8
	[NullableContext(1)]
	protected __ItemMaterialDataMap_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ItemMaterialDataMap.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA94 RID: 117396 RVA: 0x008C09EB File Offset: 0x008BEBEB
	protected __ItemMaterialDataMap_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
