using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x0200321A RID: 12826
[NullableContext(1)]
[Nullable(0)]
internal class NpcWaitEntityTask
{
	// Token: 0x0601BA85 RID: 113285 RVA: 0x00799E7C File Offset: 0x0079807C
	public NpcWaitEntityTask(Entity npcEntity, int pbDataId)
	{
		this.NpcEntity = npcEntity;
		this.PbDataIdToWait = pbDataId;
	}

	// Token: 0x0601BA86 RID: 113286 RVA: 0x00799E94 File Offset: 0x00798094
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

	// Token: 0x0601BA87 RID: 113287 RVA: 0x00799EE4 File Offset: 0x007980E4
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

	// Token: 0x0601BA88 RID: 113288 RVA: 0x00799F40 File Offset: 0x00798140
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

	// Token: 0x0601BA89 RID: 113289 RVA: 0x00799FE0 File Offset: 0x007981E0
	protected void Finish()
	{
		this.Phase = ETaskPhase.Succeeded;
	}

	// Token: 0x0601BA8A RID: 113290 RVA: 0x00799FEC File Offset: 0x007981EC
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

	// Token: 0x0601BA8B RID: 113291 RVA: 0x0079A050 File Offset: 0x00798250
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

	// Token: 0x0601BA8C RID: 113292 RVA: 0x0079A098 File Offset: 0x00798298
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

	// Token: 0x0601BA8D RID: 113293 RVA: 0x0079A0D8 File Offset: 0x007982D8
	protected void OnSceneItemLoadComplete()
	{
		CreatureModel instance = CreatureModel.Instance;
		WorldEntity worldEntity = (instance != null) ? instance.GetEntityByPbDataId(this.PbDataIdToWait).Entity : null;
		EventSystem.Instance.RemoveWithTarget(worldEntity, EEventName.OnSceneInteractionLoadCompleted, new Action(this.OnSceneItemLoadComplete));
		this.Execute(worldEntity);
	}

	// Token: 0x0601BA8E RID: 113294 RVA: 0x0079A126 File Offset: 0x00798326
	protected void TryReset(Entity entity)
	{
		if (entity.GetComponent<CreatureDataComponent>() == null)
		{
			return;
		}
		this.Reset(entity);
	}

	// Token: 0x0601BA8F RID: 113295 RVA: 0x0079A138 File Offset: 0x00798338
	protected virtual void Reset(Entity entity)
	{
		SceneItemActorComponent component = entity.GetComponent<SceneItemActorComponent>();
		if (component != null)
		{
			component.GetIsSceneInteractionLoadCompleted();
		}
	}

	// Token: 0x0601BA90 RID: 113296 RVA: 0x0079A14D File Offset: 0x0079834D
	protected virtual void Execute(Entity entity)
	{
		this.Finish();
	}

	// Token: 0x0400D99C RID: 55708
	[Nullable(2)]
	public Entity NpcEntity;

	// Token: 0x0400D99D RID: 55709
	public int PbDataIdToWait;

	// Token: 0x0400D99E RID: 55710
	public EEntityType? EntityType;

	// Token: 0x0400D99F RID: 55711
	[Nullable(2)]
	public WaitEntityTask WaitEntityTaskHandle;

	// Token: 0x0400D9A0 RID: 55712
	public ETaskPhase Phase;
}
