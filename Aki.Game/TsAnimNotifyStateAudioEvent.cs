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
	// Token: 0x17000294 RID: 660
	// (get) Token: 0x06001017 RID: 4119 RVA: 0x0005D694 File Offset: 0x0005B894
	// (set) Token: 0x06001018 RID: 4120 RVA: 0x0005D6CD File Offset: 0x0005B8CD
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

	// Token: 0x17000295 RID: 661
	// (get) Token: 0x06001019 RID: 4121 RVA: 0x0005D6F2 File Offset: 0x0005B8F2
	// (set) Token: 0x0600101A RID: 4122 RVA: 0x0005D706 File Offset: 0x0005B906
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

	// Token: 0x17000296 RID: 662
	// (get) Token: 0x0600101B RID: 4123 RVA: 0x0005D71B File Offset: 0x0005B91B
	// (set) Token: 0x0600101C RID: 4124 RVA: 0x0005D72B File Offset: 0x0005B92B
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

	// Token: 0x17000297 RID: 663
	// (get) Token: 0x0600101D RID: 4125 RVA: 0x0005D73C File Offset: 0x0005B93C
	// (set) Token: 0x0600101E RID: 4126 RVA: 0x0005D74C File Offset: 0x0005B94C
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

	// Token: 0x17000298 RID: 664
	// (get) Token: 0x0600101F RID: 4127 RVA: 0x0005D75D File Offset: 0x0005B95D
	// (set) Token: 0x06001020 RID: 4128 RVA: 0x0005D76D File Offset: 0x0005B96D
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

	// Token: 0x17000299 RID: 665
	// (get) Token: 0x06001021 RID: 4129 RVA: 0x0005D77E File Offset: 0x0005B97E
	// (set) Token: 0x06001022 RID: 4130 RVA: 0x0005D78E File Offset: 0x0005B98E
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

	// Token: 0x1700029A RID: 666
	// (get) Token: 0x06001023 RID: 4131 RVA: 0x0005D7A0 File Offset: 0x0005B9A0
	// (set) Token: 0x06001024 RID: 4132 RVA: 0x0005D7D9 File Offset: 0x0005B9D9
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

	// Token: 0x1700029B RID: 667
	// (get) Token: 0x06001025 RID: 4133 RVA: 0x0005D800 File Offset: 0x0005BA00
	// (set) Token: 0x06001026 RID: 4134 RVA: 0x0005D839 File Offset: 0x0005BA39
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

	// Token: 0x06001027 RID: 4135 RVA: 0x0005D864 File Offset: 0x0005BA64
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateAudioEvent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateAudioEvent.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001028 RID: 4136 RVA: 0x0005D8F4 File Offset: 0x0005BAF4
	protected override string GetNotifyName_Implementation()
	{
		if (!(this.AudioEvent != null))
		{
			return "AudioEvent";
		}
		return "AudioEvent: " + AudioSystem.Instance.parseAudioEventPath(this.AudioEvent);
	}

	// Token: 0x06001029 RID: 4137 RVA: 0x0005D924 File Offset: 0x0005BB24
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComponent, UAnimSequenceBase animSequence, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateAudioEvent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateAudioEvent.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600102A RID: 4138 RVA: 0x0005D9E4 File Offset: 0x0005BBE4
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

	// Token: 0x0600102B RID: 4139 RVA: 0x0005DB9C File Offset: 0x0005BD9C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComponent, UAnimSequenceBase animSequence)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateAudioEvent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateAudioEvent.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600102C RID: 4140 RVA: 0x0005DC54 File Offset: 0x0005BE54
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

	// Token: 0x0600102D RID: 4141 RVA: 0x0005DD9C File Offset: 0x0005BF9C
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

	// Token: 0x0600102E RID: 4142 RVA: 0x0005DEA8 File Offset: 0x0005C0A8
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

	// Token: 0x0600102F RID: 4143 RVA: 0x0005DF06 File Offset: 0x0005C106
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateAudioEvent._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAudioEvent.TsAnimNotifyStateAudioEvent_C");
		}
		return TsAnimNotifyStateAudioEvent._ClassPtr;
	}

	// Token: 0x06001030 RID: 4144 RVA: 0x0005DF2C File Offset: 0x0005C12C
	public TsAnimNotifyStateAudioEvent() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAudioEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001031 RID: 4145 RVA: 0x0005DF54 File Offset: 0x0005C154
	public TsAnimNotifyStateAudioEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAudioEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001032 RID: 4146 RVA: 0x0005DF87 File Offset: 0x0005C187
	protected TsAnimNotifyStateAudioEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001033 RID: 4147 RVA: 0x0005DF9B File Offset: 0x0005C19B
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x06001034 RID: 4148 RVA: 0x0005DFB0 File Offset: 0x0005C1B0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001035 RID: 4149 RVA: 0x0005DFEC File Offset: 0x0005C1EC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000C7C RID: 3196
	private const int DEFAULT_FADE_DURATION = 500;

	// Token: 0x04000C7D RID: 3197
	private float NotifyDuration;

	// Token: 0x04000C7E RID: 3198
	private readonly Dictionary<AActor, int> HandleMap = new Dictionary<AActor, int>();

	// Token: 0x04000C7F RID: 3199
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAudioEvent.TsAnimNotifyStateAudioEvent_C";

	// Token: 0x04000C80 RID: 3200
	private static IntPtr _ClassPtr;

	// Token: 0x04000C81 RID: 3201
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000C82 RID: 3202
	private static int __PropertyOffset_AudioEvent;

	// Token: 0x04000C83 RID: 3203
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UAkAudioEvent> _AudioEvent;

	// Token: 0x04000C84 RID: 3204
	private static int __PropertyOffset_SocketName;

	// Token: 0x04000C85 RID: 3205
	private static int __PropertyOffset_Follow;

	// Token: 0x04000C86 RID: 3206
	private static int __PropertyOffset_KeepAlive;

	// Token: 0x04000C87 RID: 3207
	private static int __PropertyOffset_FadeDuration;

	// Token: 0x04000C88 RID: 3208
	private static int __PropertyOffset_FadeCurve;

	// Token: 0x04000C89 RID: 3209
	private static int __PropertyOffset_TrailingAudioEvent;

	// Token: 0x04000C8A RID: 3210
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UAkAudioEvent> _TrailingAudioEvent;

	// Token: 0x04000C8B RID: 3211
	private static int __PropertyOffset_TagProbabilityInfo;

	// Token: 0x04000C8C RID: 3212
	[Nullable(2)]
	private SAudioEventProbabilityCooldownInfo _TagProbabilityInfo;
}
