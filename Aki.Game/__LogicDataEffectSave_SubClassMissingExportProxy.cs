using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E76 RID: 11894
public class __LogicDataEffectSave_SubClassMissingExportProxy : __LogicDataEffectSave_InheritProxy
{
	// Token: 0x0601C82A RID: 116778 RVA: 0x008BC6E8 File Offset: 0x008BA8E8
	[NullableContext(1)]
	protected __LogicDataEffectSave_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataEffectSave.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C82B RID: 116779 RVA: 0x008BC71B File Offset: 0x008BA91B
	protected __LogicDataEffectSave_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
