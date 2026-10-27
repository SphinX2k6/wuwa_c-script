using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039A2 RID: 14754
public class __EffectModelSequencePose_InheritProxy : EffectModelSequencePose
{
	// Token: 0x0601EE29 RID: 126505 RVA: 0x008A0430 File Offset: 0x0089E630
	[NullableContext(1)]
	public __EffectModelSequencePose_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelSequencePose.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE2A RID: 126506 RVA: 0x008A0463 File Offset: 0x0089E663
	protected __EffectModelSequencePose_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
