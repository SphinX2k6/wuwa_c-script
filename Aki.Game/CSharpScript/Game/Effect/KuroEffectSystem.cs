using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Data.Common.Struct;
using AkiClient.Game.Aki.Data.Entity.Struct;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Audio;
using CSharpScript.Game.Render;
using CSharpScript.Game.World.Define;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Game.Effect
{
	// Token: 0x020063F3 RID: 25587
	[NullableContext(1)]
	[Nullable(0)]
	public class KuroEffectSystem
	{
		// Token: 0x0603E088 RID: 254088 RVA: 0x011FE764 File Offset: 0x011FC964
		public bool Initialize()
		{
			if (Info.Instance.IsGameRunning())
			{
				UKuroTimerSystemFunctionLibrary.Initialize(GlobalData.GameInstance);
			}
			this.EffectHandleMap.Clear();
			if (!this.InitFEffectSystem(false, false))
			{
				return false;
			}
			this.HasInitialize = true;
			EventSystem instance = EventSystem.Instance;
			EEventName name = EEventName.TriggerUiTimeDilation;
			Action handle;
			if ((handle = KuroEffectSystem.<>O.<0>__OnTimeScaleChange) == null)
			{
				handle = (KuroEffectSystem.<>O.<0>__OnTimeScaleChange = new Action(KuroEffectSystem.OnTimeScaleChange));
			}
			instance.Add(name, handle);
			EventSystem instance2 = EventSystem.Instance;
			EEventName name2 = EEventName.SetNiagaraQuality;
			Action handle2;
			if ((handle2 = KuroEffectSystem.<>O.<1>__OnSetNiagaraQuality) == null)
			{
				handle2 = (KuroEffectSystem.<>O.<1>__OnSetNiagaraQuality = new Action(KuroEffectSystem.OnSetNiagaraQuality));
			}
			instance2.Add(name2, handle2);
			EventSystem instance3 = EventSystem.Instance;
			EEventName name3 = EEventName.AfterGameSettingsAppliedOnOpenLoading;
			Action handle3;
			if ((handle3 = KuroEffectSystem.<>O.<1>__OnSetNiagaraQuality) == null)
			{
				handle3 = (KuroEffectSystem.<>O.<1>__OnSetNiagaraQuality = new Action(KuroEffectSystem.OnSetNiagaraQuality));
			}
			instance3.Add(name3, handle3);
			EventSystem instance4 = EventSystem.Instance;
			EEventName name4 = EEventName.OnGlobalUiSceneStateChanged;
			Action<EKuroUI3DState> handle4;
			if ((handle4 = KuroEffectSystem.<>O.<2>__OnGlobalUiSceneStateChanged) == null)
			{
				handle4 = (KuroEffectSystem.<>O.<2>__OnGlobalUiSceneStateChanged = new Action<EKuroUI3DState>(KuroEffectSystem.OnGlobalUiSceneStateChanged));
			}
			instance4.Add<EKuroUI3DState>(name4, handle4);
			EventSystem instance5 = EventSystem.Instance;
			EEventName name5 = EEventName.OnSetGamePaused;
			Action<bool> handle5;
			if ((handle5 = KuroEffectSystem.<>O.<3>__OnSetGamePaused) == null)
			{
				handle5 = (KuroEffectSystem.<>O.<3>__OnSetGamePaused = new Action<bool>(KuroEffectSystem.OnSetGamePaused));
			}
			instance5.Add<bool>(name5, handle5);
			EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnFormationLoaded));
			this.UltraSkillStateWatcher.Init();
			return true;
		}

		// Token: 0x0603E089 RID: 254089 RVA: 0x011FE8A4 File Offset: 0x011FCAA4
		private bool InitFEffectSystem(bool withEditor = false, bool refresh = false)
		{
			UKuroResourceSystemFunctionLibrary.Initialize(GlobalData.World, 1f);
			if (!withEditor)
			{
				this.CreateEffectSpecMappingWithDb();
			}
			bool flag = !withEditor || refresh || !UKuroEffectSystemFunctionLibrary.HasEffectForSpecData();
			TArray<FKuroEffectSpecData> specDataArray = new TArray<FKuroEffectSpecData>();
			TArray<FKuroEffectSpecChildData> specChildDataArray = new TArray<FKuroEffectSpecChildData>();
			if (flag)
			{
				this.CreateEffectSpecMappingWithJson(withEditor);
				this.UpdateFEffectSystemSpecConfig(specDataArray, specChildDataArray, withEditor);
			}
			this.EffectForSpecArray.Clear();
			this.EffectForSpecDbCacheArray.Clear();
			if (!UKuroEffectSystemFunctionLibrary.Initialize(GlobalData.GameInstance, specDataArray, specChildDataArray, Info.Instance.IsGameRunning(), 0.1f, 0.3f, 0.3f, true, BP_EffectPreview_C.StaticClass(), flag))
			{
				return false;
			}
			UKuroEffectSystemFunctionLibrary.InitStaticGlobalData(EffectEnvironment.Instance.UseLog, Info.Instance.IsInEditorTick(), true);
			FSkeletalMeshSpecOnBodyEffectChangeRetVal fskeletalMeshSpecOnBodyEffectChangeRetVal = new FSkeletalMeshSpecOnBodyEffectChangeRetVal();
			FSkeletalMeshSpecOnBodyEffectChangeRetVal fskeletalMeshSpecOnBodyEffectChangeRetVal2 = fskeletalMeshSpecOnBodyEffectChangeRetVal;
			Func<float, UActorComponent, USkeletalMeshComponent, AActor, UActorComponent> callback;
			if ((callback = KuroEffectSystem.<>O.<4>__SkeletalMeshSpecOnBodyEffectChange) == null)
			{
				callback = (KuroEffectSystem.<>O.<4>__SkeletalMeshSpecOnBodyEffectChange = new Func<float, UActorComponent, USkeletalMeshComponent, AActor, UActorComponent>(KuroEffectSystem.SkeletalMeshSpecOnBodyEffectChange));
			}
			fskeletalMeshSpecOnBodyEffectChangeRetVal2.Bind(callback);
			FSkeletalMeshSpecCreateRenderCompRetVal fskeletalMeshSpecCreateRenderCompRetVal = new FSkeletalMeshSpecCreateRenderCompRetVal();
			FSkeletalMeshSpecCreateRenderCompRetVal fskeletalMeshSpecCreateRenderCompRetVal2 = fskeletalMeshSpecCreateRenderCompRetVal;
			Func<UActorComponent, USkeletalMeshComponent, AActor, UActorComponent> callback2;
			if ((callback2 = KuroEffectSystem.<>O.<5>__SkeletalMeshSpecCreateRenderingComponent) == null)
			{
				callback2 = (KuroEffectSystem.<>O.<5>__SkeletalMeshSpecCreateRenderingComponent = new Func<UActorComponent, USkeletalMeshComponent, AActor, UActorComponent>(KuroEffectSystem.SkeletalMeshSpecCreateRenderingComponent));
			}
			fskeletalMeshSpecCreateRenderCompRetVal2.Bind(callback2);
			FSkeletalMeshSpecDestroyRenderingComponent fskeletalMeshSpecDestroyRenderingComponent = new FSkeletalMeshSpecDestroyRenderingComponent();
			FSkeletalMeshSpecDestroyRenderingComponent fskeletalMeshSpecDestroyRenderingComponent2 = fskeletalMeshSpecDestroyRenderingComponent;
			Action<AActor, UActorComponent> callback3;
			if ((callback3 = KuroEffectSystem.<>O.<6>__SkeletalMeshSpecDestroyRenderingComponent) == null)
			{
				callback3 = (KuroEffectSystem.<>O.<6>__SkeletalMeshSpecDestroyRenderingComponent = new Action<AActor, UActorComponent>(KuroEffectSystem.SkeletalMeshSpecDestroyRenderingComponent));
			}
			fskeletalMeshSpecDestroyRenderingComponent2.Bind(callback3);
			FEffectHandleGetEntityOwnerActorRetVal feffectHandleGetEntityOwnerActorRetVal = new FEffectHandleGetEntityOwnerActorRetVal();
			FEffectHandleGetEntityOwnerActorRetVal feffectHandleGetEntityOwnerActorRetVal2 = feffectHandleGetEntityOwnerActorRetVal;
			Func<int, AActor> callback4;
			if ((callback4 = KuroEffectSystem.<>O.<7>__EffectHandleGetEntityOwnerActor) == null)
			{
				callback4 = (KuroEffectSystem.<>O.<7>__EffectHandleGetEntityOwnerActor = new Func<int, AActor>(KuroEffectSystem.EffectHandleGetEntityOwnerActor));
			}
			feffectHandleGetEntityOwnerActorRetVal2.Bind(callback4);
			FEffectHandleGetEntityModelConfigIdRetVal feffectHandleGetEntityModelConfigIdRetVal = new FEffectHandleGetEntityModelConfigIdRetVal();
			FEffectHandleGetEntityModelConfigIdRetVal feffectHandleGetEntityModelConfigIdRetVal2 = feffectHandleGetEntityModelConfigIdRetVal;
			Func<int, int> callback5;
			if ((callback5 = KuroEffectSystem.<>O.<8>__EffectHandleGetEntityModelConfigId) == null)
			{
				callback5 = (KuroEffectSystem.<>O.<8>__EffectHandleGetEntityModelConfigId = new Func<int, int>(KuroEffectSystem.EffectHandleGetEntityModelConfigId));
			}
			feffectHandleGetEntityModelConfigIdRetVal2.Bind(callback5);
			FEffectHandleGetOrAddEffectDynamicGroupRetVal feffectHandleGetOrAddEffectDynamicGroupRetVal = new FEffectHandleGetOrAddEffectDynamicGroupRetVal();
			FEffectHandleGetOrAddEffectDynamicGroupRetVal feffectHandleGetOrAddEffectDynamicGroupRetVal2 = feffectHandleGetOrAddEffectDynamicGroupRetVal;
			Func<float, FName> callback6;
			if ((callback6 = KuroEffectSystem.<>O.<9>__EffectHandleGetOrAddEffectDynamicGroup) == null)
			{
				callback6 = (KuroEffectSystem.<>O.<9>__EffectHandleGetOrAddEffectDynamicGroup = new Func<float, FName>(KuroEffectSystem.EffectHandleGetOrAddEffectDynamicGroup));
			}
			feffectHandleGetOrAddEffectDynamicGroupRetVal2.Bind(callback6);
			FAudioSystemGetAkComponentRetVal faudioSystemGetAkComponentRetVal = new FAudioSystemGetAkComponentRetVal();
			FAudioSystemGetAkComponentRetVal faudioSystemGetAkComponentRetVal2 = faudioSystemGetAkComponentRetVal;
			Func<bool, AActor, UAkComponent> callback7;
			if ((callback7 = KuroEffectSystem.<>O.<10>__AudioSystemGetAkComponent) == null)
			{
				callback7 = (KuroEffectSystem.<>O.<10>__AudioSystemGetAkComponent = new Func<bool, AActor, UAkComponent>(KuroEffectSystem.AudioSystemGetAkComponent));
			}
			faudioSystemGetAkComponentRetVal2.Bind(callback7);
			FAudioSystemExecuteActionStop faudioSystemExecuteActionStop = new FAudioSystemExecuteActionStop();
			FAudioSystemExecuteActionStop faudioSystemExecuteActionStop2 = faudioSystemExecuteActionStop;
			Action<int, float> callback8;
			if ((callback8 = KuroEffectSystem.<>O.<11>__AudioSystemExecuteActionStop) == null)
			{
				callback8 = (KuroEffectSystem.<>O.<11>__AudioSystemExecuteActionStop = new Action<int, float>(KuroEffectSystem.AudioSystemExecuteActionStop));
			}
			faudioSystemExecuteActionStop2.Bind(callback8);
			FAudioSystemPostEventTransformRetVal faudioSystemPostEventTransformRetVal = new FAudioSystemPostEventTransformRetVal();
			FAudioSystemPostEventTransformRetVal faudioSystemPostEventTransformRetVal2 = faudioSystemPostEventTransformRetVal;
			Func<string, FTransformDouble, int> callback9;
			if ((callback9 = KuroEffectSystem.<>O.<12>__AudioSystemPostEventTransform) == null)
			{
				callback9 = (KuroEffectSystem.<>O.<12>__AudioSystemPostEventTransform = new Func<string, FTransformDouble, int>(KuroEffectSystem.AudioSystemPostEventTransform));
			}
			faudioSystemPostEventTransformRetVal2.Bind(callback9);
			FAudioSystemPostEventAkComponentRetVal faudioSystemPostEventAkComponentRetVal = new FAudioSystemPostEventAkComponentRetVal();
			FAudioSystemPostEventAkComponentRetVal faudioSystemPostEventAkComponentRetVal2 = faudioSystemPostEventAkComponentRetVal;
			Func<string, UAkComponent, int> callback10;
			if ((callback10 = KuroEffectSystem.<>O.<13>__AudioSystemPostEventAkComponent) == null)
			{
				callback10 = (KuroEffectSystem.<>O.<13>__AudioSystemPostEventAkComponent = new Func<string, UAkComponent, int>(KuroEffectSystem.AudioSystemPostEventAkComponent));
			}
			faudioSystemPostEventAkComponentRetVal2.Bind(callback10);
			FNiagaraSpecIsNeedQualityBiasRetVal fniagaraSpecIsNeedQualityBiasRetVal = new FNiagaraSpecIsNeedQualityBiasRetVal();
			FNiagaraSpecIsNeedQualityBiasRetVal fniagaraSpecIsNeedQualityBiasRetVal2 = fniagaraSpecIsNeedQualityBiasRetVal;
			Func<int, bool> callback11;
			if ((callback11 = KuroEffectSystem.<>O.<14>__NiagaraSpecIsNeedQualityBias) == null)
			{
				callback11 = (KuroEffectSystem.<>O.<14>__NiagaraSpecIsNeedQualityBias = new Func<int, bool>(KuroEffectSystem.NiagaraSpecIsNeedQualityBias));
			}
			fniagaraSpecIsNeedQualityBiasRetVal2.Bind(callback11);
			FPostProcessSpecIsNeedPostEffectRetVal fpostProcessSpecIsNeedPostEffectRetVal = new FPostProcessSpecIsNeedPostEffectRetVal();
			FPostProcessSpecIsNeedPostEffectRetVal fpostProcessSpecIsNeedPostEffectRetVal2 = fpostProcessSpecIsNeedPostEffectRetVal;
			Func<int, bool, bool> callback12;
			if ((callback12 = KuroEffectSystem.<>O.<15>__PostProcessSpecIsNeedPostEffect) == null)
			{
				callback12 = (KuroEffectSystem.<>O.<15>__PostProcessSpecIsNeedPostEffect = new Func<int, bool, bool>(KuroEffectSystem.PostProcessSpecIsNeedPostEffect));
			}
			fpostProcessSpecIsNeedPostEffectRetVal2.Bind(callback12);
			FPostProcessSpecIsDisableInUltraSkillRetVal fpostProcessSpecIsDisableInUltraSkillRetVal = new FPostProcessSpecIsDisableInUltraSkillRetVal();
			FPostProcessSpecIsDisableInUltraSkillRetVal fpostProcessSpecIsDisableInUltraSkillRetVal2 = fpostProcessSpecIsDisableInUltraSkillRetVal;
			Func<int, bool> callback13;
			if ((callback13 = KuroEffectSystem.<>O.<16>__PostProcessSpecIsDisableInUltraSkill) == null)
			{
				callback13 = (KuroEffectSystem.<>O.<16>__PostProcessSpecIsDisableInUltraSkill = new Func<int, bool>(KuroEffectSystem.PostProcessSpecIsDisableInUltraSkill));
			}
			fpostProcessSpecIsDisableInUltraSkillRetVal2.Bind(callback13);
			FActorSystemGetRetVal factorSystemGetRetVal = new FActorSystemGetRetVal();
			FActorSystemGetRetVal factorSystemGetRetVal2 = factorSystemGetRetVal;
			FActorSystemGetRetVal.FActorSystemGetRetVal_ScriptDelegate callback14;
			if ((callback14 = KuroEffectSystem.<>O.<17>__ActorSystemGet) == null)
			{
				callback14 = (KuroEffectSystem.<>O.<17>__ActorSystemGet = new FActorSystemGetRetVal.FActorSystemGetRetVal_ScriptDelegate(KuroEffectSystem.ActorSystemGet));
			}
			factorSystemGetRetVal2.Bind(callback14);
			FActorSystemPutRetVal factorSystemPutRetVal = new FActorSystemPutRetVal();
			FActorSystemPutRetVal factorSystemPutRetVal2 = factorSystemPutRetVal;
			Func<string, AActor, bool> callback15;
			if ((callback15 = KuroEffectSystem.<>O.<18>__ActorSystemPut) == null)
			{
				callback15 = (KuroEffectSystem.<>O.<18>__ActorSystemPut = new Func<string, AActor, bool>(KuroEffectSystem.ActorSystemPut));
			}
			factorSystemPutRetVal2.Bind(callback15);
			FEffectSystemSetEffectView feffectSystemSetEffectView = new FEffectSystemSetEffectView();
			FEffectSystemSetEffectView feffectSystemSetEffectView2 = feffectSystemSetEffectView;
			Action<AActor, int> callback16;
			if ((callback16 = KuroEffectSystem.<>O.<19>__EffectSystemSetEffectView) == null)
			{
				callback16 = (KuroEffectSystem.<>O.<19>__EffectSystemSetEffectView = new Action<AActor, int>(KuroEffectSystem.EffectSystemSetEffectView));
			}
			feffectSystemSetEffectView2.Bind(callback16);
			FEffectSystemCheckIsNetPlayerRetVal feffectSystemCheckIsNetPlayerRetVal = new FEffectSystemCheckIsNetPlayerRetVal();
			FEffectSystemCheckIsNetPlayerRetVal feffectSystemCheckIsNetPlayerRetVal2 = feffectSystemCheckIsNetPlayerRetVal;
			Func<int, bool> callback17;
			if ((callback17 = KuroEffectSystem.<>O.<20>__EffectSystemCheckIsNetPlayer) == null)
			{
				callback17 = (KuroEffectSystem.<>O.<20>__EffectSystemCheckIsNetPlayer = new Func<int, bool>(KuroEffectSystem.EffectSystemCheckIsNetPlayer));
			}
			feffectSystemCheckIsNetPlayerRetVal2.Bind(callback17);
			FEffectSystemCheckMobileBlackEffectRetVal feffectSystemCheckMobileBlackEffectRetVal = new FEffectSystemCheckMobileBlackEffectRetVal();
			FEffectSystemCheckMobileBlackEffectRetVal feffectSystemCheckMobileBlackEffectRetVal2 = feffectSystemCheckMobileBlackEffectRetVal;
			Func<string, bool> callback18;
			if ((callback18 = KuroEffectSystem.<>O.<21>__EffectSystemCheckMobileBlackEffect) == null)
			{
				callback18 = (KuroEffectSystem.<>O.<21>__EffectSystemCheckMobileBlackEffect = new Func<string, bool>(KuroEffectSystem.EffectSystemCheckMobileBlackEffect));
			}
			feffectSystemCheckMobileBlackEffectRetVal2.Bind(callback18);
			FEffectSpecRegisterBodyEffect feffectSpecRegisterBodyEffect = new FEffectSpecRegisterBodyEffect();
			FEffectSpecRegisterBodyEffect feffectSpecRegisterBodyEffect2 = feffectSpecRegisterBodyEffect;
			Action<int, AActor, USkeletalMeshComponent, UObject, UEffectModelBase> callback19;
			if ((callback19 = KuroEffectSystem.<>O.<22>__EffectSpecRegisterBodyEffect) == null)
			{
				callback19 = (KuroEffectSystem.<>O.<22>__EffectSpecRegisterBodyEffect = new Action<int, AActor, USkeletalMeshComponent, UObject, UEffectModelBase>(KuroEffectSystem.EffectSpecRegisterBodyEffect));
			}
			feffectSpecRegisterBodyEffect2.Bind(callback19);
			FEffectSpecUnregisterBodyEffect feffectSpecUnregisterBodyEffect = new FEffectSpecUnregisterBodyEffect();
			FEffectSpecUnregisterBodyEffect feffectSpecUnregisterBodyEffect2 = feffectSpecUnregisterBodyEffect;
			Action<int, AActor, USkeletalMeshComponent, UObject, UEffectModelBase> callback20;
			if ((callback20 = KuroEffectSystem.<>O.<23>__EffectSpecUnregisterBodyEffect) == null)
			{
				callback20 = (KuroEffectSystem.<>O.<23>__EffectSpecUnregisterBodyEffect = new Action<int, AActor, USkeletalMeshComponent, UObject, UEffectModelBase>(KuroEffectSystem.EffectSpecUnregisterBodyEffect));
			}
			feffectSpecUnregisterBodyEffect2.Bind(callback20);
			FMaterialSpecGetRenderingComponentByContextRetVal fmaterialSpecGetRenderingComponentByContextRetVal = new FMaterialSpecGetRenderingComponentByContextRetVal();
			FMaterialSpecGetRenderingComponentByContextRetVal fmaterialSpecGetRenderingComponentByContextRetVal2 = fmaterialSpecGetRenderingComponentByContextRetVal;
			Func<int, UObject, UKuroCharRenderingComponent> callback21;
			if ((callback21 = KuroEffectSystem.<>O.<24>__MaterialSpecGetRenderingComponentByContext) == null)
			{
				callback21 = (KuroEffectSystem.<>O.<24>__MaterialSpecGetRenderingComponentByContext = new Func<int, UObject, UKuroCharRenderingComponent>(KuroEffectSystem.MaterialSpecGetRenderingComponentByContext));
			}
			fmaterialSpecGetRenderingComponentByContextRetVal2.Bind(callback21);
			FMaterialSpecGetRenderingComponentBySkeletalRetVal fmaterialSpecGetRenderingComponentBySkeletalRetVal = new FMaterialSpecGetRenderingComponentBySkeletalRetVal();
			FMaterialSpecGetRenderingComponentBySkeletalRetVal fmaterialSpecGetRenderingComponentBySkeletalRetVal2 = fmaterialSpecGetRenderingComponentBySkeletalRetVal;
			Func<USkeletalMeshComponent, UKuroCharRenderingComponent> callback22;
			if ((callback22 = KuroEffectSystem.<>O.<25>__MaterialSpecGetRenderingComponentBySkeletal) == null)
			{
				callback22 = (KuroEffectSystem.<>O.<25>__MaterialSpecGetRenderingComponentBySkeletal = new Func<USkeletalMeshComponent, UKuroCharRenderingComponent>(KuroEffectSystem.MaterialSpecGetRenderingComponentBySkeletal));
			}
			fmaterialSpecGetRenderingComponentBySkeletalRetVal2.Bind(callback22);
			FMaterialSpecSpawnRenderActorRetVal fmaterialSpecSpawnRenderActorRetVal = new FMaterialSpecSpawnRenderActorRetVal();
			FMaterialSpecSpawnRenderActorRetVal fmaterialSpecSpawnRenderActorRetVal2 = fmaterialSpecSpawnRenderActorRetVal;
			Func<USkeletalMeshComponent, AActor> callback23;
			if ((callback23 = KuroEffectSystem.<>O.<26>__MaterialSpecSpawnRenderActor) == null)
			{
				callback23 = (KuroEffectSystem.<>O.<26>__MaterialSpecSpawnRenderActor = new Func<USkeletalMeshComponent, AActor>(KuroEffectSystem.MaterialSpecSpawnRenderActor));
			}
			fmaterialSpecSpawnRenderActorRetVal2.Bind(callback23);
			FMaterialSpecGetRenderingComponentByRenderActorRetVal fmaterialSpecGetRenderingComponentByRenderActorRetVal = new FMaterialSpecGetRenderingComponentByRenderActorRetVal();
			FMaterialSpecGetRenderingComponentByRenderActorRetVal fmaterialSpecGetRenderingComponentByRenderActorRetVal2 = fmaterialSpecGetRenderingComponentByRenderActorRetVal;
			Func<AActor, USkeletalMeshComponent, UKuroCharRenderingComponent> callback24;
			if ((callback24 = KuroEffectSystem.<>O.<27>__MaterialSpecGetRenderingComponentByRenderActor) == null)
			{
				callback24 = (KuroEffectSystem.<>O.<27>__MaterialSpecGetRenderingComponentByRenderActor = new Func<AActor, USkeletalMeshComponent, UKuroCharRenderingComponent>(KuroEffectSystem.MaterialSpecGetRenderingComponentByRenderActor));
			}
			fmaterialSpecGetRenderingComponentByRenderActorRetVal2.Bind(callback24);
			FMaterialSpecAddMaterialControllerDataRetVal fmaterialSpecAddMaterialControllerDataRetVal = new FMaterialSpecAddMaterialControllerDataRetVal();
			FMaterialSpecAddMaterialControllerDataRetVal fmaterialSpecAddMaterialControllerDataRetVal2 = fmaterialSpecAddMaterialControllerDataRetVal;
			Func<UKuroCharRenderingComponent, UKuroMaterialControllerDataAsset, int> callback25;
			if ((callback25 = KuroEffectSystem.<>O.<28>__MaterialSpecAddMaterialControllerData) == null)
			{
				callback25 = (KuroEffectSystem.<>O.<28>__MaterialSpecAddMaterialControllerData = new Func<UKuroCharRenderingComponent, UKuroMaterialControllerDataAsset, int>(KuroEffectSystem.MaterialSpecAddMaterialControllerData));
			}
			fmaterialSpecAddMaterialControllerDataRetVal2.Bind(callback25);
			FMaterialSpecRemoveMaterialControllerData fmaterialSpecRemoveMaterialControllerData = new FMaterialSpecRemoveMaterialControllerData();
			FMaterialSpecRemoveMaterialControllerData fmaterialSpecRemoveMaterialControllerData2 = fmaterialSpecRemoveMaterialControllerData;
			Action<UKuroCharRenderingComponent, int> callback26;
			if ((callback26 = KuroEffectSystem.<>O.<29>__MaterialSpecRemoveMaterialControllerData) == null)
			{
				callback26 = (KuroEffectSystem.<>O.<29>__MaterialSpecRemoveMaterialControllerData = new Action<UKuroCharRenderingComponent, int>(KuroEffectSystem.MaterialSpecRemoveMaterialControllerData));
			}
			fmaterialSpecRemoveMaterialControllerData2.Bind(callback26);
			FMaterialSpecDestroyRenderingComponent fmaterialSpecDestroyRenderingComponent = new FMaterialSpecDestroyRenderingComponent();
			FMaterialSpecDestroyRenderingComponent fmaterialSpecDestroyRenderingComponent2 = fmaterialSpecDestroyRenderingComponent;
			Action<UKuroCharRenderingComponent> callback27;
			if ((callback27 = KuroEffectSystem.<>O.<30>__MaterialSpecDestroyRenderingComponent) == null)
			{
				callback27 = (KuroEffectSystem.<>O.<30>__MaterialSpecDestroyRenderingComponent = new Action<UKuroCharRenderingComponent>(KuroEffectSystem.MaterialSpecDestroyRenderingComponent));
			}
			fmaterialSpecDestroyRenderingComponent2.Bind(callback27);
			FEffectAudioControllerAddPlayEffectAudioRetVal feffectAudioControllerAddPlayEffectAudioRetVal = new FEffectAudioControllerAddPlayEffectAudioRetVal();
			FEffectAudioControllerAddPlayEffectAudioRetVal feffectAudioControllerAddPlayEffectAudioRetVal2 = feffectAudioControllerAddPlayEffectAudioRetVal;
			Func<UEffectModelAudio, AActor, int, int> callback28;
			if ((callback28 = KuroEffectSystem.<>O.<31>__EffectAudioControllerAddPlayEffectAudio) == null)
			{
				callback28 = (KuroEffectSystem.<>O.<31>__EffectAudioControllerAddPlayEffectAudio = new Func<UEffectModelAudio, AActor, int, int>(KuroEffectSystem.EffectAudioControllerAddPlayEffectAudio));
			}
			feffectAudioControllerAddPlayEffectAudioRetVal2.Bind(callback28);
			FEffectAudioControllerAddPlayEffectAudioPriorityRetVal feffectAudioControllerAddPlayEffectAudioPriorityRetVal = new FEffectAudioControllerAddPlayEffectAudioPriorityRetVal();
			FEffectAudioControllerAddPlayEffectAudioPriorityRetVal feffectAudioControllerAddPlayEffectAudioPriorityRetVal2 = feffectAudioControllerAddPlayEffectAudioPriorityRetVal;
			Func<UEffectModelAudio, AActor, int, int, int> callback29;
			if ((callback29 = KuroEffectSystem.<>O.<32>__EffectAudioControllerAddPlayEffectAudioPriority) == null)
			{
				callback29 = (KuroEffectSystem.<>O.<32>__EffectAudioControllerAddPlayEffectAudioPriority = new Func<UEffectModelAudio, AActor, int, int, int>(KuroEffectSystem.EffectAudioControllerAddPlayEffectAudioPriority));
			}
			feffectAudioControllerAddPlayEffectAudioPriorityRetVal2.Bind(callback29);
			FEffectAudioControllerOnStopEffectAudio feffectAudioControllerOnStopEffectAudio = new FEffectAudioControllerOnStopEffectAudio();
			FEffectAudioControllerOnStopEffectAudio feffectAudioControllerOnStopEffectAudio2 = feffectAudioControllerOnStopEffectAudio;
			Action<int, string> callback30;
			if ((callback30 = KuroEffectSystem.<>O.<33>__EffectAudioControllerOnStopEffectAudio) == null)
			{
				callback30 = (KuroEffectSystem.<>O.<33>__EffectAudioControllerOnStopEffectAudio = new Action<int, string>(KuroEffectSystem.EffectAudioControllerOnStopEffectAudio));
			}
			feffectAudioControllerOnStopEffectAudio2.Bind(callback30);
			UKuroEffectSystemFunctionLibrary.RegisterJsFunction(fskeletalMeshSpecOnBodyEffectChangeRetVal, fskeletalMeshSpecCreateRenderCompRetVal, fskeletalMeshSpecDestroyRenderingComponent, feffectHandleGetEntityOwnerActorRetVal, feffectHandleGetEntityModelConfigIdRetVal, feffectHandleGetOrAddEffectDynamicGroupRetVal, faudioSystemGetAkComponentRetVal, faudioSystemExecuteActionStop, faudioSystemPostEventTransformRetVal, faudioSystemPostEventAkComponentRetVal, fniagaraSpecIsNeedQualityBiasRetVal, fpostProcessSpecIsNeedPostEffectRetVal, fpostProcessSpecIsDisableInUltraSkillRetVal, factorSystemGetRetVal, factorSystemPutRetVal, feffectSystemSetEffectView, feffectSystemCheckIsNetPlayerRetVal, feffectSystemCheckMobileBlackEffectRetVal, feffectSpecRegisterBodyEffect, feffectSpecUnregisterBodyEffect, fmaterialSpecGetRenderingComponentByContextRetVal, fmaterialSpecGetRenderingComponentBySkeletalRetVal, fmaterialSpecSpawnRenderActorRetVal, fmaterialSpecGetRenderingComponentByRenderActorRetVal, fmaterialSpecAddMaterialControllerDataRetVal, fmaterialSpecRemoveMaterialControllerData, fmaterialSpecDestroyRenderingComponent, feffectAudioControllerAddPlayEffectAudioRetVal, feffectAudioControllerAddPlayEffectAudioPriorityRetVal, feffectAudioControllerOnStopEffectAudio);
			return true;
		}

		// Token: 0x0603E08A RID: 254090 RVA: 0x011FEE6C File Offset: 0x011FD06C
		public bool Clear()
		{
			this.HasInitialize = false;
			EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnFormationLoaded));
			EventSystem instance = EventSystem.Instance;
			EEventName name = EEventName.OnSetGamePaused;
			Action<bool> handle;
			if ((handle = KuroEffectSystem.<>O.<3>__OnSetGamePaused) == null)
			{
				handle = (KuroEffectSystem.<>O.<3>__OnSetGamePaused = new Action<bool>(KuroEffectSystem.OnSetGamePaused));
			}
			instance.Remove<bool>(name, handle);
			EventSystem instance2 = EventSystem.Instance;
			EEventName name2 = EEventName.OnGlobalUiSceneStateChanged;
			Action<EKuroUI3DState> handle2;
			if ((handle2 = KuroEffectSystem.<>O.<2>__OnGlobalUiSceneStateChanged) == null)
			{
				handle2 = (KuroEffectSystem.<>O.<2>__OnGlobalUiSceneStateChanged = new Action<EKuroUI3DState>(KuroEffectSystem.OnGlobalUiSceneStateChanged));
			}
			instance2.Remove<EKuroUI3DState>(name2, handle2);
			EventSystem instance3 = EventSystem.Instance;
			EEventName name3 = EEventName.AfterGameSettingsAppliedOnOpenLoading;
			Action handle3;
			if ((handle3 = KuroEffectSystem.<>O.<1>__OnSetNiagaraQuality) == null)
			{
				handle3 = (KuroEffectSystem.<>O.<1>__OnSetNiagaraQuality = new Action(KuroEffectSystem.OnSetNiagaraQuality));
			}
			instance3.Remove(name3, handle3);
			EventSystem instance4 = EventSystem.Instance;
			EEventName name4 = EEventName.SetNiagaraQuality;
			Action handle4;
			if ((handle4 = KuroEffectSystem.<>O.<1>__OnSetNiagaraQuality) == null)
			{
				handle4 = (KuroEffectSystem.<>O.<1>__OnSetNiagaraQuality = new Action(KuroEffectSystem.OnSetNiagaraQuality));
			}
			instance4.Remove(name4, handle4);
			EventSystem instance5 = EventSystem.Instance;
			EEventName name5 = EEventName.TriggerUiTimeDilation;
			Action handle5;
			if ((handle5 = KuroEffectSystem.<>O.<0>__OnTimeScaleChange) == null)
			{
				handle5 = (KuroEffectSystem.<>O.<0>__OnTimeScaleChange = new Action(KuroEffectSystem.OnTimeScaleChange));
			}
			instance5.Remove(name5, handle5);
			this.UltraSkillStateWatcher.Clear();
			this.PreviewInitState = false;
			EffectEnvironment.Instance.GameTimeInSeconds = 0.0;
			foreach (KuroEffectHandle kuroEffectHandle in this.EffectHandleMap.Values)
			{
				kuroEffectHandle.Clear(false);
			}
			this.EffectHandleMap.Clear();
			UKuroEffectSystemFunctionLibrary.Clear();
			if (Info.Instance.IsGameRunning())
			{
				UKuroTimerSystemFunctionLibrary.Clear();
				UKuroResourceSystemFunctionLibrary.Clear();
			}
			return true;
		}

		// Token: 0x0603E08B RID: 254091 RVA: 0x011FF008 File Offset: 0x011FD208
		public bool ClearPool()
		{
			UKuroEffectSystemFunctionLibrary.ClearPool(false);
			return true;
		}

		// Token: 0x0603E08C RID: 254092 RVA: 0x011FF011 File Offset: 0x011FD211
		private static void OnGlobalUiSceneStateChanged(EKuroUI3DState state)
		{
			UKuroEffectSystemFunctionLibrary.OnUiSceneStateChange(state);
		}

		// Token: 0x0603E08D RID: 254093 RVA: 0x011FF019 File Offset: 0x011FD219
		private static void OnSetGamePaused(bool paused)
		{
			UKuroEffectSystemFunctionLibrary.OnTickSystemPausedChange(paused);
		}

		// Token: 0x0603E08E RID: 254094 RVA: 0x011FF024 File Offset: 0x011FD224
		private void OnFormationLoaded()
		{
			if (this.SceneTeamItems.Num() == 0)
			{
				this.SceneTeamItems.AddZeroed(4);
			}
			List<SceneTeamItem> teamItems = SceneTeamModel.Instance.GetTeamItems(false);
			for (int i = 0; i < 4; i++)
			{
				if (i < teamItems.Count)
				{
					SceneTeamItem sceneTeamItem = teamItems[i];
					EntityHandle entityHandle = sceneTeamItem.EntityHandle;
					if (sceneTeamItem.IsMyRole() && entityHandle != null)
					{
						this.SceneTeamItems[i] = new FKuroSceneTeamItem
						{
							EntityId = entityHandle.Id,
							IsMyRole = true
						};
					}
					else
					{
						this.SceneTeamItems[i] = default(FKuroSceneTeamItem);
					}
				}
			}
			UKuroEffectSystemFunctionLibrary.OnPlayerEffectContainerFormationLoaded(this.SceneTeamItems);
		}

		// Token: 0x0603E08F RID: 254095 RVA: 0x011FF0D0 File Offset: 0x011FD2D0
		public bool InitializeWithPreview(bool refresh)
		{
			if (Info.Instance.IsGameRunning())
			{
				return true;
			}
			if (!refresh && this.PreviewInitState)
			{
				return true;
			}
			if (refresh && this.PreviewInitState && UKuroEffectSystemFunctionLibrary.HasInitialize())
			{
				this.CreateEffectSpecMappingWithJson(true);
				TArray<FKuroEffectSpecData> specDataArray = new TArray<FKuroEffectSpecData>();
				TArray<FKuroEffectSpecChildData> specChildDataArray = new TArray<FKuroEffectSpecChildData>();
				this.UpdateFEffectSystemSpecConfig(specDataArray, specChildDataArray, true);
				UKuroEffectSystemFunctionLibrary.RefreshEffectForSpecData(specDataArray, specChildDataArray, false);
				return true;
			}
			if (this.HasInitialize)
			{
				Log.Instance.Error(ELogModule.RenderEffect, ELogAuthor.WLJ, "[特效框架]InitializeWithPreview时 FEffectSystem还未Clear,非法", default(ReadOnlySpan<ValueTuple<string, object>>));
				return true;
			}
			this.PreviewInitState = true;
			return this.InitFEffectSystem(true, true);
		}

		// Token: 0x0603E090 RID: 254096 RVA: 0x011FF168 File Offset: 0x011FD368
		private void CreateEffectSpecMappingWithDb()
		{
			this.EffectForSpecArray.Clear();
			this.EffectForSpecDbCacheArray.Clear();
			IReadOnlyList<EffectSpecData> configList = ConfigEffectSpecDataGetAll.GetConfigList(false);
			if (configList != null)
			{
				foreach (EffectSpecData item in configList)
				{
					this.EffectForSpecDbCacheArray.Add(item);
				}
			}
		}

		// Token: 0x0603E091 RID: 254097 RVA: 0x011FF1D8 File Offset: 0x011FD3D8
		private void CreateEffectSpecMappingWithJson(bool withEditor = false)
		{
		}

		// Token: 0x0603E092 RID: 254098 RVA: 0x011FF1E8 File Offset: 0x011FD3E8
		private void UpdateFEffectSystemSpecConfig(TArray<FKuroEffectSpecData> specDataArray, TArray<FKuroEffectSpecChildData> specChildDataArray, bool withEditor = false)
		{
			if (withEditor)
			{
				foreach (SpecData specData in this.EffectForSpecArray)
				{
					FKuroEffectSpecData value = new FKuroEffectSpecData
					{
						Id = specData.Id,
						SpecType = specData.SpecType,
						EffectRegularType = (byte)specData.EffectRegularType,
						LifeTime = specData.LifeTime
					};
					specDataArray.Add(value);
					if (specData.Children.Count > 0)
					{
						FKuroEffectSpecChildData fkuroEffectSpecChildData = new FKuroEffectSpecChildData();
						fkuroEffectSpecChildData.Id = specData.Id;
						foreach (int value2 in specData.Children)
						{
							fkuroEffectSpecChildData.Children.Add(value2);
						}
						specChildDataArray.Add(fkuroEffectSpecChildData);
					}
				}
				return;
			}
			foreach (EffectSpecData effectSpecData in this.EffectForSpecDbCacheArray)
			{
				FKuroEffectSpecData value3 = new FKuroEffectSpecData
				{
					Id = effectSpecData.Id,
					SpecType = (byte)effectSpecData.SpecType,
					EffectRegularType = (byte)effectSpecData.EffectRegularType,
					LifeTime = (float)effectSpecData.LifeTime
				};
				specDataArray.Add(value3);
				if (effectSpecData.ChildrenLength > 0)
				{
					FKuroEffectSpecChildData fkuroEffectSpecChildData2 = new FKuroEffectSpecChildData();
					fkuroEffectSpecChildData2.Id = effectSpecData.Id;
					foreach (int value4 in effectSpecData.ChildrenIter())
					{
						fkuroEffectSpecChildData2.Children.Add(value4);
					}
					specChildDataArray.Add(fkuroEffectSpecChildData2);
				}
			}
		}

		// Token: 0x0603E093 RID: 254099 RVA: 0x011FF3EC File Offset: 0x011FD5EC
		public void Tick(float delta)
		{
			this.CheckEffectOwnerInterval -= delta;
			if (this.CheckEffectOwnerInterval < 0f)
			{
				this.CheckEffectOwnerInterval = 60000f;
				using (PoolArray<KuroEffectHandle> poolArray = this.EffectHandleMap.Values.ToPoolArray<KuroEffectHandle>())
				{
					foreach (KuroEffectHandle kuroEffectHandle in poolArray)
					{
						if (kuroEffectHandle.IsLoop && !kuroEffectHandle.CheckOwner())
						{
							this.StopEffectById(kuroEffectHandle.Id, "CheckOwner Failed", true, null);
						}
					}
				}
			}
		}

		// Token: 0x0603E094 RID: 254100 RVA: 0x011FF4B4 File Offset: 0x011FD6B4
		private static void OnTimeScaleChange()
		{
			UKuroEffectSystemFunctionLibrary.OnGlobalTimeScaleChange();
		}

		// Token: 0x0603E095 RID: 254101 RVA: 0x011FF4BC File Offset: 0x011FD6BC
		private static void OpenNiagaraDownSampling()
		{
			Log.Instance.Info(ELogModule.RenderEffect, ELogAuthor.WLJ, "Open Niagara Down Sampling", default(ReadOnlySpan<ValueTuple<string, object>>));
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "Kuro.Niagara.SystemSimulation.TickDeltaTime 0.033", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "Kuro.Niagara.SystemSimulation.SpawnAlignment 0", null);
		}

		// Token: 0x0603E096 RID: 254102 RVA: 0x011FF508 File Offset: 0x011FD708
		private static void CloseNiagaraDownSampling()
		{
			Log.Instance.Info(ELogModule.RenderEffect, ELogAuthor.WLJ, "Close Niagara Down Sampling", default(ReadOnlySpan<ValueTuple<string, object>>));
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "Kuro.Niagara.SystemSimulation.TickDeltaTime -1", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "Kuro.Niagara.SystemSimulation.SpawnAlignment 0", null);
		}

		// Token: 0x0603E097 RID: 254103 RVA: 0x011FF554 File Offset: 0x011FD754
		private static void OnSetNiagaraQuality()
		{
			int? currentValue = GameSettingsManager.Instance.GetCurrentValue(EFunction.NIAGARAQUALITY, true, true);
			if (currentValue == null)
			{
				return;
			}
			if (!Info.Instance.IsPcPlatform())
			{
				int? num = currentValue;
				int num2 = 2;
				if (num.GetValueOrDefault() < num2 & num != null)
				{
					KuroEffectSystem.OpenNiagaraDownSampling();
					return;
				}
				KuroEffectSystem.CloseNiagaraDownSampling();
				return;
			}
			else
			{
				int? num = currentValue;
				int num2 = 1;
				if (num.GetValueOrDefault() < num2 & num != null)
				{
					KuroEffectSystem.OpenNiagaraDownSampling();
					return;
				}
				KuroEffectSystem.CloseNiagaraDownSampling();
				return;
			}
		}

		// Token: 0x0603E098 RID: 254104 RVA: 0x011FF5D0 File Offset: 0x011FD7D0
		public int SpawnEffectWithActor(UObject worldContext, [Nullable(2)] AActor actor, string path, string reason, bool autoPlay = true, [Nullable(2)] EffectContext context = null, bool isExternalActor = true, EEffectType effectType = EEffectType.Scene)
		{
			FKuroEffectContext fkuroEffectContext = KuroEffectSystem.CreateFEffectContext(context);
			FKuroEffectContext fkuroEffectContext2 = fkuroEffectContext ?? new FKuroEffectContext();
			int num = UKuroEffectSystemFunctionLibrary.SpawnEffectWithActor(worldContext, actor, path, reason, fkuroEffectContext2, autoPlay, isExternalActor, (byte)effectType);
			if (!this.IsValid(num))
			{
				return 0;
			}
			if (this.EffectHandleMap.ContainsKey(num))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderEffect;
				ELogAuthor author = ELogAuthor.WLJ;
				string message = "[特效框架]SpawnEffectWithActor 生成了一个已经存在的effectId";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", num);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return 0;
			}
			KuroEffectHandle kuroEffectHandle = new KuroEffectHandle();
			kuroEffectHandle.Init(context, null, null, null);
			this.EffectHandleMap.Add(num, kuroEffectHandle);
			kuroEffectHandle.OnAfterSpawn(num);
			return num;
		}

		// Token: 0x0603E099 RID: 254105 RVA: 0x011FF674 File Offset: 0x011FD874
		public void RemoveKuroEffectHandle(int effectId)
		{
			KuroEffectHandle kuroEffectHandle;
			if (this.EffectHandleMap.Remove(effectId, out kuroEffectHandle))
			{
				kuroEffectHandle.Clear(true);
				this.EffectActorHandleMap.Remove(effectId);
				this.EffectNiagaraHandleMap.Remove(effectId);
			}
		}

		// Token: 0x0603E09A RID: 254106 RVA: 0x011FF6B2 File Offset: 0x011FD8B2
		public int GetEffectLruCount(string path)
		{
			return UKuroEffectSystemFunctionLibrary.GetEffectLruCount(path);
		}

		// Token: 0x0603E09B RID: 254107 RVA: 0x011FF6BA File Offset: 0x011FD8BA
		public int GetEffectLruCapacity()
		{
			return UKuroEffectSystemFunctionLibrary.GetEffectLruCapacity();
		}

		// Token: 0x0603E09C RID: 254108 RVA: 0x011FF6C1 File Offset: 0x011FD8C1
		public void SetEffectLruCapacity(int capacity)
		{
			UKuroEffectSystemFunctionLibrary.SetEffectLruCapacity(capacity);
		}

		// Token: 0x0603E09D RID: 254109 RVA: 0x011FF6C9 File Offset: 0x011FD8C9
		public int GetEffectLruSize()
		{
			return UKuroEffectSystemFunctionLibrary.GetEffectLruSize();
		}

		// Token: 0x0603E09E RID: 254110 RVA: 0x011FF6D0 File Offset: 0x011FD8D0
		[NullableContext(2)]
		public int SpawnUnloopedEffect(UObject worldContext, in FTransformDouble? transform, string path, [Nullable(1)] string reason, EffectContext context = null, EEffectType effectType = EEffectType.Scene, Action<int> beforeInitCallback = null, Action<ELoadEffectResult, int> callback = null, Action<int> beforePlayCallback = null, bool prepare = false, bool forceCreateActor = false)
		{
			if (!this.HasInitialize)
			{
				return 0;
			}
			if (path == null)
			{
				return 0;
			}
			KuroEffectHandle kuroEffectHandle = new KuroEffectHandle();
			kuroEffectHandle.Init(context, beforeInitCallback, callback, beforePlayCallback);
			FKuroEffectContext fkuroEffectContext = KuroEffectSystem.CreateFEffectContext(context);
			FKuroEffectBeforeInitCallback beforeInitDelegate = null;
			if (beforeInitCallback != null)
			{
				beforeInitDelegate = DelegateUtils.ToManualReleaseDelegate<FKuroEffectBeforeInitCallback>(new Action<int>(kuroEffectHandle.OnBeforeInitCallback));
			}
			FKuroEffectInitCallback initDelegate = null;
			if (callback != null)
			{
				initDelegate = DelegateUtils.ToManualReleaseDelegate<FKuroEffectInitCallback>(new Action<byte, int>(kuroEffectHandle.OnEffectInitCallback));
			}
			FKuroEffectBeforePlayCallback beforePlayDelegate = DelegateUtils.ToManualReleaseDelegate<FKuroEffectBeforePlayCallback>(new Action<int>(kuroEffectHandle.OnBeforePlayCallback));
			FKuroEffectOnClearCallback clearDelegate = DelegateUtils.ToManualReleaseDelegate<FKuroEffectOnClearCallback>(new Action(kuroEffectHandle.OnInitCallbackClear));
			kuroEffectHandle.OnSpawnDelegatesRegistered(beforeInitDelegate, initDelegate, beforePlayDelegate, clearDelegate);
			int num;
			switch (fkuroEffectContext.ContextType)
			{
			case 1:
			{
				FTransformDouble ftransformDouble = transform ?? new FTransformDouble();
				FKuroSkeletalMeshEffectContext fkuroSkeletalMeshEffectContext = (FKuroSkeletalMeshEffectContext)fkuroEffectContext;
				num = UKuroEffectSystemFunctionLibrary.SpawnUnloopedEffectFromSkeletalContext(worldContext, ftransformDouble, path, reason, fkuroSkeletalMeshEffectContext, beforeInitDelegate, initDelegate, beforePlayDelegate, clearDelegate, (byte)effectType, prepare, forceCreateActor);
				break;
			}
			case 2:
			{
				FTransformDouble ftransformDouble = transform ?? new FTransformDouble();
				FKuroEffectAudioContext fkuroEffectAudioContext = (FKuroEffectAudioContext)fkuroEffectContext;
				num = UKuroEffectSystemFunctionLibrary.SpawnUnloopedEffectFromAudioContext(worldContext, ftransformDouble, path, reason, fkuroEffectAudioContext, beforeInitDelegate, initDelegate, beforePlayDelegate, clearDelegate, (byte)effectType, prepare, forceCreateActor);
				break;
			}
			case 3:
			{
				FTransformDouble ftransformDouble = transform ?? new FTransformDouble();
				FKuroEffectRuntimeGhostEffectContext fkuroEffectRuntimeGhostEffectContext = (FKuroEffectRuntimeGhostEffectContext)fkuroEffectContext;
				num = UKuroEffectSystemFunctionLibrary.SpawnUnloopedEffectFromGhostContext(worldContext, ftransformDouble, path, reason, fkuroEffectRuntimeGhostEffectContext, beforeInitDelegate, initDelegate, beforePlayDelegate, clearDelegate, (byte)effectType, prepare, forceCreateActor);
				break;
			}
			default:
			{
				FTransformDouble ftransformDouble = transform ?? new FTransformDouble();
				num = UKuroEffectSystemFunctionLibrary.SpawnUnloopedEffect(worldContext, ftransformDouble, path, reason, fkuroEffectContext, beforeInitDelegate, initDelegate, beforePlayDelegate, clearDelegate, (byte)effectType, prepare, forceCreateActor);
				break;
			}
			}
			int num2 = num;
			if (!this.IsValid(num2))
			{
				return 0;
			}
			if (!this.EffectHandleMap.TryAdd(num2, kuroEffectHandle))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderEffect;
				ELogAuthor author = ELogAuthor.WLJ;
				string message = "[特效框架]SpawnUnloopedEffect 生成了一个已经存在的effectId";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", num2);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return 0;
			}
			kuroEffectHandle.OnAfterSpawn(num2);
			return num2;
		}

		// Token: 0x0603E09F RID: 254111 RVA: 0x011FF908 File Offset: 0x011FDB08
		[NullableContext(2)]
		public int SpawnEffect(UObject worldContext, in FTransformDouble? transform, string path, [Nullable(1)] string reason, EffectContext context = null, EEffectType effectType = EEffectType.Scene, Action<int> beforeInitCallback = null, Action<ELoadEffectResult, int> callback = null, Action<int> beforePlayCallback = null, bool prepare = false, bool forceCreateActor = false)
		{
			if (!this.HasInitialize)
			{
				return 0;
			}
			if (path == null)
			{
				return 0;
			}
			KuroEffectHandle kuroEffectHandle = new KuroEffectHandle();
			kuroEffectHandle.Init(context, beforeInitCallback, callback, beforePlayCallback);
			FKuroEffectContext fkuroEffectContext = KuroEffectSystem.CreateFEffectContext(context);
			FKuroEffectBeforeInitCallback beforeInitDelegate = null;
			if (beforeInitCallback != null)
			{
				beforeInitDelegate = DelegateUtils.ToManualReleaseDelegate<FKuroEffectBeforeInitCallback>(new Action<int>(kuroEffectHandle.OnBeforeInitCallback));
			}
			FKuroEffectInitCallback initDelegate = null;
			if (callback != null)
			{
				initDelegate = DelegateUtils.ToManualReleaseDelegate<FKuroEffectInitCallback>(new Action<byte, int>(kuroEffectHandle.OnEffectInitCallback));
			}
			FKuroEffectBeforePlayCallback beforePlayDelegate = DelegateUtils.ToManualReleaseDelegate<FKuroEffectBeforePlayCallback>(new Action<int>(kuroEffectHandle.OnBeforePlayCallback));
			FKuroEffectOnClearCallback clearDelegate = DelegateUtils.ToManualReleaseDelegate<FKuroEffectOnClearCallback>(new Action(kuroEffectHandle.OnInitCallbackClear));
			kuroEffectHandle.OnSpawnDelegatesRegistered(beforeInitDelegate, initDelegate, beforePlayDelegate, clearDelegate);
			int num;
			switch (fkuroEffectContext.ContextType)
			{
			case 1:
			{
				FTransformDouble ftransformDouble = transform ?? new FTransformDouble();
				FKuroSkeletalMeshEffectContext fkuroSkeletalMeshEffectContext = (FKuroSkeletalMeshEffectContext)fkuroEffectContext;
				num = UKuroEffectSystemFunctionLibrary.SpawnEffectFromSkeletalContext(worldContext, ftransformDouble, path, reason, fkuroSkeletalMeshEffectContext, beforeInitDelegate, initDelegate, beforePlayDelegate, clearDelegate, (byte)effectType, prepare, forceCreateActor);
				break;
			}
			case 2:
			{
				FTransformDouble ftransformDouble = transform ?? new FTransformDouble();
				FKuroEffectAudioContext fkuroEffectAudioContext = (FKuroEffectAudioContext)fkuroEffectContext;
				num = UKuroEffectSystemFunctionLibrary.SpawnEffectFromAudioContext(worldContext, ftransformDouble, path, reason, fkuroEffectAudioContext, beforeInitDelegate, initDelegate, beforePlayDelegate, clearDelegate, (byte)effectType, prepare, forceCreateActor);
				break;
			}
			case 3:
			{
				FTransformDouble ftransformDouble = transform ?? new FTransformDouble();
				FKuroEffectRuntimeGhostEffectContext fkuroEffectRuntimeGhostEffectContext = (FKuroEffectRuntimeGhostEffectContext)fkuroEffectContext;
				num = UKuroEffectSystemFunctionLibrary.SpawnEffectFromGhostContext(worldContext, ftransformDouble, path, reason, fkuroEffectRuntimeGhostEffectContext, beforeInitDelegate, initDelegate, beforePlayDelegate, clearDelegate, (byte)effectType, prepare, forceCreateActor);
				break;
			}
			default:
			{
				FTransformDouble ftransformDouble = transform ?? new FTransformDouble();
				num = UKuroEffectSystemFunctionLibrary.SpawnEffect(worldContext, ftransformDouble, path, reason, fkuroEffectContext, beforeInitDelegate, initDelegate, beforePlayDelegate, clearDelegate, (byte)effectType, prepare, forceCreateActor);
				break;
			}
			}
			int num2 = num;
			if (!this.IsValid(num2))
			{
				return 0;
			}
			if (!this.EffectHandleMap.TryAdd(num2, kuroEffectHandle))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderEffect;
				ELogAuthor author = ELogAuthor.WLJ;
				string message = "[特效框架]SpawnEffect 生成了一个已经存在的effectId";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", num2);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return 0;
			}
			kuroEffectHandle.OnAfterSpawn(num2);
			return num2;
		}

		// Token: 0x0603E0A0 RID: 254112 RVA: 0x011FFB40 File Offset: 0x011FDD40
		public void DynamicRegisterSpawnCallback(int effectId, Action<ELoadEffectResult, int> callback)
		{
			if (!this.HasInitialize)
			{
				return;
			}
			KuroEffectHandle kuroEffectHandle;
			if (this.EffectHandleMap.TryGetValue(effectId, out kuroEffectHandle))
			{
				kuroEffectHandle.RegisterDynamicEffectInitCallback(callback);
			}
		}

		// Token: 0x0603E0A1 RID: 254113 RVA: 0x011FFB70 File Offset: 0x011FDD70
		public void AddFinishCallback(int effectId, Action<int> callback)
		{
			if (!this.HasInitialize)
			{
				return;
			}
			KuroEffectHandle kuroEffectHandle;
			if (this.EffectHandleMap.TryGetValue(effectId, out kuroEffectHandle))
			{
				kuroEffectHandle.AddFinishCallback(callback);
			}
		}

		// Token: 0x0603E0A2 RID: 254114 RVA: 0x011FFBA0 File Offset: 0x011FDDA0
		public void RemoveFinishCallback(int effectId, Action<int> callback)
		{
			if (!this.HasInitialize)
			{
				return;
			}
			KuroEffectHandle kuroEffectHandle;
			if (this.EffectHandleMap.TryGetValue(effectId, out kuroEffectHandle))
			{
				kuroEffectHandle.RemoveFinishCallback(callback);
			}
		}

		// Token: 0x0603E0A3 RID: 254115 RVA: 0x011FFBCE File Offset: 0x011FDDCE
		public void ForceCheckPendingInit(int handle)
		{
			UKuroEffectSystemFunctionLibrary.ForceCheckPendingInit(handle);
		}

		// Token: 0x0603E0A4 RID: 254116 RVA: 0x011FFBD6 File Offset: 0x011FDDD6
		[NullableContext(2)]
		public void SetEffectHidden(int handle, bool bHidden, string reason = null, bool isLogic = false)
		{
			UKuroEffectSystemFunctionLibrary.SetEffectHidden(handle, bHidden, reason ?? string.Empty, isLogic);
		}

		// Token: 0x0603E0A5 RID: 254117 RVA: 0x011FFBEB File Offset: 0x011FDDEB
		public bool StopEffectById(int handle, string reason, bool immediately, bool? destroyActor = null)
		{
			return UKuroEffectSystemFunctionLibrary.StopEffectById(handle, reason, immediately, destroyActor.GetValueOrDefault());
		}

		// Token: 0x0603E0A6 RID: 254118 RVA: 0x011FFBFC File Offset: 0x011FDDFC
		public bool IsValid(int id)
		{
			return UKuroEffectSystemFunctionLibrary.IsEffectValid(id);
		}

		// Token: 0x0603E0A7 RID: 254119 RVA: 0x011FFC04 File Offset: 0x011FDE04
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public OneOf<KuroEffectActorHandle, AActor> GetEffectActor(int id)
		{
			if (id == 0)
			{
				return default(OneOf<KuroEffectActorHandle, AActor>);
			}
			if (UKuroEffectSystemFunctionLibrary.IsEffectActorValid(id))
			{
				AActor sureEffectActor = this.GetSureEffectActor(id);
				if (sureEffectActor == null)
				{
					return default(OneOf<KuroEffectActorHandle, AActor>);
				}
				return sureEffectActor;
			}
			else
			{
				KuroEffectActorHandle value;
				if (this.EffectActorHandleMap.TryGetValue(id, out value))
				{
					return value;
				}
				KuroEffectActorHandle value2 = new KuroEffectActorHandle(id);
				this.EffectActorHandleMap.Add(id, value2);
				return value2;
			}
		}

		// Token: 0x0603E0A8 RID: 254120 RVA: 0x011FFC73 File Offset: 0x011FDE73
		[NullableContext(2)]
		public AActor GetSureEffectActor(int id)
		{
			return UKuroEffectSystemFunctionLibrary.GetSureEffectActor(id);
		}

		// Token: 0x0603E0A9 RID: 254121 RVA: 0x011FFC7C File Offset: 0x011FDE7C
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public OneOf<KuroEffectNiagaraComponentHandle, UNiagaraComponent> GetNiagaraComponent(int id)
		{
			if (id == 0)
			{
				return default(OneOf<KuroEffectNiagaraComponentHandle, UNiagaraComponent>);
			}
			OneOf<KuroEffectNiagaraComponentHandle, UNiagaraComponent> result = default(OneOf<KuroEffectNiagaraComponentHandle, UNiagaraComponent>);
			if (!UKuroEffectSystemFunctionLibrary.HasNiagaraComponentHandle(id))
			{
				result = this.GetSureNiagaraComponent(id);
			}
			if (!result.HasValue)
			{
				KuroEffectNiagaraComponentHandle value;
				if (this.EffectNiagaraHandleMap.TryGetValue(id, out value))
				{
					return value;
				}
				KuroEffectNiagaraComponentHandle value2 = new KuroEffectNiagaraComponentHandle(id);
				this.EffectNiagaraHandleMap.Add(id, value2);
				result = value2;
			}
			return result;
		}

		// Token: 0x0603E0AA RID: 254122 RVA: 0x011FFCEF File Offset: 0x011FDEEF
		[NullableContext(2)]
		public UNiagaraComponent GetSureNiagaraComponent(int id)
		{
			return UKuroEffectSystemFunctionLibrary.GetSureNiagaraComponent(id);
		}

		// Token: 0x0603E0AB RID: 254123 RVA: 0x011FFCF8 File Offset: 0x011FDEF8
		public void ReplayEffect(int id, string reason, in FTransformDouble? transform)
		{
			FTransformDouble ftransformDouble = transform ?? new FTransformDouble();
			UKuroEffectSystemFunctionLibrary.ReplayEffect(id, reason, ftransformDouble, transform != null);
		}

		// Token: 0x0603E0AC RID: 254124 RVA: 0x011FFD33 File Offset: 0x011FDF33
		public bool IsPlaying(int id)
		{
			return UKuroEffectSystemFunctionLibrary.IsPlaying(id);
		}

		// Token: 0x0603E0AD RID: 254125 RVA: 0x011FFD3B File Offset: 0x011FDF3B
		public void SetHandleLifeCycle(int id, float time)
		{
			UKuroEffectSystemFunctionLibrary.SetHandleLifeCycle(id, time);
		}

		// Token: 0x0603E0AE RID: 254126 RVA: 0x011FFD44 File Offset: 0x011FDF44
		public void SetTimeScale(int id, float timeScale, bool ignoreGlobalTimeScale = false)
		{
			UKuroEffectSystemFunctionLibrary.SetTimeScale(id, timeScale, ignoreGlobalTimeScale);
		}

		// Token: 0x0603E0AF RID: 254127 RVA: 0x011FFD4E File Offset: 0x011FDF4E
		public void SetAdditionTimeScale(int sourceType, int id, float timeScale)
		{
			UKuroEffectSystemFunctionLibrary.SetAdditionTimeScale(sourceType, id, timeScale);
		}

		// Token: 0x0603E0B0 RID: 254128 RVA: 0x011FFD58 File Offset: 0x011FDF58
		public void SetAdditionTimeScaleEnable(int sourceType, bool enable)
		{
			UKuroEffectSystemFunctionLibrary.SetAdditionTimeScaleEnable(sourceType, enable);
		}

		// Token: 0x0603E0B1 RID: 254129 RVA: 0x011FFD61 File Offset: 0x011FDF61
		public bool GetAdditionTimeScaleEnable(int sourceType)
		{
			return UKuroEffectSystemFunctionLibrary.GetAdditionTimeScaleEnable(sourceType);
		}

		// Token: 0x0603E0B2 RID: 254130 RVA: 0x011FFD69 File Offset: 0x011FDF69
		public void FreezeHandle(int id, bool freeze, bool force = false)
		{
			UKuroEffectSystemFunctionLibrary.FreezeHandle(id, freeze, force);
		}

		// Token: 0x0603E0B3 RID: 254131 RVA: 0x011FFD73 File Offset: 0x011FDF73
		public bool IsHandleFreeze(int id)
		{
			return UKuroEffectSystemFunctionLibrary.IsHandleFreeze(id);
		}

		// Token: 0x0603E0B4 RID: 254132 RVA: 0x011FFD7B File Offset: 0x011FDF7B
		public bool HandleSeekToTime(int id, float time, bool autoLoop, bool force = false)
		{
			return UKuroEffectSystemFunctionLibrary.HandleSeekToTime(id, time, autoLoop, force);
		}

		// Token: 0x0603E0B5 RID: 254133 RVA: 0x011FFD87 File Offset: 0x011FDF87
		public void HandleSeekToTimeWithProcess(int id, float time, bool seekContinue = false, float delta = -1f)
		{
			UKuroEffectSystemFunctionLibrary.HandleSeekToTimeWithProcess(id, time, seekContinue, delta);
		}

		// Token: 0x0603E0B6 RID: 254134 RVA: 0x011FFD93 File Offset: 0x011FDF93
		public float GetSeekToTargetTime(int id)
		{
			return UKuroEffectSystemFunctionLibrary.GetSeekToTargetTime(id);
		}

		// Token: 0x0603E0B7 RID: 254135 RVA: 0x011FFD9C File Offset: 0x011FDF9C
		public void SetEffectNotRecord(int id, bool notRecord = true)
		{
			KuroEffectHandle kuroEffectHandle;
			if (this.EffectHandleMap.TryGetValue(id, out kuroEffectHandle))
			{
				kuroEffectHandle.SetNotRecord(notRecord);
			}
		}

		// Token: 0x0603E0B8 RID: 254136 RVA: 0x011FFDC0 File Offset: 0x011FDFC0
		public string GetPath(int id)
		{
			return UKuroEffectSystemFunctionLibrary.GetPath(id);
		}

		// Token: 0x0603E0B9 RID: 254137 RVA: 0x011FFDC8 File Offset: 0x011FDFC8
		public void SetEffectDataByNiagaraParam(int id, SNiagaraParam niagaraParam, bool resetPassTime)
		{
			if (!this.IsValid(id))
			{
				return;
			}
			EffectModelNiagara effectModelNiagara = UKuroEffectSystemFunctionLibrary.GetEffectModel(id) as EffectModelNiagara;
			if (effectModelNiagara != null)
			{
				effectModelNiagara.FloatParameters = niagaraParam.FloatParameters;
				effectModelNiagara.VectorParameters = niagaraParam.VectorParameters;
				effectModelNiagara.ColorParameters = niagaraParam.ColorParameters;
			}
			UKuroEffectSystemFunctionLibrary.SetThreeStageTime(id, niagaraParam.StartTime, niagaraParam.LoopTime, niagaraParam.EndTime, resetPassTime);
		}

		// Token: 0x0603E0BA RID: 254138 RVA: 0x011FFE2C File Offset: 0x011FE02C
		[NullableContext(2)]
		public void SetEffectParameterNiagara(int id, EffectParameterNiagara parameter)
		{
			if (parameter == null)
			{
				return;
			}
			FKuroEffectNiagaraParametersStruct parameters = new FKuroEffectNiagaraParametersStruct();
			parameter.ToKuroEffectParameterNiagara(parameters);
			UKuroEffectSystemFunctionLibrary.SetEffectParameterNiagara(id, parameters);
		}

		// Token: 0x0603E0BB RID: 254139 RVA: 0x011FFE52 File Offset: 0x011FE052
		public void SetEffectDataFloatConstParam(int id, in FName paramName, float value)
		{
			UKuroEffectSystemFunctionLibrary.SetEffectDataFloatConstParam(id, paramName, value);
		}

		// Token: 0x0603E0BC RID: 254140 RVA: 0x011FFE61 File Offset: 0x011FE061
		public void SetEffectExtraState(int effectId, int extraState)
		{
			UKuroEffectSystemFunctionLibrary.SetEffectExtraState(effectId, extraState);
		}

		// Token: 0x0603E0BD RID: 254141 RVA: 0x011FFE6A File Offset: 0x011FE06A
		public void SetEffectIgnoreVisibilityOptimize(int effectId, bool ignore)
		{
			UKuroEffectSystemFunctionLibrary.SetEffectIgnoreVisibilityOptimize(effectId, ignore);
		}

		// Token: 0x0603E0BE RID: 254142 RVA: 0x011FFE73 File Offset: 0x011FE073
		public void SetEffectStoppingTime(int effectId, bool stoppingTime, EEffectStoppingTimeSource source = EEffectStoppingTimeSource.ScenePaused)
		{
			UKuroEffectSystemFunctionLibrary.SetEffectStoppingTime(effectId, stoppingTime, (int)source);
		}

		// Token: 0x0603E0BF RID: 254143 RVA: 0x011FFE7D File Offset: 0x011FE07D
		public void SetEffectStoppingTimeFromEntity(int entityId, bool stoppingTime, EEffectStoppingTimeSource source = EEffectStoppingTimeSource.ScenePaused)
		{
			UKuroEffectSystemFunctionLibrary.SetEffectStoppingTimeFromEntity(entityId, stoppingTime, (int)source);
		}

		// Token: 0x0603E0C0 RID: 254144 RVA: 0x011FFE87 File Offset: 0x011FE087
		public void SetEntityUltraSkillState(int entityId, bool inUltraSkill)
		{
			UKuroEffectSystemFunctionLibrary.SetEntityUltraSkillState(entityId, inUltraSkill);
		}

		// Token: 0x0603E0C1 RID: 254145 RVA: 0x011FFE90 File Offset: 0x011FE090
		public bool IsEntityInUltraSkill(int entityId)
		{
			return UKuroEffectSystemFunctionLibrary.IsEntityInUltraSkill(entityId);
		}

		// Token: 0x0603E0C2 RID: 254146 RVA: 0x011FFE98 File Offset: 0x011FE098
		public void ClearUltraSkillState()
		{
			UKuroEffectSystemFunctionLibrary.ClearUltraSkillState();
		}

		// Token: 0x0603E0C3 RID: 254147 RVA: 0x011FFE9F File Offset: 0x011FE09F
		public float GlobalStoppingPlayTime(EEffectStoppingTimeSource source = EEffectStoppingTimeSource.ScenePaused)
		{
			return UKuroEffectSystemFunctionLibrary.GlobalStoppingPlayTime((int)source);
		}

		// Token: 0x0603E0C4 RID: 254148 RVA: 0x011FFEA7 File Offset: 0x011FE0A7
		public bool GlobalStoppingTime(EEffectStoppingTimeSource source = EEffectStoppingTimeSource.ScenePaused)
		{
			return UKuroEffectSystemFunctionLibrary.GlobalStoppingTime((int)source);
		}

		// Token: 0x0603E0C5 RID: 254149 RVA: 0x011FFEAF File Offset: 0x011FE0AF
		public void SetGlobalStoppingTime(bool stoppingTime, float playTime, EEffectStoppingTimeSource source = EEffectStoppingTimeSource.ScenePaused)
		{
			UKuroEffectSystemFunctionLibrary.SetGlobalStoppingTime(stoppingTime, playTime, (int)source);
		}

		// Token: 0x0603E0C6 RID: 254150 RVA: 0x011FFEBC File Offset: 0x011FE0BC
		public void AttachToEffectSkeletalMesh(int id, AActor attachActor, in FName? socketName, EAttachmentRule transformRule)
		{
			UKuroEffectSystemFunctionLibrary.AttachToEffectSkeletalMesh(id, attachActor, socketName ?? FName.NAME_None, transformRule);
		}

		// Token: 0x0603E0C7 RID: 254151 RVA: 0x011FFEF0 File Offset: 0x011FE0F0
		public void AttachSkeletalMesh(int id, SkeletalMeshEffectContext context)
		{
			FKuroSkeletalMeshEffectContext fkuroSkeletalMeshEffectContext = KuroEffectSystem.CreateFEffectContext(context) as FKuroSkeletalMeshEffectContext;
			UKuroEffectSystemFunctionLibrary.AttachSkeletalMesh(id, fkuroSkeletalMeshEffectContext);
		}

		// Token: 0x0603E0C8 RID: 254152 RVA: 0x011FFF14 File Offset: 0x011FE114
		private static FKuroEffectContext CreateFEffectContext([Nullable(2)] EffectContext context)
		{
			FKuroEffectContext fkuroEffectContext = null;
			if (context is EffectRuntimeGhostEffectContext)
			{
				fkuroEffectContext = new FKuroEffectRuntimeGhostEffectContext();
				fkuroEffectContext.ContextType = 3;
			}
			else if (context is EffectAudioContext)
			{
				fkuroEffectContext = new FKuroEffectAudioContext();
				fkuroEffectContext.ContextType = 2;
			}
			else if (context is SkeletalMeshEffectContext)
			{
				fkuroEffectContext = new FKuroSkeletalMeshEffectContext();
				fkuroEffectContext.ContextType = 1;
			}
			else if (context != null)
			{
				fkuroEffectContext = new FKuroEffectContext();
				fkuroEffectContext.ContextType = 0;
			}
			if (fkuroEffectContext != null)
			{
				context.ToKuroEffectContext(fkuroEffectContext);
			}
			else
			{
				fkuroEffectContext = new FKuroEffectContext();
				fkuroEffectContext.ContextType = 0;
			}
			return fkuroEffectContext;
		}

		// Token: 0x0603E0C9 RID: 254153 RVA: 0x011FFF98 File Offset: 0x011FE198
		public void CollectMaterialFloatCurve(int id, in FName key, FKuroCurveFloat value)
		{
			UKuroEffectSystemFunctionLibrary.CollectMaterialFloatCurve(id, key, value);
		}

		// Token: 0x0603E0CA RID: 254154 RVA: 0x011FFFA8 File Offset: 0x011FE1A8
		public void CollectMaterialVectorCurve(int id, in FName key, FKuroCurveVector value)
		{
			UKuroEffectSystemFunctionLibrary.CollectMaterialVectorCurve(id, key, value);
		}

		// Token: 0x0603E0CB RID: 254155 RVA: 0x011FFFB8 File Offset: 0x011FE1B8
		public void CollectMaterialLinearColorCurve(int id, in FName key, FKuroCurveLinearColor value)
		{
			UKuroEffectSystemFunctionLibrary.CollectMaterialLinearColorCurve(id, key, value);
		}

		// Token: 0x0603E0CC RID: 254156 RVA: 0x011FFFC8 File Offset: 0x011FE1C8
		[NullableContext(2)]
		public UEffectModelBase GetEffectModel(int id)
		{
			return UKuroEffectSystemFunctionLibrary.GetEffectModel(id);
		}

		// Token: 0x0603E0CD RID: 254157 RVA: 0x011FFFD0 File Offset: 0x011FE1D0
		public float GetTotalPassTime(int id)
		{
			return UKuroEffectSystemFunctionLibrary.GetTotalPassTime(id);
		}

		// Token: 0x0603E0CE RID: 254158 RVA: 0x011FFFD8 File Offset: 0x011FE1D8
		public float GetPassTime(int id)
		{
			return UKuroEffectSystemFunctionLibrary.GetPassTime(id);
		}

		// Token: 0x0603E0CF RID: 254159 RVA: 0x011FFFE0 File Offset: 0x011FE1E0
		public bool GetHideOnBurstSkill(int id)
		{
			UEffectModelBase effectModel = this.GetEffectModel(id);
			return effectModel != null && effectModel.HideOnBurstSkill;
		}

		// Token: 0x0603E0D0 RID: 254160 RVA: 0x01200000 File Offset: 0x011FE200
		public void RegisterCustomCheckOwnerFunc(int id, Func<int, bool> func)
		{
			KuroEffectHandle kuroEffectHandle;
			if (this.EffectHandleMap.TryGetValue(id, out kuroEffectHandle))
			{
				kuroEffectHandle.OnCustomCheckOwner = func;
			}
		}

		// Token: 0x0603E0D1 RID: 254161 RVA: 0x01200024 File Offset: 0x011FE224
		public void SetEffectQualityLevel(int id, int qualityLevel)
		{
			UKuroEffectSystemFunctionLibrary.SetEffectQualityLevel(id, qualityLevel);
		}

		// Token: 0x0603E0D2 RID: 254162 RVA: 0x01200030 File Offset: 0x011FE230
		public void TickHandleInEditor(int id, float delta)
		{
			UKuroEffectSystemFunctionLibrary.TickHandleInEditor(id, delta);
			KuroEffectHandle kuroEffectHandle;
			if (!Info.Instance.IsGameRunning() && this.EffectHandleMap.TryGetValue(id, out kuroEffectHandle) && kuroEffectHandle.IsLoop && !kuroEffectHandle.CheckOwner() && this.GetSureEffectActor(kuroEffectHandle.Id) is BP_EffectPreview_C)
			{
				this.StopEffectById(kuroEffectHandle.Id, "TickInEditor CheckOwner Failed", true, null);
			}
		}

		// Token: 0x0603E0D3 RID: 254163 RVA: 0x0120009F File Offset: 0x011FE29F
		public float GetLastPlayTime(int id)
		{
			return UKuroEffectSystemFunctionLibrary.GetLastPlayTime(id);
		}

		// Token: 0x0603E0D4 RID: 254164 RVA: 0x012000A7 File Offset: 0x011FE2A7
		public float GetLastStopTime(int id)
		{
			return UKuroEffectSystemFunctionLibrary.GetLastStopTime(id);
		}

		// Token: 0x0603E0D5 RID: 254165 RVA: 0x012000AF File Offset: 0x011FE2AF
		public void UpdateBodyEffect(int id, float opacity, bool visible, bool castShadow)
		{
			UKuroEffectSystemFunctionLibrary.UpdateBodyEffect(id, opacity, visible, castShadow);
		}

		// Token: 0x0603E0D6 RID: 254166 RVA: 0x012000BB File Offset: 0x011FE2BB
		public void DebugUpdate(int id, bool dDebugUpdate)
		{
			UKuroEffectSystemFunctionLibrary.DebugUpdate(id, dDebugUpdate);
		}

		// Token: 0x0603E0D7 RID: 254167 RVA: 0x012000C4 File Offset: 0x011FE2C4
		public int GetEffectCount()
		{
			return UKuroEffectSystemFunctionLibrary.GetEffectCount();
		}

		// Token: 0x0603E0D8 RID: 254168 RVA: 0x012000CB File Offset: 0x011FE2CB
		public int GetActiveEffectCount()
		{
			return UKuroEffectSystemFunctionLibrary.GetActiveEffectCount();
		}

		// Token: 0x0603E0D9 RID: 254169 RVA: 0x012000D2 File Offset: 0x011FE2D2
		public void DebugPrintAllErrorEffects()
		{
			UKuroEffectSystemFunctionLibrary.DebugPrintAllErrorEffects();
		}

		// Token: 0x0603E0DA RID: 254170 RVA: 0x012000D9 File Offset: 0x011FE2D9
		public void DebugPrintCurrentImportanceEffects()
		{
			UKuroEffectSystemFunctionLibrary.DebugPrintCurrentImportanceEffects();
		}

		// Token: 0x0603E0DB RID: 254171 RVA: 0x012000E0 File Offset: 0x011FE2E0
		public void DebugPrintEffect()
		{
			UKuroEffectSystemFunctionLibrary.DebugPrintEffect();
		}

		// Token: 0x0603E0DC RID: 254172 RVA: 0x012000E7 File Offset: 0x011FE2E7
		public int GetPlayerEffectLruSize(int pos)
		{
			return UKuroEffectSystemFunctionLibrary.GetPlayerEffectLruSize(pos);
		}

		// Token: 0x0603E0DD RID: 254173 RVA: 0x012000F0 File Offset: 0x011FE2F0
		public void SetEffectStartRecording(global::Vector tempVector, global::Vector centerLocation, float recordDistSquared, Action<int, AActor> onEffectRecorded)
		{
			foreach (KuroEffectHandle kuroEffectHandle in this.EffectHandleMap.Values)
			{
				if (kuroEffectHandle.IsDone())
				{
					UEffectModelBase effectModel = this.GetEffectModel(kuroEffectHandle.Id);
					if (effectModel != null && effectModel.IsValid())
					{
						bool flag = false;
						if (flag)
						{
							Log instance = Log.Instance;
							ELogModule module = ELogModule.Test;
							ELogAuthor author = ELogAuthor.LCZ;
							string message = "Try ";
							ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("effectModel", effectModel);
							instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						}
						if (kuroEffectHandle.GetNotRecord())
						{
							if (flag)
							{
								Log instance2 = Log.Instance;
								ELogModule module2 = ELogModule.Test;
								ELogAuthor author2 = ELogAuthor.LCZ;
								string message2 = "Continue1  ";
								ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("handle.GetIsAnimEffect()", kuroEffectHandle.GetNotRecord());
								instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
							}
						}
						else
						{
							AActor sureEffectActor = this.GetSureEffectActor(kuroEffectHandle.Id);
							if (sureEffectActor != null)
							{
								FVectorDouble fvectorDouble = sureEffectActor.D_K2_GetActorLocation();
								tempVector.FromUeVector(fvectorDouble);
								if (global::Vector.DistSquared(tempVector, centerLocation) > (double)recordDistSquared)
								{
									if (flag)
									{
										Log instance3 = Log.Instance;
										ELogModule module3 = ELogModule.Test;
										ELogAuthor author3 = ELogAuthor.LCZ;
										DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 3);
										defaultInterpolatedStringHandler.AppendLiteral("Continue3 ");
										defaultInterpolatedStringHandler.AppendFormatted(tempVector.ToString());
										defaultInterpolatedStringHandler.AppendLiteral(" ");
										defaultInterpolatedStringHandler.AppendFormatted(centerLocation.ToString());
										defaultInterpolatedStringHandler.AppendLiteral(" ");
										defaultInterpolatedStringHandler.AppendFormatted<float>(recordDistSquared);
										instance3.Warn(module3, author3, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
									}
								}
								else
								{
									onEffectRecorded(kuroEffectHandle.Id, sureEffectActor);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0603E0DE RID: 254174 RVA: 0x012002A8 File Offset: 0x011FE4A8
		public void RefreshEffectSpecData(Dictionary<string, SpecData> specDataMap)
		{
			TArray<FKuroEffectSpecData> tarray = new TArray<FKuroEffectSpecData>();
			TArray<FKuroEffectSpecChildData> tarray2 = new TArray<FKuroEffectSpecChildData>();
			foreach (SpecData specData in specDataMap.Values)
			{
				FKuroEffectSpecData value = new FKuroEffectSpecData
				{
					Id = specData.Id,
					SpecType = specData.SpecType,
					EffectRegularType = (byte)specData.EffectRegularType,
					LifeTime = specData.LifeTime
				};
				tarray.Add(value);
				if (specData.Children.Count > 0)
				{
					FKuroEffectSpecChildData fkuroEffectSpecChildData = new FKuroEffectSpecChildData();
					fkuroEffectSpecChildData.Id = specData.Id;
					foreach (int value2 in specData.Children)
					{
						fkuroEffectSpecChildData.Children.Add(value2);
					}
					tarray2.Add(fkuroEffectSpecChildData);
				}
			}
			UKuroEffectSystemFunctionLibrary.RefreshEffectForSpecData(tarray, tarray2, true);
		}

		// Token: 0x0603E0DF RID: 254175 RVA: 0x012003C8 File Offset: 0x011FE5C8
		[return: Nullable(2)]
		private static UActorComponent SkeletalMeshSpecOnBodyEffectChange(float opacity, [Nullable(2)] UActorComponent renderingComponent, USkeletalMeshComponent skeletalMeshComponent, AActor owner)
		{
			CharRenderingComponent charRenderingComponent = renderingComponent as CharRenderingComponent;
			if (opacity < 1f)
			{
				if (charRenderingComponent == null)
				{
					charRenderingComponent = (owner.GetComponentByClass(CharRenderingComponent.StaticClass()) as CharRenderingComponent);
				}
				if (charRenderingComponent == null)
				{
					TSubclassOf<UActorComponent> @class = CharRenderingComponent.StaticClass();
					bool bManualAttachment = false;
					FTransform ftransform = new FTransform();
					charRenderingComponent = (owner.AddComponentByClass(@class, bManualAttachment, ftransform, false, default(FName)) as CharRenderingComponent);
					charRenderingComponent.Init(GlobalData.IsUiSceneOpen ? ECharacterRenderingType.UI : ECharacterRenderingType.Default);
					charRenderingComponent.SetLogicOwner(owner);
					charRenderingComponent.AddComponentByCase(ECharacterControllerCaseType.BodyCase0, skeletalMeshComponent);
				}
				charRenderingComponent.SetDitherEffect(opacity, ECharacterDitherType.Fight);
			}
			else if (charRenderingComponent != null)
			{
				charRenderingComponent.SetDitherEffect(1f, ECharacterDitherType.Fight);
			}
			return charRenderingComponent;
		}

		// Token: 0x0603E0E0 RID: 254176 RVA: 0x01200464 File Offset: 0x011FE664
		private static UActorComponent SkeletalMeshSpecCreateRenderingComponent([Nullable(2)] UActorComponent renderingComponent, USkeletalMeshComponent skeletalMeshComponent, AActor owner)
		{
			CharRenderingComponent charRenderingComponent = renderingComponent as CharRenderingComponent;
			if (charRenderingComponent == null)
			{
				charRenderingComponent = (owner.GetComponentByClass(CharRenderingComponent.StaticClass()) as CharRenderingComponent);
			}
			if (charRenderingComponent == null)
			{
				TSubclassOf<UActorComponent> @class = CharRenderingComponent.StaticClass();
				bool bManualAttachment = false;
				FTransform ftransform = new FTransform();
				charRenderingComponent = (owner.AddComponentByClass(@class, bManualAttachment, ftransform, false, default(FName)) as CharRenderingComponent);
				charRenderingComponent.Init(GlobalData.IsUiSceneOpen ? ECharacterRenderingType.UI : ECharacterRenderingType.Default);
				charRenderingComponent.SetLogicOwner(owner);
				charRenderingComponent.AddComponentByCase(ECharacterControllerCaseType.BodyCase0, skeletalMeshComponent);
			}
			return charRenderingComponent;
		}

		// Token: 0x0603E0E1 RID: 254177 RVA: 0x012004E0 File Offset: 0x011FE6E0
		private static void SkeletalMeshSpecDestroyRenderingComponent(AActor effectActor, [Nullable(2)] UActorComponent renderingComponent)
		{
			CharRenderingComponent charRenderingComponent = (renderingComponent as CharRenderingComponent) ?? (effectActor.GetComponentByClass(CharRenderingComponent.StaticClass()) as CharRenderingComponent);
			if (charRenderingComponent != null)
			{
				charRenderingComponent.ResetAllRenderingState();
				charRenderingComponent.K2_DestroyComponent(charRenderingComponent);
			}
		}

		// Token: 0x0603E0E2 RID: 254178 RVA: 0x01200520 File Offset: 0x011FE720
		[NullableContext(2)]
		private static AActor EffectHandleGetEntityOwnerActor(int entityId)
		{
			if (entityId == 0)
			{
				return null;
			}
			Entity entity = EntitySystem.Instance.Get(entityId);
			if (entity == null)
			{
				return null;
			}
			CharacterActorComponent component = entity.GetComponent<CharacterActorComponent>();
			if (component == null)
			{
				return null;
			}
			return component.Owner;
		}

		// Token: 0x0603E0E3 RID: 254179 RVA: 0x01200554 File Offset: 0x011FE754
		private static int EffectHandleGetEntityModelConfigId(int entityId)
		{
			if (!Info.Instance.IsGameRunning())
			{
				return 0;
			}
			if (entityId == 0)
			{
				return 0;
			}
			EntityHandle entityById = CreatureModel.Instance.GetEntityById(entityId);
			if (entityById != null && entityById.Valid)
			{
				CreatureDataComponent component = entityById.Entity.GetComponent<CreatureDataComponent>();
				if (component != null)
				{
					SModelConfig modelConfig = component.GetModelConfig();
					if (modelConfig != null)
					{
						return modelConfig.ID;
					}
				}
			}
			return 0;
		}

		// Token: 0x0603E0E4 RID: 254180 RVA: 0x012005B2 File Offset: 0x011FE7B2
		private static FName EffectHandleGetOrAddEffectDynamicGroup(float effectEnableRange)
		{
			return GameBudgetAllocatorConfigCreator.Instance.GetEffectDynamicGroup((uint)effectEnableRange).GroupName;
		}

		// Token: 0x0603E0E5 RID: 254181 RVA: 0x012005C8 File Offset: 0x011FE7C8
		[return: Nullable(2)]
		private static UAkComponent AudioSystemGetAkComponent(bool fromPrimaryRole, AActor effectActor)
		{
			return AudioSystem.Instance.GetAkComponent(effectActor, new FName?(FName.NAME_None), delegate(AActor owner, UAkComponent _)
			{
				GameAudioController.Instance.SetRolePriority(fromPrimaryRole ? ERoleAudioPriorityType.PlayerControl : ERoleAudioPriorityType.OtherControl, owner);
			});
		}

		// Token: 0x0603E0E6 RID: 254182 RVA: 0x01200608 File Offset: 0x011FE808
		private static void AudioSystemExecuteActionStop(int eventHandle, float fadeOutTime)
		{
			AudioSystem.Instance.ExecuteAction(eventHandle, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs
			{
				TransitionDuration = new int?((int)fadeOutTime)
			}));
		}

		// Token: 0x0603E0E7 RID: 254183 RVA: 0x01200640 File Offset: 0x011FE840
		private static int AudioSystemPostEventTransform(string eventName, FTransformDouble transform)
		{
			return AudioSystem.Instance.PostEvent(eventName, new FTransformDouble?(transform), null);
		}

		// Token: 0x0603E0E8 RID: 254184 RVA: 0x01200668 File Offset: 0x011FE868
		private static int AudioSystemPostEventAkComponent(string eventName, [Nullable(2)] UAkComponent akComponent)
		{
			return AudioSystem.Instance.PostEvent(eventName, akComponent, null);
		}

		// Token: 0x0603E0E9 RID: 254185 RVA: 0x0120068C File Offset: 0x011FE88C
		private static bool NiagaraSpecIsNeedQualityBias(int entityId)
		{
			if (!Info.Instance.IsGameRunning())
			{
				return false;
			}
			EntityHandle handle = CharacterModel.Instance.GetHandle(entityId);
			if (handle == null || !handle.Valid)
			{
				return false;
			}
			WorldEntity entity = handle.Entity;
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			if (component.GetEntityType() == EEntityType.Player && !entity.GetComponent<CharacterActorComponent>().IsAutonomousProxy)
			{
				return true;
			}
			if (component.GetEntityType() == EEntityType.Vehicle && !entity.GetComponent<VehicleActorComponent>().IsAutonomousProxy)
			{
				return true;
			}
			int entityId2 = CreatureModel.Instance.GetEntityId(component.GetSummonerId());
			Entity entity2 = EntitySystem.Instance.Get(entityId2);
			CreatureDataComponent creatureDataComponent = (entity2 != null) ? entity2.GetComponent<CreatureDataComponent>() : null;
			return creatureDataComponent != null && creatureDataComponent.GetEntityType() == EEntityType.Player && !entity.GetComponent<CharacterActorComponent>().IsAutonomousProxy;
		}

		// Token: 0x0603E0EA RID: 254186 RVA: 0x0120074C File Offset: 0x011FE94C
		private static bool PostProcessSpecIsNeedPostEffect(int entityId, bool visibleForProtoPlayer)
		{
			if (!Info.Instance.IsGameRunning())
			{
				return true;
			}
			if (visibleForProtoPlayer)
			{
				return true;
			}
			EntityHandle handle = CharacterModel.Instance.GetHandle(entityId);
			if (handle == null || !handle.Valid)
			{
				return true;
			}
			WorldEntity entity = handle.Entity;
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			if (component.GetEntityType() == EEntityType.Player && !entity.GetComponent<CharacterActorComponent>().IsAutonomousProxy)
			{
				return false;
			}
			int entityId2 = CreatureModel.Instance.GetEntityId(component.GetSummonerId());
			Entity entity2 = EntitySystem.Instance.Get(entityId2);
			CreatureDataComponent creatureDataComponent = (entity2 != null) ? entity2.GetComponent<CreatureDataComponent>() : null;
			return creatureDataComponent == null || creatureDataComponent.GetEntityType() != EEntityType.Player || entity.GetComponent<CharacterActorComponent>().IsAutonomousProxy;
		}

		// Token: 0x0603E0EB RID: 254187 RVA: 0x012007F8 File Offset: 0x011FE9F8
		private static bool PostProcessSpecIsDisableInUltraSkill(int entityId)
		{
			if (!Info.Instance.IsGameRunning())
			{
				return true;
			}
			EntityHandle handle = CharacterModel.Instance.GetHandle(entityId);
			if (handle == null || !handle.Valid)
			{
				return true;
			}
			WorldEntity entity = handle.Entity;
			return entity.GetComponent<CreatureDataComponent>().GetEntityType() != EEntityType.Player || !entity.GetComponent<CharacterActorComponent>().IsAutonomousProxy;
		}

		// Token: 0x0603E0EC RID: 254188 RVA: 0x01200856 File Offset: 0x011FEA56
		[NullableContext(2)]
		private static AActor ActorSystemGet([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> ueClass, in FTransformDouble transform)
		{
			return ActorSystem.Instance.Get(ueClass, transform, null, true);
		}

		// Token: 0x0603E0ED RID: 254189 RVA: 0x01200870 File Offset: 0x011FEA70
		private static bool ActorSystemPut(string reason, AActor actor)
		{
			return ActorSystem.Instance.Put(reason, actor, null);
		}

		// Token: 0x0603E0EE RID: 254190 RVA: 0x01200880 File Offset: 0x011FEA80
		private static void EffectSystemSetEffectView(AActor effectActor, int effectId)
		{
			BP_EffectPreview_C bp_EffectPreview_C = effectActor as BP_EffectPreview_C;
			if (bp_EffectPreview_C != null)
			{
				bp_EffectPreview_C.EffectView = effectId;
			}
		}

		// Token: 0x0603E0EF RID: 254191 RVA: 0x012008A0 File Offset: 0x011FEAA0
		private static bool EffectSystemCheckIsNetPlayer(int entityId)
		{
			if (!Info.Instance.IsGameRunning())
			{
				return false;
			}
			EntityHandle entityById = CreatureModel.Instance.GetEntityById(entityId);
			if (entityById == null || !entityById.Valid)
			{
				return false;
			}
			CreatureDataComponent component = entityById.Entity.GetComponent<CreatureDataComponent>();
			return component.GetEntityType() == EEntityType.Player && component.GetPlayerId() != CreatureModel.Instance.GetPlayerId();
		}

		// Token: 0x0603E0F0 RID: 254192 RVA: 0x01200905 File Offset: 0x011FEB05
		private static bool EffectSystemCheckMobileBlackEffect(string path)
		{
			return Info.Instance.IsMobilePlatform() && KuroEffectSystem.MOBILE_EFFECT_BLACK_LIST.Contains(path);
		}

		// Token: 0x0603E0F1 RID: 254193 RVA: 0x01200924 File Offset: 0x011FEB24
		[NullableContext(2)]
		private static CharRenderingComponent FindRenderingComponent(AActor effectActor, USkeletalMeshComponent contextMeshComponent, UObject contextSourceObject, [Nullable(1)] UEffectModelBase effectModel)
		{
			CharRenderingComponent charRenderingComponent = null;
			AActor aactor = (effectActor != null) ? effectActor.GetAttachParentActor() : null;
			if (effectModel.NeedDisableWithActor)
			{
				int num = 0;
				AEffectSystemActor aeffectSystemActor = effectActor as AEffectSystemActor;
				if (aeffectSystemActor != null)
				{
					num = aeffectSystemActor.GetOwnerEntityId();
				}
				if (num > 0)
				{
					Entity entity = EntitySystem.Instance.Get(num);
					object obj;
					if (entity == null)
					{
						obj = null;
					}
					else
					{
						CharacterActorComponent component = entity.GetComponent<CharacterActorComponent>();
						obj = ((component != null) ? component.Owner : null);
					}
					TsBaseCharacter tsBaseCharacter = obj as TsBaseCharacter;
					if (tsBaseCharacter != null)
					{
						return tsBaseCharacter.CharRenderingComponent;
					}
				}
			}
			if (effectModel.LoopTime > 0f || effectModel.NeedDisableWithActor)
			{
				if (contextMeshComponent != null)
				{
					AActor owner = contextMeshComponent.GetOwner();
					charRenderingComponent = (((owner != null) ? owner.GetComponentByClass(CharRenderingComponent.StaticClass()) : null) as CharRenderingComponent);
				}
				if (charRenderingComponent == null)
				{
					charRenderingComponent = (((aactor != null) ? aactor.GetComponentByClass(CharRenderingComponent.StaticClass()) : null) as CharRenderingComponent);
				}
			}
			if (charRenderingComponent == null && effectModel.NeedDisableWithActor)
			{
				AActor aactor2 = contextSourceObject as AActor;
				if (aactor2 != null && aactor2 != aactor)
				{
					charRenderingComponent = (aactor2.GetComponentByClass(CharRenderingComponent.StaticClass()) as CharRenderingComponent);
				}
				if (charRenderingComponent == null)
				{
					UActorComponent uactorComponent = contextSourceObject as UActorComponent;
					AActor aactor3 = (uactorComponent != null) ? uactorComponent.GetOwner() : null;
					if (aactor3 != null && aactor3 != aactor)
					{
						charRenderingComponent = (aactor3.GetComponentByClass(CharRenderingComponent.StaticClass()) as CharRenderingComponent);
					}
				}
			}
			return charRenderingComponent;
		}

		// Token: 0x0603E0F2 RID: 254194 RVA: 0x01200A59 File Offset: 0x011FEC59
		[NullableContext(2)]
		private static void EffectSpecRegisterBodyEffect(int effectId, AActor effectActor, USkeletalMeshComponent contextMeshComponent, UObject contextSourceObject, [Nullable(1)] UEffectModelBase effectModel)
		{
			CharRenderingComponent charRenderingComponent = KuroEffectSystem.FindRenderingComponent(effectActor, contextMeshComponent, contextSourceObject, effectModel);
			if (charRenderingComponent == null)
			{
				return;
			}
			charRenderingComponent.RegisterBodyEffect(effectId);
		}

		// Token: 0x0603E0F3 RID: 254195 RVA: 0x01200A70 File Offset: 0x011FEC70
		private static void EffectSpecUnregisterBodyEffect(int effectId, [Nullable(2)] AActor effectActor, USkeletalMeshComponent contextMeshComponent, UObject contextSourceObject, UEffectModelBase effectModel)
		{
			CharRenderingComponent charRenderingComponent = KuroEffectSystem.FindRenderingComponent(effectActor, contextMeshComponent, contextSourceObject, effectModel);
			if (charRenderingComponent == null)
			{
				return;
			}
			charRenderingComponent.UnregisterBodyEffect(effectId);
		}

		// Token: 0x0603E0F4 RID: 254196 RVA: 0x01200A88 File Offset: 0x011FEC88
		[NullableContext(2)]
		private static UKuroCharRenderingComponent MaterialSpecGetRenderingComponentByContext(int entityId, UObject contextSourceObject)
		{
			if (entityId != 0)
			{
				Entity entity = EntitySystem.Instance.Get(entityId);
				object obj;
				if (entity == null)
				{
					obj = null;
				}
				else
				{
					CharacterActorComponent component = entity.GetComponent<CharacterActorComponent>();
					obj = ((component != null) ? component.Owner : null);
				}
				TsBaseCharacter tsBaseCharacter = obj as TsBaseCharacter;
				if (tsBaseCharacter != null)
				{
					return tsBaseCharacter.CharRenderingComponent;
				}
			}
			TsBaseCharacter tsBaseCharacter2 = contextSourceObject as TsBaseCharacter;
			if (tsBaseCharacter2 != null)
			{
				return tsBaseCharacter2.CharRenderingComponent;
			}
			return null;
		}

		// Token: 0x0603E0F5 RID: 254197 RVA: 0x01200AE0 File Offset: 0x011FECE0
		[NullableContext(2)]
		private static UKuroCharRenderingComponent MaterialSpecGetRenderingComponentBySkeletal(USkeletalMeshComponent skeletalMeshComponent)
		{
			if (skeletalMeshComponent == null)
			{
				return null;
			}
			AActor owner = skeletalMeshComponent.GetOwner();
			TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
			if (tsBaseCharacter != null)
			{
				return tsBaseCharacter.CharRenderingComponent;
			}
			CharRenderingComponent charRenderingComponent = owner.GetComponentByClass(CharRenderingComponent.StaticClass()) as CharRenderingComponent;
			if (charRenderingComponent != null)
			{
				return charRenderingComponent;
			}
			return null;
		}

		// Token: 0x0603E0F6 RID: 254198 RVA: 0x01200B28 File Offset: 0x011FED28
		[NullableContext(2)]
		private static AActor MaterialSpecSpawnRenderActor(USkeletalMeshComponent skeletalMeshComponent)
		{
			TSubclassOf<AActor> actorClass = BP_MaterialControllerRenderActor_C.StaticClass();
			FTransformDouble ftransformDouble = new FTransformDouble();
			return UKuroRenderingRuntimeBPPluginBPLibrary.D_SpawnActorFromClass(skeletalMeshComponent, actorClass, ftransformDouble, ESpawnActorCollisionHandlingMethod.Undefined, null, null, true);
		}

		// Token: 0x0603E0F7 RID: 254199 RVA: 0x01200B54 File Offset: 0x011FED54
		[NullableContext(2)]
		private static UKuroCharRenderingComponent MaterialSpecGetRenderingComponentByRenderActor(AActor actor, USkeletalMeshComponent skeletalMeshComponent)
		{
			if (actor == null)
			{
				return null;
			}
			AActor logicOwner = (skeletalMeshComponent != null) ? skeletalMeshComponent.GetOwner() : null;
			CharRenderingComponent charRenderingComponent = (actor as BP_MaterialControllerRenderActor_C).CharRenderingComponent;
			charRenderingComponent.Init(GlobalData.IsUiSceneOpen ? ECharacterRenderingType.UI : ECharacterRenderingType.Default);
			charRenderingComponent.SetLogicOwner(logicOwner);
			charRenderingComponent.AddComponentByCase(ECharacterControllerCaseType.BodyCase0, skeletalMeshComponent);
			return charRenderingComponent;
		}

		// Token: 0x0603E0F8 RID: 254200 RVA: 0x01200BA0 File Offset: 0x011FEDA0
		[NullableContext(2)]
		private static int MaterialSpecAddMaterialControllerData(UKuroCharRenderingComponent renderComponent, UKuroMaterialControllerDataAsset dataAsset)
		{
			if (dataAsset != null)
			{
				CharRenderingComponent charRenderingComponent = renderComponent as CharRenderingComponent;
				if (charRenderingComponent != null)
				{
					return charRenderingComponent.AddMaterialControllerData(dataAsset);
				}
			}
			return -1;
		}

		// Token: 0x0603E0F9 RID: 254201 RVA: 0x01200BC4 File Offset: 0x011FEDC4
		[NullableContext(2)]
		private static void MaterialSpecRemoveMaterialControllerData(UKuroCharRenderingComponent renderComponent, int materialControllerHandle)
		{
			CharRenderingComponent charRenderingComponent = renderComponent as CharRenderingComponent;
			if (charRenderingComponent == null || materialControllerHandle == -1)
			{
				return;
			}
			charRenderingComponent.RemoveMaterialControllerData(materialControllerHandle);
		}

		// Token: 0x0603E0FA RID: 254202 RVA: 0x01200BE7 File Offset: 0x011FEDE7
		[NullableContext(2)]
		private static void MaterialSpecDestroyRenderingComponent(UKuroCharRenderingComponent renderComponent)
		{
			CharRenderingComponent charRenderingComponent = renderComponent as CharRenderingComponent;
			if (charRenderingComponent == null)
			{
				return;
			}
			charRenderingComponent.Destroy();
		}

		// Token: 0x0603E0FB RID: 254203 RVA: 0x01200BFC File Offset: 0x011FEDFC
		[NullableContext(2)]
		private static int EffectAudioControllerAddPlayEffectAudio(UEffectModelAudio effectModel, AActor effectActor, int effectType)
		{
			if (effectModel == null)
			{
				return 0;
			}
			return EffectAudioController.Instance.AddPlayEffectAudio(effectModel, effectActor, new EHitEffectType?((EHitEffectType)effectType), null, null, null);
		}

		// Token: 0x0603E0FC RID: 254204 RVA: 0x01200C40 File Offset: 0x011FEE40
		[NullableContext(2)]
		private static int EffectAudioControllerAddPlayEffectAudioPriority(UEffectModelAudio effectModel, AActor effectActor, int effectType, int priority)
		{
			if (effectModel == null)
			{
				return 0;
			}
			return EffectAudioController.Instance.AddPlayEffectAudio(effectModel, effectActor, new EHitEffectType?((EHitEffectType)effectType), new ERoleAudioPriorityType?((ERoleAudioPriorityType)priority), null, null);
		}

		// Token: 0x0603E0FD RID: 254205 RVA: 0x01200C7E File Offset: 0x011FEE7E
		private static void EffectAudioControllerOnStopEffectAudio(int uid, string context)
		{
			EffectAudioController.Instance.OnStopEffectAudio(uid, context, true);
		}

		// Token: 0x04020EAA RID: 134826
		public bool PreviewInitState;

		// Token: 0x04020EAB RID: 134827
		private bool HasInitialize;

		// Token: 0x04020EAC RID: 134828
		private readonly OrderedDictionary<int, KuroEffectHandle> EffectHandleMap = new OrderedDictionary<int, KuroEffectHandle>();

		// Token: 0x04020EAD RID: 134829
		private readonly OrderedDictionary<int, KuroEffectActorHandle> EffectActorHandleMap = new OrderedDictionary<int, KuroEffectActorHandle>();

		// Token: 0x04020EAE RID: 134830
		private readonly OrderedDictionary<int, KuroEffectNiagaraComponentHandle> EffectNiagaraHandleMap = new OrderedDictionary<int, KuroEffectNiagaraComponentHandle>();

		// Token: 0x04020EAF RID: 134831
		private readonly UltraSkillEffectStateWatcher UltraSkillStateWatcher = new UltraSkillEffectStateWatcher();

		// Token: 0x04020EB0 RID: 134832
		private const string MIN_NIAGARA_SIMULATION_TICK_TIME = "0.033";

		// Token: 0x04020EB1 RID: 134833
		private const int CHECK_EFFECT_OWNER_INTERVAL = 60000;

		// Token: 0x04020EB2 RID: 134834
		private const string EFFECT_SPEC_DATA_PATH = "../Config/Client/EffectData/";

		// Token: 0x04020EB3 RID: 134835
		[StaticVariableRuleIgnore]
		public static readonly HashSet<string> MOBILE_EFFECT_BLACK_LIST = new HashSet<string>
		{
			"/Game/Aki/Scene/EffectDataAsset/DA_New/DA_Fx_Sc2_FarCloud/DA_Fx_Sc2_FarCloud01.DA_Fx_Sc2_FarCloud01",
			"/Game/Aki/Scene/EffectDataAsset/DA_New/DA_Fx_Sc2_FarCloud/DA_Fx_Sc2_FarCloud02.DA_Fx_Sc2_FarCloud02",
			"/Game/Aki/Scene/EffectDataAsset/DA_New/DA_Fx_Sc2_FarCloud/DA_Fx_Sc2_FarCloud03.DA_Fx_Sc2_FarCloud03",
			"/Game/Aki/Scene/EffectDataAsset/DA_New/DA_Fx_Sc2_FarCloud/DA_Fx_Sc2_FarCloud04.DA_Fx_Sc2_FarCloud04",
			"/Game/Aki/Scene/EffectDataAsset/DA_New/DA_Fx_Sc2_FarCloud/DA_Fx_Sc2_FarCloud05.DA_Fx_Sc2_FarCloud05",
			"/Game/Aki/Scene/EffectDataAsset/DA_New/DA_Fx_Sc2_FarCloud/DA_Fx_Sc2_FarCloud06.DA_Fx_Sc2_FarCloud06",
			"/Game/Aki/Scene/EffectDataAsset/DA_New/DA_Fx_Sc2_FarCloud/DA_Fx_Sc2_FarCloud07.DA_Fx_Sc2_FarCloud07",
			"/Game/Aki/Scene/EffectDataAsset/DA_New/DA_Fx_Sc2_FarCloud/DA_Fx_Sc2_FarCloud08.DA_Fx_Sc2_FarCloud08",
			"/Game/Aki/Scene/EffectDataAsset/DA_Base/DA_Fx_Luoye_03.DA_Fx_Luoye_03",
			"/Game/Aki/Scene/EffectDataAsset/DA_Base/DA_Fx_Sc3_luoye06.DA_Fx_Sc3_luoye06",
			"/Game/Aki/Scene/EffectDataAsset/DA_New/DA_Fx_Luoye/DA_Fx_Luoye_06/DA_Fx_Sc3_luoye06_01.DA_Fx_Sc3_luoye06_01",
			"/Game/Aki/Scene/EffectDataAsset/DA_New/DA_Fx_Fog/DA_Fx_Fog_001.DA_Fx_Fog_001",
			"/Game/Aki/Scene/EffectDataAsset/DA_New/DA_Fx_Fog/DA_Fx_Fog_001_01.DA_Fx_Fog_001_01",
			"/Game/Aki/Scene/EffectDataAsset/DA_New/DA_Fx_Fog/DA_Fx_Fog_001_02.DA_Fx_Fog_001_02",
			"/Game/Aki/Scene/EffectDataAsset/DA_New/DA_Fx_Fog/DA_Fx_Fog_001_03.DA_Fx_Fog_001_03",
			"/Game/Aki/Scene/EffectDataAsset/DA_Base/DA_Fx_Sc2_MiddleFog.DA_Fx_Sc2_MiddleFog",
			"/Game/Aki/Scene/EffectDataAsset/DA_New/DA_Fx_Fog/DA_Fx_Sc2_MiddleFog_01.DA_Fx_Sc2_MiddleFog_01",
			"/Game/Aki/Scene/EffectDataAsset/DA_New/DA_Fx_Fog/DA_Fx_Sc2_MiddleFog_02.DA_Fx_Sc2_MiddleFog_02",
			"/Game/Aki/Scene/EffectDataAsset/DA_New/DA_Fx_Fog/DA_Fx_Sc2_MiddleFog_03.DA_Fx_Sc2_MiddleFog_03",
			"/Game/Aki/Scene/EffectDataAsset/DA_New/DA_Fx_Fog/DA_Fx_Sc2_MiddleFog_04.DA_Fx_Sc2_MiddleFog_04",
			"/Game/Aki/Effect/DataAsset/Niagara/Scene/Comnon/Smoke/DA_Fx_SC3_SmokFlow01.DA_Fx_SC3_SmokFlow01",
			"/Game/Aki/Scene/EffectDataAsset/DA_Base/DA_Fx_Luoye_01.DA_Fx_Luoye_01",
			"/Game/Aki/Scene/EffectDataAsset/DA_Base/DA_Fx_Luoye_01_bai.DA_Fx_Luoye_01_bai",
			"/Game/Aki/Scene/EffectDataAsset/DA_New/DA_Fx_Luoye/DA_Fx_Luoye_01/DA_Fx_Luoye_01_01.DA_Fx_Luoye_01_01",
			"/Game/Aki/Scene/EffectDataAsset/DA_New/DA_Fx_Luoye/DA_Fx_Luoye_01/DA_Fx_Luoye_01_02.DA_Fx_Luoye_01_02",
			"/Game/Aki/Scene/EffectDataAsset/DA_New/DA_Fx_Luoye/DA_Fx_Luoye_01/DA_Fx_Luoye_01_03.DA_Fx_Luoye_01_03",
			"/Game/Aki/Scene/EffectDataAsset/DA_New/DA_Fx_Luoye/DA_Fx_Luoye_01/DA_Fx_Luoye_01_bai_01.DA_Fx_Luoye_01_bai_01",
			"/Game/Aki/Scene/EffectDataAsset/DA_Base/DA_Fx_Luoye_02.DA_Fx_Luoye_02",
			"/Game/Aki/Scene/EffectDataAsset/DA_New/DA_Fx_Luoye/DA_Fx_Luoye_02/DA_Fx_Luoye_02_1.DA_Fx_Luoye_02_1",
			"/Game/Aki/Scene/EffectDataAsset/DA_New/DA_Fx_Luoye/DA_Fx_Luoye_02/DA_Fx_Luoye_02_2.DA_Fx_Luoye_02_2",
			"/Game/Aki/Scene/EffectDataAsset/DA_New/DA_Fx_Luoye/DA_Fx_Luoye_02/DA_Fx_Luoye_02_3.DA_Fx_Luoye_02_3",
			"/Game/Aki/Scene/EffectDataAsset/DA_New/DA_Fx_Luoye/DA_Fx_Luoye_02/DA_Fx_Luoye_02_4.DA_Fx_Luoye_02_4",
			"/Game/Aki/Scene/EffectDataAsset/DA_Base/DA_Fx_Sc3_luoye05_zise.DA_Fx_Sc3_luoye05_zise",
			"/Game/Aki/Scene/EffectDataAsset/DA_Base/DA_Fx_Sc3_Chuiyan.DA_Fx_Sc3_Chuiyan",
			"/Game/Aki/Effect/DataAsset/Niagara/Scene/CXS/DA_Fx_SC2_CXS_BambooLeaf.DA_Fx_SC2_CXS_BambooLeaf",
			"/Game/Aki/Effect/DataAsset/Niagara/Scene/Cluster/Wind/DA_Fx_SC3_Cluster_WindSmoke.DA_Fx_SC3_Cluster_WindSmoke",
			"/Game/Aki/Effect/DataAsset/Niagara/Scene/CXS/DA_Fx_SC2_CXS_Steam.DA_Fx_SC2_CXS_Steam",
			"/Game/Aki/Effect/DataAsset/Niagara/Scene/Comnon/Leaf/DA_Fx_Sc2_Leaf01.DA_Fx_Sc2_Leaf01",
			"/Game/Aki/Effect/DataAsset/Niagara/Scene/Comnon/Leaf/DA_Fx_Sc2_Leaf01_1.DA_Fx_Sc2_Leaf01_1",
			"/Game/Aki/Effect/DataAsset/Niagara/Scene/Comnon/Leaf/DA_Fx_Sc2_Leaf02.DA_Fx_Sc2_Leaf02",
			"/Game/Aki/Effect/DataAsset/Niagara/Scene/Comnon/Leaf/DA_Fx_Sc2_Leaf03.DA_Fx_Sc2_Leaf03",
			"/Game/Aki/Effect/DataAsset/Niagara/Scene/Comnon/Leaf/DA_Fx_SC2_Leaf05_1.DA_Fx_SC2_Leaf05_1"
		};

		// Token: 0x04020EB4 RID: 134836
		private readonly TArray<FKuroSceneTeamItem> SceneTeamItems = new TArray<FKuroSceneTeamItem>();

		// Token: 0x04020EB5 RID: 134837
		private readonly List<SpecData> EffectForSpecArray = new List<SpecData>();

		// Token: 0x04020EB6 RID: 134838
		private readonly List<EffectSpecData> EffectForSpecDbCacheArray = new List<EffectSpecData>();

		// Token: 0x04020EB7 RID: 134839
		private float CheckEffectOwnerInterval = 60000f;

		// Token: 0x0200BB77 RID: 47991
		[NullableContext(0)]
		private enum EEffectContextType : byte
		{
			// Token: 0x04039A23 RID: 236067
			EEffectContextType_Base,
			// Token: 0x04039A24 RID: 236068
			EEffectContextType_Skeletal,
			// Token: 0x04039A25 RID: 236069
			EEffectContextType_Audio,
			// Token: 0x04039A26 RID: 236070
			EEffectContextType_Ghost
		}

		// Token: 0x0200BB78 RID: 47992
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04039A27 RID: 236071
			[Nullable(0)]
			public static Action <0>__OnTimeScaleChange;

			// Token: 0x04039A28 RID: 236072
			[Nullable(0)]
			public static Action <1>__OnSetNiagaraQuality;

			// Token: 0x04039A29 RID: 236073
			[Nullable(0)]
			public static Action<EKuroUI3DState> <2>__OnGlobalUiSceneStateChanged;

			// Token: 0x04039A2A RID: 236074
			[Nullable(0)]
			public static Action<bool> <3>__OnSetGamePaused;

			// Token: 0x04039A2B RID: 236075
			[Nullable(new byte[]
			{
				0,
				2,
				2,
				2,
				2
			})]
			public static Func<float, UActorComponent, USkeletalMeshComponent, AActor, UActorComponent> <4>__SkeletalMeshSpecOnBodyEffectChange;

			// Token: 0x04039A2C RID: 236076
			[Nullable(new byte[]
			{
				0,
				2,
				2,
				2,
				2
			})]
			public static Func<UActorComponent, USkeletalMeshComponent, AActor, UActorComponent> <5>__SkeletalMeshSpecCreateRenderingComponent;

			// Token: 0x04039A2D RID: 236077
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Action<AActor, UActorComponent> <6>__SkeletalMeshSpecDestroyRenderingComponent;

			// Token: 0x04039A2E RID: 236078
			[Nullable(new byte[]
			{
				0,
				2
			})]
			public static Func<int, AActor> <7>__EffectHandleGetEntityOwnerActor;

			// Token: 0x04039A2F RID: 236079
			[Nullable(0)]
			public static Func<int, int> <8>__EffectHandleGetEntityModelConfigId;

			// Token: 0x04039A30 RID: 236080
			[Nullable(0)]
			public static Func<float, FName> <9>__EffectHandleGetOrAddEffectDynamicGroup;

			// Token: 0x04039A31 RID: 236081
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Func<bool, AActor, UAkComponent> <10>__AudioSystemGetAkComponent;

			// Token: 0x04039A32 RID: 236082
			[Nullable(0)]
			public static Action<int, float> <11>__AudioSystemExecuteActionStop;

			// Token: 0x04039A33 RID: 236083
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Func<string, FTransformDouble, int> <12>__AudioSystemPostEventTransform;

			// Token: 0x04039A34 RID: 236084
			[Nullable(new byte[]
			{
				0,
				1,
				2
			})]
			public static Func<string, UAkComponent, int> <13>__AudioSystemPostEventAkComponent;

			// Token: 0x04039A35 RID: 236085
			[Nullable(0)]
			public static Func<int, bool> <14>__NiagaraSpecIsNeedQualityBias;

			// Token: 0x04039A36 RID: 236086
			[Nullable(0)]
			public static Func<int, bool, bool> <15>__PostProcessSpecIsNeedPostEffect;

			// Token: 0x04039A37 RID: 236087
			[Nullable(0)]
			public static Func<int, bool> <16>__PostProcessSpecIsDisableInUltraSkill;

			// Token: 0x04039A38 RID: 236088
			[Nullable(0)]
			public static FActorSystemGetRetVal.FActorSystemGetRetVal_ScriptDelegate <17>__ActorSystemGet;

			// Token: 0x04039A39 RID: 236089
			[Nullable(new byte[]
			{
				0,
				1,
				2
			})]
			public static Func<string, AActor, bool> <18>__ActorSystemPut;

			// Token: 0x04039A3A RID: 236090
			[Nullable(new byte[]
			{
				0,
				2
			})]
			public static Action<AActor, int> <19>__EffectSystemSetEffectView;

			// Token: 0x04039A3B RID: 236091
			[Nullable(0)]
			public static Func<int, bool> <20>__EffectSystemCheckIsNetPlayer;

			// Token: 0x04039A3C RID: 236092
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Func<string, bool> <21>__EffectSystemCheckMobileBlackEffect;

			// Token: 0x04039A3D RID: 236093
			[Nullable(new byte[]
			{
				0,
				2,
				2,
				2,
				2
			})]
			public static Action<int, AActor, USkeletalMeshComponent, UObject, UEffectModelBase> <22>__EffectSpecRegisterBodyEffect;

			// Token: 0x04039A3E RID: 236094
			[Nullable(new byte[]
			{
				0,
				2,
				2,
				2,
				2
			})]
			public static Action<int, AActor, USkeletalMeshComponent, UObject, UEffectModelBase> <23>__EffectSpecUnregisterBodyEffect;

			// Token: 0x04039A3F RID: 236095
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Func<int, UObject, UKuroCharRenderingComponent> <24>__MaterialSpecGetRenderingComponentByContext;

			// Token: 0x04039A40 RID: 236096
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Func<USkeletalMeshComponent, UKuroCharRenderingComponent> <25>__MaterialSpecGetRenderingComponentBySkeletal;

			// Token: 0x04039A41 RID: 236097
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Func<USkeletalMeshComponent, AActor> <26>__MaterialSpecSpawnRenderActor;

			// Token: 0x04039A42 RID: 236098
			[Nullable(new byte[]
			{
				0,
				2,
				2,
				2
			})]
			public static Func<AActor, USkeletalMeshComponent, UKuroCharRenderingComponent> <27>__MaterialSpecGetRenderingComponentByRenderActor;

			// Token: 0x04039A43 RID: 236099
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Func<UKuroCharRenderingComponent, UKuroMaterialControllerDataAsset, int> <28>__MaterialSpecAddMaterialControllerData;

			// Token: 0x04039A44 RID: 236100
			[Nullable(new byte[]
			{
				0,
				2
			})]
			public static Action<UKuroCharRenderingComponent, int> <29>__MaterialSpecRemoveMaterialControllerData;

			// Token: 0x04039A45 RID: 236101
			[Nullable(new byte[]
			{
				0,
				2
			})]
			public static Action<UKuroCharRenderingComponent> <30>__MaterialSpecDestroyRenderingComponent;

			// Token: 0x04039A46 RID: 236102
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Func<UEffectModelAudio, AActor, int, int> <31>__EffectAudioControllerAddPlayEffectAudio;

			// Token: 0x04039A47 RID: 236103
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Func<UEffectModelAudio, AActor, int, int, int> <32>__EffectAudioControllerAddPlayEffectAudioPriority;

			// Token: 0x04039A48 RID: 236104
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Action<int, string> <33>__EffectAudioControllerOnStopEffectAudio;
		}
	}
}
