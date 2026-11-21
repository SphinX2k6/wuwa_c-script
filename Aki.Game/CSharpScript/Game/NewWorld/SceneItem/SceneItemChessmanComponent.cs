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
	// Token: 0x02006227 RID: 25127
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemChessmanComponent : EntityComponent
	{
		// Token: 0x0603C71E RID: 247582 RVA: 0x01143EF8 File Offset: 0x011420F8
		protected override bool OnInitData(IEntityArgs args = null)
		{
			ChessmanComponent config = args.GetP1<CreateEntityData>().GetParam<SceneItemChessmanComponent>() as ChessmanComponent;
			this.Config = config;
			return true;
		}

		// Token: 0x0603C71F RID: 247583 RVA: 0x01143F20 File Offset: 0x01142120
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

		// Token: 0x0603C720 RID: 247584 RVA: 0x01143FB4 File Offset: 0x011421B4
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

		// Token: 0x0603C721 RID: 247585 RVA: 0x01144001 File Offset: 0x01142201
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

		// Token: 0x0603C722 RID: 247586 RVA: 0x01144021 File Offset: 0x01142221
		private void OnSceneInteractionLoadCompleted()
		{
			if (this.SceneInteractionLoadCompletedCallback != null)
			{
				this.SceneInteractionLoadCompletedCallback();
			}
		}

		// Token: 0x0603C723 RID: 247587 RVA: 0x01144038 File Offset: 0x01142238
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

		// Token: 0x0603C724 RID: 247588 RVA: 0x011440B0 File Offset: 0x011422B0
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

		// Token: 0x0603C725 RID: 247589 RVA: 0x0114416C File Offset: 0x0114236C
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

		// Token: 0x0603C726 RID: 247590 RVA: 0x011442B0 File Offset: 0x011424B0
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

		// Token: 0x0603C727 RID: 247591 RVA: 0x011443A0 File Offset: 0x011425A0
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

		// Token: 0x0603C728 RID: 247592 RVA: 0x01144480 File Offset: 0x01142680
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

		// Token: 0x0603C729 RID: 247593 RVA: 0x01144500 File Offset: 0x01142700
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

		// Token: 0x0603C72A RID: 247594 RVA: 0x011445AC File Offset: 0x011427AC
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemChessmanComponent sceneItemChessmanComponent = (SceneItemChessmanComponent)componentTemplate;
			if (sceneItemChessmanComponent.ItemComponent == null)
			{
				this.ItemComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ItemComponent), "ItemComponent"))
			{
				return false;
			}
			if (sceneItemChessmanComponent.MoveComponent == null)
			{
				this.MoveComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComponent), "MoveComponent"))
			{
				return false;
			}
			if (sceneItemChessmanComponent.ActorComponent == null)
			{
				this.ActorComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComponent), "ActorComponent"))
			{
				return false;
			}
			if (sceneItemChessmanComponent.TagComponent == null)
			{
				this.TagComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComponent), "TagComponent"))
			{
				return false;
			}
			if (sceneItemChessmanComponent.Config == null)
			{
				this.Config = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Config), "Config"))
			{
				return false;
			}
			if (sceneItemChessmanComponent.SceneInteractionLoadCompletedCallback == null)
			{
				this.SceneInteractionLoadCompletedCallback = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SceneInteractionLoadCompletedCallback), "SceneInteractionLoadCompletedCallback"))
			{
				return false;
			}
			if (sceneItemChessmanComponent.OnPieceMoveEnd == null)
			{
				this.OnPieceMoveEnd = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OnPieceMoveEnd), "OnPieceMoveEnd"))
			{
				return false;
			}
			if (sceneItemChessmanComponent.TargetJigsawIndex == null)
			{
				this.TargetJigsawIndex = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TargetJigsawIndex), "TargetJigsawIndex"))
			{
				return false;
			}
			if (sceneItemChessmanComponent.TargetLocation == null)
			{
				this.TargetLocation = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TargetLocation), "TargetLocation"))
			{
				return false;
			}
			if (sceneItemChessmanComponent.SetLocationPerformanceTimerHandle == null)
			{
				this.SetLocationPerformanceTimerHandle = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SetLocationPerformanceTimerHandle), "SetLocationPerformanceTimerHandle"))
			{
				return false;
			}
			if (sceneItemChessmanComponent.RefreshPickBoundsEvent == null)
			{
				this.RefreshPickBoundsEvent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.RefreshPickBoundsEvent), "RefreshPickBoundsEvent"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x1700722B RID: 29227
		// (get) Token: 0x0603C72B RID: 247595 RVA: 0x011447A5 File Offset: 0x011429A5
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700722C RID: 29228
		// (get) Token: 0x0603C72C RID: 247596 RVA: 0x011447A8 File Offset: 0x011429A8
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04020040 RID: 131136
		private const int CHESSMAN_SETLOCATION_PERFORMANCE_TIME = 1000;

		// Token: 0x04020041 RID: 131137
		private SceneItemJigsawItemComponent ItemComponent;

		// Token: 0x04020042 RID: 131138
		private SceneItemMoveComponent MoveComponent;

		// Token: 0x04020043 RID: 131139
		private SceneItemActorComponent ActorComponent;

		// Token: 0x04020044 RID: 131140
		private LevelTagComponent TagComponent;

		// Token: 0x04020045 RID: 131141
		private ChessmanComponent Config;

		// Token: 0x04020046 RID: 131142
		private Action SceneInteractionLoadCompletedCallback;

		// Token: 0x04020047 RID: 131143
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private Action<AActor, SceneItemJigsawItemComponent, JigsawIndex> OnPieceMoveEnd;

		// Token: 0x04020048 RID: 131144
		private JigsawIndex TargetJigsawIndex;

		// Token: 0x04020049 RID: 131145
		private Vector TargetLocation;

		// Token: 0x0402004A RID: 131146
		private TimerHandle SetLocationPerformanceTimerHandle;

		// Token: 0x0402004B RID: 131147
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<AActor> RefreshPickBoundsEvent;
	}
}
