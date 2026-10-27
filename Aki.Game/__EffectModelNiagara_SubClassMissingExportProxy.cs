using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200399F RID: 14751
public class __EffectModelNiagara_SubClassMissingExportProxy : __EffectModelNiagara_InheritProxy
{
	// Token: 0x0601EE23 RID: 126499 RVA: 0x008A037C File Offset: 0x0089E57C
	[NullableContext(1)]
	protected __EffectModelNiagara_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelNiagara.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE24 RID: 126500 RVA: 0x008A03AF File Offset: 0x0089E5AF
	protected __EffectModelNiagara_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
