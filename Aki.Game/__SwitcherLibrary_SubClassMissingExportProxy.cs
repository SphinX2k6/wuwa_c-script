using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039CB RID: 14795
public class __SwitcherLibrary_SubClassMissingExportProxy : __SwitcherLibrary_InheritProxy
{
	// Token: 0x0601EF15 RID: 126741 RVA: 0x008A35C0 File Offset: 0x008A17C0
	[NullableContext(1)]
	protected __SwitcherLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SwitcherLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EF16 RID: 126742 RVA: 0x008A35F3 File Offset: 0x008A17F3
	protected __SwitcherLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
