using System;
using System.Runtime.CompilerServices;

// Token: 0x0200231E RID: 8990
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class BulletLogicAddBuff : BulletLogicController<LogicDataAddBuff, object>
{
	// Token: 0x06016295 RID: 90773 RVA: 0x00671210 File Offset: 0x0066F410
	[NullableContext(1)]
	public BulletLogicAddBuff(LogicDataAddBuff logicData, Entity bulletEntity) : base(logicData, bulletEntity)
	{
		this.Config = logicData;
	}

	// Token: 0x06016296 RID: 90774 RVA: 0x00671224 File Offset: 0x0066F424
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

	// Token: 0x0400BAB8 RID: 47800
	private readonly LogicDataAddBuff Config;
}
