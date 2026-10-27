using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003886 RID: 14470
public class __CameraBlueprintFunctionLibrary_InheritProxy : CameraBlueprintFunctionLibrary
{
	// Token: 0x0601E9BF RID: 125375 RVA: 0x00893CF4 File Offset: 0x00891EF4
	[NullableContext(1)]
	public __CameraBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CameraBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E9C0 RID: 125376 RVA: 0x00893D27 File Offset: 0x00891F27
	protected __CameraBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
