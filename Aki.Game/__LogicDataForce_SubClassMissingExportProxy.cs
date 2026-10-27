using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038FF RID: 14591
public class __LogicDataForce_SubClassMissingExportProxy : __LogicDataForce_InheritProxy
{
	// Token: 0x0601EB76 RID: 125814 RVA: 0x008982BC File Offset: 0x008964BC
	[NullableContext(1)]
	protected __LogicDataForce_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataForce.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB77 RID: 125815 RVA: 0x008982EF File Offset: 0x008964EF
	protected __LogicDataForce_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
