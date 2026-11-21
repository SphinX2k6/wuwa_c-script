using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Utils;

// Token: 0x0200253C RID: 9532
[NullableContext(1)]
[Nullable(0)]
public class LimitDodgeTrigger : Trigger
{
	// Token: 0x06017916 RID: 96534 RVA: 0x006F5777 File Offset: 0x006F3977
	[NullableContext(2)]
	public LimitDodgeTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x06017917 RID: 96535 RVA: 0x006F578F File Offset: 0x006F398F
	public override void OnInitParams(string[] triggerParams)
	{
		this.TargetType = (ETriggerTargetType)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : "0");
		this.Source = Convert.ToInt32((triggerParams.Length > 1) ? triggerParams[1] : "1");
	}

	// Token: 0x06017918 RID: 96536 RVA: 0x006F57C8 File Offset: 0x006F39C8
	protected override void OnActive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target == null)
		{
			return;
		}
		if ((this.Source & 1) != 0 && !EventSystem.Instance.HasWithTarget(target, EEventName.CharLimitDodge, new Action<Entity, Entity, int, long>(this.OnEvent)))
		{
			EventSystem.Instance.AddWithTarget(target, EEventName.CharLimitDodge, new Action<Entity, Entity, int, long>(this.OnEvent));
		}
		if ((this.Source & 2) != 0)
		{
			if (!EventSystem.Instance.HasWithTarget(target, EEventName.CharBeHitLocal, new Action<HitInformation, HitContext>(this.OnHitLocal)))
			{
				EventSystem.Instance.AddWithTarget(target, EEventName.CharBeHitLocal, new Action<HitInformation, HitContext>(this.OnHitLocal));
			}
			if (!EventSystem.Instance.HasWithTarget(target, EEventName.CharBeHitRemote, new Action<HitContext>(this.OnHitRemote)))
			{
				EventSystem.Instance.AddWithTarget(target, EEventName.CharBeHitRemote, new Action<HitContext>(this.OnHitRemote));
			}
		}
	}

	// Token: 0x06017919 RID: 96537 RVA: 0x006F58AC File Offset: 0x006F3AAC
	protected override void OnInactive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target == null)
		{
			return;
		}
		if ((this.Source & 1) != 0 && EventSystem.Instance.HasWithTarget(target, EEventName.CharLimitDodge, new Action<Entity, Entity, int, long>(this.OnEvent)))
		{
			EventSystem.Instance.RemoveWithTarget(target, EEventName.CharLimitDodge, new Action<Entity, Entity, int, long>(this.OnEvent));
		}
		if ((this.Source & 2) != 0)
		{
			if (EventSystem.Instance.HasWithTarget(target, EEventName.CharBeHitLocal, new Action<HitInformation, HitContext>(this.OnHitLocal)))
			{
				EventSystem.Instance.RemoveWithTarget(target, EEventName.CharBeHitLocal, new Action<HitInformation, HitContext>(this.OnHitLocal));
			}
			if (EventSystem.Instance.HasWithTarget(target, EEventName.CharBeHitRemote, new Action<HitContext>(this.OnHitRemote)))
			{
				EventSystem.Instance.RemoveWithTarget(target, EEventName.CharBeHitRemote, new Action<HitContext>(this.OnHitRemote));
			}
		}
	}

	// Token: 0x0601791A RID: 96538 RVA: 0x006F598E File Offset: 0x006F3B8E
	protected void OnEvent(Entity attacker, Entity victim, int skillId, long bulletId)
	{
		this.OnEventInternal(attacker, victim, skillId, bulletId);
	}

	// Token: 0x0601791B RID: 96539 RVA: 0x006F599B File Offset: 0x006F3B9B
	protected void OnHitLocal(HitInformation _, HitContext hitContext)
	{
		this.OnEventInternal(hitContext.Attacker, hitContext.Target, hitContext.SkillId, Convert.ToInt64(hitContext.BulletId));
	}

	// Token: 0x0601791C RID: 96540 RVA: 0x006F59C0 File Offset: 0x006F3BC0
	protected void OnHitRemote(HitContext hitContext)
	{
		this.OnEventInternal(hitContext.Attacker, hitContext.Target, hitContext.SkillId, Convert.ToInt64(hitContext.BulletId));
	}

	// Token: 0x0601791D RID: 96541 RVA: 0x006F59E8 File Offset: 0x006F3BE8
	private void OnEventInternal(Entity attacker, Entity victim, int skillId, long bulletId)
	{
		if (base.Checker != null && !base.Checker())
		{
			return;
		}
		Entity entity = EntitySystem.Instance.Get(attacker.Id);
		BaseSkillComponent baseSkillComponent = (entity != null) ? entity.GetComponent<BaseSkillComponent>() : null;
		int[] skillTypes = TriggerUtils.GetSkillTypes((baseSkillComponent != null) ? baseSkillComponent.GetSkillGenres(skillId) : null);
		Dictionary<string, TFormulaValue> dictionary = new Dictionary<string, TFormulaValue>();
		dictionary["Attacker"] = attacker;
		dictionary["Victim"] = victim;
		dictionary["SkillID"] = skillId;
		dictionary["SkillTypes"] = skillTypes;
		dictionary["BulletID"] = bulletId;
		base.EvaluateAndExecute(dictionary);
	}

	// Token: 0x0601791E RID: 96542 RVA: 0x006F5A9B File Offset: 0x006F3C9B
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C888 RID: 51336
	protected ETriggerTargetType TargetType;

	// Token: 0x0400C889 RID: 51337
	private int Source = 1;

	// Token: 0x0400C88A RID: 51338
	private const int INVALID_HIT_COUNT = 9999;
}
