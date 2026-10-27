using System;
using System.Runtime.CompilerServices;

// Token: 0x02001649 RID: 5705
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class <WheelTowerSeasonRewardView>FBBF3D6A812E94D5AA5DF10EDABE679BF50A994B28144B2AF50A6ACDB52EB89EF__CategoryGridData : MultiTemplateGridDataBase<ETaskCategory, WheelTowerSeasonTaskCategoryItem>
{
	// Token: 0x0600A036 RID: 41014 RVA: 0x002343DC File Offset: 0x002325DC
	public <WheelTowerSeasonRewardView>FBBF3D6A812E94D5AA5DF10EDABE679BF50A994B28144B2AF50A6ACDB52EB89EF__CategoryGridData(ETaskCategory data)
	{
		base.Data = data;
	}

	// Token: 0x0600A037 RID: 41015 RVA: 0x002343EB File Offset: 0x002325EB
	public override int GetTemplateIndex()
	{
		return 0;
	}

	// Token: 0x0600A038 RID: 41016 RVA: 0x002343EE File Offset: 0x002325EE
	public override WheelTowerSeasonTaskCategoryItem CreateProxy()
	{
		return new WheelTowerSeasonTaskCategoryItem();
	}
}
