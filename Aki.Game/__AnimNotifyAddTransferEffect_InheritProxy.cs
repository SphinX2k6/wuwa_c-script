using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EED RID: 12013
public class __AnimNotifyAddTransferEffect_InheritProxy : AnimNotifyAddTransferEffect
{
	// Token: 0x0601C99E RID: 117150 RVA: 0x008BECC0 File Offset: 0x008BCEC0
	[NullableContext(1)]
	public __AnimNotifyAddTransferEffect_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyAddTransferEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C99F RID: 117151 RVA: 0x008BECF3 File Offset: 0x008BCEF3
	protected __AnimNotifyAddTransferEffect_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C9A0 RID: 117152 RVA: 0x008BECFC File Offset: 0x008BCEFC
	protected unsafe override void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), base.GetNotifyName_Implementation());
	}
}
