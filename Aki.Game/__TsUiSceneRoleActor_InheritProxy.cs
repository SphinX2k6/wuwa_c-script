using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038D6 RID: 14550
public class __TsUiSceneRoleActor_InheritProxy : TsUiSceneRoleActor
{
	// Token: 0x0601EB03 RID: 125699 RVA: 0x00897710 File Offset: 0x00895910
	[NullableContext(1)]
	public __TsUiSceneRoleActor_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiSceneRoleActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB04 RID: 125700 RVA: 0x00897743 File Offset: 0x00895943
	protected __TsUiSceneRoleActor_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EB05 RID: 125701 RVA: 0x0089774C File Offset: 0x0089594C
	protected unsafe override void __CPPCALL_ReceiveTick_Implementation(AActor.__ReceiveTick_FunctionParams* __Params)
	{
		base.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x0601EB06 RID: 125702 RVA: 0x0089775A File Offset: 0x0089595A
	protected unsafe override void __CPPCALL_IsShowUiWepaonEffect_Implementation(TsUiSceneRoleActor.__IsShowUiWepaonEffect_FunctionParams* __Params)
	{
		__Params->__Result = base.IsShowUiWepaonEffect_Implementation();
	}
}
