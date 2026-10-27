using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Utils;

// Token: 0x02002FE7 RID: 12263
[NullableContext(1)]
[Nullable(0)]
public class LimitDodgeTrigger : Trigger
{
	// Token: 0x06019FE2 RID: 106466 RVA: 0x006CD8AB File Offset: 0x006CBAAB
	[NullableContext(2)]
	public LimitDodgeTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x06019FE3 RID: 106467 RVA: 0x006CD8C3 File Offset: 0x006CBAC3
	public override void OnInitParams(string[] triggerParams)
	{
		this.TargetType = (ETriggerTargetType)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : "0");
		this.Source = Convert.ToInt32((triggerParams.Length > 1) ? triggerParams[1] : "1");
	}

	// Token: 0x06019FE4 RID: 106468 RVA: 0x006CD8FC File Offset: 0x006CBAFC
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

	// Token: 0x06019FE5 RID: 106469 RVA: 0x006CD9E0 File Offset: 0x006CBBE0
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

	// Token: 0x06019FE6 RID: 106470 RVA: 0x006CDAC2 File Offset: 0x006CBCC2
	protected void OnEvent(Entity attacker, Entity victim, int skillId, long bulletId)
	{
		this.OnEventInternal(attacker, victim, skillId, bulletId);
	}

	// Token: 0x06019FE7 RID: 106471 RVA: 0x006CDACF File Offset: 0x006CBCCF
	protected void OnHitLocal(HitInformation _, HitContext hitContext)
	{
		this.OnEventInternal(hitContext.Attacker, hitContext.Target, hitContext.SkillId, Convert.ToInt64(hitContext.BulletId));
	}

	// Token: 0x06019FE8 RID: 106472 RVA: 0x006CDAF4 File Offset: 0x006CBCF4
	protected void OnHitRemote(HitContext hitContext)
	{
		this.OnEventInternal(hitContext.Attacker, hitContext.Target, hitContext.SkillId, Convert.ToInt64(hitContext.BulletId));
	}

	// Token: 0x06019FE9 RID: 106473 RVA: 0x006CDB1C File Offset: 0x006CBD1C
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

	// Token: 0x06019FEA RID: 106474 RVA: 0x006CDBCF File Offset: 0x006CBDCF
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C4C0 RID: 50368
	protected ETriggerTargetType TargetType;

	// Token: 0x0400C4C1 RID: 50369
	private int Source = 1;

	// Token: 0x0400C4C2 RID: 50370
	private const int INVALID_HIT_COUNT = 9999;
}
