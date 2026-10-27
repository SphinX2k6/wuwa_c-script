using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020036D9 RID: 14041
public class __TsTaskUseSkill_SubClassMissingExportProxy : __TsTaskUseSkill_InheritProxy
{
	// Token: 0x0601E3D9 RID: 123865 RVA: 0x00885E88 File Offset: 0x00884088
	[NullableContext(1)]
	protected __TsTaskUseSkill_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskUseSkill.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E3DA RID: 123866 RVA: 0x00885EBB File Offset: 0x008840BB
	protected __TsTaskUseSkill_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
