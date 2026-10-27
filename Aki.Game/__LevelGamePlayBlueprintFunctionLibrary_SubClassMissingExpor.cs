using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038AB RID: 14507
public class __LevelGamePlayBlueprintFunctionLibrary_SubClassMissingExportProxy : __LevelGamePlayBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601EA5C RID: 125532 RVA: 0x0089597C File Offset: 0x00893B7C
	[NullableContext(1)]
	protected __LevelGamePlayBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LevelGamePlayBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EA5D RID: 125533 RVA: 0x008959AF File Offset: 0x00893BAF
	protected __LevelGamePlayBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
