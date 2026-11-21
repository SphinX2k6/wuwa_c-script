using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E04 RID: 11780
public class __TsBaseCharacter_SubClassMissingExportProxy : __TsBaseCharacter_InheritProxy
{
	// Token: 0x0601C6CF RID: 116431 RVA: 0x008BA388 File Offset: 0x008B8588
	[NullableContext(1)]
	protected __TsBaseCharacter_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBaseCharacter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C6D0 RID: 116432 RVA: 0x008BA3BB File Offset: 0x008B85BB
	protected __TsBaseCharacter_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
