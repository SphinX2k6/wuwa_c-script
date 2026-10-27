using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002DE1 RID: 11745
[NullableContext(1)]
[Nullable(0)]
public static class BulletHitCountUtil
{
	// Token: 0x06018A78 RID: 100984 RVA: 0x00651D3C File Offset: 0x0064FF3C
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

	// Token: 0x06018A79 RID: 100985 RVA: 0x00651E94 File Offset: 0x00650094
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

	// Token: 0x06018A7A RID: 100986 RVA: 0x00651F08 File Offset: 0x00650108
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

	// Token: 0x06018A7B RID: 100987 RVA: 0x00651FD8 File Offset: 0x006501D8
	public static bool CheckHitCountTotal(BulletInfo bulletInfo)
	{
		if (bulletInfo.CountByParent && bulletInfo.ParentBulletInfo != null)
		{
			return BulletHitCountUtil.CheckHitCountTotal(bulletInfo.ParentBulletInfo);
		}
		BulletDataMain bulletDataMain = bulletInfo.BulletDataMain;
		return bulletDataMain.Logic.DestroyOnCountZero && bulletDataMain.Base.HitCountMax > 0 && bulletInfo.HitNumberAll >= bulletDataMain.Base.HitCountMax;
	}

	// Token: 0x06018A7C RID: 100988 RVA: 0x0065203B File Offset: 0x0065023B
	public static int GetHitCountByVictim(BulletInfo bulletInfo, int victimId)
	{
		if (bulletInfo.CountByParent && bulletInfo.ParentBulletInfo != null)
		{
			return BulletHitCountUtil.GetHitCountByVictim(bulletInfo.ParentBulletInfo, victimId);
		}
		return bulletInfo.EntityHitCount.GetValueOrDefault(victimId, 0);
	}
}
