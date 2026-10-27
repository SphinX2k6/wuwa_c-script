using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039B2 RID: 14770
public class __EffectViewComponent_InheritProxy : EffectViewComponent
{
	// Token: 0x0601EE49 RID: 126537 RVA: 0x008A07F0 File Offset: 0x0089E9F0
	[NullableContext(1)]
	public __EffectViewComponent_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectViewComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE4A RID: 126538 RVA: 0x008A0823 File Offset: 0x0089EA23
	protected __EffectViewComponent_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EE4B RID: 126539 RVA: 0x008A082C File Offset: 0x0089EA2C
	protected unsafe override void __CPPCALL_EditorTick_Implementation(EffectViewComponent.__EditorTick_FunctionParams* __Params)
	{
		base.EditorTick_Implementation(__Params->deltaSecond);
	}

	// Token: 0x0601EE4C RID: 126540 RVA: 0x008A083A File Offset: 0x0089EA3A
	protected unsafe override void __CPPCALL_SetAutoPlay_Implementation(EffectViewComponent.__SetAutoPlay_FunctionParams* __Params)
	{
		base.SetAutoPlay_Implementation(__Params->autoPlay);
	}

	// Token: 0x0601EE4D RID: 126541 RVA: 0x008A0848 File Offset: 0x0089EA48
	protected override void __CPPCALL_Play_Implementation()
	{
		base.Play_Implementation();
	}

	// Token: 0x0601EE4E RID: 126542 RVA: 0x008A0850 File Offset: 0x0089EA50
	protected unsafe override void __CPPCALL_Stop_Implementation(EffectViewComponent.__Stop_FunctionParams* __Params)
	{
		base.Stop_Implementation(__Params->immediately);
	}
}
