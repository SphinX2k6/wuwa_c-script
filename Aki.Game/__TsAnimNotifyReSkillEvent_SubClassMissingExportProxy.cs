using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002DCA RID: 11722
public class __TsAnimNotifyReSkillEvent_SubClassMissingExportProxy : __TsAnimNotifyReSkillEvent_InheritProxy
{
	// Token: 0x0601C61C RID: 116252 RVA: 0x008B8D5C File Offset: 0x008B6F5C
	[NullableContext(1)]
	protected __TsAnimNotifyReSkillEvent_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyReSkillEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C61D RID: 116253 RVA: 0x008B8D8F File Offset: 0x008B6F8F
	protected __TsAnimNotifyReSkillEvent_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
