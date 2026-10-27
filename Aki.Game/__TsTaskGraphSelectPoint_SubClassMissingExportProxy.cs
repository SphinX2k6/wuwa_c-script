using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035F7 RID: 13815
public class __TsTaskGraphSelectPoint_SubClassMissingExportProxy : __TsTaskGraphSelectPoint_InheritProxy
{
	// Token: 0x0601E159 RID: 123225 RVA: 0x00880384 File Offset: 0x0087E584
	[NullableContext(1)]
	protected __TsTaskGraphSelectPoint_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskGraphSelectPoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E15A RID: 123226 RVA: 0x008803B7 File Offset: 0x0087E5B7
	protected __TsTaskGraphSelectPoint_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
