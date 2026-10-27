using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200364F RID: 13903
public class __TsTaskAnimalDropItem_SubClassMissingExportProxy : __TsTaskAnimalDropItem_InheritProxy
{
	// Token: 0x0601E24E RID: 123470 RVA: 0x008825B8 File Offset: 0x008807B8
	[NullableContext(1)]
	protected __TsTaskAnimalDropItem_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskAnimalDropItem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E24F RID: 123471 RVA: 0x008825EB File Offset: 0x008807EB
	protected __TsTaskAnimalDropItem_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
