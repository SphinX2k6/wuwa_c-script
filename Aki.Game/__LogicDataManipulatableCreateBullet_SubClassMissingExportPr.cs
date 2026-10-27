using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003903 RID: 14595
public class __LogicDataManipulatableCreateBullet_SubClassMissingExportProxy : __LogicDataManipulatableCreateBullet_InheritProxy
{
	// Token: 0x0601EB7E RID: 125822 RVA: 0x008983AC File Offset: 0x008965AC
	[NullableContext(1)]
	protected __LogicDataManipulatableCreateBullet_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataManipulatableCreateBullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB7F RID: 125823 RVA: 0x008983DF File Offset: 0x008965DF
	protected __LogicDataManipulatableCreateBullet_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
