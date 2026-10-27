using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200362B RID: 13867
public class __TsTaskGetTargetInfo_SubClassMissingExportProxy : __TsTaskGetTargetInfo_InheritProxy
{
	// Token: 0x0601E1E5 RID: 123365 RVA: 0x00881698 File Offset: 0x0087F898
	[NullableContext(1)]
	protected __TsTaskGetTargetInfo_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskGetTargetInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E1E6 RID: 123366 RVA: 0x008816CB File Offset: 0x0087F8CB
	protected __TsTaskGetTargetInfo_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
