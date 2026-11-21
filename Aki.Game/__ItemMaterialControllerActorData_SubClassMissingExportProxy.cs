using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F34 RID: 12084
public class __ItemMaterialControllerActorData_SubClassMissingExportProxy : __ItemMaterialControllerActorData_InheritProxy
{
	// Token: 0x0601CA8B RID: 117387 RVA: 0x008C08C8 File Offset: 0x008BEAC8
	[NullableContext(1)]
	protected __ItemMaterialControllerActorData_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ItemMaterialControllerActorData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA8C RID: 117388 RVA: 0x008C08FB File Offset: 0x008BEAFB
	protected __ItemMaterialControllerActorData_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
