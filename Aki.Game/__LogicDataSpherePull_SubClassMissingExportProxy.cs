using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E8C RID: 11916
public class __LogicDataSpherePull_SubClassMissingExportProxy : __LogicDataSpherePull_InheritProxy
{
	// Token: 0x0601C856 RID: 116822 RVA: 0x008BCC10 File Offset: 0x008BAE10
	[NullableContext(1)]
	protected __LogicDataSpherePull_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSpherePull.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C857 RID: 116823 RVA: 0x008BCC43 File Offset: 0x008BAE43
	protected __LogicDataSpherePull_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
