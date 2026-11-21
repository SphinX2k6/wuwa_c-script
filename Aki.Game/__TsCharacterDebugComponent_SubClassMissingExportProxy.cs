using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E98 RID: 11928
public class __TsCharacterDebugComponent_SubClassMissingExportProxy : __TsCharacterDebugComponent_InheritProxy
{
	// Token: 0x0601C87B RID: 116859 RVA: 0x008BCF60 File Offset: 0x008BB160
	[NullableContext(1)]
	protected __TsCharacterDebugComponent_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsCharacterDebugComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C87C RID: 116860 RVA: 0x008BCF93 File Offset: 0x008BB193
	protected __TsCharacterDebugComponent_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
