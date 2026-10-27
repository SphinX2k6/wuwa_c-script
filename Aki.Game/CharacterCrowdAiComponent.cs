using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02003055 RID: 12373
[NullableContext(2)]
[Nullable(0)]
public class CharacterCrowdAiComponent : BaseCrowdAiComponent
{
	// Token: 0x17002434 RID: 9268
	// (get) Token: 0x0601A4E4 RID: 107748 RVA: 0x006F795C File Offset: 0x006F5B5C
	protected new CharacterActorComponent ActorComp
	{
		get
		{
			return this.ActorComp as CharacterActorComponent;
		}
	}

	// Token: 0x0601A4E5 RID: 107749 RVA: 0x006F7969 File Offset: 0x006F5B69
	protected override bool OnStart()
	{
		base.OnStart();
		this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		return true;
	}

	// Token: 0x0601A4E6 RID: 107750 RVA: 0x006F79A6 File Offset: 0x006F5BA6
	protected override bool OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		return base.OnEnd();
	}

	// Token: 0x0601A4E7 RID: 107751 RVA: 0x006F79D0 File Offset: 0x006F5BD0
	protected override void OnTick(float delta)
	{
		this.UpdateRadius(delta * 0.001f);
	}

	// Token: 0x0601A4E8 RID: 107752 RVA: 0x006F79DF File Offset: 0x006F5BDF
	protected override void OnBoidComponentCreated()
	{
		base.OnBoidComponentCreated();
		this.InitFromRoleBoidParams(CrowdAiController.Instance.RoleParams);
	}

	// Token: 0x0601A4E9 RID: 107753 RVA: 0x006F79F7 File Offset: 0x006F5BF7
	protected void InitFromRoleBoidParams(RoleBoidParams @params)
	{
		if (@params == null)
		{
			return;
		}
		this.MaxRadius = @params.MaxRadius;
		this.MinRadius = @params.MinRadius;
		this.MaxRadiusChangeTime = @params.MaxRadiusChangeTime;
	}

	// Token: 0x0601A4EA RID: 107754 RVA: 0x006F7A24 File Offset: 0x006F5C24
	protected void UpdateRadius(float delta)
	{
		if (this.BoidComponent == null)
		{
			return;
		}
		MathUtils.Instance.CommonTempVector.DeepCopy(this.ActorComp.ActorLocationProxy);
		MathUtils.Instance.CommonTempVector.SubtractionEqual(this.ActorComp.LastActorLocation);
		GravityUtils.Instance.ConvertToPlanarVectorForActor(this.ActorComp, MathUtils.Instance.CommonTempVector);
		if (MathUtils.Instance.CommonTempVector.SizeSquared() > (double)(delta * delta * 400f))
		{
			this.CurRadius = this.MinRadius;
		}
		else
		{
			float num = (this.MaxRadius - this.MinRadius) / this.MaxRadiusChangeTime;
			this.CurRadius = Math.Min(this.CurRadius + delta * num, this.MaxRadius);
		}
		this.BoidComponent.Radius = this.CurRadius;
	}

	// Token: 0x0601A4EB RID: 107755 RVA: 0x006F7AF4 File Offset: 0x006F5CF4
	[NullableContext(1)]
	protected void OnChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
	{
		WorldEntity entity = newEntity.Entity;
		CharacterCrowdAiComponent characterCrowdAiComponent = (entity != null) ? entity.GetComponent<CharacterCrowdAiComponent>() : null;
		CharacterCrowdAiComponent characterCrowdAiComponent2;
		if (oldEntity == null)
		{
			characterCrowdAiComponent2 = null;
		}
		else
		{
			WorldEntity entity2 = oldEntity.Entity;
			characterCrowdAiComponent2 = ((entity2 != null) ? entity2.GetComponent<CharacterCrowdAiComponent>() : null);
		}
		CharacterCrowdAiComponent characterCrowdAiComponent3 = characterCrowdAiComponent2;
		if (characterCrowdAiComponent3 == null || characterCrowdAiComponent == null)
		{
			return;
		}
		characterCrowdAiComponent.CurRadius = characterCrowdAiComponent3.CurRadius;
		characterCrowdAiComponent.MinRadius = characterCrowdAiComponent3.MinRadius;
		characterCrowdAiComponent.MaxRadius = characterCrowdAiComponent3.MaxRadius;
		characterCrowdAiComponent.MaxRadiusChangeTime = characterCrowdAiComponent3.MaxRadiusChangeTime;
	}

	// Token: 0x0601A4EC RID: 107756 RVA: 0x006F7B64 File Offset: 0x006F5D64
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterCrowdAiComponent characterCrowdAiComponent = (CharacterCrowdAiComponent)componentTemplate;
		if (base.CanResetComponentProperty("CurRadius"))
		{
			this.CurRadius = characterCrowdAiComponent.CurRadius;
		}
		if (base.CanResetComponentProperty("MinRadius"))
		{
			this.MinRadius = characterCrowdAiComponent.MinRadius;
		}
		if (base.CanResetComponentProperty("MaxRadius"))
		{
			this.MaxRadius = characterCrowdAiComponent.MaxRadius;
		}
		if (base.CanResetComponentProperty("MaxRadiusChangeTime"))
		{
			this.MaxRadiusChangeTime = characterCrowdAiComponent.MaxRadiusChangeTime;
		}
		return true;
	}

	// Token: 0x0400C8A0 RID: 51360
	private const int STOP_MOVE_MAX_SPEED_SQUARED = 400;

	// Token: 0x0400C8A1 RID: 51361
	protected float CurRadius = 20f;

	// Token: 0x0400C8A2 RID: 51362
	protected float MinRadius = 20f;

	// Token: 0x0400C8A3 RID: 51363
	protected float MaxRadius = 80f;

	// Token: 0x0400C8A4 RID: 51364
	protected float MaxRadiusChangeTime = 1f;
}
