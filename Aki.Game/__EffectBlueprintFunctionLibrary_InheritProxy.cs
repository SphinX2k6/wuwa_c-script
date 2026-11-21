using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F2B RID: 12075
public class __EffectBlueprintFunctionLibrary_InheritProxy : EffectBlueprintFunctionLibrary
{
	// Token: 0x0601CA72 RID: 117362 RVA: 0x008C0634 File Offset: 0x008BE834
	[NullableContext(1)]
	public __EffectBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA73 RID: 117363 RVA: 0x008C0667 File Offset: 0x008BE867
	protected __EffectBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
