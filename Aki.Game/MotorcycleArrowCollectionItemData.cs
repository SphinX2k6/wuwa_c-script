using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001197 RID: 4503
public class MotorcycleArrowCollectionItemData
{
	// Token: 0x0600B3AA RID: 45994 RVA: 0x003516BA File Offset: 0x0034F8BA
	[NullableContext(1)]
	public static MotorcycleArrowCollectionItemData Create(MotorFightItem config, int pos)
	{
		return new MotorcycleArrowCollectionItemData(config.Id)
		{
			Config = config,
			Pos = pos,
			Num = 1
		};
	}

	// Token: 0x0600B3AB RID: 45995 RVA: 0x003516DD File Offset: 0x0034F8DD
	private MotorcycleArrowCollectionItemData(int id)
	{
		this.Id = id;
	}

	// Token: 0x0600B3AC RID: 45996 RVA: 0x003516F3 File Offset: 0x0034F8F3
	public void SetIsShowStrengthen(bool show)
	{
		this.IsShowStrengthen = show;
	}

	// Token: 0x040067B5 RID: 26549
	public int Id;

	// Token: 0x040067B6 RID: 26550
	public MotorFightItem Config;

	// Token: 0x040067B7 RID: 26551
	public bool IsShowStrengthen;

	// Token: 0x040067B8 RID: 26552
	public bool IsUnlock = true;

	// Token: 0x040067B9 RID: 26553
	public int Pos;

	// Token: 0x040067BA RID: 26554
	public int Num;
}
