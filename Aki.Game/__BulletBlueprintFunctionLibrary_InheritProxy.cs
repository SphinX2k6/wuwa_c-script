using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038EA RID: 14570
public class __BulletBlueprintFunctionLibrary_InheritProxy : BulletBlueprintFunctionLibrary
{
	// Token: 0x0601EB4C RID: 125772 RVA: 0x00897DD0 File Offset: 0x00895FD0
	[NullableContext(1)]
	public __BulletBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BulletBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB4D RID: 125773 RVA: 0x00897E03 File Offset: 0x00896003
	protected __BulletBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
