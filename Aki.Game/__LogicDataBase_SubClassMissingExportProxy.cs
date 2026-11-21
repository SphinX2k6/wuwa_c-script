using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E6A RID: 11882
public class __LogicDataBase_SubClassMissingExportProxy : __LogicDataBase_InheritProxy
{
	// Token: 0x0601C812 RID: 116754 RVA: 0x008BC418 File Offset: 0x008BA618
	[NullableContext(1)]
	protected __LogicDataBase_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C813 RID: 116755 RVA: 0x008BC44B File Offset: 0x008BA64B
	protected __LogicDataBase_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
