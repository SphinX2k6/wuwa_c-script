using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003939 RID: 14649
public class __SkillTriggerBase_SubClassMissingExportProxy : __SkillTriggerBase_InheritProxy
{
	// Token: 0x0601EC02 RID: 125954 RVA: 0x008995BC File Offset: 0x008977BC
	[NullableContext(1)]
	protected __SkillTriggerBase_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SkillTriggerBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EC03 RID: 125955 RVA: 0x008995EF File Offset: 0x008977EF
	protected __SkillTriggerBase_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
