using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Plot.Sequence;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000191 RID: 401
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsSeqAnimNotifyStateAudioEvent.TsSeqAnimNotifyStateAudioEvent_C")]
public class TsSeqAnimNotifyStateAudioEvent : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700043C RID: 1084
	// (get) Token: 0x060019E9 RID: 6633 RVA: 0x0008C048 File Offset: 0x0008A248
	// (set) Token: 0x060019EA RID: 6634 RVA: 0x0008C081 File Offset: 0x0008A281
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

	// Token: 0x1700043D RID: 1085
	// (get) Token: 0x060019EB RID: 6635 RVA: 0x0008C0A6 File Offset: 0x0008A2A6
	// (set) Token: 0x060019EC RID: 6636 RVA: 0x0008C0BA File Offset: 0x0008A2BA
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

	// Token: 0x1700043E RID: 1086
	// (get) Token: 0x060019ED RID: 6637 RVA: 0x0008C0CF File Offset: 0x0008A2CF
	// (set) Token: 0x060019EE RID: 6638 RVA: 0x0008C0DF File Offset: 0x0008A2DF
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

	// Token: 0x1700043F RID: 1087
	// (get) Token: 0x060019EF RID: 6639 RVA: 0x0008C0F0 File Offset: 0x0008A2F0
	// (set) Token: 0x060019F0 RID: 6640 RVA: 0x0008C100 File Offset: 0x0008A300
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

	// Token: 0x17000440 RID: 1088
	// (get) Token: 0x060019F1 RID: 6641 RVA: 0x0008C111 File Offset: 0x0008A311
	// (set) Token: 0x060019F2 RID: 6642 RVA: 0x0008C121 File Offset: 0x0008A321
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

	// Token: 0x17000441 RID: 1089
	// (get) Token: 0x060019F3 RID: 6643 RVA: 0x0008C132 File Offset: 0x0008A332
	// (set) Token: 0x060019F4 RID: 6644 RVA: 0x0008C142 File Offset: 0x0008A342
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

	// Token: 0x17000442 RID: 1090
	// (get) Token: 0x060019F5 RID: 6645 RVA: 0x0008C154 File Offset: 0x0008A354
	// (set) Token: 0x060019F6 RID: 6646 RVA: 0x0008C18D File Offset: 0x0008A38D
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

	// Token: 0x060019F7 RID: 6647 RVA: 0x0008C1B4 File Offset: 0x0008A3B4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsSeqAnimNotifyStateAudioEvent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsSeqAnimNotifyStateAudioEvent.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotifyState.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x060019F8 RID: 6648 RVA: 0x0008C244 File Offset: 0x0008A444
	protected override string GetNotifyName_Implementation()
	{
		if (!(this.AudioEvent != null))
		{
			return "AudioEvent";
		}
		return "AudioEvent: " + AudioSystem.Instance.parseAudioEventPath(this.AudioEvent);
	}

	// Token: 0x060019F9 RID: 6649 RVA: 0x0008C274 File Offset: 0x0008A474
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComponent, UAnimSequenceBase animSequence, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsSeqAnimNotifyStateAudioEvent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsSeqAnimNotifyStateAudioEvent.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyBegin_Implementation(meshComponent, animSequence, totalDuration);
		}
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComponent != null) ? meshComponent.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animSequence != null) ? animSequence.NativePtr : ((IntPtr)0));
		ptr->TotalDuration = totalDuration;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x060019FA RID: 6650 RVA: 0x0008C334 File Offset: 0x0008A534
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

	// Token: 0x060019FB RID: 6651 RVA: 0x0008C488 File Offset: 0x0008A688
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComponent, UAnimSequenceBase animSequence)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsSeqAnimNotifyStateAudioEvent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsSeqAnimNotifyStateAudioEvent.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyEnd_Implementation(meshComponent, animSequence);
		}
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComponent != null) ? meshComponent.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animSequence != null) ? animSequence.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x060019FC RID: 6652 RVA: 0x0008C540 File Offset: 0x0008A740
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

	// Token: 0x060019FD RID: 6653 RVA: 0x0008C6BC File Offset: 0x0008A8BC
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

	// Token: 0x060019FE RID: 6654 RVA: 0x0008C800 File Offset: 0x0008AA00
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsSeqAnimNotifyStateAudioEvent._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsSeqAnimNotifyStateAudioEvent.TsSeqAnimNotifyStateAudioEvent_C");
		}
		return TsSeqAnimNotifyStateAudioEvent._ClassPtr;
	}

	// Token: 0x060019FF RID: 6655 RVA: 0x0008C824 File Offset: 0x0008AA24
	public TsSeqAnimNotifyStateAudioEvent() : this(BuiltinUtils.AllocNativeUObject(TsSeqAnimNotifyStateAudioEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001A00 RID: 6656 RVA: 0x0008C84C File Offset: 0x0008AA4C
	public TsSeqAnimNotifyStateAudioEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSeqAnimNotifyStateAudioEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001A01 RID: 6657 RVA: 0x0008C87F File Offset: 0x0008AA7F
	protected TsSeqAnimNotifyStateAudioEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001A02 RID: 6658 RVA: 0x0008C893 File Offset: 0x0008AA93
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x06001A03 RID: 6659 RVA: 0x0008C8A8 File Offset: 0x0008AAA8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001A04 RID: 6660 RVA: 0x0008C8E4 File Offset: 0x0008AAE4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040010F0 RID: 4336
	private const int DEFAULT_FADE_DURATION = 500;

	// Token: 0x040010F1 RID: 4337
	private float NotifyDuration;

	// Token: 0x040010F2 RID: 4338
	private readonly Dictionary<AActor, int> HandleMap = new Dictionary<AActor, int>();

	// Token: 0x040010F3 RID: 4339
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsSeqAnimNotifyStateAudioEvent.TsSeqAnimNotifyStateAudioEvent_C";

	// Token: 0x040010F4 RID: 4340
	private static IntPtr _ClassPtr;

	// Token: 0x040010F5 RID: 4341
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040010F6 RID: 4342
	private static int __PropertyOffset_AudioEvent;

	// Token: 0x040010F7 RID: 4343
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UAkAudioEvent> _AudioEvent;

	// Token: 0x040010F8 RID: 4344
	private static int __PropertyOffset_SocketName;

	// Token: 0x040010F9 RID: 4345
	private static int __PropertyOffset_Follow;

	// Token: 0x040010FA RID: 4346
	private static int __PropertyOffset_KeepAlive;

	// Token: 0x040010FB RID: 4347
	private static int __PropertyOffset_FadeDuration;

	// Token: 0x040010FC RID: 4348
	private static int __PropertyOffset_FadeCurve;

	// Token: 0x040010FD RID: 4349
	private static int __PropertyOffset_TrailingAudioEvent;

	// Token: 0x040010FE RID: 4350
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UAkAudioEvent> _TrailingAudioEvent;
}
