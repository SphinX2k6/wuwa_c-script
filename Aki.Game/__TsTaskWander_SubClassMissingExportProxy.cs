using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020036DF RID: 14047
public class __TsTaskWander_SubClassMissingExportProxy : __TsTaskWander_InheritProxy
{
	// Token: 0x0601E3EB RID: 123883 RVA: 0x0088611C File Offset: 0x0088431C
	[NullableContext(1)]
	protected __TsTaskWander_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskWander.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E3EC RID: 123884 RVA: 0x0088614F File Offset: 0x0088434F
	protected __TsTaskWander_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
