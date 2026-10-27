using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003901 RID: 14593
public class __LogicDataFreeze_SubClassMissingExportProxy : __LogicDataFreeze_InheritProxy
{
	// Token: 0x0601EB7A RID: 125818 RVA: 0x00898334 File Offset: 0x00896534
	[NullableContext(1)]
	protected __LogicDataFreeze_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataFreeze.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB7B RID: 125819 RVA: 0x00898367 File Offset: 0x00896567
	protected __LogicDataFreeze_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
