using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E99 RID: 11929
public class __CharacterBlueprintFunctionLibrary_InheritProxy : CharacterBlueprintFunctionLibrary
{
	// Token: 0x0601C87D RID: 116861 RVA: 0x008BCF9C File Offset: 0x008BB19C
	[NullableContext(1)]
	public __CharacterBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CharacterBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C87E RID: 116862 RVA: 0x008BCFCF File Offset: 0x008BB1CF
	protected __CharacterBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
