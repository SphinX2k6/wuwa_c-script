using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038CF RID: 14543
public class __TsTowerDefenseEventActor_SubClassMissingExportProxy : __TsTowerDefenseEventActor_InheritProxy
{
	// Token: 0x0601EAEE RID: 125678 RVA: 0x008974A8 File Offset: 0x008956A8
	[NullableContext(1)]
	protected __TsTowerDefenseEventActor_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTowerDefenseEventActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EAEF RID: 125679 RVA: 0x008974DB File Offset: 0x008956DB
	protected __TsTowerDefenseEventActor_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
