using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002BBE RID: 11198
public class __TsTaskAiMarkItem_SubClassMissingExportProxy : __TsTaskAiMarkItem_InheritProxy
{
	// Token: 0x0601BF61 RID: 114529 RVA: 0x008AA258 File Offset: 0x008A8458
	[NullableContext(1)]
	protected __TsTaskAiMarkItem_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskAiMarkItem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BF62 RID: 114530 RVA: 0x008AA28B File Offset: 0x008A848B
	protected __TsTaskAiMarkItem_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
