using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038A3 RID: 14499
public class __KscBulletData_SubClassMissingExportProxy : __KscBulletData_InheritProxy
{
	// Token: 0x0601EA49 RID: 125513 RVA: 0x008956C0 File Offset: 0x008938C0
	[NullableContext(1)]
	protected __KscBulletData_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(KscBulletData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EA4A RID: 125514 RVA: 0x008956F3 File Offset: 0x008938F3
	protected __KscBulletData_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
