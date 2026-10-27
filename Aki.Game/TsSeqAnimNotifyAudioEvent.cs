using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Plot.Sequence;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001E7 RID: 487
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsSeqAnimNotifyAudioEvent.TsSeqAnimNotifyAudioEvent_C")]
public class TsSeqAnimNotifyAudioEvent : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004E9 RID: 1257
	// (get) Token: 0x06001E62 RID: 7778 RVA: 0x0009795C File Offset: 0x00095B5C
	// (set) Token: 0x06001E63 RID: 7779 RVA: 0x00097995 File Offset: 0x00095B95
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<UAkAudioEvent> AudioEvent
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<UAkAudioEvent> result;
			if ((result = this._AudioEvent) == null)
			{
				result = (this._AudioEvent = new TSoftObjectPtr<UAkAudioEvent>(base.NativePtr + (IntPtr)TsSeqAnimNotifyAudioEvent.__PropertyOffset_AudioEvent, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)TsSeqAnimNotifyAudioEvent.__PropertyOffset_AudioEvent, 1);
		}
	}

	// Token: 0x170004EA RID: 1258
	// (get) Token: 0x06001E64 RID: 7780 RVA: 0x000979BA File Offset: 0x00095BBA
	// (set) Token: 0x06001E65 RID: 7781 RVA: 0x000979CE File Offset: 0x00095BCE
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName SocketName
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsSeqAnimNotifyAudioEvent.__PropertyOffset_SocketName);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsSeqAnimNotifyAudioEvent.__PropertyOffset_SocketName) = value;
		}
	}

	// Token: 0x170004EB RID: 1259
	// (get) Token: 0x06001E66 RID: 7782 RVA: 0x000979E3 File Offset: 0x00095BE3
	// (set) Token: 0x06001E67 RID: 7783 RVA: 0x000979F3 File Offset: 0x00095BF3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool Follow
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsSeqAnimNotifyAudioEvent.__PropertyOffset_Follow) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsSeqAnimNotifyAudioEvent.__PropertyOffset_Follow) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001E68 RID: 7784 RVA: 0x00097A04 File Offset: 0x00095C04
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

	// Token: 0x06001E69 RID: 7785 RVA: 0x00097A7F File Offset: 0x00095C7F
	protected override string GetNotifyName_Implementation()
	{
		if (!(this.AudioEvent != null))
		{
			return "AudioEvent";
		}
		return "AudioEvent: " + AudioSystem.Instance.parseAudioEventPath(this.AudioEvent);
	}

	// Token: 0x06001E6A RID: 7786 RVA: 0x00097AB0 File Offset: 0x00095CB0
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

	// Token: 0x06001E6B RID: 7787 RVA: 0x00097B50 File Offset: 0x00095D50
	[NullableContext(2)]
	protected unsafe virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComponent, UAnimSequenceBase animSequence)
	{
		if (meshComponent == null)
		{
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
		if (this.AudioEvent == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Audio;
			ELogAuthor author = ELogAuthor.JYS;
			string message = "[Game.AnimNotify] 无效的 AudioEvent";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("AnimNotify", this);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("AnimSequence", UKismetSystemLibrary.GetPathName(animSequence));
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		string text = AudioSystem.Instance.parseAudioEventPath(this.AudioEvent);
		if (text == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Audio;
			ELogAuthor author2 = ELogAuthor.JYS;
			string message2 = "[Game.AnimNotify] eventName为空";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("EventName", text);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("AnimNotify", this);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("AnimSequence", UKismetSystemLibrary.GetPathName(animSequence));
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			return false;
		}
		AActor owner = meshComponent.GetOwner();
		if (owner == null)
		{
			return false;
		}
		if (!SequenceUtils.CheckIfUseAudioSeq(owner))
		{
			return false;
		}
		if (this.Follow)
		{
			UAkComponent akComponent = AudioSystem.Instance.GetAkComponent(meshComponent, new FName?(this.SocketName), null);
			if (akComponent == null || !akComponent.IsValid())
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.Audio;
				ELogAuthor author3 = ELogAuthor.JYS;
				string message3 = "[Game.AnimNotify] 无效的 akComponent";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("EventName", text);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("AnimNotify", this);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("AnimSequence", UKismetSystemLibrary.GetPathName(animSequence));
				instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
				return false;
			}
			AudioSystem.Instance.PostEvent(text.ToString(), akComponent, null);
		}
		else
		{
			FTransformDouble value = meshComponent.D_GetSocketTransform(this.SocketName, ERelativeTransformSpace.RTS_World);
			AudioSystem.Instance.PostEvent(text.ToString(), new FTransformDouble?(value), null);
		}
		return true;
	}

	// Token: 0x06001E6C RID: 7788 RVA: 0x00097DE2 File Offset: 0x00095FE2
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsSeqAnimNotifyAudioEvent._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsSeqAnimNotifyAudioEvent.TsSeqAnimNotifyAudioEvent_C");
		}
		return TsSeqAnimNotifyAudioEvent._ClassPtr;
	}

	// Token: 0x06001E6D RID: 7789 RVA: 0x00097E08 File Offset: 0x00096008
	public TsSeqAnimNotifyAudioEvent() : this(BuiltinUtils.AllocNativeUObject(TsSeqAnimNotifyAudioEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001E6E RID: 7790 RVA: 0x00097E30 File Offset: 0x00096030
	public TsSeqAnimNotifyAudioEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSeqAnimNotifyAudioEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001E6F RID: 7791 RVA: 0x00097E63 File Offset: 0x00096063
	protected TsSeqAnimNotifyAudioEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001E70 RID: 7792 RVA: 0x00097E6C File Offset: 0x0009606C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x06001E71 RID: 7793 RVA: 0x00097E80 File Offset: 0x00096080
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040012BA RID: 4794
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsSeqAnimNotifyAudioEvent.TsSeqAnimNotifyAudioEvent_C";

	// Token: 0x040012BB RID: 4795
	private static IntPtr _ClassPtr;

	// Token: 0x040012BC RID: 4796
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040012BD RID: 4797
	private static int __PropertyOffset_AudioEvent;

	// Token: 0x040012BE RID: 4798
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UAkAudioEvent> _AudioEvent;

	// Token: 0x040012BF RID: 4799
	private static int __PropertyOffset_SocketName;

	// Token: 0x040012C0 RID: 4800
	private static int __PropertyOffset_Follow;
}
