using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038FB RID: 14587
public class __LogicDataDestroyOtherBullet_SubClassMissingExportProxy : __LogicDataDestroyOtherBullet_InheritProxy
{
	// Token: 0x0601EB6E RID: 125806 RVA: 0x008981CC File Offset: 0x008963CC
	[NullableContext(1)]
	protected __LogicDataDestroyOtherBullet_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataDestroyOtherBullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB6F RID: 125807 RVA: 0x008981FF File Offset: 0x008963FF
	protected __LogicDataDestroyOtherBullet_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
