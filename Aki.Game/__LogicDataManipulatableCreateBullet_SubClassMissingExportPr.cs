using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E7C RID: 11900
public class __LogicDataManipulatableCreateBullet_SubClassMissingExportProxy : __LogicDataManipulatableCreateBullet_InheritProxy
{
	// Token: 0x0601C836 RID: 116790 RVA: 0x008BC850 File Offset: 0x008BAA50
	[NullableContext(1)]
	protected __LogicDataManipulatableCreateBullet_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataManipulatableCreateBullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C837 RID: 116791 RVA: 0x008BC883 File Offset: 0x008BAA83
	protected __LogicDataManipulatableCreateBullet_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
