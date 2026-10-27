using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035ED RID: 13805
public class __TsServiceNpcPerceptionDecision_SubClassMissingExportProxy : __TsServiceNpcPerceptionDecision_InheritProxy
{
	// Token: 0x0601E13E RID: 123198 RVA: 0x0087FFD0 File Offset: 0x0087E1D0
	[NullableContext(1)]
	protected __TsServiceNpcPerceptionDecision_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsServiceNpcPerceptionDecision.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E13F RID: 123199 RVA: 0x00880003 File Offset: 0x0087E203
	protected __TsServiceNpcPerceptionDecision_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
