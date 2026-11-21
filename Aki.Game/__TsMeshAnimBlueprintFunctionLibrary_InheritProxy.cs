using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EA9 RID: 11945
public class __TsMeshAnimBlueprintFunctionLibrary_InheritProxy : TsMeshAnimBlueprintFunctionLibrary
{
	// Token: 0x0601C89D RID: 116893 RVA: 0x008BD35C File Offset: 0x008BB55C
	[NullableContext(1)]
	public __TsMeshAnimBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsMeshAnimBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C89E RID: 116894 RVA: 0x008BD38F File Offset: 0x008BB58F
	protected __TsMeshAnimBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
