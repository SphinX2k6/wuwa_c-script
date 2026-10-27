using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003924 RID: 14628
public class __TsControlBlueprintFunctionLibrary_InheritProxy : TsControlBlueprintFunctionLibrary
{
	// Token: 0x0601EBD8 RID: 125912 RVA: 0x008990D0 File Offset: 0x008972D0
	[NullableContext(1)]
	public __TsControlBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsControlBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EBD9 RID: 125913 RVA: 0x00899103 File Offset: 0x00897303
	protected __TsControlBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
