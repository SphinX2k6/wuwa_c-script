using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002D54 RID: 11604
public class __TsAnimNotifyBase_SubClassMissingExportProxy : __TsAnimNotifyBase_InheritProxy
{
	// Token: 0x0601C4BB RID: 115899 RVA: 0x008B6150 File Offset: 0x008B4350
	[NullableContext(1)]
	protected __TsAnimNotifyBase_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C4BC RID: 115900 RVA: 0x008B6183 File Offset: 0x008B4383
	protected __TsAnimNotifyBase_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
