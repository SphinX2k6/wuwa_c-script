using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002C2C RID: 11308
public class __TsTaskSetNowTime_SubClassMissingExportProxy : __TsTaskSetNowTime_InheritProxy
{
	// Token: 0x0601C092 RID: 114834 RVA: 0x008ACAB8 File Offset: 0x008AACB8
	[NullableContext(1)]
	protected __TsTaskSetNowTime_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskSetNowTime.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C093 RID: 114835 RVA: 0x008ACAEB File Offset: 0x008AACEB
	protected __TsTaskSetNowTime_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
