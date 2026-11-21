using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002D88 RID: 11656
public class __TsAnimNotifyDetach_SubClassMissingExportProxy : __TsAnimNotifyDetach_InheritProxy
{
	// Token: 0x0601C557 RID: 116055 RVA: 0x008B74D0 File Offset: 0x008B56D0
	[NullableContext(1)]
	protected __TsAnimNotifyDetach_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyDetach.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C558 RID: 116056 RVA: 0x008B7503 File Offset: 0x008B5703
	protected __TsAnimNotifyDetach_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
