using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002C32 RID: 11314
public class __TsTaskSkillWander_SubClassMissingExportProxy : __TsTaskSkillWander_InheritProxy
{
	// Token: 0x0601C0A2 RID: 114850 RVA: 0x008ACCE8 File Offset: 0x008AAEE8
	[NullableContext(1)]
	protected __TsTaskSkillWander_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskSkillWander.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C0A3 RID: 114851 RVA: 0x008ACD1B File Offset: 0x008AAF1B
	protected __TsTaskSkillWander_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
