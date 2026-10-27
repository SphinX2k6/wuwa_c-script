using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003917 RID: 14615
public class __LogicDataSummonRandom_SubClassMissingExportProxy : __LogicDataSummonRandom_InheritProxy
{
	// Token: 0x0601EBA6 RID: 125862 RVA: 0x0089885C File Offset: 0x00896A5C
	[NullableContext(1)]
	protected __LogicDataSummonRandom_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSummonRandom.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EBA7 RID: 125863 RVA: 0x0089888F File Offset: 0x00896A8F
	protected __LogicDataSummonRandom_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
