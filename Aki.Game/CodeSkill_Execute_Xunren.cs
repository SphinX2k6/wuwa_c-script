using System;
using System.Runtime.CompilerServices;

// Token: 0x02003179 RID: 12665
[NullableContext(1)]
[Nullable(0)]
public class CodeSkill_Execute_Xunren : CodeSkillBase
{
	// Token: 0x0601B3CD RID: 111565 RVA: 0x0076DF27 File Offset: 0x0076C127
	public CodeSkill_Execute_Xunren(SpecialSkillBase specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x0601B3CE RID: 111566 RVA: 0x0076DF30 File Offset: 0x0076C130
	public override void OnBegin(Skill skill)
	{
		this.ClearForceSpeed();
		this.TryAddMultiplayerTimeStopBuff();
		this.PlayExecuteMontage(skill);
	}

	// Token: 0x0601B3CF RID: 111567 RVA: 0x0076DF45 File Offset: 0x0076C145
	private void ClearForceSpeed()
	{
		CharacterMoveComponent component = base.Entity.GetComponent<CharacterMoveComponent>();
		if (component == null)
		{
			return;
		}
		component.SetForceSpeed(Vector.ZeroVectorProxy);
	}

	// Token: 0x0601B3D0 RID: 111568 RVA: 0x0076DF64 File Offset: 0x0076C164
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

	// Token: 0x0601B3D1 RID: 111569 RVA: 0x0076DFFC File Offset: 0x0076C1FC
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

	// Token: 0x0400D481 RID: 54401
	private const int EXECUTE_MONTAGE_INDEX = 0;

	// Token: 0x0400D482 RID: 54402
	private const long MULTIPLAYER_TIME_STOP_BUFF_ID = 1101013023L;
}
