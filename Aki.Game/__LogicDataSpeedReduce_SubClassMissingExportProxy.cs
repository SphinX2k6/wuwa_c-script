using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003911 RID: 14609
public class __LogicDataSpeedReduce_SubClassMissingExportProxy : __LogicDataSpeedReduce_InheritProxy
{
	// Token: 0x0601EB9A RID: 125850 RVA: 0x008986F4 File Offset: 0x008968F4
	[NullableContext(1)]
	protected __LogicDataSpeedReduce_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSpeedReduce.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB9B RID: 125851 RVA: 0x00898727 File Offset: 0x00896927
	protected __LogicDataSpeedReduce_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
