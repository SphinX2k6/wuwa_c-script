using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020036E1 RID: 14049
public class __TsTaskWriteEntityId_SubClassMissingExportProxy : __TsTaskWriteEntityId_InheritProxy
{
	// Token: 0x0601E3F0 RID: 123888 RVA: 0x008861C8 File Offset: 0x008843C8
	[NullableContext(1)]
	protected __TsTaskWriteEntityId_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskWriteEntityId.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E3F1 RID: 123889 RVA: 0x008861FB File Offset: 0x008843FB
	protected __TsTaskWriteEntityId_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
