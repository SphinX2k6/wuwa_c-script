using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F17 RID: 12055
public class __EffectModelNDC_InheritProxy : EffectModelNDC
{
	// Token: 0x0601CA4A RID: 117322 RVA: 0x008C0184 File Offset: 0x008BE384
	[NullableContext(1)]
	public __EffectModelNDC_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelNDC.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA4B RID: 117323 RVA: 0x008C01B7 File Offset: 0x008BE3B7
	protected __EffectModelNDC_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
