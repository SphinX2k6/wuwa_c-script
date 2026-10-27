using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038E4 RID: 14564
public class __TsUiHotKeyLinkListener_InheritProxy : TsUiHotKeyLinkListener
{
	// Token: 0x0601EB3C RID: 125756 RVA: 0x00897C14 File Offset: 0x00895E14
	[NullableContext(1)]
	public __TsUiHotKeyLinkListener_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiHotKeyLinkListener.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB3D RID: 125757 RVA: 0x00897C47 File Offset: 0x00895E47
	protected __TsUiHotKeyLinkListener_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
