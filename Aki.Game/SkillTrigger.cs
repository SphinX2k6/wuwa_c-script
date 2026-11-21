using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow;
using CSharpScript.Utils;

// Token: 0x0200253D RID: 9533
[NullableContext(1)]
[Nullable(0)]
public class SkillTrigger : Trigger
{
	// Token: 0x0601791F RID: 96543 RVA: 0x006F5AA2 File Offset: 0x006F3CA2
	[NullableContext(2)]
	public SkillTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x06017920 RID: 96544 RVA: 0x006F5AC8 File Offset: 0x006F3CC8
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

	// Token: 0x06017921 RID: 96545 RVA: 0x006F5B68 File Offset: 0x006F3D68
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

	// Token: 0x06017922 RID: 96546 RVA: 0x006F5C2C File Offset: 0x006F3E2C
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

	// Token: 0x06017923 RID: 96547 RVA: 0x006F5CF0 File Offset: 0x006F3EF0
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

	// Token: 0x06017924 RID: 96548 RVA: 0x006F5E2D File Offset: 0x006F402D
	protected void OnSelfEventWithProxy(int entityId, int skillId, bool isAutonomousProxy)
	{
		this.OnSelfEvent(entityId, skillId);
	}

	// Token: 0x06017925 RID: 96549 RVA: 0x006F5E37 File Offset: 0x006F4037
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C88B RID: 51339
	protected ETriggerTargetType TargetType;

	// Token: 0x0400C88C RID: 51340
	protected readonly List<int> SkillIds = new List<int>();

	// Token: 0x0400C88D RID: 51341
	protected bool AllSkill = true;

	// Token: 0x0400C88E RID: 51342
	protected bool CheckEnd;
}
