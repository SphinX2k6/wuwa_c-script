using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F4A RID: 12106
public class __TsEntityDebugInfoManager_SubClassMissingExportProxy : __TsEntityDebugInfoManager_InheritProxy
{
	// Token: 0x0601CB09 RID: 117513 RVA: 0x008C13A8 File Offset: 0x008BF5A8
	[NullableContext(1)]
	protected __TsEntityDebugInfoManager_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsEntityDebugInfoManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CB0A RID: 117514 RVA: 0x008C13DB File Offset: 0x008BF5DB
	protected __TsEntityDebugInfoManager_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
