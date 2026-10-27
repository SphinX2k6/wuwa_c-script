using System;
using Aki.Protocol;
using Aki.Protocol.Summon;

// Token: 0x02002D98 RID: 11672
public class BulletActionSummonEntity : BulletActionBase
{
	// Token: 0x06018850 RID: 100432 RVA: 0x00642DC0 File Offset: 0x00640FC0
	public BulletActionSummonEntity(EBulletAction type) : base(type)
	{
	}

	// Token: 0x06018851 RID: 100433 RVA: 0x00642DCC File Offset: 0x00640FCC
	protected override void OnExecute()
	{
		Entity attacker = this.BulletInfo.Attacker;
		CreatureDataComponent attackerCreatureDataComp = this.BulletInfo.AttackerCreatureDataComp;
		int num = 0;
		EEntityType entityType = attackerCreatureDataComp.GetEntityType();
		if (GameModeModel.Instance.IsMulti)
		{
			if ((entityType == EEntityType.Player || entityType == EEntityType.Vision) && !this.BulletInfo.AttackerActorComp.IsAutonomousProxy)
			{
				return;
			}
			if (entityType == EEntityType.Monster)
			{
				num = attackerCreatureDataComp.GetSummonsVersion();
				if (num == 0)
				{
					EntityComponentPb entityComponentPb;
					if (attackerCreatureDataComp.ComponentDataMap.TryGetValue("SummonsComponentPb", out entityComponentPb))
					{
						SummonsComponentPb summonsComponentPb = entityComponentPb.SummonsComponentPb;
						num = ((summonsComponentPb != null) ? summonsComponentPb.Version : 1);
					}
					else
					{
						num = 1;
					}
				}
			}
		}
		this.BulletInfo.SummonAttackerId = attacker.Id;
		bool openCreateLog = BulletConstant.Instance.OpenCreateLog;
		long? num2 = CreatureController.Instance.SummonRequest(this.BulletInfo.BulletInitParams.SkillId, true, this.BulletInfo.ActorComponent.ActorTransform, this.BulletInfo.SummonAttackerId, this.BulletInfo.BulletDataMain.Summon.EntityId, num);
		if (num2 != null)
		{
			this.BulletInfo.SummonServerEntityId = num2.Value;
			BulletModel.Instance.SummonerSummon(attacker.Id, num2.Value);
		}
		if (num > 0)
		{
			attackerCreatureDataComp.SetSummonsVersion(num + 1);
		}
	}
}
