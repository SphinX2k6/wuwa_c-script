using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003990 RID: 14736
public class __EffectModelDecal_InheritProxy : EffectModelDecal
{
	// Token: 0x0601EE05 RID: 126469 RVA: 0x0089FFF8 File Offset: 0x0089E1F8
	[NullableContext(1)]
	public __EffectModelDecal_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelDecal.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE06 RID: 126470 RVA: 0x008A002B File Offset: 0x0089E22B
	protected __EffectModelDecal_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
