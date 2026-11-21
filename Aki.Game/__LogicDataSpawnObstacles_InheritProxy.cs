using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E87 RID: 11911
public class __LogicDataSpawnObstacles_InheritProxy : LogicDataSpawnObstacles
{
	// Token: 0x0601C84C RID: 116812 RVA: 0x008BCAE4 File Offset: 0x008BACE4
	[NullableContext(1)]
	public __LogicDataSpawnObstacles_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSpawnObstacles.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C84D RID: 116813 RVA: 0x008BCB17 File Offset: 0x008BAD17
	protected __LogicDataSpawnObstacles_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
