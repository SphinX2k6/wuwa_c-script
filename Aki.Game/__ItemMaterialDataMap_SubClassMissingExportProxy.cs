using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039BD RID: 14781
public class __ItemMaterialDataMap_SubClassMissingExportProxy : __ItemMaterialDataMap_InheritProxy
{
	// Token: 0x0601EE6C RID: 126572 RVA: 0x008A0DB4 File Offset: 0x0089EFB4
	[NullableContext(1)]
	protected __ItemMaterialDataMap_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ItemMaterialDataMap.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE6D RID: 126573 RVA: 0x008A0DE7 File Offset: 0x0089EFE7
	protected __ItemMaterialDataMap_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
