using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003934 RID: 14644
public class __TsTraceBlueprintFunctionLibrary_InheritProxy : TsTraceBlueprintFunctionLibrary
{
	// Token: 0x0601EBF8 RID: 125944 RVA: 0x00899490 File Offset: 0x00897690
	[NullableContext(1)]
	public __TsTraceBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTraceBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EBF9 RID: 125945 RVA: 0x008994C3 File Offset: 0x008976C3
	protected __TsTraceBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
