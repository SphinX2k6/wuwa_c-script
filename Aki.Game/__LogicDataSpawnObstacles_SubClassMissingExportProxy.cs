using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200390F RID: 14607
public class __LogicDataSpawnObstacles_SubClassMissingExportProxy : __LogicDataSpawnObstacles_InheritProxy
{
	// Token: 0x0601EB96 RID: 125846 RVA: 0x0089867C File Offset: 0x0089687C
	[NullableContext(1)]
	protected __LogicDataSpawnObstacles_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSpawnObstacles.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB97 RID: 125847 RVA: 0x008986AF File Offset: 0x008968AF
	protected __LogicDataSpawnObstacles_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
