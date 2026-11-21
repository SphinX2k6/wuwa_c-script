using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002C2A RID: 11306
public class __TsTaskSetCoolDown_SubClassMissingExportProxy : __TsTaskSetCoolDown_InheritProxy
{
	// Token: 0x0601C08D RID: 114829 RVA: 0x008ACA0C File Offset: 0x008AAC0C
	[NullableContext(1)]
	protected __TsTaskSetCoolDown_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskSetCoolDown.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C08E RID: 114830 RVA: 0x008ACA3F File Offset: 0x008AAC3F
	protected __TsTaskSetCoolDown_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
