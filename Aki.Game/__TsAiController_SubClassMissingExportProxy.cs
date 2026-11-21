using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002C58 RID: 11352
public class __TsAiController_SubClassMissingExportProxy : __TsAiController_InheritProxy
{
	// Token: 0x0601C138 RID: 115000 RVA: 0x008ADF94 File Offset: 0x008AC194
	[NullableContext(1)]
	protected __TsAiController_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAiController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C139 RID: 115001 RVA: 0x008ADFC7 File Offset: 0x008AC1C7
	protected __TsAiController_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
