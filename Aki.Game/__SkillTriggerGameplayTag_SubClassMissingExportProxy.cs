using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200393B RID: 14651
public class __SkillTriggerGameplayTag_SubClassMissingExportProxy : __SkillTriggerGameplayTag_InheritProxy
{
	// Token: 0x0601EC06 RID: 125958 RVA: 0x00899634 File Offset: 0x00897834
	[NullableContext(1)]
	protected __SkillTriggerGameplayTag_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SkillTriggerGameplayTag.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EC07 RID: 125959 RVA: 0x00899667 File Offset: 0x00897867
	protected __SkillTriggerGameplayTag_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
