using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow;
using CSharpScript.Utils;

// Token: 0x02002FE8 RID: 12264
[NullableContext(1)]
[Nullable(0)]
public class SkillTrigger : Trigger
{
	// Token: 0x06019FEB RID: 106475 RVA: 0x006CDBD6 File Offset: 0x006CBDD6
	[NullableContext(2)]
	public SkillTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x06019FEC RID: 106476 RVA: 0x006CDBFC File Offset: 0x006CBDFC
	public override void OnInitParams(string[] triggerParams)
	{
		this.TargetType = (ETriggerTargetType)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : "0");
		this.SkillIds.Clear();
		if (triggerParams.Length > 1 && !string.IsNullOrEmpty(triggerParams[1]))
		{
			string[] array = triggerParams[1].Split('#', StringSplitOptions.None);
			this.AllSkill = false;
			for (int i = 0; i < array.Length; i++)
			{
				int num = Convert.ToInt32(array[i]);
				this.SkillIds.Add(num);
				if (num == -1)
				{
					this.AllSkill = true;
				}
			}
		}
		this.CheckEnd = (Convert.ToInt32((triggerParams.Length > 2) ? triggerParams[2] : "0") != 0);
	}

	// Token: 0x06019FED RID: 106477 RVA: 0x006CDC9C File Offset: 0x006CBE9C
	protected override void OnActive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target == null)
		{
			return;
		}
		if (this.CheckEnd)
		{
			if (!TriggerEventHelper.HasWithTarget(target, EEventName.OnSkillEnd, new Action<int, int>(this.OnSelfEvent)))
			{
				TriggerEventHelper.AddWithTarget(target, EEventName.OnSkillEnd, new Action<int, int>(this.OnSelfEvent));
				return;
			}
		}
		else
		{
			if (!TriggerEventHelper.HasWithTarget(target, EEventName.CharUseSkill, new Action<int, int, bool>(this.OnSelfEventWithProxy)))
			{
				TriggerEventHelper.AddWithTarget(target, EEventName.CharUseSkill, new Action<int, int, bool>(this.OnSelfEventWithProxy));
			}
			if (!EventSystem.Instance.HasWithTarget(target, EEventName.CharUseSkillRemote, new Action<int, int>(this.OnSelfEvent)))
			{
				EventSystem.Instance.AddWithTarget(target, EEventName.CharUseSkillRemote, new Action<int, int>(this.OnSelfEvent));
			}
		}
	}

	// Token: 0x06019FEE RID: 106478 RVA: 0x006CDD60 File Offset: 0x006CBF60
	protected override void OnInactive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target == null)
		{
			return;
		}
		if (this.CheckEnd)
		{
			if (TriggerEventHelper.HasWithTarget(target, EEventName.OnSkillEnd, new Action<int, int>(this.OnSelfEvent)))
			{
				TriggerEventHelper.RemoveWithTarget(target, EEventName.OnSkillEnd, new Action<int, int>(this.OnSelfEvent));
				return;
			}
		}
		else
		{
			if (TriggerEventHelper.HasWithTarget(target, EEventName.CharUseSkill, new Action<int, int, bool>(this.OnSelfEventWithProxy)))
			{
				TriggerEventHelper.RemoveWithTarget(target, EEventName.CharUseSkill, new Action<int, int, bool>(this.OnSelfEventWithProxy));
			}
			if (EventSystem.Instance.HasWithTarget(target, EEventName.CharUseSkillRemote, new Action<int, int>(this.OnSelfEvent)))
			{
				EventSystem.Instance.RemoveWithTarget(target, EEventName.CharUseSkillRemote, new Action<int, int>(this.OnSelfEvent));
			}
		}
	}

	// Token: 0x06019FEF RID: 106479 RVA: 0x006CDE24 File Offset: 0x006CC024
	protected void OnSelfEvent(int entityId, int skillId)
	{
		if (base.Checker != null && !base.Checker())
		{
			return;
		}
		if (!this.AllSkill)
		{
			bool flag = false;
			for (int i = 0; i < this.SkillIds.Count; i++)
			{
				if (this.SkillIds[i] == skillId)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return;
			}
		}
		Entity entity = EntitySystem.Instance.Get(entityId);
		if (entity != null && FollowUtils.IsFollowShooterByEntity(entity))
		{
			entity = FollowUtils.ShouldForwardToFrontChar(entity);
		}
		BaseSkillComponent baseSkillComponent = (entity != null) ? entity.GetComponent<BaseSkillComponent>() : null;
		if (baseSkillComponent == null)
		{
			return;
		}
		Skill skill = baseSkillComponent.GetSkill(skillId);
		int[] skillTypes = TriggerUtils.GetSkillTypes((skill != null) ? skill.SkillGenres : null);
		string[] array;
		if (skill == null)
		{
			array = null;
		}
		else
		{
			ISkillBattleContext battleContext = skill.BattleContext;
			if (battleContext == null)
			{
				array = null;
			}
			else
			{
				List<string> battleFlags = battleContext.BattleFlags;
				array = ((battleFlags != null) ? battleFlags.ToArray() : null);
			}
		}
		string[] value = array ?? Array.Empty<string>();
		Dictionary<string, TFormulaValue> dictionary = new Dictionary<string, TFormulaValue>();
		dictionary["SkillTypes"] = skillTypes;
		dictionary["SkillTags"] = Array.Empty<string>();
		dictionary["SkillID"] = skillId;
		dictionary["BattleFlags"] = value;
		dictionary["Attacker"] = entity;
		base.EvaluateAndExecute(dictionary);
	}

	// Token: 0x06019FF0 RID: 106480 RVA: 0x006CDF61 File Offset: 0x006CC161
	protected void OnSelfEventWithProxy(int entityId, int skillId, bool isAutonomousProxy)
	{
		this.OnSelfEvent(entityId, skillId);
	}

	// Token: 0x06019FF1 RID: 106481 RVA: 0x006CDF6B File Offset: 0x006CC16B
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C4C3 RID: 50371
	protected ETriggerTargetType TargetType;

	// Token: 0x0400C4C4 RID: 50372
	protected readonly List<int> SkillIds = new List<int>();

	// Token: 0x0400C4C5 RID: 50373
	protected bool AllSkill = true;

	// Token: 0x0400C4C6 RID: 50374
	protected bool CheckEnd;
}
