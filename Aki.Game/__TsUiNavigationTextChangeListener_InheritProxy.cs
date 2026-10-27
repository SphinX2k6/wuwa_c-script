using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038E0 RID: 14560
public class __TsUiNavigationTextChangeListener_InheritProxy : TsUiNavigationTextChangeListener
{
	// Token: 0x0601EB2C RID: 125740 RVA: 0x00897AC8 File Offset: 0x00895CC8
	[NullableContext(1)]
	public __TsUiNavigationTextChangeListener_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiNavigationTextChangeListener.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB2D RID: 125741 RVA: 0x00897AFB File Offset: 0x00895CFB
	protected __TsUiNavigationTextChangeListener_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EB2E RID: 125742 RVA: 0x00897B04 File Offset: 0x00895D04
	protected override void __CPPCALL_AwakeBP_Implementation()
	{
		base.AwakeBP_Implementation();
	}

	// Token: 0x0601EB2F RID: 125743 RVA: 0x00897B0C File Offset: 0x00895D0C
	protected override void __CPPCALL_StartBP_Implementation()
	{
		base.StartBP_Implementation();
	}

	// Token: 0x0601EB30 RID: 125744 RVA: 0x00897B14 File Offset: 0x00895D14
	protected unsafe override void __CPPCALL_OnNotifyTextChangeBP_Implementation(UUINavigationTextChangeListener.__OnNotifyTextChangeBP_FunctionParams* __Params)
	{
		string notifyText = FString.ToString((void*)(&__Params->NotifyText));
		base.OnNotifyTextChangeBP_Implementation(notifyText);
	}
}
