using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035BF RID: 13759
public class __TsDecoratorCoolDown_SubClassMissingExportProxy : __TsDecoratorCoolDown_InheritProxy
{
	// Token: 0x0601E0CA RID: 123082 RVA: 0x0087F02C File Offset: 0x0087D22C
	[NullableContext(1)]
	protected __TsDecoratorCoolDown_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCoolDown.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E0CB RID: 123083 RVA: 0x0087F05F File Offset: 0x0087D25F
	protected __TsDecoratorCoolDown_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
