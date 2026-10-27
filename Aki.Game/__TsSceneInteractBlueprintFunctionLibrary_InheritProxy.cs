using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003932 RID: 14642
public class __TsSceneInteractBlueprintFunctionLibrary_InheritProxy : TsSceneInteractBlueprintFunctionLibrary
{
	// Token: 0x0601EBF4 RID: 125940 RVA: 0x00899418 File Offset: 0x00897618
	[NullableContext(1)]
	public __TsSceneInteractBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSceneInteractBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EBF5 RID: 125941 RVA: 0x0089944B File Offset: 0x0089764B
	protected __TsSceneInteractBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
