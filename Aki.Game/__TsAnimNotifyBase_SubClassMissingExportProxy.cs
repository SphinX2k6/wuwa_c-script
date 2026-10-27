using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020037DB RID: 14299
public class __TsAnimNotifyBase_SubClassMissingExportProxy : __TsAnimNotifyBase_InheritProxy
{
	// Token: 0x0601E7C2 RID: 124866 RVA: 0x0088FD54 File Offset: 0x0088DF54
	[NullableContext(1)]
	protected __TsAnimNotifyBase_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E7C3 RID: 124867 RVA: 0x0088FD87 File Offset: 0x0088DF87
	protected __TsAnimNotifyBase_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
