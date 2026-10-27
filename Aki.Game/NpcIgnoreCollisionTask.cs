using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200321B RID: 12827
[NullableContext(1)]
[Nullable(0)]
internal class NpcIgnoreCollisionTask : NpcWaitEntityTask
{
	// Token: 0x0601BA91 RID: 113297 RVA: 0x0079A155 File Offset: 0x00798355
	public NpcIgnoreCollisionTask(Entity npcEntity, int pbDataId) : base(npcEntity, pbDataId)
	{
	}

	// Token: 0x0601BA92 RID: 113298 RVA: 0x0079A15F File Offset: 0x0079835F
	protected override void Reset(Entity entity)
	{
		SceneItemActorComponent component = entity.GetComponent<SceneItemActorComponent>();
		if (component == null || !component.GetIsSceneInteractionLoadCompleted())
		{
			return;
		}
		this.IgnoreSceneItemCollision(entity, false);
	}

	// Token: 0x0601BA93 RID: 113299 RVA: 0x0079A181 File Offset: 0x00798381
	protected override void Execute(Entity entity)
	{
		this.IgnoreSceneItemCollision(entity, true);
		base.Finish();
	}

	// Token: 0x0601BA94 RID: 113300 RVA: 0x0079A194 File Offset: 0x00798394
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
