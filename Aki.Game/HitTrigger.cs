using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow;
using CSharpScript.Utils;

// Token: 0x02002FE1 RID: 12257
[NullableContext(1)]
[Nullable(0)]
public class HitTrigger : Trigger
{
	// Token: 0x06019FB4 RID: 106420 RVA: 0x006CC801 File Offset: 0x006CAA01
	[NullableContext(2)]
	public HitTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x06019FB5 RID: 106421 RVA: 0x006CC812 File Offset: 0x006CAA12
	public override void OnInitParams(string[] triggerParams)
	{
		this.TargetType = (ETriggerTargetType)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : "0");
	}

	// Token: 0x06019FB6 RID: 106422 RVA: 0x006CC830 File Offset: 0x006CAA30
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

	// Token: 0x06019FB7 RID: 106423 RVA: 0x006CC8B4 File Offset: 0x006CAAB4
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

	// Token: 0x06019FB8 RID: 106424 RVA: 0x006CC936 File Offset: 0x006CAB36
	protected void OnHitLocal(HitInformation _, HitContext hitContext)
	{
		this.OnEvent(hitContext);
	}

	// Token: 0x06019FB9 RID: 106425 RVA: 0x006CC93F File Offset: 0x006CAB3F
	protected void OnHitRemote(HitContext hitContext)
	{
		this.OnEvent(hitContext);
	}

	// Token: 0x06019FBA RID: 106426 RVA: 0x006CC948 File Offset: 0x006CAB48
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

	// Token: 0x06019FBB RID: 106427 RVA: 0x006CCAB0 File Offset: 0x006CACB0
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C4B2 RID: 50354
	protected ETriggerTargetType TargetType;
}
