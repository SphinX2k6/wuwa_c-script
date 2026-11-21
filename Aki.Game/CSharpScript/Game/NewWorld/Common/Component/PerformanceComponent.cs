using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Common.Struct;
using AkiClient.Game.Aki.Data.Entity.Struct;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.Enum;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Common.Component
{
	// Token: 0x0200620A RID: 25098
	[NullableContext(1)]
	[Nullable(0)]
	public class PerformanceComponent : EntityComponent
	{
		// Token: 0x0603C4ED RID: 247021 RVA: 0x01131E42 File Offset: 0x01130042
		public void SetIsSceneInteractionJumpToEnd(bool value)
		{
			this.IsSceneInteractionJumpToEnd = value;
		}

		// Token: 0x0603C4EE RID: 247022 RVA: 0x01131E4C File Offset: 0x0113004C
		protected override bool OnStart()
		{
			this.CommonEffectTimerId = null;
			this.LevelTagComponent = base.Entity.CheckGetComponent<LevelTagComponent>();
			this.ActorComponent = base.Entity.GetComponent<BaseActorComponent>();
			this.ModelConfig = this.ActorComponent.CreatureData.GetModelConfig();
			this.IsSceneInteractionJumpToEnd = false;
			return true;
		}

		// Token: 0x0603C4EF RID: 247023 RVA: 0x01131EA0 File Offset: 0x011300A0
		protected override void OnActivate()
		{
			if (this.ActorComponent.SkeletalMesh == null)
			{
				this.LoadAndChangeStaticMesh();
			}
			this.InitSceneInteractionLevel();
			this.SceneInteractionEffectMap = new Dictionary<int, ESceneInteractionEffect>();
			SceneItemActorComponent sceneItemActorComponent = this.ActorComponent as SceneItemActorComponent;
			if (sceneItemActorComponent != null && !sceneItemActorComponent.GetIsSceneInteractionLoadCompleted())
			{
				EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnSceneInteractionLoadCompleted, new Action(this.OnSceneInteractionLoadCompleted));
			}
			this.InitCommonEffect();
			if (this.CheckAndUpdateCommonEffectTag())
			{
				this.SetCommonEffectParam();
			}
			this.OwnEffectMap = new Dictionary<int, int>();
			this.InitOwnEffects();
			EventSystem.Instance.AddWithTarget<IReadOnlyList<int>, IReadOnlyList<int>>(base.Entity, EEventName.OnLevelTagChanged, new Action<IReadOnlyList<int>, IReadOnlyList<int>>(this.CheckGameplayTagChange2));
		}

		// Token: 0x0603C4F0 RID: 247024 RVA: 0x01131F54 File Offset: 0x01130154
		protected override bool OnEnd()
		{
			if (EventSystem.Instance.HasWithTarget<IReadOnlyList<int>, IReadOnlyList<int>>(base.Entity, EEventName.OnLevelTagChanged, new Action<IReadOnlyList<int>, IReadOnlyList<int>>(this.CheckGameplayTagChange2)))
			{
				EventSystem.Instance.RemoveWithTarget<IReadOnlyList<int>, IReadOnlyList<int>>(base.Entity, EEventName.OnLevelTagChanged, new Action<IReadOnlyList<int>, IReadOnlyList<int>>(this.CheckGameplayTagChange2));
			}
			if (this.ActorComponent is SceneItemActorComponent && EventSystem.Instance.HasWithTarget(base.Entity, EEventName.OnSceneInteractionLoadCompleted, new Action(this.OnSceneInteractionLoadCompleted)))
			{
				EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnSceneInteractionLoadCompleted, new Action(this.OnSceneInteractionLoadCompleted));
			}
			return true;
		}

		// Token: 0x0603C4F1 RID: 247025 RVA: 0x01131FFC File Offset: 0x011301FC
		protected override bool OnClear()
		{
			if (this.SceneInteractionEffectMap != null)
			{
				this.SceneInteractionEffectMap.Clear();
				this.SceneInteractionEffectMap = null;
			}
			this.DisposeCommonEffectTimer();
			this.OnChangeCommonEffectFinished = null;
			if (this.OwnEffectMap != null)
			{
				foreach (int handle in this.OwnEffectMap.Values)
				{
					EffectSystem.Instance.StopEffectById(handle, "[PerformanceComponent.OnClear 1]", true, null);
				}
				this.OwnEffectMap.Clear();
				this.OwnEffectMap = null;
			}
			if (this.CommonEffect != 0)
			{
				this.CommonEffectNiagaraComp = null;
				EffectSystem.Instance.StopEffectById(this.CommonEffect, "[PerformanceComponent.OnClear 2]", false, null);
				this.CommonEffect = 0;
			}
			if (this.LastChangeEffect != 0)
			{
				EffectSystem.Instance.RemoveFinishCallback(this.LastChangeEffect, this.OnChangeEffectFinished);
				EffectSystem.Instance.StopEffectById(this.LastChangeEffect, "[PerformanceComponent.OnClear 3]", true, null);
				this.LastChangeEffect = 0;
			}
			this.OnChangeEffectFinished = null;
			return true;
		}

		// Token: 0x0603C4F2 RID: 247026 RVA: 0x01132134 File Offset: 0x01130334
		protected override void OnEnable()
		{
			Entity entity = base.Entity;
			if (entity != null && entity.IsInit)
			{
				this.SetPerformanceVisible(this.ActorComponent.CreatureData.GetVisible());
			}
		}

		// Token: 0x0603C4F3 RID: 247027 RVA: 0x01132160 File Offset: 0x01130360
		protected override void OnDisable(string reason)
		{
			this.SetPerformanceVisible(false);
		}

		// Token: 0x0603C4F4 RID: 247028 RVA: 0x0113216C File Offset: 0x0113036C
		protected override void OnChangeTimeDilation(float timeDilation)
		{
			PawnTimeScaleComponent component = base.Entity.GetComponent<PawnTimeScaleComponent>();
			float num = (component != null) ? component.CurrentTimeScale : 1f;
			float timeScale = timeDilation * num;
			if (EffectSystem.Instance.IsValid(this.CommonEffect))
			{
				EffectSystem.Instance.SetTimeScale(this.CommonEffect, timeScale, false);
			}
			if (EffectSystem.Instance.IsValid(this.LastChangeEffect))
			{
				EffectSystem.Instance.SetTimeScale(this.LastChangeEffect, timeScale, false);
			}
			Dictionary<int, int> ownEffectMap = this.OwnEffectMap;
			if (ownEffectMap != null && ownEffectMap.Count > 0)
			{
				foreach (int id in this.OwnEffectMap.Values)
				{
					if (EffectSystem.Instance.IsValid(id))
					{
						EffectSystem.Instance.SetTimeScale(id, timeScale, false);
					}
				}
			}
		}

		// Token: 0x0603C4F5 RID: 247029 RVA: 0x01132258 File Offset: 0x01130458
		private void CheckGameplayTagChange2(IReadOnlyList<int> added, IReadOnlyList<int> removed)
		{
			if (this.ActorComponent.SkeletalMesh == null)
			{
				this.LoadAndChangeStaticMesh();
			}
			if (this.CheckAndUpdateCommonEffectTag())
			{
				this.ChangeCommonEffectParam();
			}
			this.ChangeOwnEffects(added, removed);
			this.ChangeSceneInteractionLevel();
			this.ChangeSceneInteractionEffects(added, removed);
			this.ChangeSceneInteractionExtraEffects(added, removed);
			SceneItemActorComponent sceneItemActorComponent = this.ActorComponent as SceneItemActorComponent;
			if (sceneItemActorComponent != null)
			{
				sceneItemActorComponent.TryRefreshShowActor();
			}
		}

		// Token: 0x0603C4F6 RID: 247030 RVA: 0x011322B9 File Offset: 0x011304B9
		private void InitSceneInteractionLevel()
		{
			this.UpdateSceneInteractionLevel(true);
		}

		// Token: 0x0603C4F7 RID: 247031 RVA: 0x011322C2 File Offset: 0x011304C2
		private void ChangeSceneInteractionLevel()
		{
			this.UpdateSceneInteractionLevel(false);
		}

		// Token: 0x0603C4F8 RID: 247032 RVA: 0x011322CC File Offset: 0x011304CC
		private void UpdateSceneInteractionLevel(bool needInit)
		{
			SceneItemStateComponent component = base.Entity.GetComponent<SceneItemStateComponent>();
			if (component != null && component.PerformanceStateControlledExternally)
			{
				return;
			}
			int? resTag = this.GetResTag<EKuroSceneInteractionState>(this.ModelConfig.场景交互物状态列表);
			if (resTag != null)
			{
				int? num = resTag;
				int curSceneInteractionLevelTagId = this.CurSceneInteractionLevelTagId;
				if (num.GetValueOrDefault() == curSceneInteractionLevelTagId & num != null)
				{
					return;
				}
				this.CurSceneInteractionLevelTagId = resTag.Value;
			}
			else
			{
				int num2 = GameplayTagDefine.EGameplayTagId["物体.表现.初始状态"];
				FGameplayTag? gameplayTagById = GameplayTagUtils.GetGameplayTagById(num2);
				if (num2 == this.CurSceneInteractionLevelTagId || !this.ModelConfig.场景交互物状态列表.Contains(gameplayTagById.Value))
				{
					SceneItemActorComponent sceneItemActorComponent = this.ActorComponent as SceneItemActorComponent;
					if (sceneItemActorComponent != null && sceneItemActorComponent.GetSceneInteractionLevelHandleId() == -1)
					{
						sceneItemActorComponent.SetIsSceneInteractionLoadCompleted(true);
					}
					return;
				}
				this.CurSceneInteractionLevelTagId = num2;
			}
			SceneItemActorComponent sceneItemActorComponent2 = this.ActorComponent as SceneItemActorComponent;
			if (sceneItemActorComponent2 != null)
			{
				EKuroSceneInteractionState? ekuroSceneInteractionState = null;
				if (this.CurSceneInteractionLevelTagId == GameplayTagDefine.EGameplayTagId["物体.表现.隐匿"])
				{
					ekuroSceneInteractionState = new EKuroSceneInteractionState?(EKuroSceneInteractionState.ConcealedState);
				}
				else
				{
					FGameplayTag? gameplayTagById2 = GameplayTagUtils.GetGameplayTagById(this.CurSceneInteractionLevelTagId);
					EKuroSceneInteractionState ekuroSceneInteractionState2;
					ekuroSceneInteractionState = new EKuroSceneInteractionState?(this.ModelConfig.场景交互物状态列表.TryGetValue(gameplayTagById2.Value, out ekuroSceneInteractionState2) ? ekuroSceneInteractionState2 : EKuroSceneInteractionState.Error);
				}
				if (needInit)
				{
					bool isInitShow = false;
					if (this.CurSceneInteractionLevelTagId == GameplayTagDefine.EGameplayTagId["关卡.Common.表现.出生"])
					{
						isInitShow = true;
					}
					sceneItemActorComponent2.LoadSceneInteractionLevel(ekuroSceneInteractionState.Value, isInitShow);
					return;
				}
				sceneItemActorComponent2.SwitchToState(ekuroSceneInteractionState.Value, !this.IsSceneInteractionJumpToEnd, this.IsSceneInteractionJumpToEnd);
			}
		}

		// Token: 0x0603C4F9 RID: 247033 RVA: 0x01132464 File Offset: 0x01130664
		private void InitSceneInteractionEffects()
		{
			if (this.LevelTagComponent == null)
			{
				return;
			}
			SceneItemActorComponent sceneItemActorComponent = this.ActorComponent as SceneItemActorComponent;
			if (sceneItemActorComponent != null && this.SceneInteractionEffectMap != null && this.SceneInteractionEffectMap.Count > 0)
			{
				foreach (ESceneInteractionEffect effectKey in this.SceneInteractionEffectMap.Values)
				{
					if (sceneItemActorComponent != null)
					{
						sceneItemActorComponent.EndSceneInteractionEffect(effectKey);
					}
					if (sceneItemActorComponent != null)
					{
						sceneItemActorComponent.PlaySceneInteractionEndEffect(effectKey);
					}
				}
				Dictionary<int, ESceneInteractionEffect> sceneInteractionEffectMap = this.SceneInteractionEffectMap;
				if (sceneInteractionEffectMap != null)
				{
					sceneInteractionEffectMap.Clear();
				}
			}
			foreach (int tagId in this.LevelTagComponent.GetTagIds())
			{
				if (this.CheckAndAddSceneInteractionByTag(tagId))
				{
					break;
				}
			}
		}

		// Token: 0x0603C4FA RID: 247034 RVA: 0x01132550 File Offset: 0x01130750
		private void InitSceneInteractionExtraEffects()
		{
			if (this.LevelTagComponent == null)
			{
				return;
			}
			foreach (int tagId in this.LevelTagComponent.GetTagIds())
			{
				FGameplayTag? gameplayTagById = GameplayTagUtils.GetGameplayTagById(tagId);
				SceneItemActorComponent sceneItemActorComponent = this.ActorComponent as SceneItemActorComponent;
				if (sceneItemActorComponent != null && gameplayTagById != null)
				{
					sceneItemActorComponent.PlayExtraEffect(gameplayTagById.Value, true);
				}
			}
		}

		// Token: 0x0603C4FB RID: 247035 RVA: 0x011325D0 File Offset: 0x011307D0
		private bool CheckAndAddSceneInteractionByTag(int tagId)
		{
			if (this.SceneInteractionEffectMap.ContainsKey(tagId))
			{
				return false;
			}
			FGameplayTag? gameplayTagById = GameplayTagUtils.GetGameplayTagById(tagId);
			TEnumAsByte<ESceneInteractionEffect> value;
			if (!this.ModelConfig.场景交互物特效列表.TryGetValue(gameplayTagById.Value, out value))
			{
				return false;
			}
			SceneItemActorComponent sceneItemActorComponent = this.ActorComponent as SceneItemActorComponent;
			if (sceneItemActorComponent != null)
			{
				sceneItemActorComponent.PlaySceneInteractionEffect(value);
				this.SceneInteractionEffectMap.Add(tagId, value);
				return true;
			}
			return false;
		}

		// Token: 0x0603C4FC RID: 247036 RVA: 0x01132644 File Offset: 0x01130844
		private void ChangeSceneInteractionEffects(IReadOnlyList<int> added, IReadOnlyList<int> removed)
		{
			foreach (int key in removed)
			{
				if (this.SceneInteractionEffectMap.ContainsKey(key))
				{
					ESceneInteractionEffect effectKey = this.SceneInteractionEffectMap[key];
					this.SceneInteractionEffectMap.Remove(key);
					SceneItemActorComponent sceneItemActorComponent = this.ActorComponent as SceneItemActorComponent;
					if (sceneItemActorComponent != null)
					{
						sceneItemActorComponent.EndSceneInteractionEffect(effectKey);
						sceneItemActorComponent.PlaySceneInteractionEndEffect(effectKey);
					}
				}
			}
			foreach (int tagId in added)
			{
				this.CheckAndAddSceneInteractionByTag(tagId);
			}
		}

		// Token: 0x0603C4FD RID: 247037 RVA: 0x01132704 File Offset: 0x01130904
		private void ChangeSceneInteractionExtraEffects(IReadOnlyList<int> added, IReadOnlyList<int> removed)
		{
			foreach (int tagId in removed)
			{
				FGameplayTag? gameplayTagById = GameplayTagUtils.GetGameplayTagById(tagId);
				SceneItemActorComponent sceneItemActorComponent = this.ActorComponent as SceneItemActorComponent;
				if (sceneItemActorComponent != null && gameplayTagById != null)
				{
					sceneItemActorComponent.StopExtraEffect(gameplayTagById.Value);
				}
			}
			foreach (int tagId2 in added)
			{
				FGameplayTag? gameplayTagById2 = GameplayTagUtils.GetGameplayTagById(tagId2);
				SceneItemActorComponent sceneItemActorComponent2 = this.ActorComponent as SceneItemActorComponent;
				if (sceneItemActorComponent2 != null && gameplayTagById2 != null)
				{
					sceneItemActorComponent2.PlayExtraEffect(gameplayTagById2.Value, false);
				}
			}
		}

		// Token: 0x0603C4FE RID: 247038 RVA: 0x011327D0 File Offset: 0x011309D0
		public void LoadAndChangeStaticMesh()
		{
			if (this.ActorComponent.SkeletalMesh != null)
			{
				return;
			}
			int? resTag = this.GetResTag<FSoftObjectPath>(this.ModelConfig.静态网格体列表);
			if (resTag != null)
			{
				int? num = resTag;
				int curStaticMeshTagId = this.CurStaticMeshTagId;
				if (num.GetValueOrDefault() == curStaticMeshTagId & num != null)
				{
					return;
				}
				this.CurStaticMeshTagId = resTag.Value;
			}
			else
			{
				int num2 = GameplayTagDefine.EGameplayTagId["物体.表现.初始状态"];
				FGameplayTag? gameplayTagById = GameplayTagUtils.GetGameplayTagById(num2);
				if (num2 == this.CurStaticMeshTagId || !this.ModelConfig.静态网格体列表.Contains(gameplayTagById.Value) || this.ModelConfig.静态网格体列表.Get(gameplayTagById.Value) == null)
				{
					return;
				}
				this.CurStaticMeshTagId = num2;
			}
			SceneItemActorComponent sceneItemActorComponent = this.ActorComponent as SceneItemActorComponent;
			if (sceneItemActorComponent != null)
			{
				sceneItemActorComponent.LoadAndChangeStaticMesh(GameplayTagUtils.GetGameplayTagById(this.CurStaticMeshTagId).Value);
			}
		}

		// Token: 0x0603C4FF RID: 247039 RVA: 0x011328C4 File Offset: 0x01130AC4
		private void InitCommonEffect()
		{
			FGameplayTag? gameplayTagById = GameplayTagUtils.GetGameplayTagById(GameplayTagDefine.EGameplayTagId["物体.表现.常驻特效"]);
			FSoftObjectPath fsoftObjectPath;
			if (!this.ModelConfig.常驻特效列表.TryGetValue(gameplayTagById.Value, out fsoftObjectPath))
			{
				return;
			}
			if (fsoftObjectPath == null)
			{
				return;
			}
			this.CommonEffect = this.SpawnEffectByPath(fsoftObjectPath.AssetPathName.ToString(), "[PerformanceComponent.InitCommonEffect]", new Action<ELoadEffectResult, int>(this.OnSpawnEffectByPathCompleted));
			if (!EffectSystem.Instance.IsValid(this.CommonEffect))
			{
				return;
			}
			OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(this.CommonEffect);
			AActor owner = this.ActorComponent.Owner;
			FName? fname = null;
			effectActor.K2_AttachToActor(owner, fname, EAttachmentRule.SnapToTarget, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, false);
			bool visible = this.ActorComponent.CreatureData.GetVisible();
			this.SetEffectVisibleById(this.CommonEffect, visible);
		}

		// Token: 0x0603C500 RID: 247040 RVA: 0x0113299C File Offset: 0x01130B9C
		private bool CheckAndUpdateCommonEffectTag()
		{
			if (this.CommonEffect == 0)
			{
				return false;
			}
			int? resTag = this.GetResTag<SNiagaraParam>(this.ModelConfig.通用特效常驻参数);
			int? num = resTag;
			int curCommonEffectTagId = this.CurCommonEffectTagId;
			if (num.GetValueOrDefault() == curCommonEffectTagId & num != null)
			{
				return false;
			}
			this.CurCommonEffectTagId = resTag.GetValueOrDefault();
			return this.CurCommonEffectTagId != 0;
		}

		// Token: 0x0603C501 RID: 247041 RVA: 0x011329FC File Offset: 0x01130BFC
		private void SetCommonEffectParam()
		{
			if (this.CommonEffect == 0)
			{
				return;
			}
			FGameplayTag? gameplayTagById = GameplayTagUtils.GetGameplayTagById(this.CurCommonEffectTagId);
			SNiagaraParam sniagaraParam;
			if (!this.ModelConfig.通用特效常驻参数.TryGetValue(gameplayTagById.Value, out sniagaraParam))
			{
				return;
			}
			if (sniagaraParam == null)
			{
				return;
			}
			this.SetCommonEffectByNiagaraParam(sniagaraParam);
		}

		// Token: 0x0603C502 RID: 247042 RVA: 0x01132A4C File Offset: 0x01130C4C
		private void ChangeCommonEffectParam()
		{
			FGameplayTag? gameplayTagById = GameplayTagUtils.GetGameplayTagById(this.CurCommonEffectTagId);
			SNiagaraParam sniagaraParam;
			if (!this.ModelConfig.通用特效变化参数.TryGetValue(gameplayTagById.Value, out sniagaraParam))
			{
				return;
			}
			if (sniagaraParam == null)
			{
				this.SetCommonEffectParam();
				return;
			}
			if (sniagaraParam.ManualLifeTime > 0f)
			{
				if (this.OnChangeCommonEffectFinished == null)
				{
					this.OnChangeCommonEffectFinished = delegate(float delta)
					{
						this.SetCommonEffectParam();
					};
				}
				this.DisposeCommonEffectTimer();
				this.CommonEffectTimerId = TimerSystem.Instance.Loop(this.OnChangeCommonEffectFinished, (float)TimeUtil.Instance.SetTimeMillisecond((double)sniagaraParam.ManualLifeTime), 1, 0f, null, null, true);
			}
			this.SetCommonEffectByNiagaraParam(sniagaraParam);
		}

		// Token: 0x0603C503 RID: 247043 RVA: 0x01132AF8 File Offset: 0x01130CF8
		private void InitOwnEffects()
		{
			if (this.LevelTagComponent == null)
			{
				return;
			}
			foreach (int tagId in this.LevelTagComponent.GetTagIds())
			{
				this.CheckAndAddOwnEffectByTag(tagId);
			}
		}

		// Token: 0x0603C504 RID: 247044 RVA: 0x01132B54 File Offset: 0x01130D54
		private void CheckAndAddOwnEffectByTag(int tagId)
		{
			if (this.OwnEffectMap.ContainsKey(tagId))
			{
				return;
			}
			FGameplayTag? gameplayTagById = GameplayTagUtils.GetGameplayTagById(tagId);
			FSoftObjectPath fsoftObjectPath;
			if (!this.ModelConfig.常驻特效列表.TryGetValue(gameplayTagById.Value, out fsoftObjectPath))
			{
				return;
			}
			if (fsoftObjectPath == null)
			{
				return;
			}
			int num = this.SpawnEffectByPath(fsoftObjectPath.AssetPathName.ToString(), "[PerformanceComponent.CheckAndAddOwnEffectByTag]", null);
			if (num != 0)
			{
				this.OwnEffectMap.Add(tagId, num);
				bool visible = this.ActorComponent.CreatureData.GetVisible();
				this.SetEffectVisibleById(num, visible);
			}
		}

		// Token: 0x0603C505 RID: 247045 RVA: 0x01132BEC File Offset: 0x01130DEC
		private void ChangeOwnEffects(IReadOnlyList<int> added, IReadOnlyList<int> removed)
		{
			foreach (int key in removed)
			{
				if (this.OwnEffectMap.ContainsKey(key))
				{
					int handle2 = this.OwnEffectMap[key];
					this.OwnEffectMap.Remove(key);
					EffectSystem.Instance.StopEffectById(handle2, "[PerformanceComponent.ChangeOwnEffects]", true, null);
				}
			}
			int? num = null;
			foreach (int tagId in added)
			{
				FGameplayTag? gameplayTagById = GameplayTagUtils.GetGameplayTagById(tagId);
				FSoftObjectPath fsoftObjectPath;
				if (this.ModelConfig.变化特效列表.TryGetValue(gameplayTagById.Value, out fsoftObjectPath))
				{
					if (fsoftObjectPath != null)
					{
						num = new int?(this.SpawnEffectByPath(fsoftObjectPath.AssetPathName.ToString(), "[PerformanceComponent.ChangeOwnEffects]", null));
					}
					else
					{
						this.CheckAndAddOwnEffectByTag(tagId);
					}
				}
				else
				{
					this.CheckAndAddOwnEffectByTag(tagId);
				}
			}
			if (num != null)
			{
				if (this.OnChangeEffectFinished == null)
				{
					this.OnChangeEffectFinished = delegate(int handle)
					{
						this.LastChangeEffect = 0;
						this.InitOwnEffects();
					};
				}
				EffectSystem.Instance.AddFinishCallback(this.LastChangeEffect, this.OnChangeEffectFinished);
				this.LastChangeEffect = num.Value;
			}
		}

		// Token: 0x0603C506 RID: 247046 RVA: 0x01132D5C File Offset: 0x01130F5C
		private int? GetResTag<[Nullable(2)] T>(TMap<FGameplayTag, T> map)
		{
			if (this.LevelTagComponent.HasTag(PerformanceComponent.ConcealedGameplayTagId))
			{
				return new int?(PerformanceComponent.ConcealedGameplayTagId);
			}
			this.ResTagId = null;
			if (this.LevelTagComponent != null)
			{
				foreach (int num in this.LevelTagComponent.GetTagIds())
				{
					T t;
					if (num != PerformanceComponent.ConcealedGameplayTagId && map.TryGetValue(GameplayTagUtils.GetGameplayTagById(num).Value, out t) && t != null)
					{
						this.ResTagId = new int?(num);
						break;
					}
				}
			}
			return this.ResTagId;
		}

		// Token: 0x0603C507 RID: 247047 RVA: 0x01132E14 File Offset: 0x01131014
		[NullableContext(2)]
		private int SpawnEffectByPath(string effectDataPath, [Nullable(1)] string reason, Action<ELoadEffectResult, int> callback)
		{
			if (string.IsNullOrEmpty(effectDataPath))
			{
				return 0;
			}
			if (this.ActorComponent == null)
			{
				return 0;
			}
			EffectSystem instance = EffectSystem.Instance;
			UObject world = GlobalData.World;
			FTransformDouble? ftransformDouble = new FTransformDouble?(this.ActorComponent.ActorTransform);
			return instance.SpawnEffect(world, ftransformDouble, effectDataPath, reason, new EffectContext(new int?(base.Entity.Id), null, false), EEffectType.Scene, null, callback, null, false, false);
		}

		// Token: 0x0603C508 RID: 247048 RVA: 0x01132E76 File Offset: 0x01131076
		private void SetCommonEffectByNiagaraParam(SNiagaraParam niagaraParam)
		{
			EffectSystem.Instance.SetEffectDataByNiagaraParam(this.CommonEffect, niagaraParam, true);
		}

		// Token: 0x0603C509 RID: 247049 RVA: 0x01132E8A File Offset: 0x0113108A
		public bool ApplyNiagaraParameters(string key, FVector value)
		{
			if (this.CommonEffect == 0 || this.CommonEffectNiagaraComp == null)
			{
				return false;
			}
			this.CommonEffectNiagaraComp.Value.SetNiagaraVariableVec3(key, value);
			return true;
		}

		// Token: 0x0603C50A RID: 247050 RVA: 0x01132EB7 File Offset: 0x011310B7
		public bool ApplyNiagaraParameters(string key, float value)
		{
			if (this.CommonEffect == 0 || this.CommonEffectNiagaraComp == null)
			{
				return false;
			}
			this.CommonEffectNiagaraComp.Value.SetNiagaraVariableFloat(key, value);
			return true;
		}

		// Token: 0x0603C50B RID: 247051 RVA: 0x01132EE3 File Offset: 0x011310E3
		private void DisposeCommonEffectTimer()
		{
			if (TimerSystem.Instance.Has(this.CommonEffectTimerId))
			{
				TimerSystem.Instance.Remove(this.CommonEffectTimerId);
			}
		}

		// Token: 0x0603C50C RID: 247052 RVA: 0x01132F08 File Offset: 0x01131108
		private void OnSceneInteractionLoadCompleted()
		{
			this.InitSceneInteractionEffects();
			this.InitSceneInteractionExtraEffects();
		}

		// Token: 0x0603C50D RID: 247053 RVA: 0x01132F18 File Offset: 0x01131118
		private void OnSpawnEffectByPathCompleted(ELoadEffectResult result, int handle)
		{
			if (result != ELoadEffectResult.Success)
			{
				return;
			}
			Entity entity = base.Entity;
			if (entity == null || !entity.Valid || !EffectSystem.Instance.IsValid(handle))
			{
				return;
			}
			this.CommonEffectNiagaraComp = new OneOf<KuroEffectNiagaraComponentHandle, UNiagaraComponent>?(EffectSystem.Instance.GetNiagaraComponent(handle));
			if (this.CommonEffectNiagaraComp != null)
			{
				EventSystem.Instance.EmitWithTarget(base.Entity, EEventName.OnAddCommonEffect);
			}
		}

		// Token: 0x0603C50E RID: 247054 RVA: 0x01132F88 File Offset: 0x01131188
		public void SetPerformanceVisible(bool visible)
		{
			this.SetEffectVisibleById(this.CommonEffect, visible);
			if (this.OwnEffectMap != null)
			{
				foreach (int handleId in this.OwnEffectMap.Values)
				{
					this.SetEffectVisibleById(handleId, visible);
				}
			}
		}

		// Token: 0x0603C50F RID: 247055 RVA: 0x01132FF8 File Offset: 0x011311F8
		private void SetEffectVisibleById(int handleId, bool visible)
		{
			if (EffectSystem.Instance.IsValid(handleId))
			{
				EffectSystem.Instance.SetEffectHidden(handleId, !visible, "PerformanceComponent", false);
				EffectSystem.Instance.SetTimeScale(handleId, visible > false, false);
			}
		}

		// Token: 0x0603C510 RID: 247056 RVA: 0x01133030 File Offset: 0x01131230
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			PerformanceComponent performanceComponent = (PerformanceComponent)componentTemplate;
			if (performanceComponent.LevelTagComponent == null)
			{
				this.LevelTagComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LevelTagComponent), "LevelTagComponent"))
			{
				return false;
			}
			if (performanceComponent.ActorComponent == null)
			{
				this.ActorComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComponent), "ActorComponent"))
			{
				return false;
			}
			if (performanceComponent.SceneInteractionEffectMap == null)
			{
				this.SceneInteractionEffectMap = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SceneInteractionEffectMap), "SceneInteractionEffectMap"))
			{
				return false;
			}
			this.CurSceneInteractionLevelTagId = performanceComponent.CurSceneInteractionLevelTagId;
			this.CurStaticMeshTagId = performanceComponent.CurStaticMeshTagId;
			this.CurCommonEffectTagId = performanceComponent.CurCommonEffectTagId;
			this.CommonEffect = performanceComponent.CommonEffect;
			this.CommonEffectNiagaraComp = performanceComponent.CommonEffectNiagaraComp;
			if (performanceComponent.OwnEffectMap == null)
			{
				this.OwnEffectMap = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OwnEffectMap), "OwnEffectMap"))
			{
				return false;
			}
			this.LastChangeEffect = performanceComponent.LastChangeEffect;
			if (performanceComponent.OnChangeEffectFinished == null)
			{
				this.OnChangeEffectFinished = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OnChangeEffectFinished), "OnChangeEffectFinished"))
			{
				return false;
			}
			if (performanceComponent.OnChangeCommonEffectFinished == null)
			{
				this.OnChangeCommonEffectFinished = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OnChangeCommonEffectFinished), "OnChangeCommonEffectFinished"))
			{
				return false;
			}
			if (performanceComponent.CommonEffectTimerId == null)
			{
				this.CommonEffectTimerId = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CommonEffectTimerId), "CommonEffectTimerId"))
			{
				return false;
			}
			if (performanceComponent.ModelConfig == null)
			{
				this.ModelConfig = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ModelConfig), "ModelConfig"))
			{
				return false;
			}
			this.IsSceneInteractionJumpToEnd = performanceComponent.IsSceneInteractionJumpToEnd;
			this.ResTagId = performanceComponent.ResTagId;
			return true;
		}

		// Token: 0x170071D3 RID: 29139
		// (get) Token: 0x0603C511 RID: 247057 RVA: 0x0113320E File Offset: 0x0113140E
		public override bool NeedClearInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170071D4 RID: 29140
		// (get) Token: 0x0603C512 RID: 247058 RVA: 0x01133211 File Offset: 0x01131411
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170071D5 RID: 29141
		// (get) Token: 0x0603C513 RID: 247059 RVA: 0x01133214 File Offset: 0x01131414
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170071D6 RID: 29142
		// (get) Token: 0x0603C514 RID: 247060 RVA: 0x01133217 File Offset: 0x01131417
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170071D7 RID: 29143
		// (get) Token: 0x0603C515 RID: 247061 RVA: 0x0113321A File Offset: 0x0113141A
		public override bool NeedEnableInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170071D8 RID: 29144
		// (get) Token: 0x0603C516 RID: 247062 RVA: 0x0113321D File Offset: 0x0113141D
		public override bool NeedDisableInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170071D9 RID: 29145
		// (get) Token: 0x0603C517 RID: 247063 RVA: 0x01133220 File Offset: 0x01131420
		public override bool NeedChangeTimeDilationInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401FEDA RID: 130778
		[Nullable(2)]
		private LevelTagComponent LevelTagComponent;

		// Token: 0x0401FEDB RID: 130779
		[Nullable(2)]
		private BaseActorComponent ActorComponent;

		// Token: 0x0401FEDC RID: 130780
		[Nullable(2)]
		private Dictionary<int, ESceneInteractionEffect> SceneInteractionEffectMap;

		// Token: 0x0401FEDD RID: 130781
		private int CurSceneInteractionLevelTagId;

		// Token: 0x0401FEDE RID: 130782
		private int CurStaticMeshTagId;

		// Token: 0x0401FEDF RID: 130783
		private int CurCommonEffectTagId;

		// Token: 0x0401FEE0 RID: 130784
		private int CommonEffect;

		// Token: 0x0401FEE1 RID: 130785
		[Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		private OneOf<KuroEffectNiagaraComponentHandle, UNiagaraComponent>? CommonEffectNiagaraComp;

		// Token: 0x0401FEE2 RID: 130786
		[Nullable(2)]
		private Dictionary<int, int> OwnEffectMap;

		// Token: 0x0401FEE3 RID: 130787
		private int LastChangeEffect;

		// Token: 0x0401FEE4 RID: 130788
		[Nullable(2)]
		private Action<int> OnChangeEffectFinished;

		// Token: 0x0401FEE5 RID: 130789
		[Nullable(2)]
		private TTimerAction OnChangeCommonEffectFinished;

		// Token: 0x0401FEE6 RID: 130790
		[Nullable(2)]
		private TimerHandle CommonEffectTimerId;

		// Token: 0x0401FEE7 RID: 130791
		[Nullable(2)]
		private SModelConfig ModelConfig;

		// Token: 0x0401FEE8 RID: 130792
		private bool IsSceneInteractionJumpToEnd;

		// Token: 0x0401FEE9 RID: 130793
		private int? ResTagId;

		// Token: 0x0401FEEA RID: 130794
		private static readonly int ConcealedGameplayTagId = GameplayTagDefine.EGameplayTagId["物体.表现.隐匿"];
	}
}
