using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EB5 RID: 11957
public class __SkillTriggerGameplayTag_InheritProxy : SkillTriggerGameplayTag
{
	// Token: 0x0601C8B5 RID: 116917 RVA: 0x008BD62C File Offset: 0x008BB82C
	[NullableContext(1)]
	public __SkillTriggerGameplayTag_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SkillTriggerGameplayTag.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C8B6 RID: 116918 RVA: 0x008BD65F File Offset: 0x008BB85F
	protected __SkillTriggerGameplayTag_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
