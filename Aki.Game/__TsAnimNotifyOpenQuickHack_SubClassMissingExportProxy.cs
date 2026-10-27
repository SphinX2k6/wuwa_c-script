using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200383D RID: 14397
public class __TsAnimNotifyOpenQuickHack_SubClassMissingExportProxy : __TsAnimNotifyOpenQuickHack_InheritProxy
{
	// Token: 0x0601E8E8 RID: 125160 RVA: 0x00892214 File Offset: 0x00890414
	[NullableContext(1)]
	protected __TsAnimNotifyOpenQuickHack_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyOpenQuickHack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E8E9 RID: 125161 RVA: 0x00892247 File Offset: 0x00890447
	protected __TsAnimNotifyOpenQuickHack_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
