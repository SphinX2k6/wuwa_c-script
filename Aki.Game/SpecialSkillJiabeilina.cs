using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020026FF RID: 9983
[NullableContext(2)]
[Nullable(0)]
public class SpecialSkillJiabeilina : SpecialSkillBase
{
	// Token: 0x06019038 RID: 102456 RVA: 0x0079DBA8 File Offset: 0x0079BDA8
	[NullableContext(1)]
	public SpecialSkillJiabeilina(CharacterSpecialSkillComponent specialSkillComponent) : base(specialSkillComponent)
	{
	}

	// Token: 0x06019039 RID: 102457 RVA: 0x0079DBB4 File Offset: 0x0079BDB4
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

	// Token: 0x0601903A RID: 102458 RVA: 0x0079DC58 File Offset: 0x0079BE58
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

	// Token: 0x0601903B RID: 102459 RVA: 0x0079DCEC File Offset: 0x0079BEEC
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

	// Token: 0x0601903C RID: 102460 RVA: 0x0079DD30 File Offset: 0x0079BF30
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

	// Token: 0x0601903D RID: 102461 RVA: 0x0079DE3C File Offset: 0x0079C03C
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

	// Token: 0x0601903E RID: 102462 RVA: 0x0079DF04 File Offset: 0x0079C104
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

	// Token: 0x0601903F RID: 102463 RVA: 0x0079E048 File Offset: 0x0079C248
	private void OnSkillEnd(int entityId, int skillId)
	{
		Dictionary<long, HashSet<string>> skillOtherCasesMap = this.SkillOtherCasesMap;
		HashSet<string> hashSet = (skillOtherCasesMap != null) ? skillOtherCasesMap.GetValueOrDefault((long)skillId) : null;
		if (hashSet != null && hashSet.Count > 0)
		{
			this.RefreshNoUpdateMeshes(hashSet, true);
		}
	}

	// Token: 0x06019040 RID: 102464 RVA: 0x0079E07E File Offset: 0x0079C27E
	public static void SetOptimizeEnable(bool enable)
	{
		SpecialSkillJiabeilina.IsOptimizeEnableInitialized = true;
		SpecialSkillJiabeilina.IsOptimizeEnable = enable;
	}

	// Token: 0x0400DA0C RID: 55820
	private CharacterActorComponent ActorComp;

	// Token: 0x0400DA0D RID: 55821
	private CharacterAnimationComponent AnimComp;

	// Token: 0x0400DA0E RID: 55822
	private BaseSkillComponent SkillComp;

	// Token: 0x0400DA0F RID: 55823
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private HashSet<USkeletalMeshComponent> NoUpdateMeshes;

	// Token: 0x0400DA10 RID: 55824
	[Nullable(new byte[]
	{
		2,
		2,
		1
	})]
	private Dictionary<long, HashSet<string>> SkillOtherCasesMap;

	// Token: 0x0400DA11 RID: 55825
	[StaticVariableRuleIgnore]
	private static bool IsOptimizeEnable;

	// Token: 0x0400DA12 RID: 55826
	[StaticVariableRuleIgnore]
	private static bool IsOptimizeEnableInitialized;
}
