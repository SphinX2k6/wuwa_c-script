using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200392E RID: 14638
public class __TsMeshAnimBlueprintFunctionLibrary_InheritProxy : TsMeshAnimBlueprintFunctionLibrary
{
	// Token: 0x0601EBEC RID: 125932 RVA: 0x00899328 File Offset: 0x00897528
	[NullableContext(1)]
	public __TsMeshAnimBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsMeshAnimBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EBED RID: 125933 RVA: 0x0089935B File Offset: 0x0089755B
	protected __TsMeshAnimBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
