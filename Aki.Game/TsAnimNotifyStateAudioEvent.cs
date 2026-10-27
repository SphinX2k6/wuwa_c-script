using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Audio;
using CSharpScript.Game.Utils;
using UnrealEngine;
using UnrealEngine.Extension;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000111 RID: 273
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAudioEvent.TsAnimNotifyStateAudioEvent_C")]
public class TsAnimNotifyStateAudioEvent : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000291 RID: 657
	// (get) Token: 0x06001011 RID: 4113 RVA: 0x0005C4A8 File Offset: 0x0005A6A8
	// (set) Token: 0x06001012 RID: 4114 RVA: 0x0005C4E1 File Offset: 0x0005A6E1
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<UAkAudioEvent> AudioEvent
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<UAkAudioEvent> result;
			if ((result = this._AudioEvent) == null)
			{
				result = (this._AudioEvent = new TSoftObjectPtr<UAkAudioEvent>(base.NativePtr + (IntPtr)TsAnimNotifyStateAudioEvent.__PropertyOffset_AudioEvent, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)TsAnimNotifyStateAudioEvent.__PropertyOffset_AudioEvent, 1);
		}
	}

	// Token: 0x17000292 RID: 658
	// (get) Token: 0x06001013 RID: 4115 RVA: 0x0005C506 File Offset: 0x0005A706
	// (set) Token: 0x06001014 RID: 4116 RVA: 0x0005C51A File Offset: 0x0005A71A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName SocketName
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateAudioEvent.__PropertyOffset_SocketName);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAudioEvent.__PropertyOffset_SocketName) = value;
		}
	}

	// Token: 0x17000293 RID: 659
	// (get) Token: 0x06001015 RID: 4117 RVA: 0x0005C52F File Offset: 0x0005A72F
	// (set) Token: 0x06001016 RID: 4118 RVA: 0x0005C53F File Offset: 0x0005A73F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool Follow
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateAudioEvent.__PropertyOffset_Follow) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAudioEvent.__PropertyOffset_Follow) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000294 RID: 660
	// (get) Token: 0x06001017 RID: 4119 RVA: 0x0005C550 File Offset: 0x0005A750
	// (set) Token: 0x06001018 RID: 4120 RVA: 0x0005C560 File Offset: 0x0005A760
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool KeepAlive
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateAudioEvent.__PropertyOffset_KeepAlive) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAudioEvent.__PropertyOffset_KeepAlive) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000295 RID: 661
	// (get) Token: 0x06001019 RID: 4121 RVA: 0x0005C571 File Offset: 0x0005A771
	// (set) Token: 0x0600101A RID: 4122 RVA: 0x0005C581 File Offset: 0x0005A781
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int FadeDuration
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateAudioEvent.__PropertyOffset_FadeDuration);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAudioEvent.__PropertyOffset_FadeDuration) = value;
		}
	}

	// Token: 0x17000296 RID: 662
	// (get) Token: 0x0600101B RID: 4123 RVA: 0x0005C592 File Offset: 0x0005A792
	// (set) Token: 0x0600101C RID: 4124 RVA: 0x0005C5A2 File Offset: 0x0005A7A2
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EAudioFadeCurve FadeCurve
	{
		get
		{
			return (EAudioFadeCurve)(*(base.NativePtr + (IntPtr)TsAnimNotifyStateAudioEvent.__PropertyOffset_FadeCurve));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAudioEvent.__PropertyOffset_FadeCurve) = (byte)value;
		}
	}

	// Token: 0x17000297 RID: 663
	// (get) Token: 0x0600101D RID: 4125 RVA: 0x0005C5B4 File Offset: 0x0005A7B4
	// (set) Token: 0x0600101E RID: 4126 RVA: 0x0005C5ED File Offset: 0x0005A7ED
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<UAkAudioEvent> TrailingAudioEvent
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<UAkAudioEvent> result;
			if ((result = this._TrailingAudioEvent) == null)
			{
				result = (this._TrailingAudioEvent = new TSoftObjectPtr<UAkAudioEvent>(base.NativePtr + (IntPtr)TsAnimNotifyStateAudioEvent.__PropertyOffset_TrailingAudioEvent, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)TsAnimNotifyStateAudioEvent.__PropertyOffset_TrailingAudioEvent, 1);
		}
	}

	// Token: 0x17000298 RID: 664
	// (get) Token: 0x0600101F RID: 4127 RVA: 0x0005C614 File Offset: 0x0005A814
	// (set) Token: 0x06001020 RID: 4128 RVA: 0x0005C64D File Offset: 0x0005A84D
	[UProperty(EPropertyFlags.CPF_None)]
	public SAudioEventProbabilityCooldownInfo TagProbabilityInfo
	{
		get
		{
			base.FastCheckIsValid();
			SAudioEventProbabilityCooldownInfo result;
			if ((result = this._TagProbabilityInfo) == null)
			{
				result = (this._TagProbabilityInfo = new SAudioEventProbabilityCooldownInfo(base.NativePtr + (IntPtr)TsAnimNotifyStateAudioEvent.__PropertyOffset_TagProbabilityInfo, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(SAudioEventProbabilityCooldownInfo.StaticStruct(), base.NativePtr + (IntPtr)TsAnimNotifyStateAudioEvent.__PropertyOffset_TagProbabilityInfo, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x06001021 RID: 4129 RVA: 0x0005C678 File Offset: 0x0005A878
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

	// Token: 0x06001022 RID: 4130 RVA: 0x0005C6F3 File Offset: 0x0005A8F3
	protected override string GetNotifyName_Implementation()
	{
		if (!(this.AudioEvent != null))
		{
			return "AudioEvent";
		}
		return "AudioEvent: " + AudioSystem.Instance.parseAudioEventPath(this.AudioEvent);
	}

	// Token: 0x06001023 RID: 4131 RVA: 0x0005C724 File Offset: 0x0005A924
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

	// Token: 0x06001024 RID: 4132 RVA: 0x0005C7CC File Offset: 0x0005A9CC
	[NullableContext(2)]
	protected unsafe virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComponent, UAnimSequenceBase animSequence, float totalDuration)
	{
		this.NotifyDuration = totalDuration;
		if (this.AudioEvent == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Audio;
			ELogAuthor author = ELogAuthor.MSY;
			string message = "[Game.AnimNotifyState] 无效的 AudioEvent";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("AnimNotify", this);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("AnimSequence", UKismetSystemLibrary.GetPathName(animSequence));
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		string text = this.AudioEvent.ToAssetPathName();
		UObject outer = meshComponent.GetOuter();
		if (Info.Instance.IsGameRunning())
		{
			if (outer is TsBaseCharacter)
			{
				Entity entityNoBlueprint = (outer as TsBaseCharacter).GetEntityNoBlueprint();
				BaseTagComponent baseTagComponent = (entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<BaseTagComponent>() : null;
				if (baseTagComponent != null && baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["系统.活动.声骸对战.bvb镜头"]))
				{
					return false;
				}
				CharacterActorComponent characterActorComponent = (outer as TsBaseCharacter).CharacterActorComponent;
				text = (((characterActorComponent != null) ? characterActorComponent.GetReplaceEffect(text) : null) ?? text);
			}
		}
		else
		{
			text = EffectUtil.GetPreviewReplaceEffectPath(text);
		}
		string text2 = (this.AudioEvent != null) ? AudioSystem.Instance.parseAudioEventPath(text) : null;
		if (text2 != null)
		{
			bool flag = true;
			TsBaseCharacter tsBaseCharacter = meshComponent.GetOwner() as TsBaseCharacter;
			if (tsBaseCharacter != null)
			{
				CharacterActorComponent characterActorComponent2 = tsBaseCharacter.CharacterActorComponent;
				Entity entity = (characterActorComponent2 != null) ? characterActorComponent2.Entity : null;
				if (entity != null)
				{
					flag = GameAudioModel.Instance.CheckAudioProbabilityInfo(entity.Id, text2, new AudioCoolDownWithTagInfo
					{
						DefaultProbability = (double)this.TagProbabilityInfo.DefaultProbability,
						DefaultCooldownTime = this.TagProbabilityInfo.DefaultCooldownTime,
						TagProbability = this.TagProbabilityInfo.TagProbability
					}, true, true, true);
				}
			}
			if (!flag)
			{
				return true;
			}
			this.PostAudioEvent(text2, meshComponent, animSequence);
		}
		return true;
	}

	// Token: 0x06001025 RID: 4133 RVA: 0x0005C984 File Offset: 0x0005AB84
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

	// Token: 0x06001026 RID: 4134 RVA: 0x0005CA24 File Offset: 0x0005AC24
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComponent, UAnimSequenceBase animSequence)
	{
		if (this.KeepAlive && base.CurrentTimeLength > this.NotifyDuration)
		{
			return false;
		}
		if (meshComponent == null)
		{
			return false;
		}
		AActor owner = meshComponent.GetOwner();
		if (owner == null || !owner.IsValid())
		{
			return false;
		}
		if (GlobalData.GameInstance == null)
		{
			int num;
			if (this.HandleMap.TryGetValue(owner, out num) && num != 0)
			{
				AudioSystem.Instance.ExecuteAction(num, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs
				{
					TransitionDuration = new int?(this.FadeDuration),
					TransitionFadeCurve = new EAudioFadeCurve?(this.FadeCurve)
				}));
				this.HandleMap.Remove(owner);
			}
			return true;
		}
		int num2;
		if (!this.HandleMap.TryGetValue(owner, out num2) || num2 == 0)
		{
			return true;
		}
		AudioSystem.Instance.ExecuteAction(num2, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs
		{
			TransitionDuration = new int?(this.FadeDuration),
			TransitionFadeCurve = new EAudioFadeCurve?(this.FadeCurve)
		}));
		this.HandleMap.Remove(owner);
		GameAudioController.Instance.RemoveEvent(owner, num2);
		string text = (this.TrailingAudioEvent != null) ? AudioSystem.Instance.parseAudioEventPath(this.TrailingAudioEvent) : null;
		if (text != null)
		{
			this.PostAudioEvent(text, meshComponent, animSequence);
		}
		return true;
	}

	// Token: 0x06001027 RID: 4135 RVA: 0x0005CB6C File Offset: 0x0005AD6C
	private void PostAudioEvent(string eventName, USkeletalMeshComponent meshComponent, UAnimSequenceBase animSequence)
	{
		AActor owner = meshComponent.GetOwner();
		if (owner == null || !owner.IsValid())
		{
			return;
		}
		if (GlobalData.GameInstance == null)
		{
			UAkComponent akComponent = AudioSystem.Instance.GetAkComponent(owner, new FName?(this.SocketName), null);
			if (akComponent == null || !akComponent.IsValid())
			{
				return;
			}
			int num = AudioSystem.Instance.PostEvent(eventName, akComponent, null);
			if (num != 0)
			{
				this.StopExistingHandle(owner);
				this.HandleMap[owner] = num;
			}
			return;
		}
		else if (this.Follow)
		{
			int num2 = GameAudioController.Instance.PostEvent(owner, eventName, new FName?(this.SocketName));
			if (num2 == 0)
			{
				return;
			}
			this.StopExistingHandle(owner);
			this.HandleMap[owner] = num2;
			return;
		}
		else
		{
			FTransformDouble value = meshComponent.D_GetSocketTransform(this.SocketName, ERelativeTransformSpace.RTS_World);
			int num3 = AudioSystem.Instance.PostEvent(eventName, new FTransformDouble?(value), null);
			if (num3 == 0)
			{
				return;
			}
			this.StopExistingHandle(owner);
			this.HandleMap[owner] = num3;
			return;
		}
	}

	// Token: 0x06001028 RID: 4136 RVA: 0x0005CC78 File Offset: 0x0005AE78
	private void StopExistingHandle(AActor owner)
	{
		int num;
		if (this.HandleMap.TryGetValue(owner, out num) && num != 0)
		{
			AudioSystem.Instance.ExecuteAction(num, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs
			{
				TransitionDuration = new int?(this.FadeDuration),
				TransitionFadeCurve = new EAudioFadeCurve?(this.FadeCurve)
			}));
		}
	}

	// Token: 0x06001029 RID: 4137 RVA: 0x0005CCD6 File Offset: 0x0005AED6
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateAudioEvent._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAudioEvent.TsAnimNotifyStateAudioEvent_C");
		}
		return TsAnimNotifyStateAudioEvent._ClassPtr;
	}

	// Token: 0x0600102A RID: 4138 RVA: 0x0005CCFC File Offset: 0x0005AEFC
	public TsAnimNotifyStateAudioEvent() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAudioEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600102B RID: 4139 RVA: 0x0005CD24 File Offset: 0x0005AF24
	public TsAnimNotifyStateAudioEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAudioEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600102C RID: 4140 RVA: 0x0005CD57 File Offset: 0x0005AF57
	protected TsAnimNotifyStateAudioEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600102D RID: 4141 RVA: 0x0005CD6B File Offset: 0x0005AF6B
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0600102E RID: 4142 RVA: 0x0005CD80 File Offset: 0x0005AF80
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600102F RID: 4143 RVA: 0x0005CDBC File Offset: 0x0005AFBC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000C74 RID: 3188
	private const int DEFAULT_FADE_DURATION = 500;

	// Token: 0x04000C75 RID: 3189
	private float NotifyDuration;

	// Token: 0x04000C76 RID: 3190
	private readonly Dictionary<AActor, int> HandleMap = new Dictionary<AActor, int>();

	// Token: 0x04000C77 RID: 3191
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAudioEvent.TsAnimNotifyStateAudioEvent_C";

	// Token: 0x04000C78 RID: 3192
	private static IntPtr _ClassPtr;

	// Token: 0x04000C79 RID: 3193
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000C7A RID: 3194
	private static int __PropertyOffset_AudioEvent;

	// Token: 0x04000C7B RID: 3195
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UAkAudioEvent> _AudioEvent;

	// Token: 0x04000C7C RID: 3196
	private static int __PropertyOffset_SocketName;

	// Token: 0x04000C7D RID: 3197
	private static int __PropertyOffset_Follow;

	// Token: 0x04000C7E RID: 3198
	private static int __PropertyOffset_KeepAlive;

	// Token: 0x04000C7F RID: 3199
	private static int __PropertyOffset_FadeDuration;

	// Token: 0x04000C80 RID: 3200
	private static int __PropertyOffset_FadeCurve;

	// Token: 0x04000C81 RID: 3201
	private static int __PropertyOffset_TrailingAudioEvent;

	// Token: 0x04000C82 RID: 3202
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UAkAudioEvent> _TrailingAudioEvent;

	// Token: 0x04000C83 RID: 3203
	private static int __PropertyOffset_TagProbabilityInfo;

	// Token: 0x04000C84 RID: 3204
	[Nullable(2)]
	private SAudioEventProbabilityCooldownInfo _TagProbabilityInfo;
}
