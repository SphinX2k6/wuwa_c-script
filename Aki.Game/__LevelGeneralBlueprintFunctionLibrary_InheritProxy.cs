using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038AC RID: 14508
public class __LevelGeneralBlueprintFunctionLibrary_InheritProxy : LevelGeneralBlueprintFunctionLibrary
{
	// Token: 0x0601EA5E RID: 125534 RVA: 0x008959B8 File Offset: 0x00893BB8
	[NullableContext(1)]
	public __LevelGeneralBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LevelGeneralBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EA5F RID: 125535 RVA: 0x008959EB File Offset: 0x00893BEB
	protected __LevelGeneralBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
