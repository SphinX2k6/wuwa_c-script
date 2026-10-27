using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038FD RID: 14589
public class __LogicDataEffectSave_SubClassMissingExportProxy : __LogicDataEffectSave_InheritProxy
{
	// Token: 0x0601EB72 RID: 125810 RVA: 0x00898244 File Offset: 0x00896444
	[NullableContext(1)]
	protected __LogicDataEffectSave_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataEffectSave.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB73 RID: 125811 RVA: 0x00898277 File Offset: 0x00896477
	protected __LogicDataEffectSave_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
