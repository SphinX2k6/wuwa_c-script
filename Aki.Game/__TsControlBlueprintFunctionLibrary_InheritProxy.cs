using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E9F RID: 11935
public class __TsControlBlueprintFunctionLibrary_InheritProxy : TsControlBlueprintFunctionLibrary
{
	// Token: 0x0601C889 RID: 116873 RVA: 0x008BD104 File Offset: 0x008BB304
	[NullableContext(1)]
	public __TsControlBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsControlBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C88A RID: 116874 RVA: 0x008BD137 File Offset: 0x008BB337
	protected __TsControlBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
