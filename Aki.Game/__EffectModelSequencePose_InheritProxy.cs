using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F1D RID: 12061
public class __EffectModelSequencePose_InheritProxy : EffectModelSequencePose
{
	// Token: 0x0601CA56 RID: 117334 RVA: 0x008C02EC File Offset: 0x008BE4EC
	[NullableContext(1)]
	public __EffectModelSequencePose_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelSequencePose.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA57 RID: 117335 RVA: 0x008C031F File Offset: 0x008BE51F
	protected __EffectModelSequencePose_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
