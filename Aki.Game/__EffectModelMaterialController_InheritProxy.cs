using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200399A RID: 14746
public class __EffectModelMaterialController_InheritProxy : EffectModelMaterialController
{
	// Token: 0x0601EE19 RID: 126489 RVA: 0x008A0250 File Offset: 0x0089E450
	[NullableContext(1)]
	public __EffectModelMaterialController_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelMaterialController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE1A RID: 126490 RVA: 0x008A0283 File Offset: 0x0089E483
	protected __EffectModelMaterialController_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
