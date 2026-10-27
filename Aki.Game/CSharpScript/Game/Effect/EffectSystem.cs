using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Common.Struct;
using CSharpScript.Core.Common;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;

namespace CSharpScript.Game.Effect
{
	// Token: 0x0200726B RID: 29291
	[NullableContext(1)]
	[Nullable(0)]
	public class EffectSystem : Singleton, ITickable
	{
		// Token: 0x06047C1D RID: 293917 RVA: 0x0125CB80 File Offset: 0x0125AD80
		public bool Initialize()
		{
			UKuroEffectSystemFunctionLibrary.SetUseDebugDrawNew(true);
			return this.KuroEffectSystemInstance.Initialize();
		}

		// Token: 0x06047C1E RID: 293918 RVA: 0x0125CB93 File Offset: 0x0125AD93
		public bool Clear()
		{
			return this.KuroEffectSystemInstance.Clear();
		}

		// Token: 0x06047C1F RID: 293919 RVA: 0x0125CBA0 File Offset: 0x0125ADA0
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

		// Token: 0x06047C20 RID: 293920 RVA: 0x0125CBC9 File Offset: 0x0125ADC9
		public void Tick(float delta)
		{
			this.KuroEffectSystemInstance.Tick(delta);
		}

		// Token: 0x06047C21 RID: 293921 RVA: 0x0125CBD7 File Offset: 0x0125ADD7
		public void AfterTick(float delta)
		{
		}

		// Token: 0x06047C22 RID: 293922 RVA: 0x0125CBD9 File Offset: 0x0125ADD9
		public void ClearPool()
		{
			this.KuroEffectSystemInstance.ClearPool();
		}

		// Token: 0x06047C23 RID: 293923 RVA: 0x0125CBE8 File Offset: 0x0125ADE8
		public int SpawnEffectWithActor(UObject worldContext, [Nullable(2)] AActor actor, string path, string reason, bool autoPlay = true, [Nullable(2)] EffectContext context = null, bool isExternalActor = true, EEffectType effectType = EEffectType.Scene)
		{
			return this.KuroEffectSystemInstance.SpawnEffectWithActor(worldContext, actor, path, reason, autoPlay, context, isExternalActor, effectType);
		}

		// Token: 0x06047C24 RID: 293924 RVA: 0x0125CC0D File Offset: 0x0125AE0D
		public void RemoveKuroEffectHandle(int effectId)
		{
			this.KuroEffectSystemInstance.RemoveKuroEffectHandle(effectId);
		}

		// Token: 0x06047C25 RID: 293925 RVA: 0x0125CC1B File Offset: 0x0125AE1B
		public int GetEffectLruCount(string path)
		{
			return this.KuroEffectSystemInstance.GetEffectLruCount(path);
		}

		// Token: 0x06047C26 RID: 293926 RVA: 0x0125CC29 File Offset: 0x0125AE29
		public int GetEffectLruCapacity()
		{
			return this.KuroEffectSystemInstance.GetEffectLruCapacity();
		}

		// Token: 0x06047C27 RID: 293927 RVA: 0x0125CC36 File Offset: 0x0125AE36
		public void SetEffectLruCapacity(int capacity)
		{
			this.KuroEffectSystemInstance.SetEffectLruCapacity(capacity);
		}

		// Token: 0x06047C28 RID: 293928 RVA: 0x0125CC44 File Offset: 0x0125AE44
		public int GetEffectLruSize()
		{
			return this.KuroEffectSystemInstance.GetEffectLruSize();
		}

		// Token: 0x06047C29 RID: 293929 RVA: 0x0125CC54 File Offset: 0x0125AE54
		[NullableContext(2)]
		public int SpawnUnloopedEffect(UObject worldContext, in FTransformDouble? transform, string path, [Nullable(1)] string reason, EffectContext context = null, EEffectType effectType = EEffectType.Scene, Action<int> beforeInitCallback = null, Action<ELoadEffectResult, int> callback = null, Action<int> beforePlayCallback = null, bool prepare = false, bool forceCreateActor = false)
		{
			if (path != null && EffectSystem.EFFECT_BLACK_LIST.Contains(path))
			{
				return 0;
			}
			return this.KuroEffectSystemInstance.SpawnUnloopedEffect(worldContext, transform, path, reason, context, effectType, beforeInitCallback, callback, beforePlayCallback, prepare, forceCreateActor);
		}

		// Token: 0x06047C2A RID: 293930 RVA: 0x0125CC94 File Offset: 0x0125AE94
		[NullableContext(2)]
		public int SpawnEffect(UObject worldContext, in FTransformDouble? transform, string path, [Nullable(1)] string reason, EffectContext context = null, EEffectType effectType = EEffectType.Scene, Action<int> beforeInitCallback = null, Action<ELoadEffectResult, int> callback = null, Action<int> beforePlayCallback = null, bool prepare = false, bool forceCreateActor = false)
		{
			if (path != null && EffectSystem.EFFECT_BLACK_LIST.Contains(path))
			{
				return 0;
			}
			return this.KuroEffectSystemInstance.SpawnEffect(worldContext, transform, path, reason, context, effectType, beforeInitCallback, callback, beforePlayCallback, prepare, forceCreateActor);
		}

		// Token: 0x06047C2B RID: 293931 RVA: 0x0125CCD1 File Offset: 0x0125AED1
		public void DynamicRegisterSpawnCallback(int effectId, Action<ELoadEffectResult, int> callback)
		{
			this.KuroEffectSystemInstance.DynamicRegisterSpawnCallback(effectId, callback);
		}

		// Token: 0x06047C2C RID: 293932 RVA: 0x0125CCE0 File Offset: 0x0125AEE0
		public void ForceCheckPendingInit(int handle)
		{
			this.KuroEffectSystemInstance.ForceCheckPendingInit(handle);
		}

		// Token: 0x06047C2D RID: 293933 RVA: 0x0125CCEE File Offset: 0x0125AEEE
		[NullableContext(2)]
		public void SetEffectHidden(int handle, bool bHidden, string reason = null, bool isLogic = false)
		{
			this.KuroEffectSystemInstance.SetEffectHidden(handle, bHidden, reason, isLogic);
		}

		// Token: 0x06047C2E RID: 293934 RVA: 0x0125CD00 File Offset: 0x0125AF00
		public bool StopEffectById(int handle, string reason, bool immediately, bool? destroyActor = null)
		{
			return this.KuroEffectSystemInstance.StopEffectById(handle, reason, immediately, destroyActor);
		}

		// Token: 0x06047C2F RID: 293935 RVA: 0x0125CD12 File Offset: 0x0125AF12
		public bool IsValid(int id)
		{
			return this.KuroEffectSystemInstance.IsValid(id);
		}

		// Token: 0x06047C30 RID: 293936 RVA: 0x0125CD20 File Offset: 0x0125AF20
		public void AddFinishCallback(int id, Action<int> callback)
		{
			this.KuroEffectSystemInstance.AddFinishCallback(id, callback);
		}

		// Token: 0x06047C31 RID: 293937 RVA: 0x0125CD2F File Offset: 0x0125AF2F
		public void RemoveFinishCallback(int id, Action<int> callback)
		{
			this.KuroEffectSystemInstance.RemoveFinishCallback(id, callback);
		}

		// Token: 0x06047C32 RID: 293938 RVA: 0x0125CD3E File Offset: 0x0125AF3E
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

		// Token: 0x06047C33 RID: 293939 RVA: 0x0125CD4C File Offset: 0x0125AF4C
		[NullableContext(2)]
		public AActor GetSureEffectActor(int id)
		{
			return this.KuroEffectSystemInstance.GetSureEffectActor(id);
		}

		// Token: 0x06047C34 RID: 293940 RVA: 0x0125CD5A File Offset: 0x0125AF5A
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

		// Token: 0x06047C35 RID: 293941 RVA: 0x0125CD68 File Offset: 0x0125AF68
		[NullableContext(2)]
		public UNiagaraComponent GetSureNiagaraComponent(int id)
		{
			return this.KuroEffectSystemInstance.GetSureNiagaraComponent(id);
		}

		// Token: 0x06047C36 RID: 293942 RVA: 0x0125CD76 File Offset: 0x0125AF76
		public void ReplayEffect(int id, string reason, in FTransformDouble? transform = null)
		{
			this.KuroEffectSystemInstance.ReplayEffect(id, reason, transform);
		}

		// Token: 0x06047C37 RID: 293943 RVA: 0x0125CD86 File Offset: 0x0125AF86
		public bool IsPlaying(int id)
		{
			return this.KuroEffectSystemInstance.IsPlaying(id);
		}

		// Token: 0x06047C38 RID: 293944 RVA: 0x0125CD94 File Offset: 0x0125AF94
		public void SetHandleLifeCycle(int id, float time)
		{
			this.KuroEffectSystemInstance.SetHandleLifeCycle(id, time);
		}

		// Token: 0x06047C39 RID: 293945 RVA: 0x0125CDA3 File Offset: 0x0125AFA3
		public void SetTimeScale(int id, float timeScale, bool ignoreGlobalTimeScale = false)
		{
			this.KuroEffectSystemInstance.SetTimeScale(id, timeScale, ignoreGlobalTimeScale);
		}

		// Token: 0x06047C3A RID: 293946 RVA: 0x0125CDB3 File Offset: 0x0125AFB3
		public void SetAdditionTimeScale(ETimeScaleSourceType sourceType, int id, float timeScale)
		{
			this.KuroEffectSystemInstance.SetAdditionTimeScale((int)sourceType, id, timeScale);
		}

		// Token: 0x06047C3B RID: 293947 RVA: 0x0125CDC3 File Offset: 0x0125AFC3
		public void SetAdditionTimeScaleEnable(ETimeScaleSourceType sourceType, bool enable)
		{
			this.KuroEffectSystemInstance.SetAdditionTimeScaleEnable((int)sourceType, enable);
		}

		// Token: 0x06047C3C RID: 293948 RVA: 0x0125CDD2 File Offset: 0x0125AFD2
		public bool GetAdditionTimeScaleEnable(ETimeScaleSourceType sourceType)
		{
			return this.KuroEffectSystemInstance.GetAdditionTimeScaleEnable((int)sourceType);
		}

		// Token: 0x06047C3D RID: 293949 RVA: 0x0125CDE0 File Offset: 0x0125AFE0
		public void FreezeHandle(int id, bool freeze, bool force = false)
		{
			this.KuroEffectSystemInstance.FreezeHandle(id, freeze, force);
		}

		// Token: 0x06047C3E RID: 293950 RVA: 0x0125CDF0 File Offset: 0x0125AFF0
		public bool IsHandleFreeze(int id)
		{
			return this.KuroEffectSystemInstance.IsHandleFreeze(id);
		}

		// Token: 0x06047C3F RID: 293951 RVA: 0x0125CDFE File Offset: 0x0125AFFE
		public bool HandleSeekToTime(int id, float time, bool autoLoop, bool force = false)
		{
			return this.KuroEffectSystemInstance.HandleSeekToTime(id, time, autoLoop, force);
		}

		// Token: 0x06047C40 RID: 293952 RVA: 0x0125CE10 File Offset: 0x0125B010
		public void HandleSeekToTimeWithProcess(int id, float time, bool seekContinue = false, float delta = -1f)
		{
			this.KuroEffectSystemInstance.HandleSeekToTimeWithProcess(id, time, seekContinue, delta);
		}

		// Token: 0x06047C41 RID: 293953 RVA: 0x0125CE22 File Offset: 0x0125B022
		public float GetSeekToTargetTime(int id)
		{
			return this.KuroEffectSystemInstance.GetSeekToTargetTime(id);
		}

		// Token: 0x06047C42 RID: 293954 RVA: 0x0125CE30 File Offset: 0x0125B030
		public void SetEffectNotRecord(int id, bool notRecord = true)
		{
			this.KuroEffectSystemInstance.SetEffectNotRecord(id, notRecord);
		}

		// Token: 0x06047C43 RID: 293955 RVA: 0x0125CE3F File Offset: 0x0125B03F
		public string GetPath(int id)
		{
			return this.KuroEffectSystemInstance.GetPath(id);
		}

		// Token: 0x06047C44 RID: 293956 RVA: 0x0125CE4D File Offset: 0x0125B04D
		public void SetEffectDataByNiagaraParam(int id, SNiagaraParam niagaraParam, bool resetPassTime)
		{
			this.KuroEffectSystemInstance.SetEffectDataByNiagaraParam(id, niagaraParam, resetPassTime);
		}

		// Token: 0x06047C45 RID: 293957 RVA: 0x0125CE5D File Offset: 0x0125B05D
		[NullableContext(2)]
		public void SetEffectParameterNiagara(int id, EffectParameterNiagara parameter)
		{
			this.KuroEffectSystemInstance.SetEffectParameterNiagara(id, parameter);
		}

		// Token: 0x06047C46 RID: 293958 RVA: 0x0125CE6C File Offset: 0x0125B06C
		public void SetEffectDataFloatConstParam(int id, in FName paramName, float value)
		{
			this.KuroEffectSystemInstance.SetEffectDataFloatConstParam(id, paramName, value);
		}

		// Token: 0x06047C47 RID: 293959 RVA: 0x0125CE7C File Offset: 0x0125B07C
		public void SetEffectExtraState(int effectId, int extraState)
		{
			this.KuroEffectSystemInstance.SetEffectExtraState(effectId, extraState);
		}

		// Token: 0x06047C48 RID: 293960 RVA: 0x0125CE8B File Offset: 0x0125B08B
		public void SetEffectIgnoreVisibilityOptimize(int effectId, bool ignore)
		{
			this.KuroEffectSystemInstance.SetEffectIgnoreVisibilityOptimize(effectId, ignore);
		}

		// Token: 0x06047C49 RID: 293961 RVA: 0x0125CE9A File Offset: 0x0125B09A
		public void SetEffectStoppingTime(int effectId, bool stoppingTime, EEffectStoppingTimeSource source = EEffectStoppingTimeSource.ScenePaused)
		{
			this.KuroEffectSystemInstance.SetEffectStoppingTime(effectId, stoppingTime, source);
		}

		// Token: 0x06047C4A RID: 293962 RVA: 0x0125CEAA File Offset: 0x0125B0AA
		public void SetEffectStoppingTimeFromEntity(int entityId, bool stoppingTime, EEffectStoppingTimeSource source = EEffectStoppingTimeSource.ScenePaused)
		{
			this.KuroEffectSystemInstance.SetEffectStoppingTimeFromEntity(entityId, stoppingTime, source);
		}

		// Token: 0x06047C4B RID: 293963 RVA: 0x0125CEBA File Offset: 0x0125B0BA
		public float GlobalStoppingPlayTime(EEffectStoppingTimeSource source = EEffectStoppingTimeSource.ScenePaused)
		{
			return this.KuroEffectSystemInstance.GlobalStoppingPlayTime(source);
		}

		// Token: 0x06047C4C RID: 293964 RVA: 0x0125CEC8 File Offset: 0x0125B0C8
		public bool GlobalStoppingTime(EEffectStoppingTimeSource source = EEffectStoppingTimeSource.ScenePaused)
		{
			return this.KuroEffectSystemInstance.GlobalStoppingTime(source);
		}

		// Token: 0x06047C4D RID: 293965 RVA: 0x0125CED6 File Offset: 0x0125B0D6
		public void SetGlobalStoppingTime(bool stoppingTime, float playTime, EEffectStoppingTimeSource source = EEffectStoppingTimeSource.ScenePaused)
		{
			this.KuroEffectSystemInstance.SetGlobalStoppingTime(stoppingTime, playTime, source);
		}

		// Token: 0x06047C4E RID: 293966 RVA: 0x0125CEE6 File Offset: 0x0125B0E6
		public void AttachToEffectSkeletalMesh(int id, AActor attachActor, in FName? socketName, EAttachmentRule transformRule)
		{
			this.KuroEffectSystemInstance.AttachToEffectSkeletalMesh(id, attachActor, socketName, transformRule);
		}

		// Token: 0x06047C4F RID: 293967 RVA: 0x0125CEF8 File Offset: 0x0125B0F8
		public void AttachSkeletalMesh(int id, SkeletalMeshEffectContext context)
		{
			this.KuroEffectSystemInstance.AttachSkeletalMesh(id, context);
		}

		// Token: 0x06047C50 RID: 293968 RVA: 0x0125CF07 File Offset: 0x0125B107
		public void CollectMaterialFloatCurve(int id, in FName key, FKuroCurveFloat value)
		{
			this.KuroEffectSystemInstance.CollectMaterialFloatCurve(id, key, value);
		}

		// Token: 0x06047C51 RID: 293969 RVA: 0x0125CF17 File Offset: 0x0125B117
		public void CollectMaterialVectorCurve(int id, in FName key, FKuroCurveVector value)
		{
			this.KuroEffectSystemInstance.CollectMaterialVectorCurve(id, key, value);
		}

		// Token: 0x06047C52 RID: 293970 RVA: 0x0125CF27 File Offset: 0x0125B127
		public void CollectMaterialLinearColorCurve(int id, in FName key, FKuroCurveLinearColor value)
		{
			this.KuroEffectSystemInstance.CollectMaterialLinearColorCurve(id, key, value);
		}

		// Token: 0x06047C53 RID: 293971 RVA: 0x0125CF37 File Offset: 0x0125B137
		[NullableContext(2)]
		public UEffectModelBase GetEffectModel(int id)
		{
			return this.KuroEffectSystemInstance.GetEffectModel(id);
		}

		// Token: 0x06047C54 RID: 293972 RVA: 0x0125CF45 File Offset: 0x0125B145
		public float GetTotalPassTime(int id)
		{
			return this.KuroEffectSystemInstance.GetTotalPassTime(id);
		}

		// Token: 0x06047C55 RID: 293973 RVA: 0x0125CF53 File Offset: 0x0125B153
		public float GetPassTime(int id)
		{
			return this.KuroEffectSystemInstance.GetPassTime(id);
		}

		// Token: 0x06047C56 RID: 293974 RVA: 0x0125CF61 File Offset: 0x0125B161
		public bool GetHideOnBurstSkill(int id)
		{
			return this.KuroEffectSystemInstance.GetHideOnBurstSkill(id);
		}

		// Token: 0x06047C57 RID: 293975 RVA: 0x0125CF6F File Offset: 0x0125B16F
		public void RegisterCustomCheckOwnerFunc(int id, Func<int, bool> func)
		{
			this.KuroEffectSystemInstance.RegisterCustomCheckOwnerFunc(id, func);
		}

		// Token: 0x06047C58 RID: 293976 RVA: 0x0125CF80 File Offset: 0x0125B180
		public void EnableNiagaraDownSampling()
		{
			Log.Instance.Info(ELogModule.RenderEffect, ELogAuthor.WLJ, "Enable Niagara Down Sampling", default(ReadOnlySpan<ValueTuple<string, object>>));
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "Kuro.Niagara.SystemSimulation.TickOptimizeEnable 1", null);
		}

		// Token: 0x06047C59 RID: 293977 RVA: 0x0125CFBC File Offset: 0x0125B1BC
		public void DisableNiagaraDownSampling()
		{
			Log.Instance.Info(ELogModule.RenderEffect, ELogAuthor.WLJ, "Disable Niagara Down Sampling", default(ReadOnlySpan<ValueTuple<string, object>>));
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "Kuro.Niagara.SystemSimulation.TickOptimizeEnable 0", null);
		}

		// Token: 0x06047C5A RID: 293978 RVA: 0x0125CFF5 File Offset: 0x0125B1F5
		public void SetEffectQualityLevel(int id, int qualityLevel)
		{
			this.KuroEffectSystemInstance.SetEffectQualityLevel(id, qualityLevel);
		}

		// Token: 0x06047C5B RID: 293979 RVA: 0x0125D004 File Offset: 0x0125B204
		public void TickHandleInEditor(int id, float delta)
		{
			this.KuroEffectSystemInstance.TickHandleInEditor(id, delta);
		}

		// Token: 0x06047C5C RID: 293980 RVA: 0x0125D013 File Offset: 0x0125B213
		public float GetLastPlayTime(int id)
		{
			return this.KuroEffectSystemInstance.GetLastPlayTime(id);
		}

		// Token: 0x06047C5D RID: 293981 RVA: 0x0125D021 File Offset: 0x0125B221
		public float GetLastStopTime(int id)
		{
			return this.KuroEffectSystemInstance.GetLastStopTime(id);
		}

		// Token: 0x06047C5E RID: 293982 RVA: 0x0125D02F File Offset: 0x0125B22F
		public void UpdateBodyEffect(int id, float opacity, bool visible, bool castShadow)
		{
			this.KuroEffectSystemInstance.UpdateBodyEffect(id, opacity, visible, castShadow);
		}

		// Token: 0x06047C5F RID: 293983 RVA: 0x0125D041 File Offset: 0x0125B241
		public void DebugUpdate(int id, bool dDebugUpdate)
		{
			this.KuroEffectSystemInstance.DebugUpdate(id, dDebugUpdate);
		}

		// Token: 0x06047C60 RID: 293984 RVA: 0x0125D050 File Offset: 0x0125B250
		public int GetEffectCount()
		{
			return this.KuroEffectSystemInstance.GetEffectCount();
		}

		// Token: 0x06047C61 RID: 293985 RVA: 0x0125D05D File Offset: 0x0125B25D
		public int GetActiveEffectCount()
		{
			return this.KuroEffectSystemInstance.GetActiveEffectCount();
		}

		// Token: 0x06047C62 RID: 293986 RVA: 0x0125D06A File Offset: 0x0125B26A
		public void DebugPrintAllErrorEffects()
		{
			this.KuroEffectSystemInstance.DebugPrintAllErrorEffects();
		}

		// Token: 0x06047C63 RID: 293987 RVA: 0x0125D077 File Offset: 0x0125B277
		public void DebugPrintCurrentImportanceEffects()
		{
			this.KuroEffectSystemInstance.DebugPrintCurrentImportanceEffects();
		}

		// Token: 0x06047C64 RID: 293988 RVA: 0x0125D084 File Offset: 0x0125B284
		public void DebugPrintEffect()
		{
			this.KuroEffectSystemInstance.DebugPrintEffect();
		}

		// Token: 0x06047C65 RID: 293989 RVA: 0x0125D091 File Offset: 0x0125B291
		public int GetPlayerEffectLruSize(int pos)
		{
			return this.KuroEffectSystemInstance.GetPlayerEffectLruSize(pos);
		}

		// Token: 0x06047C66 RID: 293990 RVA: 0x0125D09F File Offset: 0x0125B29F
		public void SetEffectStartRecording(Vector tempVector, Vector centerLocation, float recordDistSquared, Action<int, AActor> onEffectRecorded)
		{
			this.KuroEffectSystemInstance.SetEffectStartRecording(tempVector, centerLocation, recordDistSquared, onEffectRecorded);
		}

		// Token: 0x06047C67 RID: 293991 RVA: 0x0125D0B1 File Offset: 0x0125B2B1
		public static void RefreshEffectSpecData(Dictionary<string, SpecData> specDataMap)
		{
			EffectSystem.Instance.KuroEffectSystemInstance.RefreshEffectSpecData(specDataMap);
		}

		// Token: 0x17009E89 RID: 40585
		// (get) Token: 0x06047C68 RID: 293992 RVA: 0x0125D0C3 File Offset: 0x0125B2C3
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

		// Token: 0x06047C69 RID: 293993 RVA: 0x0125D0E6 File Offset: 0x0125B2E6
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06047C6A RID: 293994 RVA: 0x0125D0E8 File Offset: 0x0125B2E8
		public static void ResetStaticDefaultValue()
		{
			EffectSystem instance = EffectSystem._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			EffectSystem._instance = null;
		}

		// Token: 0x06047C6B RID: 293995 RVA: 0x0125D101 File Offset: 0x0125B301
		static EffectSystem()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(EffectSystem.CreateStaticDefaultValue), new Action(EffectSystem.ResetStaticDefaultValue));
		}

		// Token: 0x04025BBE RID: 154558
		public const int EFFECT_REASON_LENGTH_LIMIT = 4;

		// Token: 0x04025BBF RID: 154559
		public const int EFFECT_LIFETIME_FLOAT_TO_INT = 10000;

		// Token: 0x04025BC0 RID: 154560
		[StaticVariableRuleIgnore]
		private static readonly HashSet<string> EFFECT_BLACK_LIST = new HashSet<string>
		{
			"/Game/Aki/Scene/EffectDataAsset/DA_Base/DA_ClusterStuff/Dust/DA_Fx_Sc3_Cluster_Dust_PMMD.DA_Fx_Sc3_Cluster_Dust_PMMD"
		};

		// Token: 0x04025BC1 RID: 154561
		private readonly KuroEffectSystem KuroEffectSystemInstance = new KuroEffectSystem();

		// Token: 0x04025BC2 RID: 154562
		[Nullable(2)]
		private static EffectSystem _instance;
	}
}
