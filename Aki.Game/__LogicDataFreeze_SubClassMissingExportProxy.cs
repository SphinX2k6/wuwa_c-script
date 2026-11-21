using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E7A RID: 11898
public class __LogicDataFreeze_SubClassMissingExportProxy : __LogicDataFreeze_InheritProxy
{
	// Token: 0x0601C832 RID: 116786 RVA: 0x008BC7D8 File Offset: 0x008BA9D8
	[NullableContext(1)]
	protected __LogicDataFreeze_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataFreeze.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C833 RID: 116787 RVA: 0x008BC80B File Offset: 0x008BAA0B
	protected __LogicDataFreeze_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
