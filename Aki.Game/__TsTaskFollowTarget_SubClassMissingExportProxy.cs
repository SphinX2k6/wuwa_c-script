using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002BF8 RID: 11256
public class __TsTaskFollowTarget_SubClassMissingExportProxy : __TsTaskFollowTarget_InheritProxy
{
	// Token: 0x0601C007 RID: 114695 RVA: 0x008AB7C0 File Offset: 0x008A99C0
	[NullableContext(1)]
	protected __TsTaskFollowTarget_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskFollowTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C008 RID: 114696 RVA: 0x008AB7F3 File Offset: 0x008A99F3
	protected __TsTaskFollowTarget_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
