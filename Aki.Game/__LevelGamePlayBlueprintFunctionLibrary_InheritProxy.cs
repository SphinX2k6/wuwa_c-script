using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E23 RID: 11811
public class __LevelGamePlayBlueprintFunctionLibrary_InheritProxy : LevelGamePlayBlueprintFunctionLibrary
{
	// Token: 0x0601C734 RID: 116532 RVA: 0x008BAE48 File Offset: 0x008B9048
	[NullableContext(1)]
	public __LevelGamePlayBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LevelGamePlayBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C735 RID: 116533 RVA: 0x008BAE7B File Offset: 0x008B907B
	protected __LevelGamePlayBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
