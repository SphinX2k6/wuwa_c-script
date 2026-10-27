using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

// Token: 0x02003196 RID: 12694
[NullableContext(1)]
[Nullable(0)]
public class SpecialSkillLuPa : SpecialSkillAimingBase
{
	// Token: 0x170025C9 RID: 9673
	// (get) Token: 0x0601B555 RID: 111957 RVA: 0x00776ED4 File Offset: 0x007750D4
	protected override int AimingTagId
	{
		get
		{
			return GameplayTagDefine.EGameplayTagId["角色.Common.瞄准镜头.露帕瞄准"];
		}
	}

	// Token: 0x170025CA RID: 9674
	// (get) Token: 0x0601B556 RID: 111958 RVA: 0x00776EE5 File Offset: 0x007750E5
	protected override EEventName SwitchLockTargetEventName
	{
		get
		{
			return EEventName.SpecialSkillLuPaSwitchLockTarget;
		}
	}

	// Token: 0x0601B557 RID: 111959 RVA: 0x00776EE9 File Offset: 0x007750E9
	public SpecialSkillLuPa(CharacterSpecialSkillComponent specialSkillComponent) : base(specialSkillComponent)
	{
	}

	// Token: 0x0601B558 RID: 111960 RVA: 0x00776F00 File Offset: 0x00775100
	public override void OnStart()
	{
		this.SkillComp = this.SpecialSkillComponent.Entity.GetComponent<CharacterSkillComponent>();
		this.CreatureDataComp = this.SpecialSkillComponent.Entity.GetComponent<CreatureDataComponent>();
		CharacterSkillComponent skillComp = this.SkillComp;
		this.SpecialSkill = ((skillComp != null) ? skillComp.GetSkill(1207601) : null);
		if (this.LockOnBuffId == 0L)
		{
			Skill specialSkill = this.SpecialSkill;
			TArray<long> tarray;
			if (specialSkill == null)
			{
				tarray = null;
			}
			else
			{
				SSkillInfo skillInfo = specialSkill.SkillInfo;
				tarray = ((skillInfo != null) ? skillInfo.SpecialBuffInCode : null);
			}
			TArray<long> tarray2 = tarray;
			if (tarray2 != null && tarray2.Num() > 0)
			{
				this.LockOnBuffId = tarray2.Get(0);
			}
		}
		base.OnStart();
	}

	// Token: 0x0601B559 RID: 111961 RVA: 0x00776F9C File Offset: 0x0077519C
	protected override void LockOn()
	{
		base.LockOnCircle(this.Distance, this.Radius);
	}

	// Token: 0x0601B55A RID: 111962 RVA: 0x00776FB0 File Offset: 0x007751B0
	protected override void DoOnTargetLocked(EntityHandle target, string socketName)
	{
		WorldEntity entity = target.Entity;
		CharacterBuffComponent characterBuffComponent = (entity != null) ? entity.GetComponent<CharacterBuffComponent>() : null;
		if (characterBuffComponent == null)
		{
			return;
		}
		long lockOnBuffId = this.LockOnBuffId;
		AddBuffParam addBuffParam = new AddBuffParam();
		addBuffParam.InstigatorId = this.CreatureDataComp.GetCreatureDataId();
		addBuffParam.Reason = "露帕特殊技能瞄准目标加Buff";
		Skill specialSkill = this.SpecialSkill;
		addBuffParam.PreMessageId = ((specialSkill != null) ? specialSkill.CombatMessageId : null);
		characterBuffComponent.AddBuff(lockOnBuffId, addBuffParam);
	}

	// Token: 0x0601B55B RID: 111963 RVA: 0x00777020 File Offset: 0x00775220
	protected override void DoOnTargetUnlocked(EntityHandle target, string socketName)
	{
		if (target.Valid)
		{
			WorldEntity entity = target.Entity;
			CharacterBuffComponent characterBuffComponent = (entity != null) ? entity.GetComponent<CharacterBuffComponent>() : null;
			if (characterBuffComponent == null)
			{
				return;
			}
			long lockOnBuffId = this.LockOnBuffId;
			int stackCount = -1;
			string reason = "露帕特殊技能瞄准目标移除Buff";
			Skill specialSkill = this.SpecialSkill;
			characterBuffComponent.RemoveBuff(lockOnBuffId, stackCount, reason, (specialSkill != null) ? specialSkill.CombatMessageId : null, null, null);
		}
	}

	// Token: 0x0400D5C7 RID: 54727
	private const int SpecialSkillId = 1207601;

	// Token: 0x0400D5C8 RID: 54728
	private readonly int Radius = 500;

	// Token: 0x0400D5C9 RID: 54729
	[Nullable(2)]
	private CharacterSkillComponent SkillComp;

	// Token: 0x0400D5CA RID: 54730
	[Nullable(2)]
	private CreatureDataComponent CreatureDataComp;

	// Token: 0x0400D5CB RID: 54731
	[Nullable(2)]
	private Skill SpecialSkill;

	// Token: 0x0400D5CC RID: 54732
	private long LockOnBuffId;
}
