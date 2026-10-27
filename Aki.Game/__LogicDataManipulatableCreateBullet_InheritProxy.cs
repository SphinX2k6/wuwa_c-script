using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003902 RID: 14594
public class __LogicDataManipulatableCreateBullet_InheritProxy : LogicDataManipulatableCreateBullet
{
	// Token: 0x0601EB7C RID: 125820 RVA: 0x00898370 File Offset: 0x00896570
	[NullableContext(1)]
	public __LogicDataManipulatableCreateBullet_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataManipulatableCreateBullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB7D RID: 125821 RVA: 0x008983A3 File Offset: 0x008965A3
	protected __LogicDataManipulatableCreateBullet_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
