using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200392C RID: 14636
public class __TsMediaBlueprintFunctionLibrary_InheritProxy : TsMediaBlueprintFunctionLibrary
{
	// Token: 0x0601EBE8 RID: 125928 RVA: 0x008992B0 File Offset: 0x008974B0
	[NullableContext(1)]
	public __TsMediaBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsMediaBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EBE9 RID: 125929 RVA: 0x008992E3 File Offset: 0x008974E3
	protected __TsMediaBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
