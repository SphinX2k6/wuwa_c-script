using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F12 RID: 12050
public class __EffectModelGroup_SubClassMissingExportProxy : __EffectModelGroup_InheritProxy
{
	// Token: 0x0601CA40 RID: 117312 RVA: 0x008C0058 File Offset: 0x008BE258
	[NullableContext(1)]
	protected __EffectModelGroup_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelGroup.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA41 RID: 117313 RVA: 0x008C008B File Offset: 0x008BE28B
	protected __EffectModelGroup_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
