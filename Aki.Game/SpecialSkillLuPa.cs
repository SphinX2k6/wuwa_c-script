using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

// Token: 0x02002704 RID: 9988
[NullableContext(1)]
[Nullable(0)]
public class SpecialSkillLuPa : SpecialSkillAimingBase
{
	// Token: 0x170027BA RID: 10170
	// (get) Token: 0x06019075 RID: 102517 RVA: 0x0079F160 File Offset: 0x0079D360
	protected override int AimingTagId
	{
		get
		{
			return GameplayTagDefine.EGameplayTagId["角色.Common.瞄准镜头.露帕瞄准"];
		}
	}

	// Token: 0x170027BB RID: 10171
	// (get) Token: 0x06019076 RID: 102518 RVA: 0x0079F171 File Offset: 0x0079D371
	protected override EEventName SwitchLockTargetEventName
	{
		get
		{
			return EEventName.SpecialSkillLuPaSwitchLockTarget;
		}
	}

	// Token: 0x06019077 RID: 102519 RVA: 0x0079F175 File Offset: 0x0079D375
	public SpecialSkillLuPa(CharacterSpecialSkillComponent specialSkillComponent) : base(specialSkillComponent)
	{
	}

	// Token: 0x06019078 RID: 102520 RVA: 0x0079F18C File Offset: 0x0079D38C
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

	// Token: 0x06019079 RID: 102521 RVA: 0x0079F228 File Offset: 0x0079D428
	protected override void LockOn()
	{
		base.LockOnCircle(this.Distance, this.Radius);
	}

	// Token: 0x0601907A RID: 102522 RVA: 0x0079F23C File Offset: 0x0079D43C
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

	// Token: 0x0601907B RID: 102523 RVA: 0x0079F2AC File Offset: 0x0079D4AC
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

	// Token: 0x0400DA4A RID: 55882
	private const int SpecialSkillId = 1207601;

	// Token: 0x0400DA4B RID: 55883
	private readonly int Radius = 500;

	// Token: 0x0400DA4C RID: 55884
	[Nullable(2)]
	private CharacterSkillComponent SkillComp;

	// Token: 0x0400DA4D RID: 55885
	[Nullable(2)]
	private CreatureDataComponent CreatureDataComp;

	// Token: 0x0400DA4E RID: 55886
	[Nullable(2)]
	private Skill SpecialSkill;

	// Token: 0x0400DA4F RID: 55887
	private long LockOnBuffId;
}
