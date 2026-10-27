using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020036B7 RID: 14007
public class __TsTaskSetNowTime_SubClassMissingExportProxy : __TsTaskSetNowTime_InheritProxy
{
	// Token: 0x0601E379 RID: 123769 RVA: 0x008850E0 File Offset: 0x008832E0
	[NullableContext(1)]
	protected __TsTaskSetNowTime_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskSetNowTime.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E37A RID: 123770 RVA: 0x00885113 File Offset: 0x00883313
	protected __TsTaskSetNowTime_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
