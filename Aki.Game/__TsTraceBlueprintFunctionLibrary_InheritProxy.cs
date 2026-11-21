using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EAF RID: 11951
public class __TsTraceBlueprintFunctionLibrary_InheritProxy : TsTraceBlueprintFunctionLibrary
{
	// Token: 0x0601C8A9 RID: 116905 RVA: 0x008BD4C4 File Offset: 0x008BB6C4
	[NullableContext(1)]
	public __TsTraceBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTraceBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C8AA RID: 116906 RVA: 0x008BD4F7 File Offset: 0x008BB6F7
	protected __TsTraceBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
