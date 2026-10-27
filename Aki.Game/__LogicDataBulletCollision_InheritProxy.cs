using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038F2 RID: 14578
public class __LogicDataBulletCollision_InheritProxy : LogicDataBulletCollision
{
	// Token: 0x0601EB5C RID: 125788 RVA: 0x00897FB0 File Offset: 0x008961B0
	[NullableContext(1)]
	public __LogicDataBulletCollision_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataBulletCollision.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB5D RID: 125789 RVA: 0x00897FE3 File Offset: 0x008961E3
	protected __LogicDataBulletCollision_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
