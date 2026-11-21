using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EA1 RID: 11937
public class __TsExploreComponentBlueprintFunctionLibrary_InheritProxy : TsExploreComponentBlueprintFunctionLibrary
{
	// Token: 0x0601C88D RID: 116877 RVA: 0x008BD17C File Offset: 0x008BB37C
	[NullableContext(1)]
	public __TsExploreComponentBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsExploreComponentBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C88E RID: 116878 RVA: 0x008BD1AF File Offset: 0x008BB3AF
	protected __TsExploreComponentBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
