using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002DCB RID: 11723
[NullableContext(2)]
[Nullable(0)]
public class BulletLogicController<[Nullable(0)] T, TParam> : BulletLogicControllerBase where T : UKuroBpDataAsset
{
	// Token: 0x06018A01 RID: 100865 RVA: 0x0064BF02 File Offset: 0x0064A102
	[NullableContext(1)]
	protected BulletLogicController(T logicController, Entity bullet) : base(bullet)
	{
		this.LogicController = logicController;
	}

	// Token: 0x06018A02 RID: 100866 RVA: 0x0064BF14 File Offset: 0x0064A114
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

	// Token: 0x06018A03 RID: 100867 RVA: 0x0064BF44 File Offset: 0x0064A144
	public virtual void BulletLogicAction(TParam param = default(TParam))
	{
	}

	// Token: 0x06018A04 RID: 100868 RVA: 0x0064BF48 File Offset: 0x0064A148
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

	// Token: 0x06018A05 RID: 100869 RVA: 0x0064BF78 File Offset: 0x0064A178
	public virtual void BulletLogicActionOnHitObstacles(TParam param = default(TParam))
	{
	}

	// Token: 0x0400B74F RID: 46927
	[Nullable(1)]
	protected T LogicController;
}
