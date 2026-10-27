using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003687 RID: 13959
public class __TsTaskGetStartPosition_SubClassMissingExportProxy : __TsTaskGetStartPosition_InheritProxy
{
	// Token: 0x0601E2F8 RID: 123640 RVA: 0x00883F38 File Offset: 0x00882138
	[NullableContext(1)]
	protected __TsTaskGetStartPosition_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskGetStartPosition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E2F9 RID: 123641 RVA: 0x00883F6B File Offset: 0x0088216B
	protected __TsTaskGetStartPosition_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
