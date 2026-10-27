using System;
using System.Runtime.CompilerServices;

// Token: 0x02002DC4 RID: 11716
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class BulletLogicAddBuff : BulletLogicController<LogicDataAddBuff, object>
{
	// Token: 0x060189ED RID: 100845 RVA: 0x0064B42C File Offset: 0x0064962C
	[NullableContext(1)]
	public BulletLogicAddBuff(LogicDataAddBuff logicData, Entity bulletEntity) : base(logicData, bulletEntity)
	{
		this.Config = logicData;
	}

	// Token: 0x060189EE RID: 100846 RVA: 0x0064B440 File Offset: 0x00649640
	public override void BulletLogicAction(object param = null)
	{
		if (this.Config == null)
		{
			return;
		}
		BulletInfo bulletInfo = this.Bullet.GetBulletInfo();
		BaseBuffComponent attackerBuffComp = bulletInfo.AttackerBuffComp;
		if (attackerBuffComp == null)
		{
			return;
		}
		BaseBuffComponent baseBuffComponent = attackerBuffComp;
		long buffId = this.Config.BuffId;
		AddBuffParam addBuffParam = new AddBuffParam();
		addBuffParam.InstigatorId = attackerBuffComp.CreatureDataId;
		addBuffParam.Level = new int?(bulletInfo.SkillLevel);
		addBuffParam.PreMessageId = bulletInfo.ContextId;
		string str = "子弹";
		BulletDataMain bulletDataMain = bulletInfo.BulletDataMain;
		addBuffParam.Reason = str + ((bulletDataMain != null) ? bulletDataMain.BulletRowName : null) + "GB添加buff";
		addBuffParam.BulletMessageId = bulletInfo.ContextId;
		baseBuffComponent.AddBuff(buffId, addBuffParam);
	}

	// Token: 0x0400B73D RID: 46909
	private readonly LogicDataAddBuff Config;
}
