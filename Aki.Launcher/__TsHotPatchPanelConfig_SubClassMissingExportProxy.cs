using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02000016 RID: 22
public class __TsHotPatchPanelConfig_SubClassMissingExportProxy : __TsHotPatchPanelConfig_InheritProxy
{
	// Token: 0x060000BC RID: 188 RVA: 0x000074F0 File Offset: 0x000056F0
	[NullableContext(1)]
	protected __TsHotPatchPanelConfig_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsHotPatchPanelConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060000BD RID: 189 RVA: 0x00007523 File Offset: 0x00005723
	protected __TsHotPatchPanelConfig_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
