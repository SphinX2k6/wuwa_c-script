using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E7B RID: 11899
public class __LogicDataManipulatableCreateBullet_InheritProxy : LogicDataManipulatableCreateBullet
{
	// Token: 0x0601C834 RID: 116788 RVA: 0x008BC814 File Offset: 0x008BAA14
	[NullableContext(1)]
	public __LogicDataManipulatableCreateBullet_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataManipulatableCreateBullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C835 RID: 116789 RVA: 0x008BC847 File Offset: 0x008BAA47
	protected __LogicDataManipulatableCreateBullet_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
