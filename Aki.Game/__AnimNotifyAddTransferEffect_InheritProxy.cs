using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003972 RID: 14706
public class __AnimNotifyAddTransferEffect_InheritProxy : AnimNotifyAddTransferEffect
{
	// Token: 0x0601ED38 RID: 126264 RVA: 0x0089D088 File Offset: 0x0089B288
	[NullableContext(1)]
	public __AnimNotifyAddTransferEffect_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyAddTransferEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601ED39 RID: 126265 RVA: 0x0089D0BB File Offset: 0x0089B2BB
	protected __AnimNotifyAddTransferEffect_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601ED3A RID: 126266 RVA: 0x0089D0C4 File Offset: 0x0089B2C4
	protected unsafe override void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), base.GetNotifyName_Implementation());
	}
}
