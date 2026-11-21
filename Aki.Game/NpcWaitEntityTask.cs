using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02002789 RID: 10121
[NullableContext(1)]
[Nullable(0)]
internal class NpcWaitEntityTask
{
	// Token: 0x0601960A RID: 103946 RVA: 0x007C2618 File Offset: 0x007C0818
	public NpcWaitEntityTask(Entity npcEntity, int pbDataId)
	{
		this.NpcEntity = npcEntity;
		this.PbDataIdToWait = pbDataId;
	}

	// Token: 0x0601960B RID: 103947 RVA: 0x007C2630 File Offset: 0x007C0830
	public void Start()
	{
		if (this.Phase != ETaskPhase.None)
		{
			return;
		}
		if (this.WaitEntityTaskHandle != null)
		{
			return;
		}
		this.Phase = ETaskPhase.InProgress;
		this.WaitEntityTaskHandle = WaitEntityTask.CreateWithPbDataId("NpcWaitEntityTask.Start", this.PbDataIdToWait, new Action<bool?>(this.OnEntityAdd), 30000, false, true);
	}

	// Token: 0x0601960C RID: 103948 RVA: 0x007C2680 File Offset: 0x007C0880
	public void Stop()
	{
		if (this.Phase != ETaskPhase.Succeeded)
		{
			if (this.Phase == ETaskPhase.InProgress)
			{
				this.Cancel();
			}
			return;
		}
		CreatureModel instance = CreatureModel.Instance;
		EntityHandle entityHandle = (instance != null) ? instance.GetEntityByPbDataId(this.PbDataIdToWait) : null;
		if (entityHandle == null || !entityHandle.Valid)
		{
			return;
		}
		this.TryReset(entityHandle.Entity);
	}

	// Token: 0x0601960D RID: 103949 RVA: 0x007C26DC File Offset: 0x007C08DC
	public void Cancel()
	{
		if (this.WaitEntityTaskHandle != null)
		{
			this.WaitEntityTaskHandle.Cancel();
			return;
		}
		CreatureModel instance = CreatureModel.Instance;
		WorldEntity worldEntity;
		if (instance == null)
		{
			worldEntity = null;
		}
		else
		{
			EntityHandle entityByPbDataId = instance.GetEntityByPbDataId(this.PbDataIdToWait);
			worldEntity = ((entityByPbDataId != null) ? entityByPbDataId.Entity : null);
		}
		WorldEntity worldEntity2 = worldEntity;
		if (worldEntity2 == null || !worldEntity2.Valid)
		{
			return;
		}
		if (worldEntity2.GetComponent<CreatureDataComponent>().GetEntityType() == EEntityType.SceneItem && EventSystem.Instance.HasWithTarget(worldEntity2, EEventName.OnSceneInteractionLoadCompleted, new Action(this.OnSceneItemLoadComplete)))
		{
			EventSystem.Instance.RemoveWithTarget(worldEntity2, EEventName.OnSceneInteractionLoadCompleted, new Action(this.OnSceneItemLoadComplete));
		}
	}

	// Token: 0x0601960E RID: 103950 RVA: 0x007C277C File Offset: 0x007C097C
	protected void Finish()
	{
		this.Phase = ETaskPhase.Succeeded;
	}

	// Token: 0x0601960F RID: 103951 RVA: 0x007C2788 File Offset: 0x007C0988
	protected void OnEntityAdd(bool? result)
	{
		this.WaitEntityTaskHandle = null;
		if (!result.GetValueOrDefault())
		{
			this.Phase = ETaskPhase.Failed;
			return;
		}
		CreatureModel instance = CreatureModel.Instance;
		EntityHandle entityHandle = (instance != null) ? instance.GetEntityByPbDataId(this.PbDataIdToWait) : null;
		if (entityHandle == null || !entityHandle.Valid)
		{
			this.Phase = ETaskPhase.Failed;
			return;
		}
		this.TryExecute(entityHandle.Entity);
	}

	// Token: 0x06019610 RID: 103952 RVA: 0x007C27EC File Offset: 0x007C09EC
	protected void TryExecute(Entity entity)
	{
		CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
		if (component == null)
		{
			this.Phase = ETaskPhase.Failed;
			return;
		}
		EEntityType entityType = component.GetEntityType();
		if (entityType == EEntityType.SceneItem)
		{
			this.TryExecuteWithSceneItemActor(entity);
			return;
		}
		if (entityType != EEntityType.Vehicle)
		{
			this.Phase = ETaskPhase.Failed;
			return;
		}
		this.Execute(entity);
	}

	// Token: 0x06019611 RID: 103953 RVA: 0x007C2834 File Offset: 0x007C0A34
	protected void TryExecuteWithSceneItemActor(Entity entity)
	{
		SceneItemActorComponent component = entity.GetComponent<SceneItemActorComponent>();
		if (component == null || !component.GetIsSceneInteractionLoadCompleted())
		{
			EventSystem.Instance.AddWithTarget(entity, EEventName.OnSceneInteractionLoadCompleted, new Action(this.OnSceneItemLoadComplete));
			return;
		}
		this.Execute(entity);
	}

	// Token: 0x06019612 RID: 103954 RVA: 0x007C2874 File Offset: 0x007C0A74
	protected void OnSceneItemLoadComplete()
	{
		CreatureModel instance = CreatureModel.Instance;
		WorldEntity worldEntity = (instance != null) ? instance.GetEntityByPbDataId(this.PbDataIdToWait).Entity : null;
		EventSystem.Instance.RemoveWithTarget(worldEntity, EEventName.OnSceneInteractionLoadCompleted, new Action(this.OnSceneItemLoadComplete));
		this.Execute(worldEntity);
	}

	// Token: 0x06019613 RID: 103955 RVA: 0x007C28C2 File Offset: 0x007C0AC2
	protected void TryReset(Entity entity)
	{
		if (entity.GetComponent<CreatureDataComponent>() == null)
		{
			return;
		}
		this.Reset(entity);
	}

	// Token: 0x06019614 RID: 103956 RVA: 0x007C28D4 File Offset: 0x007C0AD4
	protected virtual void Reset(Entity entity)
	{
		SceneItemActorComponent component = entity.GetComponent<SceneItemActorComponent>();
		if (component != null)
		{
			component.GetIsSceneInteractionLoadCompleted();
		}
	}

	// Token: 0x06019615 RID: 103957 RVA: 0x007C28E9 File Offset: 0x007C0AE9
	protected virtual void Execute(Entity entity)
	{
		this.Finish();
	}

	// Token: 0x0400DE3B RID: 56891
	[Nullable(2)]
	public Entity NpcEntity;

	// Token: 0x0400DE3C RID: 56892
	public int PbDataIdToWait;

	// Token: 0x0400DE3D RID: 56893
	public EEntityType? EntityType;

	// Token: 0x0400DE3E RID: 56894
	[Nullable(2)]
	public WaitEntityTask WaitEntityTaskHandle;

	// Token: 0x0400DE3F RID: 56895
	public ETaskPhase Phase;
}
