using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E9B RID: 11931
public class __TsAiBlueprintFunctionLibrary_InheritProxy : TsAiBlueprintFunctionLibrary
{
	// Token: 0x0601C881 RID: 116865 RVA: 0x008BD014 File Offset: 0x008BB214
	[NullableContext(1)]
	public __TsAiBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAiBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C882 RID: 116866 RVA: 0x008BD047 File Offset: 0x008BB247
	protected __TsAiBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
