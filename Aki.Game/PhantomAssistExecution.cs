using System;
using System.Runtime.CompilerServices;
using Aki.Protocol.Summon;

// Token: 0x02002F90 RID: 12176
[NullableContext(1)]
[Nullable(0)]
public class PhantomAssistExecution : InitExecution
{
	// Token: 0x06019D9B RID: 105883 RVA: 0x006BF8F8 File Offset: 0x006BDAF8
	public PhantomAssistExecution(RequireAndLimits requireAndLimits) : base(requireAndLimits)
	{
	}

	// Token: 0x06019D9C RID: 105884 RVA: 0x006BF908 File Offset: 0x006BDB08
	protected override bool CheckExecutable()
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		return ownerBuffComponent != null && ownerBuffComponent.HasBuffAuthority();
	}

	// Token: 0x06019D9D RID: 105885 RVA: 0x006BF91C File Offset: 0x006BDB1C
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		this.SummonType = (ESummonType)((extraEffectParameters_ != null && extraEffectParameters_.Length != 0) ? int.Parse(extraEffectParameters_[0]) : 0);
		this.FollowIndex = ((extraEffectParameters_ != null && extraEffectParameters_.Length > 1) ? int.Parse(extraEffectParameters_[1]) : 0);
		this.SkillId = ((extraEffectParameters_ != null && extraEffectParameters_.Length > 2) ? int.Parse(extraEffectParameters_[2]) : 0);
		this.SkillTargetType = (ESkillTargetType)((extraEffectParameters_ != null && extraEffectParameters_.Length > 3) ? int.Parse(extraEffectParameters_[3]) : 2);
	}

	// Token: 0x06019D9E RID: 105886 RVA: 0x006BF998 File Offset: 0x006BDB98
	[return: Nullable(2)]
	public override object OnExecute(params object[] args)
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		Entity entity = (ownerBuffComponent != null) ? ownerBuffComponent.GetEntity() : null;
		EntityHandle entityHandle = (entity != null) ? PhantomUtil.GetSummonedEntity(entity, this.SummonType, this.FollowIndex) : null;
		if (((entityHandle != null) ? entityHandle.Entity : null) == null)
		{
			return null;
		}
		CharacterSkillComponent component = entityHandle.Entity.GetComponent<CharacterSkillComponent>();
		if (component == null)
		{
			return null;
		}
		BaseSkillComponent baseSkillComponent = component;
		int skillId = this.SkillId;
		SkillParam skillParam = new SkillParam();
		EntityHandle skillTarget = this.GetSkillTarget();
		skillParam.Target = ((skillTarget != null) ? skillTarget.Entity : null);
		skillParam.Reason = "PhantomAssistExecution.OnExecute";
		baseSkillComponent.BeginSkillAsync(skillId, skillParam);
		return null;
	}

	// Token: 0x06019D9F RID: 105887 RVA: 0x006BFA28 File Offset: 0x006BDC28
	[NullableContext(2)]
	private EntityHandle GetSkillTarget()
	{
		EntityHandle result = null;
		switch (this.SkillTargetType)
		{
		case ESkillTargetType.SkillTarget:
		{
			IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
			EntityHandle entityHandle;
			if (ownerBuffComponent == null)
			{
				entityHandle = null;
			}
			else
			{
				BaseSkillComponent skillComponent = ownerBuffComponent.GetSkillComponent();
				entityHandle = ((skillComponent != null) ? skillComponent.SkillTarget : null);
			}
			result = entityHandle;
			break;
		}
		case ESkillTargetType.LockOnTarget:
		{
			IBuffComponent ownerBuffComponent2 = this.OwnerBuffComponent;
			EntityHandle entityHandle2;
			if (ownerBuffComponent2 == null)
			{
				entityHandle2 = null;
			}
			else
			{
				Entity entity = ownerBuffComponent2.GetEntity();
				if (entity == null)
				{
					entityHandle2 = null;
				}
				else
				{
					CharacterLockOnComponent component = entity.GetComponent<CharacterLockOnComponent>();
					entityHandle2 = ((component != null) ? component.GetCurrentTarget() : null);
				}
			}
			result = entityHandle2;
			break;
		}
		case ESkillTargetType.Owner:
		{
			CharacterModel instance = CharacterModel.Instance;
			IBuffComponent ownerBuffComponent3 = this.OwnerBuffComponent;
			result = instance.GetHandleByEntity((ownerBuffComponent3 != null) ? ownerBuffComponent3.GetEntity() : null);
			break;
		}
		}
		return result;
	}

	// Token: 0x0400C347 RID: 49991
	private ESummonType SummonType;

	// Token: 0x0400C348 RID: 49992
	private int FollowIndex;

	// Token: 0x0400C349 RID: 49993
	private int SkillId;

	// Token: 0x0400C34A RID: 49994
	private ESkillTargetType SkillTargetType = ESkillTargetType.Owner;
}
