using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E25 RID: 11813
public class __LevelGeneralBlueprintFunctionLibrary_InheritProxy : LevelGeneralBlueprintFunctionLibrary
{
	// Token: 0x0601C738 RID: 116536 RVA: 0x008BAEC0 File Offset: 0x008B90C0
	[NullableContext(1)]
	public __LevelGeneralBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LevelGeneralBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C739 RID: 116537 RVA: 0x008BAEF3 File Offset: 0x008B90F3
	protected __LevelGeneralBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
