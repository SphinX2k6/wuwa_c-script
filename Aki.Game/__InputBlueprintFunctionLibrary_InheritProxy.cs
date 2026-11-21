using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E17 RID: 11799
public class __InputBlueprintFunctionLibrary_InheritProxy : InputBlueprintFunctionLibrary
{
	// Token: 0x0601C71A RID: 116506 RVA: 0x008BAB0C File Offset: 0x008B8D0C
	[NullableContext(1)]
	public __InputBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(InputBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C71B RID: 116507 RVA: 0x008BAB3F File Offset: 0x008B8D3F
	protected __InputBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
