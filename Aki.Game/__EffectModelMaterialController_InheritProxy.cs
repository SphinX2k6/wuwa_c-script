using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F15 RID: 12053
public class __EffectModelMaterialController_InheritProxy : EffectModelMaterialController
{
	// Token: 0x0601CA46 RID: 117318 RVA: 0x008C010C File Offset: 0x008BE30C
	[NullableContext(1)]
	public __EffectModelMaterialController_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelMaterialController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA47 RID: 117319 RVA: 0x008C013F File Offset: 0x008BE33F
	protected __EffectModelMaterialController_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
