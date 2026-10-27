using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003926 RID: 14630
public class __TsExploreComponentBlueprintFunctionLibrary_InheritProxy : TsExploreComponentBlueprintFunctionLibrary
{
	// Token: 0x0601EBDC RID: 125916 RVA: 0x00899148 File Offset: 0x00897348
	[NullableContext(1)]
	public __TsExploreComponentBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsExploreComponentBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EBDD RID: 125917 RVA: 0x0089917B File Offset: 0x0089737B
	protected __TsExploreComponentBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
