using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002C26 RID: 11302
public class __TsTaskSelectSkill_SubClassMissingExportProxy : __TsTaskSelectSkill_InheritProxy
{
	// Token: 0x0601C083 RID: 114819 RVA: 0x008AC8BC File Offset: 0x008AAABC
	[NullableContext(1)]
	protected __TsTaskSelectSkill_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskSelectSkill.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C084 RID: 114820 RVA: 0x008AC8EF File Offset: 0x008AAAEF
	protected __TsTaskSelectSkill_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
