using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003992 RID: 14738
public class __EffectModelGhost_InheritProxy : EffectModelGhost
{
	// Token: 0x0601EE09 RID: 126473 RVA: 0x008A0070 File Offset: 0x0089E270
	[NullableContext(1)]
	public __EffectModelGhost_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelGhost.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE0A RID: 126474 RVA: 0x008A00A3 File Offset: 0x0089E2A3
	protected __EffectModelGhost_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
