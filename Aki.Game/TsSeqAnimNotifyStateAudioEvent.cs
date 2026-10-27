using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Plot.Sequence;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200018D RID: 397
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsSeqAnimNotifyStateAudioEvent.TsSeqAnimNotifyStateAudioEvent_C")]
public class TsSeqAnimNotifyStateAudioEvent : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700041A RID: 1050
	// (get) Token: 0x0600194C RID: 6476 RVA: 0x00085D1C File Offset: 0x00083F1C
	// (set) Token: 0x0600194D RID: 6477 RVA: 0x00085D55 File Offset: 0x00083F55
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<UAkAudioEvent> AudioEvent
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<UAkAudioEvent> result;
			if ((result = this._AudioEvent) == null)
			{
				result = (this._AudioEvent = new TSoftObjectPtr<UAkAudioEvent>(base.NativePtr + (IntPtr)TsSeqAnimNotifyStateAudioEvent.__PropertyOffset_AudioEvent, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)TsSeqAnimNotifyStateAudioEvent.__PropertyOffset_AudioEvent, 1);
		}
	}

	// Token: 0x1700041B RID: 1051
	// (get) Token: 0x0600194E RID: 6478 RVA: 0x00085D7A File Offset: 0x00083F7A
	// (set) Token: 0x0600194F RID: 6479 RVA: 0x00085D8E File Offset: 0x00083F8E
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName SocketName
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsSeqAnimNotifyStateAudioEvent.__PropertyOffset_SocketName);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsSeqAnimNotifyStateAudioEvent.__PropertyOffset_SocketName) = value;
		}
	}

	// Token: 0x1700041C RID: 1052
	// (get) Token: 0x06001950 RID: 6480 RVA: 0x00085DA3 File Offset: 0x00083FA3
	// (set) Token: 0x06001951 RID: 6481 RVA: 0x00085DB3 File Offset: 0x00083FB3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool Follow
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsSeqAnimNotifyStateAudioEvent.__PropertyOffset_Follow) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsSeqAnimNotifyStateAudioEvent.__PropertyOffset_Follow) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700041D RID: 1053
	// (get) Token: 0x06001952 RID: 6482 RVA: 0x00085DC4 File Offset: 0x00083FC4
	// (set) Token: 0x06001953 RID: 6483 RVA: 0x00085DD4 File Offset: 0x00083FD4
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool KeepAlive
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsSeqAnimNotifyStateAudioEvent.__PropertyOffset_KeepAlive) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsSeqAnimNotifyStateAudioEvent.__PropertyOffset_KeepAlive) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700041E RID: 1054
	// (get) Token: 0x06001954 RID: 6484 RVA: 0x00085DE5 File Offset: 0x00083FE5
	// (set) Token: 0x06001955 RID: 6485 RVA: 0x00085DF5 File Offset: 0x00083FF5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int FadeDuration
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsSeqAnimNotifyStateAudioEvent.__PropertyOffset_FadeDuration);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsSeqAnimNotifyStateAudioEvent.__PropertyOffset_FadeDuration) = value;
		}
	}

	// Token: 0x1700041F RID: 1055
	// (get) Token: 0x06001956 RID: 6486 RVA: 0x00085E06 File Offset: 0x00084006
	// (set) Token: 0x06001957 RID: 6487 RVA: 0x00085E16 File Offset: 0x00084016
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EAudioFadeCurve FadeCurve
	{
		get
		{
			return (EAudioFadeCurve)(*(base.NativePtr + (IntPtr)TsSeqAnimNotifyStateAudioEvent.__PropertyOffset_FadeCurve));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsSeqAnimNotifyStateAudioEvent.__PropertyOffset_FadeCurve) = (byte)value;
		}
	}

	// Token: 0x17000420 RID: 1056
	// (get) Token: 0x06001958 RID: 6488 RVA: 0x00085E28 File Offset: 0x00084028
	// (set) Token: 0x06001959 RID: 6489 RVA: 0x00085E61 File Offset: 0x00084061
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<UAkAudioEvent> TrailingAudioEvent
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<UAkAudioEvent> result;
			if ((result = this._TrailingAudioEvent) == null)
			{
				result = (this._TrailingAudioEvent = new TSoftObjectPtr<UAkAudioEvent>(base.NativePtr + (IntPtr)TsSeqAnimNotifyStateAudioEvent.__PropertyOffset_TrailingAudioEvent, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)TsSeqAnimNotifyStateAudioEvent.__PropertyOffset_TrailingAudioEvent, 1);
		}
	}

	// Token: 0x0600195A RID: 6490 RVA: 0x00085E88 File Offset: 0x00084088
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotifyState.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		string result = FString.ToString((void*)(&ptr2->__Result));
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return result;
	}

	// Token: 0x0600195B RID: 6491 RVA: 0x00085F03 File Offset: 0x00084103
	protected override string GetNotifyName_Implementation()
	{
		if (!(this.AudioEvent != null))
		{
			return "AudioEvent";
		}
		return "AudioEvent: " + AudioSystem.Instance.parseAudioEventPath(this.AudioEvent);
	}

	// Token: 0x0600195C RID: 6492 RVA: 0x00085F34 File Offset: 0x00084134
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComponent, UAnimSequenceBase animSequence, float totalDuration)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyBegin"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComponent != null) ? meshComponent.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animSequence != null) ? animSequence.NativePtr : ((IntPtr)0));
			ptr2->TotalDuration = totalDuration;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0600195D RID: 6493 RVA: 0x00085FDC File Offset: 0x000841DC
	[NullableContext(2)]
	protected unsafe virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComponent, UAnimSequenceBase animSequence, float totalDuration)
	{
		if (meshComponent == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Audio;
			ELogAuthor author = ELogAuthor.JYS;
			string message = "不存在的MeshComp";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("AnimNotify", this);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		if (meshComponent.bHiddenInGame)
		{
			return false;
		}
		bool flag = false;
		BP_EWorldType worldType = UKuroRenderingRuntimeBPPluginBPLibrary.GetWorldType(meshComponent.GetOwner());
		if (worldType != BP_EWorldType.Game && worldType != BP_EWorldType.PIE)
		{
			ULevelSequence selectedSequenceInEditor = SequenceUtils.GetSelectedSequenceInEditor();
			if (selectedSequenceInEditor != null)
			{
				flag = selectedSequenceInEditor.GetAnimAudio();
			}
		}
		else
		{
			ALevelSequenceActor curLevelSeqActor = SequenceModel.Instance.CurLevelSeqActor;
			bool? flag2;
			if (curLevelSeqActor == null)
			{
				flag2 = null;
			}
			else
			{
				ULevelSequence sequence = curLevelSeqActor.GetSequence();
				flag2 = ((sequence != null) ? new bool?(sequence.GetAnimAudio()) : null);
			}
			bool? flag3 = flag2;
			flag = flag3.GetValueOrDefault();
		}
		if (!flag)
		{
			return false;
		}
		this.NotifyDuration = totalDuration;
		if (this.AudioEvent == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Audio;
			ELogAuthor author2 = ELogAuthor.JYS;
			string message2 = "[Game.AnimNotifyState] 无效的 AudioEvent";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("AnimNotify", this);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("AnimSequence", UKismetSystemLibrary.GetPathName(animSequence));
			instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		string text = (this.AudioEvent != null) ? AudioSystem.Instance.parseAudioEventPath(this.AudioEvent) : null;
		if (text != null)
		{
			this.PostAudioEvent(text, meshComponent, animSequence);
		}
		return true;
	}

	// Token: 0x0600195E RID: 6494 RVA: 0x00086130 File Offset: 0x00084330
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComponent, UAnimSequenceBase animSequence)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyEnd"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComponent != null) ? meshComponent.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animSequence != null) ? animSequence.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0600195F RID: 6495 RVA: 0x000861D0 File Offset: 0x000843D0
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComponent, UAnimSequenceBase animSequence)
	{
		if (meshComponent == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Audio;
			ELogAuthor author = ELogAuthor.JYS;
			string message = "[Game.AnimNotify] 不存在的MeshComp";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("AnimNotify", this);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		if (meshComponent.bHiddenInGame)
		{
			return false;
		}
		bool flag = false;
		BP_EWorldType worldType = UKuroRenderingRuntimeBPPluginBPLibrary.GetWorldType(meshComponent.GetOwner());
		if (worldType != BP_EWorldType.Game && worldType != BP_EWorldType.PIE)
		{
			ULevelSequence selectedSequenceInEditor = SequenceUtils.GetSelectedSequenceInEditor();
			if (selectedSequenceInEditor != null)
			{
				flag = selectedSequenceInEditor.GetAnimAudio();
			}
		}
		else
		{
			ALevelSequenceActor curLevelSeqActor = SequenceModel.Instance.CurLevelSeqActor;
			bool? flag2;
			if (curLevelSeqActor == null)
			{
				flag2 = null;
			}
			else
			{
				ULevelSequence sequence = curLevelSeqActor.GetSequence();
				flag2 = ((sequence != null) ? new bool?(sequence.GetAnimAudio()) : null);
			}
			bool? flag3 = flag2;
			flag = flag3.GetValueOrDefault();
		}
		if (!flag)
		{
			return false;
		}
		if (this.KeepAlive && base.GetCurrentTriggerOffsetInThisNotifyTick() > this.NotifyDuration)
		{
			return false;
		}
		AActor owner = meshComponent.GetOwner();
		if (owner == null)
		{
			return false;
		}
		if (owner.bHidden)
		{
			return false;
		}
		int handle = 0;
		if (owner != null && this.HandleMap.TryGetValue(owner, out handle))
		{
			AudioSystem.Instance.ExecuteAction(handle, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs
			{
				TransitionDuration = new int?(this.FadeDuration),
				TransitionFadeCurve = new EAudioFadeCurve?(this.FadeCurve)
			}));
			this.HandleMap.Remove(owner);
			string text = (this.TrailingAudioEvent != null) ? AudioSystem.Instance.parseAudioEventPath(this.TrailingAudioEvent) : null;
			if (text != null)
			{
				this.PostAudioEvent(text, meshComponent, animSequence);
			}
			return true;
		}
		return true;
	}

	// Token: 0x06001960 RID: 6496 RVA: 0x0008634C File Offset: 0x0008454C
	private unsafe void PostAudioEvent(string eventName, USkeletalMeshComponent meshComponent, UAnimSequenceBase animSequence)
	{
		AActor owner = meshComponent.GetOwner();
		if (owner == null || !owner.IsValid())
		{
			return;
		}
		if (owner.bHidden)
		{
			return;
		}
		if (!SequenceUtils.CheckIfUseAudioSeq(owner))
		{
			return;
		}
		if (!this.Follow)
		{
			FTransformDouble value = meshComponent.D_GetSocketTransform(this.SocketName, ERelativeTransformSpace.RTS_World);
			int value2 = AudioSystem.Instance.PostEvent(eventName, new FTransformDouble?(value), null);
			this.HandleMap.Add(owner, value2);
			return;
		}
		UAkComponent akComponent = AudioSystem.Instance.GetAkComponent(meshComponent, new FName?(this.SocketName), null);
		if (akComponent == null || !akComponent.IsValid())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Audio;
			ELogAuthor author = ELogAuthor.JYS;
			string message = "[Game.AnimNotify] 无效的 akComponent";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EventName", eventName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("AnimNotify", this);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("AnimSequence", UKismetSystemLibrary.GetPathName(animSequence));
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		int value3 = AudioSystem.Instance.PostEvent(eventName, meshComponent.GetOwner(), null);
		this.HandleMap.Add(owner, value3);
	}

	// Token: 0x06001961 RID: 6497 RVA: 0x00086490 File Offset: 0x00084690
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsSeqAnimNotifyStateAudioEvent._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsSeqAnimNotifyStateAudioEvent.TsSeqAnimNotifyStateAudioEvent_C");
		}
		return TsSeqAnimNotifyStateAudioEvent._ClassPtr;
	}

	// Token: 0x06001962 RID: 6498 RVA: 0x000864B4 File Offset: 0x000846B4
	public TsSeqAnimNotifyStateAudioEvent() : this(BuiltinUtils.AllocNativeUObject(TsSeqAnimNotifyStateAudioEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001963 RID: 6499 RVA: 0x000864DC File Offset: 0x000846DC
	public TsSeqAnimNotifyStateAudioEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSeqAnimNotifyStateAudioEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001964 RID: 6500 RVA: 0x0008650F File Offset: 0x0008470F
	protected TsSeqAnimNotifyStateAudioEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001965 RID: 6501 RVA: 0x00086523 File Offset: 0x00084723
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x06001966 RID: 6502 RVA: 0x00086538 File Offset: 0x00084738
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001967 RID: 6503 RVA: 0x00086574 File Offset: 0x00084774
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040010AD RID: 4269
	private const int DEFAULT_FADE_DURATION = 500;

	// Token: 0x040010AE RID: 4270
	private float NotifyDuration;

	// Token: 0x040010AF RID: 4271
	private readonly Dictionary<AActor, int> HandleMap = new Dictionary<AActor, int>();

	// Token: 0x040010B0 RID: 4272
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsSeqAnimNotifyStateAudioEvent.TsSeqAnimNotifyStateAudioEvent_C";

	// Token: 0x040010B1 RID: 4273
	private static IntPtr _ClassPtr;

	// Token: 0x040010B2 RID: 4274
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040010B3 RID: 4275
	private static int __PropertyOffset_AudioEvent;

	// Token: 0x040010B4 RID: 4276
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UAkAudioEvent> _AudioEvent;

	// Token: 0x040010B5 RID: 4277
	private static int __PropertyOffset_SocketName;

	// Token: 0x040010B6 RID: 4278
	private static int __PropertyOffset_Follow;

	// Token: 0x040010B7 RID: 4279
	private static int __PropertyOffset_KeepAlive;

	// Token: 0x040010B8 RID: 4280
	private static int __PropertyOffset_FadeDuration;

	// Token: 0x040010B9 RID: 4281
	private static int __PropertyOffset_FadeCurve;

	// Token: 0x040010BA RID: 4282
	private static int __PropertyOffset_TrailingAudioEvent;

	// Token: 0x040010BB RID: 4283
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UAkAudioEvent> _TrailingAudioEvent;
}
