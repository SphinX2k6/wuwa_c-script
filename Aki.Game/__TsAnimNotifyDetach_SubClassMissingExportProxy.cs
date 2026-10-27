using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200380F RID: 14351
public class __TsAnimNotifyDetach_SubClassMissingExportProxy : __TsAnimNotifyDetach_InheritProxy
{
	// Token: 0x0601E85E RID: 125022 RVA: 0x008910D4 File Offset: 0x0088F2D4
	[NullableContext(1)]
	protected __TsAnimNotifyDetach_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyDetach.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E85F RID: 125023 RVA: 0x00891107 File Offset: 0x0088F307
	protected __TsAnimNotifyDetach_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
