using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200278A RID: 10122
[NullableContext(1)]
[Nullable(0)]
internal class NpcIgnoreCollisionTask : NpcWaitEntityTask
{
	// Token: 0x06019616 RID: 103958 RVA: 0x007C28F1 File Offset: 0x007C0AF1
	public NpcIgnoreCollisionTask(Entity npcEntity, int pbDataId) : base(npcEntity, pbDataId)
	{
	}

	// Token: 0x06019617 RID: 103959 RVA: 0x007C28FB File Offset: 0x007C0AFB
	protected override void Reset(Entity entity)
	{
		SceneItemActorComponent component = entity.GetComponent<SceneItemActorComponent>();
		if (component == null || !component.GetIsSceneInteractionLoadCompleted())
		{
			return;
		}
		this.IgnoreSceneItemCollision(entity, false);
	}

	// Token: 0x06019618 RID: 103960 RVA: 0x007C291D File Offset: 0x007C0B1D
	protected override void Execute(Entity entity)
	{
		this.IgnoreSceneItemCollision(entity, true);
		base.Finish();
	}

	// Token: 0x06019619 RID: 103961 RVA: 0x007C2930 File Offset: 0x007C0B30
	private void IgnoreSceneItemCollision(Entity entity, bool shouldIgnore)
	{
		SceneItemActorComponent component = entity.GetComponent<SceneItemActorComponent>();
		Entity npcEntity = this.NpcEntity;
		BaseCharacterComponent baseCharacterComponent = (npcEntity != null) ? npcEntity.GetComponent<BaseCharacterComponent>() : null;
		if (component == null || baseCharacterComponent == null)
		{
			this.Phase = ETaskPhase.Failed;
			return;
		}
		AActor interactCollisionActor = component.GetInteractCollisionActor();
		if (interactCollisionActor == null || !interactCollisionActor.IsValid())
		{
			this.Phase = ETaskPhase.Failed;
			return;
		}
		baseCharacterComponent.Actor.IgnoreActorWhenMoving(interactCollisionActor, shouldIgnore, true);
	}
}
