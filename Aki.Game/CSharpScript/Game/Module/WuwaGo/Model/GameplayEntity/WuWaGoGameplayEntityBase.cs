using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity
{
	// Token: 0x02003677 RID: 13943
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class WuWaGoGameplayEntityBase : WuWaGoBaseUnit
	{
		// Token: 0x060242B5 RID: 148149 RVA: 0x00A3CCA8 File Offset: 0x00A3AEA8
		[NullableContext(1)]
		protected WuWaGoGameplayEntityBase(EWuWaGoEntityType entityType, int pbDataId, Vector coordinate, Rotator rotator) : base(coordinate, rotator)
		{
		}

		// Token: 0x170049E5 RID: 18917
		// (get) Token: 0x060242B6 RID: 148150 RVA: 0x00A3CCC8 File Offset: 0x00A3AEC8
		public override bool Actionable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170049E6 RID: 18918
		// (get) Token: 0x060242B7 RID: 148151 RVA: 0x00A3CCCB File Offset: 0x00A3AECB
		public override bool MoveAbility
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170049E7 RID: 18919
		// (get) Token: 0x060242B8 RID: 148152 RVA: 0x00A3CCCE File Offset: 0x00A3AECE
		public IReadOnlyList<int> OpenAddClientTags
		{
			get
			{
				return this.OpenAddClientTagsInner;
			}
		}

		// Token: 0x060242B9 RID: 148153 RVA: 0x00A3CCD6 File Offset: 0x00A3AED6
		public void SetOpenAddClientTags(IReadOnlyList<int> tags)
		{
			this.OpenAddClientTagsInner = tags;
		}

		// Token: 0x170049E8 RID: 18920
		// (get) Token: 0x060242BA RID: 148154 RVA: 0x00A3CCDF File Offset: 0x00A3AEDF
		// (set) Token: 0x060242BB RID: 148155 RVA: 0x00A3CCE7 File Offset: 0x00A3AEE7
		public EGameplayEntityState State { get; private set; }

		// Token: 0x170049E9 RID: 18921
		// (get) Token: 0x060242BC RID: 148156 RVA: 0x00A3CCF0 File Offset: 0x00A3AEF0
		// (set) Token: 0x060242BD RID: 148157 RVA: 0x00A3CCF8 File Offset: 0x00A3AEF8
		public int StandGridId { get; private set; }

		// Token: 0x060242BE RID: 148158 RVA: 0x00A3CD01 File Offset: 0x00A3AF01
		protected override AActor GetActorRaw()
		{
			return CharacterController.Instance.GetActor(this.EntityHandle);
		}

		// Token: 0x170049EA RID: 18922
		// (get) Token: 0x060242BF RID: 148159 RVA: 0x00A3CD13 File Offset: 0x00A3AF13
		public EntityHandle EntityHandle
		{
			get
			{
				return CreatureModel.Instance.GetEntityByPbDataId(this.EntityPbDataId);
			}
		}

		// Token: 0x170049EB RID: 18923
		// (get) Token: 0x060242C0 RID: 148160 RVA: 0x00A3CD25 File Offset: 0x00A3AF25
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

		// Token: 0x060242C1 RID: 148161 RVA: 0x00A3CD44 File Offset: 0x00A3AF44
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

		// Token: 0x060242C2 RID: 148162 RVA: 0x00A3CDA7 File Offset: 0x00A3AFA7
		public void SetInitialState(EGameplayEntityState state)
		{
			this.InitialState = state;
		}

		// Token: 0x060242C3 RID: 148163 RVA: 0x00A3CDB0 File Offset: 0x00A3AFB0
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

		// Token: 0x060242C4 RID: 148164 RVA: 0x00A3CDD2 File Offset: 0x00A3AFD2
		public virtual void Unlock()
		{
			this.State = this.InitialState;
		}

		// Token: 0x060242C5 RID: 148165 RVA: 0x00A3CDE0 File Offset: 0x00A3AFE0
		public virtual void RestoreInitialStateForGameOver()
		{
			this.State = this.InitialState;
		}

		// Token: 0x060242C6 RID: 148166 RVA: 0x00A3CDEE File Offset: 0x00A3AFEE
		[NullableContext(1)]
		public override IRollbackCapture CaptureRollback()
		{
			return new GameplayEntityRollbackCapture<WuWaGoGameplayEntityBase>(this);
		}

		// Token: 0x060242C7 RID: 148167 RVA: 0x00A3CDF6 File Offset: 0x00A3AFF6
		public void SetStateSilently(EGameplayEntityState newState)
		{
			if (this.State == newState)
			{
				return;
			}
			base.MarkRollbackDirty();
			this.State = newState;
		}

		// Token: 0x060242C8 RID: 148168 RVA: 0x00A3CE0F File Offset: 0x00A3B00F
		protected virtual void OnStateChanged(EGameplayEntityState newState)
		{
		}

		// Token: 0x060242C9 RID: 148169 RVA: 0x00A3CE11 File Offset: 0x00A3B011
		protected void RestoreInitialStateWithStateChanged()
		{
			this.State = this.InitialState;
			this.OnStateChanged(this.InitialState);
		}

		// Token: 0x060242CA RID: 148170 RVA: 0x00A3CE2B File Offset: 0x00A3B02B
		protected virtual void OnBeforeStandGridChanged(WuWaGoGrid prevGrid, WuWaGoGrid nextGrid)
		{
		}

		// Token: 0x060242CB RID: 148171 RVA: 0x00A3CE2D File Offset: 0x00A3B02D
		protected virtual void OnAfterStandGridChanged(WuWaGoGrid prevGrid, WuWaGoGrid nextGrid)
		{
		}

		// Token: 0x060242CC RID: 148172 RVA: 0x00A3CE30 File Offset: 0x00A3B030
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

		// Token: 0x060242CD RID: 148173 RVA: 0x00A3CEB0 File Offset: 0x00A3B0B0
		public virtual void Destroy()
		{
			this.SetStandGridId(0);
			this.State = EGameplayEntityState.Locked;
			this.StandGridId = 0;
			this.StandGridInner = null;
		}

		// Token: 0x04014294 RID: 82580
		private WuWaGoGrid StandGridInner;

		// Token: 0x04014295 RID: 82581
		public readonly int EntityPbDataId = pbDataId;

		// Token: 0x04014296 RID: 82582
		private EGameplayEntityState InitialState = EGameplayEntityState.Normal;

		// Token: 0x04014297 RID: 82583
		private IReadOnlyList<int> OpenAddClientTagsInner;

		// Token: 0x0401429A RID: 82586
		public readonly EWuWaGoEntityType EntityType = entityType;
	}
}
