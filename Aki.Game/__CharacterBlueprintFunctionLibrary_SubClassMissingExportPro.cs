using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E9A RID: 11930
public class __CharacterBlueprintFunctionLibrary_SubClassMissingExportProxy : __CharacterBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601C87F RID: 116863 RVA: 0x008BCFD8 File Offset: 0x008BB1D8
	[NullableContext(1)]
	protected __CharacterBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CharacterBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C880 RID: 116864 RVA: 0x008BD00B File Offset: 0x008BB20B
	protected __CharacterBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
