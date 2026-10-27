using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020037FF RID: 14335
public class __TsAnimNotifyChangeSlot_SubClassMissingExportProxy : __TsAnimNotifyChangeSlot_InheritProxy
{
	// Token: 0x0601E82E RID: 124974 RVA: 0x00890AD4 File Offset: 0x0088ECD4
	[NullableContext(1)]
	protected __TsAnimNotifyChangeSlot_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyChangeSlot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E82F RID: 124975 RVA: 0x00890B07 File Offset: 0x0088ED07
	protected __TsAnimNotifyChangeSlot_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
