using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E28 RID: 11816
public class __LevelGeneralBpBridge_SubClassMissingExportProxy : __LevelGeneralBpBridge_InheritProxy
{
	// Token: 0x0601C744 RID: 116548 RVA: 0x008BB02C File Offset: 0x008B922C
	[NullableContext(1)]
	protected __LevelGeneralBpBridge_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LevelGeneralBpBridge.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C745 RID: 116549 RVA: 0x008BB05F File Offset: 0x008B925F
	protected __LevelGeneralBpBridge_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
