using System;
using System.Runtime.CompilerServices;

// Token: 0x02001434 RID: 5172
[NullableContext(1)]
[Nullable(0)]
internal sealed class AiNoMoveData
{
	// Token: 0x0600CDD0 RID: 52688 RVA: 0x003D3F34 File Offset: 0x003D2134
	public AiNoMoveData(int entityId)
	{
		this.EntityId = entityId;
		this.LastMoveTime = (GameModeModel.Instance.IsMulti ? TimeUtil.Instance.GetServerTimeStamp() : Time.Instance.WorldTime);
	}

	// Token: 0x0600CDD1 RID: 52689 RVA: 0x003D3F8C File Offset: 0x003D218C
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

	// Token: 0x0600CDD2 RID: 52690 RVA: 0x003D4030 File Offset: 0x003D2230
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

	// Token: 0x0600CDD3 RID: 52691 RVA: 0x003D406B File Offset: 0x003D226B
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

	// Token: 0x0600CDD4 RID: 52692 RVA: 0x003D408E File Offset: 0x003D228E
	public void ResetTime()
	{
		this.LastMoveTime = this.GetWorldTime();
	}

	// Token: 0x0600CDD5 RID: 52693 RVA: 0x003D409C File Offset: 0x003D229C
	private double GetWorldTime()
	{
		if (!GameModeModel.Instance.IsMulti)
		{
			return Time.Instance.WorldTime;
		}
		return TimeUtil.Instance.GetServerTimeStamp();
	}

	// Token: 0x0600CDD6 RID: 52694 RVA: 0x003D40BF File Offset: 0x003D22BF
	public double GetNoMoveTime()
	{
		return this.GetWorldTime() - this.LastMoveTime;
	}

	// Token: 0x0400754D RID: 30029
	public int EntityId;

	// Token: 0x0400754E RID: 30030
	private Vector LastLocation = Vector.Create();

	// Token: 0x0400754F RID: 30031
	private Rotator LastRotation = Rotator.Create();

	// Token: 0x04007550 RID: 30032
	private double LastMoveTime;

	// Token: 0x04007551 RID: 30033
	private EAiNoMoveResetCondition ResetConditionMask;
}
