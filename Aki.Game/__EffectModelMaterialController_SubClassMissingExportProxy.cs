using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200399B RID: 14747
public class __EffectModelMaterialController_SubClassMissingExportProxy : __EffectModelMaterialController_InheritProxy
{
	// Token: 0x0601EE1B RID: 126491 RVA: 0x008A028C File Offset: 0x0089E48C
	[NullableContext(1)]
	protected __EffectModelMaterialController_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelMaterialController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE1C RID: 126492 RVA: 0x008A02BF File Offset: 0x0089E4BF
	protected __EffectModelMaterialController_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
