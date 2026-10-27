using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038B6 RID: 14518
public class __UiBlueprintFunctionLibrary_InheritProxy : UiBlueprintFunctionLibrary
{
	// Token: 0x0601EA8E RID: 125582 RVA: 0x00896440 File Offset: 0x00894640
	[NullableContext(1)]
	public __UiBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UiBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EA8F RID: 125583 RVA: 0x00896473 File Offset: 0x00894673
	protected __UiBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
