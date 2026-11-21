using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F46 RID: 12102
public class __SwitcherLibrary_SubClassMissingExportProxy : __SwitcherLibrary_InheritProxy
{
	// Token: 0x0601CAF7 RID: 117495 RVA: 0x008C1198 File Offset: 0x008BF398
	[NullableContext(1)]
	protected __SwitcherLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SwitcherLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CAF8 RID: 117496 RVA: 0x008C11CB File Offset: 0x008BF3CB
	protected __SwitcherLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
