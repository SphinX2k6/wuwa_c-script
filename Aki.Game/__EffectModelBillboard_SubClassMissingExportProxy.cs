using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F08 RID: 12040
public class __EffectModelBillboard_SubClassMissingExportProxy : __EffectModelBillboard_InheritProxy
{
	// Token: 0x0601CA2C RID: 117292 RVA: 0x008BFE00 File Offset: 0x008BE000
	[NullableContext(1)]
	protected __EffectModelBillboard_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelBillboard.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA2D RID: 117293 RVA: 0x008BFE33 File Offset: 0x008BE033
	protected __EffectModelBillboard_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
