using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200399E RID: 14750
public class __EffectModelNiagara_InheritProxy : EffectModelNiagara
{
	// Token: 0x0601EE21 RID: 126497 RVA: 0x008A0340 File Offset: 0x0089E540
	[NullableContext(1)]
	public __EffectModelNiagara_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelNiagara.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE22 RID: 126498 RVA: 0x008A0373 File Offset: 0x0089E573
	protected __EffectModelNiagara_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
