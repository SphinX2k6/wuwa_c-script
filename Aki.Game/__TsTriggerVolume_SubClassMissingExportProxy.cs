using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002ED0 RID: 11984
public class __TsTriggerVolume_SubClassMissingExportProxy : __TsTriggerVolume_InheritProxy
{
	// Token: 0x0601C91A RID: 117018 RVA: 0x008BE034 File Offset: 0x008BC234
	[NullableContext(1)]
	protected __TsTriggerVolume_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTriggerVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C91B RID: 117019 RVA: 0x008BE067 File Offset: 0x008BC267
	protected __TsTriggerVolume_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
