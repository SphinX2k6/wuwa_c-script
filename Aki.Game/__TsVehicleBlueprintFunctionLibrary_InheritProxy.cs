using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EB1 RID: 11953
public class __TsVehicleBlueprintFunctionLibrary_InheritProxy : TsVehicleBlueprintFunctionLibrary
{
	// Token: 0x0601C8AD RID: 116909 RVA: 0x008BD53C File Offset: 0x008BB73C
	[NullableContext(1)]
	public __TsVehicleBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsVehicleBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C8AE RID: 116910 RVA: 0x008BD56F File Offset: 0x008BB76F
	protected __TsVehicleBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
