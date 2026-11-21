using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002BC2 RID: 11202
public class __TsTaskAiUseItem_SubClassMissingExportProxy : __TsTaskAiUseItem_InheritProxy
{
	// Token: 0x0601BF6D RID: 114541 RVA: 0x008AA3E4 File Offset: 0x008A85E4
	[NullableContext(1)]
	protected __TsTaskAiUseItem_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskAiUseItem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BF6E RID: 114542 RVA: 0x008AA417 File Offset: 0x008A8617
	protected __TsTaskAiUseItem_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
