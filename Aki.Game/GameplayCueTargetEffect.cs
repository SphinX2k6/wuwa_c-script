using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using UnrealEngine;

// Token: 0x02002529 RID: 9513
public class GameplayCueTargetEffect : GameplayCueEffect
{
	// Token: 0x0601786A RID: 96362 RVA: 0x006F170D File Offset: 0x006EF90D
	protected override void OnTick(float delta)
	{
		base.OnTick(delta);
		this.CheckTargetChanged();
	}

	// Token: 0x0601786B RID: 96363 RVA: 0x006F171C File Offset: 0x006EF91C
	protected override void SetTargetMeshAndSocket()
	{
		ValueTuple<EntityHandle, string> targetAndSocket = this.GetTargetAndSocket();
		EntityHandle item = targetAndSocket.Item1;
		string item2 = targetAndSocket.Item2;
		this.CurrentTarget = item;
		this.CurrentTargetSocket = item2;
		if (item != null)
		{
			WorldEntity entity = item.Entity;
			if (((entity != null) ? new bool?(entity.Valid) : null).GetValueOrDefault())
			{
				CharacterActorComponent component = item.Entity.GetComponent<CharacterActorComponent>();
				if (component != null)
				{
					this.TargetMesh = component.Actor.Mesh;
					string key = (!string.IsNullOrEmpty(item2)) ? item2 : this.CueConfig.Socket;
					this.TargetSocket = FNameUtil.GetDynamicFName(key).Value;
					USkeletalMeshComponent targetMesh = this.TargetMesh;
					if (targetMesh == null || !targetMesh.DoesSocketExist(this.TargetSocket))
					{
						this.TargetSocket = CharacterNameDefines.Instance.HIT_CASE_NAME;
					}
					return;
				}
			}
		}
		this.TargetMesh = this.ActorInternal.Mesh;
		this.TargetSocket = FNameUtil.GetDynamicFName(this.CueConfig.Socket).Value;
		USkeletalMeshComponent targetMesh2 = this.TargetMesh;
		if (targetMesh2 == null || !targetMesh2.DoesSocketExist(this.TargetSocket))
		{
			this.TargetSocket = CharacterNameDefines.Instance.HIT_CASE_NAME;
		}
	}

	// Token: 0x0601786C RID: 96364 RVA: 0x006F1854 File Offset: 0x006EFA54
	protected override void AttachEffect(bool onChangeRole = false)
	{
		if (!EffectSystem.Instance.IsValid(this.EffectViewHandle))
		{
			return;
		}
		OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(this.EffectViewHandle);
		if (!effectActor.IsValid())
		{
			return;
		}
		EntityHandle currentTarget = this.CurrentTarget;
		bool flag;
		if (currentTarget == null)
		{
			flag = true;
		}
		else
		{
			WorldEntity entity = currentTarget.Entity;
			flag = !((entity != null) ? new bool?(entity.Valid) : null).GetValueOrDefault();
		}
		if (flag)
		{
			effectActor.SetActorHiddenInGame(true);
			return;
		}
		effectActor.SetActorHiddenInGame(false);
		effectActor.K2_AttachToComponent(this.TargetMesh, new FName?(this.TargetSocket), (EAttachmentRule)this.CueConfig.LocRule, (EAttachmentRule)this.CueConfig.RotaRule, (EAttachmentRule)this.CueConfig.SclRule, false);
	}

	// Token: 0x0601786D RID: 96365 RVA: 0x006F1911 File Offset: 0x006EFB11
	[return: TupleElementNames(new string[]
	{
		"Target",
		"TargetSocket"
	})]
	[return: Nullable(new byte[]
	{
		0,
		2,
		1
	})]
	private ValueTuple<EntityHandle, string> GetTargetAndSocket()
	{
		if (GameplayCueController.GetTargetSourceType(this.CueConfig) == ETargetSourceType.Skill)
		{
			return this.GetSkillTargetAndSocket();
		}
		return this.GetLockOnTargetAndSocket();
	}

	// Token: 0x0601786E RID: 96366 RVA: 0x006F1930 File Offset: 0x006EFB30
	[return: TupleElementNames(new string[]
	{
		"Target",
		"TargetSocket"
	})]
	[return: Nullable(new byte[]
	{
		0,
		2,
		1
	})]
	private ValueTuple<EntityHandle, string> GetLockOnTargetAndSocket()
	{
		EntityHandle item = null;
		string item2 = string.Empty;
		WorldEntity entity = this.EntityHandle.Entity;
		CharacterLockOnComponent characterLockOnComponent = (entity != null) ? entity.GetComponent<CharacterLockOnComponent>() : null;
		WorldEntity entity2 = this.EntityHandle.Entity;
		CharacterActorComponent characterActorComponent = (entity2 != null) ? entity2.GetComponent<CharacterActorComponent>() : null;
		if (characterLockOnComponent != null && characterActorComponent != null && characterActorComponent.IsAutonomousProxy)
		{
			item = characterLockOnComponent.GetCurrentTarget();
			item2 = characterLockOnComponent.GetCurrentTargetSocketName();
		}
		else
		{
			WorldEntity entity3 = this.EntityHandle.Entity;
			CharacterSkillComponent characterSkillComponent = (entity3 != null) ? entity3.GetComponent<CharacterSkillComponent>() : null;
			if (characterSkillComponent != null)
			{
				item = characterSkillComponent.SkillTarget;
				item2 = characterSkillComponent.SkillTargetSocket;
			}
		}
		return new ValueTuple<EntityHandle, string>(item, item2);
	}

	// Token: 0x0601786F RID: 96367 RVA: 0x006F19C8 File Offset: 0x006EFBC8
	[return: TupleElementNames(new string[]
	{
		"Target",
		"TargetSocket"
	})]
	[return: Nullable(new byte[]
	{
		0,
		2,
		1
	})]
	private ValueTuple<EntityHandle, string> GetSkillTargetAndSocket()
	{
		EntityHandle item = null;
		string item2 = string.Empty;
		WorldEntity entity = this.EntityHandle.Entity;
		CharacterSkillComponent characterSkillComponent = (entity != null) ? entity.GetComponent<CharacterSkillComponent>() : null;
		if (characterSkillComponent != null)
		{
			item = characterSkillComponent.SkillTarget;
			item2 = characterSkillComponent.SkillTargetSocket;
		}
		return new ValueTuple<EntityHandle, string>(item, item2);
	}

	// Token: 0x06017870 RID: 96368 RVA: 0x006F1A10 File Offset: 0x006EFC10
	private void CheckTargetChanged()
	{
		ValueTuple<EntityHandle, string> targetAndSocket = this.GetTargetAndSocket();
		EntityHandle item = targetAndSocket.Item1;
		string item2 = targetAndSocket.Item2;
		if (item == this.CurrentTarget && item2 == this.CurrentTargetSocket)
		{
			return;
		}
		this.RefreshEffectStatus(false);
	}

	// Token: 0x0400C82A RID: 51242
	[Nullable(2)]
	private EntityHandle CurrentTarget;

	// Token: 0x0400C82B RID: 51243
	[Nullable(1)]
	private string CurrentTargetSocket = string.Empty;
}
