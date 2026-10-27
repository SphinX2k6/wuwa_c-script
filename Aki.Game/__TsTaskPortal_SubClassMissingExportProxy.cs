using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020036A5 RID: 13989
public class __TsTaskPortal_SubClassMissingExportProxy : __TsTaskPortal_InheritProxy
{
	// Token: 0x0601E34B RID: 123723 RVA: 0x00884AB8 File Offset: 0x00882CB8
	[NullableContext(1)]
	protected __TsTaskPortal_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskPortal.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E34C RID: 123724 RVA: 0x00884AEB File Offset: 0x00882CEB
	protected __TsTaskPortal_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
