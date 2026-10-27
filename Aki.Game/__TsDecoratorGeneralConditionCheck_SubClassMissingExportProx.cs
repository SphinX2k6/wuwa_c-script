using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035C9 RID: 13769
public class __TsDecoratorGeneralConditionCheck_SubClassMissingExportProxy : __TsDecoratorGeneralConditionCheck_InheritProxy
{
	// Token: 0x0601E0E3 RID: 123107 RVA: 0x0087F388 File Offset: 0x0087D588
	[NullableContext(1)]
	protected __TsDecoratorGeneralConditionCheck_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorGeneralConditionCheck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E0E4 RID: 123108 RVA: 0x0087F3BB File Offset: 0x0087D5BB
	protected __TsDecoratorGeneralConditionCheck_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
