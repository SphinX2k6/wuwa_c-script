using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039AD RID: 14765
public class __EffectModelMultiEffect_SubClassMissingExportProxy : __EffectModelMultiEffect_InheritProxy
{
	// Token: 0x0601EE3F RID: 126527 RVA: 0x008A06C4 File Offset: 0x0089E8C4
	[NullableContext(1)]
	protected __EffectModelMultiEffect_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelMultiEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE40 RID: 126528 RVA: 0x008A06F7 File Offset: 0x0089E8F7
	protected __EffectModelMultiEffect_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
