using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020036BB RID: 14011
public class __TsTaskSetTag_SubClassMissingExportProxy : __TsTaskSetTag_InheritProxy
{
	// Token: 0x0601E383 RID: 123779 RVA: 0x00885234 File Offset: 0x00883434
	[NullableContext(1)]
	protected __TsTaskSetTag_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskSetTag.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E384 RID: 123780 RVA: 0x00885267 File Offset: 0x00883467
	protected __TsTaskSetTag_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
