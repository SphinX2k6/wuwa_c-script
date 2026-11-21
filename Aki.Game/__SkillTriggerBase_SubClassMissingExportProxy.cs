using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EB4 RID: 11956
public class __SkillTriggerBase_SubClassMissingExportProxy : __SkillTriggerBase_InheritProxy
{
	// Token: 0x0601C8B3 RID: 116915 RVA: 0x008BD5F0 File Offset: 0x008BB7F0
	[NullableContext(1)]
	protected __SkillTriggerBase_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SkillTriggerBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C8B4 RID: 116916 RVA: 0x008BD623 File Offset: 0x008BB823
	protected __SkillTriggerBase_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
