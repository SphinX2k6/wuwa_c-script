using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Data.Sequence.Struct;
using AkiClient.Game.Aki.Sequence.Manager;
using CSharpScript.Game.LevelGamePlay.GravityFlip;
using CSharpScript.Game.LevelGamePlay.ItemInspect;
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

// Token: 0x02002973 RID: 10611
[UClass("/Game/Aki/TypeScript/Game/Module/Sequence/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/Sequence/PlotBlueprintFunctionLibrary.PlotBlueprintFunctionLibrary_C")]
public class PlotBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x06015EDC RID: 89820 RVA: 0x005880B0 File Offset: 0x005862B0
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

	// Token: 0x06015EDD RID: 89821 RVA: 0x0058810A File Offset: 0x0058630A
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SkipCurrentSequence()
	{
	}

	// Token: 0x06015EDE RID: 89822 RVA: 0x0058810C File Offset: 0x0058630C
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void PauseSequence()
	{
	}

	// Token: 0x06015EDF RID: 89823 RVA: 0x0058810E File Offset: 0x0058630E
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ResumeSequence()
	{
	}

	// Token: 0x06015EE0 RID: 89824 RVA: 0x00588110 File Offset: 0x00586310
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void UseEnterMoveMode(AActor inCharacter)
	{
	}

	// Token: 0x06015EE1 RID: 89825 RVA: 0x00588114 File Offset: 0x00586314
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

	// Token: 0x06015EE2 RID: 89826 RVA: 0x0058816C File Offset: 0x0058636C
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool IsInPerformingPlot()
	{
		return PlotModel.Instance != null && (PlotModel.Instance.IsInInteraction || (PlotModel.Instance.IsInPlot && PlotModel.Instance.PlotConfig.PlotLevel.GetValueOrDefault() != EPlotLevel.LevelD));
	}

	// Token: 0x06015EE3 RID: 89827 RVA: 0x005881B8 File Offset: 0x005863B8
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void TriggerBlackSequence()
	{
		PlotController.Instance.TriggerBlackSequence();
	}

	// Token: 0x06015EE4 RID: 89828 RVA: 0x005881C4 File Offset: 0x005863C4
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ChangePlotWeather(int weatherId, bool isInherit, float tweenTime)
	{
		PlotController.Instance.ChangeWeather(weatherId, isInherit, tweenTime);
	}

	// Token: 0x06015EE5 RID: 89829 RVA: 0x005881D3 File Offset: 0x005863D3
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ChangePlotTimeOfDay(bool isInherit, int startSecond, int endSecond, int tweenFrame)
	{
		PlotController.Instance.ChangePlotTimeOfDay(isInherit, startSecond, endSecond, tweenFrame / 30);
	}

	// Token: 0x06015EE6 RID: 89830 RVA: 0x005881E6 File Offset: 0x005863E6
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ExecuteSequenceEvents(string key)
	{
		SequenceController.Instance.RunSequenceFrameEvents(key);
	}

	// Token: 0x06015EE7 RID: 89831 RVA: 0x005881F4 File Offset: 0x005863F4
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

	// Token: 0x06015EE8 RID: 89832 RVA: 0x00588292 File Offset: 0x00586492
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void TriggerCutChange()
	{
		SequenceController.Instance.TriggerCutChange();
	}

	// Token: 0x06015EE9 RID: 89833 RVA: 0x0058829E File Offset: 0x0058649E
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void OpenChapterUi(int chapterState, int chapterId)
	{
		GeneralLogicTreeUtil.Instance.OpenChapterViewV2(chapterState, chapterId, true, null);
	}

	// Token: 0x06015EEA RID: 89834 RVA: 0x005882AE File Offset: 0x005864AE
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ShowLogo(float time)
	{
		SequenceController.Instance.ShowLogo(time);
	}

	// Token: 0x06015EEB RID: 89835 RVA: 0x005882BC File Offset: 0x005864BC
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

	// Token: 0x06015EEC RID: 89836 RVA: 0x00588300 File Offset: 0x00586500
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

	// Token: 0x06015EED RID: 89837 RVA: 0x00588343 File Offset: 0x00586543
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void PlayUiLevelSequence(string seqName)
	{
		SequenceController.Instance.PlayUiLevelSequence(seqName);
	}

	// Token: 0x06015EEE RID: 89838 RVA: 0x00588350 File Offset: 0x00586550
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void CloseUiView()
	{
		SequenceController.Instance.CloseUiView();
	}

	// Token: 0x06015EEF RID: 89839 RVA: 0x0058835C File Offset: 0x0058655C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void PlaySpineAnim(string spineName, bool needLoop = true)
	{
		SequenceController.Instance.PlaySpineAnim(spineName, needLoop);
	}

	// Token: 0x06015EF0 RID: 89840 RVA: 0x0058836C File Offset: 0x0058656C
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

	// Token: 0x06015EF1 RID: 89841 RVA: 0x005883A8 File Offset: 0x005865A8
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

	// Token: 0x06015EF2 RID: 89842 RVA: 0x005883E5 File Offset: 0x005865E5
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void CloseSpineAnim(string spineName)
	{
		SequenceController.Instance.CloseSpineAnim(spineName);
	}

	// Token: 0x06015EF3 RID: 89843 RVA: 0x005883F4 File Offset: 0x005865F4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void CloseSpineAnimInArray(ref TArray<string> spineArray)
	{
		TArray<string> spineArray2 = spineArray;
		SequenceController.Instance.CloseSpineAnimInArray(spineArray2);
	}

	// Token: 0x06015EF4 RID: 89844 RVA: 0x00588410 File Offset: 0x00586610
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

	// Token: 0x06015EF5 RID: 89845 RVA: 0x0058844C File Offset: 0x0058664C
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void AdditionSeqEnd()
	{
		SequenceController.Instance.AdditionSeqEnd();
	}

	// Token: 0x06015EF6 RID: 89846 RVA: 0x00588458 File Offset: 0x00586658
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

	// Token: 0x06015EF7 RID: 89847 RVA: 0x00588500 File Offset: 0x00586700
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

	// Token: 0x06015EF8 RID: 89848 RVA: 0x00588550 File Offset: 0x00586750
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

	// Token: 0x06015EF9 RID: 89849 RVA: 0x00588598 File Offset: 0x00586798
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void CloseArtWord2dView()
	{
		UiManager.Instance.CloseView(EUiViewName.PlotArtWord2dView, null);
	}

	// Token: 0x06015EFA RID: 89850 RVA: 0x005885AA File Offset: 0x005867AA
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ShowNameInput()
	{
		CreateCharacterController.TriggerInputName();
	}

	// Token: 0x06015EFB RID: 89851 RVA: 0x005885B1 File Offset: 0x005867B1
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void AddBurstEyeRenderingMaterial(bool isBoy)
	{
		CreateCharacterController.AddBurstEyeRenderingMaterial(isBoy);
	}

	// Token: 0x06015EFC RID: 89852 RVA: 0x005885B9 File Offset: 0x005867B9
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void RemoveBurstEyeRenderingMaterial(bool isBoy)
	{
		CreateCharacterController.RemoveBurstEyeRenderingMaterial(isBoy);
	}

	// Token: 0x06015EFD RID: 89853 RVA: 0x005885C1 File Offset: 0x005867C1
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

	// Token: 0x06015EFE RID: 89854 RVA: 0x005885D7 File Offset: 0x005867D7
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

	// Token: 0x06015EFF RID: 89855 RVA: 0x005885F0 File Offset: 0x005867F0
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

	// Token: 0x06015F00 RID: 89856 RVA: 0x00588658 File Offset: 0x00586858
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

	// Token: 0x06015F01 RID: 89857 RVA: 0x005886A4 File Offset: 0x005868A4
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

	// Token: 0x06015F02 RID: 89858 RVA: 0x005886F7 File Offset: 0x005868F7
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void EnablePlotInteract(bool bEnable)
	{
		PlotController.Instance.PlotViewManager.EnableInteractPlot(bEnable, new bool?(false), "Blueprint");
	}

	// Token: 0x06015F03 RID: 89859 RVA: 0x00588714 File Offset: 0x00586914
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void EnableCameraShake(bool bEnable, TSoftClassPtr<UMatineeCameraShake> cameraShakePtr)
	{
		SequenceController.Instance.EnableCameraShake(bEnable, cameraShakePtr);
	}

	// Token: 0x06015F04 RID: 89860 RVA: 0x00588724 File Offset: 0x00586924
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool NeedFlowAdaption()
	{
		return GameSettingsManager.Instance.GetCurrentValue(EFunction.FlowAdaptation, true, true) != null;
	}

	// Token: 0x06015F05 RID: 89861 RVA: 0x0058874A File Offset: 0x0058694A
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

	// Token: 0x06015F06 RID: 89862 RVA: 0x00588770 File Offset: 0x00586970
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (PlotBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/Sequence/PlotBlueprintFunctionLibrary.PlotBlueprintFunctionLibrary_C");
		}
		return PlotBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x06015F07 RID: 89863 RVA: 0x00588794 File Offset: 0x00586994
	public PlotBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(PlotBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06015F08 RID: 89864 RVA: 0x005887BC File Offset: 0x005869BC
	[NullableContext(1)]
	public PlotBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PlotBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06015F09 RID: 89865 RVA: 0x005887EF File Offset: 0x005869EF
	protected PlotBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06015F0A RID: 89866 RVA: 0x005887F8 File Offset: 0x005869F8
	protected unsafe static void __CPPCALL_IsInSequence_Implementation(PlotBlueprintFunctionLibrary.__IsInSequence_FunctionParams* __Params)
	{
		__Params->__Result = PlotBlueprintFunctionLibrary.IsInSequence();
	}

	// Token: 0x06015F0B RID: 89867 RVA: 0x00588805 File Offset: 0x00586A05
	protected unsafe static void __CPPCALL_SkipCurrentSequence_Implementation(PlotBlueprintFunctionLibrary.__SkipCurrentSequence_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.SkipCurrentSequence();
	}

	// Token: 0x06015F0C RID: 89868 RVA: 0x0058880C File Offset: 0x00586A0C
	protected unsafe static void __CPPCALL_PauseSequence_Implementation(PlotBlueprintFunctionLibrary.__PauseSequence_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.PauseSequence();
	}

	// Token: 0x06015F0D RID: 89869 RVA: 0x00588813 File Offset: 0x00586A13
	protected unsafe static void __CPPCALL_ResumeSequence_Implementation(PlotBlueprintFunctionLibrary.__ResumeSequence_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.ResumeSequence();
	}

	// Token: 0x06015F0E RID: 89870 RVA: 0x0058881A File Offset: 0x00586A1A
	protected unsafe static void __CPPCALL_UseEnterMoveMode_Implementation(PlotBlueprintFunctionLibrary.__UseEnterMoveMode_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.UseEnterMoveMode(BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->inCharacter));
	}

	// Token: 0x06015F0F RID: 89871 RVA: 0x0058882C File Offset: 0x00586A2C
	protected unsafe static void __CPPCALL_StartPlotTs_Implementation(PlotBlueprintFunctionLibrary.__StartPlotTs_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.StartPlotTs(FString.ToString((void*)(&__Params->inRes)));
	}

	// Token: 0x06015F10 RID: 89872 RVA: 0x0058883F File Offset: 0x00586A3F
	protected unsafe static void __CPPCALL_IsInPerformingPlot_Implementation(PlotBlueprintFunctionLibrary.__IsInPerformingPlot_FunctionParams* __Params)
	{
		__Params->__Result = PlotBlueprintFunctionLibrary.IsInPerformingPlot();
	}

	// Token: 0x06015F11 RID: 89873 RVA: 0x0058884C File Offset: 0x00586A4C
	protected unsafe static void __CPPCALL_TriggerBlackSequence_Implementation(PlotBlueprintFunctionLibrary.__TriggerBlackSequence_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.TriggerBlackSequence();
	}

	// Token: 0x06015F12 RID: 89874 RVA: 0x00588853 File Offset: 0x00586A53
	protected unsafe static void __CPPCALL_ChangePlotWeather_Implementation(PlotBlueprintFunctionLibrary.__ChangePlotWeather_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.ChangePlotWeather(__Params->weatherId, __Params->isInherit, __Params->tweenTime);
	}

	// Token: 0x06015F13 RID: 89875 RVA: 0x0058886C File Offset: 0x00586A6C
	protected unsafe static void __CPPCALL_ChangePlotTimeOfDay_Implementation(PlotBlueprintFunctionLibrary.__ChangePlotTimeOfDay_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.ChangePlotTimeOfDay(__Params->isInherit, __Params->startSecond, __Params->endSecond, __Params->tweenFrame);
	}

	// Token: 0x06015F14 RID: 89876 RVA: 0x0058888B File Offset: 0x00586A8B
	protected unsafe static void __CPPCALL_ExecuteSequenceEvents_Implementation(PlotBlueprintFunctionLibrary.__ExecuteSequenceEvents_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.ExecuteSequenceEvents(FString.ToString((void*)(&__Params->key)));
	}

	// Token: 0x06015F15 RID: 89877 RVA: 0x0058889E File Offset: 0x00586A9E
	protected unsafe static void __CPPCALL_ExecuteEntitySequenceEvents_Implementation(PlotBlueprintFunctionLibrary.__ExecuteEntitySequenceEvents_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.ExecuteEntitySequenceEvents(FString.ToString((void*)(&__Params->key)), __Params->entityId);
	}

	// Token: 0x06015F16 RID: 89878 RVA: 0x005888B7 File Offset: 0x00586AB7
	protected unsafe static void __CPPCALL_TriggerCutChange_Implementation(PlotBlueprintFunctionLibrary.__TriggerCutChange_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.TriggerCutChange();
	}

	// Token: 0x06015F17 RID: 89879 RVA: 0x005888BE File Offset: 0x00586ABE
	protected unsafe static void __CPPCALL_OpenChapterUi_Implementation(PlotBlueprintFunctionLibrary.__OpenChapterUi_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.OpenChapterUi(__Params->chapterState, __Params->chapterId);
	}

	// Token: 0x06015F18 RID: 89880 RVA: 0x005888D1 File Offset: 0x00586AD1
	protected unsafe static void __CPPCALL_ShowLogo_Implementation(PlotBlueprintFunctionLibrary.__ShowLogo_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.ShowLogo(__Params->time);
	}

	// Token: 0x06015F19 RID: 89881 RVA: 0x005888E0 File Offset: 0x00586AE0
	protected unsafe static void __CPPCALL_OpenUiView_Implementation(PlotBlueprintFunctionLibrary.__OpenUiView_FunctionParams* __Params)
	{
		string maleAssetName = FString.ToString((void*)(&__Params->maleAssetName));
		string femaleAssetName = FString.ToString((void*)(&__Params->femaleAssetName));
		string maleSpineName = FString.ToString((void*)(&__Params->maleSpineName));
		string femaleSpineName = FString.ToString((void*)(&__Params->femaleSpineName));
		PlotBlueprintFunctionLibrary.OpenUiView(maleAssetName, femaleAssetName, maleSpineName, femaleSpineName, __Params->needLoop, __Params->useFullscreenAdaptAnchor);
	}

	// Token: 0x06015F1A RID: 89882 RVA: 0x00588934 File Offset: 0x00586B34
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

	// Token: 0x06015F1B RID: 89883 RVA: 0x005889BA File Offset: 0x00586BBA
	protected unsafe static void __CPPCALL_PlayUiLevelSequence_Implementation(PlotBlueprintFunctionLibrary.__PlayUiLevelSequence_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.PlayUiLevelSequence(FString.ToString((void*)(&__Params->seqName)));
	}

	// Token: 0x06015F1C RID: 89884 RVA: 0x005889CD File Offset: 0x00586BCD
	protected unsafe static void __CPPCALL_CloseUiView_Implementation(PlotBlueprintFunctionLibrary.__CloseUiView_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.CloseUiView();
	}

	// Token: 0x06015F1D RID: 89885 RVA: 0x005889D4 File Offset: 0x00586BD4
	protected unsafe static void __CPPCALL_PlaySpineAnim_Implementation(PlotBlueprintFunctionLibrary.__PlaySpineAnim_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.PlaySpineAnim(FString.ToString((void*)(&__Params->spineName)), __Params->needLoop);
	}

	// Token: 0x06015F1E RID: 89886 RVA: 0x005889F0 File Offset: 0x00586BF0
	protected unsafe static void __CPPCALL_PlaySpineAnimForGender_Implementation(PlotBlueprintFunctionLibrary.__PlaySpineAnimForGender_FunctionParams* __Params)
	{
		string maleSpineName = FString.ToString((void*)(&__Params->maleSpineName));
		string femaleSpineName = FString.ToString((void*)(&__Params->femaleSpineName));
		PlotBlueprintFunctionLibrary.PlaySpineAnimForGender(maleSpineName, femaleSpineName, __Params->needLoop);
	}

	// Token: 0x06015F1F RID: 89887 RVA: 0x00588A24 File Offset: 0x00586C24
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

	// Token: 0x06015F20 RID: 89888 RVA: 0x00588A8A File Offset: 0x00586C8A
	protected unsafe static void __CPPCALL_CloseSpineAnim_Implementation(PlotBlueprintFunctionLibrary.__CloseSpineAnim_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.CloseSpineAnim(FString.ToString((void*)(&__Params->spineName)));
	}

	// Token: 0x06015F21 RID: 89889 RVA: 0x00588AA0 File Offset: 0x00586CA0
	protected unsafe static void __CPPCALL_CloseSpineAnimInArray_Implementation(PlotBlueprintFunctionLibrary.__CloseSpineAnimInArray_FunctionParams* __Params)
	{
		TArray<string> tarray = new TArray<string>(&__Params->spineArray, true, true);
		PlotBlueprintFunctionLibrary.CloseSpineAnimInArray(ref tarray);
		if (tarray != null)
		{
			tarray.CopyTo(&__Params->spineArray, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x06015F22 RID: 89890 RVA: 0x00588ADC File Offset: 0x00586CDC
	protected unsafe static void __CPPCALL_AdditionSeqPlay_Implementation(PlotBlueprintFunctionLibrary.__AdditionSeqPlay_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.AdditionSeqPlay(BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelSequence>(__Params->levelSequence), __Params->componentName, __Params->boneName, __Params->frame);
	}

	// Token: 0x06015F23 RID: 89891 RVA: 0x00588B00 File Offset: 0x00586D00
	protected unsafe static void __CPPCALL_AdditionSeqEnd_Implementation(PlotBlueprintFunctionLibrary.__AdditionSeqEnd_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.AdditionSeqEnd();
	}

	// Token: 0x06015F24 RID: 89892 RVA: 0x00588B07 File Offset: 0x00586D07
	protected unsafe static void __CPPCALL_OpenMultiTextCaption_Implementation(PlotBlueprintFunctionLibrary.__OpenMultiTextCaption_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.OpenMultiTextCaption(FString.ToString((void*)(&__Params->textId)), __Params->duration);
	}

	// Token: 0x06015F25 RID: 89893 RVA: 0x00588B20 File Offset: 0x00586D20
	protected unsafe static void __CPPCALL_OpenArtWord2dView_Implementation(PlotBlueprintFunctionLibrary.__OpenArtWord2dView_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.OpenArtWord2dView(FString.ToString((void*)(&__Params->sequenceName)));
	}

	// Token: 0x06015F26 RID: 89894 RVA: 0x00588B33 File Offset: 0x00586D33
	protected unsafe static void __CPPCALL_SwitchArtWord2dMark_Implementation(PlotBlueprintFunctionLibrary.__SwitchArtWord2dMark_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.SwitchArtWord2dMark();
	}

	// Token: 0x06015F27 RID: 89895 RVA: 0x00588B3A File Offset: 0x00586D3A
	protected unsafe static void __CPPCALL_CloseArtWord2dView_Implementation(PlotBlueprintFunctionLibrary.__CloseArtWord2dView_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.CloseArtWord2dView();
	}

	// Token: 0x06015F28 RID: 89896 RVA: 0x00588B41 File Offset: 0x00586D41
	protected unsafe static void __CPPCALL_ShowNameInput_Implementation(PlotBlueprintFunctionLibrary.__ShowNameInput_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.ShowNameInput();
	}

	// Token: 0x06015F29 RID: 89897 RVA: 0x00588B48 File Offset: 0x00586D48
	protected unsafe static void __CPPCALL_AddBurstEyeRenderingMaterial_Implementation(PlotBlueprintFunctionLibrary.__AddBurstEyeRenderingMaterial_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.AddBurstEyeRenderingMaterial(__Params->isBoy);
	}

	// Token: 0x06015F2A RID: 89898 RVA: 0x00588B55 File Offset: 0x00586D55
	protected unsafe static void __CPPCALL_RemoveBurstEyeRenderingMaterial_Implementation(PlotBlueprintFunctionLibrary.__RemoveBurstEyeRenderingMaterial_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.RemoveBurstEyeRenderingMaterial(__Params->isBoy);
	}

	// Token: 0x06015F2B RID: 89899 RVA: 0x00588B62 File Offset: 0x00586D62
	protected unsafe static void __CPPCALL_AddInteractTagToInteractingGravityMachine_Implementation(PlotBlueprintFunctionLibrary.__AddInteractTagToInteractingGravityMachine_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.AddInteractTagToInteractingGravityMachine();
	}

	// Token: 0x06015F2C RID: 89900 RVA: 0x00588B69 File Offset: 0x00586D69
	protected unsafe static void __CPPCALL_RemoveInteractTagFromInteractingGravityMachine_Implementation(PlotBlueprintFunctionLibrary.__RemoveInteractTagFromInteractingGravityMachine_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.RemoveInteractTagFromInteractingGravityMachine();
	}

	// Token: 0x06015F2D RID: 89901 RVA: 0x00588B70 File Offset: 0x00586D70
	protected unsafe static void __CPPCALL_TriggerTagToInteractingGravityMachine_Implementation(PlotBlueprintFunctionLibrary.__TriggerTagToInteractingGravityMachine_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.TriggerTagToInteractingGravityMachine(__Params->tag);
	}

	// Token: 0x06015F2E RID: 89902 RVA: 0x00588B80 File Offset: 0x00586D80
	protected unsafe static void __CPPCALL_ShowBgIcon_Implementation(PlotBlueprintFunctionLibrary.__ShowBgIcon_FunctionParams* __Params)
	{
		UTexture2D orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture2D>(__Params->texture);
		BP_KuroMasterSeqEvent_C orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_KuroMasterSeqEvent_C>(__Params->obj);
		PlotBlueprintFunctionLibrary.ShowBgIcon(__Params->bShow, orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06015F2F RID: 89903 RVA: 0x00588BB2 File Offset: 0x00586DB2
	protected unsafe static void __CPPCALL_BindItemInspectActor_Implementation(PlotBlueprintFunctionLibrary.__BindItemInspectActor_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.BindItemInspectActor(new FMovieSceneObjectBindingID(&__Params->binding, true, true));
	}

	// Token: 0x06015F30 RID: 89904 RVA: 0x00588BC7 File Offset: 0x00586DC7
	protected unsafe static void __CPPCALL_EnablePlotInteract_Implementation(PlotBlueprintFunctionLibrary.__EnablePlotInteract_FunctionParams* __Params)
	{
		PlotBlueprintFunctionLibrary.EnablePlotInteract(__Params->bEnable);
	}

	// Token: 0x06015F31 RID: 89905 RVA: 0x00588BD4 File Offset: 0x00586DD4
	protected unsafe static void __CPPCALL_EnableCameraShake_Implementation(PlotBlueprintFunctionLibrary.__EnableCameraShake_FunctionParams* __Params)
	{
		TSoftClassPtr<UMatineeCameraShake> cameraShakePtr = new TSoftClassPtr<UMatineeCameraShake>(&__Params->cameraShakePtr, true, true);
		PlotBlueprintFunctionLibrary.EnableCameraShake(__Params->bEnable, cameraShakePtr);
	}

	// Token: 0x06015F32 RID: 89906 RVA: 0x00588BFC File Offset: 0x00586DFC
	protected unsafe static void __CPPCALL_NeedFlowAdaption_Implementation(PlotBlueprintFunctionLibrary.__NeedFlowAdaption_FunctionParams* __Params)
	{
		__Params->__Result = PlotBlueprintFunctionLibrary.NeedFlowAdaption();
	}

	// Token: 0x06015F33 RID: 89907 RVA: 0x00588C0C File Offset: 0x00586E0C
	protected unsafe static void __CPPCALL_OpenCaptionImage_Implementation(PlotBlueprintFunctionLibrary.__OpenCaptionImage_FunctionParams* __Params)
	{
		string uiPrefabId = FString.ToString((void*)(&__Params->uiPrefabId));
		string uiStartAnimName = FString.ToString((void*)(&__Params->uiStartAnimName));
		string uiEndAnimName = FString.ToString((void*)(&__Params->uiEndAnimName));
		PlotBlueprintFunctionLibrary.OpenCaptionImage(uiPrefabId, __Params->duration, uiStartAnimName, uiEndAnimName);
	}

	// Token: 0x0400A32B RID: 41771
	private const int FRAME_PER_SECOND = 30;

	// Token: 0x0400A32C RID: 41772
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/Sequence/PlotBlueprintFunctionLibrary.PlotBlueprintFunctionLibrary_C";

	// Token: 0x0400A32D RID: 41773
	private static IntPtr _ClassPtr;

	// Token: 0x0400A32E RID: 41774
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x02008F43 RID: 36675
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __IsInSequence_FunctionParams
	{
		// Token: 0x0402E6E1 RID: 190177
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402E6E2 RID: 190178
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x02008F44 RID: 36676
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SkipCurrentSequence_FunctionParams
	{
		// Token: 0x0402E6E3 RID: 190179
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F45 RID: 36677
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __PauseSequence_FunctionParams
	{
		// Token: 0x0402E6E4 RID: 190180
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F46 RID: 36678
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __ResumeSequence_FunctionParams
	{
		// Token: 0x0402E6E5 RID: 190181
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F47 RID: 36679
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __UseEnterMoveMode_FunctionParams
	{
		// Token: 0x0402E6E6 RID: 190182
		[FieldOffset(0)]
		public IntPtr inCharacter;

		// Token: 0x0402E6E7 RID: 190183
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F48 RID: 36680
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __StartPlotTs_FunctionParams
	{
		// Token: 0x0402E6E8 RID: 190184
		[FieldOffset(0)]
		public FString inRes;

		// Token: 0x0402E6E9 RID: 190185
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F49 RID: 36681
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __IsInPerformingPlot_FunctionParams
	{
		// Token: 0x0402E6EA RID: 190186
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402E6EB RID: 190187
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x02008F4A RID: 36682
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __TriggerBlackSequence_FunctionParams
	{
		// Token: 0x0402E6EC RID: 190188
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F4B RID: 36683
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ChangePlotWeather_FunctionParams
	{
		// Token: 0x0402E6ED RID: 190189
		[FieldOffset(0)]
		public int weatherId;

		// Token: 0x0402E6EE RID: 190190
		[FieldOffset(4)]
		public bool isInherit;

		// Token: 0x0402E6EF RID: 190191
		[FieldOffset(8)]
		public float tweenTime;

		// Token: 0x0402E6F0 RID: 190192
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F4C RID: 36684
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ChangePlotTimeOfDay_FunctionParams
	{
		// Token: 0x0402E6F1 RID: 190193
		[FieldOffset(0)]
		public bool isInherit;

		// Token: 0x0402E6F2 RID: 190194
		[FieldOffset(4)]
		public int startSecond;

		// Token: 0x0402E6F3 RID: 190195
		[FieldOffset(8)]
		public int endSecond;

		// Token: 0x0402E6F4 RID: 190196
		[FieldOffset(12)]
		public int tweenFrame;

		// Token: 0x0402E6F5 RID: 190197
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F4D RID: 36685
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ExecuteSequenceEvents_FunctionParams
	{
		// Token: 0x0402E6F6 RID: 190198
		[FieldOffset(0)]
		public FString key;

		// Token: 0x0402E6F7 RID: 190199
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F4E RID: 36686
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __ExecuteEntitySequenceEvents_FunctionParams
	{
		// Token: 0x0402E6F8 RID: 190200
		[FieldOffset(0)]
		public FString key;

		// Token: 0x0402E6F9 RID: 190201
		[FieldOffset(16)]
		public int entityId;

		// Token: 0x0402E6FA RID: 190202
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F4F RID: 36687
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __TriggerCutChange_FunctionParams
	{
		// Token: 0x0402E6FB RID: 190203
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F50 RID: 36688
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __OpenChapterUi_FunctionParams
	{
		// Token: 0x0402E6FC RID: 190204
		[FieldOffset(0)]
		public int chapterState;

		// Token: 0x0402E6FD RID: 190205
		[FieldOffset(4)]
		public int chapterId;

		// Token: 0x0402E6FE RID: 190206
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F51 RID: 36689
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ShowLogo_FunctionParams
	{
		// Token: 0x0402E6FF RID: 190207
		[FieldOffset(0)]
		public float time;

		// Token: 0x0402E700 RID: 190208
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F52 RID: 36690
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 80)]
	protected ref struct __OpenUiView_FunctionParams
	{
		// Token: 0x0402E701 RID: 190209
		[FieldOffset(0)]
		public FString maleAssetName;

		// Token: 0x0402E702 RID: 190210
		[FieldOffset(16)]
		public FString femaleAssetName;

		// Token: 0x0402E703 RID: 190211
		[FieldOffset(32)]
		public FString maleSpineName;

		// Token: 0x0402E704 RID: 190212
		[FieldOffset(48)]
		public FString femaleSpineName;

		// Token: 0x0402E705 RID: 190213
		[FieldOffset(64)]
		public bool needLoop;

		// Token: 0x0402E706 RID: 190214
		[FieldOffset(65)]
		public bool useFullscreenAdaptAnchor;

		// Token: 0x0402E707 RID: 190215
		[FieldOffset(72)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F53 RID: 36691
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 80)]
	protected ref struct __OpenUiViewInArray_FunctionParams
	{
		// Token: 0x0402E708 RID: 190216
		[FieldOffset(0)]
		public FString maleAssetName;

		// Token: 0x0402E709 RID: 190217
		[FieldOffset(16)]
		public FString femaleAssetName;

		// Token: 0x0402E70A RID: 190218
		[FieldOffset(32)]
		public byte maleSpineArray;

		// Token: 0x0402E70B RID: 190219
		[FieldOffset(48)]
		public byte femaleSpineArray;

		// Token: 0x0402E70C RID: 190220
		[FieldOffset(64)]
		public bool useFullscreenAdaptAnchor;

		// Token: 0x0402E70D RID: 190221
		[FieldOffset(72)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F54 RID: 36692
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __PlayUiLevelSequence_FunctionParams
	{
		// Token: 0x0402E70E RID: 190222
		[FieldOffset(0)]
		public FString seqName;

		// Token: 0x0402E70F RID: 190223
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F55 RID: 36693
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __CloseUiView_FunctionParams
	{
		// Token: 0x0402E710 RID: 190224
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F56 RID: 36694
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __PlaySpineAnim_FunctionParams
	{
		// Token: 0x0402E711 RID: 190225
		[FieldOffset(0)]
		public FString spineName;

		// Token: 0x0402E712 RID: 190226
		[FieldOffset(16)]
		public bool needLoop;

		// Token: 0x0402E713 RID: 190227
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F57 RID: 36695
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __PlaySpineAnimForGender_FunctionParams
	{
		// Token: 0x0402E714 RID: 190228
		[FieldOffset(0)]
		public FString maleSpineName;

		// Token: 0x0402E715 RID: 190229
		[FieldOffset(16)]
		public FString femaleSpineName;

		// Token: 0x0402E716 RID: 190230
		[FieldOffset(32)]
		public bool needLoop;

		// Token: 0x0402E717 RID: 190231
		[FieldOffset(40)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F58 RID: 36696
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __PlaySpineAnimForGenderInArray_FunctionParams
	{
		// Token: 0x0402E718 RID: 190232
		[FieldOffset(0)]
		public byte maleSpineArray;

		// Token: 0x0402E719 RID: 190233
		[FieldOffset(16)]
		public byte femaleSpineArray;

		// Token: 0x0402E71A RID: 190234
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F59 RID: 36697
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __CloseSpineAnim_FunctionParams
	{
		// Token: 0x0402E71B RID: 190235
		[FieldOffset(0)]
		public FString spineName;

		// Token: 0x0402E71C RID: 190236
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F5A RID: 36698
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __CloseSpineAnimInArray_FunctionParams
	{
		// Token: 0x0402E71D RID: 190237
		[FieldOffset(0)]
		public byte spineArray;

		// Token: 0x0402E71E RID: 190238
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F5B RID: 36699
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __AdditionSeqPlay_FunctionParams
	{
		// Token: 0x0402E71F RID: 190239
		[FieldOffset(0)]
		public IntPtr levelSequence;

		// Token: 0x0402E720 RID: 190240
		[FieldOffset(8)]
		public FName componentName;

		// Token: 0x0402E721 RID: 190241
		[FieldOffset(20)]
		public FName boneName;

		// Token: 0x0402E722 RID: 190242
		[FieldOffset(32)]
		public float frame;

		// Token: 0x0402E723 RID: 190243
		[FieldOffset(40)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F5C RID: 36700
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __AdditionSeqEnd_FunctionParams
	{
		// Token: 0x0402E724 RID: 190244
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F5D RID: 36701
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __OpenMultiTextCaption_FunctionParams
	{
		// Token: 0x0402E725 RID: 190245
		[FieldOffset(0)]
		public FString textId;

		// Token: 0x0402E726 RID: 190246
		[FieldOffset(16)]
		public float duration;

		// Token: 0x0402E727 RID: 190247
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F5E RID: 36702
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __OpenArtWord2dView_FunctionParams
	{
		// Token: 0x0402E728 RID: 190248
		[FieldOffset(0)]
		public FString sequenceName;

		// Token: 0x0402E729 RID: 190249
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F5F RID: 36703
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SwitchArtWord2dMark_FunctionParams
	{
		// Token: 0x0402E72A RID: 190250
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F60 RID: 36704
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __CloseArtWord2dView_FunctionParams
	{
		// Token: 0x0402E72B RID: 190251
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F61 RID: 36705
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __ShowNameInput_FunctionParams
	{
		// Token: 0x0402E72C RID: 190252
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F62 RID: 36706
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __AddBurstEyeRenderingMaterial_FunctionParams
	{
		// Token: 0x0402E72D RID: 190253
		[FieldOffset(0)]
		public bool isBoy;

		// Token: 0x0402E72E RID: 190254
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F63 RID: 36707
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __RemoveBurstEyeRenderingMaterial_FunctionParams
	{
		// Token: 0x0402E72F RID: 190255
		[FieldOffset(0)]
		public bool isBoy;

		// Token: 0x0402E730 RID: 190256
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F64 RID: 36708
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __AddInteractTagToInteractingGravityMachine_FunctionParams
	{
		// Token: 0x0402E731 RID: 190257
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F65 RID: 36709
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __RemoveInteractTagFromInteractingGravityMachine_FunctionParams
	{
		// Token: 0x0402E732 RID: 190258
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F66 RID: 36710
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __TriggerTagToInteractingGravityMachine_FunctionParams
	{
		// Token: 0x0402E733 RID: 190259
		[FieldOffset(0)]
		public FGameplayTag tag;

		// Token: 0x0402E734 RID: 190260
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F67 RID: 36711
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __ShowBgIcon_FunctionParams
	{
		// Token: 0x0402E735 RID: 190261
		[FieldOffset(0)]
		public bool bShow;

		// Token: 0x0402E736 RID: 190262
		[FieldOffset(8)]
		public IntPtr texture;

		// Token: 0x0402E737 RID: 190263
		[FieldOffset(16)]
		public IntPtr obj;

		// Token: 0x0402E738 RID: 190264
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F68 RID: 36712
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __BindItemInspectActor_FunctionParams
	{
		// Token: 0x0402E739 RID: 190265
		[FieldOffset(0)]
		public byte binding;

		// Token: 0x0402E73A RID: 190266
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F69 RID: 36713
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EnablePlotInteract_FunctionParams
	{
		// Token: 0x0402E73B RID: 190267
		[FieldOffset(0)]
		public bool bEnable;

		// Token: 0x0402E73C RID: 190268
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F6A RID: 36714
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __EnableCameraShake_FunctionParams
	{
		// Token: 0x0402E73D RID: 190269
		[FieldOffset(0)]
		public bool bEnable;

		// Token: 0x0402E73E RID: 190270
		[FieldOffset(8)]
		public byte cameraShakePtr;

		// Token: 0x0402E73F RID: 190271
		[FieldOffset(56)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008F6B RID: 36715
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __NeedFlowAdaption_FunctionParams
	{
		// Token: 0x0402E740 RID: 190272
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402E741 RID: 190273
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x02008F6C RID: 36716
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __OpenCaptionImage_FunctionParams
	{
		// Token: 0x0402E742 RID: 190274
		[FieldOffset(0)]
		public FString uiPrefabId;

		// Token: 0x0402E743 RID: 190275
		[FieldOffset(16)]
		public float duration;

		// Token: 0x0402E744 RID: 190276
		[FieldOffset(24)]
		public FString uiStartAnimName;

		// Token: 0x0402E745 RID: 190277
		[FieldOffset(40)]
		public FString uiEndAnimName;

		// Token: 0x0402E746 RID: 190278
		[FieldOffset(56)]
		public IntPtr __WorldContext;
	}
}
