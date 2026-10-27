using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003961 RID: 14689
public class __TsRecordEffect_SubClassMissingExportProxy : __TsRecordEffect_InheritProxy
{
	// Token: 0x0601ECBE RID: 126142 RVA: 0x0089B85C File Offset: 0x00899A5C
	[NullableContext(1)]
	protected __TsRecordEffect_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsRecordEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601ECBF RID: 126143 RVA: 0x0089B88F File Offset: 0x00899A8F
	protected __TsRecordEffect_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
