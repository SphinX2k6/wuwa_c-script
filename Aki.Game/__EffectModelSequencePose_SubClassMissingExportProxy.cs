using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039A3 RID: 14755
public class __EffectModelSequencePose_SubClassMissingExportProxy : __EffectModelSequencePose_InheritProxy
{
	// Token: 0x0601EE2B RID: 126507 RVA: 0x008A046C File Offset: 0x0089E66C
	[NullableContext(1)]
	protected __EffectModelSequencePose_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelSequencePose.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE2C RID: 126508 RVA: 0x008A049F File Offset: 0x0089E69F
	protected __EffectModelSequencePose_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
