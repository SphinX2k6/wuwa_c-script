using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038F9 RID: 14585
public class __LogicDataDestroyBullet_SubClassMissingExportProxy : __LogicDataDestroyBullet_InheritProxy
{
	// Token: 0x0601EB6A RID: 125802 RVA: 0x00898154 File Offset: 0x00896354
	[NullableContext(1)]
	protected __LogicDataDestroyBullet_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataDestroyBullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB6B RID: 125803 RVA: 0x00898187 File Offset: 0x00896387
	protected __LogicDataDestroyBullet_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
