using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E49 RID: 11849
public class __TsUiBlur_InheritProxy : TsUiBlur
{
	// Token: 0x0601C7AA RID: 116650 RVA: 0x008BBA78 File Offset: 0x008B9C78
	[NullableContext(1)]
	public __TsUiBlur_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiBlur.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C7AB RID: 116651 RVA: 0x008BBAAB File Offset: 0x008B9CAB
	protected __TsUiBlur_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C7AC RID: 116652 RVA: 0x008BBAB4 File Offset: 0x008B9CB4
	protected unsafe override void __CPPCALL_SetEnableUiBlur_Implementation(TsUiBlur.__SetEnableUiBlur_FunctionParams* __Params)
	{
		base.SetEnableUiBlur_Implementation(__Params->value);
	}
}
