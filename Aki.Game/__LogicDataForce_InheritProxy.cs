using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038FE RID: 14590
public class __LogicDataForce_InheritProxy : LogicDataForce
{
	// Token: 0x0601EB74 RID: 125812 RVA: 0x00898280 File Offset: 0x00896480
	[NullableContext(1)]
	public __LogicDataForce_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataForce.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB75 RID: 125813 RVA: 0x008982B3 File Offset: 0x008964B3
	protected __LogicDataForce_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
