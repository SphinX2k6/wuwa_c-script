using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E48 RID: 11848
public class __TsTowerDefenseEventActor_SubClassMissingExportProxy : __TsTowerDefenseEventActor_InheritProxy
{
	// Token: 0x0601C7A8 RID: 116648 RVA: 0x008BBA3C File Offset: 0x008B9C3C
	[NullableContext(1)]
	protected __TsTowerDefenseEventActor_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTowerDefenseEventActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C7A9 RID: 116649 RVA: 0x008BBA6F File Offset: 0x008B9C6F
	protected __TsTowerDefenseEventActor_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
