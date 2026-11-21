using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F2D RID: 12077
public class __EffectViewComponent_InheritProxy : EffectViewComponent
{
	// Token: 0x0601CA76 RID: 117366 RVA: 0x008C06AC File Offset: 0x008BE8AC
	[NullableContext(1)]
	public __EffectViewComponent_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectViewComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA77 RID: 117367 RVA: 0x008C06DF File Offset: 0x008BE8DF
	protected __EffectViewComponent_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601CA78 RID: 117368 RVA: 0x008C06E8 File Offset: 0x008BE8E8
	protected unsafe override void __CPPCALL_EditorTick_Implementation(EffectViewComponent.__EditorTick_FunctionParams* __Params)
	{
		base.EditorTick_Implementation(__Params->deltaSecond);
	}

	// Token: 0x0601CA79 RID: 117369 RVA: 0x008C06F6 File Offset: 0x008BE8F6
	protected unsafe override void __CPPCALL_SetAutoPlay_Implementation(EffectViewComponent.__SetAutoPlay_FunctionParams* __Params)
	{
		base.SetAutoPlay_Implementation(__Params->autoPlay);
	}

	// Token: 0x0601CA7A RID: 117370 RVA: 0x008C0704 File Offset: 0x008BE904
	protected override void __CPPCALL_Play_Implementation()
	{
		base.Play_Implementation();
	}

	// Token: 0x0601CA7B RID: 117371 RVA: 0x008C070C File Offset: 0x008BE90C
	protected unsafe override void __CPPCALL_Stop_Implementation(EffectViewComponent.__Stop_FunctionParams* __Params)
	{
		base.Stop_Implementation(__Params->immediately);
	}
}
