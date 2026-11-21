using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E8B RID: 11915
public class __LogicDataSpherePull_InheritProxy : LogicDataSpherePull
{
	// Token: 0x0601C854 RID: 116820 RVA: 0x008BCBD4 File Offset: 0x008BADD4
	[NullableContext(1)]
	public __LogicDataSpherePull_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSpherePull.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C855 RID: 116821 RVA: 0x008BCC07 File Offset: 0x008BAE07
	protected __LogicDataSpherePull_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
