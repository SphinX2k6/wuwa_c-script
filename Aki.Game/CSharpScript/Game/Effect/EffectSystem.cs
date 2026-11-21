using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Common.Struct;
using CSharpScript.Core.Common;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;

namespace CSharpScript.Game.Effect
{
	// Token: 0x020063EA RID: 25578
	[NullableContext(1)]
	[Nullable(0)]
	public class EffectSystem : Singleton, ITickable
	{
		// Token: 0x0603DFD7 RID: 253911 RVA: 0x011FD4E8 File Offset: 0x011FB6E8
		public bool Initialize()
		{
			UKuroEffectSystemFunctionLibrary.SetUseDebugDrawNew(true);
			return this.KuroEffectSystemInstance.Initialize();
		}

		// Token: 0x0603DFD8 RID: 253912 RVA: 0x011FD4FB File Offset: 0x011FB6FB
		public bool Clear()
		{
			return this.KuroEffectSystemInstance.Clear();
		}

		// Token: 0x0603DFD9 RID: 253913 RVA: 0x011FD508 File Offset: 0x011FB708
		public void InitializeWithPreview(bool refresh)
		{
			if (Info.Instance.IsGameRunning())
			{
				return;
			}
			if (!this.KuroEffectSystemInstance.PreviewInitState)
			{
				this.KuroEffectSystemInstance.InitializeWithPreview(refresh);
			}
		}

		// Token: 0x0603DFDA RID: 253914 RVA: 0x011FD531 File Offset: 0x011FB731
		public void Tick(float delta)
		{
			this.KuroEffectSystemInstance.Tick(delta);
		}

		// Token: 0x0603DFDB RID: 253915 RVA: 0x011FD53F File Offset: 0x011FB73F
		public void AfterTick(float delta)
		{
		}

		// Token: 0x0603DFDC RID: 253916 RVA: 0x011FD541 File Offset: 0x011FB741
		public void ClearPool()
		{
			this.KuroEffectSystemInstance.ClearPool();
		}

		// Token: 0x0603DFDD RID: 253917 RVA: 0x011FD550 File Offset: 0x011FB750
		public int SpawnEffectWithActor(UObject worldContext, [Nullable(2)] AActor actor, string path, string reason, bool autoPlay = true, [Nullable(2)] EffectContext context = null, bool isExternalActor = true, EEffectType effectType = EEffectType.Scene)
		{
			return this.KuroEffectSystemInstance.SpawnEffectWithActor(worldContext, actor, path, reason, autoPlay, context, isExternalActor, effectType);
		}

		// Token: 0x0603DFDE RID: 253918 RVA: 0x011FD575 File Offset: 0x011FB775
		public void RemoveKuroEffectHandle(int effectId)
		{
			this.KuroEffectSystemInstance.RemoveKuroEffectHandle(effectId);
		}

		// Token: 0x0603DFDF RID: 253919 RVA: 0x011FD583 File Offset: 0x011FB783
		public int GetEffectLruCount(string path)
		{
			return this.KuroEffectSystemInstance.GetEffectLruCount(path);
		}

		// Token: 0x0603DFE0 RID: 253920 RVA: 0x011FD591 File Offset: 0x011FB791
		public int GetEffectLruCapacity()
		{
			return this.KuroEffectSystemInstance.GetEffectLruCapacity();
		}

		// Token: 0x0603DFE1 RID: 253921 RVA: 0x011FD59E File Offset: 0x011FB79E
		public void SetEffectLruCapacity(int capacity)
		{
			this.KuroEffectSystemInstance.SetEffectLruCapacity(capacity);
		}

		// Token: 0x0603DFE2 RID: 253922 RVA: 0x011FD5AC File Offset: 0x011FB7AC
		public int GetEffectLruSize()
		{
			return this.KuroEffectSystemInstance.GetEffectLruSize();
		}

		// Token: 0x0603DFE3 RID: 253923 RVA: 0x011FD5BC File Offset: 0x011FB7BC
		[NullableContext(2)]
		public int SpawnUnloopedEffect(UObject worldContext, in FTransformDouble? transform, string path, [Nullable(1)] string reason, EffectContext context = null, EEffectType effectType = EEffectType.Scene, Action<int> beforeInitCallback = null, Action<ELoadEffectResult, int> callback = null, Action<int> beforePlayCallback = null, bool prepare = false, bool forceCreateActor = false)
		{
			if (path != null && EffectSystem.EFFECT_BLACK_LIST.Contains(path))
			{
				return 0;
			}
			return this.KuroEffectSystemInstance.SpawnUnloopedEffect(worldContext, transform, path, reason, context, effectType, beforeInitCallback, callback, beforePlayCallback, prepare, forceCreateActor);
		}

		// Token: 0x0603DFE4 RID: 253924 RVA: 0x011FD5FC File Offset: 0x011FB7FC
		[NullableContext(2)]
		public int SpawnEffect(UObject worldContext, in FTransformDouble? transform, string path, [Nullable(1)] string reason, EffectContext context = null, EEffectType effectType = EEffectType.Scene, Action<int> beforeInitCallback = null, Action<ELoadEffectResult, int> callback = null, Action<int> beforePlayCallback = null, bool prepare = false, bool forceCreateActor = false)
		{
			if (path != null && EffectSystem.EFFECT_BLACK_LIST.Contains(path))
			{
				return 0;
			}
			return this.KuroEffectSystemInstance.SpawnEffect(worldContext, transform, path, reason, context, effectType, beforeInitCallback, callback, beforePlayCallback, prepare, forceCreateActor);
		}

		// Token: 0x0603DFE5 RID: 253925 RVA: 0x011FD639 File Offset: 0x011FB839
		public void DynamicRegisterSpawnCallback(int effectId, Action<ELoadEffectResult, int> callback)
		{
			this.KuroEffectSystemInstance.DynamicRegisterSpawnCallback(effectId, callback);
		}

		// Token: 0x0603DFE6 RID: 253926 RVA: 0x011FD648 File Offset: 0x011FB848
		public void ForceCheckPendingInit(int handle)
		{
			this.KuroEffectSystemInstance.ForceCheckPendingInit(handle);
		}

		// Token: 0x0603DFE7 RID: 253927 RVA: 0x011FD656 File Offset: 0x011FB856
		[NullableContext(2)]
		public void SetEffectHidden(int handle, bool bHidden, string reason = null, bool isLogic = false)
		{
			this.KuroEffectSystemInstance.SetEffectHidden(handle, bHidden, reason, isLogic);
		}

		// Token: 0x0603DFE8 RID: 253928 RVA: 0x011FD668 File Offset: 0x011FB868
		public bool StopEffectById(int handle, string reason, bool immediately, bool? destroyActor = null)
		{
			return this.KuroEffectSystemInstance.StopEffectById(handle, reason, immediately, destroyActor);
		}

		// Token: 0x0603DFE9 RID: 253929 RVA: 0x011FD67A File Offset: 0x011FB87A
		public bool IsValid(int id)
		{
			return this.KuroEffectSystemInstance.IsValid(id);
		}

		// Token: 0x0603DFEA RID: 253930 RVA: 0x011FD688 File Offset: 0x011FB888
		public void AddFinishCallback(int id, Action<int> callback)
		{
			this.KuroEffectSystemInstance.AddFinishCallback(id, callback);
		}

		// Token: 0x0603DFEB RID: 253931 RVA: 0x011FD697 File Offset: 0x011FB897
		public void RemoveFinishCallback(int id, Action<int> callback)
		{
			this.KuroEffectSystemInstance.RemoveFinishCallback(id, callback);
		}

		// Token: 0x0603DFEC RID: 253932 RVA: 0x011FD6A6 File Offset: 0x011FB8A6
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public OneOf<KuroEffectActorHandle, AActor> GetEffectActor(int id)
		{
			return this.KuroEffectSystemInstance.GetEffectActor(id);
		}

		// Token: 0x0603DFED RID: 253933 RVA: 0x011FD6B4 File Offset: 0x011FB8B4
		[NullableContext(2)]
		public AActor GetSureEffectActor(int id)
		{
			return this.KuroEffectSystemInstance.GetSureEffectActor(id);
		}

		// Token: 0x0603DFEE RID: 253934 RVA: 0x011FD6C2 File Offset: 0x011FB8C2
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public OneOf<KuroEffectNiagaraComponentHandle, UNiagaraComponent> GetNiagaraComponent(int id)
		{
			return this.KuroEffectSystemInstance.GetNiagaraComponent(id);
		}

		// Token: 0x0603DFEF RID: 253935 RVA: 0x011FD6D0 File Offset: 0x011FB8D0
		[NullableContext(2)]
		public UNiagaraComponent GetSureNiagaraComponent(int id)
		{
			return this.KuroEffectSystemInstance.GetSureNiagaraComponent(id);
		}

		// Token: 0x0603DFF0 RID: 253936 RVA: 0x011FD6DE File Offset: 0x011FB8DE
		public void ReplayEffect(int id, string reason, in FTransformDouble? transform = null)
		{
			this.KuroEffectSystemInstance.ReplayEffect(id, reason, transform);
		}

		// Token: 0x0603DFF1 RID: 253937 RVA: 0x011FD6EE File Offset: 0x011FB8EE
		public bool IsPlaying(int id)
		{
			return this.KuroEffectSystemInstance.IsPlaying(id);
		}

		// Token: 0x0603DFF2 RID: 253938 RVA: 0x011FD6FC File Offset: 0x011FB8FC
		public void SetHandleLifeCycle(int id, float time)
		{
			this.KuroEffectSystemInstance.SetHandleLifeCycle(id, time);
		}

		// Token: 0x0603DFF3 RID: 253939 RVA: 0x011FD70B File Offset: 0x011FB90B
		public void SetTimeScale(int id, float timeScale, bool ignoreGlobalTimeScale = false)
		{
			this.KuroEffectSystemInstance.SetTimeScale(id, timeScale, ignoreGlobalTimeScale);
		}

		// Token: 0x0603DFF4 RID: 253940 RVA: 0x011FD71B File Offset: 0x011FB91B
		public void SetAdditionTimeScale(ETimeScaleSourceType sourceType, int id, float timeScale)
		{
			this.KuroEffectSystemInstance.SetAdditionTimeScale((int)sourceType, id, timeScale);
		}

		// Token: 0x0603DFF5 RID: 253941 RVA: 0x011FD72B File Offset: 0x011FB92B
		public void SetAdditionTimeScaleEnable(ETimeScaleSourceType sourceType, bool enable)
		{
			this.KuroEffectSystemInstance.SetAdditionTimeScaleEnable((int)sourceType, enable);
		}

		// Token: 0x0603DFF6 RID: 253942 RVA: 0x011FD73A File Offset: 0x011FB93A
		public bool GetAdditionTimeScaleEnable(ETimeScaleSourceType sourceType)
		{
			return this.KuroEffectSystemInstance.GetAdditionTimeScaleEnable((int)sourceType);
		}

		// Token: 0x0603DFF7 RID: 253943 RVA: 0x011FD748 File Offset: 0x011FB948
		public void FreezeHandle(int id, bool freeze, bool force = false)
		{
			this.KuroEffectSystemInstance.FreezeHandle(id, freeze, force);
		}

		// Token: 0x0603DFF8 RID: 253944 RVA: 0x011FD758 File Offset: 0x011FB958
		public bool IsHandleFreeze(int id)
		{
			return this.KuroEffectSystemInstance.IsHandleFreeze(id);
		}

		// Token: 0x0603DFF9 RID: 253945 RVA: 0x011FD766 File Offset: 0x011FB966
		public bool HandleSeekToTime(int id, float time, bool autoLoop, bool force = false)
		{
			return this.KuroEffectSystemInstance.HandleSeekToTime(id, time, autoLoop, force);
		}

		// Token: 0x0603DFFA RID: 253946 RVA: 0x011FD778 File Offset: 0x011FB978
		public void HandleSeekToTimeWithProcess(int id, float time, bool seekContinue = false, float delta = -1f)
		{
			this.KuroEffectSystemInstance.HandleSeekToTimeWithProcess(id, time, seekContinue, delta);
		}

		// Token: 0x0603DFFB RID: 253947 RVA: 0x011FD78A File Offset: 0x011FB98A
		public float GetSeekToTargetTime(int id)
		{
			return this.KuroEffectSystemInstance.GetSeekToTargetTime(id);
		}

		// Token: 0x0603DFFC RID: 253948 RVA: 0x011FD798 File Offset: 0x011FB998
		public void SetEffectNotRecord(int id, bool notRecord = true)
		{
			this.KuroEffectSystemInstance.SetEffectNotRecord(id, notRecord);
		}

		// Token: 0x0603DFFD RID: 253949 RVA: 0x011FD7A7 File Offset: 0x011FB9A7
		public string GetPath(int id)
		{
			return this.KuroEffectSystemInstance.GetPath(id);
		}

		// Token: 0x0603DFFE RID: 253950 RVA: 0x011FD7B5 File Offset: 0x011FB9B5
		public void SetEffectDataByNiagaraParam(int id, SNiagaraParam niagaraParam, bool resetPassTime)
		{
			this.KuroEffectSystemInstance.SetEffectDataByNiagaraParam(id, niagaraParam, resetPassTime);
		}

		// Token: 0x0603DFFF RID: 253951 RVA: 0x011FD7C5 File Offset: 0x011FB9C5
		[NullableContext(2)]
		public void SetEffectParameterNiagara(int id, EffectParameterNiagara parameter)
		{
			this.KuroEffectSystemInstance.SetEffectParameterNiagara(id, parameter);
		}

		// Token: 0x0603E000 RID: 253952 RVA: 0x011FD7D4 File Offset: 0x011FB9D4
		public void SetEffectDataFloatConstParam(int id, in FName paramName, float value)
		{
			this.KuroEffectSystemInstance.SetEffectDataFloatConstParam(id, paramName, value);
		}

		// Token: 0x0603E001 RID: 253953 RVA: 0x011FD7E4 File Offset: 0x011FB9E4
		public void SetEffectExtraState(int effectId, int extraState)
		{
			this.KuroEffectSystemInstance.SetEffectExtraState(effectId, extraState);
		}

		// Token: 0x0603E002 RID: 253954 RVA: 0x011FD7F3 File Offset: 0x011FB9F3
		public void SetEffectIgnoreVisibilityOptimize(int effectId, bool ignore)
		{
			this.KuroEffectSystemInstance.SetEffectIgnoreVisibilityOptimize(effectId, ignore);
		}

		// Token: 0x0603E003 RID: 253955 RVA: 0x011FD802 File Offset: 0x011FBA02
		public void SetEffectStoppingTime(int effectId, bool stoppingTime, EEffectStoppingTimeSource source = EEffectStoppingTimeSource.ScenePaused)
		{
			this.KuroEffectSystemInstance.SetEffectStoppingTime(effectId, stoppingTime, source);
		}

		// Token: 0x0603E004 RID: 253956 RVA: 0x011FD812 File Offset: 0x011FBA12
		public void SetEffectStoppingTimeFromEntity(int entityId, bool stoppingTime, EEffectStoppingTimeSource source = EEffectStoppingTimeSource.ScenePaused)
		{
			this.KuroEffectSystemInstance.SetEffectStoppingTimeFromEntity(entityId, stoppingTime, source);
		}

		// Token: 0x0603E005 RID: 253957 RVA: 0x011FD822 File Offset: 0x011FBA22
		public void SetEntityUltraSkillState(int entityId, bool inUltraSkill)
		{
			this.KuroEffectSystemInstance.SetEntityUltraSkillState(entityId, inUltraSkill);
		}

		// Token: 0x0603E006 RID: 253958 RVA: 0x011FD831 File Offset: 0x011FBA31
		public bool IsEntityInUltraSkill(int entityId)
		{
			return this.KuroEffectSystemInstance.IsEntityInUltraSkill(entityId);
		}

		// Token: 0x0603E007 RID: 253959 RVA: 0x011FD83F File Offset: 0x011FBA3F
		public void ClearUltraSkillState()
		{
			this.KuroEffectSystemInstance.ClearUltraSkillState();
		}

		// Token: 0x0603E008 RID: 253960 RVA: 0x011FD84C File Offset: 0x011FBA4C
		public float GlobalStoppingPlayTime(EEffectStoppingTimeSource source = EEffectStoppingTimeSource.ScenePaused)
		{
			return this.KuroEffectSystemInstance.GlobalStoppingPlayTime(source);
		}

		// Token: 0x0603E009 RID: 253961 RVA: 0x011FD85A File Offset: 0x011FBA5A
		public bool GlobalStoppingTime(EEffectStoppingTimeSource source = EEffectStoppingTimeSource.ScenePaused)
		{
			return this.KuroEffectSystemInstance.GlobalStoppingTime(source);
		}

		// Token: 0x0603E00A RID: 253962 RVA: 0x011FD868 File Offset: 0x011FBA68
		public void SetGlobalStoppingTime(bool stoppingTime, float playTime, EEffectStoppingTimeSource source = EEffectStoppingTimeSource.ScenePaused)
		{
			this.KuroEffectSystemInstance.SetGlobalStoppingTime(stoppingTime, playTime, source);
		}

		// Token: 0x0603E00B RID: 253963 RVA: 0x011FD878 File Offset: 0x011FBA78
		public void AttachToEffectSkeletalMesh(int id, AActor attachActor, in FName? socketName, EAttachmentRule transformRule)
		{
			this.KuroEffectSystemInstance.AttachToEffectSkeletalMesh(id, attachActor, socketName, transformRule);
		}

		// Token: 0x0603E00C RID: 253964 RVA: 0x011FD88A File Offset: 0x011FBA8A
		public void AttachSkeletalMesh(int id, SkeletalMeshEffectContext context)
		{
			this.KuroEffectSystemInstance.AttachSkeletalMesh(id, context);
		}

		// Token: 0x0603E00D RID: 253965 RVA: 0x011FD899 File Offset: 0x011FBA99
		public void CollectMaterialFloatCurve(int id, in FName key, FKuroCurveFloat value)
		{
			this.KuroEffectSystemInstance.CollectMaterialFloatCurve(id, key, value);
		}

		// Token: 0x0603E00E RID: 253966 RVA: 0x011FD8A9 File Offset: 0x011FBAA9
		public void CollectMaterialVectorCurve(int id, in FName key, FKuroCurveVector value)
		{
			this.KuroEffectSystemInstance.CollectMaterialVectorCurve(id, key, value);
		}

		// Token: 0x0603E00F RID: 253967 RVA: 0x011FD8B9 File Offset: 0x011FBAB9
		public void CollectMaterialLinearColorCurve(int id, in FName key, FKuroCurveLinearColor value)
		{
			this.KuroEffectSystemInstance.CollectMaterialLinearColorCurve(id, key, value);
		}

		// Token: 0x0603E010 RID: 253968 RVA: 0x011FD8C9 File Offset: 0x011FBAC9
		[NullableContext(2)]
		public UEffectModelBase GetEffectModel(int id)
		{
			return this.KuroEffectSystemInstance.GetEffectModel(id);
		}

		// Token: 0x0603E011 RID: 253969 RVA: 0x011FD8D7 File Offset: 0x011FBAD7
		public float GetTotalPassTime(int id)
		{
			return this.KuroEffectSystemInstance.GetTotalPassTime(id);
		}

		// Token: 0x0603E012 RID: 253970 RVA: 0x011FD8E5 File Offset: 0x011FBAE5
		public float GetPassTime(int id)
		{
			return this.KuroEffectSystemInstance.GetPassTime(id);
		}

		// Token: 0x0603E013 RID: 253971 RVA: 0x011FD8F3 File Offset: 0x011FBAF3
		public bool GetHideOnBurstSkill(int id)
		{
			return this.KuroEffectSystemInstance.GetHideOnBurstSkill(id);
		}

		// Token: 0x0603E014 RID: 253972 RVA: 0x011FD901 File Offset: 0x011FBB01
		public void RegisterCustomCheckOwnerFunc(int id, Func<int, bool> func)
		{
			this.KuroEffectSystemInstance.RegisterCustomCheckOwnerFunc(id, func);
		}

		// Token: 0x0603E015 RID: 253973 RVA: 0x011FD910 File Offset: 0x011FBB10
		public void EnableNiagaraDownSampling()
		{
			Log.Instance.Info(ELogModule.RenderEffect, ELogAuthor.WLJ, "Enable Niagara Down Sampling", default(ReadOnlySpan<ValueTuple<string, object>>));
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "Kuro.Niagara.SystemSimulation.TickOptimizeEnable 1", null);
		}

		// Token: 0x0603E016 RID: 253974 RVA: 0x011FD94C File Offset: 0x011FBB4C
		public void DisableNiagaraDownSampling()
		{
			Log.Instance.Info(ELogModule.RenderEffect, ELogAuthor.WLJ, "Disable Niagara Down Sampling", default(ReadOnlySpan<ValueTuple<string, object>>));
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "Kuro.Niagara.SystemSimulation.TickOptimizeEnable 0", null);
		}

		// Token: 0x0603E017 RID: 253975 RVA: 0x011FD985 File Offset: 0x011FBB85
		public void SetEffectQualityLevel(int id, int qualityLevel)
		{
			this.KuroEffectSystemInstance.SetEffectQualityLevel(id, qualityLevel);
		}

		// Token: 0x0603E018 RID: 253976 RVA: 0x011FD994 File Offset: 0x011FBB94
		public void TickHandleInEditor(int id, float delta)
		{
			this.KuroEffectSystemInstance.TickHandleInEditor(id, delta);
		}

		// Token: 0x0603E019 RID: 253977 RVA: 0x011FD9A3 File Offset: 0x011FBBA3
		public float GetLastPlayTime(int id)
		{
			return this.KuroEffectSystemInstance.GetLastPlayTime(id);
		}

		// Token: 0x0603E01A RID: 253978 RVA: 0x011FD9B1 File Offset: 0x011FBBB1
		public float GetLastStopTime(int id)
		{
			return this.KuroEffectSystemInstance.GetLastStopTime(id);
		}

		// Token: 0x0603E01B RID: 253979 RVA: 0x011FD9BF File Offset: 0x011FBBBF
		public void UpdateBodyEffect(int id, float opacity, bool visible, bool castShadow)
		{
			this.KuroEffectSystemInstance.UpdateBodyEffect(id, opacity, visible, castShadow);
		}

		// Token: 0x0603E01C RID: 253980 RVA: 0x011FD9D1 File Offset: 0x011FBBD1
		public void DebugUpdate(int id, bool dDebugUpdate)
		{
			this.KuroEffectSystemInstance.DebugUpdate(id, dDebugUpdate);
		}

		// Token: 0x0603E01D RID: 253981 RVA: 0x011FD9E0 File Offset: 0x011FBBE0
		public int GetEffectCount()
		{
			return this.KuroEffectSystemInstance.GetEffectCount();
		}

		// Token: 0x0603E01E RID: 253982 RVA: 0x011FD9ED File Offset: 0x011FBBED
		public int GetActiveEffectCount()
		{
			return this.KuroEffectSystemInstance.GetActiveEffectCount();
		}

		// Token: 0x0603E01F RID: 253983 RVA: 0x011FD9FA File Offset: 0x011FBBFA
		public void DebugPrintAllErrorEffects()
		{
			this.KuroEffectSystemInstance.DebugPrintAllErrorEffects();
		}

		// Token: 0x0603E020 RID: 253984 RVA: 0x011FDA07 File Offset: 0x011FBC07
		public void DebugPrintCurrentImportanceEffects()
		{
			this.KuroEffectSystemInstance.DebugPrintCurrentImportanceEffects();
		}

		// Token: 0x0603E021 RID: 253985 RVA: 0x011FDA14 File Offset: 0x011FBC14
		public void DebugPrintEffect()
		{
			this.KuroEffectSystemInstance.DebugPrintEffect();
		}

		// Token: 0x0603E022 RID: 253986 RVA: 0x011FDA21 File Offset: 0x011FBC21
		public int GetPlayerEffectLruSize(int pos)
		{
			return this.KuroEffectSystemInstance.GetPlayerEffectLruSize(pos);
		}

		// Token: 0x0603E023 RID: 253987 RVA: 0x011FDA2F File Offset: 0x011FBC2F
		public void SetEffectStartRecording(Vector tempVector, Vector centerLocation, float recordDistSquared, Action<int, AActor> onEffectRecorded)
		{
			this.KuroEffectSystemInstance.SetEffectStartRecording(tempVector, centerLocation, recordDistSquared, onEffectRecorded);
		}

		// Token: 0x0603E024 RID: 253988 RVA: 0x011FDA41 File Offset: 0x011FBC41
		public static void RefreshEffectSpecData(Dictionary<string, SpecData> specDataMap)
		{
			EffectSystem.Instance.KuroEffectSystemInstance.RefreshEffectSpecData(specDataMap);
		}

		// Token: 0x170075E2 RID: 30178
		// (get) Token: 0x0603E025 RID: 253989 RVA: 0x011FDA53 File Offset: 0x011FBC53
		public static EffectSystem Instance
		{
			get
			{
				if (EffectSystem._instance == null)
				{
					EffectSystem._instance = new EffectSystem();
					EffectSystem._instance.OnInit();
				}
				return EffectSystem._instance;
			}
		}

		// Token: 0x0603E026 RID: 253990 RVA: 0x011FDA76 File Offset: 0x011FBC76
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603E027 RID: 253991 RVA: 0x011FDA78 File Offset: 0x011FBC78
		public static void ResetStaticDefaultValue()
		{
			EffectSystem instance = EffectSystem._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			EffectSystem._instance = null;
		}

		// Token: 0x0603E028 RID: 253992 RVA: 0x011FDA91 File Offset: 0x011FBC91
		static EffectSystem()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(EffectSystem.CreateStaticDefaultValue), new Action(EffectSystem.ResetStaticDefaultValue));
		}

		// Token: 0x04020E7D RID: 134781
		public const int EFFECT_REASON_LENGTH_LIMIT = 4;

		// Token: 0x04020E7E RID: 134782
		public const int EFFECT_LIFETIME_FLOAT_TO_INT = 10000;

		// Token: 0x04020E7F RID: 134783
		[StaticVariableRuleIgnore]
		private static readonly HashSet<string> EFFECT_BLACK_LIST = new HashSet<string>
		{
			"/Game/Aki/Scene/EffectDataAsset/DA_Base/DA_ClusterStuff/Dust/DA_Fx_Sc3_Cluster_Dust_PMMD.DA_Fx_Sc3_Cluster_Dust_PMMD"
		};

		// Token: 0x04020E80 RID: 134784
		private readonly KuroEffectSystem KuroEffectSystemInstance = new KuroEffectSystem();

		// Token: 0x04020E81 RID: 134785
		[Nullable(2)]
		private static EffectSystem _instance;
	}
}
