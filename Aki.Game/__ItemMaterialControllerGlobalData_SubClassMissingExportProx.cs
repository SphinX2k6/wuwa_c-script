using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039BB RID: 14779
public class __ItemMaterialControllerGlobalData_SubClassMissingExportProxy : __ItemMaterialControllerGlobalData_InheritProxy
{
	// Token: 0x0601EE68 RID: 126568 RVA: 0x008A0D3C File Offset: 0x0089EF3C
	[NullableContext(1)]
	protected __ItemMaterialControllerGlobalData_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ItemMaterialControllerGlobalData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE69 RID: 126569 RVA: 0x008A0D6F File Offset: 0x0089EF6F
	protected __ItemMaterialControllerGlobalData_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
