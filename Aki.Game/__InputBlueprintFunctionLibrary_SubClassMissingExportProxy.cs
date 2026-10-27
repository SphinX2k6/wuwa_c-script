using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200389F RID: 14495
public class __InputBlueprintFunctionLibrary_SubClassMissingExportProxy : __InputBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601EA41 RID: 125505 RVA: 0x008955D0 File Offset: 0x008937D0
	[NullableContext(1)]
	protected __InputBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(InputBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EA42 RID: 125506 RVA: 0x00895603 File Offset: 0x00893803
	protected __InputBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
