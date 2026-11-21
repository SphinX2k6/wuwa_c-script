using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EAB RID: 11947
public class __TsMoveBlueprintFunctionLibrary_InheritProxy : TsMoveBlueprintFunctionLibrary
{
	// Token: 0x0601C8A1 RID: 116897 RVA: 0x008BD3D4 File Offset: 0x008BB5D4
	[NullableContext(1)]
	public __TsMoveBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsMoveBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C8A2 RID: 116898 RVA: 0x008BD407 File Offset: 0x008BB607
	protected __TsMoveBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
