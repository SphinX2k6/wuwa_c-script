using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E24 RID: 11812
public class __LevelGamePlayBlueprintFunctionLibrary_SubClassMissingExportProxy : __LevelGamePlayBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601C736 RID: 116534 RVA: 0x008BAE84 File Offset: 0x008B9084
	[NullableContext(1)]
	protected __LevelGamePlayBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LevelGamePlayBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C737 RID: 116535 RVA: 0x008BAEB7 File Offset: 0x008B90B7
	protected __LevelGamePlayBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
