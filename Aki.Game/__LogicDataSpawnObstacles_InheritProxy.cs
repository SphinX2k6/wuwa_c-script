using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200390E RID: 14606
public class __LogicDataSpawnObstacles_InheritProxy : LogicDataSpawnObstacles
{
	// Token: 0x0601EB94 RID: 125844 RVA: 0x00898640 File Offset: 0x00896840
	[NullableContext(1)]
	public __LogicDataSpawnObstacles_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSpawnObstacles.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB95 RID: 125845 RVA: 0x00898673 File Offset: 0x00896873
	protected __LogicDataSpawnObstacles_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
