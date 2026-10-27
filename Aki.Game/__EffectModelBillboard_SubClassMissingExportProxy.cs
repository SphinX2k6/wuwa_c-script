using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200398D RID: 14733
public class __EffectModelBillboard_SubClassMissingExportProxy : __EffectModelBillboard_InheritProxy
{
	// Token: 0x0601EDFF RID: 126463 RVA: 0x0089FF44 File Offset: 0x0089E144
	[NullableContext(1)]
	protected __EffectModelBillboard_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelBillboard.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE00 RID: 126464 RVA: 0x0089FF77 File Offset: 0x0089E177
	protected __EffectModelBillboard_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
