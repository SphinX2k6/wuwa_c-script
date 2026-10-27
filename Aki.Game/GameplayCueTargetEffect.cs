using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using UnrealEngine;

// Token: 0x02002FD5 RID: 12245
public class GameplayCueTargetEffect : GameplayCueEffect
{
	// Token: 0x06019F58 RID: 106328 RVA: 0x006CAE19 File Offset: 0x006C9019
	protected override void OnTick(float delta)
	{
		base.OnTick(delta);
		this.CheckTargetChanged();
	}

	// Token: 0x06019F59 RID: 106329 RVA: 0x006CAE28 File Offset: 0x006C9028
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

	// Token: 0x06019F5A RID: 106330 RVA: 0x006CAF60 File Offset: 0x006C9160
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

	// Token: 0x06019F5B RID: 106331 RVA: 0x006CB01D File Offset: 0x006C921D
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

	// Token: 0x06019F5C RID: 106332 RVA: 0x006CB03C File Offset: 0x006C923C
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

	// Token: 0x06019F5D RID: 106333 RVA: 0x006CB0D4 File Offset: 0x006C92D4
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

	// Token: 0x06019F5E RID: 106334 RVA: 0x006CB11C File Offset: 0x006C931C
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

	// Token: 0x0400C481 RID: 50305
	[Nullable(2)]
	private EntityHandle CurrentTarget;

	// Token: 0x0400C482 RID: 50306
	[Nullable(1)]
	private string CurrentTargetSocket = string.Empty;
}
