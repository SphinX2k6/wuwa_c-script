using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002DFF RID: 11775
public class __CameraBlueprintFunctionLibrary_InheritProxy : CameraBlueprintFunctionLibrary
{
	// Token: 0x0601C6B8 RID: 116408 RVA: 0x008BA0F0 File Offset: 0x008B82F0
	[NullableContext(1)]
	public __CameraBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CameraBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C6B9 RID: 116409 RVA: 0x008BA123 File Offset: 0x008B8323
	protected __CameraBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
