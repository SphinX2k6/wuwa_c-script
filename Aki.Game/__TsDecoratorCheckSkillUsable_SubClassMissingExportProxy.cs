using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035BB RID: 13755
public class __TsDecoratorCheckSkillUsable_SubClassMissingExportProxy : __TsDecoratorCheckSkillUsable_InheritProxy
{
	// Token: 0x0601E0C0 RID: 123072 RVA: 0x0087EED4 File Offset: 0x0087D0D4
	[NullableContext(1)]
	protected __TsDecoratorCheckSkillUsable_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckSkillUsable.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E0C1 RID: 123073 RVA: 0x0087EF07 File Offset: 0x0087D107
	protected __TsDecoratorCheckSkillUsable_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
