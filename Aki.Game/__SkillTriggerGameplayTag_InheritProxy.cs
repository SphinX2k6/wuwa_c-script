using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200393A RID: 14650
public class __SkillTriggerGameplayTag_InheritProxy : SkillTriggerGameplayTag
{
	// Token: 0x0601EC04 RID: 125956 RVA: 0x008995F8 File Offset: 0x008977F8
	[NullableContext(1)]
	public __SkillTriggerGameplayTag_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SkillTriggerGameplayTag.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EC05 RID: 125957 RVA: 0x0089962B File Offset: 0x0089782B
	protected __SkillTriggerGameplayTag_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
