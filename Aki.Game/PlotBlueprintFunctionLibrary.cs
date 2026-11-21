using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Data.Sequence.Struct;
using AkiClient.Game.Aki.Sequence.Manager;
using CSharpScript.Game.LevelGamePlay.GravityFlip;
using CSharpScript.Game.LevelGamePlay.ItemInspect;
using CSharpScript.Game.LevelGamePlay.PianoGameplay;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Module.Plot.PlotView;
using CSharpScript.Game.Module.Plot.Sequence;
using CSharpScript.Game.NewWorld.SceneItem;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02001EEE RID: 7918
[UClass("/Game/Aki/TypeScript/Game/Module/Sequence/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/Sequence/PlotBlueprintFunctionLibrary.PlotBlueprintFunctionLibrary_C")]
public class PlotBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x060138E0 RID: 80096 RVA: 0x005B30B4 File Offset: 0x005B12B4
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool IsInSequence()
	{
		if (PlotModel.Instance.IsInPlot)
		{
			EPlotLevel? plotLevel = PlotModel.Instance.PlotConfig.PlotLevel;
			EPlotLevel eplotLevel = EPlotLevel.LevelA;
			return (plotLevel.GetValueOrDefault() == eplotLevel & plotLevel != null) || PlotModel.Instance.PlotConfig.PlotLevel.GetValueOrDefault() == EPlotLevel.LevelB;
		}
		return false;
	}

	// Token: 0x060138E1 RID: 80097 RVA: 0x005B310E File Offset: 0x005B130E
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SkipCurrentSequence()
	{
	}

	// Token: 0x060138E2 RID: 80098 RVA: 0x005B3110 File Offset: 0x005B1310
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void PauseSequence()
	{
	}

	// Token: 0x060138E3 RID: 80099 RVA: 0x005B3112 File Offset: 0x005B1312
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ResumeSequence()
	{
	}

	// Token: 0x060138E4 RID: 80100 RVA: 0x005B3114 File Offset: 0x005B1314
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void UseEnterMoveMode(AActor inCharacter)
	{
	}

	// Token: 0x060138E5 RID: 80101 RVA: 0x005B3118 File Offset: 0x005B1318
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void StartPlotTs(string inRes)
	{
		if (PlotModel.Instance.IsInPlot && PlotModel.Instance.PlotConfig.PlotLevel.GetValueOrDefault() != EPlotLevel.LevelD)
		{
			global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.CFT, "当前正在播放其他剧情，不允许打断", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		FlowController.Instance.StartFlowByRes(inRes);
	}

	// Token: 0x060138E6 RID: 80102 RVA: 0x005B3170 File Offset: 0x005B1370
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool IsInPerformingPlot()
	{
		return PlotModel.Instance != null && (PlotModel.Instance.IsInInteraction || (PlotModel.Instance.IsInPlot && PlotModel.Instance.PlotConfig.PlotLevel.GetValueOrDefault() != EPlotLevel.LevelD));
	}

	// Token: 0x060138E7 RID: 80103 RVA: 0x005B31BC File Offset: 0x005B13BC
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void TriggerBlackSequence()
	{
		PlotController.Instance.TriggerBlackSequence();
	}

	// Token: 0x060138E8 RID: 80104 RVA: 0x005B31C8 File Offset: 0x005B13C8
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ChangePlotWeather(int weatherId, bool isInherit, float tweenTime)
	{
		PlotController.Instance.ChangeWeather(weatherId, isInherit, tweenTime);
	}

	// Token: 0x060138E9 RID: 80105 RVA: 0x005B31D7 File Offset: 0x005B13D7
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ChangePlotTimeOfDay(bool isInherit, int startSecond, int endSecond, int tweenFrame)
	{
		PlotController.Instance.ChangePlotTimeOfDay(isInherit, startSecond, endSecond, tweenFrame / 30);
	}

	// Token: 0x060138EA RID: 80106 RVA: 0x005B31EA File Offset: 0x005B13EA
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ExecuteSequenceEvents(string key)
	{
		SequenceController.Instance.RunSequenceFrameEvents(key);
	}

	// Token: 0x060138EB RID: 80107 RVA: 0x005B31F8 File Offset: 0x005B13F8
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public unsafe static void ExecuteEntitySequenceEvents(string key, int entityId)
	{
		EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(entityId);
		if (entityByPbDataId == null || !entityByPbDataId.IsInit)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.LevelPlay;
			ELogAuthor author = ELogAuthor.FZX;
			string message = "场景引用Sequence帧事件找不到实体";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("key", key);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("id", entityId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		WorldEntity entity = entityByPbDataId.Entity;
		if (entity == null)
		{
			return;
		}
		LevelSequenceFrameEventComponent component = entity.GetComponent<LevelSequenceFrameEventComponent>();
		if (component == null)
		{
			return;
		}
		component.ExecuteEvent(key);
	}

	// Token: 0x060138EC RID: 80108 RVA: 0x005B3296 File Offset: 0x005B1496
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void TriggerCutChange()
	{
		SequenceController.Instance.TriggerCutChange();
	}

	// Token: 0x060138ED RID: 80109 RVA: 0x005B32A2 File Offset: 0x005B14A2
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void OpenChapterUi(int chapterState, int chapterId)
	{
		GeneralLogicTreeUtil.Instance.OpenChapterViewV2(chapterState, chapterId, true, null);
	}

	// Token: 0x060138EE RID: 80110 RVA: 0x005B32B2 File Offset: 0x005B14B2
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ShowLogo(float time)
	{
		SequenceController.Instance.ShowLogo(time);
	}

	// Token: 0x060138EF RID: 80111 RVA: 0x005B32C0 File Offset: 0x005B14C0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void OpenUiView(string maleAssetName, string femaleAssetName, string maleSpineName, string femaleSpineName, bool needLoop = true, bool useFullscreenAdaptAnchor = false)
	{
		int sex = WorldLevelModel.Instance.Sex;
		if (sex == 0)
		{
			SequenceController.Instance.OpenUiView(femaleAssetName, femaleSpineName, needLoop, useFullscreenAdaptAnchor);
			return;
		}
		if (sex != 1)
		{
			return;
		}
		SequenceController.Instance.OpenUiView(maleAssetName, maleSpineName, needLoop, useFullscreenAdaptAnchor);
	}

	// Token: 0x060138F0 RID: 80112 RVA: 0x005B3304 File Offset: 0x005B1504
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void OpenUiViewInArray(string maleAssetName, string femaleAssetName, ref TArray<SpineThingsInfo> maleSpineArray, ref TArray<SpineThingsInfo> femaleSpineArray, bool useFullscreenAdaptAnchor = false)
	{
		int sex = WorldLevelModel.Instance.Sex;
		if (sex == 0)
		{
			TArray<SpineThingsInfo> spineArray = femaleSpineArray;
			SequenceController.Instance.OpenUiViewForArray(femaleAssetName, spineArray, useFullscreenAdaptAnchor);
			return;
		}
		if (sex != 1)
		{
			return;
		}
		TArray<SpineThingsInfo> spineArray2 = maleSpineArray;
		SequenceController.Instance.OpenUiViewForArray(maleAssetName, spineArray2, useFullscreenAdaptAnchor);
	}

	// Token: 0x060138F1 RID: 80113 RVA: 0x005B3347 File Offset: 0x005B1547
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void PlayUiLevelSequence(string seqName)
	{
		SequenceController.Instance.PlayUiLevelSequence(seqName);
	}

	// Token: 0x060138F2 RID: 80114 RVA: 0x005B3354 File Offset: 0x005B1554
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void CloseUiView()
	{
		SequenceController.Instance.CloseUiView();
	}

	// Token: 0x060138F3 RID: 80115 RVA: 0x005B3360 File Offset: 0x005B1560
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void PlaySpineAnim(string spineName, bool needLoop = true)
	{
		SequenceController.Instance.PlaySpineAnim(spineName, needLoop);
	}

	// Token: 0x060138F4 RID: 80116 RVA: 0x005B3370 File Offset: 0x005B1570
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void PlaySpineAnimForGender(string maleSpineName, string femaleSpineName, bool needLoop = true)
	{
		int sex = WorldLevelModel.Instance.Sex;
		if (sex == 0)
		{
			SequenceController.Instance.PlaySpineAnim(femaleSpineName, needLoop);
			return;
		}
		if (sex != 1)
		{
			return;
		}
		SequenceController.Instance.PlaySpineAnim(maleSpineName, needLoop);
	}

	// Token: 0x060138F5 RID: 80117 RVA: 0x005B33AC File Offset: 0x005B15AC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void PlaySpineAnimForGenderInArray(ref TArray<SpineThingsInfo> maleSpineArray, ref TArray<SpineThingsInfo> femaleSpineArray)
	{
		int sex = WorldLevelModel.Instance.Sex;
		if (sex == 0)
		{
			TArray<SpineThingsInfo> spineArray = femaleSpineArray;
			SequenceController.Instance.PlaySpineAnimInArray(spineArray);
			return;
		}
		if (sex != 1)
		{
			return;
		}
		TArray<SpineThingsInfo> spineArray2 = maleSpineArray;
		SequenceController.Instance.PlaySpineAnimInArray(spineArray2);
	}

	// Token: 0x060138F6 RID: 80118 RVA: 0x005B33E9 File Offset: 0x005B15E9
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void CloseSpineAnim(string spineName)
	{
		SequenceController.Instance.CloseSpineAnim(spineName);
	}

	// Token: 0x060138F7 RID: 80119 RVA: 0x005B33F8 File Offset: 0x005B15F8
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void CloseSpineAnimInArray(ref TArray<string> spineArray)
	{
		TArray<string> spineArray2 = spineArray;
		SequenceController.Instance.CloseSpineAnimInArray(spineArray2);
	}

	// Token: 0x060138F8 RID: 80120 RVA: 0x005B3414 File Offset: 0x005B1614
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void AdditionSeqPlay(ULevelSequence levelSequence, FName componentName, FName boneName, float frame)
	{
		if (levelSequence == null)
		{
			global::Log.Instance.Info(ELogModule.Level, ELogAuthor.JYS, "AdditionSeqPlay 没找到LevelSequence", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		SequenceController.Instance.AdditionSeqPlay(levelSequence, componentName, boneName, (int)frame);
	}

	// Token: 0x060138F9 RID: 80121 RVA: 0x005B3450 File Offset: 0x005B1650
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void AdditionSeqEnd()
	{
		SequenceController.Instance.AdditionSeqEnd();
	}

	// Token: 0x060138FA RID: 80122 RVA: 0x005B345C File Offset: 0x005B165C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void OpenMultiTextCaption(string textId, float duration)
	{
		if (string.IsNullOrEmpty(textId))
		{
			global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.HYF, "OpenMultiTextCaption未配置textId，不打开字幕", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (duration <= 0f)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.HYF;
			string message = "OpenMultiTextCaption未配置有效duration，不打开字幕";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("duration", duration);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		PlotWordArtCaptionViewParams param = new PlotWordArtCaptionViewParams
		{
			TidSubtitleText = textId
		};
		UiManager.Instance.OpenViewByPlot(EUiViewName.PlotWordArtCaptionView, param, delegate(bool success, int viewId)
		{
			if (!success)
			{
				return;
			}
			TimerSystem.Instance.Delay(delegate(float _)
			{
				UiManager.Instance.CloseViewById(viewId, null);
			}, duration * 1000f, null, null, true, 1f);
		});
	}

	// Token: 0x060138FB RID: 80123 RVA: 0x005B3504 File Offset: 0x005B1704
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void OpenArtWord2dView(string sequenceName)
	{
		if (string.IsNullOrEmpty(sequenceName))
		{
			global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.HYF, "OpenArtWord2dView未配置sequenceName, 不打开界面", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		PlotArtWord2dViewParams param = new PlotArtWord2dViewParams
		{
			SequenceName = sequenceName
		};
		UiManager.Instance.OpenViewByPlot(EUiViewName.PlotArtWord2dView, param, null);
	}

	// Token: 0x060138FC RID: 80124 RVA: 0x005B3554 File Offset: 0x005B1754
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SwitchArtWord2dMark()
	{
		PlotArtWord2dView plotArtWord2dView = UiManager.Instance.GetViewByName(EUiViewName.PlotArtWord2dView) as PlotArtWord2dView;
		if (plotArtWord2dView == null)
		{
			global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.HYF, "SwitchArtWord2dMark时界面未打开, 忽略", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		plotArtWord2dView.SwitchToNextMark();
	}

	// Token: 0x060138FD RID: 80125 RVA: 0x005B359C File Offset: 0x005B179C
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void CloseArtWord2dView()
	{
		UiManager.Instance.CloseView(EUiViewName.PlotArtWord2dView, null);
	}

	// Token: 0x060138FE RID: 80126 RVA: 0x005B35AE File Offset: 0x005B17AE
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ShowNameInput()
	{
		CreateCharacterController.TriggerInputName();
	}

	// Token: 0x060138FF RID: 80127 RVA: 0x005B35B5 File Offset: 0x005B17B5
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void AddBurstEyeRenderingMaterial(bool isBoy)
	{
		CreateCharacterController.AddBurstEyeRenderingMaterial(isBoy);
	}

	// Token: 0x06013900 RID: 80128 RVA: 0x005B35BD File Offset: 0x005B17BD
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void RemoveBurstEyeRenderingMaterial(bool isBoy)
	{
		CreateCharacterController.RemoveBurstEyeRenderingMaterial(isBoy);
	}

	// Token: 0x06013901 RID: 80129 RVA: 0x005B35C5 File Offset: 0x005B17C5
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void AddInteractTagToInteractingGravityMachine()
	{
		SceneItemGravityFlipComponent gravityFlipComp = GravityFlipModel.Instance.GravityFlipComp;
		if (gravityFlipComp == null)
		{
			return;
		}
		gravityFlipComp.AddInteractTag();
	}

	// Token: 0x06013902 RID: 80130 RVA: 0x005B35DB File Offset: 0x005B17DB
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void RemoveInteractTagFromInteractingGravityMachine()
	{
		SceneItemGravityFlipComponent gravityFlipComp = GravityFlipModel.Instance.GravityFlipComp;
		if (gravityFlipComp == null)
		{
			return;
		}
		gravityFlipComp.RemoveInteractTag();
	}

	// Token: 0x06013903 RID: 80131 RVA: 0x005B35F4 File Offset: 0x005B17F4
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void TriggerTagToInteractingGravityMachine(FGameplayTag tag)
	{
		Entity gravityFlipEntity = GravityFlipModel.Instance.GravityFlipEntity;
		BaseTagComponent baseTagComponent = (gravityFlipEntity != null) ? gravityFlipEntity.GetComponent<BaseTagComponent>() : null;
		int tagIdByName = GameplayTagUtils.GetTagIdByName(tag.TagName.ToString());
		if (baseTagComponent != null && baseTagComponent.HasTag(tagIdByName) && baseTagComponent != null)
		{
			baseTagComponent.RemoveTag(new int?(tagIdByName));
		}
		if (baseTagComponent != null)
		{
			baseTagComponent.AddTag(new int?(tagIdByName));
		}
	}

	// Token: 0x06013904 RID: 80132 RVA: 0x005B365C File Offset: 0x005B185C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ShowBgIcon(bool bShow, UTexture2D texture, BP_KuroMasterSeqEvent_C obj)
	{
		PlotController.Instance.PlotViewManager.RunWithPlotSubtitleView("ShowBgIcon", delegate(PlotSubtitleView view)
		{
			view.SetIconBySequence(bShow, texture, obj);
			return UniTask.CompletedTask;
		}, null);
	}

	// Token: 0x06013905 RID: 80133 RVA: 0x005B36A8 File Offset: 0x005B18A8
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void BindItemInspectActor(FMovieSceneObjectBindingID binding)
	{
		ALevelSequenceActor curLevelSeqActor = SequenceModel.Instance.CurLevelSeqActor;
		if (curLevelSeqActor == null || !curLevelSeqActor.IsValid())
		{
			return;
		}
		AActor spawnedActorByGuid = curLevelSeqActor.SequencePlayer.GetSpawnedActorByGuid(binding.Guid, true);
		if (spawnedActorByGuid != null && spawnedActorByGuid.IsValid())
		{
			ItemInspectController.Instance.BindItemInspectActor(spawnedActorByGuid);
		}
	}

	// Token: 0x06013906 RID: 80134 RVA: 0x005B36FB File Offset: 0x005B18FB
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void EnablePlotInteract(bool bEnable)
	{
		PlotController.Instance.PlotViewManager.EnableInteractPlot(bEnable, new bool?(false), "Blueprint");
	}

	// Token: 0x06013907 RID: 80135 RVA: 0x005B3718 File Offset: 0x005B1918
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void EnableCameraShake(bool bEnable, TSoftClassPtr<UMatineeCameraShake> cameraShakePtr)
	{
		SequenceController.Instance.EnableCameraShake(bEnable, cameraShakePtr);
	}

	// Token: 0x06013908 RID: 80136 RVA: 0x005B3728 File Offset: 0x005B1928
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool NeedFlowAdaption()
	{
		return GameSettingsManager.Instance.GetCurrentValue(EFunction.FlowAdaptation, true, true) != null;
	}

	// Token: 0x06013909 RID: 80137 RVA: 0x005B374E File Offset: 0x005B194E
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void OpenCaptionImage(string uiPrefabId, float duration, string uiStartAnimName, string uiEndAnimName)
	{
		PlotCaptionImageController.Instance.OpenAsync(uiPrefabId, duration, new IUiAnimConfig
		{
			UiStartAnimName = uiStartAnimName,
			UiEndAnimName = uiEndAnimName
		}).Forget();
	}

	// Token: 0x0601390A RID: 80138 RVA: 0x005B3774 File Offset: 0x005B1974
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ExecutePianoSequenceEvent(string key)
	{
		PianoGameplayController.Instance.ExecutePianoSequenceEvent(key);
	}

	// Token: 0x0601390B RID: 80139 RVA: 0x005B3781 File Offset: 0x005B1981
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (PlotBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/Sequence/PlotBlueprintFunctionLibrary.PlotBlueprintFunctionLibrary_C");
		}
		return PlotBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x0601390C RID: 80140 RVA: 0x005B37A8 File Offset: 0x005B19A8
	public PlotBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(PlotBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601390D RID: 80141 RVA: 0x005B37D0 File Offset: 0x005B19D0
	[NullableContext(1)]
	public PlotBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PlotBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601390E RID: 80142 RVA: 0x005B3803 File Offset: 0x005B1A03
	protected PlotBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601390F RID: 80143 RVA: 0x005B380C File Offset: 0x005B1A0C
	protected unsafe static void __CPPCALL_IsInSequence_Implementation(PlotBlueprintFunctionLibrary.__IsInSequence_FunctionParams* __Params)
	{
		__Params->__Result = PlotBlueprintFunctionLibrary.IsInSequence();
	}

	// Token: 0x06013910 RID: 80144 RVA: 0x005B3819 File Offset: 0x005B1A19
	protected unsafe static void __CPPCALL_SkipCurrentSequence_Implementation(PlotBlueprintFunctionLibrary.__SkipCurrentSequence_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.SkipCurrentSequence();
	}

	// Token: 0x06013911 RID: 80145 RVA: 0x005B3820 File Offset: 0x005B1A20
	protected unsafe static void __CPPCALL_PauseSequence_Implementation(PlotBlueprintFunctionLibrary.__PauseSequence_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.PauseSequence();
	}

	// Token: 0x06013912 RID: 80146 RVA: 0x005B3827 File Offset: 0x005B1A27
	protected unsafe static void __CPPCALL_ResumeSequence_Implementation(PlotBlueprintFunctionLibrary.__ResumeSequence_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.ResumeSequence();
	}

	// Token: 0x06013913 RID: 80147 RVA: 0x005B382E File Offset: 0x005B1A2E
	protected unsafe static void __CPPCALL_UseEnterMoveMode_Implementation(PlotBlueprintFunctionLibrary.__UseEnterMoveMode_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.UseEnterMoveMode(BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->inCharacter));
	}

	// Token: 0x06013914 RID: 80148 RVA: 0x005B3840 File Offset: 0x005B1A40
	protected unsafe static void __CPPCALL_StartPlotTs_Implementation(PlotBlueprintFunctionLibrary.__StartPlotTs_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.StartPlotTs(FString.ToString((void*)(&__Params->inRes)));
	}

	// Token: 0x06013915 RID: 80149 RVA: 0x005B3853 File Offset: 0x005B1A53
	protected unsafe static void __CPPCALL_IsInPerformingPlot_Implementation(PlotBlueprintFunctionLibrary.__IsInPerformingPlot_FunctionParams* __Params)
	{
		__Params->__Result = PlotBlueprintFunctionLibrary.IsInPerformingPlot();
	}

	// Token: 0x06013916 RID: 80150 RVA: 0x005B3860 File Offset: 0x005B1A60
	protected unsafe static void __CPPCALL_TriggerBlackSequence_Implementation(PlotBlueprintFunctionLibrary.__TriggerBlackSequence_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.TriggerBlackSequence();
	}

	// Token: 0x06013917 RID: 80151 RVA: 0x005B3867 File Offset: 0x005B1A67
	protected unsafe static void __CPPCALL_ChangePlotWeather_Implementation(PlotBlueprintFunctionLibrary.__ChangePlotWeather_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.ChangePlotWeather(__Params->weatherId, __Params->isInherit, __Params->tweenTime);
	}

	// Token: 0x06013918 RID: 80152 RVA: 0x005B3880 File Offset: 0x005B1A80
	protected unsafe static void __CPPCALL_ChangePlotTimeOfDay_Implementation(PlotBlueprintFunctionLibrary.__ChangePlotTimeOfDay_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.ChangePlotTimeOfDay(__Params->isInherit, __Params->startSecond, __Params->endSecond, __Params->tweenFrame);
	}

	// Token: 0x06013919 RID: 80153 RVA: 0x005B389F File Offset: 0x005B1A9F
	protected unsafe static void __CPPCALL_ExecuteSequenceEvents_Implementation(PlotBlueprintFunctionLibrary.__ExecuteSequenceEvents_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.ExecuteSequenceEvents(FString.ToString((void*)(&__Params->key)));
	}

	// Token: 0x0601391A RID: 80154 RVA: 0x005B38B2 File Offset: 0x005B1AB2
	protected unsafe static void __CPPCALL_ExecuteEntitySequenceEvents_Implementation(PlotBlueprintFunctionLibrary.__ExecuteEntitySequenceEvents_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.ExecuteEntitySequenceEvents(FString.ToString((void*)(&__Params->key)), __Params->entityId);
	}

	// Token: 0x0601391B RID: 80155 RVA: 0x005B38CB File Offset: 0x005B1ACB
	protected unsafe static void __CPPCALL_TriggerCutChange_Implementation(PlotBlueprintFunctionLibrary.__TriggerCutChange_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.TriggerCutChange();
	}

	// Token: 0x0601391C RID: 80156 RVA: 0x005B38D2 File Offset: 0x005B1AD2
	protected unsafe static void __CPPCALL_OpenChapterUi_Implementation(PlotBlueprintFunctionLibrary.__OpenChapterUi_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.OpenChapterUi(__Params->chapterState, __Params->chapterId);
	}

	// Token: 0x0601391D RID: 80157 RVA: 0x005B38E5 File Offset: 0x005B1AE5
	protected unsafe static void __CPPCALL_ShowLogo_Implementation(PlotBlueprintFunctionLibrary.__ShowLogo_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.ShowLogo(__Params->time);
	}

	// Token: 0x0601391E RID: 80158 RVA: 0x005B38F4 File Offset: 0x005B1AF4
	protected unsafe static void __CPPCALL_OpenUiView_Implementation(PlotBlueprintFunctionLibrary.__OpenUiView_FunctionParams* __Params)
	{
		string maleAssetName = FString.ToString((void*)(&__Params->maleAssetName));
		string femaleAssetName = FString.ToString((void*)(&__Params->femaleAssetName));
		string maleSpineName = FString.ToString((void*)(&__Params->maleSpineName));
		string femaleSpineName = FString.ToString((void*)(&__Params->femaleSpineName));
		PlotBlueprintFunctionLibrary.OpenUiView(maleAssetName, femaleAssetName, maleSpineName, femaleSpineName, __Params->needLoop, __Params->useFullscreenAdaptAnchor);
	}

	// Token: 0x0601391F RID: 80159 RVA: 0x005B3948 File Offset: 0x005B1B48
	protected unsafe static void __CPPCALL_OpenUiViewInArray_Implementation(PlotBlueprintFunctionLibrary.__OpenUiViewInArray_FunctionParams* __Params)
	{
		string maleAssetName = FString.ToString((void*)(&__Params->maleAssetName));
		string femaleAssetName = FString.ToString((void*)(&__Params->femaleAssetName));
		TArray<SpineThingsInfo> tarray = new TArray<SpineThingsInfo>(&__Params->maleSpineArray, true, true);
		TArray<SpineThingsInfo> tarray2 = new TArray<SpineThingsInfo>(&__Params->femaleSpineArray, true, true);
		PlotBlueprintFunctionLibrary.OpenUiViewInArray(maleAssetName, femaleAssetName, ref tarray, ref tarray2, __Params->useFullscreenAdaptAnchor);
		if (tarray != null)
		{
			tarray.CopyTo(&__Params->maleSpineArray, default(UScriptStructStackOnlyPtr));
		}
		if (tarray2 != null)
		{
			tarray2.CopyTo(&__Params->femaleSpineArray, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x06013920 RID: 80160 RVA: 0x005B39CE File Offset: 0x005B1BCE
	protected unsafe static void __CPPCALL_PlayUiLevelSequence_Implementation(PlotBlueprintFunctionLibrary.__PlayUiLevelSequence_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.PlayUiLevelSequence(FString.ToString((void*)(&__Params->seqName)));
	}

	// Token: 0x06013921 RID: 80161 RVA: 0x005B39E1 File Offset: 0x005B1BE1
	protected unsafe static void __CPPCALL_CloseUiView_Implementation(PlotBlueprintFunctionLibrary.__CloseUiView_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.CloseUiView();
	}

	// Token: 0x06013922 RID: 80162 RVA: 0x005B39E8 File Offset: 0x005B1BE8
	protected unsafe static void __CPPCALL_PlaySpineAnim_Implementation(PlotBlueprintFunctionLibrary.__PlaySpineAnim_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.PlaySpineAnim(FString.ToString((void*)(&__Params->spineName)), __Params->needLoop);
	}

	// Token: 0x06013923 RID: 80163 RVA: 0x005B3A04 File Offset: 0x005B1C04
	protected unsafe static void __CPPCALL_PlaySpineAnimForGender_Implementation(PlotBlueprintFunctionLibrary.__PlaySpineAnimForGender_FunctionParams* __Params)
	{
		string maleSpineName = FString.ToString((void*)(&__Params->maleSpineName));
		string femaleSpineName = FString.ToString((void*)(&__Params->femaleSpineName));
		PlotBlueprintFunctionLibrary.PlaySpineAnimForGender(maleSpineName, femaleSpineName, __Params->needLoop);
	}

	// Token: 0x06013924 RID: 80164 RVA: 0x005B3A38 File Offset: 0x005B1C38
	protected unsafe static void __CPPCALL_PlaySpineAnimForGenderInArray_Implementation(PlotBlueprintFunctionLibrary.__PlaySpineAnimForGenderInArray_FunctionParams* __Params)
	{
		TArray<SpineThingsInfo> tarray = new TArray<SpineThingsInfo>(&__Params->maleSpineArray, true, true);
		TArray<SpineThingsInfo> tarray2 = new TArray<SpineThingsInfo>(&__Params->femaleSpineArray, true, true);
		PlotBlueprintFunctionLibrary.PlaySpineAnimForGenderInArray(ref tarray, ref tarray2);
		if (tarray != null)
		{
			tarray.CopyTo(&__Params->maleSpineArray, default(UScriptStructStackOnlyPtr));
		}
		if (tarray2 != null)
		{
			tarray2.CopyTo(&__Params->femaleSpineArray, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x06013925 RID: 80165 RVA: 0x005B3A9E File Offset: 0x005B1C9E
	protected unsafe static void __CPPCALL_CloseSpineAnim_Implementation(PlotBlueprintFunctionLibrary.__CloseSpineAnim_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.CloseSpineAnim(FString.ToString((void*)(&__Params->spineName)));
	}

	// Token: 0x06013926 RID: 80166 RVA: 0x005B3AB4 File Offset: 0x005B1CB4
	protected unsafe static void __CPPCALL_CloseSpineAnimInArray_Implementation(PlotBlueprintFunctionLibrary.__CloseSpineAnimInArray_FunctionParams* __Params)
	{
		TArray<string> tarray = new TArray<string>(&__Params->spineArray, true, true);
		PlotBlueprintFunctionLibrary.CloseSpineAnimInArray(ref tarray);
		if (tarray != null)
		{
			tarray.CopyTo(&__Params->spineArray, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x06013927 RID: 80167 RVA: 0x005B3AF0 File Offset: 0x005B1CF0
	protected unsafe static void __CPPCALL_AdditionSeqPlay_Implementation(PlotBlueprintFunctionLibrary.__AdditionSeqPlay_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.AdditionSeqPlay(BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelSequence>(__Params->levelSequence), __Params->componentName, __Params->boneName, __Params->frame);
	}

	// Token: 0x06013928 RID: 80168 RVA: 0x005B3B14 File Offset: 0x005B1D14
	protected unsafe static void __CPPCALL_AdditionSeqEnd_Implementation(PlotBlueprintFunctionLibrary.__AdditionSeqEnd_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.AdditionSeqEnd();
	}

	// Token: 0x06013929 RID: 80169 RVA: 0x005B3B1B File Offset: 0x005B1D1B
	protected unsafe static void __CPPCALL_OpenMultiTextCaption_Implementation(PlotBlueprintFunctionLibrary.__OpenMultiTextCaption_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.OpenMultiTextCaption(FString.ToString((void*)(&__Params->textId)), __Params->duration);
	}

	// Token: 0x0601392A RID: 80170 RVA: 0x005B3B34 File Offset: 0x005B1D34
	protected unsafe static void __CPPCALL_OpenArtWord2dView_Implementation(PlotBlueprintFunctionLibrary.__OpenArtWord2dView_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.OpenArtWord2dView(FString.ToString((void*)(&__Params->sequenceName)));
	}

	// Token: 0x0601392B RID: 80171 RVA: 0x005B3B47 File Offset: 0x005B1D47
	protected unsafe static void __CPPCALL_SwitchArtWord2dMark_Implementation(PlotBlueprintFunctionLibrary.__SwitchArtWord2dMark_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.SwitchArtWord2dMark();
	}

	// Token: 0x0601392C RID: 80172 RVA: 0x005B3B4E File Offset: 0x005B1D4E
	protected unsafe static void __CPPCALL_CloseArtWord2dView_Implementation(PlotBlueprintFunctionLibrary.__CloseArtWord2dView_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.CloseArtWord2dView();
	}

	// Token: 0x0601392D RID: 80173 RVA: 0x005B3B55 File Offset: 0x005B1D55
	protected unsafe static void __CPPCALL_ShowNameInput_Implementation(PlotBlueprintFunctionLibrary.__ShowNameInput_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.ShowNameInput();
	}

	// Token: 0x0601392E RID: 80174 RVA: 0x005B3B5C File Offset: 0x005B1D5C
	protected unsafe static void __CPPCALL_AddBurstEyeRenderingMaterial_Implementation(PlotBlueprintFunctionLibrary.__AddBurstEyeRenderingMaterial_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.AddBurstEyeRenderingMaterial(__Params->isBoy);
	}

	// Token: 0x0601392F RID: 80175 RVA: 0x005B3B69 File Offset: 0x005B1D69
	protected unsafe static void __CPPCALL_RemoveBurstEyeRenderingMaterial_Implementation(PlotBlueprintFunctionLibrary.__RemoveBurstEyeRenderingMaterial_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.RemoveBurstEyeRenderingMaterial(__Params->isBoy);
	}

	// Token: 0x06013930 RID: 80176 RVA: 0x005B3B76 File Offset: 0x005B1D76
	protected unsafe static void __CPPCALL_AddInteractTagToInteractingGravityMachine_Implementation(PlotBlueprintFunctionLibrary.__AddInteractTagToInteractingGravityMachine_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.AddInteractTagToInteractingGravityMachine();
	}

	// Token: 0x06013931 RID: 80177 RVA: 0x005B3B7D File Offset: 0x005B1D7D
	protected unsafe static void __CPPCALL_RemoveInteractTagFromInteractingGravityMachine_Implementation(PlotBlueprintFunctionLibrary.__RemoveInteractTagFromInteractingGravityMachine_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.RemoveInteractTagFromInteractingGravityMachine();
	}

	// Token: 0x06013932 RID: 80178 RVA: 0x005B3B84 File Offset: 0x005B1D84
	protected unsafe static void __CPPCALL_TriggerTagToInteractingGravityMachine_Implementation(PlotBlueprintFunctionLibrary.__TriggerTagToInteractingGravityMachine_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.TriggerTagToInteractingGravityMachine(__Params->tag);
	}

	// Token: 0x06013933 RID: 80179 RVA: 0x005B3B94 File Offset: 0x005B1D94
	protected unsafe static void __CPPCALL_ShowBgIcon_Implementation(PlotBlueprintFunctionLibrary.__ShowBgIcon_FunctionParams* __Params)
	{
		UTexture2D orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture2D>(__Params->texture);
		BP_KuroMasterSeqEvent_C orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_KuroMasterSeqEvent_C>(__Params->obj);
		PlotBlueprintFunctionLibrary.ShowBgIcon(__Params->bShow, orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06013934 RID: 80180 RVA: 0x005B3BC6 File Offset: 0x005B1DC6
	protected unsafe static void __CPPCALL_BindItemInspectActor_Implementation(PlotBlueprintFunctionLibrary.__BindItemInspectActor_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.BindItemInspectActor(new FMovieSceneObjectBindingID(&__Params->binding, true, true));
	}

	// Token: 0x06013935 RID: 80181 RVA: 0x005B3BDB File Offset: 0x005B1DDB
	protected unsafe static void __CPPCALL_EnablePlotInteract_Implementation(PlotBlueprintFunctionLibrary.__EnablePlotInteract_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.EnablePlotInteract(__Params->bEnable);
	}

	// Token: 0x06013936 RID: 80182 RVA: 0x005B3BE8 File Offset: 0x005B1DE8
	protected unsafe static void __CPPCALL_EnableCameraShake_Implementation(PlotBlueprintFunctionLibrary.__EnableCameraShake_FunctionParams* __Params)
	{
		TSoftClassPtr<UMatineeCameraShake> cameraShakePtr = new TSoftClassPtr<UMatineeCameraShake>(&__Params->cameraShakePtr, true, true);
		PlotBlueprintFunctionLibrary.EnableCameraShake(__Params->bEnable, cameraShakePtr);
	}

	// Token: 0x06013937 RID: 80183 RVA: 0x005B3C10 File Offset: 0x005B1E10
	protected unsafe static void __CPPCALL_NeedFlowAdaption_Implementation(PlotBlueprintFunctionLibrary.__NeedFlowAdaption_FunctionParams* __Params)
	{
		__Params->__Result = PlotBlueprintFunctionLibrary.NeedFlowAdaption();
	}

	// Token: 0x06013938 RID: 80184 RVA: 0x005B3C20 File Offset: 0x005B1E20
	protected unsafe static void __CPPCALL_OpenCaptionImage_Implementation(PlotBlueprintFunctionLibrary.__OpenCaptionImage_FunctionParams* __Params)
	{
		string uiPrefabId = FString.ToString((void*)(&__Params->uiPrefabId));
		string uiStartAnimName = FString.ToString((void*)(&__Params->uiStartAnimName));
		string uiEndAnimName = FString.ToString((void*)(&__Params->uiEndAnimName));
		PlotBlueprintFunctionLibrary.OpenCaptionImage(uiPrefabId, __Params->duration, uiStartAnimName, uiEndAnimName);
	}

	// Token: 0x06013939 RID: 80185 RVA: 0x005B3C60 File Offset: 0x005B1E60
	protected unsafe static void __CPPCALL_ExecutePianoSequenceEvent_Implementation(PlotBlueprintFunctionLibrary.__ExecutePianoSequenceEvent_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.ExecutePianoSequenceEvent(FString.ToString((void*)(&__Params->key)));
	}

	// Token: 0x0400A715 RID: 42773
	private const int FRAME_PER_SECOND = 30;

	// Token: 0x0400A716 RID: 42774
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/Sequence/PlotBlueprintFunctionLibrary.PlotBlueprintFunctionLibrary_C";

	// Token: 0x0400A717 RID: 42775
	private static IntPtr _ClassPtr;

	// Token: 0x0400A718 RID: 42776
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0200818B RID: 33163
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __IsInSequence_FunctionParams
	{
		// Token: 0x04029DDE RID: 171486
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04029DDF RID: 171487
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x0200818C RID: 33164
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SkipCurrentSequence_FunctionParams
	{
		// Token: 0x04029DE0 RID: 171488
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200818D RID: 33165
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __PauseSequence_FunctionParams
	{
		// Token: 0x04029DE1 RID: 171489
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200818E RID: 33166
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __ResumeSequence_FunctionParams
	{
		// Token: 0x04029DE2 RID: 171490
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200818F RID: 33167
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __UseEnterMoveMode_FunctionParams
	{
		// Token: 0x04029DE3 RID: 171491
		[FieldOffset(0)]
		public IntPtr inCharacter;

		// Token: 0x04029DE4 RID: 171492
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008190 RID: 33168
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __StartPlotTs_FunctionParams
	{
		// Token: 0x04029DE5 RID: 171493
		[FieldOffset(0)]
		public FString inRes;

		// Token: 0x04029DE6 RID: 171494
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008191 RID: 33169
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __IsInPerformingPlot_FunctionParams
	{
		// Token: 0x04029DE7 RID: 171495
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04029DE8 RID: 171496
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x02008192 RID: 33170
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __TriggerBlackSequence_FunctionParams
	{
		// Token: 0x04029DE9 RID: 171497
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008193 RID: 33171
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ChangePlotWeather_FunctionParams
	{
		// Token: 0x04029DEA RID: 171498
		[FieldOffset(0)]
		public int weatherId;

		// Token: 0x04029DEB RID: 171499
		[FieldOffset(4)]
		public bool isInherit;

		// Token: 0x04029DEC RID: 171500
		[FieldOffset(8)]
		public float tweenTime;

		// Token: 0x04029DED RID: 171501
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008194 RID: 33172
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ChangePlotTimeOfDay_FunctionParams
	{
		// Token: 0x04029DEE RID: 171502
		[FieldOffset(0)]
		public bool isInherit;

		// Token: 0x04029DEF RID: 171503
		[FieldOffset(4)]
		public int startSecond;

		// Token: 0x04029DF0 RID: 171504
		[FieldOffset(8)]
		public int endSecond;

		// Token: 0x04029DF1 RID: 171505
		[FieldOffset(12)]
		public int tweenFrame;

		// Token: 0x04029DF2 RID: 171506
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008195 RID: 33173
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ExecuteSequenceEvents_FunctionParams
	{
		// Token: 0x04029DF3 RID: 171507
		[FieldOffset(0)]
		public FString key;

		// Token: 0x04029DF4 RID: 171508
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008196 RID: 33174
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __ExecuteEntitySequenceEvents_FunctionParams
	{
		// Token: 0x04029DF5 RID: 171509
		[FieldOffset(0)]
		public FString key;

		// Token: 0x04029DF6 RID: 171510
		[FieldOffset(16)]
		public int entityId;

		// Token: 0x04029DF7 RID: 171511
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008197 RID: 33175
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __TriggerCutChange_FunctionParams
	{
		// Token: 0x04029DF8 RID: 171512
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008198 RID: 33176
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __OpenChapterUi_FunctionParams
	{
		// Token: 0x04029DF9 RID: 171513
		[FieldOffset(0)]
		public int chapterState;

		// Token: 0x04029DFA RID: 171514
		[FieldOffset(4)]
		public int chapterId;

		// Token: 0x04029DFB RID: 171515
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008199 RID: 33177
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ShowLogo_FunctionParams
	{
		// Token: 0x04029DFC RID: 171516
		[FieldOffset(0)]
		public float time;

		// Token: 0x04029DFD RID: 171517
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200819A RID: 33178
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 80)]
	protected ref struct __OpenUiView_FunctionParams
	{
		// Token: 0x04029DFE RID: 171518
		[FieldOffset(0)]
		public FString maleAssetName;

		// Token: 0x04029DFF RID: 171519
		[FieldOffset(16)]
		public FString femaleAssetName;

		// Token: 0x04029E00 RID: 171520
		[FieldOffset(32)]
		public FString maleSpineName;

		// Token: 0x04029E01 RID: 171521
		[FieldOffset(48)]
		public FString femaleSpineName;

		// Token: 0x04029E02 RID: 171522
		[FieldOffset(64)]
		public bool needLoop;

		// Token: 0x04029E03 RID: 171523
		[FieldOffset(65)]
		public bool useFullscreenAdaptAnchor;

		// Token: 0x04029E04 RID: 171524
		[FieldOffset(72)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200819B RID: 33179
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 80)]
	protected ref struct __OpenUiViewInArray_FunctionParams
	{
		// Token: 0x04029E05 RID: 171525
		[FieldOffset(0)]
		public FString maleAssetName;

		// Token: 0x04029E06 RID: 171526
		[FieldOffset(16)]
		public FString femaleAssetName;

		// Token: 0x04029E07 RID: 171527
		[FieldOffset(32)]
		public byte maleSpineArray;

		// Token: 0x04029E08 RID: 171528
		[FieldOffset(48)]
		public byte femaleSpineArray;

		// Token: 0x04029E09 RID: 171529
		[FieldOffset(64)]
		public bool useFullscreenAdaptAnchor;

		// Token: 0x04029E0A RID: 171530
		[FieldOffset(72)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200819C RID: 33180
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __PlayUiLevelSequence_FunctionParams
	{
		// Token: 0x04029E0B RID: 171531
		[FieldOffset(0)]
		public FString seqName;

		// Token: 0x04029E0C RID: 171532
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200819D RID: 33181
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __CloseUiView_FunctionParams
	{
		// Token: 0x04029E0D RID: 171533
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200819E RID: 33182
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __PlaySpineAnim_FunctionParams
	{
		// Token: 0x04029E0E RID: 171534
		[FieldOffset(0)]
		public FString spineName;

		// Token: 0x04029E0F RID: 171535
		[FieldOffset(16)]
		public bool needLoop;

		// Token: 0x04029E10 RID: 171536
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200819F RID: 33183
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __PlaySpineAnimForGender_FunctionParams
	{
		// Token: 0x04029E11 RID: 171537
		[FieldOffset(0)]
		public FString maleSpineName;

		// Token: 0x04029E12 RID: 171538
		[FieldOffset(16)]
		public FString femaleSpineName;

		// Token: 0x04029E13 RID: 171539
		[FieldOffset(32)]
		public bool needLoop;

		// Token: 0x04029E14 RID: 171540
		[FieldOffset(40)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020081A0 RID: 33184
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __PlaySpineAnimForGenderInArray_FunctionParams
	{
		// Token: 0x04029E15 RID: 171541
		[FieldOffset(0)]
		public byte maleSpineArray;

		// Token: 0x04029E16 RID: 171542
		[FieldOffset(16)]
		public byte femaleSpineArray;

		// Token: 0x04029E17 RID: 171543
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020081A1 RID: 33185
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __CloseSpineAnim_FunctionParams
	{
		// Token: 0x04029E18 RID: 171544
		[FieldOffset(0)]
		public FString spineName;

		// Token: 0x04029E19 RID: 171545
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020081A2 RID: 33186
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __CloseSpineAnimInArray_FunctionParams
	{
		// Token: 0x04029E1A RID: 171546
		[FieldOffset(0)]
		public byte spineArray;

		// Token: 0x04029E1B RID: 171547
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020081A3 RID: 33187
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __AdditionSeqPlay_FunctionParams
	{
		// Token: 0x04029E1C RID: 171548
		[FieldOffset(0)]
		public IntPtr levelSequence;

		// Token: 0x04029E1D RID: 171549
		[FieldOffset(8)]
		public FName componentName;

		// Token: 0x04029E1E RID: 171550
		[FieldOffset(20)]
		public FName boneName;

		// Token: 0x04029E1F RID: 171551
		[FieldOffset(32)]
		public float frame;

		// Token: 0x04029E20 RID: 171552
		[FieldOffset(40)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020081A4 RID: 33188
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __AdditionSeqEnd_FunctionParams
	{
		// Token: 0x04029E21 RID: 171553
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020081A5 RID: 33189
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __OpenMultiTextCaption_FunctionParams
	{
		// Token: 0x04029E22 RID: 171554
		[FieldOffset(0)]
		public FString textId;

		// Token: 0x04029E23 RID: 171555
		[FieldOffset(16)]
		public float duration;

		// Token: 0x04029E24 RID: 171556
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020081A6 RID: 33190
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __OpenArtWord2dView_FunctionParams
	{
		// Token: 0x04029E25 RID: 171557
		[FieldOffset(0)]
		public FString sequenceName;

		// Token: 0x04029E26 RID: 171558
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020081A7 RID: 33191
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SwitchArtWord2dMark_FunctionParams
	{
		// Token: 0x04029E27 RID: 171559
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020081A8 RID: 33192
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __CloseArtWord2dView_FunctionParams
	{
		// Token: 0x04029E28 RID: 171560
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020081A9 RID: 33193
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __ShowNameInput_FunctionParams
	{
		// Token: 0x04029E29 RID: 171561
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020081AA RID: 33194
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __AddBurstEyeRenderingMaterial_FunctionParams
	{
		// Token: 0x04029E2A RID: 171562
		[FieldOffset(0)]
		public bool isBoy;

		// Token: 0x04029E2B RID: 171563
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020081AB RID: 33195
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __RemoveBurstEyeRenderingMaterial_FunctionParams
	{
		// Token: 0x04029E2C RID: 171564
		[FieldOffset(0)]
		public bool isBoy;

		// Token: 0x04029E2D RID: 171565
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020081AC RID: 33196
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __AddInteractTagToInteractingGravityMachine_FunctionParams
	{
		// Token: 0x04029E2E RID: 171566
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020081AD RID: 33197
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __RemoveInteractTagFromInteractingGravityMachine_FunctionParams
	{
		// Token: 0x04029E2F RID: 171567
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020081AE RID: 33198
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __TriggerTagToInteractingGravityMachine_FunctionParams
	{
		// Token: 0x04029E30 RID: 171568
		[FieldOffset(0)]
		public FGameplayTag tag;

		// Token: 0x04029E31 RID: 171569
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020081AF RID: 33199
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __ShowBgIcon_FunctionParams
	{
		// Token: 0x04029E32 RID: 171570
		[FieldOffset(0)]
		public bool bShow;

		// Token: 0x04029E33 RID: 171571
		[FieldOffset(8)]
		public IntPtr texture;

		// Token: 0x04029E34 RID: 171572
		[FieldOffset(16)]
		public IntPtr obj;

		// Token: 0x04029E35 RID: 171573
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020081B0 RID: 33200
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __BindItemInspectActor_FunctionParams
	{
		// Token: 0x04029E36 RID: 171574
		[FieldOffset(0)]
		public byte binding;

		// Token: 0x04029E37 RID: 171575
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020081B1 RID: 33201
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EnablePlotInteract_FunctionParams
	{
		// Token: 0x04029E38 RID: 171576
		[FieldOffset(0)]
		public bool bEnable;

		// Token: 0x04029E39 RID: 171577
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020081B2 RID: 33202
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __EnableCameraShake_FunctionParams
	{
		// Token: 0x04029E3A RID: 171578
		[FieldOffset(0)]
		public bool bEnable;

		// Token: 0x04029E3B RID: 171579
		[FieldOffset(8)]
		public byte cameraShakePtr;

		// Token: 0x04029E3C RID: 171580
		[FieldOffset(56)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020081B3 RID: 33203
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __NeedFlowAdaption_FunctionParams
	{
		// Token: 0x04029E3D RID: 171581
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04029E3E RID: 171582
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x020081B4 RID: 33204
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __OpenCaptionImage_FunctionParams
	{
		// Token: 0x04029E3F RID: 171583
		[FieldOffset(0)]
		public FString uiPrefabId;

		// Token: 0x04029E40 RID: 171584
		[FieldOffset(16)]
		public float duration;

		// Token: 0x04029E41 RID: 171585
		[FieldOffset(24)]
		public FString uiStartAnimName;

		// Token: 0x04029E42 RID: 171586
		[FieldOffset(40)]
		public FString uiEndAnimName;

		// Token: 0x04029E43 RID: 171587
		[FieldOffset(56)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020081B5 RID: 33205
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ExecutePianoSequenceEvent_FunctionParams
	{
		// Token: 0x04029E44 RID: 171588
		[FieldOffset(0)]
		public FString key;

		// Token: 0x04029E45 RID: 171589
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}
}
