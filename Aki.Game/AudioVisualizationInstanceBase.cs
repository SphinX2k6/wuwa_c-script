using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02003456 RID: 13398
[UClass("/Game/Aki/TypeScript/Game/Render/AudioVisualization/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/AudioVisualization/AudioVisualizationInstanceBase.AudioVisualizationInstanceBase_C")]
public class AudioVisualizationInstanceBase : AActor, IUnrealUObject, IUnrealObject
{
	// Token: 0x170027A6 RID: 10150
	// (get) Token: 0x0601CE74 RID: 118388 RVA: 0x0080E432 File Offset: 0x0080C632
	// (set) Token: 0x0601CE75 RID: 118389 RVA: 0x0080E446 File Offset: 0x0080C646
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string Identifier
	{
		[NullableContext(1)]
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)AudioVisualizationInstanceBase.__PropertyOffset_Identifier)));
		}
		[NullableContext(1)]
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)AudioVisualizationInstanceBase.__PropertyOffset_Identifier)), value);
		}
	}

	// Token: 0x0601CE76 RID: 118390 RVA: 0x0080E45B File Offset: 0x0080C65B
	public override void ReceiveEndPlay(EEndPlayReason endPlayReason)
	{
		Action<AudioVisualizationInstanceBase> actorEndPlayCallback = this.ActorEndPlayCallback;
		if (actorEndPlayCallback == null)
		{
			return;
		}
		actorEndPlayCallback(this);
	}

	// Token: 0x0601CE77 RID: 118391 RVA: 0x0080E470 File Offset: 0x0080C670
	public unsafe void Start()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Audio;
		ELogAuthor author = ELogAuthor.LSY;
		string message = "音频可视化实例开始";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("名称", this);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("标识符", this.Identifier);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		this.StartInternal();
	}

	// Token: 0x0601CE78 RID: 118392 RVA: 0x0080E4DC File Offset: 0x0080C6DC
	public unsafe void End()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Audio;
		ELogAuthor author = ELogAuthor.LSY;
		string message = "音频可视化实例结束";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("名称", this);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("标识符", this.Identifier);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		this.EndInternal();
	}

	// Token: 0x0601CE79 RID: 118393 RVA: 0x0080E548 File Offset: 0x0080C748
	[NullableContext(1)]
	public void CallBack([Nullable(2)] UAkCallbackInfo callbackInfo, EAkCallbackType callbackType, string state)
	{
		if (callbackInfo is UAkMusicSyncCallbackInfo)
		{
			this.MidiBpm();
		}
		UAkMIDIEventCallbackInfo uakMIDIEventCallbackInfo = callbackInfo as UAkMIDIEventCallbackInfo;
		if (uakMIDIEventCallbackInfo != null)
		{
			EAkMidiEventType type = uakMIDIEventCallbackInfo.GetType();
			if (type != EAkMidiEventType.AkMidiEventTypeNoteOff)
			{
				if (type == EAkMidiEventType.AkMidiEventTypeNoteOn)
				{
					this.TriggerMidiNoteOn(uakMIDIEventCallbackInfo);
				}
			}
			else
			{
				this.TriggerMidiNoteOff(uakMIDIEventCallbackInfo);
			}
		}
		this.CallBackInternal(callbackInfo, callbackType, state);
	}

	// Token: 0x0601CE7A RID: 118394 RVA: 0x0080E5A0 File Offset: 0x0080C7A0
	[NullableContext(1)]
	private void TriggerMidiNoteOn(UAkMIDIEventCallbackInfo callbackInfo)
	{
		FAkMidiNoteOnOff fakMidiNoteOnOff = null;
		if (!callbackInfo.GetNoteOn(ref fakMidiNoteOnOff) || fakMidiNoteOnOff == null)
		{
			return;
		}
		byte velocity = fakMidiNoteOnOff.Velocity;
		switch (fakMidiNoteOnOff.Note)
		{
		case 60:
			this.MidiC3On(velocity);
			return;
		case 61:
			this.MidiCs3On(velocity);
			return;
		case 62:
			this.MidiD3On(velocity);
			return;
		case 63:
			this.MidiDs3On(velocity);
			return;
		case 64:
			this.MidiE3On(velocity);
			return;
		case 65:
			this.MidiF3On(velocity);
			return;
		case 66:
			this.MidiFs3On(velocity);
			return;
		case 67:
			this.MidiG3On(velocity);
			return;
		case 68:
			this.MidiGs3On(velocity);
			return;
		case 69:
			this.MidiA3On(velocity);
			return;
		case 70:
			this.MidiAs3On(velocity);
			return;
		case 71:
			this.MidiB3On(velocity);
			return;
		default:
			return;
		}
	}

	// Token: 0x0601CE7B RID: 118395 RVA: 0x0080E66C File Offset: 0x0080C86C
	[NullableContext(1)]
	private void TriggerMidiNoteOff(UAkMIDIEventCallbackInfo callbackInfo)
	{
		FAkMidiNoteOnOff fakMidiNoteOnOff = null;
		if (!callbackInfo.GetNoteOff(ref fakMidiNoteOnOff) || fakMidiNoteOnOff == null)
		{
			return;
		}
		byte velocity = fakMidiNoteOnOff.Velocity;
		switch (fakMidiNoteOnOff.Note)
		{
		case 60:
			this.MidiC3Off(velocity);
			return;
		case 61:
			this.MidiCs3Off(velocity);
			return;
		case 62:
			this.MidiD3Off(velocity);
			return;
		case 63:
			this.MidiDs3Off(velocity);
			return;
		case 64:
			this.MidiE3Off(velocity);
			return;
		case 65:
			this.MidiF3Off(velocity);
			return;
		case 66:
			this.MidiFs3Off(velocity);
			return;
		case 67:
			this.MidiG3Off(velocity);
			return;
		case 68:
			this.MidiGs3Off(velocity);
			return;
		case 69:
			this.MidiA3Off(velocity);
			return;
		case 70:
			this.MidiAs3Off(velocity);
			return;
		case 71:
			this.MidiB3Off(velocity);
			return;
		default:
			return;
		}
	}

	// Token: 0x0601CE7C RID: 118396 RVA: 0x0080E738 File Offset: 0x0080C938
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void StartInternal()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("StartInternal"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601CE7D RID: 118397 RVA: 0x0080E7A8 File Offset: 0x0080C9A8
	protected void StartInternal_Implementation()
	{
	}

	// Token: 0x0601CE7E RID: 118398 RVA: 0x0080E7AC File Offset: 0x0080C9AC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void EndInternal()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("EndInternal"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601CE7F RID: 118399 RVA: 0x0080E81C File Offset: 0x0080CA1C
	protected void EndInternal_Implementation()
	{
	}

	// Token: 0x0601CE80 RID: 118400 RVA: 0x0080E820 File Offset: 0x0080CA20
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void CallBackInternal([Nullable(2)] UAkCallbackInfo callbackInfo, EAkCallbackType callbackType, string state)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("CallBackInternal"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__CallBackInternal_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__CallBackInternal_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__CallBackInternal_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->callbackInfo) = ((callbackInfo != null) ? callbackInfo.NativePtr : ((IntPtr)0));
			*(&ptr2->callbackType) = (byte)callbackType;
			FString.CopyFrom((void*)(&ptr2->state), state);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601CE81 RID: 118401 RVA: 0x0080E8BA File Offset: 0x0080CABA
	[NullableContext(1)]
	protected void CallBackInternal_Implementation([Nullable(2)] UAkCallbackInfo callbackInfo, EAkCallbackType callbackType, string state)
	{
	}

	// Token: 0x0601CE82 RID: 118402 RVA: 0x0080E8BC File Offset: 0x0080CABC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiBpm()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiBpm"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601CE83 RID: 118403 RVA: 0x0080E92C File Offset: 0x0080CB2C
	protected void MidiBpm_Implementation()
	{
	}

	// Token: 0x0601CE84 RID: 118404 RVA: 0x0080E930 File Offset: 0x0080CB30
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiC3On(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiC3On"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiC3On_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiC3On_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiC3On_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601CE85 RID: 118405 RVA: 0x0080E9A6 File Offset: 0x0080CBA6
	protected void MidiC3On_Implementation(byte velocity)
	{
	}

	// Token: 0x0601CE86 RID: 118406 RVA: 0x0080E9A8 File Offset: 0x0080CBA8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiCs3On(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiCs3On"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiCs3On_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiCs3On_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiCs3On_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601CE87 RID: 118407 RVA: 0x0080EA1E File Offset: 0x0080CC1E
	protected void MidiCs3On_Implementation(byte velocity)
	{
	}

	// Token: 0x0601CE88 RID: 118408 RVA: 0x0080EA20 File Offset: 0x0080CC20
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiD3On(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiD3On"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiD3On_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiD3On_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiD3On_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601CE89 RID: 118409 RVA: 0x0080EA96 File Offset: 0x0080CC96
	protected void MidiD3On_Implementation(byte velocity)
	{
	}

	// Token: 0x0601CE8A RID: 118410 RVA: 0x0080EA98 File Offset: 0x0080CC98
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiDs3On(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiDs3On"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiDs3On_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiDs3On_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiDs3On_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601CE8B RID: 118411 RVA: 0x0080EB0E File Offset: 0x0080CD0E
	protected void MidiDs3On_Implementation(byte velocity)
	{
	}

	// Token: 0x0601CE8C RID: 118412 RVA: 0x0080EB10 File Offset: 0x0080CD10
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiE3On(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiE3On"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiE3On_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiE3On_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiE3On_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601CE8D RID: 118413 RVA: 0x0080EB86 File Offset: 0x0080CD86
	protected void MidiE3On_Implementation(byte velocity)
	{
	}

	// Token: 0x0601CE8E RID: 118414 RVA: 0x0080EB88 File Offset: 0x0080CD88
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiF3On(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiF3On"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiF3On_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiF3On_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiF3On_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601CE8F RID: 118415 RVA: 0x0080EBFE File Offset: 0x0080CDFE
	protected void MidiF3On_Implementation(byte velocity)
	{
	}

	// Token: 0x0601CE90 RID: 118416 RVA: 0x0080EC00 File Offset: 0x0080CE00
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiFs3On(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiFs3On"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiFs3On_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiFs3On_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiFs3On_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601CE91 RID: 118417 RVA: 0x0080EC76 File Offset: 0x0080CE76
	protected void MidiFs3On_Implementation(byte velocity)
	{
	}

	// Token: 0x0601CE92 RID: 118418 RVA: 0x0080EC78 File Offset: 0x0080CE78
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiG3On(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiG3On"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiG3On_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiG3On_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiG3On_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601CE93 RID: 118419 RVA: 0x0080ECEE File Offset: 0x0080CEEE
	protected void MidiG3On_Implementation(byte velocity)
	{
	}

	// Token: 0x0601CE94 RID: 118420 RVA: 0x0080ECF0 File Offset: 0x0080CEF0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiGs3On(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiGs3On"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiGs3On_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiGs3On_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiGs3On_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601CE95 RID: 118421 RVA: 0x0080ED66 File Offset: 0x0080CF66
	protected void MidiGs3On_Implementation(byte velocity)
	{
	}

	// Token: 0x0601CE96 RID: 118422 RVA: 0x0080ED68 File Offset: 0x0080CF68
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiA3On(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiA3On"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiA3On_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiA3On_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiA3On_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601CE97 RID: 118423 RVA: 0x0080EDDE File Offset: 0x0080CFDE
	protected void MidiA3On_Implementation(byte velocity)
	{
	}

	// Token: 0x0601CE98 RID: 118424 RVA: 0x0080EDE0 File Offset: 0x0080CFE0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiAs3On(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiAs3On"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiAs3On_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiAs3On_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiAs3On_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601CE99 RID: 118425 RVA: 0x0080EE56 File Offset: 0x0080D056
	protected void MidiAs3On_Implementation(byte velocity)
	{
	}

	// Token: 0x0601CE9A RID: 118426 RVA: 0x0080EE58 File Offset: 0x0080D058
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiB3On(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiB3On"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiB3On_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiB3On_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiB3On_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601CE9B RID: 118427 RVA: 0x0080EECE File Offset: 0x0080D0CE
	protected void MidiB3On_Implementation(byte velocity)
	{
	}

	// Token: 0x0601CE9C RID: 118428 RVA: 0x0080EED0 File Offset: 0x0080D0D0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiC3Off(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiC3Off"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiC3Off_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiC3Off_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiC3Off_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601CE9D RID: 118429 RVA: 0x0080EF46 File Offset: 0x0080D146
	protected void MidiC3Off_Implementation(byte velocity)
	{
	}

	// Token: 0x0601CE9E RID: 118430 RVA: 0x0080EF48 File Offset: 0x0080D148
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiCs3Off(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiCs3Off"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiCs3Off_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiCs3Off_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiCs3Off_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601CE9F RID: 118431 RVA: 0x0080EFBE File Offset: 0x0080D1BE
	protected void MidiCs3Off_Implementation(byte velocity)
	{
	}

	// Token: 0x0601CEA0 RID: 118432 RVA: 0x0080EFC0 File Offset: 0x0080D1C0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiD3Off(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiD3Off"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiD3Off_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiD3Off_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiD3Off_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601CEA1 RID: 118433 RVA: 0x0080F036 File Offset: 0x0080D236
	protected void MidiD3Off_Implementation(byte velocity)
	{
	}

	// Token: 0x0601CEA2 RID: 118434 RVA: 0x0080F038 File Offset: 0x0080D238
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiDs3Off(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiDs3Off"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiDs3Off_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiDs3Off_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiDs3Off_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601CEA3 RID: 118435 RVA: 0x0080F0AE File Offset: 0x0080D2AE
	protected void MidiDs3Off_Implementation(byte velocity)
	{
	}

	// Token: 0x0601CEA4 RID: 118436 RVA: 0x0080F0B0 File Offset: 0x0080D2B0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiE3Off(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiE3Off"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiE3Off_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiE3Off_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiE3Off_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601CEA5 RID: 118437 RVA: 0x0080F126 File Offset: 0x0080D326
	protected void MidiE3Off_Implementation(byte velocity)
	{
	}

	// Token: 0x0601CEA6 RID: 118438 RVA: 0x0080F128 File Offset: 0x0080D328
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiF3Off(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiF3Off"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiF3Off_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiF3Off_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiF3Off_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601CEA7 RID: 118439 RVA: 0x0080F19E File Offset: 0x0080D39E
	protected void MidiF3Off_Implementation(byte velocity)
	{
	}

	// Token: 0x0601CEA8 RID: 118440 RVA: 0x0080F1A0 File Offset: 0x0080D3A0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiFs3Off(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiFs3Off"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiFs3Off_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiFs3Off_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiFs3Off_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601CEA9 RID: 118441 RVA: 0x0080F216 File Offset: 0x0080D416
	protected void MidiFs3Off_Implementation(byte velocity)
	{
	}

	// Token: 0x0601CEAA RID: 118442 RVA: 0x0080F218 File Offset: 0x0080D418
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiG3Off(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiG3Off"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiG3Off_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiG3Off_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiG3Off_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601CEAB RID: 118443 RVA: 0x0080F28E File Offset: 0x0080D48E
	protected void MidiG3Off_Implementation(byte velocity)
	{
	}

	// Token: 0x0601CEAC RID: 118444 RVA: 0x0080F290 File Offset: 0x0080D490
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiGs3Off(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiGs3Off"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiGs3Off_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiGs3Off_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiGs3Off_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601CEAD RID: 118445 RVA: 0x0080F306 File Offset: 0x0080D506
	protected void MidiGs3Off_Implementation(byte velocity)
	{
	}

	// Token: 0x0601CEAE RID: 118446 RVA: 0x0080F308 File Offset: 0x0080D508
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiA3Off(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiA3Off"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiA3Off_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiA3Off_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiA3Off_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601CEAF RID: 118447 RVA: 0x0080F37E File Offset: 0x0080D57E
	protected void MidiA3Off_Implementation(byte velocity)
	{
	}

	// Token: 0x0601CEB0 RID: 118448 RVA: 0x0080F380 File Offset: 0x0080D580
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiAs3Off(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiAs3Off"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiAs3Off_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiAs3Off_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiAs3Off_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601CEB1 RID: 118449 RVA: 0x0080F3F6 File Offset: 0x0080D5F6
	protected void MidiAs3Off_Implementation(byte velocity)
	{
	}

	// Token: 0x0601CEB2 RID: 118450 RVA: 0x0080F3F8 File Offset: 0x0080D5F8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiB3Off(byte velocity)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MidiB3Off"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AudioVisualizationInstanceBase.__MidiB3Off_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AudioVisualizationInstanceBase.__MidiB3Off_FunctionParams*)ptr + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiB3Off_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->velocity = velocity;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601CEB3 RID: 118451 RVA: 0x0080F46E File Offset: 0x0080D66E
	protected void MidiB3Off_Implementation(byte velocity)
	{
	}

	// Token: 0x0601CEB4 RID: 118452 RVA: 0x0080F470 File Offset: 0x0080D670
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (AudioVisualizationInstanceBase._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/AudioVisualization/AudioVisualizationInstanceBase.AudioVisualizationInstanceBase_C");
		}
		return AudioVisualizationInstanceBase._ClassPtr;
	}

	// Token: 0x0601CEB5 RID: 118453 RVA: 0x0080F494 File Offset: 0x0080D694
	public AudioVisualizationInstanceBase() : this(BuiltinUtils.AllocNativeUObject(AudioVisualizationInstanceBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601CEB6 RID: 118454 RVA: 0x0080F4BC File Offset: 0x0080D6BC
	[NullableContext(1)]
	public AudioVisualizationInstanceBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AudioVisualizationInstanceBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CEB7 RID: 118455 RVA: 0x0080F4EF File Offset: 0x0080D6EF
	protected AudioVisualizationInstanceBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x170027A7 RID: 10151
	// (get) Token: 0x0601CEB8 RID: 118456 RVA: 0x0080F4F8 File Offset: 0x0080D6F8
	[Nullable(1)]
	public unsafe FPointerToUberGraphFrame UberGraphFrame
	{
		[NullableContext(1)]
		get
		{
			return *(base.NativePtr + (IntPtr)AudioVisualizationInstanceBase.__PropertyOffset_UberGraphFrame);
		}
	}

	// Token: 0x170027A8 RID: 10152
	// (get) Token: 0x0601CEB9 RID: 118457 RVA: 0x0080F508 File Offset: 0x0080D708
	[Nullable(2)]
	public unsafe USceneComponent DefaultSceneRoot
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AudioVisualizationInstanceBase.__PropertyOffset_DefaultSceneRoot);
		}
	}

	// Token: 0x0601CEBA RID: 118458 RVA: 0x0080F51C File Offset: 0x0080D71C
	protected virtual void __CPPCALL_StartInternal_Implementation()
	{
		this.StartInternal_Implementation();
	}

	// Token: 0x0601CEBB RID: 118459 RVA: 0x0080F524 File Offset: 0x0080D724
	protected virtual void __CPPCALL_EndInternal_Implementation()
	{
		this.EndInternal_Implementation();
	}

	// Token: 0x0601CEBC RID: 118460 RVA: 0x0080F52C File Offset: 0x0080D72C
	protected unsafe virtual void __CPPCALL_CallBackInternal_Implementation(AudioVisualizationInstanceBase.__CallBackInternal_FunctionParams* __Params)
	{
		UAkCallbackInfo orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAkCallbackInfo>(__Params->callbackInfo);
		EAkCallbackType callbackType = (EAkCallbackType)__Params->callbackType;
		string state = FString.ToString((void*)(&__Params->state));
		this.CallBackInternal_Implementation(orCreateUObjectByNativePointer, callbackType, state);
	}

	// Token: 0x0601CEBD RID: 118461 RVA: 0x0080F562 File Offset: 0x0080D762
	protected virtual void __CPPCALL_MidiBpm_Implementation()
	{
		this.MidiBpm_Implementation();
	}

	// Token: 0x0601CEBE RID: 118462 RVA: 0x0080F56A File Offset: 0x0080D76A
	protected unsafe virtual void __CPPCALL_MidiC3On_Implementation(AudioVisualizationInstanceBase.__MidiC3On_FunctionParams* __Params)
	{
		this.MidiC3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601CEBF RID: 118463 RVA: 0x0080F578 File Offset: 0x0080D778
	protected unsafe virtual void __CPPCALL_MidiCs3On_Implementation(AudioVisualizationInstanceBase.__MidiCs3On_FunctionParams* __Params)
	{
		this.MidiCs3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601CEC0 RID: 118464 RVA: 0x0080F586 File Offset: 0x0080D786
	protected unsafe virtual void __CPPCALL_MidiD3On_Implementation(AudioVisualizationInstanceBase.__MidiD3On_FunctionParams* __Params)
	{
		this.MidiD3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601CEC1 RID: 118465 RVA: 0x0080F594 File Offset: 0x0080D794
	protected unsafe virtual void __CPPCALL_MidiDs3On_Implementation(AudioVisualizationInstanceBase.__MidiDs3On_FunctionParams* __Params)
	{
		this.MidiDs3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601CEC2 RID: 118466 RVA: 0x0080F5A2 File Offset: 0x0080D7A2
	protected unsafe virtual void __CPPCALL_MidiE3On_Implementation(AudioVisualizationInstanceBase.__MidiE3On_FunctionParams* __Params)
	{
		this.MidiE3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601CEC3 RID: 118467 RVA: 0x0080F5B0 File Offset: 0x0080D7B0
	protected unsafe virtual void __CPPCALL_MidiF3On_Implementation(AudioVisualizationInstanceBase.__MidiF3On_FunctionParams* __Params)
	{
		this.MidiF3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601CEC4 RID: 118468 RVA: 0x0080F5BE File Offset: 0x0080D7BE
	protected unsafe virtual void __CPPCALL_MidiFs3On_Implementation(AudioVisualizationInstanceBase.__MidiFs3On_FunctionParams* __Params)
	{
		this.MidiFs3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601CEC5 RID: 118469 RVA: 0x0080F5CC File Offset: 0x0080D7CC
	protected unsafe virtual void __CPPCALL_MidiG3On_Implementation(AudioVisualizationInstanceBase.__MidiG3On_FunctionParams* __Params)
	{
		this.MidiG3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601CEC6 RID: 118470 RVA: 0x0080F5DA File Offset: 0x0080D7DA
	protected unsafe virtual void __CPPCALL_MidiGs3On_Implementation(AudioVisualizationInstanceBase.__MidiGs3On_FunctionParams* __Params)
	{
		this.MidiGs3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601CEC7 RID: 118471 RVA: 0x0080F5E8 File Offset: 0x0080D7E8
	protected unsafe virtual void __CPPCALL_MidiA3On_Implementation(AudioVisualizationInstanceBase.__MidiA3On_FunctionParams* __Params)
	{
		this.MidiA3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601CEC8 RID: 118472 RVA: 0x0080F5F6 File Offset: 0x0080D7F6
	protected unsafe virtual void __CPPCALL_MidiAs3On_Implementation(AudioVisualizationInstanceBase.__MidiAs3On_FunctionParams* __Params)
	{
		this.MidiAs3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601CEC9 RID: 118473 RVA: 0x0080F604 File Offset: 0x0080D804
	protected unsafe virtual void __CPPCALL_MidiB3On_Implementation(AudioVisualizationInstanceBase.__MidiB3On_FunctionParams* __Params)
	{
		this.MidiB3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601CECA RID: 118474 RVA: 0x0080F612 File Offset: 0x0080D812
	protected unsafe virtual void __CPPCALL_MidiC3Off_Implementation(AudioVisualizationInstanceBase.__MidiC3Off_FunctionParams* __Params)
	{
		this.MidiC3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601CECB RID: 118475 RVA: 0x0080F620 File Offset: 0x0080D820
	protected unsafe virtual void __CPPCALL_MidiCs3Off_Implementation(AudioVisualizationInstanceBase.__MidiCs3Off_FunctionParams* __Params)
	{
		this.MidiCs3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601CECC RID: 118476 RVA: 0x0080F62E File Offset: 0x0080D82E
	protected unsafe virtual void __CPPCALL_MidiD3Off_Implementation(AudioVisualizationInstanceBase.__MidiD3Off_FunctionParams* __Params)
	{
		this.MidiD3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601CECD RID: 118477 RVA: 0x0080F63C File Offset: 0x0080D83C
	protected unsafe virtual void __CPPCALL_MidiDs3Off_Implementation(AudioVisualizationInstanceBase.__MidiDs3Off_FunctionParams* __Params)
	{
		this.MidiDs3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601CECE RID: 118478 RVA: 0x0080F64A File Offset: 0x0080D84A
	protected unsafe virtual void __CPPCALL_MidiE3Off_Implementation(AudioVisualizationInstanceBase.__MidiE3Off_FunctionParams* __Params)
	{
		this.MidiE3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601CECF RID: 118479 RVA: 0x0080F658 File Offset: 0x0080D858
	protected unsafe virtual void __CPPCALL_MidiF3Off_Implementation(AudioVisualizationInstanceBase.__MidiF3Off_FunctionParams* __Params)
	{
		this.MidiF3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601CED0 RID: 118480 RVA: 0x0080F666 File Offset: 0x0080D866
	protected unsafe virtual void __CPPCALL_MidiFs3Off_Implementation(AudioVisualizationInstanceBase.__MidiFs3Off_FunctionParams* __Params)
	{
		this.MidiFs3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601CED1 RID: 118481 RVA: 0x0080F674 File Offset: 0x0080D874
	protected unsafe virtual void __CPPCALL_MidiG3Off_Implementation(AudioVisualizationInstanceBase.__MidiG3Off_FunctionParams* __Params)
	{
		this.MidiG3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601CED2 RID: 118482 RVA: 0x0080F682 File Offset: 0x0080D882
	protected unsafe virtual void __CPPCALL_MidiGs3Off_Implementation(AudioVisualizationInstanceBase.__MidiGs3Off_FunctionParams* __Params)
	{
		this.MidiGs3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601CED3 RID: 118483 RVA: 0x0080F690 File Offset: 0x0080D890
	protected unsafe virtual void __CPPCALL_MidiA3Off_Implementation(AudioVisualizationInstanceBase.__MidiA3Off_FunctionParams* __Params)
	{
		this.MidiA3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601CED4 RID: 118484 RVA: 0x0080F69E File Offset: 0x0080D89E
	protected unsafe virtual void __CPPCALL_MidiAs3Off_Implementation(AudioVisualizationInstanceBase.__MidiAs3Off_FunctionParams* __Params)
	{
		this.MidiAs3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601CED5 RID: 118485 RVA: 0x0080F6AC File Offset: 0x0080D8AC
	protected unsafe virtual void __CPPCALL_MidiB3Off_Implementation(AudioVisualizationInstanceBase.__MidiB3Off_FunctionParams* __Params)
	{
		this.MidiB3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0400E41A RID: 58394
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<AudioVisualizationInstanceBase> ActorEndPlayCallback;

	// Token: 0x0400E41B RID: 58395
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/AudioVisualization/AudioVisualizationInstanceBase.AudioVisualizationInstanceBase_C";

	// Token: 0x0400E41C RID: 58396
	private static IntPtr _ClassPtr;

	// Token: 0x0400E41D RID: 58397
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E41E RID: 58398
	private static int __PropertyOffset_UberGraphFrame;

	// Token: 0x0400E41F RID: 58399
	private static int __PropertyOffset_DefaultSceneRoot;

	// Token: 0x0400E420 RID: 58400
	private static int __PropertyOffset_Identifier;

	// Token: 0x020097A3 RID: 38819
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __CallBackInternal_FunctionParams
	{
		// Token: 0x04030758 RID: 198488
		[FieldOffset(0)]
		public IntPtr callbackInfo;

		// Token: 0x04030759 RID: 198489
		[FieldOffset(8)]
		public byte callbackType;

		// Token: 0x0403075A RID: 198490
		[FieldOffset(16)]
		public FString state;
	}

	// Token: 0x020097A4 RID: 38820
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiC3On_FunctionParams
	{
		// Token: 0x0403075B RID: 198491
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020097A5 RID: 38821
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiCs3On_FunctionParams
	{
		// Token: 0x0403075C RID: 198492
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020097A6 RID: 38822
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiD3On_FunctionParams
	{
		// Token: 0x0403075D RID: 198493
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020097A7 RID: 38823
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiDs3On_FunctionParams
	{
		// Token: 0x0403075E RID: 198494
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020097A8 RID: 38824
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiE3On_FunctionParams
	{
		// Token: 0x0403075F RID: 198495
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020097A9 RID: 38825
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiF3On_FunctionParams
	{
		// Token: 0x04030760 RID: 198496
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020097AA RID: 38826
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiFs3On_FunctionParams
	{
		// Token: 0x04030761 RID: 198497
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020097AB RID: 38827
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiG3On_FunctionParams
	{
		// Token: 0x04030762 RID: 198498
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020097AC RID: 38828
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiGs3On_FunctionParams
	{
		// Token: 0x04030763 RID: 198499
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020097AD RID: 38829
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiA3On_FunctionParams
	{
		// Token: 0x04030764 RID: 198500
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020097AE RID: 38830
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiAs3On_FunctionParams
	{
		// Token: 0x04030765 RID: 198501
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020097AF RID: 38831
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiB3On_FunctionParams
	{
		// Token: 0x04030766 RID: 198502
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020097B0 RID: 38832
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiC3Off_FunctionParams
	{
		// Token: 0x04030767 RID: 198503
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020097B1 RID: 38833
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiCs3Off_FunctionParams
	{
		// Token: 0x04030768 RID: 198504
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020097B2 RID: 38834
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiD3Off_FunctionParams
	{
		// Token: 0x04030769 RID: 198505
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020097B3 RID: 38835
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiDs3Off_FunctionParams
	{
		// Token: 0x0403076A RID: 198506
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020097B4 RID: 38836
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiE3Off_FunctionParams
	{
		// Token: 0x0403076B RID: 198507
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020097B5 RID: 38837
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiF3Off_FunctionParams
	{
		// Token: 0x0403076C RID: 198508
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020097B6 RID: 38838
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiFs3Off_FunctionParams
	{
		// Token: 0x0403076D RID: 198509
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020097B7 RID: 38839
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiG3Off_FunctionParams
	{
		// Token: 0x0403076E RID: 198510
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020097B8 RID: 38840
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiGs3Off_FunctionParams
	{
		// Token: 0x0403076F RID: 198511
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020097B9 RID: 38841
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiA3Off_FunctionParams
	{
		// Token: 0x04030770 RID: 198512
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020097BA RID: 38842
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiAs3Off_FunctionParams
	{
		// Token: 0x04030771 RID: 198513
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020097BB RID: 38843
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiB3Off_FunctionParams
	{
		// Token: 0x04030772 RID: 198514
		[FieldOffset(0)]
		public byte velocity;
	}
}
