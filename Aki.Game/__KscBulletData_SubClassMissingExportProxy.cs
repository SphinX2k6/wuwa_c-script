using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E1C RID: 11804
public class __KscBulletData_SubClassMissingExportProxy : __KscBulletData_InheritProxy
{
	// Token: 0x0601C724 RID: 116516 RVA: 0x008BAC38 File Offset: 0x008B8E38
	[NullableContext(1)]
	protected __KscBulletData_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(KscBulletData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C725 RID: 116517 RVA: 0x008BAC6B File Offset: 0x008B8E6B
	protected __KscBulletData_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
