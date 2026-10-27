using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038D0 RID: 14544
public class __TsUiBlur_InheritProxy : TsUiBlur
{
	// Token: 0x0601EAF0 RID: 125680 RVA: 0x008974E4 File Offset: 0x008956E4
	[NullableContext(1)]
	public __TsUiBlur_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiBlur.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EAF1 RID: 125681 RVA: 0x00897517 File Offset: 0x00895717
	protected __TsUiBlur_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EAF2 RID: 125682 RVA: 0x00897520 File Offset: 0x00895720
	protected unsafe override void __CPPCALL_SetEnableUiBlur_Implementation(TsUiBlur.__SetEnableUiBlur_FunctionParams* __Params)
	{
		base.SetEnableUiBlur_Implementation(__Params->value);
	}
}
