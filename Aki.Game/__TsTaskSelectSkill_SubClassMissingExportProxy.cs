using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020036B1 RID: 14001
public class __TsTaskSelectSkill_SubClassMissingExportProxy : __TsTaskSelectSkill_InheritProxy
{
	// Token: 0x0601E36A RID: 123754 RVA: 0x00884EE4 File Offset: 0x008830E4
	[NullableContext(1)]
	protected __TsTaskSelectSkill_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskSelectSkill.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E36B RID: 123755 RVA: 0x00884F17 File Offset: 0x00883117
	protected __TsTaskSelectSkill_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
