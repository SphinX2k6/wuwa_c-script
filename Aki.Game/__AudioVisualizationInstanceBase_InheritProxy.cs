using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EDF RID: 11999
public class __AudioVisualizationInstanceBase_InheritProxy : AudioVisualizationInstanceBase
{
	// Token: 0x0601C952 RID: 117074 RVA: 0x008BE5CC File Offset: 0x008BC7CC
	[NullableContext(1)]
	public __AudioVisualizationInstanceBase_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AudioVisualizationInstanceBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C953 RID: 117075 RVA: 0x008BE5FF File Offset: 0x008BC7FF
	protected __AudioVisualizationInstanceBase_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C954 RID: 117076 RVA: 0x008BE608 File Offset: 0x008BC808
	protected override void __CPPCALL_StartInternal_Implementation()
	{
		base.StartInternal_Implementation();
	}

	// Token: 0x0601C955 RID: 117077 RVA: 0x008BE610 File Offset: 0x008BC810
	protected override void __CPPCALL_EndInternal_Implementation()
	{
		base.EndInternal_Implementation();
	}

	// Token: 0x0601C956 RID: 117078 RVA: 0x008BE618 File Offset: 0x008BC818
	protected unsafe override void __CPPCALL_CallBackInternal_Implementation(AudioVisualizationInstanceBase.__CallBackInternal_FunctionParams* __Params)
	{
		UAkCallbackInfo orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAkCallbackInfo>(__Params->callbackInfo);
		EAkCallbackType callbackType = (EAkCallbackType)__Params->callbackType;
		string state = FString.ToString((void*)(&__Params->state));
		base.CallBackInternal_Implementation(orCreateUObjectByNativePointer, callbackType, state);
	}

	// Token: 0x0601C957 RID: 117079 RVA: 0x008BE64E File Offset: 0x008BC84E
	protected override void __CPPCALL_MidiBpm_Implementation()
	{
		base.MidiBpm_Implementation();
	}

	// Token: 0x0601C958 RID: 117080 RVA: 0x008BE656 File Offset: 0x008BC856
	protected unsafe override void __CPPCALL_MidiC3On_Implementation(AudioVisualizationInstanceBase.__MidiC3On_FunctionParams* __Params)
	{
		base.MidiC3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601C959 RID: 117081 RVA: 0x008BE664 File Offset: 0x008BC864
	protected unsafe override void __CPPCALL_MidiCs3On_Implementation(AudioVisualizationInstanceBase.__MidiCs3On_FunctionParams* __Params)
	{
		base.MidiCs3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601C95A RID: 117082 RVA: 0x008BE672 File Offset: 0x008BC872
	protected unsafe override void __CPPCALL_MidiD3On_Implementation(AudioVisualizationInstanceBase.__MidiD3On_FunctionParams* __Params)
	{
		base.MidiD3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601C95B RID: 117083 RVA: 0x008BE680 File Offset: 0x008BC880
	protected unsafe override void __CPPCALL_MidiDs3On_Implementation(AudioVisualizationInstanceBase.__MidiDs3On_FunctionParams* __Params)
	{
		base.MidiDs3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601C95C RID: 117084 RVA: 0x008BE68E File Offset: 0x008BC88E
	protected unsafe override void __CPPCALL_MidiE3On_Implementation(AudioVisualizationInstanceBase.__MidiE3On_FunctionParams* __Params)
	{
		base.MidiE3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601C95D RID: 117085 RVA: 0x008BE69C File Offset: 0x008BC89C
	protected unsafe override void __CPPCALL_MidiF3On_Implementation(AudioVisualizationInstanceBase.__MidiF3On_FunctionParams* __Params)
	{
		base.MidiF3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601C95E RID: 117086 RVA: 0x008BE6AA File Offset: 0x008BC8AA
	protected unsafe override void __CPPCALL_MidiFs3On_Implementation(AudioVisualizationInstanceBase.__MidiFs3On_FunctionParams* __Params)
	{
		base.MidiFs3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601C95F RID: 117087 RVA: 0x008BE6B8 File Offset: 0x008BC8B8
	protected unsafe override void __CPPCALL_MidiG3On_Implementation(AudioVisualizationInstanceBase.__MidiG3On_FunctionParams* __Params)
	{
		base.MidiG3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601C960 RID: 117088 RVA: 0x008BE6C6 File Offset: 0x008BC8C6
	protected unsafe override void __CPPCALL_MidiGs3On_Implementation(AudioVisualizationInstanceBase.__MidiGs3On_FunctionParams* __Params)
	{
		base.MidiGs3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601C961 RID: 117089 RVA: 0x008BE6D4 File Offset: 0x008BC8D4
	protected unsafe override void __CPPCALL_MidiA3On_Implementation(AudioVisualizationInstanceBase.__MidiA3On_FunctionParams* __Params)
	{
		base.MidiA3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601C962 RID: 117090 RVA: 0x008BE6E2 File Offset: 0x008BC8E2
	protected unsafe override void __CPPCALL_MidiAs3On_Implementation(AudioVisualizationInstanceBase.__MidiAs3On_FunctionParams* __Params)
	{
		base.MidiAs3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601C963 RID: 117091 RVA: 0x008BE6F0 File Offset: 0x008BC8F0
	protected unsafe override void __CPPCALL_MidiB3On_Implementation(AudioVisualizationInstanceBase.__MidiB3On_FunctionParams* __Params)
	{
		base.MidiB3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601C964 RID: 117092 RVA: 0x008BE6FE File Offset: 0x008BC8FE
	protected unsafe override void __CPPCALL_MidiC3Off_Implementation(AudioVisualizationInstanceBase.__MidiC3Off_FunctionParams* __Params)
	{
		base.MidiC3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601C965 RID: 117093 RVA: 0x008BE70C File Offset: 0x008BC90C
	protected unsafe override void __CPPCALL_MidiCs3Off_Implementation(AudioVisualizationInstanceBase.__MidiCs3Off_FunctionParams* __Params)
	{
		base.MidiCs3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601C966 RID: 117094 RVA: 0x008BE71A File Offset: 0x008BC91A
	protected unsafe override void __CPPCALL_MidiD3Off_Implementation(AudioVisualizationInstanceBase.__MidiD3Off_FunctionParams* __Params)
	{
		base.MidiD3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601C967 RID: 117095 RVA: 0x008BE728 File Offset: 0x008BC928
	protected unsafe override void __CPPCALL_MidiDs3Off_Implementation(AudioVisualizationInstanceBase.__MidiDs3Off_FunctionParams* __Params)
	{
		base.MidiDs3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601C968 RID: 117096 RVA: 0x008BE736 File Offset: 0x008BC936
	protected unsafe override void __CPPCALL_MidiE3Off_Implementation(AudioVisualizationInstanceBase.__MidiE3Off_FunctionParams* __Params)
	{
		base.MidiE3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601C969 RID: 117097 RVA: 0x008BE744 File Offset: 0x008BC944
	protected unsafe override void __CPPCALL_MidiF3Off_Implementation(AudioVisualizationInstanceBase.__MidiF3Off_FunctionParams* __Params)
	{
		base.MidiF3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601C96A RID: 117098 RVA: 0x008BE752 File Offset: 0x008BC952
	protected unsafe override void __CPPCALL_MidiFs3Off_Implementation(AudioVisualizationInstanceBase.__MidiFs3Off_FunctionParams* __Params)
	{
		base.MidiFs3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601C96B RID: 117099 RVA: 0x008BE760 File Offset: 0x008BC960
	protected unsafe override void __CPPCALL_MidiG3Off_Implementation(AudioVisualizationInstanceBase.__MidiG3Off_FunctionParams* __Params)
	{
		base.MidiG3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601C96C RID: 117100 RVA: 0x008BE76E File Offset: 0x008BC96E
	protected unsafe override void __CPPCALL_MidiGs3Off_Implementation(AudioVisualizationInstanceBase.__MidiGs3Off_FunctionParams* __Params)
	{
		base.MidiGs3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601C96D RID: 117101 RVA: 0x008BE77C File Offset: 0x008BC97C
	protected unsafe override void __CPPCALL_MidiA3Off_Implementation(AudioVisualizationInstanceBase.__MidiA3Off_FunctionParams* __Params)
	{
		base.MidiA3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601C96E RID: 117102 RVA: 0x008BE78A File Offset: 0x008BC98A
	protected unsafe override void __CPPCALL_MidiAs3Off_Implementation(AudioVisualizationInstanceBase.__MidiAs3Off_FunctionParams* __Params)
	{
		base.MidiAs3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601C96F RID: 117103 RVA: 0x008BE798 File Offset: 0x008BC998
	protected unsafe override void __CPPCALL_MidiB3Off_Implementation(AudioVisualizationInstanceBase.__MidiB3Off_FunctionParams* __Params)
	{
		base.MidiB3Off_Implementation(__Params->velocity);
	}
}
