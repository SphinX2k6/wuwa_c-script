using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002C4E RID: 11342
public class __TsTaskUseSkill_SubClassMissingExportProxy : __TsTaskUseSkill_InheritProxy
{
	// Token: 0x0601C0EF RID: 114927 RVA: 0x008AD710 File Offset: 0x008AB910
	[NullableContext(1)]
	protected __TsTaskUseSkill_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskUseSkill.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C0F0 RID: 114928 RVA: 0x008AD743 File Offset: 0x008AB943
	protected __TsTaskUseSkill_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
