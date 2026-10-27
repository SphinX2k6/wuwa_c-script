using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02003192 RID: 12690
[NullableContext(2)]
[Nullable(0)]
public class SpecialSkillJiabeilina : SpecialSkillBase
{
	// Token: 0x0601B534 RID: 111924 RVA: 0x00776230 File Offset: 0x00774430
	[NullableContext(1)]
	public SpecialSkillJiabeilina(CharacterSpecialSkillComponent specialSkillComponent) : base(specialSkillComponent)
	{
	}

	// Token: 0x0601B535 RID: 111925 RVA: 0x0077623C File Offset: 0x0077443C
	public override void OnStart()
	{
		if (!SpecialSkillJiabeilina.IsOptimizeEnableInitialized)
		{
			SpecialSkillJiabeilina.IsOptimizeEnable = true;
			SpecialSkillJiabeilina.IsOptimizeEnableInitialized = true;
		}
		Entity entity = this.SpecialSkillComponent.Entity;
		this.ActorComp = entity.GetComponent<CharacterActorComponent>();
		this.SkillComp = entity.GetComponent<BaseSkillComponent>();
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp != null && actorComp.IsRoleAndCtrlByMe && SpecialSkillJiabeilina.IsOptimizeEnable)
		{
			this.SkillOtherCasesMap = new Dictionary<long, HashSet<string>>();
			this.InitNoUpdateMeshes();
			EventSystem.Instance.AddWithTarget<int, bool>(entity, EEventName.CharBeforeSkillWithTarget, new Action<int, bool>(this.OnCharBeforeSkill));
			EventSystem.Instance.AddWithTarget<int, int>(entity, EEventName.OnSkillEnd, new Action<int, int>(this.OnSkillEnd));
		}
	}

	// Token: 0x0601B536 RID: 111926 RVA: 0x007762E0 File Offset: 0x007744E0
	public override void OnEnd()
	{
		HashSet<USkeletalMeshComponent> noUpdateMeshes = this.NoUpdateMeshes;
		if (noUpdateMeshes != null)
		{
			noUpdateMeshes.Clear();
		}
		Entity entity = this.SpecialSkillComponent.Entity;
		if (EventSystem.Instance.HasWithTarget<int, bool>(entity, EEventName.CharBeforeSkillWithTarget, new Action<int, bool>(this.OnCharBeforeSkill)))
		{
			EventSystem.Instance.RemoveWithTarget<int, bool>(entity, EEventName.CharBeforeSkillWithTarget, new Action<int, bool>(this.OnCharBeforeSkill));
		}
		if (EventSystem.Instance.HasWithTarget<int, int>(entity, EEventName.OnSkillEnd, new Action<int, int>(this.OnSkillEnd)))
		{
			EventSystem.Instance.RemoveWithTarget<int, int>(entity, EEventName.OnSkillEnd, new Action<int, int>(this.OnSkillEnd));
		}
	}

	// Token: 0x0601B537 RID: 111927 RVA: 0x00776374 File Offset: 0x00774574
	public override void OnActivate()
	{
		Entity entity = this.SpecialSkillComponent.Entity;
		this.AnimComp = entity.GetComponent<CharacterAnimationComponent>();
		if (this.NoUpdateMeshes != null)
		{
			CharacterAnimationComponent animComp = this.AnimComp;
			if (animComp == null)
			{
				return;
			}
			animComp.SetNoUpdateMeshes(this.NoUpdateMeshes);
		}
	}

	// Token: 0x0601B538 RID: 111928 RVA: 0x007763B8 File Offset: 0x007745B8
	private void InitNoUpdateMeshes()
	{
		CharacterActorComponent actorComp = this.ActorComp;
		if (((actorComp != null) ? actorComp.Actor : null) == null)
		{
			return;
		}
		HashSet<string> hashSet = new HashSet<string>
		{
			"OtherCase1",
			"OtherCase2",
			"OtherCase3",
			"OtherCase4",
			"OtherCase5",
			"OtherCase6",
			"OtherCase9",
			"OtherCase10"
		};
		if (this.NoUpdateMeshes == null)
		{
			this.NoUpdateMeshes = new HashSet<USkeletalMeshComponent>();
		}
		TArray<UActorComponent> tarray = this.ActorComp.Actor.K2_GetComponentsByClass(USkeletalMeshComponent.StaticClass());
		for (int i = 0; i < tarray.Num(); i++)
		{
			USkeletalMeshComponent uskeletalMeshComponent = tarray.Get(i) as USkeletalMeshComponent;
			if (uskeletalMeshComponent != null)
			{
				string name = uskeletalMeshComponent.GetName();
				if (hashSet.Contains(name) && uskeletalMeshComponent.AnimClass != null)
				{
					this.NoUpdateMeshes.Add(uskeletalMeshComponent);
				}
			}
		}
	}

	// Token: 0x0601B539 RID: 111929 RVA: 0x007764C4 File Offset: 0x007746C4
	[NullableContext(1)]
	private void RefreshNoUpdateMeshes(HashSet<string> otherCases, bool isAdd)
	{
		CharacterActorComponent actorComp = this.ActorComp;
		if (((actorComp != null) ? actorComp.Actor : null) == null || this.NoUpdateMeshes == null)
		{
			return;
		}
		TArray<UActorComponent> tarray = this.ActorComp.Actor.K2_GetComponentsByClass(USkeletalMeshComponent.StaticClass());
		bool flag = false;
		for (int i = 0; i < tarray.Num(); i++)
		{
			USkeletalMeshComponent uskeletalMeshComponent = tarray.Get(i) as USkeletalMeshComponent;
			if (uskeletalMeshComponent != null)
			{
				string name = uskeletalMeshComponent.GetName();
				if (otherCases.Contains(name))
				{
					if (isAdd && this.NoUpdateMeshes.Add(uskeletalMeshComponent))
					{
						flag = true;
					}
					else if (!isAdd && this.NoUpdateMeshes.Contains(uskeletalMeshComponent))
					{
						this.NoUpdateMeshes.Remove(uskeletalMeshComponent);
						flag = true;
					}
				}
			}
		}
		if (flag)
		{
			CharacterAnimationComponent animComp = this.AnimComp;
			if (animComp == null)
			{
				return;
			}
			animComp.SetNoUpdateMeshes(this.NoUpdateMeshes);
		}
	}

	// Token: 0x0601B53A RID: 111930 RVA: 0x0077658C File Offset: 0x0077478C
	private void OnCharBeforeSkill(int skillId, bool isAutonomousProxy)
	{
		if (this.SkillOtherCasesMap == null)
		{
			this.SkillOtherCasesMap = new Dictionary<long, HashSet<string>>();
		}
		HashSet<string> hashSet;
		if (this.SkillOtherCasesMap.ContainsKey((long)skillId))
		{
			hashSet = this.SkillOtherCasesMap[(long)skillId];
		}
		else
		{
			BaseSkillComponent skillComp = this.SkillComp;
			UAnimMontage[] array;
			if (skillComp == null)
			{
				array = null;
			}
			else
			{
				Skill skill = skillComp.GetSkill(skillId);
				array = ((skill != null) ? skill.GetLoadedMontages() : null);
			}
			UAnimMontage[] array2 = array;
			if (array2 == null)
			{
				this.SkillOtherCasesMap[(long)skillId] = null;
				return;
			}
			hashSet = new HashSet<string>();
			foreach (UAnimMontage uanimMontage in array2)
			{
				if (uanimMontage != null)
				{
					TArray<FAnimNotifyEvent> notifies = uanimMontage.Notifies;
					int num = notifies.Num();
					for (int j = 0; j < num; j++)
					{
						FAnimNotifyEvent fanimNotifyEvent = notifies.Get(j);
						UAnimNotifyState notifyStateClass = fanimNotifyEvent.NotifyStateClass;
						if (notifyStateClass != null && notifyStateClass.IsValid())
						{
							TsAnimNotifyStateHideMesh tsAnimNotifyStateHideMesh = fanimNotifyEvent.NotifyStateClass as TsAnimNotifyStateHideMesh;
							if (tsAnimNotifyStateHideMesh != null)
							{
								string childMeshName = tsAnimNotifyStateHideMesh.ChildMeshName;
								if (!string.IsNullOrEmpty(childMeshName))
								{
									hashSet.Add(childMeshName);
								}
							}
						}
					}
				}
			}
			if (hashSet.Count <= 0)
			{
				this.SkillOtherCasesMap[(long)skillId] = null;
				return;
			}
			this.SkillOtherCasesMap[(long)skillId] = hashSet;
		}
		if (hashSet != null && hashSet.Count > 0)
		{
			this.RefreshNoUpdateMeshes(hashSet, false);
		}
	}

	// Token: 0x0601B53B RID: 111931 RVA: 0x007766D0 File Offset: 0x007748D0
	private void OnSkillEnd(int entityId, int skillId)
	{
		Dictionary<long, HashSet<string>> skillOtherCasesMap = this.SkillOtherCasesMap;
		HashSet<string> hashSet = (skillOtherCasesMap != null) ? skillOtherCasesMap.GetValueOrDefault((long)skillId) : null;
		if (hashSet != null && hashSet.Count > 0)
		{
			this.RefreshNoUpdateMeshes(hashSet, true);
		}
	}

	// Token: 0x0601B53C RID: 111932 RVA: 0x00776706 File Offset: 0x00774906
	public new static void SetOptimizeEnable(bool enable)
	{
		SpecialSkillJiabeilina.IsOptimizeEnableInitialized = true;
		SpecialSkillJiabeilina.IsOptimizeEnable = enable;
	}

	// Token: 0x0400D5A9 RID: 54697
	private CharacterActorComponent ActorComp;

	// Token: 0x0400D5AA RID: 54698
	private CharacterAnimationComponent AnimComp;

	// Token: 0x0400D5AB RID: 54699
	private BaseSkillComponent SkillComp;

	// Token: 0x0400D5AC RID: 54700
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private HashSet<USkeletalMeshComponent> NoUpdateMeshes;

	// Token: 0x0400D5AD RID: 54701
	[Nullable(new byte[]
	{
		2,
		2,
		1
	})]
	private Dictionary<long, HashSet<string>> SkillOtherCasesMap;

	// Token: 0x0400D5AE RID: 54702
	[StaticVariableRuleIgnore]
	private static bool IsOptimizeEnable;

	// Token: 0x0400D5AF RID: 54703
	[StaticVariableRuleIgnore]
	private static bool IsOptimizeEnableInitialized;
}
