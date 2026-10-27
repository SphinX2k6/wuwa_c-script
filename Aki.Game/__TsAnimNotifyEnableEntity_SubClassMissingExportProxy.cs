using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200381F RID: 14367
public class __TsAnimNotifyEnableEntity_SubClassMissingExportProxy : __TsAnimNotifyEnableEntity_InheritProxy
{
	// Token: 0x0601E88E RID: 125070 RVA: 0x008916D4 File Offset: 0x0088F8D4
	[NullableContext(1)]
	protected __TsAnimNotifyEnableEntity_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyEnableEntity.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E88F RID: 125071 RVA: 0x00891707 File Offset: 0x0088F907
	protected __TsAnimNotifyEnableEntity_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
