using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F07 RID: 12039
public class __EffectModelBillboard_InheritProxy : EffectModelBillboard
{
	// Token: 0x0601CA2A RID: 117290 RVA: 0x008BFDC4 File Offset: 0x008BDFC4
	[NullableContext(1)]
	public __EffectModelBillboard_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelBillboard.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA2B RID: 117291 RVA: 0x008BFDF7 File Offset: 0x008BDFF7
	protected __EffectModelBillboard_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
