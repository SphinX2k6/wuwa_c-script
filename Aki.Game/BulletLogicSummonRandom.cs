using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002337 RID: 9015
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class BulletLogicSummonRandom : BulletLogicController<LogicDataSummonRandom, object>
{
	// Token: 0x060162FD RID: 90877 RVA: 0x00675566 File Offset: 0x00673766
	public BulletLogicSummonRandom(LogicDataSummonRandom logicController, Entity bullet) : base(logicController, bullet)
	{
	}

	// Token: 0x060162FE RID: 90878 RVA: 0x00675570 File Offset: 0x00673770
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

	// Token: 0x060162FF RID: 90879 RVA: 0x006755EC File Offset: 0x006737EC
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
