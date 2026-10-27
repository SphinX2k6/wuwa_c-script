using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200382F RID: 14383
public class __TsAnimNotifyHideBone_SubClassMissingExportProxy : __TsAnimNotifyHideBone_InheritProxy
{
	// Token: 0x0601E8BE RID: 125118 RVA: 0x00891CD4 File Offset: 0x0088FED4
	[NullableContext(1)]
	protected __TsAnimNotifyHideBone_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyHideBone.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E8BF RID: 125119 RVA: 0x00891D07 File Offset: 0x0088FF07
	protected __TsAnimNotifyHideBone_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
