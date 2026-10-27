using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003964 RID: 14692
public class __AudioVisualizationInstanceBase_InheritProxy : AudioVisualizationInstanceBase
{
	// Token: 0x0601ECC9 RID: 126153 RVA: 0x0089B958 File Offset: 0x00899B58
	[NullableContext(1)]
	public __AudioVisualizationInstanceBase_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AudioVisualizationInstanceBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601ECCA RID: 126154 RVA: 0x0089B98B File Offset: 0x00899B8B
	protected __AudioVisualizationInstanceBase_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601ECCB RID: 126155 RVA: 0x0089B994 File Offset: 0x00899B94
	protected override void __CPPCALL_StartInternal_Implementation()
	{
		base.StartInternal_Implementation();
	}

	// Token: 0x0601ECCC RID: 126156 RVA: 0x0089B99C File Offset: 0x00899B9C
	protected override void __CPPCALL_EndInternal_Implementation()
	{
		base.EndInternal_Implementation();
	}

	// Token: 0x0601ECCD RID: 126157 RVA: 0x0089B9A4 File Offset: 0x00899BA4
	protected unsafe override void __CPPCALL_CallBackInternal_Implementation(AudioVisualizationInstanceBase.__CallBackInternal_FunctionParams* __Params)
	{
		UAkCallbackInfo orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAkCallbackInfo>(__Params->callbackInfo);
		EAkCallbackType callbackType = (EAkCallbackType)__Params->callbackType;
		string state = FString.ToString((void*)(&__Params->state));
		base.CallBackInternal_Implementation(orCreateUObjectByNativePointer, callbackType, state);
	}

	// Token: 0x0601ECCE RID: 126158 RVA: 0x0089B9DA File Offset: 0x00899BDA
	protected override void __CPPCALL_MidiBpm_Implementation()
	{
		base.MidiBpm_Implementation();
	}

	// Token: 0x0601ECCF RID: 126159 RVA: 0x0089B9E2 File Offset: 0x00899BE2
	protected unsafe override void __CPPCALL_MidiC3On_Implementation(AudioVisualizationInstanceBase.__MidiC3On_FunctionParams* __Params)
	{
		base.MidiC3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601ECD0 RID: 126160 RVA: 0x0089B9F0 File Offset: 0x00899BF0
	protected unsafe override void __CPPCALL_MidiCs3On_Implementation(AudioVisualizationInstanceBase.__MidiCs3On_FunctionParams* __Params)
	{
		base.MidiCs3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601ECD1 RID: 126161 RVA: 0x0089B9FE File Offset: 0x00899BFE
	protected unsafe override void __CPPCALL_MidiD3On_Implementation(AudioVisualizationInstanceBase.__MidiD3On_FunctionParams* __Params)
	{
		base.MidiD3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601ECD2 RID: 126162 RVA: 0x0089BA0C File Offset: 0x00899C0C
	protected unsafe override void __CPPCALL_MidiDs3On_Implementation(AudioVisualizationInstanceBase.__MidiDs3On_FunctionParams* __Params)
	{
		base.MidiDs3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601ECD3 RID: 126163 RVA: 0x0089BA1A File Offset: 0x00899C1A
	protected unsafe override void __CPPCALL_MidiE3On_Implementation(AudioVisualizationInstanceBase.__MidiE3On_FunctionParams* __Params)
	{
		base.MidiE3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601ECD4 RID: 126164 RVA: 0x0089BA28 File Offset: 0x00899C28
	protected unsafe override void __CPPCALL_MidiF3On_Implementation(AudioVisualizationInstanceBase.__MidiF3On_FunctionParams* __Params)
	{
		base.MidiF3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601ECD5 RID: 126165 RVA: 0x0089BA36 File Offset: 0x00899C36
	protected unsafe override void __CPPCALL_MidiFs3On_Implementation(AudioVisualizationInstanceBase.__MidiFs3On_FunctionParams* __Params)
	{
		base.MidiFs3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601ECD6 RID: 126166 RVA: 0x0089BA44 File Offset: 0x00899C44
	protected unsafe override void __CPPCALL_MidiG3On_Implementation(AudioVisualizationInstanceBase.__MidiG3On_FunctionParams* __Params)
	{
		base.MidiG3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601ECD7 RID: 126167 RVA: 0x0089BA52 File Offset: 0x00899C52
	protected unsafe override void __CPPCALL_MidiGs3On_Implementation(AudioVisualizationInstanceBase.__MidiGs3On_FunctionParams* __Params)
	{
		base.MidiGs3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601ECD8 RID: 126168 RVA: 0x0089BA60 File Offset: 0x00899C60
	protected unsafe override void __CPPCALL_MidiA3On_Implementation(AudioVisualizationInstanceBase.__MidiA3On_FunctionParams* __Params)
	{
		base.MidiA3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601ECD9 RID: 126169 RVA: 0x0089BA6E File Offset: 0x00899C6E
	protected unsafe override void __CPPCALL_MidiAs3On_Implementation(AudioVisualizationInstanceBase.__MidiAs3On_FunctionParams* __Params)
	{
		base.MidiAs3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601ECDA RID: 126170 RVA: 0x0089BA7C File Offset: 0x00899C7C
	protected unsafe override void __CPPCALL_MidiB3On_Implementation(AudioVisualizationInstanceBase.__MidiB3On_FunctionParams* __Params)
	{
		base.MidiB3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601ECDB RID: 126171 RVA: 0x0089BA8A File Offset: 0x00899C8A
	protected unsafe override void __CPPCALL_MidiC3Off_Implementation(AudioVisualizationInstanceBase.__MidiC3Off_FunctionParams* __Params)
	{
		base.MidiC3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601ECDC RID: 126172 RVA: 0x0089BA98 File Offset: 0x00899C98
	protected unsafe override void __CPPCALL_MidiCs3Off_Implementation(AudioVisualizationInstanceBase.__MidiCs3Off_FunctionParams* __Params)
	{
		base.MidiCs3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601ECDD RID: 126173 RVA: 0x0089BAA6 File Offset: 0x00899CA6
	protected unsafe override void __CPPCALL_MidiD3Off_Implementation(AudioVisualizationInstanceBase.__MidiD3Off_FunctionParams* __Params)
	{
		base.MidiD3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601ECDE RID: 126174 RVA: 0x0089BAB4 File Offset: 0x00899CB4
	protected unsafe override void __CPPCALL_MidiDs3Off_Implementation(AudioVisualizationInstanceBase.__MidiDs3Off_FunctionParams* __Params)
	{
		base.MidiDs3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601ECDF RID: 126175 RVA: 0x0089BAC2 File Offset: 0x00899CC2
	protected unsafe override void __CPPCALL_MidiE3Off_Implementation(AudioVisualizationInstanceBase.__MidiE3Off_FunctionParams* __Params)
	{
		base.MidiE3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601ECE0 RID: 126176 RVA: 0x0089BAD0 File Offset: 0x00899CD0
	protected unsafe override void __CPPCALL_MidiF3Off_Implementation(AudioVisualizationInstanceBase.__MidiF3Off_FunctionParams* __Params)
	{
		base.MidiF3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601ECE1 RID: 126177 RVA: 0x0089BADE File Offset: 0x00899CDE
	protected unsafe override void __CPPCALL_MidiFs3Off_Implementation(AudioVisualizationInstanceBase.__MidiFs3Off_FunctionParams* __Params)
	{
		base.MidiFs3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601ECE2 RID: 126178 RVA: 0x0089BAEC File Offset: 0x00899CEC
	protected unsafe override void __CPPCALL_MidiG3Off_Implementation(AudioVisualizationInstanceBase.__MidiG3Off_FunctionParams* __Params)
	{
		base.MidiG3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601ECE3 RID: 126179 RVA: 0x0089BAFA File Offset: 0x00899CFA
	protected unsafe override void __CPPCALL_MidiGs3Off_Implementation(AudioVisualizationInstanceBase.__MidiGs3Off_FunctionParams* __Params)
	{
		base.MidiGs3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601ECE4 RID: 126180 RVA: 0x0089BB08 File Offset: 0x00899D08
	protected unsafe override void __CPPCALL_MidiA3Off_Implementation(AudioVisualizationInstanceBase.__MidiA3Off_FunctionParams* __Params)
	{
		base.MidiA3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601ECE5 RID: 126181 RVA: 0x0089BB16 File Offset: 0x00899D16
	protected unsafe override void __CPPCALL_MidiAs3Off_Implementation(AudioVisualizationInstanceBase.__MidiAs3Off_FunctionParams* __Params)
	{
		base.MidiAs3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601ECE6 RID: 126182 RVA: 0x0089BB24 File Offset: 0x00899D24
	protected unsafe override void __CPPCALL_MidiB3Off_Implementation(AudioVisualizationInstanceBase.__MidiB3Off_FunctionParams* __Params)
	{
		base.MidiB3Off_Implementation(__Params->velocity);
	}
}
