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

// Token: 0x02000196 RID: 406
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyAudioEvent.TsAnimNotifyAudioEvent_C")]
public class TsAnimNotifyAudioEvent : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700044C RID: 1100
	// (get) Token: 0x06001A41 RID: 6721 RVA: 0x0008D9C8 File Offset: 0x0008BBC8
	// (set) Token: 0x06001A42 RID: 6722 RVA: 0x0008DA01 File Offset: 0x0008BC01
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

	// Token: 0x1700044D RID: 1101
	// (get) Token: 0x06001A43 RID: 6723 RVA: 0x0008DA26 File Offset: 0x0008BC26
	// (set) Token: 0x06001A44 RID: 6724 RVA: 0x0008DA3A File Offset: 0x0008BC3A
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

	// Token: 0x1700044E RID: 1102
	// (get) Token: 0x06001A45 RID: 6725 RVA: 0x0008DA4F File Offset: 0x0008BC4F
	// (set) Token: 0x06001A46 RID: 6726 RVA: 0x0008DA5F File Offset: 0x0008BC5F
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

	// Token: 0x1700044F RID: 1103
	// (get) Token: 0x06001A47 RID: 6727 RVA: 0x0008DA70 File Offset: 0x0008BC70
	// (set) Token: 0x06001A48 RID: 6728 RVA: 0x0008DAA9 File Offset: 0x0008BCA9
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

	// Token: 0x06001A49 RID: 6729 RVA: 0x0008DAD4 File Offset: 0x0008BCD4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyAudioEvent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyAudioEvent.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotify.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotify.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x06001A4A RID: 6730 RVA: 0x0008DB64 File Offset: 0x0008BD64
	protected override string GetNotifyName_Implementation()
	{
		if (!(this.AudioEvent != null))
		{
			return "AudioEvent";
		}
		return "AudioEvent: " + AudioSystem.Instance.parseAudioEventPath(this.AudioEvent);
	}

	// Token: 0x06001A4B RID: 6731 RVA: 0x0008DB94 File Offset: 0x0008BD94
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComponent, UAnimSequenceBase animSequence)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyAudioEvent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyAudioEvent.StaticClass(), out intPtr, out num))
		{
			return this.K2_Notify_Implementation(meshComponent, animSequence);
		}
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr = stackalloc UKuroAnimNotify.__K2_Notify_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComponent != null) ? meshComponent.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animSequence != null) ? animSequence.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001A4C RID: 6732 RVA: 0x0008DC4C File Offset: 0x0008BE4C
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

	// Token: 0x06001A4D RID: 6733 RVA: 0x0008DDB8 File Offset: 0x0008BFB8
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

	// Token: 0x06001A4E RID: 6734 RVA: 0x0008DED9 File Offset: 0x0008C0D9
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyAudioEvent._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyAudioEvent.TsAnimNotifyAudioEvent_C");
		}
		return TsAnimNotifyAudioEvent._ClassPtr;
	}

	// Token: 0x06001A4F RID: 6735 RVA: 0x0008DF00 File Offset: 0x0008C100
	public TsAnimNotifyAudioEvent() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyAudioEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001A50 RID: 6736 RVA: 0x0008DF28 File Offset: 0x0008C128
	public TsAnimNotifyAudioEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyAudioEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001A51 RID: 6737 RVA: 0x0008DF5B File Offset: 0x0008C15B
	protected TsAnimNotifyAudioEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001A52 RID: 6738 RVA: 0x0008DF64 File Offset: 0x0008C164
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x06001A53 RID: 6739 RVA: 0x0008DF78 File Offset: 0x0008C178
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04001117 RID: 4375
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyAudioEvent.TsAnimNotifyAudioEvent_C";

	// Token: 0x04001118 RID: 4376
	private static IntPtr _ClassPtr;

	// Token: 0x04001119 RID: 4377
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400111A RID: 4378
	private static int __PropertyOffset_AudioEvent;

	// Token: 0x0400111B RID: 4379
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UAkAudioEvent> _AudioEvent;

	// Token: 0x0400111C RID: 4380
	private static int __PropertyOffset_SocketName;

	// Token: 0x0400111D RID: 4381
	private static int __PropertyOffset_Follow;

	// Token: 0x0400111E RID: 4382
	private static int __PropertyOffset_TagProbabilityInfo;

	// Token: 0x0400111F RID: 4383
	[Nullable(2)]
	private SAudioEventProbabilityCooldownInfo _TagProbabilityInfo;
}
