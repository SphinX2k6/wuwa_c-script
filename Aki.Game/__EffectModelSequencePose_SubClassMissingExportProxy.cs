using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F1E RID: 12062
public class __EffectModelSequencePose_SubClassMissingExportProxy : __EffectModelSequencePose_InheritProxy
{
	// Token: 0x0601CA58 RID: 117336 RVA: 0x008C0328 File Offset: 0x008BE528
	[NullableContext(1)]
	protected __EffectModelSequencePose_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelSequencePose.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA59 RID: 117337 RVA: 0x008C035B File Offset: 0x008BE55B
	protected __EffectModelSequencePose_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
