using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039C9 RID: 14793
public class __GlobalBlueprintFunctionLibrary_SubClassMissingExportProxy : __GlobalBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601EF11 RID: 126737 RVA: 0x008A3548 File Offset: 0x008A1748
	[NullableContext(1)]
	protected __GlobalBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GlobalBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EF12 RID: 126738 RVA: 0x008A357B File Offset: 0x008A177B
	protected __GlobalBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
