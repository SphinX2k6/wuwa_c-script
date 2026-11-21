using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E8A RID: 11914
public class __LogicDataSpeedReduce_SubClassMissingExportProxy : __LogicDataSpeedReduce_InheritProxy
{
	// Token: 0x0601C852 RID: 116818 RVA: 0x008BCB98 File Offset: 0x008BAD98
	[NullableContext(1)]
	protected __LogicDataSpeedReduce_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSpeedReduce.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C853 RID: 116819 RVA: 0x008BCBCB File Offset: 0x008BADCB
	protected __LogicDataSpeedReduce_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
