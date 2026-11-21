using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E9D RID: 11933
public class __TsBattleUiBlueprintFunctionLibrary_InheritProxy : TsBattleUiBlueprintFunctionLibrary
{
	// Token: 0x0601C885 RID: 116869 RVA: 0x008BD08C File Offset: 0x008BB28C
	[NullableContext(1)]
	public __TsBattleUiBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBattleUiBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C886 RID: 116870 RVA: 0x008BD0BF File Offset: 0x008BB2BF
	protected __TsBattleUiBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
