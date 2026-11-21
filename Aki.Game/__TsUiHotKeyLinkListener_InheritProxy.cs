using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E5D RID: 11869
public class __TsUiHotKeyLinkListener_InheritProxy : TsUiHotKeyLinkListener
{
	// Token: 0x0601C7F4 RID: 116724 RVA: 0x008BC0B8 File Offset: 0x008BA2B8
	[NullableContext(1)]
	public __TsUiHotKeyLinkListener_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiHotKeyLinkListener.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C7F5 RID: 116725 RVA: 0x008BC0EB File Offset: 0x008BA2EB
	protected __TsUiHotKeyLinkListener_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
