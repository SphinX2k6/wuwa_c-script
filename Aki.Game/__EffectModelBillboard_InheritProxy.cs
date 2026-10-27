using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200398C RID: 14732
public class __EffectModelBillboard_InheritProxy : EffectModelBillboard
{
	// Token: 0x0601EDFD RID: 126461 RVA: 0x0089FF08 File Offset: 0x0089E108
	[NullableContext(1)]
	public __EffectModelBillboard_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelBillboard.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EDFE RID: 126462 RVA: 0x0089FF3B File Offset: 0x0089E13B
	protected __EffectModelBillboard_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
