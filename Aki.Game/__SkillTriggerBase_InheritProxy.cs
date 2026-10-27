using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003938 RID: 14648
public class __SkillTriggerBase_InheritProxy : SkillTriggerBase
{
	// Token: 0x0601EC00 RID: 125952 RVA: 0x00899580 File Offset: 0x00897780
	[NullableContext(1)]
	public __SkillTriggerBase_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SkillTriggerBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EC01 RID: 125953 RVA: 0x008995B3 File Offset: 0x008977B3
	protected __SkillTriggerBase_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
