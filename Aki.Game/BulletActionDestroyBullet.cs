using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;

// Token: 0x02002D87 RID: 11655
[NullableContext(1)]
[Nullable(0)]
public class BulletActionDestroyBullet : BulletActionBase
{
	// Token: 0x060187E7 RID: 100327 RVA: 0x0063C274 File Offset: 0x0063A474
	public BulletActionDestroyBullet(EBulletAction type) : base(type)
	{
	}

	// Token: 0x060187E8 RID: 100328 RVA: 0x0063C280 File Offset: 0x0063A480
	protected override void OnExecute()
	{
		BulletActionInfoDestroyBullet bulletActionInfoDestroyBullet = (BulletActionInfoDestroyBullet)this.ActionInfo;
		if (bulletActionInfoDestroyBullet.SummonChild)
		{
			BulletChildInfo childInfo = this.BulletInfo.ChildInfo;
			if (childInfo != null)
			{
				childInfo.SetIsActiveSummonChildBullet(true);
			}
		}
		if (bulletActionInfoDestroyBullet.DestroyReason.GetValueOrDefault() == EBulletDestroyReason.ParentDestroy)
		{
			this.OnParentDestroy();
		}
		EntityHandle attackerHandle = this.BulletInfo.AttackerHandle;
		if (attackerHandle != null && attackerHandle.Valid)
		{
			BaseActorComponent attackerActorComp = this.BulletInfo.AttackerActorComp;
			if (((attackerActorComp != null) ? attackerActorComp.Owner : null) != null)
			{
				this.SummonChildBulletOnDestroy();
				this.SendBulletDataEndEvent();
			}
		}
		this.BulletEffectOnDestroy();
		this.DestroySummon();
		if (this.BulletInfo.NeedNotifyChildrenWhenDestroy && this.BulletInfo.ChildEntityIds != null)
		{
			foreach (int id in this.BulletInfo.ChildEntityIds)
			{
				BulletController.Instance.DestroyBullet(id, false, EBulletDestroyReason.ParentDestroy, false);
			}
		}
		BulletCollisionInfo collisionInfo = this.BulletInfo.CollisionInfo;
		foreach (KeyValuePair<int, int> keyValuePair in collisionInfo.HitTimeScaleEntityMap)
		{
			int key = keyValuePair.Key;
			int value = keyValuePair.Value;
			EntityHandle handle = CharacterModel.Instance.GetHandle(key);
			if (handle != null && handle.Valid)
			{
				PawnTimeScaleComponent component = handle.Entity.GetComponent<PawnTimeScaleComponent>();
				if (component != null)
				{
					component.RemoveTimeScale(value);
				}
			}
		}
		collisionInfo.HitTimeScaleEntityMap.Clear();
		foreach (BulletHitActorData bulletHitActorData in collisionInfo.LastArrayHitActorData)
		{
			if (bulletHitActorData.IsValidHit)
			{
				BulletCollisionUtil.EntityLeave(this.BulletInfo, bulletHitActorData);
			}
		}
	}

	// Token: 0x060187E9 RID: 100329 RVA: 0x0063C46C File Offset: 0x0063A66C
	private void OnParentDestroy()
	{
		if (BulletHitCountUtil.CheckHitCountTotal(this.BulletInfo))
		{
			BulletStaticFunction.SpawnHitEffect(this.BulletInfo, EBulletHitEffect.次数不足时触发, "[BulletActionDestroyBullet.OnParentDestroy]");
			BulletChildInfo childInfo = this.BulletInfo.ChildInfo;
			if (childInfo == null)
			{
				return;
			}
			childInfo.SetIsNumberNotEnough(true);
		}
	}

	// Token: 0x060187EA RID: 100330 RVA: 0x0063C4A4 File Offset: 0x0063A6A4
	private void SendBulletDataEndEvent()
	{
		BaseActorComponent attackerActorComp = this.BulletInfo.AttackerActorComp;
		bool flag;
		if (attackerActorComp == null)
		{
			flag = false;
		}
		else
		{
			AActor owner = attackerActorComp.Owner;
			flag = ((owner != null) ? new bool?(owner.IsValid()) : null).GetValueOrDefault();
		}
		if (flag)
		{
			FGameplayTag sendGameplayEventTagToAttackerOnEnd = this.BulletInfo.BulletDataMain.Execution.SendGameplayEventTagToAttackerOnEnd;
			EventSystem.Instance.EmitWithTarget<BulletInfo>(this.BulletInfo.Attacker, EEventName.BulletDestroy, this.BulletInfo);
			if (!sendGameplayEventTagToAttackerOnEnd.TagName.IsNone())
			{
				FGameplayEventData fgameplayEventData = new FGameplayEventData();
				fgameplayEventData.OptionalObject = this.BulletInfo.Actor;
				UAbilitySystemBlueprintLibrary.SendGameplayEventToActor(this.BulletInfo.AttackerActorComp.Owner, sendGameplayEventTagToAttackerOnEnd, fgameplayEventData);
			}
		}
	}

	// Token: 0x060187EB RID: 100331 RVA: 0x0063C560 File Offset: 0x0063A760
	private void DestroySummon()
	{
		BulletDataMain bulletDataMain = this.BulletInfo.BulletDataMain;
		if (this.BulletInfo.SummonServerEntityId == 0L || bulletDataMain.Summon.EntityId <= 0 || !bulletDataMain.Summon.DestroyEntityOnBulletEnd)
		{
			return;
		}
		CreatureController.Instance.RemoveSummonEntityByServerIdRequest(this.BulletInfo.BulletInitParams.SkillId, this.BulletInfo.SummonAttackerId, this.BulletInfo.SummonServerEntityId);
	}

	// Token: 0x060187EC RID: 100332 RVA: 0x0063C5D4 File Offset: 0x0063A7D4
	private void SummonChildBulletOnDestroy()
	{
		BulletChildInfo childInfo = this.BulletInfo.ChildInfo;
		BulletDataChild[] children = this.BulletInfo.BulletDataMain.Children;
		int num = children.Length;
		for (int i = 0; i < num; i++)
		{
			BulletDataChild bulletDataChild = children[i];
			long num2;
			if (((bulletDataChild.Condition == global::EBulletChildrenType.OnTimeEnd && this.BulletInfo.IsTimeNotEnough) || (bulletDataChild.Condition == global::EBulletChildrenType.OnCountEnd && childInfo.IsNumberNotEnough) || (bulletDataChild.Condition == global::EBulletChildrenType.Normal && childInfo.IsActiveSummonChildBullet)) && long.TryParse(bulletDataChild.RowName.ToString(), out num2) && num2 != 0L && bulletDataChild.Num >= 1)
			{
				HashSet<string> parentIds = BulletUtil.CollectParentsId(this.BulletInfo);
				BulletController instance = BulletController.Instance;
				Entity attacker = this.BulletInfo.Attacker;
				string bulletRowName = bulletDataChild.RowName.ToString();
				FTransformDouble? initialTransform = new FTransformDouble?(this.BulletInfo.ActorComponent.ActorTransform);
				BulletController.BulletCreateParams bulletCreateParams = new BulletController.BulletCreateParams();
				bulletCreateParams.SkillId = this.BulletInfo.BulletInitParams.SkillId;
				bulletCreateParams.SkillContextId = this.BulletInfo.BulletInitParams.SkillContextId;
				Entity target = this.BulletInfo.Target;
				bulletCreateParams.ParentTargetId = ((target != null) ? new int?(target.Id) : null);
				bulletCreateParams.ParentId = this.BulletInfo.Entity.Id;
				bulletCreateParams.BattleContext = this.BulletInfo.BulletInitParams.BattleContext;
				bulletCreateParams.ParentIds = parentIds;
				BulletEntity bulletEntity = instance.CreateBulletCustomTarget(attacker, bulletRowName, initialTransform, bulletCreateParams, this.BulletInfo.ContextId, EBulletCreateSource.Others);
				if (bulletEntity != null)
				{
					BulletUtil.ProcessHandOverEffectToSon(this.BulletInfo, bulletEntity);
				}
			}
		}
	}

	// Token: 0x060187ED RID: 100333 RVA: 0x0063C780 File Offset: 0x0063A980
	private void BulletEffectOnDestroy()
	{
		if (this.BulletInfo.IsDestroyByCharSkillEnd)
		{
			BulletStaticFunction.SpawnHitEffect(this.BulletInfo, EBulletHitEffect.子弹打断销毁触发, "[BulletActionDestroyBullet.BulletEffectOnDestroy] 1");
		}
		if (this.BulletInfo.IsTimeNotEnough)
		{
			BulletStaticFunction.SpawnHitEffect(this.BulletInfo, EBulletHitEffect.时间销毁触发, "[BulletActionDestroyBullet.BulletEffectOnDestroy] 2");
		}
		this.BulletInfo.ActionLogicComponent.ActionDestroy();
		if ((this.ActionInfo as BulletActionInfoDestroyBullet).DestroyEffectImmediately)
		{
			this.BulletInfo.EffectInfo.IsFinishAuto = false;
		}
		BulletStaticFunction.DestroyEffect(this.BulletInfo, true);
	}

	// Token: 0x0400B589 RID: 46473
	[StaticVariableRuleIgnore]
	private static readonly Stat ChildOnDestroyStat = Stat.Create("BulletDataComp.ChildOnDestroy", "", "");

	// Token: 0x0400B58A RID: 46474
	[StaticVariableRuleIgnore]
	private static readonly Stat EffectOnDestroyStat = Stat.Create("BulletDataComp.EffectOnDestroy", "", "");

	// Token: 0x0400B58B RID: 46475
	[StaticVariableRuleIgnore]
	private static readonly Stat SpawnHitEffectStat = Stat.Create("SpawnHitEffect", "", "");

	// Token: 0x0400B58C RID: 46476
	[StaticVariableRuleIgnore]
	private static readonly Stat ActionDestroyStat = Stat.Create("ActionDestroy", "", "");

	// Token: 0x0400B58D RID: 46477
	[StaticVariableRuleIgnore]
	private static readonly Stat ActionBreakEffect = Stat.Create("ActionBreakEffect", "", "");
}
