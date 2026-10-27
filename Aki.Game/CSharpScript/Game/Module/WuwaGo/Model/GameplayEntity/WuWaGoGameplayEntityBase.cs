using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity
{
	// Token: 0x02004746 RID: 18246
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class WuWaGoGameplayEntityBase : WuWaGoBaseUnit
	{
		// Token: 0x0602FAEB RID: 195307 RVA: 0x00B0CCDC File Offset: 0x00B0AEDC
		[NullableContext(1)]
		protected WuWaGoGameplayEntityBase(EWuWaGoEntityType entityType, int pbDataId, Vector coordinate, Rotator rotator) : base(coordinate, rotator)
		{
		}

		// Token: 0x17007729 RID: 30505
		// (get) Token: 0x0602FAEC RID: 195308 RVA: 0x00B0CCFC File Offset: 0x00B0AEFC
		public override bool Actionable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700772A RID: 30506
		// (get) Token: 0x0602FAED RID: 195309 RVA: 0x00B0CCFF File Offset: 0x00B0AEFF
		public override bool MoveAbility
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700772B RID: 30507
		// (get) Token: 0x0602FAEE RID: 195310 RVA: 0x00B0CD02 File Offset: 0x00B0AF02
		public IReadOnlyList<int> OpenAddClientTags
		{
			get
			{
				return this.OpenAddClientTagsInner;
			}
		}

		// Token: 0x0602FAEF RID: 195311 RVA: 0x00B0CD0A File Offset: 0x00B0AF0A
		public void SetOpenAddClientTags(IReadOnlyList<int> tags)
		{
			this.OpenAddClientTagsInner = tags;
		}

		// Token: 0x1700772C RID: 30508
		// (get) Token: 0x0602FAF0 RID: 195312 RVA: 0x00B0CD13 File Offset: 0x00B0AF13
		// (set) Token: 0x0602FAF1 RID: 195313 RVA: 0x00B0CD1B File Offset: 0x00B0AF1B
		public EGameplayEntityState State { get; private set; }

		// Token: 0x1700772D RID: 30509
		// (get) Token: 0x0602FAF2 RID: 195314 RVA: 0x00B0CD24 File Offset: 0x00B0AF24
		// (set) Token: 0x0602FAF3 RID: 195315 RVA: 0x00B0CD2C File Offset: 0x00B0AF2C
		public int StandGridId { get; private set; }

		// Token: 0x0602FAF4 RID: 195316 RVA: 0x00B0CD35 File Offset: 0x00B0AF35
		protected override AActor GetActorRaw()
		{
			return CharacterController.Instance.GetActor(this.EntityHandle);
		}

		// Token: 0x1700772E RID: 30510
		// (get) Token: 0x0602FAF5 RID: 195317 RVA: 0x00B0CD47 File Offset: 0x00B0AF47
		public EntityHandle EntityHandle
		{
			get
			{
				return CreatureModel.Instance.GetEntityByPbDataId(this.EntityPbDataId);
			}
		}

		// Token: 0x1700772F RID: 30511
		// (get) Token: 0x0602FAF6 RID: 195318 RVA: 0x00B0CD59 File Offset: 0x00B0AF59
		public SceneItemMoveComponent SceneItemMoveComponent
		{
			get
			{
				EntityHandle entityHandle = this.EntityHandle;
				if (entityHandle == null)
				{
					return null;
				}
				WorldEntity entity = entityHandle.Entity;
				if (entity == null)
				{
					return null;
				}
				return entity.GetComponent<SceneItemMoveComponent>();
			}
		}

		// Token: 0x0602FAF7 RID: 195319 RVA: 0x00B0CD78 File Offset: 0x00B0AF78
		public void SetStandGridId(int gridId)
		{
			if (this.StandGridId == gridId)
			{
				return;
			}
			base.MarkRollbackDirty();
			WuWaGoGrid standGridInner = this.StandGridInner;
			WuWaGoGrid wuWaGoGrid = (gridId == 0) ? null : ((standGridInner != null && standGridInner.Id == gridId) ? standGridInner : WuWaGoModel.Instance.GetGridById(gridId));
			this.OnBeforeStandGridChanged(standGridInner, wuWaGoGrid);
			this.StandGridId = gridId;
			this.StandGridInner = wuWaGoGrid;
			this.OnAfterStandGridChanged(standGridInner, wuWaGoGrid);
		}

		// Token: 0x0602FAF8 RID: 195320 RVA: 0x00B0CDDB File Offset: 0x00B0AFDB
		public void SetInitialState(EGameplayEntityState state)
		{
			this.InitialState = state;
		}

		// Token: 0x0602FAF9 RID: 195321 RVA: 0x00B0CDE4 File Offset: 0x00B0AFE4
		public virtual bool SetState(EGameplayEntityState newState)
		{
			if (this.State == newState)
			{
				return false;
			}
			base.MarkRollbackDirty();
			this.State = newState;
			this.OnStateChanged(newState);
			return true;
		}

		// Token: 0x0602FAFA RID: 195322 RVA: 0x00B0CE06 File Offset: 0x00B0B006
		public virtual void Unlock()
		{
			this.State = this.InitialState;
		}

		// Token: 0x0602FAFB RID: 195323 RVA: 0x00B0CE14 File Offset: 0x00B0B014
		public virtual void RestoreInitialStateForGameOver()
		{
			this.State = this.InitialState;
		}

		// Token: 0x0602FAFC RID: 195324 RVA: 0x00B0CE22 File Offset: 0x00B0B022
		[NullableContext(1)]
		public override IRollbackCapture CaptureRollback()
		{
			return new GameplayEntityRollbackCapture<WuWaGoGameplayEntityBase>(this);
		}

		// Token: 0x0602FAFD RID: 195325 RVA: 0x00B0CE2A File Offset: 0x00B0B02A
		public void SetStateSilently(EGameplayEntityState newState)
		{
			if (this.State == newState)
			{
				return;
			}
			base.MarkRollbackDirty();
			this.State = newState;
		}

		// Token: 0x0602FAFE RID: 195326 RVA: 0x00B0CE43 File Offset: 0x00B0B043
		protected virtual void OnStateChanged(EGameplayEntityState newState)
		{
		}

		// Token: 0x0602FAFF RID: 195327 RVA: 0x00B0CE45 File Offset: 0x00B0B045
		protected void RestoreInitialStateWithStateChanged()
		{
			this.State = this.InitialState;
			this.OnStateChanged(this.InitialState);
		}

		// Token: 0x0602FB00 RID: 195328 RVA: 0x00B0CE5F File Offset: 0x00B0B05F
		protected virtual void OnBeforeStandGridChanged(WuWaGoGrid prevGrid, WuWaGoGrid nextGrid)
		{
		}

		// Token: 0x0602FB01 RID: 195329 RVA: 0x00B0CE61 File Offset: 0x00B0B061
		protected virtual void OnAfterStandGridChanged(WuWaGoGrid prevGrid, WuWaGoGrid nextGrid)
		{
		}

		// Token: 0x0602FB02 RID: 195330 RVA: 0x00B0CE64 File Offset: 0x00B0B064
		protected void SwitchSceneItemStateByGameplayEntityState(EGameplayEntityState newState, bool needTransition = true, bool jumpToEnd = false)
		{
			EntityHandle entityHandle = this.EntityHandle;
			WorldEntity worldEntity = (entityHandle != null) ? entityHandle.Entity : null;
			SceneItemActorComponent sceneItemActorComponent = (worldEntity != null) ? worldEntity.GetComponent<SceneItemActorComponent>() : null;
			CreatureDataComponent creatureDataComponent = (worldEntity != null) ? worldEntity.GetComponent<CreatureDataComponent>() : null;
			if (sceneItemActorComponent == null || creatureDataComponent == null)
			{
				return;
			}
			FGameplayTag? gameplayTagById = GameplayTagUtils.GetGameplayTagById(GameplayTagUtils.GetTagIdByName(newState.ToEnumString()));
			EKuroSceneInteractionState targetState;
			if (gameplayTagById == null || !creatureDataComponent.GetModelConfig().场景交互物状态列表.TryGetValue(gameplayTagById.Value, out targetState))
			{
				return;
			}
			sceneItemActorComponent.SwitchToState(targetState, needTransition, jumpToEnd);
		}

		// Token: 0x0602FB03 RID: 195331 RVA: 0x00B0CEE4 File Offset: 0x00B0B0E4
		public virtual void Destroy()
		{
			this.SetStandGridId(0);
			this.State = EGameplayEntityState.Locked;
			this.StandGridId = 0;
			this.StandGridInner = null;
		}

		// Token: 0x04019BE4 RID: 105444
		private WuWaGoGrid StandGridInner;

		// Token: 0x04019BE5 RID: 105445
		public readonly int EntityPbDataId = pbDataId;

		// Token: 0x04019BE6 RID: 105446
		private EGameplayEntityState InitialState = EGameplayEntityState.Normal;

		// Token: 0x04019BE7 RID: 105447
		private IReadOnlyList<int> OpenAddClientTagsInner;

		// Token: 0x04019BEA RID: 105450
		public readonly EWuWaGoEntityType EntityType = entityType;
	}
}
