using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E82 RID: 11906
public class __LogicDataShakeScreen_SubClassMissingExportProxy : __LogicDataShakeScreen_InheritProxy
{
	// Token: 0x0601C842 RID: 116802 RVA: 0x008BC9B8 File Offset: 0x008BABB8
	[NullableContext(1)]
	protected __LogicDataShakeScreen_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataShakeScreen.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C843 RID: 116803 RVA: 0x008BC9EB File Offset: 0x008BABEB
	protected __LogicDataShakeScreen_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
