using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F11 RID: 12049
public class __EffectModelGroup_InheritProxy : EffectModelGroup
{
	// Token: 0x0601CA3E RID: 117310 RVA: 0x008C001C File Offset: 0x008BE21C
	[NullableContext(1)]
	public __EffectModelGroup_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelGroup.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA3F RID: 117311 RVA: 0x008C004F File Offset: 0x008BE24F
	protected __EffectModelGroup_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
