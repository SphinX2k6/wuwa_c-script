using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200392A RID: 14634
public class __TsManipulateInteractBlueprintFunctionLibrary_InheritProxy : TsManipulateInteractBlueprintFunctionLibrary
{
	// Token: 0x0601EBE4 RID: 125924 RVA: 0x00899238 File Offset: 0x00897438
	[NullableContext(1)]
	public __TsManipulateInteractBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsManipulateInteractBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EBE5 RID: 125925 RVA: 0x0089926B File Offset: 0x0089746B
	protected __TsManipulateInteractBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
