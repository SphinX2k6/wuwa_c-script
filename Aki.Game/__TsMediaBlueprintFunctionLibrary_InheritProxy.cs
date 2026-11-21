using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EA7 RID: 11943
public class __TsMediaBlueprintFunctionLibrary_InheritProxy : TsMediaBlueprintFunctionLibrary
{
	// Token: 0x0601C899 RID: 116889 RVA: 0x008BD2E4 File Offset: 0x008BB4E4
	[NullableContext(1)]
	public __TsMediaBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsMediaBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C89A RID: 116890 RVA: 0x008BD317 File Offset: 0x008BB517
	protected __TsMediaBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
