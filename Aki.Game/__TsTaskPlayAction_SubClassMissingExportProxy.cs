using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003699 RID: 13977
public class __TsTaskPlayAction_SubClassMissingExportProxy : __TsTaskPlayAction_InheritProxy
{
	// Token: 0x0601E32B RID: 123691 RVA: 0x00884660 File Offset: 0x00882860
	[NullableContext(1)]
	protected __TsTaskPlayAction_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskPlayAction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E32C RID: 123692 RVA: 0x00884693 File Offset: 0x00882893
	protected __TsTaskPlayAction_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
