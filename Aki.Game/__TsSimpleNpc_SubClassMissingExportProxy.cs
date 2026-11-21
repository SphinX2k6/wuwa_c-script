using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EB8 RID: 11960
public class __TsSimpleNpc_SubClassMissingExportProxy : __TsSimpleNpc_InheritProxy
{
	// Token: 0x0601C8C8 RID: 116936 RVA: 0x008BD79C File Offset: 0x008BB99C
	[NullableContext(1)]
	protected __TsSimpleNpc_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSimpleNpc.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C8C9 RID: 116937 RVA: 0x008BD7CF File Offset: 0x008BB9CF
	protected __TsSimpleNpc_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
