using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038AA RID: 14506
public class __LevelGamePlayBlueprintFunctionLibrary_InheritProxy : LevelGamePlayBlueprintFunctionLibrary
{
	// Token: 0x0601EA5A RID: 125530 RVA: 0x00895940 File Offset: 0x00893B40
	[NullableContext(1)]
	public __LevelGamePlayBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LevelGamePlayBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EA5B RID: 125531 RVA: 0x00895973 File Offset: 0x00893B73
	protected __LevelGamePlayBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
