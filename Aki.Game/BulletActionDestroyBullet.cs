using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;

// Token: 0x020022E1 RID: 8929
[NullableContext(1)]
[Nullable(0)]
public class BulletActionDestroyBullet : BulletActionBase
{
	// Token: 0x06016089 RID: 90249 RVA: 0x00661FAC File Offset: 0x006601AC
	public BulletActionDestroyBullet(EBulletAction type) : base(type)
	{
	}

	// Token: 0x0601608A RID: 90250 RVA: 0x00661FB8 File Offset: 0x006601B8
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

	// Token: 0x0601608B RID: 90251 RVA: 0x006621A4 File Offset: 0x006603A4
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

	// Token: 0x0601608C RID: 90252 RVA: 0x006621DC File Offset: 0x006603DC
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

	// Token: 0x0601608D RID: 90253 RVA: 0x00662298 File Offset: 0x00660498
	private void DestroySummon()
	{
		BulletDataMain bulletDataMain = this.BulletInfo.BulletDataMain;
		if (this.BulletInfo.SummonServerEntityId == 0L || bulletDataMain.Summon.EntityId <= 0 || !bulletDataMain.Summon.DestroyEntityOnBulletEnd)
		{
			return;
		}
		CreatureController.Instance.RemoveSummonEntityByServerIdRequest(this.BulletInfo.BulletInitParams.SkillId, this.BulletInfo.SummonAttackerId, this.BulletInfo.SummonServerEntityId);
	}

	// Token: 0x0601608E RID: 90254 RVA: 0x0066230C File Offset: 0x0066050C
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

	// Token: 0x0601608F RID: 90255 RVA: 0x006624B8 File Offset: 0x006606B8
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

	// Token: 0x0400B8FE RID: 47358
	[StaticVariableRuleIgnore]
	private static readonly Stat ChildOnDestroyStat = Stat.Create("BulletDataComp.ChildOnDestroy", "", "");

	// Token: 0x0400B8FF RID: 47359
	[StaticVariableRuleIgnore]
	private static readonly Stat EffectOnDestroyStat = Stat.Create("BulletDataComp.EffectOnDestroy", "", "");

	// Token: 0x0400B900 RID: 47360
	[StaticVariableRuleIgnore]
	private static readonly Stat SpawnHitEffectStat = Stat.Create("SpawnHitEffect", "", "");

	// Token: 0x0400B901 RID: 47361
	[StaticVariableRuleIgnore]
	private static readonly Stat ActionDestroyStat = Stat.Create("ActionDestroy", "", "");

	// Token: 0x0400B902 RID: 47362
	[StaticVariableRuleIgnore]
	private static readonly Stat ActionBreakEffect = Stat.Create("ActionBreakEffect", "", "");
}
