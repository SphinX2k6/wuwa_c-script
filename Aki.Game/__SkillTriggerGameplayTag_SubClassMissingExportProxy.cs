using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EB6 RID: 11958
public class __SkillTriggerGameplayTag_SubClassMissingExportProxy : __SkillTriggerGameplayTag_InheritProxy
{
	// Token: 0x0601C8B7 RID: 116919 RVA: 0x008BD668 File Offset: 0x008BB868
	[NullableContext(1)]
	protected __SkillTriggerGameplayTag_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SkillTriggerGameplayTag.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C8B8 RID: 116920 RVA: 0x008BD69B File Offset: 0x008BB89B
	protected __SkillTriggerGameplayTag_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
