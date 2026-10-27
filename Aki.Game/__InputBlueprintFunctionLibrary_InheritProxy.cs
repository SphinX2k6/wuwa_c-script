using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200389E RID: 14494
public class __InputBlueprintFunctionLibrary_InheritProxy : InputBlueprintFunctionLibrary
{
	// Token: 0x0601EA3F RID: 125503 RVA: 0x00895594 File Offset: 0x00893794
	[NullableContext(1)]
	public __InputBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(InputBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EA40 RID: 125504 RVA: 0x008955C7 File Offset: 0x008937C7
	protected __InputBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
