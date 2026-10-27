using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038F3 RID: 14579
public class __LogicDataBulletCollision_SubClassMissingExportProxy : __LogicDataBulletCollision_InheritProxy
{
	// Token: 0x0601EB5E RID: 125790 RVA: 0x00897FEC File Offset: 0x008961EC
	[NullableContext(1)]
	protected __LogicDataBulletCollision_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataBulletCollision.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB5F RID: 125791 RVA: 0x0089801F File Offset: 0x0089621F
	protected __LogicDataBulletCollision_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
