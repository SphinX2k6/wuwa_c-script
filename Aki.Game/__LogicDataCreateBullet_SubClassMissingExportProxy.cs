using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038F7 RID: 14583
public class __LogicDataCreateBullet_SubClassMissingExportProxy : __LogicDataCreateBullet_InheritProxy
{
	// Token: 0x0601EB66 RID: 125798 RVA: 0x008980DC File Offset: 0x008962DC
	[NullableContext(1)]
	protected __LogicDataCreateBullet_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataCreateBullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB67 RID: 125799 RVA: 0x0089810F File Offset: 0x0089630F
	protected __LogicDataCreateBullet_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
