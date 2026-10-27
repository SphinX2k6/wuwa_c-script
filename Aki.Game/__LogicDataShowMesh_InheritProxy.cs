using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200390C RID: 14604
public class __LogicDataShowMesh_InheritProxy : LogicDataShowMesh
{
	// Token: 0x0601EB90 RID: 125840 RVA: 0x008985C8 File Offset: 0x008967C8
	[NullableContext(1)]
	public __LogicDataShowMesh_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataShowMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB91 RID: 125841 RVA: 0x008985FB File Offset: 0x008967FB
	protected __LogicDataShowMesh_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
