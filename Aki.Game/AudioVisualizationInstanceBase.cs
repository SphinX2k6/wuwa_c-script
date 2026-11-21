using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020029CA RID: 10698
[UClass("/Game/Aki/TypeScript/Game/Render/AudioVisualization/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/AudioVisualization/AudioVisualizationInstanceBase.AudioVisualizationInstanceBase_C")]
public class AudioVisualizationInstanceBase : AActor, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002B42 RID: 11074
	// (get) Token: 0x0601AB74 RID: 109428 RVA: 0x00834B1A File Offset: 0x00832D1A
	// (set) Token: 0x0601AB75 RID: 109429 RVA: 0x00834B2E File Offset: 0x00832D2E
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

	// Token: 0x0601AB76 RID: 109430 RVA: 0x00834B43 File Offset: 0x00832D43
	public override void ReceiveEndPlay(EEndPlayReason endPlayReason)
	{
		Action<AudioVisualizationInstanceBase> actorEndPlayCallback = this.ActorEndPlayCallback;
		if (actorEndPlayCallback == null)
		{
			return;
		}
		actorEndPlayCallback(this);
	}

	// Token: 0x0601AB77 RID: 109431 RVA: 0x00834B58 File Offset: 0x00832D58
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

	// Token: 0x0601AB78 RID: 109432 RVA: 0x00834BC4 File Offset: 0x00832DC4
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

	// Token: 0x0601AB79 RID: 109433 RVA: 0x00834C30 File Offset: 0x00832E30
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

	// Token: 0x0601AB7A RID: 109434 RVA: 0x00834C88 File Offset: 0x00832E88
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

	// Token: 0x0601AB7B RID: 109435 RVA: 0x00834D54 File Offset: 0x00832F54
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

	// Token: 0x0601AB7C RID: 109436 RVA: 0x00834E20 File Offset: 0x00833020
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void StartInternal()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(AudioVisualizationInstanceBase) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("StartInternal"), AudioVisualizationInstanceBase.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.StartInternal_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601AB7D RID: 109437 RVA: 0x00834E79 File Offset: 0x00833079
	protected void StartInternal_Implementation()
	{
	}

	// Token: 0x0601AB7E RID: 109438 RVA: 0x00834E7C File Offset: 0x0083307C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void EndInternal()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(AudioVisualizationInstanceBase) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("EndInternal"), AudioVisualizationInstanceBase.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.EndInternal_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601AB7F RID: 109439 RVA: 0x00834ED5 File Offset: 0x008330D5
	protected void EndInternal_Implementation()
	{
	}

	// Token: 0x0601AB80 RID: 109440 RVA: 0x00834ED8 File Offset: 0x008330D8
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void CallBackInternal([Nullable(2)] UAkCallbackInfo callbackInfo, EAkCallbackType callbackType, string state)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AudioVisualizationInstanceBase) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("CallBackInternal"), AudioVisualizationInstanceBase.StaticClass(), out intPtr, out num))
		{
			this.CallBackInternal_Implementation(callbackInfo, callbackType, state);
			return;
		}
		AudioVisualizationInstanceBase.__CallBackInternal_FunctionParams* ptr = stackalloc AudioVisualizationInstanceBase.__CallBackInternal_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AudioVisualizationInstanceBase.__CallBackInternal_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->callbackInfo) = ((callbackInfo != null) ? callbackInfo.NativePtr : ((IntPtr)0));
		*(&ptr->callbackType) = (byte)callbackType;
		FString.CopyFrom((void*)(&ptr->state), state);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AB81 RID: 109441 RVA: 0x00834F8A File Offset: 0x0083318A
	[NullableContext(1)]
	protected void CallBackInternal_Implementation([Nullable(2)] UAkCallbackInfo callbackInfo, EAkCallbackType callbackType, string state)
	{
	}

	// Token: 0x0601AB82 RID: 109442 RVA: 0x00834F8C File Offset: 0x0083318C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void MidiBpm()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(AudioVisualizationInstanceBase) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("MidiBpm"), AudioVisualizationInstanceBase.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.MidiBpm_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601AB83 RID: 109443 RVA: 0x00834FE5 File Offset: 0x008331E5
	protected void MidiBpm_Implementation()
	{
	}

	// Token: 0x0601AB84 RID: 109444 RVA: 0x00834FE8 File Offset: 0x008331E8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiC3On(byte velocity)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AudioVisualizationInstanceBase) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("MidiC3On"), AudioVisualizationInstanceBase.StaticClass(), out intPtr, out num))
		{
			this.MidiC3On_Implementation(velocity);
			return;
		}
		AudioVisualizationInstanceBase.__MidiC3On_FunctionParams* ptr = stackalloc AudioVisualizationInstanceBase.__MidiC3On_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiC3On_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->velocity = velocity;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AB85 RID: 109445 RVA: 0x00835074 File Offset: 0x00833274
	protected void MidiC3On_Implementation(byte velocity)
	{
	}

	// Token: 0x0601AB86 RID: 109446 RVA: 0x00835078 File Offset: 0x00833278
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiCs3On(byte velocity)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AudioVisualizationInstanceBase) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("MidiCs3On"), AudioVisualizationInstanceBase.StaticClass(), out intPtr, out num))
		{
			this.MidiCs3On_Implementation(velocity);
			return;
		}
		AudioVisualizationInstanceBase.__MidiCs3On_FunctionParams* ptr = stackalloc AudioVisualizationInstanceBase.__MidiCs3On_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiCs3On_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->velocity = velocity;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AB87 RID: 109447 RVA: 0x00835104 File Offset: 0x00833304
	protected void MidiCs3On_Implementation(byte velocity)
	{
	}

	// Token: 0x0601AB88 RID: 109448 RVA: 0x00835108 File Offset: 0x00833308
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiD3On(byte velocity)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AudioVisualizationInstanceBase) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("MidiD3On"), AudioVisualizationInstanceBase.StaticClass(), out intPtr, out num))
		{
			this.MidiD3On_Implementation(velocity);
			return;
		}
		AudioVisualizationInstanceBase.__MidiD3On_FunctionParams* ptr = stackalloc AudioVisualizationInstanceBase.__MidiD3On_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiD3On_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->velocity = velocity;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AB89 RID: 109449 RVA: 0x00835194 File Offset: 0x00833394
	protected void MidiD3On_Implementation(byte velocity)
	{
	}

	// Token: 0x0601AB8A RID: 109450 RVA: 0x00835198 File Offset: 0x00833398
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiDs3On(byte velocity)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AudioVisualizationInstanceBase) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("MidiDs3On"), AudioVisualizationInstanceBase.StaticClass(), out intPtr, out num))
		{
			this.MidiDs3On_Implementation(velocity);
			return;
		}
		AudioVisualizationInstanceBase.__MidiDs3On_FunctionParams* ptr = stackalloc AudioVisualizationInstanceBase.__MidiDs3On_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiDs3On_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->velocity = velocity;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AB8B RID: 109451 RVA: 0x00835224 File Offset: 0x00833424
	protected void MidiDs3On_Implementation(byte velocity)
	{
	}

	// Token: 0x0601AB8C RID: 109452 RVA: 0x00835228 File Offset: 0x00833428
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiE3On(byte velocity)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AudioVisualizationInstanceBase) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("MidiE3On"), AudioVisualizationInstanceBase.StaticClass(), out intPtr, out num))
		{
			this.MidiE3On_Implementation(velocity);
			return;
		}
		AudioVisualizationInstanceBase.__MidiE3On_FunctionParams* ptr = stackalloc AudioVisualizationInstanceBase.__MidiE3On_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiE3On_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->velocity = velocity;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AB8D RID: 109453 RVA: 0x008352B4 File Offset: 0x008334B4
	protected void MidiE3On_Implementation(byte velocity)
	{
	}

	// Token: 0x0601AB8E RID: 109454 RVA: 0x008352B8 File Offset: 0x008334B8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiF3On(byte velocity)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AudioVisualizationInstanceBase) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("MidiF3On"), AudioVisualizationInstanceBase.StaticClass(), out intPtr, out num))
		{
			this.MidiF3On_Implementation(velocity);
			return;
		}
		AudioVisualizationInstanceBase.__MidiF3On_FunctionParams* ptr = stackalloc AudioVisualizationInstanceBase.__MidiF3On_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiF3On_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->velocity = velocity;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AB8F RID: 109455 RVA: 0x00835344 File Offset: 0x00833544
	protected void MidiF3On_Implementation(byte velocity)
	{
	}

	// Token: 0x0601AB90 RID: 109456 RVA: 0x00835348 File Offset: 0x00833548
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiFs3On(byte velocity)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AudioVisualizationInstanceBase) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("MidiFs3On"), AudioVisualizationInstanceBase.StaticClass(), out intPtr, out num))
		{
			this.MidiFs3On_Implementation(velocity);
			return;
		}
		AudioVisualizationInstanceBase.__MidiFs3On_FunctionParams* ptr = stackalloc AudioVisualizationInstanceBase.__MidiFs3On_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiFs3On_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->velocity = velocity;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AB91 RID: 109457 RVA: 0x008353D4 File Offset: 0x008335D4
	protected void MidiFs3On_Implementation(byte velocity)
	{
	}

	// Token: 0x0601AB92 RID: 109458 RVA: 0x008353D8 File Offset: 0x008335D8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiG3On(byte velocity)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AudioVisualizationInstanceBase) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("MidiG3On"), AudioVisualizationInstanceBase.StaticClass(), out intPtr, out num))
		{
			this.MidiG3On_Implementation(velocity);
			return;
		}
		AudioVisualizationInstanceBase.__MidiG3On_FunctionParams* ptr = stackalloc AudioVisualizationInstanceBase.__MidiG3On_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiG3On_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->velocity = velocity;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AB93 RID: 109459 RVA: 0x00835464 File Offset: 0x00833664
	protected void MidiG3On_Implementation(byte velocity)
	{
	}

	// Token: 0x0601AB94 RID: 109460 RVA: 0x00835468 File Offset: 0x00833668
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiGs3On(byte velocity)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AudioVisualizationInstanceBase) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("MidiGs3On"), AudioVisualizationInstanceBase.StaticClass(), out intPtr, out num))
		{
			this.MidiGs3On_Implementation(velocity);
			return;
		}
		AudioVisualizationInstanceBase.__MidiGs3On_FunctionParams* ptr = stackalloc AudioVisualizationInstanceBase.__MidiGs3On_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiGs3On_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->velocity = velocity;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AB95 RID: 109461 RVA: 0x008354F4 File Offset: 0x008336F4
	protected void MidiGs3On_Implementation(byte velocity)
	{
	}

	// Token: 0x0601AB96 RID: 109462 RVA: 0x008354F8 File Offset: 0x008336F8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiA3On(byte velocity)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AudioVisualizationInstanceBase) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("MidiA3On"), AudioVisualizationInstanceBase.StaticClass(), out intPtr, out num))
		{
			this.MidiA3On_Implementation(velocity);
			return;
		}
		AudioVisualizationInstanceBase.__MidiA3On_FunctionParams* ptr = stackalloc AudioVisualizationInstanceBase.__MidiA3On_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiA3On_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->velocity = velocity;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AB97 RID: 109463 RVA: 0x00835584 File Offset: 0x00833784
	protected void MidiA3On_Implementation(byte velocity)
	{
	}

	// Token: 0x0601AB98 RID: 109464 RVA: 0x00835588 File Offset: 0x00833788
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiAs3On(byte velocity)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AudioVisualizationInstanceBase) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("MidiAs3On"), AudioVisualizationInstanceBase.StaticClass(), out intPtr, out num))
		{
			this.MidiAs3On_Implementation(velocity);
			return;
		}
		AudioVisualizationInstanceBase.__MidiAs3On_FunctionParams* ptr = stackalloc AudioVisualizationInstanceBase.__MidiAs3On_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiAs3On_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->velocity = velocity;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AB99 RID: 109465 RVA: 0x00835614 File Offset: 0x00833814
	protected void MidiAs3On_Implementation(byte velocity)
	{
	}

	// Token: 0x0601AB9A RID: 109466 RVA: 0x00835618 File Offset: 0x00833818
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiB3On(byte velocity)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AudioVisualizationInstanceBase) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("MidiB3On"), AudioVisualizationInstanceBase.StaticClass(), out intPtr, out num))
		{
			this.MidiB3On_Implementation(velocity);
			return;
		}
		AudioVisualizationInstanceBase.__MidiB3On_FunctionParams* ptr = stackalloc AudioVisualizationInstanceBase.__MidiB3On_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiB3On_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->velocity = velocity;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AB9B RID: 109467 RVA: 0x008356A4 File Offset: 0x008338A4
	protected void MidiB3On_Implementation(byte velocity)
	{
	}

	// Token: 0x0601AB9C RID: 109468 RVA: 0x008356A8 File Offset: 0x008338A8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiC3Off(byte velocity)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AudioVisualizationInstanceBase) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("MidiC3Off"), AudioVisualizationInstanceBase.StaticClass(), out intPtr, out num))
		{
			this.MidiC3Off_Implementation(velocity);
			return;
		}
		AudioVisualizationInstanceBase.__MidiC3Off_FunctionParams* ptr = stackalloc AudioVisualizationInstanceBase.__MidiC3Off_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiC3Off_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->velocity = velocity;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AB9D RID: 109469 RVA: 0x00835734 File Offset: 0x00833934
	protected void MidiC3Off_Implementation(byte velocity)
	{
	}

	// Token: 0x0601AB9E RID: 109470 RVA: 0x00835738 File Offset: 0x00833938
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiCs3Off(byte velocity)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AudioVisualizationInstanceBase) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("MidiCs3Off"), AudioVisualizationInstanceBase.StaticClass(), out intPtr, out num))
		{
			this.MidiCs3Off_Implementation(velocity);
			return;
		}
		AudioVisualizationInstanceBase.__MidiCs3Off_FunctionParams* ptr = stackalloc AudioVisualizationInstanceBase.__MidiCs3Off_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiCs3Off_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->velocity = velocity;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AB9F RID: 109471 RVA: 0x008357C4 File Offset: 0x008339C4
	protected void MidiCs3Off_Implementation(byte velocity)
	{
	}

	// Token: 0x0601ABA0 RID: 109472 RVA: 0x008357C8 File Offset: 0x008339C8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiD3Off(byte velocity)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AudioVisualizationInstanceBase) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("MidiD3Off"), AudioVisualizationInstanceBase.StaticClass(), out intPtr, out num))
		{
			this.MidiD3Off_Implementation(velocity);
			return;
		}
		AudioVisualizationInstanceBase.__MidiD3Off_FunctionParams* ptr = stackalloc AudioVisualizationInstanceBase.__MidiD3Off_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiD3Off_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->velocity = velocity;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601ABA1 RID: 109473 RVA: 0x00835854 File Offset: 0x00833A54
	protected void MidiD3Off_Implementation(byte velocity)
	{
	}

	// Token: 0x0601ABA2 RID: 109474 RVA: 0x00835858 File Offset: 0x00833A58
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiDs3Off(byte velocity)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AudioVisualizationInstanceBase) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("MidiDs3Off"), AudioVisualizationInstanceBase.StaticClass(), out intPtr, out num))
		{
			this.MidiDs3Off_Implementation(velocity);
			return;
		}
		AudioVisualizationInstanceBase.__MidiDs3Off_FunctionParams* ptr = stackalloc AudioVisualizationInstanceBase.__MidiDs3Off_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiDs3Off_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->velocity = velocity;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601ABA3 RID: 109475 RVA: 0x008358E4 File Offset: 0x00833AE4
	protected void MidiDs3Off_Implementation(byte velocity)
	{
	}

	// Token: 0x0601ABA4 RID: 109476 RVA: 0x008358E8 File Offset: 0x00833AE8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiE3Off(byte velocity)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AudioVisualizationInstanceBase) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("MidiE3Off"), AudioVisualizationInstanceBase.StaticClass(), out intPtr, out num))
		{
			this.MidiE3Off_Implementation(velocity);
			return;
		}
		AudioVisualizationInstanceBase.__MidiE3Off_FunctionParams* ptr = stackalloc AudioVisualizationInstanceBase.__MidiE3Off_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiE3Off_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->velocity = velocity;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601ABA5 RID: 109477 RVA: 0x00835974 File Offset: 0x00833B74
	protected void MidiE3Off_Implementation(byte velocity)
	{
	}

	// Token: 0x0601ABA6 RID: 109478 RVA: 0x00835978 File Offset: 0x00833B78
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiF3Off(byte velocity)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AudioVisualizationInstanceBase) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("MidiF3Off"), AudioVisualizationInstanceBase.StaticClass(), out intPtr, out num))
		{
			this.MidiF3Off_Implementation(velocity);
			return;
		}
		AudioVisualizationInstanceBase.__MidiF3Off_FunctionParams* ptr = stackalloc AudioVisualizationInstanceBase.__MidiF3Off_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiF3Off_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->velocity = velocity;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601ABA7 RID: 109479 RVA: 0x00835A04 File Offset: 0x00833C04
	protected void MidiF3Off_Implementation(byte velocity)
	{
	}

	// Token: 0x0601ABA8 RID: 109480 RVA: 0x00835A08 File Offset: 0x00833C08
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiFs3Off(byte velocity)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AudioVisualizationInstanceBase) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("MidiFs3Off"), AudioVisualizationInstanceBase.StaticClass(), out intPtr, out num))
		{
			this.MidiFs3Off_Implementation(velocity);
			return;
		}
		AudioVisualizationInstanceBase.__MidiFs3Off_FunctionParams* ptr = stackalloc AudioVisualizationInstanceBase.__MidiFs3Off_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiFs3Off_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->velocity = velocity;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601ABA9 RID: 109481 RVA: 0x00835A94 File Offset: 0x00833C94
	protected void MidiFs3Off_Implementation(byte velocity)
	{
	}

	// Token: 0x0601ABAA RID: 109482 RVA: 0x00835A98 File Offset: 0x00833C98
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiG3Off(byte velocity)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AudioVisualizationInstanceBase) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("MidiG3Off"), AudioVisualizationInstanceBase.StaticClass(), out intPtr, out num))
		{
			this.MidiG3Off_Implementation(velocity);
			return;
		}
		AudioVisualizationInstanceBase.__MidiG3Off_FunctionParams* ptr = stackalloc AudioVisualizationInstanceBase.__MidiG3Off_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiG3Off_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->velocity = velocity;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601ABAB RID: 109483 RVA: 0x00835B24 File Offset: 0x00833D24
	protected void MidiG3Off_Implementation(byte velocity)
	{
	}

	// Token: 0x0601ABAC RID: 109484 RVA: 0x00835B28 File Offset: 0x00833D28
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiGs3Off(byte velocity)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AudioVisualizationInstanceBase) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("MidiGs3Off"), AudioVisualizationInstanceBase.StaticClass(), out intPtr, out num))
		{
			this.MidiGs3Off_Implementation(velocity);
			return;
		}
		AudioVisualizationInstanceBase.__MidiGs3Off_FunctionParams* ptr = stackalloc AudioVisualizationInstanceBase.__MidiGs3Off_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiGs3Off_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->velocity = velocity;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601ABAD RID: 109485 RVA: 0x00835BB4 File Offset: 0x00833DB4
	protected void MidiGs3Off_Implementation(byte velocity)
	{
	}

	// Token: 0x0601ABAE RID: 109486 RVA: 0x00835BB8 File Offset: 0x00833DB8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiA3Off(byte velocity)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AudioVisualizationInstanceBase) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("MidiA3Off"), AudioVisualizationInstanceBase.StaticClass(), out intPtr, out num))
		{
			this.MidiA3Off_Implementation(velocity);
			return;
		}
		AudioVisualizationInstanceBase.__MidiA3Off_FunctionParams* ptr = stackalloc AudioVisualizationInstanceBase.__MidiA3Off_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiA3Off_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->velocity = velocity;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601ABAF RID: 109487 RVA: 0x00835C44 File Offset: 0x00833E44
	protected void MidiA3Off_Implementation(byte velocity)
	{
	}

	// Token: 0x0601ABB0 RID: 109488 RVA: 0x00835C48 File Offset: 0x00833E48
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiAs3Off(byte velocity)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AudioVisualizationInstanceBase) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("MidiAs3Off"), AudioVisualizationInstanceBase.StaticClass(), out intPtr, out num))
		{
			this.MidiAs3Off_Implementation(velocity);
			return;
		}
		AudioVisualizationInstanceBase.__MidiAs3Off_FunctionParams* ptr = stackalloc AudioVisualizationInstanceBase.__MidiAs3Off_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiAs3Off_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->velocity = velocity;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601ABB1 RID: 109489 RVA: 0x00835CD4 File Offset: 0x00833ED4
	protected void MidiAs3Off_Implementation(byte velocity)
	{
	}

	// Token: 0x0601ABB2 RID: 109490 RVA: 0x00835CD8 File Offset: 0x00833ED8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MidiB3Off(byte velocity)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AudioVisualizationInstanceBase) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("MidiB3Off"), AudioVisualizationInstanceBase.StaticClass(), out intPtr, out num))
		{
			this.MidiB3Off_Implementation(velocity);
			return;
		}
		AudioVisualizationInstanceBase.__MidiB3Off_FunctionParams* ptr = stackalloc AudioVisualizationInstanceBase.__MidiB3Off_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AudioVisualizationInstanceBase.__MidiB3Off_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->velocity = velocity;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601ABB3 RID: 109491 RVA: 0x00835D64 File Offset: 0x00833F64
	protected void MidiB3Off_Implementation(byte velocity)
	{
	}

	// Token: 0x0601ABB4 RID: 109492 RVA: 0x00835D66 File Offset: 0x00833F66
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (AudioVisualizationInstanceBase._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/AudioVisualization/AudioVisualizationInstanceBase.AudioVisualizationInstanceBase_C");
		}
		return AudioVisualizationInstanceBase._ClassPtr;
	}

	// Token: 0x0601ABB5 RID: 109493 RVA: 0x00835D8C File Offset: 0x00833F8C
	public AudioVisualizationInstanceBase() : this(BuiltinUtils.AllocNativeUObject(AudioVisualizationInstanceBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601ABB6 RID: 109494 RVA: 0x00835DB4 File Offset: 0x00833FB4
	[NullableContext(1)]
	public AudioVisualizationInstanceBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AudioVisualizationInstanceBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601ABB7 RID: 109495 RVA: 0x00835DE7 File Offset: 0x00833FE7
	protected AudioVisualizationInstanceBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x17002B43 RID: 11075
	// (get) Token: 0x0601ABB8 RID: 109496 RVA: 0x00835DF0 File Offset: 0x00833FF0
	[Nullable(2)]
	public unsafe USceneComponent DefaultSceneRoot
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AudioVisualizationInstanceBase.__PropertyOffset_DefaultSceneRoot);
		}
	}

	// Token: 0x0601ABB9 RID: 109497 RVA: 0x00835E04 File Offset: 0x00834004
	protected virtual void __CPPCALL_StartInternal_Implementation()
	{
		this.StartInternal_Implementation();
	}

	// Token: 0x0601ABBA RID: 109498 RVA: 0x00835E0C File Offset: 0x0083400C
	protected virtual void __CPPCALL_EndInternal_Implementation()
	{
		this.EndInternal_Implementation();
	}

	// Token: 0x0601ABBB RID: 109499 RVA: 0x00835E14 File Offset: 0x00834014
	protected unsafe virtual void __CPPCALL_CallBackInternal_Implementation(AudioVisualizationInstanceBase.__CallBackInternal_FunctionParams* __Params)
	{
		UAkCallbackInfo orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAkCallbackInfo>(__Params->callbackInfo);
		EAkCallbackType callbackType = (EAkCallbackType)__Params->callbackType;
		string state = FString.ToString((void*)(&__Params->state));
		this.CallBackInternal_Implementation(orCreateUObjectByNativePointer, callbackType, state);
	}

	// Token: 0x0601ABBC RID: 109500 RVA: 0x00835E4A File Offset: 0x0083404A
	protected virtual void __CPPCALL_MidiBpm_Implementation()
	{
		this.MidiBpm_Implementation();
	}

	// Token: 0x0601ABBD RID: 109501 RVA: 0x00835E52 File Offset: 0x00834052
	protected unsafe virtual void __CPPCALL_MidiC3On_Implementation(AudioVisualizationInstanceBase.__MidiC3On_FunctionParams* __Params)
	{
		this.MidiC3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601ABBE RID: 109502 RVA: 0x00835E60 File Offset: 0x00834060
	protected unsafe virtual void __CPPCALL_MidiCs3On_Implementation(AudioVisualizationInstanceBase.__MidiCs3On_FunctionParams* __Params)
	{
		this.MidiCs3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601ABBF RID: 109503 RVA: 0x00835E6E File Offset: 0x0083406E
	protected unsafe virtual void __CPPCALL_MidiD3On_Implementation(AudioVisualizationInstanceBase.__MidiD3On_FunctionParams* __Params)
	{
		this.MidiD3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601ABC0 RID: 109504 RVA: 0x00835E7C File Offset: 0x0083407C
	protected unsafe virtual void __CPPCALL_MidiDs3On_Implementation(AudioVisualizationInstanceBase.__MidiDs3On_FunctionParams* __Params)
	{
		this.MidiDs3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601ABC1 RID: 109505 RVA: 0x00835E8A File Offset: 0x0083408A
	protected unsafe virtual void __CPPCALL_MidiE3On_Implementation(AudioVisualizationInstanceBase.__MidiE3On_FunctionParams* __Params)
	{
		this.MidiE3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601ABC2 RID: 109506 RVA: 0x00835E98 File Offset: 0x00834098
	protected unsafe virtual void __CPPCALL_MidiF3On_Implementation(AudioVisualizationInstanceBase.__MidiF3On_FunctionParams* __Params)
	{
		this.MidiF3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601ABC3 RID: 109507 RVA: 0x00835EA6 File Offset: 0x008340A6
	protected unsafe virtual void __CPPCALL_MidiFs3On_Implementation(AudioVisualizationInstanceBase.__MidiFs3On_FunctionParams* __Params)
	{
		this.MidiFs3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601ABC4 RID: 109508 RVA: 0x00835EB4 File Offset: 0x008340B4
	protected unsafe virtual void __CPPCALL_MidiG3On_Implementation(AudioVisualizationInstanceBase.__MidiG3On_FunctionParams* __Params)
	{
		this.MidiG3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601ABC5 RID: 109509 RVA: 0x00835EC2 File Offset: 0x008340C2
	protected unsafe virtual void __CPPCALL_MidiGs3On_Implementation(AudioVisualizationInstanceBase.__MidiGs3On_FunctionParams* __Params)
	{
		this.MidiGs3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601ABC6 RID: 109510 RVA: 0x00835ED0 File Offset: 0x008340D0
	protected unsafe virtual void __CPPCALL_MidiA3On_Implementation(AudioVisualizationInstanceBase.__MidiA3On_FunctionParams* __Params)
	{
		this.MidiA3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601ABC7 RID: 109511 RVA: 0x00835EDE File Offset: 0x008340DE
	protected unsafe virtual void __CPPCALL_MidiAs3On_Implementation(AudioVisualizationInstanceBase.__MidiAs3On_FunctionParams* __Params)
	{
		this.MidiAs3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601ABC8 RID: 109512 RVA: 0x00835EEC File Offset: 0x008340EC
	protected unsafe virtual void __CPPCALL_MidiB3On_Implementation(AudioVisualizationInstanceBase.__MidiB3On_FunctionParams* __Params)
	{
		this.MidiB3On_Implementation(__Params->velocity);
	}

	// Token: 0x0601ABC9 RID: 109513 RVA: 0x00835EFA File Offset: 0x008340FA
	protected unsafe virtual void __CPPCALL_MidiC3Off_Implementation(AudioVisualizationInstanceBase.__MidiC3Off_FunctionParams* __Params)
	{
		this.MidiC3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601ABCA RID: 109514 RVA: 0x00835F08 File Offset: 0x00834108
	protected unsafe virtual void __CPPCALL_MidiCs3Off_Implementation(AudioVisualizationInstanceBase.__MidiCs3Off_FunctionParams* __Params)
	{
		this.MidiCs3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601ABCB RID: 109515 RVA: 0x00835F16 File Offset: 0x00834116
	protected unsafe virtual void __CPPCALL_MidiD3Off_Implementation(AudioVisualizationInstanceBase.__MidiD3Off_FunctionParams* __Params)
	{
		this.MidiD3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601ABCC RID: 109516 RVA: 0x00835F24 File Offset: 0x00834124
	protected unsafe virtual void __CPPCALL_MidiDs3Off_Implementation(AudioVisualizationInstanceBase.__MidiDs3Off_FunctionParams* __Params)
	{
		this.MidiDs3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601ABCD RID: 109517 RVA: 0x00835F32 File Offset: 0x00834132
	protected unsafe virtual void __CPPCALL_MidiE3Off_Implementation(AudioVisualizationInstanceBase.__MidiE3Off_FunctionParams* __Params)
	{
		this.MidiE3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601ABCE RID: 109518 RVA: 0x00835F40 File Offset: 0x00834140
	protected unsafe virtual void __CPPCALL_MidiF3Off_Implementation(AudioVisualizationInstanceBase.__MidiF3Off_FunctionParams* __Params)
	{
		this.MidiF3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601ABCF RID: 109519 RVA: 0x00835F4E File Offset: 0x0083414E
	protected unsafe virtual void __CPPCALL_MidiFs3Off_Implementation(AudioVisualizationInstanceBase.__MidiFs3Off_FunctionParams* __Params)
	{
		this.MidiFs3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601ABD0 RID: 109520 RVA: 0x00835F5C File Offset: 0x0083415C
	protected unsafe virtual void __CPPCALL_MidiG3Off_Implementation(AudioVisualizationInstanceBase.__MidiG3Off_FunctionParams* __Params)
	{
		this.MidiG3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601ABD1 RID: 109521 RVA: 0x00835F6A File Offset: 0x0083416A
	protected unsafe virtual void __CPPCALL_MidiGs3Off_Implementation(AudioVisualizationInstanceBase.__MidiGs3Off_FunctionParams* __Params)
	{
		this.MidiGs3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601ABD2 RID: 109522 RVA: 0x00835F78 File Offset: 0x00834178
	protected unsafe virtual void __CPPCALL_MidiA3Off_Implementation(AudioVisualizationInstanceBase.__MidiA3Off_FunctionParams* __Params)
	{
		this.MidiA3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601ABD3 RID: 109523 RVA: 0x00835F86 File Offset: 0x00834186
	protected unsafe virtual void __CPPCALL_MidiAs3Off_Implementation(AudioVisualizationInstanceBase.__MidiAs3Off_FunctionParams* __Params)
	{
		this.MidiAs3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0601ABD4 RID: 109524 RVA: 0x00835F94 File Offset: 0x00834194
	protected unsafe virtual void __CPPCALL_MidiB3Off_Implementation(AudioVisualizationInstanceBase.__MidiB3Off_FunctionParams* __Params)
	{
		this.MidiB3Off_Implementation(__Params->velocity);
	}

	// Token: 0x0400E8CC RID: 59596
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<AudioVisualizationInstanceBase> ActorEndPlayCallback;

	// Token: 0x0400E8CD RID: 59597
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/AudioVisualization/AudioVisualizationInstanceBase.AudioVisualizationInstanceBase_C";

	// Token: 0x0400E8CE RID: 59598
	private static IntPtr _ClassPtr;

	// Token: 0x0400E8CF RID: 59599
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E8D0 RID: 59600
	private static int __PropertyOffset_DefaultSceneRoot;

	// Token: 0x0400E8D1 RID: 59601
	private static int __PropertyOffset_Identifier;

	// Token: 0x020089C6 RID: 35270
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __CallBackInternal_FunctionParams
	{
		// Token: 0x0402BDE5 RID: 179685
		[FieldOffset(0)]
		public IntPtr callbackInfo;

		// Token: 0x0402BDE6 RID: 179686
		[FieldOffset(8)]
		public byte callbackType;

		// Token: 0x0402BDE7 RID: 179687
		[FieldOffset(16)]
		public FString state;
	}

	// Token: 0x020089C7 RID: 35271
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiC3On_FunctionParams
	{
		// Token: 0x0402BDE8 RID: 179688
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020089C8 RID: 35272
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiCs3On_FunctionParams
	{
		// Token: 0x0402BDE9 RID: 179689
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020089C9 RID: 35273
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiD3On_FunctionParams
	{
		// Token: 0x0402BDEA RID: 179690
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020089CA RID: 35274
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiDs3On_FunctionParams
	{
		// Token: 0x0402BDEB RID: 179691
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020089CB RID: 35275
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiE3On_FunctionParams
	{
		// Token: 0x0402BDEC RID: 179692
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020089CC RID: 35276
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiF3On_FunctionParams
	{
		// Token: 0x0402BDED RID: 179693
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020089CD RID: 35277
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiFs3On_FunctionParams
	{
		// Token: 0x0402BDEE RID: 179694
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020089CE RID: 35278
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiG3On_FunctionParams
	{
		// Token: 0x0402BDEF RID: 179695
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020089CF RID: 35279
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiGs3On_FunctionParams
	{
		// Token: 0x0402BDF0 RID: 179696
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020089D0 RID: 35280
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiA3On_FunctionParams
	{
		// Token: 0x0402BDF1 RID: 179697
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020089D1 RID: 35281
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiAs3On_FunctionParams
	{
		// Token: 0x0402BDF2 RID: 179698
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020089D2 RID: 35282
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiB3On_FunctionParams
	{
		// Token: 0x0402BDF3 RID: 179699
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020089D3 RID: 35283
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiC3Off_FunctionParams
	{
		// Token: 0x0402BDF4 RID: 179700
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020089D4 RID: 35284
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiCs3Off_FunctionParams
	{
		// Token: 0x0402BDF5 RID: 179701
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020089D5 RID: 35285
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiD3Off_FunctionParams
	{
		// Token: 0x0402BDF6 RID: 179702
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020089D6 RID: 35286
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiDs3Off_FunctionParams
	{
		// Token: 0x0402BDF7 RID: 179703
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020089D7 RID: 35287
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiE3Off_FunctionParams
	{
		// Token: 0x0402BDF8 RID: 179704
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020089D8 RID: 35288
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiF3Off_FunctionParams
	{
		// Token: 0x0402BDF9 RID: 179705
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020089D9 RID: 35289
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiFs3Off_FunctionParams
	{
		// Token: 0x0402BDFA RID: 179706
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020089DA RID: 35290
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiG3Off_FunctionParams
	{
		// Token: 0x0402BDFB RID: 179707
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020089DB RID: 35291
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiGs3Off_FunctionParams
	{
		// Token: 0x0402BDFC RID: 179708
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020089DC RID: 35292
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiA3Off_FunctionParams
	{
		// Token: 0x0402BDFD RID: 179709
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020089DD RID: 35293
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiAs3Off_FunctionParams
	{
		// Token: 0x0402BDFE RID: 179710
		[FieldOffset(0)]
		public byte velocity;
	}

	// Token: 0x020089DE RID: 35294
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __MidiB3Off_FunctionParams
	{
		// Token: 0x0402BDFF RID: 179711
		[FieldOffset(0)]
		public byte velocity;
	}
}
