using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039C7 RID: 14791
public class __CombatDebugBlueprintFunctionLibrary_SubClassMissingExportProxy : __CombatDebugBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601EF0D RID: 126733 RVA: 0x008A34D0 File Offset: 0x008A16D0
	[NullableContext(1)]
	protected __CombatDebugBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CombatDebugBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EF0E RID: 126734 RVA: 0x008A3503 File Offset: 0x008A1703
	protected __CombatDebugBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
