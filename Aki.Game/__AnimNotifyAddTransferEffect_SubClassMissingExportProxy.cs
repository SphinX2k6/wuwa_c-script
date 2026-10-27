using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003973 RID: 14707
public class __AnimNotifyAddTransferEffect_SubClassMissingExportProxy : __AnimNotifyAddTransferEffect_InheritProxy
{
	// Token: 0x0601ED3B RID: 126267 RVA: 0x0089D0D8 File Offset: 0x0089B2D8
	[NullableContext(1)]
	protected __AnimNotifyAddTransferEffect_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyAddTransferEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601ED3C RID: 126268 RVA: 0x0089D10B File Offset: 0x0089B30B
	protected __AnimNotifyAddTransferEffect_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
