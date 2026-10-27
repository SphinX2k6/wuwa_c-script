using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.NewWorld.Common.Component;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using CSharpScript.Game.NewWorld.SceneItem.Jigsaw;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x02007173 RID: 29043
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemChessmanComponent : EntityComponent
	{
		// Token: 0x06046EB2 RID: 290482 RVA: 0x011E8B74 File Offset: 0x011E6D74
		protected override bool OnInitData(IEntityArgs args = null)
		{
			ChessmanComponent config = args.GetP1<CreateEntityData>().GetParam<SceneItemChessmanComponent>() as ChessmanComponent;
			this.Config = config;
			return true;
		}

		// Token: 0x06046EB3 RID: 290483 RVA: 0x011E8B9C File Offset: 0x011E6D9C
		protected override bool OnStart()
		{
			this.ItemComponent = base.Entity.GetComponent<SceneItemJigsawItemComponent>();
			this.MoveComponent = base.Entity.GetComponent<SceneItemMoveComponent>();
			this.ActorComponent = base.Entity.GetComponent<SceneItemActorComponent>();
			this.TagComponent = base.Entity.GetComponent<LevelTagComponent>();
			SceneItemMoveComponent moveComponent = this.MoveComponent;
			if (moveComponent != null)
			{
				moveComponent.AddStopMoveCallback(new Action(this.OnTicTacToePieceMoveEnd));
			}
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnSceneInteractionShowCompleted, new Action(this.OnSceneInteractionLoadCompleted));
			return true;
		}

		// Token: 0x06046EB4 RID: 290484 RVA: 0x011E8C30 File Offset: 0x011E6E30
		protected override bool OnEnd()
		{
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnSceneInteractionShowCompleted, new Action(this.OnSceneInteractionLoadCompleted));
			SceneItemMoveComponent moveComponent = this.MoveComponent;
			if (moveComponent != null)
			{
				moveComponent.RemoveStopMoveCallback(new Action(this.OnTicTacToePieceMoveEnd));
			}
			return true;
		}

		// Token: 0x06046EB5 RID: 290485 RVA: 0x011E8C7D File Offset: 0x011E6E7D
		[NullableContext(1)]
		public bool RegisterOnSceneInteractionLoadCompleted(Action callback)
		{
			SceneItemActorComponent actorComponent = this.ActorComponent;
			if (actorComponent != null && actorComponent.GetIsSceneInteractionLoadCompleted())
			{
				return false;
			}
			this.SceneInteractionLoadCompletedCallback = callback;
			return true;
		}

		// Token: 0x06046EB6 RID: 290486 RVA: 0x011E8C9D File Offset: 0x011E6E9D
		private void OnSceneInteractionLoadCompleted()
		{
			if (this.SceneInteractionLoadCompletedCallback != null)
			{
				this.SceneInteractionLoadCompletedCallback();
			}
		}

		// Token: 0x06046EB7 RID: 290487 RVA: 0x011E8CB4 File Offset: 0x011E6EB4
		private void OnPieceMoveStart()
		{
			LevelTagComponent tagComponent = this.TagComponent;
			if (tagComponent != null)
			{
				tagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.棋子.移动中"]));
			}
			ChessmanComponent config = this.Config;
			if (((config != null) ? config.StartMovingActions : null) == null)
			{
				return;
			}
			EntityContext context = EntityContext.Create(base.Entity.Id, null);
			LevelGeneralController.Instance.ExecuteActionsNew(this.Config.StartMovingActions, context, null);
		}

		// Token: 0x06046EB8 RID: 290488 RVA: 0x011E8D2C File Offset: 0x011E6F2C
		private void OnTicTacToePieceMoveEnd()
		{
			if (this.OnPieceMoveEnd != null)
			{
				SceneItemActorComponent actorComponent = this.ActorComponent;
				AActor aactor = (actorComponent != null) ? actorComponent.GetInteractionMainActor() : null;
				if (aactor != null)
				{
					this.OnPieceMoveEnd(aactor, this.ItemComponent, this.TargetJigsawIndex);
					this.TargetJigsawIndex = null;
				}
				this.OnPieceMoveEnd = null;
			}
			ChessmanComponent config = this.Config;
			if (((config != null) ? config.EndMovingActions : null) != null)
			{
				EntityContext context = EntityContext.Create(base.Entity.Id, null);
				LevelGeneralController.Instance.ExecuteActionsNew(this.Config.EndMovingActions, context, null);
			}
			LevelTagComponent tagComponent = this.TagComponent;
			if (tagComponent == null)
			{
				return;
			}
			tagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.棋子.移动中"]));
		}

		// Token: 0x06046EB9 RID: 290489 RVA: 0x011E8DE8 File Offset: 0x011E6FE8
		public void OnTicTacToePieceMove([Nullable(1)] JigsawIndex target, [Nullable(1)] Action<AActor, SceneItemJigsawItemComponent, JigsawIndex> onPieceMoveEnd, Vector movePoint0 = null, Vector movePoint1 = null, Vector movePoint2 = null)
		{
			SceneItemJigsawItemComponent itemComponent = this.ItemComponent;
			Vector vector;
			if (itemComponent == null)
			{
				vector = null;
			}
			else
			{
				SceneItemJigsawBaseComponent putDownBase = itemComponent.PutDownBase;
				vector = ((putDownBase != null) ? putDownBase.GetBlockLocationByIndex(target, true) : null);
			}
			Vector vector2 = vector;
			if (vector2 != null)
			{
				this.OnPieceMoveStart();
				if (movePoint0 == null || movePoint1 == null || movePoint2 == null)
				{
					SceneItemMoveComponent moveComponent = this.MoveComponent;
					if (moveComponent != null)
					{
						moveComponent.AddMoveTarget(new SceneItemMoveComponent.MoveTarget(vector2, 1f, 0f, -1f, -1f));
					}
				}
				else
				{
					SceneItemMoveComponent moveComponent2 = this.MoveComponent;
					if (moveComponent2 != null)
					{
						moveComponent2.AddMoveTarget(new SceneItemMoveComponent.MoveTarget(movePoint0, 0.25f, 0f, -1f, -1f));
					}
					SceneItemMoveComponent moveComponent3 = this.MoveComponent;
					if (moveComponent3 != null)
					{
						moveComponent3.AddMoveTarget(new SceneItemMoveComponent.MoveTarget(movePoint1, 0.25f, 0f, -1f, -1f));
					}
					SceneItemMoveComponent moveComponent4 = this.MoveComponent;
					if (moveComponent4 != null)
					{
						moveComponent4.AddMoveTarget(new SceneItemMoveComponent.MoveTarget(movePoint2, 0.25f, 0f, -1f, -1f));
					}
					SceneItemMoveComponent moveComponent5 = this.MoveComponent;
					if (moveComponent5 != null)
					{
						moveComponent5.AddMoveTarget(new SceneItemMoveComponent.MoveTarget(vector2, 0.25f, 0f, -1f, -1f));
					}
				}
				this.OnPieceMoveEnd = onPieceMoveEnd;
				this.TargetJigsawIndex = new JigsawIndex(target.Row, target.Col);
			}
		}

		// Token: 0x06046EBA RID: 290490 RVA: 0x011E8F2C File Offset: 0x011E712C
		[NullableContext(1)]
		public void SetTicTacToePieceLocation(JigsawIndex target, [Nullable(new byte[]
		{
			2,
			1
		})] Action<AActor> refreshPickBoundsEvent)
		{
			SceneItemJigsawItemComponent itemComponent = this.ItemComponent;
			Vector vector;
			if (itemComponent == null)
			{
				vector = null;
			}
			else
			{
				SceneItemJigsawBaseComponent putDownBase = itemComponent.PutDownBase;
				vector = ((putDownBase != null) ? putDownBase.GetBlockLocationByIndex(target, true) : null);
			}
			Vector vector2 = vector;
			if (vector2 != null)
			{
				SceneItemMoveComponent moveComponent = this.MoveComponent;
				if (moveComponent != null)
				{
					moveComponent.StopMove(true, true);
				}
				SceneItemMoveComponent moveComponent2 = this.MoveComponent;
				if (moveComponent2 != null)
				{
					moveComponent2.AddStopMoveCallback(new Action(this.OnTicTacToePieceMoveEnd));
				}
				LevelTagComponent tagComponent = this.TagComponent;
				if (tagComponent != null)
				{
					tagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.棋子.出现"]));
				}
				LevelTagComponent tagComponent2 = this.TagComponent;
				if (tagComponent2 != null)
				{
					tagComponent2.AddTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.棋子.消失"]));
				}
				this.TargetLocation = vector2;
				this.RefreshPickBoundsEvent = refreshPickBoundsEvent;
				if (this.SetLocationPerformanceTimerHandle == null)
				{
					this.SetLocationPerformanceTimerHandle = TimerSystem.Instance.Delay(new TTimerAction(this.ChessmanSetLocationPerformance), 1000f, null, null, true, 1f);
				}
			}
		}

		// Token: 0x06046EBB RID: 290491 RVA: 0x011E901C File Offset: 0x011E721C
		private void ChessmanSetLocationPerformance(float _)
		{
			LevelTagComponent tagComponent = this.TagComponent;
			if (tagComponent != null)
			{
				tagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.棋子.消失"]));
			}
			LevelTagComponent tagComponent2 = this.TagComponent;
			if (tagComponent2 != null)
			{
				tagComponent2.AddTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.棋子.出现"]));
			}
			TimerSystem.Instance.Delay(delegate(float _)
			{
				LevelTagComponent tagComponent3 = this.TagComponent;
				if (tagComponent3 == null)
				{
					return;
				}
				tagComponent3.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.棋子.出现"]));
			}, 1000f, null, null, true, 1f);
			SceneItemActorComponent actorComponent = this.ActorComponent;
			if (actorComponent != null)
			{
				actorComponent.SetActorLocation(this.TargetLocation.ToUeVector(false), "unknown", true);
			}
			SceneItemActorComponent actorComponent2 = this.ActorComponent;
			AActor aactor = (actorComponent2 != null) ? actorComponent2.GetInteractionMainActor() : null;
			if (aactor != null && this.RefreshPickBoundsEvent != null)
			{
				this.RefreshPickBoundsEvent(aactor);
			}
			this.SetLocationPerformanceTimerHandle = null;
			this.TargetLocation = null;
			this.RefreshPickBoundsEvent = null;
		}

		// Token: 0x06046EBC RID: 290492 RVA: 0x011E90FC File Offset: 0x011E72FC
		public void OnTicTacToePieceMovingChange(bool moving)
		{
			if (moving)
			{
				LevelTagComponent tagComponent = this.TagComponent;
				if (tagComponent != null)
				{
					tagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.棋子.可操控"]));
				}
				LevelTagComponent tagComponent2 = this.TagComponent;
				if (tagComponent2 == null)
				{
					return;
				}
				tagComponent2.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.棋子.被选中"]));
				return;
			}
			else
			{
				LevelTagComponent tagComponent3 = this.TagComponent;
				if (tagComponent3 == null)
				{
					return;
				}
				tagComponent3.AddTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.棋子.可操控"]));
				return;
			}
		}

		// Token: 0x06046EBD RID: 290493 RVA: 0x011E917C File Offset: 0x011E737C
		public void OnTicTacToePieceSelect(bool select, bool controller)
		{
			if (select)
			{
				LevelTagComponent tagComponent = this.TagComponent;
				if (tagComponent != null)
				{
					tagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.棋子.被选中"]));
				}
			}
			else
			{
				LevelTagComponent tagComponent2 = this.TagComponent;
				if (tagComponent2 != null)
				{
					tagComponent2.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.棋子.被选中"]));
				}
			}
			if (controller)
			{
				LevelTagComponent tagComponent3 = this.TagComponent;
				if (tagComponent3 == null)
				{
					return;
				}
				tagComponent3.AddTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.棋子.可操控"]));
				return;
			}
			else
			{
				LevelTagComponent tagComponent4 = this.TagComponent;
				if (tagComponent4 == null)
				{
					return;
				}
				tagComponent4.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.棋子.可操控"]));
				return;
			}
		}

		// Token: 0x06046EBE RID: 290494 RVA: 0x011E9228 File Offset: 0x011E7428
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemChessmanComponent sceneItemChessmanComponent = (SceneItemChessmanComponent)componentTemplate;
			if (base.CanResetComponentProperty("ItemComponent"))
			{
				if (sceneItemChessmanComponent.ItemComponent == null)
				{
					this.ItemComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemJigsawItemComponent>(this.ItemComponent), "ItemComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("MoveComponent"))
			{
				if (sceneItemChessmanComponent.MoveComponent == null)
				{
					this.MoveComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemMoveComponent>(this.MoveComponent), "MoveComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ActorComponent"))
			{
				if (sceneItemChessmanComponent.ActorComponent == null)
				{
					this.ActorComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemActorComponent>(this.ActorComponent), "ActorComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TagComponent"))
			{
				if (sceneItemChessmanComponent.TagComponent == null)
				{
					this.TagComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<LevelTagComponent>(this.TagComponent), "TagComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("Config"))
			{
				if (sceneItemChessmanComponent.Config == null)
				{
					this.Config = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ChessmanComponent>(this.Config), "Config"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("SceneInteractionLoadCompletedCallback"))
			{
				if (sceneItemChessmanComponent.SceneInteractionLoadCompletedCallback == null)
				{
					this.SceneInteractionLoadCompletedCallback = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Action>(this.SceneInteractionLoadCompletedCallback), "SceneInteractionLoadCompletedCallback"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("OnPieceMoveEnd"))
			{
				if (sceneItemChessmanComponent.OnPieceMoveEnd == null)
				{
					this.OnPieceMoveEnd = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Action<AActor, SceneItemJigsawItemComponent, JigsawIndex>>(this.OnPieceMoveEnd), "OnPieceMoveEnd"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TargetJigsawIndex"))
			{
				if (sceneItemChessmanComponent.TargetJigsawIndex == null)
				{
					this.TargetJigsawIndex = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<JigsawIndex>(this.TargetJigsawIndex), "TargetJigsawIndex"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TargetLocation"))
			{
				if (sceneItemChessmanComponent.TargetLocation == null)
				{
					this.TargetLocation = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TargetLocation), "TargetLocation"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("SetLocationPerformanceTimerHandle"))
			{
				if (sceneItemChessmanComponent.SetLocationPerformanceTimerHandle == null)
				{
					this.SetLocationPerformanceTimerHandle = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TimerHandle>(this.SetLocationPerformanceTimerHandle), "SetLocationPerformanceTimerHandle"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("RefreshPickBoundsEvent"))
			{
				if (sceneItemChessmanComponent.RefreshPickBoundsEvent == null)
				{
					this.RefreshPickBoundsEvent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Action<AActor>>(this.RefreshPickBoundsEvent), "RefreshPickBoundsEvent"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x040253D9 RID: 152537
		private const int CHESSMAN_SETLOCATION_PERFORMANCE_TIME = 1000;

		// Token: 0x040253DA RID: 152538
		private SceneItemJigsawItemComponent ItemComponent;

		// Token: 0x040253DB RID: 152539
		private SceneItemMoveComponent MoveComponent;

		// Token: 0x040253DC RID: 152540
		private SceneItemActorComponent ActorComponent;

		// Token: 0x040253DD RID: 152541
		private LevelTagComponent TagComponent;

		// Token: 0x040253DE RID: 152542
		private ChessmanComponent Config;

		// Token: 0x040253DF RID: 152543
		private Action SceneInteractionLoadCompletedCallback;

		// Token: 0x040253E0 RID: 152544
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private Action<AActor, SceneItemJigsawItemComponent, JigsawIndex> OnPieceMoveEnd;

		// Token: 0x040253E1 RID: 152545
		private JigsawIndex TargetJigsawIndex;

		// Token: 0x040253E2 RID: 152546
		private Vector TargetLocation;

		// Token: 0x040253E3 RID: 152547
		private TimerHandle SetLocationPerformanceTimerHandle;

		// Token: 0x040253E4 RID: 152548
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<AActor> RefreshPickBoundsEvent;
	}
}
