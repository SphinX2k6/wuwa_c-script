using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200233C RID: 9020
[NullableContext(1)]
[Nullable(0)]
public static class BulletHitCountUtil
{
	// Token: 0x06016325 RID: 90917 RVA: 0x00677E78 File Offset: 0x00676078
	public static bool HitCountCondition(BulletInfo bulletInfo, Entity victimEntity)
	{
		if (bulletInfo.CountByParent && bulletInfo.ParentBulletInfo != null)
		{
			return BulletHitCountUtil.HitCountCondition(bulletInfo.ParentBulletInfo, victimEntity);
		}
		bool openHitActorLog = BulletConstant.Instance.OpenHitActorLog;
		if (victimEntity == null)
		{
			return false;
		}
		CharacterFollowComponent component = victimEntity.GetComponent<CharacterFollowComponent>();
		Entity entity = ((component != null) ? component.GetAttributeHolderExceptVisionSummon() : null) ?? victimEntity;
		BulletDataMain bulletDataMain = bulletInfo.BulletDataMain;
		if (bulletDataMain.Base.VictimCount >= 0 && bulletInfo.EntityHitSet.Count >= bulletDataMain.Base.VictimCount && !bulletInfo.EntityHitSet.Contains(entity.Id))
		{
			return false;
		}
		if (bulletDataMain.Base.HitCountMax >= 0 && bulletInfo.HitNumberAll >= bulletDataMain.Base.HitCountMax)
		{
			return false;
		}
		int num;
		if (!bulletInfo.EntityHitCount.TryGetValue(entity.Id, out num))
		{
			bulletInfo.EntityHitCount[entity.Id] = 1;
			bulletInfo.EntityHitSet.Add(entity.Id);
			bulletInfo.HitNumberAll++;
			return true;
		}
		if (bulletDataMain.Base.HitCountPerVictim > 0 && num >= bulletDataMain.Base.HitCountPerVictim)
		{
			return false;
		}
		bulletInfo.EntityHitCount[entity.Id] = num + 1;
		bulletInfo.EntityHitSet.Add(entity.Id);
		bulletInfo.HitNumberAll++;
		return true;
	}

	// Token: 0x06016326 RID: 90918 RVA: 0x00677FD0 File Offset: 0x006761D0
	public static void AddHitCount(BulletInfo bulletInfo, Entity victim)
	{
		if (bulletInfo.CountByParent && bulletInfo.ParentBulletInfo != null)
		{
			BulletHitCountUtil.AddHitCount(bulletInfo.ParentBulletInfo, victim);
			return;
		}
		int valueOrDefault = bulletInfo.EntityHitCount.GetValueOrDefault(victim.Id, 0);
		bulletInfo.EntityHitCount[victim.Id] = valueOrDefault + 1;
		bulletInfo.EntityHitSet.Add(victim.Id);
		bulletInfo.HitNumberAll++;
	}

	// Token: 0x06016327 RID: 90919 RVA: 0x00678044 File Offset: 0x00676244
	public static bool CheckHitCountPerVictim(BulletInfo bulletInfo, Entity victim)
	{
		if (bulletInfo.CountByParent && bulletInfo.ParentBulletInfo != null)
		{
			return BulletHitCountUtil.CheckHitCountPerVictim(bulletInfo.ParentBulletInfo, victim);
		}
		int count = bulletInfo.EntityHitSet.Count;
		bool openHitActorLog = BulletConstant.Instance.OpenHitActorLog;
		BulletDataMain bulletDataMain = bulletInfo.BulletDataMain;
		if (bulletDataMain.Base.VictimCount >= 0 && count >= bulletDataMain.Base.VictimCount && !bulletInfo.EntityHitSet.Contains(victim.Id))
		{
			return false;
		}
		int valueOrDefault = bulletInfo.EntityHitCount.GetValueOrDefault(victim.Id, 0);
		return (bulletDataMain.Base.HitCountPerVictim < 0 || valueOrDefault < bulletDataMain.Base.HitCountPerVictim) && (bulletDataMain.Base.HitCountMax <= 0 || bulletInfo.HitNumberAll < bulletDataMain.Base.HitCountMax);
	}

	// Token: 0x06016328 RID: 90920 RVA: 0x00678114 File Offset: 0x00676314
	public static bool CheckHitCountTotal(BulletInfo bulletInfo)
	{
		if (bulletInfo.CountByParent && bulletInfo.ParentBulletInfo != null)
		{
			return BulletHitCountUtil.CheckHitCountTotal(bulletInfo.ParentBulletInfo);
		}
		BulletDataMain bulletDataMain = bulletInfo.BulletDataMain;
		return bulletDataMain.Logic.DestroyOnCountZero && bulletDataMain.Base.HitCountMax > 0 && bulletInfo.HitNumberAll >= bulletDataMain.Base.HitCountMax;
	}

	// Token: 0x06016329 RID: 90921 RVA: 0x00678177 File Offset: 0x00676377
	public static int GetHitCountByVictim(BulletInfo bulletInfo, int victimId)
	{
		if (bulletInfo.CountByParent && bulletInfo.ParentBulletInfo != null)
		{
			return BulletHitCountUtil.GetHitCountByVictim(bulletInfo.ParentBulletInfo, victimId);
		}
		return bulletInfo.EntityHitCount.GetValueOrDefault(victimId, 0);
	}
}
