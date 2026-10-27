using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020036B5 RID: 14005
public class __TsTaskSetCoolDown_SubClassMissingExportProxy : __TsTaskSetCoolDown_InheritProxy
{
	// Token: 0x0601E374 RID: 123764 RVA: 0x00885034 File Offset: 0x00883234
	[NullableContext(1)]
	protected __TsTaskSetCoolDown_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskSetCoolDown.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E375 RID: 123765 RVA: 0x00885067 File Offset: 0x00883267
	protected __TsTaskSetCoolDown_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
