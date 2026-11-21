using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002C0A RID: 11274
public class __TsTaskPatrolLogic_SubClassMissingExportProxy : __TsTaskPatrolLogic_InheritProxy
{
	// Token: 0x0601C039 RID: 114745 RVA: 0x008ABEB4 File Offset: 0x008AA0B4
	[NullableContext(1)]
	protected __TsTaskPatrolLogic_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskPatrolLogic.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C03A RID: 114746 RVA: 0x008ABEE7 File Offset: 0x008AA0E7
	protected __TsTaskPatrolLogic_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
