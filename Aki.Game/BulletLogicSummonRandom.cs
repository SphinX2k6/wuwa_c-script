using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002DDC RID: 11740
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class BulletLogicSummonRandom : BulletLogicController<LogicDataSummonRandom, object>
{
	// Token: 0x06018A50 RID: 100944 RVA: 0x0064F42A File Offset: 0x0064D62A
	public BulletLogicSummonRandom(LogicDataSummonRandom logicController, Entity bullet) : base(logicController, bullet)
	{
	}

	// Token: 0x06018A51 RID: 100945 RVA: 0x0064F434 File Offset: 0x0064D634
	[NullableContext(2)]
	public override void BulletLogicAction(object param = null)
	{
		BulletInfo bulletInfo = this.Bullet.GetBulletInfo();
		Entity attacker = bulletInfo.Attacker;
		FRotator frotator = bulletInfo.GetActorRotation().ToUeRotator();
		FVectorDouble fvectorDouble = bulletInfo.GetActorLocation().ToUeVector(false);
		FTransformDouble transform = new FTransformDouble(ref frotator, ref fvectorDouble, ref FVector.OneVector);
		CreatureController.Instance.SummonRandomRequest(attacker.Id, this.LogicController.SummonIndex, transform, this.LogicController.SkillId, this.LogicController.IsVisible);
	}

	// Token: 0x06018A52 RID: 100946 RVA: 0x0064F4B0 File Offset: 0x0064D6B0
	public override void OnBulletDestroy()
	{
		if (!this.LogicController.DestroySummonOnDestroy)
		{
			return;
		}
		Entity attacker = this.Bullet.GetBulletInfo().Attacker;
		long summonRandomEntityId = attacker.GetComponent<CreatureDataComponent>().GetSummonRandomEntityId(this.LogicController.SummonIndex);
		if (summonRandomEntityId != 0L)
		{
			CreatureController.Instance.RemoveSummonEntityByServerIdRequest(this.LogicController.SkillId, attacker.Id, (long)((int)summonRandomEntityId));
		}
	}
}
