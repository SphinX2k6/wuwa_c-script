using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F16 RID: 12054
public class __EffectModelMaterialController_SubClassMissingExportProxy : __EffectModelMaterialController_InheritProxy
{
	// Token: 0x0601CA48 RID: 117320 RVA: 0x008C0148 File Offset: 0x008BE348
	[NullableContext(1)]
	protected __EffectModelMaterialController_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelMaterialController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA49 RID: 117321 RVA: 0x008C017B File Offset: 0x008BE37B
	protected __EffectModelMaterialController_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
