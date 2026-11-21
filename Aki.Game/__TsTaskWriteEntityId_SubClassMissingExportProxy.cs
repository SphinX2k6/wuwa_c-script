using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002C56 RID: 11350
public class __TsTaskWriteEntityId_SubClassMissingExportProxy : __TsTaskWriteEntityId_InheritProxy
{
	// Token: 0x0601C106 RID: 114950 RVA: 0x008ADA50 File Offset: 0x008ABC50
	[NullableContext(1)]
	protected __TsTaskWriteEntityId_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskWriteEntityId.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C107 RID: 114951 RVA: 0x008ADA83 File Offset: 0x008ABC83
	protected __TsTaskWriteEntityId_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
