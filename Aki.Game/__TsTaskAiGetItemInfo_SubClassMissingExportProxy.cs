using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002BBC RID: 11196
public class __TsTaskAiGetItemInfo_SubClassMissingExportProxy : __TsTaskAiGetItemInfo_InheritProxy
{
	// Token: 0x0601BF5B RID: 114523 RVA: 0x008AA1A8 File Offset: 0x008A83A8
	[NullableContext(1)]
	protected __TsTaskAiGetItemInfo_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskAiGetItemInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BF5C RID: 114524 RVA: 0x008AA1DB File Offset: 0x008A83DB
	protected __TsTaskAiGetItemInfo_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
