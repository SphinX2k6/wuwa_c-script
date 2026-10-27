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
	// Token: 0x02007089 RID: 28809
	[NullableContext(1)]
	[Nullable(0)]
	public class PerformanceComponent : EntityComponent
	{
		// Token: 0x060462C5 RID: 287429 RVA: 0x011889E8 File Offset: 0x01186BE8
		public void SetIsSceneInteractionJumpToEnd(bool value)
		{
			this.IsSceneInteractionJumpToEnd = value;
		}

		// Token: 0x060462C6 RID: 287430 RVA: 0x011889F4 File Offset: 0x01186BF4
		protected override bool OnStart()
		{
			this.CommonEffectTimerId = null;
			this.LevelTagComponent = base.Entity.CheckGetComponent<LevelTagComponent>();
			this.ActorComponent = base.Entity.GetComponent<BaseActorComponent>();
			this.ModelConfig = this.ActorComponent.CreatureData.GetModelConfig();
			this.IsSceneInteractionJumpToEnd = false;
			return true;
		}

		// Token: 0x060462C7 RID: 287431 RVA: 0x01188A48 File Offset: 0x01186C48
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

		// Token: 0x060462C8 RID: 287432 RVA: 0x01188AFC File Offset: 0x01186CFC
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

		// Token: 0x060462C9 RID: 287433 RVA: 0x01188BA4 File Offset: 0x01186DA4
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

		// Token: 0x060462CA RID: 287434 RVA: 0x01188CDC File Offset: 0x01186EDC
		protected override void OnEnable()
		{
			Entity entity = base.Entity;
			if (entity != null && entity.IsInit)
			{
				this.SetPerformanceVisible(this.ActorComponent.CreatureData.GetVisible());
			}
		}

		// Token: 0x060462CB RID: 287435 RVA: 0x01188D08 File Offset: 0x01186F08
		protected override void OnDisable(string reason)
		{
			this.SetPerformanceVisible(false);
		}

		// Token: 0x060462CC RID: 287436 RVA: 0x01188D14 File Offset: 0x01186F14
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

		// Token: 0x060462CD RID: 287437 RVA: 0x01188E00 File Offset: 0x01187000
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

		// Token: 0x060462CE RID: 287438 RVA: 0x01188E61 File Offset: 0x01187061
		private void InitSceneInteractionLevel()
		{
			this.UpdateSceneInteractionLevel(true);
		}

		// Token: 0x060462CF RID: 287439 RVA: 0x01188E6A File Offset: 0x0118706A
		private void ChangeSceneInteractionLevel()
		{
			this.UpdateSceneInteractionLevel(false);
		}

		// Token: 0x060462D0 RID: 287440 RVA: 0x01188E74 File Offset: 0x01187074
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

		// Token: 0x060462D1 RID: 287441 RVA: 0x0118900C File Offset: 0x0118720C
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

		// Token: 0x060462D2 RID: 287442 RVA: 0x011890F8 File Offset: 0x011872F8
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

		// Token: 0x060462D3 RID: 287443 RVA: 0x01189178 File Offset: 0x01187378
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

		// Token: 0x060462D4 RID: 287444 RVA: 0x011891EC File Offset: 0x011873EC
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

		// Token: 0x060462D5 RID: 287445 RVA: 0x011892AC File Offset: 0x011874AC
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

		// Token: 0x060462D6 RID: 287446 RVA: 0x01189378 File Offset: 0x01187578
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

		// Token: 0x060462D7 RID: 287447 RVA: 0x0118946C File Offset: 0x0118766C
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

		// Token: 0x060462D8 RID: 287448 RVA: 0x01189544 File Offset: 0x01187744
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

		// Token: 0x060462D9 RID: 287449 RVA: 0x011895A4 File Offset: 0x011877A4
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

		// Token: 0x060462DA RID: 287450 RVA: 0x011895F4 File Offset: 0x011877F4
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

		// Token: 0x060462DB RID: 287451 RVA: 0x011896A0 File Offset: 0x011878A0
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

		// Token: 0x060462DC RID: 287452 RVA: 0x011896FC File Offset: 0x011878FC
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

		// Token: 0x060462DD RID: 287453 RVA: 0x01189794 File Offset: 0x01187994
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

		// Token: 0x060462DE RID: 287454 RVA: 0x01189904 File Offset: 0x01187B04
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

		// Token: 0x060462DF RID: 287455 RVA: 0x011899BC File Offset: 0x01187BBC
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

		// Token: 0x060462E0 RID: 287456 RVA: 0x01189A1E File Offset: 0x01187C1E
		private void SetCommonEffectByNiagaraParam(SNiagaraParam niagaraParam)
		{
			EffectSystem.Instance.SetEffectDataByNiagaraParam(this.CommonEffect, niagaraParam, true);
		}

		// Token: 0x060462E1 RID: 287457 RVA: 0x01189A32 File Offset: 0x01187C32
		public bool ApplyNiagaraParameters(string key, FVector value)
		{
			if (this.CommonEffect == 0 || this.CommonEffectNiagaraComp == null)
			{
				return false;
			}
			this.CommonEffectNiagaraComp.Value.SetNiagaraVariableVec3(key, value);
			return true;
		}

		// Token: 0x060462E2 RID: 287458 RVA: 0x01189A5F File Offset: 0x01187C5F
		public bool ApplyNiagaraParameters(string key, float value)
		{
			if (this.CommonEffect == 0 || this.CommonEffectNiagaraComp == null)
			{
				return false;
			}
			this.CommonEffectNiagaraComp.Value.SetNiagaraVariableFloat(key, value);
			return true;
		}

		// Token: 0x060462E3 RID: 287459 RVA: 0x01189A8B File Offset: 0x01187C8B
		private void DisposeCommonEffectTimer()
		{
			if (TimerSystem.Instance.Has(this.CommonEffectTimerId))
			{
				TimerSystem.Instance.Remove(this.CommonEffectTimerId);
			}
		}

		// Token: 0x060462E4 RID: 287460 RVA: 0x01189AB0 File Offset: 0x01187CB0
		private void OnSceneInteractionLoadCompleted()
		{
			this.InitSceneInteractionEffects();
			this.InitSceneInteractionExtraEffects();
		}

		// Token: 0x060462E5 RID: 287461 RVA: 0x01189AC0 File Offset: 0x01187CC0
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

		// Token: 0x060462E6 RID: 287462 RVA: 0x01189B30 File Offset: 0x01187D30
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

		// Token: 0x060462E7 RID: 287463 RVA: 0x01189BA0 File Offset: 0x01187DA0
		private void SetEffectVisibleById(int handleId, bool visible)
		{
			if (EffectSystem.Instance.IsValid(handleId))
			{
				EffectSystem.Instance.SetEffectHidden(handleId, !visible, "PerformanceComponent", false);
				EffectSystem.Instance.SetTimeScale(handleId, visible > false, false);
			}
		}

		// Token: 0x060462E8 RID: 287464 RVA: 0x01189BD8 File Offset: 0x01187DD8
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			PerformanceComponent performanceComponent = (PerformanceComponent)componentTemplate;
			if (base.CanResetComponentProperty("LevelTagComponent"))
			{
				if (performanceComponent.LevelTagComponent == null)
				{
					this.LevelTagComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<LevelTagComponent>(this.LevelTagComponent), "LevelTagComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ActorComponent"))
			{
				if (performanceComponent.ActorComponent == null)
				{
					this.ActorComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseActorComponent>(this.ActorComponent), "ActorComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("SceneInteractionEffectMap"))
			{
				if (performanceComponent.SceneInteractionEffectMap == null)
				{
					this.SceneInteractionEffectMap = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, ESceneInteractionEffect>>(this.SceneInteractionEffectMap), "SceneInteractionEffectMap"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CurSceneInteractionLevelTagId"))
			{
				this.CurSceneInteractionLevelTagId = performanceComponent.CurSceneInteractionLevelTagId;
			}
			if (base.CanResetComponentProperty("CurStaticMeshTagId"))
			{
				this.CurStaticMeshTagId = performanceComponent.CurStaticMeshTagId;
			}
			if (base.CanResetComponentProperty("CurCommonEffectTagId"))
			{
				this.CurCommonEffectTagId = performanceComponent.CurCommonEffectTagId;
			}
			if (base.CanResetComponentProperty("CommonEffect"))
			{
				this.CommonEffect = performanceComponent.CommonEffect;
			}
			if (base.CanResetComponentProperty("CommonEffectNiagaraComp"))
			{
				this.CommonEffectNiagaraComp = performanceComponent.CommonEffectNiagaraComp;
			}
			if (base.CanResetComponentProperty("OwnEffectMap"))
			{
				if (performanceComponent.OwnEffectMap == null)
				{
					this.OwnEffectMap = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, int>>(this.OwnEffectMap), "OwnEffectMap"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("LastChangeEffect"))
			{
				this.LastChangeEffect = performanceComponent.LastChangeEffect;
			}
			if (base.CanResetComponentProperty("OnChangeEffectFinished"))
			{
				if (performanceComponent.OnChangeEffectFinished == null)
				{
					this.OnChangeEffectFinished = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Action<int>>(this.OnChangeEffectFinished), "OnChangeEffectFinished"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("OnChangeCommonEffectFinished"))
			{
				if (performanceComponent.OnChangeCommonEffectFinished == null)
				{
					this.OnChangeCommonEffectFinished = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TTimerAction>(this.OnChangeCommonEffectFinished), "OnChangeCommonEffectFinished"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CommonEffectTimerId"))
			{
				if (performanceComponent.CommonEffectTimerId == null)
				{
					this.CommonEffectTimerId = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TimerHandle>(this.CommonEffectTimerId), "CommonEffectTimerId"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ModelConfig"))
			{
				if (performanceComponent.ModelConfig == null)
				{
					this.ModelConfig = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SModelConfig>(this.ModelConfig), "ModelConfig"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("IsSceneInteractionJumpToEnd"))
			{
				this.IsSceneInteractionJumpToEnd = performanceComponent.IsSceneInteractionJumpToEnd;
			}
			if (base.CanResetComponentProperty("ResTagId"))
			{
				this.ResTagId = performanceComponent.ResTagId;
			}
			return true;
		}

		// Token: 0x04024C1F RID: 150559
		[Nullable(2)]
		private LevelTagComponent LevelTagComponent;

		// Token: 0x04024C20 RID: 150560
		[Nullable(2)]
		private BaseActorComponent ActorComponent;

		// Token: 0x04024C21 RID: 150561
		[Nullable(2)]
		private Dictionary<int, ESceneInteractionEffect> SceneInteractionEffectMap;

		// Token: 0x04024C22 RID: 150562
		private int CurSceneInteractionLevelTagId;

		// Token: 0x04024C23 RID: 150563
		private int CurStaticMeshTagId;

		// Token: 0x04024C24 RID: 150564
		private int CurCommonEffectTagId;

		// Token: 0x04024C25 RID: 150565
		private int CommonEffect;

		// Token: 0x04024C26 RID: 150566
		[Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		private OneOf<KuroEffectNiagaraComponentHandle, UNiagaraComponent>? CommonEffectNiagaraComp;

		// Token: 0x04024C27 RID: 150567
		[Nullable(2)]
		private Dictionary<int, int> OwnEffectMap;

		// Token: 0x04024C28 RID: 150568
		private int LastChangeEffect;

		// Token: 0x04024C29 RID: 150569
		[Nullable(2)]
		private Action<int> OnChangeEffectFinished;

		// Token: 0x04024C2A RID: 150570
		[Nullable(2)]
		private TTimerAction OnChangeCommonEffectFinished;

		// Token: 0x04024C2B RID: 150571
		[Nullable(2)]
		private TimerHandle CommonEffectTimerId;

		// Token: 0x04024C2C RID: 150572
		[Nullable(2)]
		private SModelConfig ModelConfig;

		// Token: 0x04024C2D RID: 150573
		private bool IsSceneInteractionJumpToEnd;

		// Token: 0x04024C2E RID: 150574
		private int? ResTagId;

		// Token: 0x04024C2F RID: 150575
		private static readonly int ConcealedGameplayTagId = GameplayTagDefine.EGameplayTagId["物体.表现.隐匿"];
	}
}
