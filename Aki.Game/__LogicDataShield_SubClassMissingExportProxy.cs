using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E84 RID: 11908
public class __LogicDataShield_SubClassMissingExportProxy : __LogicDataShield_InheritProxy
{
	// Token: 0x0601C846 RID: 116806 RVA: 0x008BCA30 File Offset: 0x008BAC30
	[NullableContext(1)]
	protected __LogicDataShield_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataShield.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C847 RID: 116807 RVA: 0x008BCA63 File Offset: 0x008BAC63
	protected __LogicDataShield_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
