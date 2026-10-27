using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200399C RID: 14748
public class __EffectModelNDC_InheritProxy : EffectModelNDC
{
	// Token: 0x0601EE1D RID: 126493 RVA: 0x008A02C8 File Offset: 0x0089E4C8
	[NullableContext(1)]
	public __EffectModelNDC_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelNDC.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE1E RID: 126494 RVA: 0x008A02FB File Offset: 0x0089E4FB
	protected __EffectModelNDC_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
