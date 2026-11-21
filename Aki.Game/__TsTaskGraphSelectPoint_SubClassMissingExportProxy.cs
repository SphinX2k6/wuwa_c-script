using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B6C RID: 11116
public class __TsTaskGraphSelectPoint_SubClassMissingExportProxy : __TsTaskGraphSelectPoint_InheritProxy
{
	// Token: 0x0601BE81 RID: 114305 RVA: 0x008A8418 File Offset: 0x008A6618
	[NullableContext(1)]
	protected __TsTaskGraphSelectPoint_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskGraphSelectPoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BE82 RID: 114306 RVA: 0x008A844B File Offset: 0x008A664B
	protected __TsTaskGraphSelectPoint_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
