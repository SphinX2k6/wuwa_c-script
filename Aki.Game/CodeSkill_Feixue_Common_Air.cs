using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200317E RID: 12670
[NullableContext(1)]
[Nullable(0)]
public class CodeSkill_Feixue_Common_Air : CodeSkillBase
{
	// Token: 0x0601B401 RID: 111617 RVA: 0x0076EE3B File Offset: 0x0076D03B
	public CodeSkill_Feixue_Common_Air(SpecialSkillBase specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x0601B402 RID: 111618 RVA: 0x0076EE44 File Offset: 0x0076D044
	public override void OnBegin(Skill skill)
	{
		this.CanLand = false;
		this.LandCheckDone = false;
		if (!base.SkillComp.PlaySkillMontage(0, "", 0f, delegate(bool isInterrupted)
		{
			this.EndSelf(skill);
		}, delegate(bool isInterrupted)
		{
			this.EndSelf(skill);
		}))
		{
			base.EndSelf(skill);
			return;
		}
		this.RegisterCanLandEventListener();
	}

	// Token: 0x0601B403 RID: 111619 RVA: 0x0076EEB8 File Offset: 0x0076D0B8
	public override void OnTick(float delta, Skill skill)
	{
		if (!this.CanLand || this.LandCheckDone)
		{
			return;
		}
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		if (component == null)
		{
			return;
		}
		if (component.HasAllTag(new int[]
		{
			GameplayTagDefine.EGameplayTagId["行为状态.位置状态.空中"],
			GameplayTagDefine.EGameplayTagId["行为状态.动作状态.其他"]
		}))
		{
			return;
		}
		this.LandCheckDone = true;
		if (component.HasAnyTag(new int[]
		{
			GameplayTagDefine.EGameplayTagId["行为状态.位置状态.地面"]
		}))
		{
			base.EndSelf(skill);
		}
	}

	// Token: 0x0601B404 RID: 111620 RVA: 0x0076EF47 File Offset: 0x0076D147
	public override void OnEnd(Skill skill)
	{
		this.RemoveCanLandEventListener();
	}

	// Token: 0x0601B405 RID: 111621 RVA: 0x0076EF50 File Offset: 0x0076D150
	private void RegisterCanLandEventListener()
	{
		BaseAbilityComponent component = base.Entity.GetComponent<BaseAbilityComponent>();
		if (component == null)
		{
			return;
		}
		component.AddGameplayEventListener(GameplayTagDefine.EGameplayTagId["角色.R2T1TaidaonvMd10011.事件相关.可接地"], new TGameplayEventCallback(this.OnCanLandEvent));
		this.ListenerActive = true;
	}

	// Token: 0x0601B406 RID: 111622 RVA: 0x0076EF98 File Offset: 0x0076D198
	private void RemoveCanLandEventListener()
	{
		if (!this.ListenerActive)
		{
			return;
		}
		this.ListenerActive = false;
		BaseAbilityComponent component = base.Entity.GetComponent<BaseAbilityComponent>();
		if (component == null)
		{
			return;
		}
		component.RemoveGameplayEventListener(GameplayTagDefine.EGameplayTagId["角色.R2T1TaidaonvMd10011.事件相关.可接地"], new TGameplayEventCallback(this.OnCanLandEvent));
	}

	// Token: 0x0601B407 RID: 111623 RVA: 0x0076EFE5 File Offset: 0x0076D1E5
	private void OnCanLandEvent(int tagId, FGameplayEventData payload)
	{
		this.CanLand = true;
		this.RemoveCanLandEventListener();
	}

	// Token: 0x0400D4AA RID: 54442
	private const int COMMON_AIR_MONTAGE_INDEX = 0;

	// Token: 0x0400D4AB RID: 54443
	private bool CanLand;

	// Token: 0x0400D4AC RID: 54444
	private bool LandCheckDone;

	// Token: 0x0400D4AD RID: 54445
	private bool ListenerActive;
}
