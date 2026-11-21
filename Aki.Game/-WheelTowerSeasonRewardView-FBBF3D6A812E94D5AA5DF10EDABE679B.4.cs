using System;
using System.Runtime.CompilerServices;

// Token: 0x02000B01 RID: 2817
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class <WheelTowerSeasonRewardView>FBBF3D6A812E94D5AA5DF10EDABE679BF50A994B28144B2AF50A6ACDB52EB89EF__CategoryGridData : MultiTemplateGridDataBase<ETaskCategory, WheelTowerSeasonTaskCategoryItem>
{
	// Token: 0x06007414 RID: 29716 RVA: 0x0023E218 File Offset: 0x0023C418
	public <WheelTowerSeasonRewardView>FBBF3D6A812E94D5AA5DF10EDABE679BF50A994B28144B2AF50A6ACDB52EB89EF__CategoryGridData(ETaskCategory data)
	{
		base.Data = data;
	}

	// Token: 0x06007415 RID: 29717 RVA: 0x0023E227 File Offset: 0x0023C427
	public override int GetTemplateIndex()
	{
		return 0;
	}

	// Token: 0x06007416 RID: 29718 RVA: 0x0023E22A File Offset: 0x0023C42A
	public override WheelTowerSeasonTaskCategoryItem CreateProxy()
	{
		return new WheelTowerSeasonTaskCategoryItem();
	}
}
