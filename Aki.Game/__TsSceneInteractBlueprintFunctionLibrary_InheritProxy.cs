using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EAD RID: 11949
public class __TsSceneInteractBlueprintFunctionLibrary_InheritProxy : TsSceneInteractBlueprintFunctionLibrary
{
	// Token: 0x0601C8A5 RID: 116901 RVA: 0x008BD44C File Offset: 0x008BB64C
	[NullableContext(1)]
	public __TsSceneInteractBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSceneInteractBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C8A6 RID: 116902 RVA: 0x008BD47F File Offset: 0x008BB67F
	protected __TsSceneInteractBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
