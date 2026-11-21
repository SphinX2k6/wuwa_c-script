using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002BAA RID: 11178
public class __TsTaskNpcPatrol_SubClassMissingExportProxy : __TsTaskNpcPatrol_InheritProxy
{
	// Token: 0x0601BF2A RID: 114474 RVA: 0x008A9B44 File Offset: 0x008A7D44
	[NullableContext(1)]
	protected __TsTaskNpcPatrol_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskNpcPatrol.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BF2B RID: 114475 RVA: 0x008A9B77 File Offset: 0x008A7D77
	protected __TsTaskNpcPatrol_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
