using System;
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

// Token: 0x02000192 RID: 402
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyAudioEvent.TsAnimNotifyAudioEvent_C")]
public class TsAnimNotifyAudioEvent : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700042A RID: 1066
	// (get) Token: 0x060019A4 RID: 6564 RVA: 0x000875D4 File Offset: 0x000857D4
	// (set) Token: 0x060019A5 RID: 6565 RVA: 0x0008760D File Offset: 0x0008580D
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<UAkAudioEvent> AudioEvent
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<UAkAudioEvent> result;
			if ((result = this._AudioEvent) == null)
			{
				result = (this._AudioEvent = new TSoftObjectPtr<UAkAudioEvent>(base.NativePtr + (IntPtr)TsAnimNotifyAudioEvent.__PropertyOffset_AudioEvent, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)TsAnimNotifyAudioEvent.__PropertyOffset_AudioEvent, 1);
		}
	}

	// Token: 0x1700042B RID: 1067
	// (get) Token: 0x060019A6 RID: 6566 RVA: 0x00087632 File Offset: 0x00085832
	// (set) Token: 0x060019A7 RID: 6567 RVA: 0x00087646 File Offset: 0x00085846
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName SocketName
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyAudioEvent.__PropertyOffset_SocketName);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyAudioEvent.__PropertyOffset_SocketName) = value;
		}
	}

	// Token: 0x1700042C RID: 1068
	// (get) Token: 0x060019A8 RID: 6568 RVA: 0x0008765B File Offset: 0x0008585B
	// (set) Token: 0x060019A9 RID: 6569 RVA: 0x0008766B File Offset: 0x0008586B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool Follow
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyAudioEvent.__PropertyOffset_Follow) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyAudioEvent.__PropertyOffset_Follow) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700042D RID: 1069
	// (get) Token: 0x060019AA RID: 6570 RVA: 0x0008767C File Offset: 0x0008587C
	// (set) Token: 0x060019AB RID: 6571 RVA: 0x000876B5 File Offset: 0x000858B5
	[UProperty(EPropertyFlags.CPF_None)]
	public SAudioEventProbabilityCooldownInfo TagProbabilityInfo
	{
		get
		{
			base.FastCheckIsValid();
			SAudioEventProbabilityCooldownInfo result;
			if ((result = this._TagProbabilityInfo) == null)
			{
				result = (this._TagProbabilityInfo = new SAudioEventProbabilityCooldownInfo(base.NativePtr + (IntPtr)TsAnimNotifyAudioEvent.__PropertyOffset_TagProbabilityInfo, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(SAudioEventProbabilityCooldownInfo.StaticStruct(), base.NativePtr + (IntPtr)TsAnimNotifyAudioEvent.__PropertyOffset_TagProbabilityInfo, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x060019AC RID: 6572 RVA: 0x000876E0 File Offset: 0x000858E0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotify.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotify.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L);
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

	// Token: 0x060019AD RID: 6573 RVA: 0x0008775B File Offset: 0x0008595B
	protected override string GetNotifyName_Implementation()
	{
		if (!(this.AudioEvent != null))
		{
			return "AudioEvent";
		}
		return "AudioEvent: " + AudioSystem.Instance.parseAudioEventPath(this.AudioEvent);
	}

	// Token: 0x060019AE RID: 6574 RVA: 0x0008778C File Offset: 0x0008598C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComponent, UAnimSequenceBase animSequence)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_Notify"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotify.__K2_Notify_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L);
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

	// Token: 0x060019AF RID: 6575 RVA: 0x0008782C File Offset: 0x00085A2C
	[NullableContext(2)]
	protected unsafe virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComponent, UAnimSequenceBase animSequence)
	{
		if (this.AudioEvent == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Audio;
			ELogAuthor author = ELogAuthor.MSY;
			string message = "[Game.AnimNotify] 无效的 AudioEvent";
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
			TsBaseCharacter tsBaseCharacter = outer as TsBaseCharacter;
			if (tsBaseCharacter != null)
			{
				CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
				text = (((characterActorComponent != null) ? characterActorComponent.GetReplaceEffect(text) : null) ?? text);
			}
		}
		else
		{
			text = EffectUtil.GetPreviewReplaceEffectPath(text);
		}
		string text2 = AudioSystem.Instance.parseAudioEventPath(text);
		if (text2 != null)
		{
			bool flag = true;
			TsBaseCharacter tsBaseCharacter2 = meshComponent.GetOwner() as TsBaseCharacter;
			if (tsBaseCharacter2 != null)
			{
				CharacterActorComponent characterActorComponent2 = tsBaseCharacter2.CharacterActorComponent;
				Entity entity = (characterActorComponent2 != null) ? characterActorComponent2.Entity : null;
				if (entity != null)
				{
					AudioCoolDownWithTagInfo param = new AudioCoolDownWithTagInfo
					{
						DefaultCooldownTime = this.TagProbabilityInfo.DefaultCooldownTime,
						DefaultProbability = (double)this.TagProbabilityInfo.DefaultProbability,
						TagProbability = this.TagProbabilityInfo.TagProbability
					};
					flag = GameAudioModel.Instance.CheckAudioProbabilityInfo(entity.Id, text2, param, true, true, true);
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

	// Token: 0x060019B0 RID: 6576 RVA: 0x00087998 File Offset: 0x00085B98
	private void PostAudioEvent(string eventName, USkeletalMeshComponent meshComponent, UAnimSequenceBase animSequence)
	{
		AActor owner = meshComponent.GetOwner();
		if (owner == null || !owner.IsValid())
		{
			return;
		}
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			Entity entityNoBlueprint = tsBaseCharacter.GetEntityNoBlueprint();
			BaseTagComponent baseTagComponent = (entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<BaseTagComponent>() : null;
			if (baseTagComponent != null && baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["系统.活动.声骸对战.bvb镜头"]))
			{
				return;
			}
		}
		if (GlobalData.GameInstance == null)
		{
			UAkComponent akComponent = AudioSystem.Instance.GetAkComponent(owner, new FName?(this.SocketName), null);
			if (akComponent == null || !akComponent.IsValid())
			{
				return;
			}
			AudioSystem.Instance.PostEvent(eventName, akComponent, null);
			return;
		}
		else
		{
			if (!this.Follow)
			{
				FTransformDouble value = meshComponent.D_GetSocketTransform(this.SocketName, ERelativeTransformSpace.RTS_World);
				AudioSystem.Instance.PostEvent(eventName, new FTransformDouble?(value), null);
				return;
			}
			UAkComponent akComponent2 = GameAudioController.Instance.GetAkComponent(owner, new FName?(this.SocketName));
			if (akComponent2 == null || !akComponent2.IsValid())
			{
				return;
			}
			GameAudioController.Instance.PostEvent(owner, eventName, new FName?(this.SocketName));
			return;
		}
	}

	// Token: 0x060019B1 RID: 6577 RVA: 0x00087AB9 File Offset: 0x00085CB9
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyAudioEvent._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyAudioEvent.TsAnimNotifyAudioEvent_C");
		}
		return TsAnimNotifyAudioEvent._ClassPtr;
	}

	// Token: 0x060019B2 RID: 6578 RVA: 0x00087AE0 File Offset: 0x00085CE0
	public TsAnimNotifyAudioEvent() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyAudioEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060019B3 RID: 6579 RVA: 0x00087B08 File Offset: 0x00085D08
	public TsAnimNotifyAudioEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyAudioEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060019B4 RID: 6580 RVA: 0x00087B3B File Offset: 0x00085D3B
	protected TsAnimNotifyAudioEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060019B5 RID: 6581 RVA: 0x00087B44 File Offset: 0x00085D44
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x060019B6 RID: 6582 RVA: 0x00087B58 File Offset: 0x00085D58
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040010D4 RID: 4308
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyAudioEvent.TsAnimNotifyAudioEvent_C";

	// Token: 0x040010D5 RID: 4309
	private static IntPtr _ClassPtr;

	// Token: 0x040010D6 RID: 4310
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040010D7 RID: 4311
	private static int __PropertyOffset_AudioEvent;

	// Token: 0x040010D8 RID: 4312
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UAkAudioEvent> _AudioEvent;

	// Token: 0x040010D9 RID: 4313
	private static int __PropertyOffset_SocketName;

	// Token: 0x040010DA RID: 4314
	private static int __PropertyOffset_Follow;

	// Token: 0x040010DB RID: 4315
	private static int __PropertyOffset_TagProbabilityInfo;

	// Token: 0x040010DC RID: 4316
	[Nullable(2)]
	private SAudioEventProbabilityCooldownInfo _TagProbabilityInfo;
}
