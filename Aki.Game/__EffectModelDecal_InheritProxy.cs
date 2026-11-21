using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F0B RID: 12043
public class __EffectModelDecal_InheritProxy : EffectModelDecal
{
	// Token: 0x0601CA32 RID: 117298 RVA: 0x008BFEB4 File Offset: 0x008BE0B4
	[NullableContext(1)]
	public __EffectModelDecal_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelDecal.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA33 RID: 117299 RVA: 0x008BFEE7 File Offset: 0x008BE0E7
	protected __EffectModelDecal_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
