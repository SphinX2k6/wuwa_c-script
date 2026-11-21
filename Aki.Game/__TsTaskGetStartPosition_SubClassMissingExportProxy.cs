using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002BFC RID: 11260
public class __TsTaskGetStartPosition_SubClassMissingExportProxy : __TsTaskGetStartPosition_InheritProxy
{
	// Token: 0x0601C011 RID: 114705 RVA: 0x008AB910 File Offset: 0x008A9B10
	[NullableContext(1)]
	protected __TsTaskGetStartPosition_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskGetStartPosition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C012 RID: 114706 RVA: 0x008AB943 File Offset: 0x008A9B43
	protected __TsTaskGetStartPosition_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
