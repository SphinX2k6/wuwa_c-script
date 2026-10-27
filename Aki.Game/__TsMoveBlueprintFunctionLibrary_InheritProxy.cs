using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003930 RID: 14640
public class __TsMoveBlueprintFunctionLibrary_InheritProxy : TsMoveBlueprintFunctionLibrary
{
	// Token: 0x0601EBF0 RID: 125936 RVA: 0x008993A0 File Offset: 0x008975A0
	[NullableContext(1)]
	public __TsMoveBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsMoveBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EBF1 RID: 125937 RVA: 0x008993D3 File Offset: 0x008975D3
	protected __TsMoveBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
