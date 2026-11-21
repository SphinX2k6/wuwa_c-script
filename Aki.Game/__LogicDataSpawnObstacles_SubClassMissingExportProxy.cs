using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E88 RID: 11912
public class __LogicDataSpawnObstacles_SubClassMissingExportProxy : __LogicDataSpawnObstacles_InheritProxy
{
	// Token: 0x0601C84E RID: 116814 RVA: 0x008BCB20 File Offset: 0x008BAD20
	[NullableContext(1)]
	protected __LogicDataSpawnObstacles_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSpawnObstacles.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C84F RID: 116815 RVA: 0x008BCB53 File Offset: 0x008BAD53
	protected __LogicDataSpawnObstacles_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
