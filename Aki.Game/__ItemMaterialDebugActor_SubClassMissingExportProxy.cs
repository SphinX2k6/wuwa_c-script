using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F3A RID: 12090
public class __ItemMaterialDebugActor_SubClassMissingExportProxy : __ItemMaterialDebugActor_InheritProxy
{
	// Token: 0x0601CA9C RID: 117404 RVA: 0x008C0A58 File Offset: 0x008BEC58
	[NullableContext(1)]
	protected __ItemMaterialDebugActor_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ItemMaterialDebugActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA9D RID: 117405 RVA: 0x008C0A8B File Offset: 0x008BEC8B
	protected __ItemMaterialDebugActor_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
