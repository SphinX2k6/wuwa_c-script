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

// Token: 0x02001EED RID: 7917
[UClass("/Game/Aki/TypeScript/Game/Module/Sequence/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/Sequence/PlotActorBlueprintFunctionLibrary.PlotActorBlueprintFunctionLibrary_C")]
public class PlotActorBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x060138C3 RID: 80067 RVA: 0x005B2BE7 File Offset: 0x005B0DE7
	static PlotActorBlueprintFunctionLibrary()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PlotActorBlueprintFunctionLibrary.CreateStaticDefaultValue), new Action(PlotActorBlueprintFunctionLibrary.ResetStaticDefaultValue));
	}

	// Token: 0x060138C4 RID: 80068 RVA: 0x005B2C06 File Offset: 0x005B0E06
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetI18nBillboardComponentSpriteById(UBillboardComponent sprite, string id)
	{
		I18nUtils.SetI18nBillboardComponentSpriteById(sprite, id);
	}

	// Token: 0x060138C5 RID: 80069 RVA: 0x005B2C0F File Offset: 0x005B0E0F
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

	// Token: 0x060138C6 RID: 80070 RVA: 0x005B2C30 File Offset: 0x005B0E30
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

	// Token: 0x060138C7 RID: 80071 RVA: 0x005B2C4E File Offset: 0x005B0E4E
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void UiTextureAttachToActor(AActor target, string textureKey)
	{
		PlotActorBlueprintFunctionLibrary.UiAttachToActorImpAsync(target, textureKey).Forget();
	}

	// Token: 0x060138C8 RID: 80072 RVA: 0x005B2C5C File Offset: 0x005B0E5C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void TextNiagaraSetTextureAndLength(AActor target, string textureKey)
	{
		PlotActorBlueprintFunctionLibrary.TextSetTextureAndLengthToNiagara(target, textureKey);
	}

	// Token: 0x060138C9 RID: 80073 RVA: 0x005B2C65 File Offset: 0x005B0E65
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static string GetMediaNameByKey(string key)
	{
		return I18nUtils.GetI18nPlotAudioMediaName(key) ?? "";
	}

	// Token: 0x060138CA RID: 80074 RVA: 0x005B2C78 File Offset: 0x005B0E78
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

	// Token: 0x060138CB RID: 80075 RVA: 0x005B2CF0 File Offset: 0x005B0EF0
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void StopAllAudioByPostAudioEventAtActor()
	{
		foreach (int handle in PlotActorBlueprintFunctionLibrary.AudioHandleCache)
		{
			AudioSystem.Instance.ExecuteAction(handle, EAudioActionType.Stop, null);
		}
		PlotActorBlueprintFunctionLibrary.AudioHandleCache.Clear();
	}

	// Token: 0x060138CC RID: 80076 RVA: 0x005B2D5C File Offset: 0x005B0F5C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static string AddSuffixByGender(string baseContent, [Nullable(2)] string addedMaleString, [Nullable(2)] string addedFemaleString)
	{
		return baseContent + ((PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male) ? (addedMaleString ?? "") : (addedFemaleString ?? ""));
	}

	// Token: 0x060138CD RID: 80077 RVA: 0x005B2D87 File Offset: 0x005B0F87
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static string AddPrefixByGender(string baseContent, [Nullable(2)] string addedMaleString, [Nullable(2)] string addedFemaleString)
	{
		return ((PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male) ? (addedMaleString ?? "") : (addedFemaleString ?? "")) + baseContent;
	}

	// Token: 0x060138CE RID: 80078 RVA: 0x005B2DB4 File Offset: 0x005B0FB4
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

	// Token: 0x060138CF RID: 80079 RVA: 0x005B2E00 File Offset: 0x005B1000
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

	// Token: 0x060138D0 RID: 80080 RVA: 0x005B2E62 File Offset: 0x005B1062
	public static void CreateStaticDefaultValue()
	{
		PlotActorBlueprintFunctionLibrary.AudioHandleCache = new List<int>();
	}

	// Token: 0x060138D1 RID: 80081 RVA: 0x005B2E6E File Offset: 0x005B106E
	public static void ResetStaticDefaultValue()
	{
		PlotActorBlueprintFunctionLibrary.AudioHandleCache = null;
	}

	// Token: 0x060138D2 RID: 80082 RVA: 0x005B2E76 File Offset: 0x005B1076
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (PlotActorBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/Sequence/PlotActorBlueprintFunctionLibrary.PlotActorBlueprintFunctionLibrary_C");
		}
		return PlotActorBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x060138D3 RID: 80083 RVA: 0x005B2E9C File Offset: 0x005B109C
	public PlotActorBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(PlotActorBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060138D4 RID: 80084 RVA: 0x005B2EC4 File Offset: 0x005B10C4
	[NullableContext(1)]
	public PlotActorBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PlotActorBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060138D5 RID: 80085 RVA: 0x005B2EF7 File Offset: 0x005B10F7
	protected PlotActorBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060138D6 RID: 80086 RVA: 0x005B2F00 File Offset: 0x005B1100
	protected unsafe static void __CPPCALL_SetI18nBillboardComponentSpriteById_Implementation(PlotActorBlueprintFunctionLibrary.__SetI18nBillboardComponentSpriteById_FunctionParams* __Params)
	{
		UBillboardComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UBillboardComponent>(__Params->sprite);
		string id = FString.ToString((void*)(&__Params->id));
		PlotActorBlueprintFunctionLibrary.SetI18nBillboardComponentSpriteById(orCreateUObjectByNativePointer, id);
	}

	// Token: 0x060138D7 RID: 80087 RVA: 0x005B2F2B File Offset: 0x005B112B
	protected unsafe static void __CPPCALL_PlayFromStartForActor_Implementation(PlotActorBlueprintFunctionLibrary.__PlayFromStartForActor_FunctionParams* __Params)
	{
		PlotActorBlueprintFunctionLibrary.PlayFromStartForActor(BuiltinUtils.GetOrCreateUObjectByNativePointer<ALevelSequenceActor>(__Params->actor));
	}

	// Token: 0x060138D8 RID: 80088 RVA: 0x005B2F3D File Offset: 0x005B113D
	protected unsafe static void __CPPCALL_StopForActor_Implementation(PlotActorBlueprintFunctionLibrary.__StopForActor_FunctionParams* __Params)
	{
		PlotActorBlueprintFunctionLibrary.StopForActor(BuiltinUtils.GetOrCreateUObjectByNativePointer<ALevelSequenceActor>(__Params->actor));
	}

	// Token: 0x060138D9 RID: 80089 RVA: 0x005B2F50 File Offset: 0x005B1150
	protected unsafe static void __CPPCALL_UiTextureAttachToActor_Implementation(PlotActorBlueprintFunctionLibrary.__UiTextureAttachToActor_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->target);
		string textureKey = FString.ToString((void*)(&__Params->textureKey));
		PlotActorBlueprintFunctionLibrary.UiTextureAttachToActor(orCreateUObjectByNativePointer, textureKey);
	}

	// Token: 0x060138DA RID: 80090 RVA: 0x005B2F7C File Offset: 0x005B117C
	protected unsafe static void __CPPCALL_TextNiagaraSetTextureAndLength_Implementation(PlotActorBlueprintFunctionLibrary.__TextNiagaraSetTextureAndLength_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->target);
		string textureKey = FString.ToString((void*)(&__Params->textureKey));
		PlotActorBlueprintFunctionLibrary.TextNiagaraSetTextureAndLength(orCreateUObjectByNativePointer, textureKey);
	}

	// Token: 0x060138DB RID: 80091 RVA: 0x005B2FA8 File Offset: 0x005B11A8
	protected unsafe static void __CPPCALL_GetMediaNameByKey_Implementation(PlotActorBlueprintFunctionLibrary.__GetMediaNameByKey_FunctionParams* __Params)
	{
		string key = FString.ToString((void*)(&__Params->key));
		FString.CopyFrom((void*)(&__Params->__Result), PlotActorBlueprintFunctionLibrary.GetMediaNameByKey(key));
	}

	// Token: 0x060138DC RID: 80092 RVA: 0x005B2FD4 File Offset: 0x005B11D4
	protected unsafe static void __CPPCALL_PostAudioEventAtActor_Implementation(PlotActorBlueprintFunctionLibrary.__PostAudioEventAtActor_FunctionParams* __Params)
	{
		string eventName = FString.ToString((void*)(&__Params->eventName));
		string externalName = FString.ToString((void*)(&__Params->externalName));
		string mediaName = FString.ToString((void*)(&__Params->mediaName));
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->target);
		PlotActorBlueprintFunctionLibrary.PostAudioEventAtActor(eventName, externalName, mediaName, orCreateUObjectByNativePointer);
	}

	// Token: 0x060138DD RID: 80093 RVA: 0x005B301B File Offset: 0x005B121B
	protected unsafe static void __CPPCALL_StopAllAudioByPostAudioEventAtActor_Implementation(PlotActorBlueprintFunctionLibrary.__StopAllAudioByPostAudioEventAtActor_FunctionParams* __Params)
	{
		PlotActorBlueprintFunctionLibrary.StopAllAudioByPostAudioEventAtActor();
	}

	// Token: 0x060138DE RID: 80094 RVA: 0x005B3024 File Offset: 0x005B1224
	protected unsafe static void __CPPCALL_AddSuffixByGender_Implementation(PlotActorBlueprintFunctionLibrary.__AddSuffixByGender_FunctionParams* __Params)
	{
		string baseContent = FString.ToString((void*)(&__Params->baseContent));
		string addedMaleString = FString.ToString((void*)(&__Params->addedMaleString));
		string addedFemaleString = FString.ToString((void*)(&__Params->addedFemaleString));
		FString.CopyFrom((void*)(&__Params->__Result), PlotActorBlueprintFunctionLibrary.AddSuffixByGender(baseContent, addedMaleString, addedFemaleString));
	}

	// Token: 0x060138DF RID: 80095 RVA: 0x005B306C File Offset: 0x005B126C
	protected unsafe static void __CPPCALL_AddPrefixByGender_Implementation(PlotActorBlueprintFunctionLibrary.__AddPrefixByGender_FunctionParams* __Params)
	{
		string baseContent = FString.ToString((void*)(&__Params->baseContent));
		string addedMaleString = FString.ToString((void*)(&__Params->addedMaleString));
		string addedFemaleString = FString.ToString((void*)(&__Params->addedFemaleString));
		FString.CopyFrom((void*)(&__Params->__Result), PlotActorBlueprintFunctionLibrary.AddPrefixByGender(baseContent, addedMaleString, addedFemaleString));
	}

	// Token: 0x0400A711 RID: 42769
	[Nullable(2)]
	private static List<int> AudioHandleCache;

	// Token: 0x0400A712 RID: 42770
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/Sequence/PlotActorBlueprintFunctionLibrary.PlotActorBlueprintFunctionLibrary_C";

	// Token: 0x0400A713 RID: 42771
	private static IntPtr _ClassPtr;

	// Token: 0x0400A714 RID: 42772
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0200817E RID: 33150
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __SetI18nBillboardComponentSpriteById_FunctionParams
	{
		// Token: 0x04029DB5 RID: 171445
		[FieldOffset(0)]
		public IntPtr sprite;

		// Token: 0x04029DB6 RID: 171446
		[FieldOffset(8)]
		public FString id;

		// Token: 0x04029DB7 RID: 171447
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200817F RID: 33151
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __PlayFromStartForActor_FunctionParams
	{
		// Token: 0x04029DB8 RID: 171448
		[FieldOffset(0)]
		public IntPtr actor;

		// Token: 0x04029DB9 RID: 171449
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008180 RID: 33152
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __StopForActor_FunctionParams
	{
		// Token: 0x04029DBA RID: 171450
		[FieldOffset(0)]
		public IntPtr actor;

		// Token: 0x04029DBB RID: 171451
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008181 RID: 33153
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __UiTextureAttachToActor_FunctionParams
	{
		// Token: 0x04029DBC RID: 171452
		[FieldOffset(0)]
		public IntPtr target;

		// Token: 0x04029DBD RID: 171453
		[FieldOffset(8)]
		public FString textureKey;

		// Token: 0x04029DBE RID: 171454
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008182 RID: 33154
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __TextNiagaraSetTextureAndLength_FunctionParams
	{
		// Token: 0x04029DBF RID: 171455
		[FieldOffset(0)]
		public IntPtr target;

		// Token: 0x04029DC0 RID: 171456
		[FieldOffset(8)]
		public FString textureKey;

		// Token: 0x04029DC1 RID: 171457
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008183 RID: 33155
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __GetMediaNameByKey_FunctionParams
	{
		// Token: 0x04029DC2 RID: 171458
		[FieldOffset(0)]
		public FString key;

		// Token: 0x04029DC3 RID: 171459
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x04029DC4 RID: 171460
		[FieldOffset(24)]
		public FString __Result;
	}

	// Token: 0x02008184 RID: 33156
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __PostAudioEventAtActor_FunctionParams
	{
		// Token: 0x04029DC5 RID: 171461
		[FieldOffset(0)]
		public FString eventName;

		// Token: 0x04029DC6 RID: 171462
		[FieldOffset(16)]
		public FString externalName;

		// Token: 0x04029DC7 RID: 171463
		[FieldOffset(32)]
		public FString mediaName;

		// Token: 0x04029DC8 RID: 171464
		[FieldOffset(48)]
		public IntPtr target;

		// Token: 0x04029DC9 RID: 171465
		[FieldOffset(56)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008185 RID: 33157
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __StopAllAudioByPostAudioEventAtActor_FunctionParams
	{
		// Token: 0x04029DCA RID: 171466
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008186 RID: 33158
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 72)]
	protected ref struct __AddSuffixByGender_FunctionParams
	{
		// Token: 0x04029DCB RID: 171467
		[FieldOffset(0)]
		public FString baseContent;

		// Token: 0x04029DCC RID: 171468
		[FieldOffset(16)]
		public FString addedMaleString;

		// Token: 0x04029DCD RID: 171469
		[FieldOffset(32)]
		public FString addedFemaleString;

		// Token: 0x04029DCE RID: 171470
		[FieldOffset(48)]
		public IntPtr __WorldContext;

		// Token: 0x04029DCF RID: 171471
		[FieldOffset(56)]
		public FString __Result;
	}

	// Token: 0x02008187 RID: 33159
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 72)]
	protected ref struct __AddPrefixByGender_FunctionParams
	{
		// Token: 0x04029DD0 RID: 171472
		[FieldOffset(0)]
		public FString baseContent;

		// Token: 0x04029DD1 RID: 171473
		[FieldOffset(16)]
		public FString addedMaleString;

		// Token: 0x04029DD2 RID: 171474
		[FieldOffset(32)]
		public FString addedFemaleString;

		// Token: 0x04029DD3 RID: 171475
		[FieldOffset(48)]
		public IntPtr __WorldContext;

		// Token: 0x04029DD4 RID: 171476
		[FieldOffset(56)]
		public FString __Result;
	}
}
