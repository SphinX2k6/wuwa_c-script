using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200391F RID: 14623
public class __CharacterBlueprintFunctionLibrary_SubClassMissingExportProxy : __CharacterBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601EBCE RID: 125902 RVA: 0x00898FA4 File Offset: 0x008971A4
	[NullableContext(1)]
	protected __CharacterBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CharacterBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EBCF RID: 125903 RVA: 0x00898FD7 File Offset: 0x008971D7
	protected __CharacterBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
