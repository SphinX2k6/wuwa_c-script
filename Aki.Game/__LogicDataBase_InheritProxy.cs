using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E69 RID: 11881
public class __LogicDataBase_InheritProxy : LogicDataBase
{
	// Token: 0x0601C810 RID: 116752 RVA: 0x008BC3DC File Offset: 0x008BA5DC
	[NullableContext(1)]
	public __LogicDataBase_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C811 RID: 116753 RVA: 0x008BC40F File Offset: 0x008BA60F
	protected __LogicDataBase_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
