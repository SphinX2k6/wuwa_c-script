using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020026EB RID: 9963
[NullableContext(1)]
[Nullable(0)]
public class CodeSkill_Feixue_Common_Air : CodeSkillBase
{
	// Token: 0x06018F06 RID: 102150 RVA: 0x0079679F File Offset: 0x0079499F
	public CodeSkill_Feixue_Common_Air(SpecialSkillBase specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x06018F07 RID: 102151 RVA: 0x007967A8 File Offset: 0x007949A8
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

	// Token: 0x06018F08 RID: 102152 RVA: 0x0079681C File Offset: 0x00794A1C
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

	// Token: 0x06018F09 RID: 102153 RVA: 0x007968AB File Offset: 0x00794AAB
	public override void OnEnd(Skill skill)
	{
		this.RemoveCanLandEventListener();
	}

	// Token: 0x06018F0A RID: 102154 RVA: 0x007968B4 File Offset: 0x00794AB4
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

	// Token: 0x06018F0B RID: 102155 RVA: 0x007968FC File Offset: 0x00794AFC
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

	// Token: 0x06018F0C RID: 102156 RVA: 0x00796949 File Offset: 0x00794B49
	private void OnCanLandEvent(int tagId, FGameplayEventData payload)
	{
		this.CanLand = true;
		this.RemoveCanLandEventListener();
	}

	// Token: 0x0400D90D RID: 55565
	private const int COMMON_AIR_MONTAGE_INDEX = 0;

	// Token: 0x0400D90E RID: 55566
	private bool CanLand;

	// Token: 0x0400D90F RID: 55567
	private bool LandCheckDone;

	// Token: 0x0400D910 RID: 55568
	private bool ListenerActive;
}
