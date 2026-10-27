using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039B0 RID: 14768
public class __EffectBlueprintFunctionLibrary_InheritProxy : EffectBlueprintFunctionLibrary
{
	// Token: 0x0601EE45 RID: 126533 RVA: 0x008A0778 File Offset: 0x0089E978
	[NullableContext(1)]
	public __EffectBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE46 RID: 126534 RVA: 0x008A07AB File Offset: 0x0089E9AB
	protected __EffectBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
