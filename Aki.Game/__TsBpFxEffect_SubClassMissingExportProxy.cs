using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EDA RID: 11994
public class __TsBpFxEffect_SubClassMissingExportProxy : __TsBpFxEffect_InheritProxy
{
	// Token: 0x0601C93E RID: 117054 RVA: 0x008BE410 File Offset: 0x008BC610
	[NullableContext(1)]
	protected __TsBpFxEffect_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBpFxEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C93F RID: 117055 RVA: 0x008BE443 File Offset: 0x008BC643
	protected __TsBpFxEffect_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
