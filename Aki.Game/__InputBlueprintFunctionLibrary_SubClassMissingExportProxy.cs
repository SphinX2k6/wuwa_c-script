using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E18 RID: 11800
public class __InputBlueprintFunctionLibrary_SubClassMissingExportProxy : __InputBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601C71C RID: 116508 RVA: 0x008BAB48 File Offset: 0x008B8D48
	[NullableContext(1)]
	protected __InputBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(InputBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C71D RID: 116509 RVA: 0x008BAB7B File Offset: 0x008B8D7B
	protected __InputBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
