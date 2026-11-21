using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow;
using CSharpScript.Utils;

// Token: 0x02002536 RID: 9526
[NullableContext(1)]
[Nullable(0)]
public class HitTrigger : Trigger
{
	// Token: 0x060178E8 RID: 96488 RVA: 0x006F46A1 File Offset: 0x006F28A1
	[NullableContext(2)]
	public HitTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x060178E9 RID: 96489 RVA: 0x006F46B2 File Offset: 0x006F28B2
	public override void OnInitParams(string[] triggerParams)
	{
		this.TargetType = (ETriggerTargetType)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : "0");
	}

	// Token: 0x060178EA RID: 96490 RVA: 0x006F46D0 File Offset: 0x006F28D0
	protected override void OnActive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null)
		{
			if (!TriggerEventHelper.HasWithTarget(target, EEventName.CharHitLocal, new Action<HitInformation, HitContext>(this.OnHitLocal)))
			{
				TriggerEventHelper.AddWithTarget(target, EEventName.CharHitLocal, new Action<HitInformation, HitContext>(this.OnHitLocal));
			}
			if (!TriggerEventHelper.HasWithTarget(target, EEventName.CharHitRemote, new Action<HitContext>(this.OnHitRemote)))
			{
				TriggerEventHelper.AddWithTarget(target, EEventName.CharHitRemote, new Action<HitContext>(this.OnHitRemote));
			}
		}
	}

	// Token: 0x060178EB RID: 96491 RVA: 0x006F4754 File Offset: 0x006F2954
	protected override void OnInactive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null)
		{
			if (TriggerEventHelper.HasWithTarget(target, EEventName.CharHitLocal, new Action<HitInformation, HitContext>(this.OnHitLocal)))
			{
				TriggerEventHelper.RemoveWithTarget(target, EEventName.CharHitLocal, new Action<HitInformation, HitContext>(this.OnHitLocal));
			}
			if (TriggerEventHelper.HasWithTarget(target, EEventName.CharHitRemote, new Action<HitContext>(this.OnHitRemote)))
			{
				TriggerEventHelper.RemoveWithTarget(target, EEventName.CharHitRemote, new Action<HitContext>(this.OnHitRemote));
			}
		}
	}

	// Token: 0x060178EC RID: 96492 RVA: 0x006F47D6 File Offset: 0x006F29D6
	protected void OnHitLocal(HitInformation _, HitContext hitContext)
	{
		this.OnEvent(hitContext);
	}

	// Token: 0x060178ED RID: 96493 RVA: 0x006F47DF File Offset: 0x006F29DF
	protected void OnHitRemote(HitContext hitContext)
	{
		this.OnEvent(hitContext);
	}

	// Token: 0x060178EE RID: 96494 RVA: 0x006F47E8 File Offset: 0x006F29E8
	protected virtual void OnEvent(HitContext hitContext)
	{
		if (base.Checker != null && !base.Checker())
		{
			return;
		}
		Entity entity = hitContext.Attacker;
		if (entity != null && FollowUtils.IsFollowShooterByEntity(entity))
		{
			entity = FollowUtils.ShouldForwardToFrontChar(entity);
		}
		int[] skillTypes = TriggerUtils.GetSkillTypes(hitContext.SkillGenres);
		Dictionary<string, TFormulaValue> dictionary = new Dictionary<string, TFormulaValue>();
		dictionary["Attacker"] = entity;
		dictionary["Victim"] = hitContext.Target;
		dictionary["SkillID"] = hitContext.SkillId;
		dictionary["SkillTypes"] = skillTypes;
		dictionary["BulletID"] = Convert.ToInt64(hitContext.BulletId);
		dictionary["CounterType"] = (int)hitContext.CounterAttackType;
		dictionary["SkillHitCount"] = hitContext.SkillHitCount.GetValueOrDefault(9999);
		dictionary["SkillHitCountByVictim"] = hitContext.SkillHitCountByVictim.GetValueOrDefault(9999);
		dictionary["BulletHitCount"] = hitContext.BulletHitCount.GetValueOrDefault(9999);
		dictionary["BulletHitCountByVictim"] = hitContext.BulletHitCountByVictim.GetValueOrDefault(9999);
		dictionary["BattleFlags"] = hitContext.BattleFlags;
		base.EvaluateAndExecute(dictionary);
	}

	// Token: 0x060178EF RID: 96495 RVA: 0x006F4950 File Offset: 0x006F2B50
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C87A RID: 51322
	protected ETriggerTargetType TargetType;
}
