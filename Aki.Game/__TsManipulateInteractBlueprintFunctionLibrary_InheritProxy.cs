using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EA5 RID: 11941
public class __TsManipulateInteractBlueprintFunctionLibrary_InheritProxy : TsManipulateInteractBlueprintFunctionLibrary
{
	// Token: 0x0601C895 RID: 116885 RVA: 0x008BD26C File Offset: 0x008BB46C
	[NullableContext(1)]
	public __TsManipulateInteractBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsManipulateInteractBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C896 RID: 116886 RVA: 0x008BD29F File Offset: 0x008BB49F
	protected __TsManipulateInteractBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
