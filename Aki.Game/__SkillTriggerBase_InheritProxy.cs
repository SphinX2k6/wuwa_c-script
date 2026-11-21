using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EB3 RID: 11955
public class __SkillTriggerBase_InheritProxy : SkillTriggerBase
{
	// Token: 0x0601C8B1 RID: 116913 RVA: 0x008BD5B4 File Offset: 0x008BB7B4
	[NullableContext(1)]
	public __SkillTriggerBase_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SkillTriggerBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C8B2 RID: 116914 RVA: 0x008BD5E7 File Offset: 0x008BB7E7
	protected __SkillTriggerBase_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
