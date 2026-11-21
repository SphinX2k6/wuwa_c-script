using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E4F RID: 11855
public class __TsUiSceneRoleActor_InheritProxy : TsUiSceneRoleActor
{
	// Token: 0x0601C7BC RID: 116668 RVA: 0x008BBC2C File Offset: 0x008B9E2C
	[NullableContext(1)]
	public __TsUiSceneRoleActor_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiSceneRoleActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C7BD RID: 116669 RVA: 0x008BBC5F File Offset: 0x008B9E5F
	protected __TsUiSceneRoleActor_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C7BE RID: 116670 RVA: 0x008BBC68 File Offset: 0x008B9E68
	protected unsafe override void __CPPCALL_ReceiveTick_Implementation(AActor.__ReceiveTick_FunctionParams* __Params)
	{
		base.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x0601C7BF RID: 116671 RVA: 0x008BBC76 File Offset: 0x008B9E76
	protected unsafe override void __CPPCALL_IsShowUiWepaonEffect_Implementation(TsUiSceneRoleActor.__IsShowUiWepaonEffect_FunctionParams* __Params)
	{
		__Params->__Result = base.IsShowUiWepaonEffect_Implementation();
	}
}
