using System;
using System.Runtime.CompilerServices;

// Token: 0x0200164A RID: 5706
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
internal class <WheelTowerSeasonRewardView>FBBF3D6A812E94D5AA5DF10EDABE679BF50A994B28144B2AF50A6ACDB52EB89EF__TaskGridData : MultiTemplateGridDataBase<ActivityTaskData, WheelTowerSeasonTaskItem>
{
	// Token: 0x0600A039 RID: 41017 RVA: 0x002343F5 File Offset: 0x002325F5
	public <WheelTowerSeasonRewardView>FBBF3D6A812E94D5AA5DF10EDABE679BF50A994B28144B2AF50A6ACDB52EB89EF__TaskGridData(ActivityTaskData data, Action onClickToGet)
	{
		base.Data = data;
		this.OnClickToGet = onClickToGet;
	}

	// Token: 0x0600A03A RID: 41018 RVA: 0x0023440B File Offset: 0x0023260B
	public override int GetTemplateIndex()
	{
		return 1;
	}

	// Token: 0x0600A03B RID: 41019 RVA: 0x0023440E File Offset: 0x0023260E
	public override WheelTowerSeasonTaskItem CreateProxy()
	{
		return new WheelTowerSeasonTaskItem
		{
			OnClickToGet = this.OnClickToGet
		};
	}

	// Token: 0x040048FE RID: 18686
	private readonly Action OnClickToGet;
}
