using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020036FF RID: 14079
public class __TsAnimNotifyStateBase_SubClassMissingExportProxy : __TsAnimNotifyStateBase_InheritProxy
{
	// Token: 0x0601E4B4 RID: 124084 RVA: 0x00888CD4 File Offset: 0x00886ED4
	[NullableContext(1)]
	protected __TsAnimNotifyStateBase_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E4B5 RID: 124085 RVA: 0x00888D07 File Offset: 0x00886F07
	protected __TsAnimNotifyStateBase_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
