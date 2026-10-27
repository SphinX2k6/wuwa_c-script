using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002972 RID: 10610
[UClass("/Game/Aki/TypeScript/Game/Module/Sequence/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/Sequence/PlotActorBlueprintFunctionLibrary.PlotActorBlueprintFunctionLibrary_C")]
public class PlotActorBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x06015EBF RID: 89791 RVA: 0x00587BE3 File Offset: 0x00585DE3
	static PlotActorBlueprintFunctionLibrary()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PlotActorBlueprintFunctionLibrary.CreateStaticDefaultValue), new Action(PlotActorBlueprintFunctionLibrary.ResetStaticDefaultValue));
	}

	// Token: 0x06015EC0 RID: 89792 RVA: 0x00587C02 File Offset: 0x00585E02
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetI18nBillboardComponentSpriteById(UBillboardComponent sprite, string id)
	{
		I18nUtils.SetI18nBillboardComponentSpriteById(sprite, id);
	}

	// Token: 0x06015EC1 RID: 89793 RVA: 0x00587C0B File Offset: 0x00585E0B
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void PlayFromStartForActor(ALevelSequenceActor actor)
	{
		if (actor == null || !actor.IsValid())
		{
			return;
		}
		if (actor.SequencePlayer != null)
		{
			actor.SequencePlayer.Play();
		}
	}

	// Token: 0x06015EC2 RID: 89794 RVA: 0x00587C2C File Offset: 0x00585E2C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void StopForActor(ALevelSequenceActor actor)
	{
		if (actor == null || !actor.IsValid())
		{
			return;
		}
		ULevelSequencePlayer sequencePlayer = actor.SequencePlayer;
		if (sequencePlayer == null)
		{
			return;
		}
		sequencePlayer.Stop();
	}

	// Token: 0x06015EC3 RID: 89795 RVA: 0x00587C4A File Offset: 0x00585E4A
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void UiTextureAttachToActor(AActor target, string textureKey)
	{
		PlotActorBlueprintFunctionLibrary.UiAttachToActorImpAsync(target, textureKey).Forget();
	}

	// Token: 0x06015EC4 RID: 89796 RVA: 0x00587C58 File Offset: 0x00585E58
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void TextNiagaraSetTextureAndLength(AActor target, string textureKey)
	{
		PlotActorBlueprintFunctionLibrary.TextSetTextureAndLengthToNiagara(target, textureKey);
	}

	// Token: 0x06015EC5 RID: 89797 RVA: 0x00587C61 File Offset: 0x00585E61
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static string GetMediaNameByKey(string key)
	{
		return I18nUtils.GetI18nPlotAudioMediaName(key) ?? "";
	}

	// Token: 0x06015EC6 RID: 89798 RVA: 0x00587C74 File Offset: 0x00585E74
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void PostAudioEventAtActor([Nullable(1)] string eventName, string externalName, string mediaName, AActor target)
	{
		if (string.IsNullOrEmpty(eventName))
		{
			return;
		}
		int item;
		if (string.IsNullOrEmpty(externalName) || string.IsNullOrEmpty(mediaName))
		{
			item = AudioSystem.Instance.PostEvent(eventName, target, null);
		}
		else
		{
			item = AudioSystem.Instance.PostEvent(eventName, target, new PostEventArgs?(new PostEventArgs
			{
				ExternalSourceName = externalName,
				ExternalSourceMediaName = mediaName
			}));
		}
		PlotActorBlueprintFunctionLibrary.AudioHandleCache.Add(item);
	}

	// Token: 0x06015EC7 RID: 89799 RVA: 0x00587CEC File Offset: 0x00585EEC
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void StopAllAudioByPostAudioEventAtActor()
	{
		foreach (int handle in PlotActorBlueprintFunctionLibrary.AudioHandleCache)
		{
			AudioSystem.Instance.ExecuteAction(handle, EAudioActionType.Stop, null);
		}
		PlotActorBlueprintFunctionLibrary.AudioHandleCache.Clear();
	}

	// Token: 0x06015EC8 RID: 89800 RVA: 0x00587D58 File Offset: 0x00585F58
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static string AddSuffixByGender(string baseContent, [Nullable(2)] string addedMaleString, [Nullable(2)] string addedFemaleString)
	{
		return baseContent + ((PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male) ? (addedMaleString ?? "") : (addedFemaleString ?? ""));
	}

	// Token: 0x06015EC9 RID: 89801 RVA: 0x00587D83 File Offset: 0x00585F83
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static string AddPrefixByGender(string baseContent, [Nullable(2)] string addedMaleString, [Nullable(2)] string addedFemaleString)
	{
		return ((PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male) ? (addedMaleString ?? "") : (addedFemaleString ?? "")) + baseContent;
	}

	// Token: 0x06015ECA RID: 89802 RVA: 0x00587DB0 File Offset: 0x00585FB0
	[NullableContext(1)]
	private static UniTask UiAttachToActorImpAsync(AActor target, string key)
	{
		PlotActorBlueprintFunctionLibrary.<UiAttachToActorImpAsync>d__12 <UiAttachToActorImpAsync>d__;
		<UiAttachToActorImpAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UiAttachToActorImpAsync>d__.target = target;
		<UiAttachToActorImpAsync>d__.key = key;
		<UiAttachToActorImpAsync>d__.<>1__state = -1;
		<UiAttachToActorImpAsync>d__.<>t__builder.Start<PlotActorBlueprintFunctionLibrary.<UiAttachToActorImpAsync>d__12>(ref <UiAttachToActorImpAsync>d__);
		return <UiAttachToActorImpAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015ECB RID: 89803 RVA: 0x00587DFC File Offset: 0x00585FFC
	[NullableContext(1)]
	private static void TextSetTextureAndLengthToNiagara(AActor target, string key)
	{
		if (target != null)
		{
			UNiagaraComponent niagaraComp = target.GetComponentByClass(UNiagaraComponent.StaticClass()) as UNiagaraComponent;
			if (niagaraComp != null)
			{
				string i18nPathAtCurrentLanguage = I18nUtils.GetI18nPathAtCurrentLanguage(key);
				if (i18nPathAtCurrentLanguage != null)
				{
					ResourceSystem.Instance.LoadAsync<UTexture2D>(i18nPathAtCurrentLanguage, delegate([Nullable(2)] UTexture2D texture, string _)
					{
						if (texture == null)
						{
							Log.Instance.Error(ELogModule.Battle, ELogAuthor.LLX, "[LLX]加载贴图失败", default(ReadOnlySpan<ValueTuple<string, object>>));
							return;
						}
						niagaraComp.SetKuroNiagaraEmitterCustomTexture("TextTex", "Mask", texture);
						niagaraComp.SetNiagaraVariableFloat("TexSize", (float)(texture.Blueprint_GetSizeX() / texture.Blueprint_GetSizeY()));
					}, ResourceSystem.EResourceLoadPriority.Ui, "js_undefined");
				}
			}
		}
	}

	// Token: 0x06015ECC RID: 89804 RVA: 0x00587E5E File Offset: 0x0058605E
	public static void CreateStaticDefaultValue()
	{
		PlotActorBlueprintFunctionLibrary.AudioHandleCache = new List<int>();
	}

	// Token: 0x06015ECD RID: 89805 RVA: 0x00587E6A File Offset: 0x0058606A
	public static void ResetStaticDefaultValue()
	{
		PlotActorBlueprintFunctionLibrary.AudioHandleCache = null;
	}

	// Token: 0x06015ECE RID: 89806 RVA: 0x00587E72 File Offset: 0x00586072
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (PlotActorBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/Sequence/PlotActorBlueprintFunctionLibrary.PlotActorBlueprintFunctionLibrary_C");
		}
		return PlotActorBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x06015ECF RID: 89807 RVA: 0x00587E98 File Offset: 0x00586098
	public PlotActorBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(PlotActorBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06015ED0 RID: 89808 RVA: 0x00587EC0 File Offset: 0x005860C0
	[NullableContext(1)]
	public PlotActorBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PlotActorBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06015ED1 RID: 89809 RVA: 0x00587EF3 File Offset: 0x005860F3
	protected PlotActorBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06015ED2 RID: 89810 RVA: 0x00587EFC File Offset: 0x005860FC
	protected unsafe static void __CPPCALL_SetI18nBillboardComponentSpriteById_Implementation(PlotActorBlueprintFunctionLibrary.__SetI18nBillboardComponentSpriteById_FunctionParams* __Params)
	{
		UBillboardComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UBillboardComponent>(__Params->sprite);
		string id = FString.ToString((void*)(&__Params->id));
		PlotActorBlueprintFunctionLibrary.SetI18nBillboardComponentSpriteById(orCreateUObjectByNativePointer, id);
	}

	// Token: 0x06015ED3 RID: 89811 RVA: 0x00587F27 File Offset: 0x00586127
	protected unsafe static void __CPPCALL_PlayFromStartForActor_Implementation(PlotActorBlueprintFunctionLibrary.__PlayFromStartForActor_FunctionParams* __Params)
	{
		PlotActorBlueprintFunctionLibrary.PlayFromStartForActor(BuiltinUtils.GetOrCreateUObjectByNativePointer<ALevelSequenceActor>(__Params->actor));
	}

	// Token: 0x06015ED4 RID: 89812 RVA: 0x00587F39 File Offset: 0x00586139
	protected unsafe static void __CPPCALL_StopForActor_Implementation(PlotActorBlueprintFunctionLibrary.__StopForActor_FunctionParams* __Params)
	{
		PlotActorBlueprintFunctionLibrary.StopForActor(BuiltinUtils.GetOrCreateUObjectByNativePointer<ALevelSequenceActor>(__Params->actor));
	}

	// Token: 0x06015ED5 RID: 89813 RVA: 0x00587F4C File Offset: 0x0058614C
	protected unsafe static void __CPPCALL_UiTextureAttachToActor_Implementation(PlotActorBlueprintFunctionLibrary.__UiTextureAttachToActor_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->target);
		string textureKey = FString.ToString((void*)(&__Params->textureKey));
		PlotActorBlueprintFunctionLibrary.UiTextureAttachToActor(orCreateUObjectByNativePointer, textureKey);
	}

	// Token: 0x06015ED6 RID: 89814 RVA: 0x00587F78 File Offset: 0x00586178
	protected unsafe static void __CPPCALL_TextNiagaraSetTextureAndLength_Implementation(PlotActorBlueprintFunctionLibrary.__TextNiagaraSetTextureAndLength_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->target);
		string textureKey = FString.ToString((void*)(&__Params->textureKey));
		PlotActorBlueprintFunctionLibrary.TextNiagaraSetTextureAndLength(orCreateUObjectByNativePointer, textureKey);
	}

	// Token: 0x06015ED7 RID: 89815 RVA: 0x00587FA4 File Offset: 0x005861A4
	protected unsafe static void __CPPCALL_GetMediaNameByKey_Implementation(PlotActorBlueprintFunctionLibrary.__GetMediaNameByKey_FunctionParams* __Params)
	{
		string key = FString.ToString((void*)(&__Params->key));
		FString.CopyFrom((void*)(&__Params->__Result), PlotActorBlueprintFunctionLibrary.GetMediaNameByKey(key));
	}

	// Token: 0x06015ED8 RID: 89816 RVA: 0x00587FD0 File Offset: 0x005861D0
	protected unsafe static void __CPPCALL_PostAudioEventAtActor_Implementation(PlotActorBlueprintFunctionLibrary.__PostAudioEventAtActor_FunctionParams* __Params)
	{
		string eventName = FString.ToString((void*)(&__Params->eventName));
		string externalName = FString.ToString((void*)(&__Params->externalName));
		string mediaName = FString.ToString((void*)(&__Params->mediaName));
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->target);
		PlotActorBlueprintFunctionLibrary.PostAudioEventAtActor(eventName, externalName, mediaName, orCreateUObjectByNativePointer);
	}

	// Token: 0x06015ED9 RID: 89817 RVA: 0x00588017 File Offset: 0x00586217
	protected unsafe static void __CPPCALL_StopAllAudioByPostAudioEventAtActor_Implementation(PlotActorBlueprintFunctionLibrary.__StopAllAudioByPostAudioEventAtActor_FunctionParams* __Params)
	{
		PlotActorBlueprintFunctionLibrary.StopAllAudioByPostAudioEventAtActor();
	}

	// Token: 0x06015EDA RID: 89818 RVA: 0x00588020 File Offset: 0x00586220
	protected unsafe static void __CPPCALL_AddSuffixByGender_Implementation(PlotActorBlueprintFunctionLibrary.__AddSuffixByGender_FunctionParams* __Params)
	{
		string baseContent = FString.ToString((void*)(&__Params->baseContent));
		string addedMaleString = FString.ToString((void*)(&__Params->addedMaleString));
		string addedFemaleString = FString.ToString((void*)(&__Params->addedFemaleString));
		FString.CopyFrom((void*)(&__Params->__Result), PlotActorBlueprintFunctionLibrary.AddSuffixByGender(baseContent, addedMaleString, addedFemaleString));
	}

	// Token: 0x06015EDB RID: 89819 RVA: 0x00588068 File Offset: 0x00586268
	protected unsafe static void __CPPCALL_AddPrefixByGender_Implementation(PlotActorBlueprintFunctionLibrary.__AddPrefixByGender_FunctionParams* __Params)
	{
		string baseContent = FString.ToString((void*)(&__Params->baseContent));
		string addedMaleString = FString.ToString((void*)(&__Params->addedMaleString));
		string addedFemaleString = FString.ToString((void*)(&__Params->addedFemaleString));
		FString.CopyFrom((void*)(&__Params->__Result), PlotActorBlueprintFunctionLibrary.AddPrefixByGender(baseContent, addedMaleString, addedFemaleString));
	}

	// Token: 0x0400A327 RID: 41767
	[Nullable(2)]
	private static List<int> AudioHandleCache;

	// Token: 0x0400A328 RID: 41768
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/Sequence/PlotActorBlueprintFunctionLibrary.PlotActorBlueprintFunctionLibrary_C";

	// Token: 0x0400A329 RID: 41769
	private static IntPtr _ClassPtr;

	// Token: 0x0400A32A RID: 41770
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x02008F36 RID: 36662
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __SetI18nBillboardComponentSpriteById_FunctionParams
	{
		// Token: 0x0402E6B8 RID: 190136
		[FieldOffset(0)]
		public IntPtr sprite;

		// Token: 0x0402E6B9 RID: 190137
		[FieldOffset(8)]
		public FString id;

		// Token: 0x0402E6BA RID: 190138
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F37 RID: 36663
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __PlayFromStartForActor_FunctionParams
	{
		// Token: 0x0402E6BB RID: 190139
		[FieldOffset(0)]
		public IntPtr actor;

		// Token: 0x0402E6BC RID: 190140
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F38 RID: 36664
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __StopForActor_FunctionParams
	{
		// Token: 0x0402E6BD RID: 190141
		[FieldOffset(0)]
		public IntPtr actor;

		// Token: 0x0402E6BE RID: 190142
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F39 RID: 36665
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __UiTextureAttachToActor_FunctionParams
	{
		// Token: 0x0402E6BF RID: 190143
		[FieldOffset(0)]
		public IntPtr target;

		// Token: 0x0402E6C0 RID: 190144
		[FieldOffset(8)]
		public FString textureKey;

		// Token: 0x0402E6C1 RID: 190145
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F3A RID: 36666
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __TextNiagaraSetTextureAndLength_FunctionParams
	{
		// Token: 0x0402E6C2 RID: 190146
		[FieldOffset(0)]
		public IntPtr target;

		// Token: 0x0402E6C3 RID: 190147
		[FieldOffset(8)]
		public FString textureKey;

		// Token: 0x0402E6C4 RID: 190148
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F3B RID: 36667
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __GetMediaNameByKey_FunctionParams
	{
		// Token: 0x0402E6C5 RID: 190149
		[FieldOffset(0)]
		public FString key;

		// Token: 0x0402E6C6 RID: 190150
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x0402E6C7 RID: 190151
		[FieldOffset(24)]
		public FString __Result;
	}

	// Token: 0x02008F3C RID: 36668
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __PostAudioEventAtActor_FunctionParams
	{
		// Token: 0x0402E6C8 RID: 190152
		[FieldOffset(0)]
		public FString eventName;

		// Token: 0x0402E6C9 RID: 190153
		[FieldOffset(16)]
		public FString externalName;

		// Token: 0x0402E6CA RID: 190154
		[FieldOffset(32)]
		public FString mediaName;

		// Token: 0x0402E6CB RID: 190155
		[FieldOffset(48)]
		public IntPtr target;

		// Token: 0x0402E6CC RID: 190156
		[FieldOffset(56)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F3D RID: 36669
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __StopAllAudioByPostAudioEventAtActor_FunctionParams
	{
		// Token: 0x0402E6CD RID: 190157
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F3E RID: 36670
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 72)]
	protected ref struct __AddSuffixByGender_FunctionParams
	{
		// Token: 0x0402E6CE RID: 190158
		[FieldOffset(0)]
		public FString baseContent;

		// Token: 0x0402E6CF RID: 190159
		[FieldOffset(16)]
		public FString addedMaleString;

		// Token: 0x0402E6D0 RID: 190160
		[FieldOffset(32)]
		public FString addedFemaleString;

		// Token: 0x0402E6D1 RID: 190161
		[FieldOffset(48)]
		public IntPtr __WorldContext;

		// Token: 0x0402E6D2 RID: 190162
		[FieldOffset(56)]
		public FString __Result;
	}

	// Token: 0x02008F3F RID: 36671
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 72)]
	protected ref struct __AddPrefixByGender_FunctionParams
	{
		// Token: 0x0402E6D3 RID: 190163
		[FieldOffset(0)]
		public FString baseContent;

		// Token: 0x0402E6D4 RID: 190164
		[FieldOffset(16)]
		public FString addedMaleString;

		// Token: 0x0402E6D5 RID: 190165
		[FieldOffset(32)]
		public FString addedFemaleString;

		// Token: 0x0402E6D6 RID: 190166
		[FieldOffset(48)]
		public IntPtr __WorldContext;

		// Token: 0x0402E6D7 RID: 190167
		[FieldOffset(56)]
		public FString __Result;
	}
}
