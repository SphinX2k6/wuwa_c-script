using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E85 RID: 11909
public class __LogicDataShowMesh_InheritProxy : LogicDataShowMesh
{
	// Token: 0x0601C848 RID: 116808 RVA: 0x008BCA6C File Offset: 0x008BAC6C
	[NullableContext(1)]
	public __LogicDataShowMesh_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataShowMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C849 RID: 116809 RVA: 0x008BCA9F File Offset: 0x008BAC9F
	protected __LogicDataShowMesh_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
