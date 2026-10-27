using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039B9 RID: 14777
public class __ItemMaterialControllerActorData_SubClassMissingExportProxy : __ItemMaterialControllerActorData_InheritProxy
{
	// Token: 0x0601EE64 RID: 126564 RVA: 0x008A0CC4 File Offset: 0x0089EEC4
	[NullableContext(1)]
	protected __ItemMaterialControllerActorData_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ItemMaterialControllerActorData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE65 RID: 126565 RVA: 0x008A0CF7 File Offset: 0x0089EEF7
	protected __ItemMaterialControllerActorData_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
