using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038BC RID: 14524
public class __TsHideActorBlueprintFunctionLibrary_InheritProxy : TsHideActorBlueprintFunctionLibrary
{
	// Token: 0x0601EA9C RID: 125596 RVA: 0x00896610 File Offset: 0x00894810
	[NullableContext(1)]
	public __TsHideActorBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsHideActorBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EA9D RID: 125597 RVA: 0x00896643 File Offset: 0x00894843
	protected __TsHideActorBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
