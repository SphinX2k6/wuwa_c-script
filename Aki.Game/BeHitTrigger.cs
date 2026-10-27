using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Utils;

// Token: 0x02002FE0 RID: 12256
[NullableContext(1)]
[Nullable(0)]
public class BeHitTrigger : Trigger
{
	// Token: 0x06019FAC RID: 106412 RVA: 0x006CC574 File Offset: 0x006CA774
	[NullableContext(2)]
	public BeHitTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x06019FAD RID: 106413 RVA: 0x006CC585 File Offset: 0x006CA785
	public override void OnInitParams(string[] triggerParams)
	{
		this.TargetType = (ETriggerTargetType)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : "0");
	}

	// Token: 0x06019FAE RID: 106414 RVA: 0x006CC5A0 File Offset: 0x006CA7A0
	protected override void OnActive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null)
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

	// Token: 0x06019FAF RID: 106415 RVA: 0x006CC638 File Offset: 0x006CA838
	protected override void OnInactive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null)
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

	// Token: 0x06019FB0 RID: 106416 RVA: 0x006CC6D0 File Offset: 0x006CA8D0
	protected void OnHitLocal(HitInformation _, HitContext hitContext)
	{
		this.OnEvent(hitContext);
	}

	// Token: 0x06019FB1 RID: 106417 RVA: 0x006CC6D9 File Offset: 0x006CA8D9
	protected void OnHitRemote(HitContext hitContext)
	{
		this.OnEvent(hitContext);
	}

	// Token: 0x06019FB2 RID: 106418 RVA: 0x006CC6E4 File Offset: 0x006CA8E4
	protected void OnEvent(HitContext hitContext)
	{
		if (base.Checker != null && !base.Checker())
		{
			return;
		}
		int[] skillTypes = TriggerUtils.GetSkillTypes(hitContext.SkillGenres);
		Dictionary<string, TFormulaValue> dictionary = new Dictionary<string, TFormulaValue>();
		dictionary["Attacker"] = hitContext.Attacker;
		dictionary["Victim"] = hitContext.Target;
		dictionary["SkillID"] = hitContext.SkillId;
		dictionary["SkillTypes"] = skillTypes;
		dictionary["BulletID"] = Convert.ToInt64(hitContext.BulletId);
		dictionary["CounterType"] = (int)hitContext.CounterAttackType;
		dictionary["SkillHitCount"] = hitContext.SkillHitCount.GetValueOrDefault(9999);
		dictionary["BulletHitCount"] = hitContext.BulletHitCount.GetValueOrDefault(9999);
		dictionary["BattleFlags"] = hitContext.BattleFlags;
		Dictionary<string, TFormulaValue> extraParams = dictionary;
		base.EvaluateAndExecute(extraParams);
	}

	// Token: 0x06019FB3 RID: 106419 RVA: 0x006CC7FA File Offset: 0x006CA9FA
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C4B0 RID: 50352
	protected ETriggerTargetType TargetType;

	// Token: 0x0400C4B1 RID: 50353
	public const int INVALID_HIT_COUNT = 9999;
}
