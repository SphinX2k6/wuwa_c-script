using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038ED RID: 14573
public class __LogicDataAddBuff_SubClassMissingExportProxy : __LogicDataAddBuff_InheritProxy
{
	// Token: 0x0601EB52 RID: 125778 RVA: 0x00897E84 File Offset: 0x00896084
	[NullableContext(1)]
	protected __LogicDataAddBuff_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataAddBuff.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB53 RID: 125779 RVA: 0x00897EB7 File Offset: 0x008960B7
	protected __LogicDataAddBuff_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
