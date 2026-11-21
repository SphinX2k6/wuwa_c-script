using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002325 RID: 8997
[NullableContext(2)]
[Nullable(0)]
public class BulletLogicController<[Nullable(0)] T, TParam> : BulletLogicControllerBase where T : UKuroBpDataAsset
{
	// Token: 0x060162A9 RID: 90793 RVA: 0x00671CE6 File Offset: 0x0066FEE6
	[NullableContext(1)]
	protected BulletLogicController(T logicController, Entity bullet) : base(bullet)
	{
		this.LogicController = logicController;
	}

	// Token: 0x060162AA RID: 90794 RVA: 0x00671CF8 File Offset: 0x0066FEF8
	public override void BulletLogicActionFromBase(object param = null)
	{
		TParam param2;
		if (param is TParam)
		{
			TParam tparam = (TParam)((object)param);
			param2 = tparam;
		}
		else
		{
			param2 = default(TParam);
		}
		this.BulletLogicAction(param2);
	}

	// Token: 0x060162AB RID: 90795 RVA: 0x00671D28 File Offset: 0x0066FF28
	public virtual void BulletLogicAction(TParam param = default(TParam))
	{
	}

	// Token: 0x060162AC RID: 90796 RVA: 0x00671D2C File Offset: 0x0066FF2C
	public override void BulletLogicActionOnHitObstaclesFromBase(object param = null)
	{
		TParam param2;
		if (param is TParam)
		{
			TParam tparam = (TParam)((object)param);
			param2 = tparam;
		}
		else
		{
			param2 = default(TParam);
		}
		this.BulletLogicActionOnHitObstacles(param2);
	}

	// Token: 0x060162AD RID: 90797 RVA: 0x00671D5C File Offset: 0x0066FF5C
	public virtual void BulletLogicActionOnHitObstacles(TParam param = default(TParam))
	{
	}

	// Token: 0x0400BACA RID: 47818
	[Nullable(1)]
	protected T LogicController;
}
