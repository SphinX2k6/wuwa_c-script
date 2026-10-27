using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200391E RID: 14622
public class __CharacterBlueprintFunctionLibrary_InheritProxy : CharacterBlueprintFunctionLibrary
{
	// Token: 0x0601EBCC RID: 125900 RVA: 0x00898F68 File Offset: 0x00897168
	[NullableContext(1)]
	public __CharacterBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CharacterBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EBCD RID: 125901 RVA: 0x00898F9B File Offset: 0x0089719B
	protected __CharacterBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
