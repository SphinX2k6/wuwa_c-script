using System;
using System.Runtime.CompilerServices;

// Token: 0x020026E6 RID: 9958
[NullableContext(1)]
[Nullable(0)]
public class CodeSkill_Execute_Xunren : CodeSkillBase
{
	// Token: 0x06018ED2 RID: 102098 RVA: 0x0079588B File Offset: 0x00793A8B
	public CodeSkill_Execute_Xunren(SpecialSkillBase specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x06018ED3 RID: 102099 RVA: 0x00795894 File Offset: 0x00793A94
	public override void OnBegin(Skill skill)
	{
		this.ClearForceSpeed();
		this.TryAddMultiplayerTimeStopBuff();
		this.PlayExecuteMontage(skill);
	}

	// Token: 0x06018ED4 RID: 102100 RVA: 0x007958A9 File Offset: 0x00793AA9
	private void ClearForceSpeed()
	{
		CharacterMoveComponent component = base.Entity.GetComponent<CharacterMoveComponent>();
		if (component == null)
		{
			return;
		}
		component.SetForceSpeed(Vector.ZeroVectorProxy);
	}

	// Token: 0x06018ED5 RID: 102101 RVA: 0x007958C8 File Offset: 0x00793AC8
	private void TryAddMultiplayerTimeStopBuff()
	{
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		if (component == null || !component.HasTag(GameplayTagDefine.EGameplayTagId["功能.逻辑状态标识.战斗逻辑.多人联机"]))
		{
			return;
		}
		EntityHandle skillTarget = base.SkillComp.SkillTarget;
		WorldEntity worldEntity = (skillTarget != null) ? skillTarget.Entity : null;
		BaseBuffComponent baseBuffComponent = (worldEntity != null) ? worldEntity.GetComponent<BaseBuffComponent>() : null;
		if (baseBuffComponent == null)
		{
			return;
		}
		baseBuffComponent.AddBuff(1101013023L, new AddBuffParam
		{
			InstigatorId = baseBuffComponent.CreatureDataId,
			OuterStackCount = new int?(1),
			Reason = "CodeSkill_Execute_Xunren.AddMultiplayerTimeStopBuff"
		});
	}

	// Token: 0x06018ED6 RID: 102102 RVA: 0x00795960 File Offset: 0x00793B60
	private void PlayExecuteMontage(Skill skill)
	{
		if (!base.SkillComp.PlaySkillMontage(0, "", 0f, delegate(bool isInterrupted)
		{
			this.EndSelf(skill);
		}, delegate(bool isInterrupted)
		{
			this.EndSelf(skill);
		}))
		{
			base.EndSelf(skill);
		}
	}

	// Token: 0x0400D8E4 RID: 55524
	private const int EXECUTE_MONTAGE_INDEX = 0;

	// Token: 0x0400D8E5 RID: 55525
	private const long MULTIPLAYER_TIME_STOP_BUFF_ID = 1101013023L;
}
