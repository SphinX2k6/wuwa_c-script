using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B3E RID: 11070
public class __TsDecoratorGeneralConditionCheck_SubClassMissingExportProxy : __TsDecoratorGeneralConditionCheck_InheritProxy
{
	// Token: 0x0601BE0B RID: 114187 RVA: 0x008A741C File Offset: 0x008A561C
	[NullableContext(1)]
	protected __TsDecoratorGeneralConditionCheck_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorGeneralConditionCheck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BE0C RID: 114188 RVA: 0x008A744F File Offset: 0x008A564F
	protected __TsDecoratorGeneralConditionCheck_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
