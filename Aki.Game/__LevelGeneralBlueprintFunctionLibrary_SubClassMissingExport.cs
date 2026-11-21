using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E26 RID: 11814
public class __LevelGeneralBlueprintFunctionLibrary_SubClassMissingExportProxy : __LevelGeneralBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601C73A RID: 116538 RVA: 0x008BAEFC File Offset: 0x008B90FC
	[NullableContext(1)]
	protected __LevelGeneralBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LevelGeneralBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C73B RID: 116539 RVA: 0x008BAF2F File Offset: 0x008B912F
	protected __LevelGeneralBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
