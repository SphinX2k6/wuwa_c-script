using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x020025AB RID: 9643
[NullableContext(2)]
[Nullable(0)]
public class CharacterCrowdAiComponent : BaseCrowdAiComponent
{
	// Token: 0x1700254E RID: 9550
	// (get) Token: 0x06017E7F RID: 97919 RVA: 0x0071EAC9 File Offset: 0x0071CCC9
	protected new CharacterActorComponent ActorComp
	{
		get
		{
			return this.ActorComp as CharacterActorComponent;
		}
	}

	// Token: 0x06017E80 RID: 97920 RVA: 0x0071EAD6 File Offset: 0x0071CCD6
	protected override bool OnStart()
	{
		base.OnStart();
		this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		return true;
	}

	// Token: 0x06017E81 RID: 97921 RVA: 0x0071EB13 File Offset: 0x0071CD13
	protected override bool OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		return base.OnEnd();
	}

	// Token: 0x06017E82 RID: 97922 RVA: 0x0071EB3D File Offset: 0x0071CD3D
	protected override void OnTick(float delta)
	{
		this.UpdateRadius(delta * 0.001f);
	}

	// Token: 0x06017E83 RID: 97923 RVA: 0x0071EB4C File Offset: 0x0071CD4C
	protected override void OnBoidComponentCreated()
	{
		base.OnBoidComponentCreated();
		this.InitFromRoleBoidParams(CrowdAiController.Instance.RoleParams);
	}

	// Token: 0x06017E84 RID: 97924 RVA: 0x0071EB64 File Offset: 0x0071CD64
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

	// Token: 0x06017E85 RID: 97925 RVA: 0x0071EB90 File Offset: 0x0071CD90
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

	// Token: 0x06017E86 RID: 97926 RVA: 0x0071EC60 File Offset: 0x0071CE60
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

	// Token: 0x06017E87 RID: 97927 RVA: 0x0071ECD0 File Offset: 0x0071CED0
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterCrowdAiComponent characterCrowdAiComponent = (CharacterCrowdAiComponent)componentTemplate;
		this.CurRadius = characterCrowdAiComponent.CurRadius;
		this.MinRadius = characterCrowdAiComponent.MinRadius;
		this.MaxRadius = characterCrowdAiComponent.MaxRadius;
		this.MaxRadiusChangeTime = characterCrowdAiComponent.MaxRadiusChangeTime;
		return true;
	}

	// Token: 0x1700254F RID: 9551
	// (get) Token: 0x06017E88 RID: 97928 RVA: 0x0071ED20 File Offset: 0x0071CF20
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002550 RID: 9552
	// (get) Token: 0x06017E89 RID: 97929 RVA: 0x0071ED23 File Offset: 0x0071CF23
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002551 RID: 9553
	// (get) Token: 0x06017E8A RID: 97930 RVA: 0x0071ED26 File Offset: 0x0071CF26
	public override bool NeedEnableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002552 RID: 9554
	// (get) Token: 0x06017E8B RID: 97931 RVA: 0x0071ED29 File Offset: 0x0071CF29
	public override bool NeedDisableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002553 RID: 9555
	// (get) Token: 0x06017E8C RID: 97932 RVA: 0x0071ED2C File Offset: 0x0071CF2C
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400CC7A RID: 52346
	private const int STOP_MOVE_MAX_SPEED_SQUARED = 400;

	// Token: 0x0400CC7B RID: 52347
	protected float CurRadius = 20f;

	// Token: 0x0400CC7C RID: 52348
	protected float MinRadius = 20f;

	// Token: 0x0400CC7D RID: 52349
	protected float MaxRadius = 80f;

	// Token: 0x0400CC7E RID: 52350
	protected float MaxRadiusChangeTime = 1f;
}
