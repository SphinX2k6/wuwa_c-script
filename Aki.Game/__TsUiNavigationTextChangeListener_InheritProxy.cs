using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E59 RID: 11865
public class __TsUiNavigationTextChangeListener_InheritProxy : TsUiNavigationTextChangeListener
{
	// Token: 0x0601C7E4 RID: 116708 RVA: 0x008BBF6C File Offset: 0x008BA16C
	[NullableContext(1)]
	public __TsUiNavigationTextChangeListener_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiNavigationTextChangeListener.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C7E5 RID: 116709 RVA: 0x008BBF9F File Offset: 0x008BA19F
	protected __TsUiNavigationTextChangeListener_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C7E6 RID: 116710 RVA: 0x008BBFA8 File Offset: 0x008BA1A8
	protected override void __CPPCALL_AwakeBP_Implementation()
	{
		base.AwakeBP_Implementation();
	}

	// Token: 0x0601C7E7 RID: 116711 RVA: 0x008BBFB0 File Offset: 0x008BA1B0
	protected override void __CPPCALL_StartBP_Implementation()
	{
		base.StartBP_Implementation();
	}

	// Token: 0x0601C7E8 RID: 116712 RVA: 0x008BBFB8 File Offset: 0x008BA1B8
	protected unsafe override void __CPPCALL_OnNotifyTextChangeBP_Implementation(UUINavigationTextChangeListener.__OnNotifyTextChangeBP_FunctionParams* __Params)
	{
		string notifyText = FString.ToString((void*)(&__Params->NotifyText));
		base.OnNotifyTextChangeBP_Implementation(notifyText);
	}
}
