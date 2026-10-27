using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035CF RID: 13775
public class __TsDecoratorInTeamArea_SubClassMissingExportProxy : __TsDecoratorInTeamArea_InheritProxy
{
	// Token: 0x0601E0F2 RID: 123122 RVA: 0x0087F58C File Offset: 0x0087D78C
	[NullableContext(1)]
	protected __TsDecoratorInTeamArea_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorInTeamArea.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E0F3 RID: 123123 RVA: 0x0087F5BF File Offset: 0x0087D7BF
	protected __TsDecoratorInTeamArea_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
