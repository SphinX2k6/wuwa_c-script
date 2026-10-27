using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003635 RID: 13877
public class __TsTaskNpcPatrol_SubClassMissingExportProxy : __TsTaskNpcPatrol_InheritProxy
{
	// Token: 0x0601E202 RID: 123394 RVA: 0x00881AB0 File Offset: 0x0087FCB0
	[NullableContext(1)]
	protected __TsTaskNpcPatrol_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskNpcPatrol.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E203 RID: 123395 RVA: 0x00881AE3 File Offset: 0x0087FCE3
	protected __TsTaskNpcPatrol_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
