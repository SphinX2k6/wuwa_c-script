using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E1B RID: 11803
public class __KscBulletData_InheritProxy : KscBulletData
{
	// Token: 0x0601C722 RID: 116514 RVA: 0x008BABFC File Offset: 0x008B8DFC
	[NullableContext(1)]
	public __KscBulletData_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(KscBulletData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C723 RID: 116515 RVA: 0x008BAC2F File Offset: 0x008B8E2F
	protected __KscBulletData_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
