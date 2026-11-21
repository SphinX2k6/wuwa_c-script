using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EEE RID: 12014
public class __AnimNotifyAddTransferEffect_SubClassMissingExportProxy : __AnimNotifyAddTransferEffect_InheritProxy
{
	// Token: 0x0601C9A1 RID: 117153 RVA: 0x008BED10 File Offset: 0x008BCF10
	[NullableContext(1)]
	protected __AnimNotifyAddTransferEffect_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyAddTransferEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C9A2 RID: 117154 RVA: 0x008BED43 File Offset: 0x008BCF43
	protected __AnimNotifyAddTransferEffect_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
