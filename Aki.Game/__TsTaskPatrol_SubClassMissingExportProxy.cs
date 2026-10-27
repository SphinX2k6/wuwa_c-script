using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003693 RID: 13971
public class __TsTaskPatrol_SubClassMissingExportProxy : __TsTaskPatrol_InheritProxy
{
	// Token: 0x0601E31A RID: 123674 RVA: 0x00884400 File Offset: 0x00882600
	[NullableContext(1)]
	protected __TsTaskPatrol_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskPatrol.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E31B RID: 123675 RVA: 0x00884433 File Offset: 0x00882633
	protected __TsTaskPatrol_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
