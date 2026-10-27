using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020036CB RID: 14027
public class __TsTaskTeamWander_SubClassMissingExportProxy : __TsTaskTeamWander_InheritProxy
{
	// Token: 0x0601E3AD RID: 123821 RVA: 0x008857E0 File Offset: 0x008839E0
	[NullableContext(1)]
	protected __TsTaskTeamWander_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskTeamWander.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E3AE RID: 123822 RVA: 0x00885813 File Offset: 0x00883A13
	protected __TsTaskTeamWander_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
