using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038A2 RID: 14498
public class __KscBulletData_InheritProxy : KscBulletData
{
	// Token: 0x0601EA47 RID: 125511 RVA: 0x00895684 File Offset: 0x00893884
	[NullableContext(1)]
	public __KscBulletData_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(KscBulletData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EA48 RID: 125512 RVA: 0x008956B7 File Offset: 0x008938B7
	protected __KscBulletData_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
