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
using CSharpScript.Game.World.Define;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Game.Effect
{
	// Token: 0x02007274 RID: 29300
	[NullableContext(1)]
	[Nullable(0)]
	public class KuroEffectSystem
	{
		// Token: 0x06047CCB RID: 294091 RVA: 0x0125DDC4 File Offset: 0x0125BFC4
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
			return true;
		}

		// Token: 0x06047CCC RID: 294092 RVA: 0x0125DEF8 File Offset: 0x0125C0F8
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
			UKuroEffectSystemFunctionLibrary.InitStaticGlobalData(EffectEnvironment.Instance.UseLog, Info.Instance.IsInEditorTick(), PublicUtil.Instance.UseDbConfig());
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

		// Token: 0x06047CCD RID: 294093 RVA: 0x0125E4C8 File Offset: 0x0125C6C8
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

		// Token: 0x06047CCE RID: 294094 RVA: 0x0125E658 File Offset: 0x0125C858
		public bool ClearPool()
		{
			UKuroEffectSystemFunctionLibrary.ClearPool(false);
			return true;
		}

		// Token: 0x06047CCF RID: 294095 RVA: 0x0125E661 File Offset: 0x0125C861
		private static void OnGlobalUiSceneStateChanged(EKuroUI3DState state)
		{
			UKuroEffectSystemFunctionLibrary.OnUiSceneStateChange(state);
		}

		// Token: 0x06047CD0 RID: 294096 RVA: 0x0125E669 File Offset: 0x0125C869
		private static void OnSetGamePaused(bool paused)
		{
			UKuroEffectSystemFunctionLibrary.OnTickSystemPausedChange(paused);
		}

		// Token: 0x06047CD1 RID: 294097 RVA: 0x0125E674 File Offset: 0x0125C874
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

		// Token: 0x06047CD2 RID: 294098 RVA: 0x0125E720 File Offset: 0x0125C920
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

		// Token: 0x06047CD3 RID: 294099 RVA: 0x0125E7B8 File Offset: 0x0125C9B8
		private void CreateEffectSpecMappingWithDb()
		{
			if (!PublicUtil.Instance.UseDbConfig())
			{
				return;
			}
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

		// Token: 0x06047CD4 RID: 294100 RVA: 0x0125E834 File Offset: 0x0125CA34
		private unsafe void CreateEffectSpecMappingWithJson(bool withEditor = false)
		{
			if (!Info.Instance.IsPlayInEditor)
			{
				return;
			}
			if (!withEditor && PublicUtil.Instance.UseDbConfig())
			{
				return;
			}
			this.EffectForSpecArray.Clear();
			this.EffectForSpecDbCacheArray.Clear();
			string text = UKismetSystemLibrary.GetProjectDirectory() + "../Config/Client/EffectData/";
			if (!UBlueprintPathsLibrary.DirectoryExists(text))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.World;
				ELogAuthor author = ELogAuthor.LFJW;
				string message = "不存在EffectSpec配置文件目录";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", text);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			try
			{
				foreach (string text2 in UKuroStaticLibrary.LoadFilesRecursive(text, "*.json", true, false))
				{
					if (!string.IsNullOrEmpty(text2))
					{
						SpecData specData = Json.Decode<SpecData>(text2, null);
						if (specData != null)
						{
							this.EffectForSpecArray.Add(specData);
						}
					}
				}
			}
			catch (Exception ex)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.RenderEffect;
				ELogAuthor author2 = ELogAuthor.LFJW;
				string message2 = "读取EffectSpec.json异常";
				Exception error = ex;
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Name", "KuroEffectSystem");
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("error", ex.Message);
				instance2.ErrorWithStack(module2, author2, message2, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}

		// Token: 0x06047CD5 RID: 294101 RVA: 0x0125E98C File Offset: 0x0125CB8C
		private void UpdateFEffectSystemSpecConfig(TArray<FKuroEffectSpecData> specDataArray, TArray<FKuroEffectSpecChildData> specChildDataArray, bool withEditor = false)
		{
			if (withEditor || !PublicUtil.Instance.UseDbConfig())
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

		// Token: 0x06047CD6 RID: 294102 RVA: 0x0125EB9C File Offset: 0x0125CD9C
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

		// Token: 0x06047CD7 RID: 294103 RVA: 0x0125EC5C File Offset: 0x0125CE5C
		private static void OnTimeScaleChange()
		{
			UKuroEffectSystemFunctionLibrary.OnGlobalTimeScaleChange();
		}

		// Token: 0x06047CD8 RID: 294104 RVA: 0x0125EC64 File Offset: 0x0125CE64
		private static void OpenNiagaraDownSampling()
		{
			Log.Instance.Info(ELogModule.RenderEffect, ELogAuthor.WLJ, "Open Niagara Down Sampling", default(ReadOnlySpan<ValueTuple<string, object>>));
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "Kuro.Niagara.SystemSimulation.TickDeltaTime 0.033", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "Kuro.Niagara.SystemSimulation.SpawnAlignment 0", null);
		}

		// Token: 0x06047CD9 RID: 294105 RVA: 0x0125ECB0 File Offset: 0x0125CEB0
		private static void CloseNiagaraDownSampling()
		{
			Log.Instance.Info(ELogModule.RenderEffect, ELogAuthor.WLJ, "Close Niagara Down Sampling", default(ReadOnlySpan<ValueTuple<string, object>>));
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "Kuro.Niagara.SystemSimulation.TickDeltaTime -1", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "Kuro.Niagara.SystemSimulation.SpawnAlignment 0", null);
		}

		// Token: 0x06047CDA RID: 294106 RVA: 0x0125ECFC File Offset: 0x0125CEFC
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

		// Token: 0x06047CDB RID: 294107 RVA: 0x0125ED78 File Offset: 0x0125CF78
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

		// Token: 0x06047CDC RID: 294108 RVA: 0x0125EE1C File Offset: 0x0125D01C
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

		// Token: 0x06047CDD RID: 294109 RVA: 0x0125EE5A File Offset: 0x0125D05A
		public int GetEffectLruCount(string path)
		{
			return UKuroEffectSystemFunctionLibrary.GetEffectLruCount(path);
		}

		// Token: 0x06047CDE RID: 294110 RVA: 0x0125EE62 File Offset: 0x0125D062
		public int GetEffectLruCapacity()
		{
			return UKuroEffectSystemFunctionLibrary.GetEffectLruCapacity();
		}

		// Token: 0x06047CDF RID: 294111 RVA: 0x0125EE69 File Offset: 0x0125D069
		public void SetEffectLruCapacity(int capacity)
		{
			UKuroEffectSystemFunctionLibrary.SetEffectLruCapacity(capacity);
		}

		// Token: 0x06047CE0 RID: 294112 RVA: 0x0125EE71 File Offset: 0x0125D071
		public int GetEffectLruSize()
		{
			return UKuroEffectSystemFunctionLibrary.GetEffectLruSize();
		}

		// Token: 0x06047CE1 RID: 294113 RVA: 0x0125EE78 File Offset: 0x0125D078
		[NullableContext(2)]
		public int SpawnUnloopedEffect(UObject worldContext, in FTransformDouble? transform, string path, [Nullable(1)] string reason, EffectContext context = null, EEffectType effectType = EEffectType.Scene, Action<int> beforeInitCallback = null, Action<ELoadEffectResult, int> callback = null, Action<int> beforePlayCallback = null, bool prepare = false, bool forceCreateActor = false)
		{
			if (!this.HasInitialize && !Info.Instance.IsPlayInEditor)
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

		// Token: 0x06047CE2 RID: 294114 RVA: 0x0125F0BC File Offset: 0x0125D2BC
		[NullableContext(2)]
		public int SpawnEffect(UObject worldContext, in FTransformDouble? transform, string path, [Nullable(1)] string reason, EffectContext context = null, EEffectType effectType = EEffectType.Scene, Action<int> beforeInitCallback = null, Action<ELoadEffectResult, int> callback = null, Action<int> beforePlayCallback = null, bool prepare = false, bool forceCreateActor = false)
		{
			if (!this.HasInitialize && !Info.Instance.IsPlayInEditor)
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

		// Token: 0x06047CE3 RID: 294115 RVA: 0x0125F300 File Offset: 0x0125D500
		public void DynamicRegisterSpawnCallback(int effectId, Action<ELoadEffectResult, int> callback)
		{
			if (!this.HasInitialize && !Info.Instance.IsPlayInEditor)
			{
				return;
			}
			KuroEffectHandle kuroEffectHandle;
			if (this.EffectHandleMap.TryGetValue(effectId, out kuroEffectHandle))
			{
				kuroEffectHandle.RegisterDynamicEffectInitCallback(callback);
			}
		}

		// Token: 0x06047CE4 RID: 294116 RVA: 0x0125F33C File Offset: 0x0125D53C
		public void AddFinishCallback(int effectId, Action<int> callback)
		{
			if (!this.HasInitialize && !Info.Instance.IsPlayInEditor)
			{
				return;
			}
			KuroEffectHandle kuroEffectHandle;
			if (this.EffectHandleMap.TryGetValue(effectId, out kuroEffectHandle))
			{
				kuroEffectHandle.AddFinishCallback(callback);
			}
		}

		// Token: 0x06047CE5 RID: 294117 RVA: 0x0125F378 File Offset: 0x0125D578
		public void RemoveFinishCallback(int effectId, Action<int> callback)
		{
			if (!this.HasInitialize && !Info.Instance.IsPlayInEditor)
			{
				return;
			}
			KuroEffectHandle kuroEffectHandle;
			if (this.EffectHandleMap.TryGetValue(effectId, out kuroEffectHandle))
			{
				kuroEffectHandle.RemoveFinishCallback(callback);
			}
		}

		// Token: 0x06047CE6 RID: 294118 RVA: 0x0125F3B2 File Offset: 0x0125D5B2
		public void ForceCheckPendingInit(int handle)
		{
			UKuroEffectSystemFunctionLibrary.ForceCheckPendingInit(handle);
		}

		// Token: 0x06047CE7 RID: 294119 RVA: 0x0125F3BA File Offset: 0x0125D5BA
		[NullableContext(2)]
		public void SetEffectHidden(int handle, bool bHidden, string reason = null, bool isLogic = false)
		{
			UKuroEffectSystemFunctionLibrary.SetEffectHidden(handle, bHidden, reason ?? string.Empty, isLogic);
		}

		// Token: 0x06047CE8 RID: 294120 RVA: 0x0125F3CF File Offset: 0x0125D5CF
		public bool StopEffectById(int handle, string reason, bool immediately, bool? destroyActor = null)
		{
			return UKuroEffectSystemFunctionLibrary.StopEffectById(handle, reason, immediately, destroyActor.GetValueOrDefault());
		}

		// Token: 0x06047CE9 RID: 294121 RVA: 0x0125F3E0 File Offset: 0x0125D5E0
		public bool IsValid(int id)
		{
			return UKuroEffectSystemFunctionLibrary.IsEffectValid(id);
		}

		// Token: 0x06047CEA RID: 294122 RVA: 0x0125F3E8 File Offset: 0x0125D5E8
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

		// Token: 0x06047CEB RID: 294123 RVA: 0x0125F457 File Offset: 0x0125D657
		[NullableContext(2)]
		public AActor GetSureEffectActor(int id)
		{
			return UKuroEffectSystemFunctionLibrary.GetSureEffectActor(id);
		}

		// Token: 0x06047CEC RID: 294124 RVA: 0x0125F460 File Offset: 0x0125D660
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

		// Token: 0x06047CED RID: 294125 RVA: 0x0125F4D3 File Offset: 0x0125D6D3
		[NullableContext(2)]
		public UNiagaraComponent GetSureNiagaraComponent(int id)
		{
			return UKuroEffectSystemFunctionLibrary.GetSureNiagaraComponent(id);
		}

		// Token: 0x06047CEE RID: 294126 RVA: 0x0125F4DC File Offset: 0x0125D6DC
		public void ReplayEffect(int id, string reason, in FTransformDouble? transform)
		{
			FTransformDouble ftransformDouble = transform ?? new FTransformDouble();
			UKuroEffectSystemFunctionLibrary.ReplayEffect(id, reason, ftransformDouble, transform != null);
		}

		// Token: 0x06047CEF RID: 294127 RVA: 0x0125F517 File Offset: 0x0125D717
		public bool IsPlaying(int id)
		{
			return UKuroEffectSystemFunctionLibrary.IsPlaying(id);
		}

		// Token: 0x06047CF0 RID: 294128 RVA: 0x0125F51F File Offset: 0x0125D71F
		public void SetHandleLifeCycle(int id, float time)
		{
			UKuroEffectSystemFunctionLibrary.SetHandleLifeCycle(id, time);
		}

		// Token: 0x06047CF1 RID: 294129 RVA: 0x0125F528 File Offset: 0x0125D728
		public void SetTimeScale(int id, float timeScale, bool ignoreGlobalTimeScale = false)
		{
			UKuroEffectSystemFunctionLibrary.SetTimeScale(id, timeScale, ignoreGlobalTimeScale);
		}

		// Token: 0x06047CF2 RID: 294130 RVA: 0x0125F532 File Offset: 0x0125D732
		public void SetAdditionTimeScale(int sourceType, int id, float timeScale)
		{
			UKuroEffectSystemFunctionLibrary.SetAdditionTimeScale(sourceType, id, timeScale);
		}

		// Token: 0x06047CF3 RID: 294131 RVA: 0x0125F53C File Offset: 0x0125D73C
		public void SetAdditionTimeScaleEnable(int sourceType, bool enable)
		{
			UKuroEffectSystemFunctionLibrary.SetAdditionTimeScaleEnable(sourceType, enable);
		}

		// Token: 0x06047CF4 RID: 294132 RVA: 0x0125F545 File Offset: 0x0125D745
		public bool GetAdditionTimeScaleEnable(int sourceType)
		{
			return UKuroEffectSystemFunctionLibrary.GetAdditionTimeScaleEnable(sourceType);
		}

		// Token: 0x06047CF5 RID: 294133 RVA: 0x0125F54D File Offset: 0x0125D74D
		public void FreezeHandle(int id, bool freeze, bool force = false)
		{
			UKuroEffectSystemFunctionLibrary.FreezeHandle(id, freeze, force);
		}

		// Token: 0x06047CF6 RID: 294134 RVA: 0x0125F557 File Offset: 0x0125D757
		public bool IsHandleFreeze(int id)
		{
			return UKuroEffectSystemFunctionLibrary.IsHandleFreeze(id);
		}

		// Token: 0x06047CF7 RID: 294135 RVA: 0x0125F55F File Offset: 0x0125D75F
		public bool HandleSeekToTime(int id, float time, bool autoLoop, bool force = false)
		{
			return UKuroEffectSystemFunctionLibrary.HandleSeekToTime(id, time, autoLoop, force);
		}

		// Token: 0x06047CF8 RID: 294136 RVA: 0x0125F56B File Offset: 0x0125D76B
		public void HandleSeekToTimeWithProcess(int id, float time, bool seekContinue = false, float delta = -1f)
		{
			UKuroEffectSystemFunctionLibrary.HandleSeekToTimeWithProcess(id, time, seekContinue, delta);
		}

		// Token: 0x06047CF9 RID: 294137 RVA: 0x0125F577 File Offset: 0x0125D777
		public float GetSeekToTargetTime(int id)
		{
			return UKuroEffectSystemFunctionLibrary.GetSeekToTargetTime(id);
		}

		// Token: 0x06047CFA RID: 294138 RVA: 0x0125F580 File Offset: 0x0125D780
		public void SetEffectNotRecord(int id, bool notRecord = true)
		{
			KuroEffectHandle kuroEffectHandle;
			if (this.EffectHandleMap.TryGetValue(id, out kuroEffectHandle))
			{
				kuroEffectHandle.SetNotRecord(notRecord);
			}
		}

		// Token: 0x06047CFB RID: 294139 RVA: 0x0125F5A4 File Offset: 0x0125D7A4
		public string GetPath(int id)
		{
			return UKuroEffectSystemFunctionLibrary.GetPath(id);
		}

		// Token: 0x06047CFC RID: 294140 RVA: 0x0125F5AC File Offset: 0x0125D7AC
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

		// Token: 0x06047CFD RID: 294141 RVA: 0x0125F610 File Offset: 0x0125D810
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

		// Token: 0x06047CFE RID: 294142 RVA: 0x0125F636 File Offset: 0x0125D836
		public void SetEffectDataFloatConstParam(int id, in FName paramName, float value)
		{
			UKuroEffectSystemFunctionLibrary.SetEffectDataFloatConstParam(id, paramName, value);
		}

		// Token: 0x06047CFF RID: 294143 RVA: 0x0125F645 File Offset: 0x0125D845
		public void SetEffectExtraState(int effectId, int extraState)
		{
			UKuroEffectSystemFunctionLibrary.SetEffectExtraState(effectId, extraState);
		}

		// Token: 0x06047D00 RID: 294144 RVA: 0x0125F64E File Offset: 0x0125D84E
		public void SetEffectIgnoreVisibilityOptimize(int effectId, bool ignore)
		{
			UKuroEffectSystemFunctionLibrary.SetEffectIgnoreVisibilityOptimize(effectId, ignore);
		}

		// Token: 0x06047D01 RID: 294145 RVA: 0x0125F657 File Offset: 0x0125D857
		public void SetEffectStoppingTime(int effectId, bool stoppingTime, EEffectStoppingTimeSource source = EEffectStoppingTimeSource.ScenePaused)
		{
			UKuroEffectSystemFunctionLibrary.SetEffectStoppingTime(effectId, stoppingTime, (int)source);
		}

		// Token: 0x06047D02 RID: 294146 RVA: 0x0125F661 File Offset: 0x0125D861
		public void SetEffectStoppingTimeFromEntity(int entityId, bool stoppingTime, EEffectStoppingTimeSource source = EEffectStoppingTimeSource.ScenePaused)
		{
			UKuroEffectSystemFunctionLibrary.SetEffectStoppingTimeFromEntity(entityId, stoppingTime, (int)source);
		}

		// Token: 0x06047D03 RID: 294147 RVA: 0x0125F66B File Offset: 0x0125D86B
		public float GlobalStoppingPlayTime(EEffectStoppingTimeSource source = EEffectStoppingTimeSource.ScenePaused)
		{
			return UKuroEffectSystemFunctionLibrary.GlobalStoppingPlayTime((int)source);
		}

		// Token: 0x06047D04 RID: 294148 RVA: 0x0125F673 File Offset: 0x0125D873
		public bool GlobalStoppingTime(EEffectStoppingTimeSource source = EEffectStoppingTimeSource.ScenePaused)
		{
			return UKuroEffectSystemFunctionLibrary.GlobalStoppingTime((int)source);
		}

		// Token: 0x06047D05 RID: 294149 RVA: 0x0125F67B File Offset: 0x0125D87B
		public void SetGlobalStoppingTime(bool stoppingTime, float playTime, EEffectStoppingTimeSource source = EEffectStoppingTimeSource.ScenePaused)
		{
			UKuroEffectSystemFunctionLibrary.SetGlobalStoppingTime(stoppingTime, playTime, (int)source);
		}

		// Token: 0x06047D06 RID: 294150 RVA: 0x0125F688 File Offset: 0x0125D888
		public void AttachToEffectSkeletalMesh(int id, AActor attachActor, in FName? socketName, EAttachmentRule transformRule)
		{
			UKuroEffectSystemFunctionLibrary.AttachToEffectSkeletalMesh(id, attachActor, socketName ?? FName.NAME_None, transformRule);
		}

		// Token: 0x06047D07 RID: 294151 RVA: 0x0125F6BC File Offset: 0x0125D8BC
		public void AttachSkeletalMesh(int id, SkeletalMeshEffectContext context)
		{
			FKuroSkeletalMeshEffectContext fkuroSkeletalMeshEffectContext = KuroEffectSystem.CreateFEffectContext(context) as FKuroSkeletalMeshEffectContext;
			UKuroEffectSystemFunctionLibrary.AttachSkeletalMesh(id, fkuroSkeletalMeshEffectContext);
		}

		// Token: 0x06047D08 RID: 294152 RVA: 0x0125F6E0 File Offset: 0x0125D8E0
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

		// Token: 0x06047D09 RID: 294153 RVA: 0x0125F764 File Offset: 0x0125D964
		public void CollectMaterialFloatCurve(int id, in FName key, FKuroCurveFloat value)
		{
			UKuroEffectSystemFunctionLibrary.CollectMaterialFloatCurve(id, key, value);
		}

		// Token: 0x06047D0A RID: 294154 RVA: 0x0125F774 File Offset: 0x0125D974
		public void CollectMaterialVectorCurve(int id, in FName key, FKuroCurveVector value)
		{
			UKuroEffectSystemFunctionLibrary.CollectMaterialVectorCurve(id, key, value);
		}

		// Token: 0x06047D0B RID: 294155 RVA: 0x0125F784 File Offset: 0x0125D984
		public void CollectMaterialLinearColorCurve(int id, in FName key, FKuroCurveLinearColor value)
		{
			UKuroEffectSystemFunctionLibrary.CollectMaterialLinearColorCurve(id, key, value);
		}

		// Token: 0x06047D0C RID: 294156 RVA: 0x0125F794 File Offset: 0x0125D994
		[NullableContext(2)]
		public UEffectModelBase GetEffectModel(int id)
		{
			return UKuroEffectSystemFunctionLibrary.GetEffectModel(id);
		}

		// Token: 0x06047D0D RID: 294157 RVA: 0x0125F79C File Offset: 0x0125D99C
		public float GetTotalPassTime(int id)
		{
			return UKuroEffectSystemFunctionLibrary.GetTotalPassTime(id);
		}

		// Token: 0x06047D0E RID: 294158 RVA: 0x0125F7A4 File Offset: 0x0125D9A4
		public float GetPassTime(int id)
		{
			return UKuroEffectSystemFunctionLibrary.GetPassTime(id);
		}

		// Token: 0x06047D0F RID: 294159 RVA: 0x0125F7AC File Offset: 0x0125D9AC
		public bool GetHideOnBurstSkill(int id)
		{
			UEffectModelBase effectModel = this.GetEffectModel(id);
			return effectModel != null && effectModel.HideOnBurstSkill;
		}

		// Token: 0x06047D10 RID: 294160 RVA: 0x0125F7CC File Offset: 0x0125D9CC
		public void RegisterCustomCheckOwnerFunc(int id, Func<int, bool> func)
		{
			KuroEffectHandle kuroEffectHandle;
			if (this.EffectHandleMap.TryGetValue(id, out kuroEffectHandle))
			{
				kuroEffectHandle.OnCustomCheckOwner = func;
			}
		}

		// Token: 0x06047D11 RID: 294161 RVA: 0x0125F7F0 File Offset: 0x0125D9F0
		public void SetEffectQualityLevel(int id, int qualityLevel)
		{
			UKuroEffectSystemFunctionLibrary.SetEffectQualityLevel(id, qualityLevel);
		}

		// Token: 0x06047D12 RID: 294162 RVA: 0x0125F7FC File Offset: 0x0125D9FC
		public void TickHandleInEditor(int id, float delta)
		{
			UKuroEffectSystemFunctionLibrary.TickHandleInEditor(id, delta);
			KuroEffectHandle kuroEffectHandle;
			if (!Info.Instance.IsGameRunning() && this.EffectHandleMap.TryGetValue(id, out kuroEffectHandle) && kuroEffectHandle.IsLoop && !kuroEffectHandle.CheckOwner() && this.GetSureEffectActor(kuroEffectHandle.Id) is BP_EffectPreview_C)
			{
				this.StopEffectById(kuroEffectHandle.Id, "TickInEditor CheckOwner Failed", true, null);
			}
		}

		// Token: 0x06047D13 RID: 294163 RVA: 0x0125F86B File Offset: 0x0125DA6B
		public float GetLastPlayTime(int id)
		{
			return UKuroEffectSystemFunctionLibrary.GetLastPlayTime(id);
		}

		// Token: 0x06047D14 RID: 294164 RVA: 0x0125F873 File Offset: 0x0125DA73
		public float GetLastStopTime(int id)
		{
			return UKuroEffectSystemFunctionLibrary.GetLastStopTime(id);
		}

		// Token: 0x06047D15 RID: 294165 RVA: 0x0125F87B File Offset: 0x0125DA7B
		public void UpdateBodyEffect(int id, float opacity, bool visible, bool castShadow)
		{
			UKuroEffectSystemFunctionLibrary.UpdateBodyEffect(id, opacity, visible, castShadow);
		}

		// Token: 0x06047D16 RID: 294166 RVA: 0x0125F887 File Offset: 0x0125DA87
		public void DebugUpdate(int id, bool dDebugUpdate)
		{
			UKuroEffectSystemFunctionLibrary.DebugUpdate(id, dDebugUpdate);
		}

		// Token: 0x06047D17 RID: 294167 RVA: 0x0125F890 File Offset: 0x0125DA90
		public int GetEffectCount()
		{
			return UKuroEffectSystemFunctionLibrary.GetEffectCount();
		}

		// Token: 0x06047D18 RID: 294168 RVA: 0x0125F897 File Offset: 0x0125DA97
		public int GetActiveEffectCount()
		{
			return UKuroEffectSystemFunctionLibrary.GetActiveEffectCount();
		}

		// Token: 0x06047D19 RID: 294169 RVA: 0x0125F89E File Offset: 0x0125DA9E
		public void DebugPrintAllErrorEffects()
		{
			UKuroEffectSystemFunctionLibrary.DebugPrintAllErrorEffects();
		}

		// Token: 0x06047D1A RID: 294170 RVA: 0x0125F8A5 File Offset: 0x0125DAA5
		public void DebugPrintCurrentImportanceEffects()
		{
			UKuroEffectSystemFunctionLibrary.DebugPrintCurrentImportanceEffects();
		}

		// Token: 0x06047D1B RID: 294171 RVA: 0x0125F8AC File Offset: 0x0125DAAC
		public void DebugPrintEffect()
		{
			UKuroEffectSystemFunctionLibrary.DebugPrintEffect();
		}

		// Token: 0x06047D1C RID: 294172 RVA: 0x0125F8B3 File Offset: 0x0125DAB3
		public int GetPlayerEffectLruSize(int pos)
		{
			return UKuroEffectSystemFunctionLibrary.GetPlayerEffectLruSize(pos);
		}

		// Token: 0x06047D1D RID: 294173 RVA: 0x0125F8BC File Offset: 0x0125DABC
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

		// Token: 0x06047D1E RID: 294174 RVA: 0x0125FA74 File Offset: 0x0125DC74
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

		// Token: 0x06047D1F RID: 294175 RVA: 0x0125FB94 File Offset: 0x0125DD94
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

		// Token: 0x06047D20 RID: 294176 RVA: 0x0125FC30 File Offset: 0x0125DE30
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

		// Token: 0x06047D21 RID: 294177 RVA: 0x0125FCAC File Offset: 0x0125DEAC
		private static void SkeletalMeshSpecDestroyRenderingComponent(AActor effectActor, [Nullable(2)] UActorComponent renderingComponent)
		{
			CharRenderingComponent charRenderingComponent = (renderingComponent as CharRenderingComponent) ?? (effectActor.GetComponentByClass(CharRenderingComponent.StaticClass()) as CharRenderingComponent);
			if (charRenderingComponent != null)
			{
				charRenderingComponent.ResetAllRenderingState();
				charRenderingComponent.K2_DestroyComponent(charRenderingComponent);
			}
		}

		// Token: 0x06047D22 RID: 294178 RVA: 0x0125FCEC File Offset: 0x0125DEEC
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

		// Token: 0x06047D23 RID: 294179 RVA: 0x0125FD20 File Offset: 0x0125DF20
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

		// Token: 0x06047D24 RID: 294180 RVA: 0x0125FD7E File Offset: 0x0125DF7E
		private static FName EffectHandleGetOrAddEffectDynamicGroup(float effectEnableRange)
		{
			return GameBudgetAllocatorConfigCreator.Instance.GetEffectDynamicGroup((uint)effectEnableRange).GroupName;
		}

		// Token: 0x06047D25 RID: 294181 RVA: 0x0125FD94 File Offset: 0x0125DF94
		[return: Nullable(2)]
		private static UAkComponent AudioSystemGetAkComponent(bool fromPrimaryRole, AActor effectActor)
		{
			return AudioSystem.Instance.GetAkComponent(effectActor, new FName?(FName.NAME_None), delegate(AActor owner, UAkComponent _)
			{
				GameAudioController.Instance.SetRolePriority(fromPrimaryRole ? ERoleAudioPriorityType.PlayerControl : ERoleAudioPriorityType.OtherControl, owner);
			});
		}

		// Token: 0x06047D26 RID: 294182 RVA: 0x0125FDD4 File Offset: 0x0125DFD4
		private static void AudioSystemExecuteActionStop(int eventHandle, float fadeOutTime)
		{
			AudioSystem.Instance.ExecuteAction(eventHandle, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs
			{
				TransitionDuration = new int?((int)fadeOutTime)
			}));
		}

		// Token: 0x06047D27 RID: 294183 RVA: 0x0125FE0C File Offset: 0x0125E00C
		private static int AudioSystemPostEventTransform(string eventName, FTransformDouble transform)
		{
			return AudioSystem.Instance.PostEvent(eventName, new FTransformDouble?(transform), null);
		}

		// Token: 0x06047D28 RID: 294184 RVA: 0x0125FE34 File Offset: 0x0125E034
		private static int AudioSystemPostEventAkComponent(string eventName, [Nullable(2)] UAkComponent akComponent)
		{
			return AudioSystem.Instance.PostEvent(eventName, akComponent, null);
		}

		// Token: 0x06047D29 RID: 294185 RVA: 0x0125FE58 File Offset: 0x0125E058
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

		// Token: 0x06047D2A RID: 294186 RVA: 0x0125FF18 File Offset: 0x0125E118
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

		// Token: 0x06047D2B RID: 294187 RVA: 0x0125FFC4 File Offset: 0x0125E1C4
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

		// Token: 0x06047D2C RID: 294188 RVA: 0x01260022 File Offset: 0x0125E222
		[NullableContext(2)]
		private static AActor ActorSystemGet([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> ueClass, in FTransformDouble transform)
		{
			return ActorSystem.Instance.Get(ueClass, transform, null, true);
		}

		// Token: 0x06047D2D RID: 294189 RVA: 0x0126003C File Offset: 0x0125E23C
		private static bool ActorSystemPut(string reason, AActor actor)
		{
			return ActorSystem.Instance.Put(reason, actor, null);
		}

		// Token: 0x06047D2E RID: 294190 RVA: 0x0126004C File Offset: 0x0125E24C
		private static void EffectSystemSetEffectView(AActor effectActor, int effectId)
		{
			BP_EffectPreview_C bp_EffectPreview_C = effectActor as BP_EffectPreview_C;
			if (bp_EffectPreview_C != null)
			{
				bp_EffectPreview_C.EffectView = effectId;
			}
		}

		// Token: 0x06047D2F RID: 294191 RVA: 0x0126006C File Offset: 0x0125E26C
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

		// Token: 0x06047D30 RID: 294192 RVA: 0x012600D1 File Offset: 0x0125E2D1
		private static bool EffectSystemCheckMobileBlackEffect(string path)
		{
			return Info.Instance.IsMobilePlatform() && KuroEffectSystem.MOBILE_EFFECT_BLACK_LIST.Contains(path);
		}

		// Token: 0x06047D31 RID: 294193 RVA: 0x012600F0 File Offset: 0x0125E2F0
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

		// Token: 0x06047D32 RID: 294194 RVA: 0x01260225 File Offset: 0x0125E425
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

		// Token: 0x06047D33 RID: 294195 RVA: 0x0126023C File Offset: 0x0125E43C
		private static void EffectSpecUnregisterBodyEffect(int effectId, [Nullable(2)] AActor effectActor, USkeletalMeshComponent contextMeshComponent, UObject contextSourceObject, UEffectModelBase effectModel)
		{
			CharRenderingComponent charRenderingComponent = KuroEffectSystem.FindRenderingComponent(effectActor, contextMeshComponent, contextSourceObject, effectModel);
			if (charRenderingComponent == null)
			{
				return;
			}
			charRenderingComponent.UnregisterBodyEffect(effectId);
		}

		// Token: 0x06047D34 RID: 294196 RVA: 0x01260254 File Offset: 0x0125E454
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

		// Token: 0x06047D35 RID: 294197 RVA: 0x012602AC File Offset: 0x0125E4AC
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

		// Token: 0x06047D36 RID: 294198 RVA: 0x012602F4 File Offset: 0x0125E4F4
		[NullableContext(2)]
		private static AActor MaterialSpecSpawnRenderActor(USkeletalMeshComponent skeletalMeshComponent)
		{
			TSubclassOf<AActor> actorClass = BP_MaterialControllerRenderActor_C.StaticClass();
			FTransformDouble ftransformDouble = new FTransformDouble();
			return UKuroRenderingRuntimeBPPluginBPLibrary.D_SpawnActorFromClass(skeletalMeshComponent, actorClass, ftransformDouble, ESpawnActorCollisionHandlingMethod.Undefined, null, null, true);
		}

		// Token: 0x06047D37 RID: 294199 RVA: 0x01260320 File Offset: 0x0125E520
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

		// Token: 0x06047D38 RID: 294200 RVA: 0x0126036C File Offset: 0x0125E56C
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

		// Token: 0x06047D39 RID: 294201 RVA: 0x01260390 File Offset: 0x0125E590
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

		// Token: 0x06047D3A RID: 294202 RVA: 0x012603B3 File Offset: 0x0125E5B3
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

		// Token: 0x06047D3B RID: 294203 RVA: 0x012603C8 File Offset: 0x0125E5C8
		[NullableContext(2)]
		private static int EffectAudioControllerAddPlayEffectAudio(UEffectModelAudio effectModel, AActor effectActor, int effectType)
		{
			if (effectModel == null)
			{
				return 0;
			}
			return EffectAudioController.Instance.AddPlayEffectAudio(effectModel, effectActor, new EHitEffectType?((EHitEffectType)effectType), null, null, null);
		}

		// Token: 0x06047D3C RID: 294204 RVA: 0x0126040C File Offset: 0x0125E60C
		[NullableContext(2)]
		private static int EffectAudioControllerAddPlayEffectAudioPriority(UEffectModelAudio effectModel, AActor effectActor, int effectType, int priority)
		{
			if (effectModel == null)
			{
				return 0;
			}
			return EffectAudioController.Instance.AddPlayEffectAudio(effectModel, effectActor, new EHitEffectType?((EHitEffectType)effectType), new ERoleAudioPriorityType?((ERoleAudioPriorityType)priority), null, null);
		}

		// Token: 0x06047D3D RID: 294205 RVA: 0x0126044A File Offset: 0x0125E64A
		private static void EffectAudioControllerOnStopEffectAudio(int uid, string context)
		{
			EffectAudioController.Instance.OnStopEffectAudio(uid, context, true);
		}

		// Token: 0x04025BEB RID: 154603
		public bool PreviewInitState;

		// Token: 0x04025BEC RID: 154604
		private bool HasInitialize;

		// Token: 0x04025BED RID: 154605
		private readonly OrderedDictionary<int, KuroEffectHandle> EffectHandleMap = new OrderedDictionary<int, KuroEffectHandle>();

		// Token: 0x04025BEE RID: 154606
		private readonly OrderedDictionary<int, KuroEffectActorHandle> EffectActorHandleMap = new OrderedDictionary<int, KuroEffectActorHandle>();

		// Token: 0x04025BEF RID: 154607
		private readonly OrderedDictionary<int, KuroEffectNiagaraComponentHandle> EffectNiagaraHandleMap = new OrderedDictionary<int, KuroEffectNiagaraComponentHandle>();

		// Token: 0x04025BF0 RID: 154608
		private const string MIN_NIAGARA_SIMULATION_TICK_TIME = "0.033";

		// Token: 0x04025BF1 RID: 154609
		private const int CHECK_EFFECT_OWNER_INTERVAL = 60000;

		// Token: 0x04025BF2 RID: 154610
		private const string EFFECT_SPEC_DATA_PATH = "../Config/Client/EffectData/";

		// Token: 0x04025BF3 RID: 154611
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

		// Token: 0x04025BF4 RID: 154612
		private readonly TArray<FKuroSceneTeamItem> SceneTeamItems = new TArray<FKuroSceneTeamItem>();

		// Token: 0x04025BF5 RID: 154613
		private readonly List<SpecData> EffectForSpecArray = new List<SpecData>();

		// Token: 0x04025BF6 RID: 154614
		private readonly List<EffectSpecData> EffectForSpecDbCacheArray = new List<EffectSpecData>();

		// Token: 0x04025BF7 RID: 154615
		private float CheckEffectOwnerInterval = 60000f;

		// Token: 0x0200CF8B RID: 53131
		[NullableContext(0)]
		private enum EEffectContextType : byte
		{
			// Token: 0x0403E5F7 RID: 255479
			EEffectContextType_Base,
			// Token: 0x0403E5F8 RID: 255480
			EEffectContextType_Skeletal,
			// Token: 0x0403E5F9 RID: 255481
			EEffectContextType_Audio,
			// Token: 0x0403E5FA RID: 255482
			EEffectContextType_Ghost
		}

		// Token: 0x0200CF8C RID: 53132
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403E5FB RID: 255483
			[Nullable(0)]
			public static Action <0>__OnTimeScaleChange;

			// Token: 0x0403E5FC RID: 255484
			[Nullable(0)]
			public static Action <1>__OnSetNiagaraQuality;

			// Token: 0x0403E5FD RID: 255485
			[Nullable(0)]
			public static Action<EKuroUI3DState> <2>__OnGlobalUiSceneStateChanged;

			// Token: 0x0403E5FE RID: 255486
			[Nullable(0)]
			public static Action<bool> <3>__OnSetGamePaused;

			// Token: 0x0403E5FF RID: 255487
			[Nullable(new byte[]
			{
				0,
				2,
				2,
				2,
				2
			})]
			public static Func<float, UActorComponent, USkeletalMeshComponent, AActor, UActorComponent> <4>__SkeletalMeshSpecOnBodyEffectChange;

			// Token: 0x0403E600 RID: 255488
			[Nullable(new byte[]
			{
				0,
				2,
				2,
				2,
				2
			})]
			public static Func<UActorComponent, USkeletalMeshComponent, AActor, UActorComponent> <5>__SkeletalMeshSpecCreateRenderingComponent;

			// Token: 0x0403E601 RID: 255489
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Action<AActor, UActorComponent> <6>__SkeletalMeshSpecDestroyRenderingComponent;

			// Token: 0x0403E602 RID: 255490
			[Nullable(new byte[]
			{
				0,
				2
			})]
			public static Func<int, AActor> <7>__EffectHandleGetEntityOwnerActor;

			// Token: 0x0403E603 RID: 255491
			[Nullable(0)]
			public static Func<int, int> <8>__EffectHandleGetEntityModelConfigId;

			// Token: 0x0403E604 RID: 255492
			[Nullable(0)]
			public static Func<float, FName> <9>__EffectHandleGetOrAddEffectDynamicGroup;

			// Token: 0x0403E605 RID: 255493
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Func<bool, AActor, UAkComponent> <10>__AudioSystemGetAkComponent;

			// Token: 0x0403E606 RID: 255494
			[Nullable(0)]
			public static Action<int, float> <11>__AudioSystemExecuteActionStop;

			// Token: 0x0403E607 RID: 255495
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Func<string, FTransformDouble, int> <12>__AudioSystemPostEventTransform;

			// Token: 0x0403E608 RID: 255496
			[Nullable(new byte[]
			{
				0,
				1,
				2
			})]
			public static Func<string, UAkComponent, int> <13>__AudioSystemPostEventAkComponent;

			// Token: 0x0403E609 RID: 255497
			[Nullable(0)]
			public static Func<int, bool> <14>__NiagaraSpecIsNeedQualityBias;

			// Token: 0x0403E60A RID: 255498
			[Nullable(0)]
			public static Func<int, bool, bool> <15>__PostProcessSpecIsNeedPostEffect;

			// Token: 0x0403E60B RID: 255499
			[Nullable(0)]
			public static Func<int, bool> <16>__PostProcessSpecIsDisableInUltraSkill;

			// Token: 0x0403E60C RID: 255500
			[Nullable(0)]
			public static FActorSystemGetRetVal.FActorSystemGetRetVal_ScriptDelegate <17>__ActorSystemGet;

			// Token: 0x0403E60D RID: 255501
			[Nullable(new byte[]
			{
				0,
				1,
				2
			})]
			public static Func<string, AActor, bool> <18>__ActorSystemPut;

			// Token: 0x0403E60E RID: 255502
			[Nullable(new byte[]
			{
				0,
				2
			})]
			public static Action<AActor, int> <19>__EffectSystemSetEffectView;

			// Token: 0x0403E60F RID: 255503
			[Nullable(0)]
			public static Func<int, bool> <20>__EffectSystemCheckIsNetPlayer;

			// Token: 0x0403E610 RID: 255504
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Func<string, bool> <21>__EffectSystemCheckMobileBlackEffect;

			// Token: 0x0403E611 RID: 255505
			[Nullable(new byte[]
			{
				0,
				2,
				2,
				2,
				2
			})]
			public static Action<int, AActor, USkeletalMeshComponent, UObject, UEffectModelBase> <22>__EffectSpecRegisterBodyEffect;

			// Token: 0x0403E612 RID: 255506
			[Nullable(new byte[]
			{
				0,
				2,
				2,
				2,
				2
			})]
			public static Action<int, AActor, USkeletalMeshComponent, UObject, UEffectModelBase> <23>__EffectSpecUnregisterBodyEffect;

			// Token: 0x0403E613 RID: 255507
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Func<int, UObject, UKuroCharRenderingComponent> <24>__MaterialSpecGetRenderingComponentByContext;

			// Token: 0x0403E614 RID: 255508
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Func<USkeletalMeshComponent, UKuroCharRenderingComponent> <25>__MaterialSpecGetRenderingComponentBySkeletal;

			// Token: 0x0403E615 RID: 255509
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Func<USkeletalMeshComponent, AActor> <26>__MaterialSpecSpawnRenderActor;

			// Token: 0x0403E616 RID: 255510
			[Nullable(new byte[]
			{
				0,
				2,
				2,
				2
			})]
			public static Func<AActor, USkeletalMeshComponent, UKuroCharRenderingComponent> <27>__MaterialSpecGetRenderingComponentByRenderActor;

			// Token: 0x0403E617 RID: 255511
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Func<UKuroCharRenderingComponent, UKuroMaterialControllerDataAsset, int> <28>__MaterialSpecAddMaterialControllerData;

			// Token: 0x0403E618 RID: 255512
			[Nullable(new byte[]
			{
				0,
				2
			})]
			public static Action<UKuroCharRenderingComponent, int> <29>__MaterialSpecRemoveMaterialControllerData;

			// Token: 0x0403E619 RID: 255513
			[Nullable(new byte[]
			{
				0,
				2
			})]
			public static Action<UKuroCharRenderingComponent> <30>__MaterialSpecDestroyRenderingComponent;

			// Token: 0x0403E61A RID: 255514
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Func<UEffectModelAudio, AActor, int, int> <31>__EffectAudioControllerAddPlayEffectAudio;

			// Token: 0x0403E61B RID: 255515
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Func<UEffectModelAudio, AActor, int, int, int> <32>__EffectAudioControllerAddPlayEffectAudioPriority;

			// Token: 0x0403E61C RID: 255516
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Action<int, string> <33>__EffectAudioControllerOnStopEffectAudio;
		}
	}
}
