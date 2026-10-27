using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038E6 RID: 14566
public class __TsUiNavigationScrollControlSize_InheritProxy : TsUiNavigationScrollControlSize
{
	// Token: 0x0601EB40 RID: 125760 RVA: 0x00897C8C File Offset: 0x00895E8C
	[NullableContext(1)]
	public __TsUiNavigationScrollControlSize_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiNavigationScrollControlSize.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB41 RID: 125761 RVA: 0x00897CBF File Offset: 0x00895EBF
	protected __TsUiNavigationScrollControlSize_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EB42 RID: 125762 RVA: 0x00897CC8 File Offset: 0x00895EC8
	protected override void __CPPCALL_AwakeBP_Implementation()
	{
		base.AwakeBP_Implementation();
	}

	// Token: 0x0601EB43 RID: 125763 RVA: 0x00897CD0 File Offset: 0x00895ED0
	protected unsafe override void __CPPCALL_LateUpdateBP_Implementation(ULGUIBehaviour.__LateUpdateBP_FunctionParams* __Params)
	{
		base.LateUpdateBP_Implementation(__Params->DeltaTime);
	}

	// Token: 0x0601EB44 RID: 125764 RVA: 0x00897CDE File Offset: 0x00895EDE
	protected override void __CPPCALL_OnDisableBP_Implementation()
	{
		base.OnDisableBP_Implementation();
	}
}
