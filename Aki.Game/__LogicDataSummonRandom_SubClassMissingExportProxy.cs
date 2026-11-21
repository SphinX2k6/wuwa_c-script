using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E92 RID: 11922
public class __LogicDataSummonRandom_SubClassMissingExportProxy : __LogicDataSummonRandom_InheritProxy
{
	// Token: 0x0601C862 RID: 116834 RVA: 0x008BCD78 File Offset: 0x008BAF78
	[NullableContext(1)]
	protected __LogicDataSummonRandom_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSummonRandom.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C863 RID: 116835 RVA: 0x008BCDAB File Offset: 0x008BAFAB
	protected __LogicDataSummonRandom_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
