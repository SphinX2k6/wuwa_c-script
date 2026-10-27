using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003936 RID: 14646
public class __TsVehicleBlueprintFunctionLibrary_InheritProxy : TsVehicleBlueprintFunctionLibrary
{
	// Token: 0x0601EBFC RID: 125948 RVA: 0x00899508 File Offset: 0x00897708
	[NullableContext(1)]
	public __TsVehicleBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsVehicleBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EBFD RID: 125949 RVA: 0x0089953B File Offset: 0x0089773B
	protected __TsVehicleBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
