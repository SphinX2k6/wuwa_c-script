using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002DA8 RID: 11688
public class __TsAnimNotifyHideBone_SubClassMissingExportProxy : __TsAnimNotifyHideBone_InheritProxy
{
	// Token: 0x0601C5B7 RID: 116151 RVA: 0x008B80D0 File Offset: 0x008B62D0
	[NullableContext(1)]
	protected __TsAnimNotifyHideBone_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyHideBone.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C5B8 RID: 116152 RVA: 0x008B8103 File Offset: 0x008B6303
	protected __TsAnimNotifyHideBone_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
