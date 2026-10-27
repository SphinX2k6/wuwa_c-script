using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039C8 RID: 14792
public class __GlobalBlueprintFunctionLibrary_InheritProxy : GlobalBlueprintFunctionLibrary
{
	// Token: 0x0601EF0F RID: 126735 RVA: 0x008A350C File Offset: 0x008A170C
	[NullableContext(1)]
	public __GlobalBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GlobalBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EF10 RID: 126736 RVA: 0x008A353F File Offset: 0x008A173F
	protected __GlobalBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
