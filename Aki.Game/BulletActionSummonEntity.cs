using System;
using Aki.Protocol;
using Aki.Protocol.Summon;

// Token: 0x020022F2 RID: 8946
public class BulletActionSummonEntity : BulletActionBase
{
	// Token: 0x060160F4 RID: 90356 RVA: 0x00668B7C File Offset: 0x00666D7C
	public BulletActionSummonEntity(EBulletAction type) : base(type)
	{
	}

	// Token: 0x060160F5 RID: 90357 RVA: 0x00668B88 File Offset: 0x00666D88
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
