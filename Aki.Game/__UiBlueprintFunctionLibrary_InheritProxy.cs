using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E2F RID: 11823
public class __UiBlueprintFunctionLibrary_InheritProxy : UiBlueprintFunctionLibrary
{
	// Token: 0x0601C75B RID: 116571 RVA: 0x008BB29C File Offset: 0x008B949C
	[NullableContext(1)]
	public __UiBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UiBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C75C RID: 116572 RVA: 0x008BB2CF File Offset: 0x008B94CF
	protected __UiBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
