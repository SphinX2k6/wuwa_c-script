using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F0D RID: 12045
public class __EffectModelGhost_InheritProxy : EffectModelGhost
{
	// Token: 0x0601CA36 RID: 117302 RVA: 0x008BFF2C File Offset: 0x008BE12C
	[NullableContext(1)]
	public __EffectModelGhost_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelGhost.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA37 RID: 117303 RVA: 0x008BFF5F File Offset: 0x008BE15F
	protected __EffectModelGhost_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
