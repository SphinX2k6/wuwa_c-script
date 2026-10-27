using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003996 RID: 14742
public class __EffectModelGroup_InheritProxy : EffectModelGroup
{
	// Token: 0x0601EE11 RID: 126481 RVA: 0x008A0160 File Offset: 0x0089E360
	[NullableContext(1)]
	public __EffectModelGroup_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelGroup.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE12 RID: 126482 RVA: 0x008A0193 File Offset: 0x0089E393
	protected __EffectModelGroup_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
