using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002C40 RID: 11328
public class __TsTaskTeamWander_SubClassMissingExportProxy : __TsTaskTeamWander_InheritProxy
{
	// Token: 0x0601C0C6 RID: 114886 RVA: 0x008AD1B8 File Offset: 0x008AB3B8
	[NullableContext(1)]
	protected __TsTaskTeamWander_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskTeamWander.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C0C7 RID: 114887 RVA: 0x008AD1EB File Offset: 0x008AB3EB
	protected __TsTaskTeamWander_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
