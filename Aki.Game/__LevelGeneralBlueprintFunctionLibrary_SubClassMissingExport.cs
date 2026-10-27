using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038AD RID: 14509
public class __LevelGeneralBlueprintFunctionLibrary_SubClassMissingExportProxy : __LevelGeneralBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601EA60 RID: 125536 RVA: 0x008959F4 File Offset: 0x00893BF4
	[NullableContext(1)]
	protected __LevelGeneralBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LevelGeneralBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EA61 RID: 125537 RVA: 0x00895A27 File Offset: 0x00893C27
	protected __LevelGeneralBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
