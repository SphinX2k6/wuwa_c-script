using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E63 RID: 11875
public class __BulletBlueprintFunctionLibrary_InheritProxy : BulletBlueprintFunctionLibrary
{
	// Token: 0x0601C804 RID: 116740 RVA: 0x008BC274 File Offset: 0x008BA474
	[NullableContext(1)]
	public __BulletBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BulletBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C805 RID: 116741 RVA: 0x008BC2A7 File Offset: 0x008BA4A7
	protected __BulletBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
