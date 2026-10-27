using System;
using System.Runtime.CompilerServices;

// Token: 0x02001F72 RID: 8050
[NullableContext(1)]
[Nullable(0)]
internal sealed class AiNoMoveData
{
	// Token: 0x0600F9B1 RID: 63921 RVA: 0x003C8448 File Offset: 0x003C6648
	public AiNoMoveData(int entityId)
	{
		this.EntityId = entityId;
		this.LastMoveTime = (GameModeModel.Instance.IsMulti ? TimeUtil.Instance.GetServerTimeStamp() : Time.Instance.WorldTime);
	}

	// Token: 0x0600F9B2 RID: 63922 RVA: 0x003C84A0 File Offset: 0x003C66A0
	public bool Tick()
	{
		Entity entity = EntitySystem.Instance.Get(this.EntityId);
		BaseActorComponent baseActorComponent = (entity != null) ? entity.GetComponent<BaseActorComponent>() : null;
		if (baseActorComponent == null || !baseActorComponent.Valid)
		{
			return false;
		}
		if (this.ShouldResetNoMoveTime(entity) || !baseActorComponent.ActorLocationProxy.Equals(this.LastLocation, 9.999999747378752E-05) || !baseActorComponent.ActorRotationProxy.Equals(this.LastRotation, 0.0001f))
		{
			this.LastMoveTime = this.GetWorldTime();
		}
		this.LastLocation.DeepCopy(baseActorComponent.ActorLocationProxy);
		this.LastRotation.DeepCopy(baseActorComponent.ActorRotationProxy);
		return true;
	}

	// Token: 0x0600F9B3 RID: 63923 RVA: 0x003C8544 File Offset: 0x003C6744
	public void UpdateResetConditionMask(EAiNoMoveResetCondition resetConditionMask)
	{
		this.ResetConditionMask = resetConditionMask;
		if (resetConditionMask == EAiNoMoveResetCondition.None)
		{
			return;
		}
		Entity entity = EntitySystem.Instance.Get(this.EntityId);
		if (entity != null && this.ShouldResetNoMoveTime(entity))
		{
			this.ResetTime();
		}
	}

	// Token: 0x0600F9B4 RID: 63924 RVA: 0x003C857F File Offset: 0x003C677F
	private bool ShouldResetNoMoveTime(Entity entity)
	{
		if ((this.ResetConditionMask & EAiNoMoveResetCondition.SitOnChairTask) != EAiNoMoveResetCondition.None)
		{
			NpcSitOnChairComponent component = entity.GetComponent<NpcSitOnChairComponent>();
			if (component != null && component.IsSitOnChairTaskRunning)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600F9B5 RID: 63925 RVA: 0x003C85A2 File Offset: 0x003C67A2
	public void ResetTime()
	{
		this.LastMoveTime = this.GetWorldTime();
	}

	// Token: 0x0600F9B6 RID: 63926 RVA: 0x003C85B0 File Offset: 0x003C67B0
	private double GetWorldTime()
	{
		if (!GameModeModel.Instance.IsMulti)
		{
			return Time.Instance.WorldTime;
		}
		return TimeUtil.Instance.GetServerTimeStamp();
	}

	// Token: 0x0600F9B7 RID: 63927 RVA: 0x003C85D3 File Offset: 0x003C67D3
	public double GetNoMoveTime()
	{
		return this.GetWorldTime() - this.LastMoveTime;
	}

	// Token: 0x0400746C RID: 29804
	public int EntityId;

	// Token: 0x0400746D RID: 29805
	private Vector LastLocation = Vector.Create();

	// Token: 0x0400746E RID: 29806
	private Rotator LastRotation = Rotator.Create();

	// Token: 0x0400746F RID: 29807
	private double LastMoveTime;

	// Token: 0x04007470 RID: 29808
	private EAiNoMoveResetCondition ResetConditionMask;
}
