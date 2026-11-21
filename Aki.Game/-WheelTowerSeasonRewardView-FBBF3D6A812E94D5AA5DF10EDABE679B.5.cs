using System;
using System.Runtime.CompilerServices;

// Token: 0x02000B02 RID: 2818
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
internal class <WheelTowerSeasonRewardView>FBBF3D6A812E94D5AA5DF10EDABE679BF50A994B28144B2AF50A6ACDB52EB89EF__TaskGridData : MultiTemplateGridDataBase<ActivityTaskData, WheelTowerSeasonTaskItem>
{
	// Token: 0x06007417 RID: 29719 RVA: 0x0023E231 File Offset: 0x0023C431
	public <WheelTowerSeasonRewardView>FBBF3D6A812E94D5AA5DF10EDABE679BF50A994B28144B2AF50A6ACDB52EB89EF__TaskGridData(ActivityTaskData data, Action onClickToGet)
	{
		base.Data = data;
		this.OnClickToGet = onClickToGet;
	}

	// Token: 0x06007418 RID: 29720 RVA: 0x0023E247 File Offset: 0x0023C447
	public override int GetTemplateIndex()
	{
		return 1;
	}

	// Token: 0x06007419 RID: 29721 RVA: 0x0023E24A File Offset: 0x0023C44A
	public override WheelTowerSeasonTaskItem CreateProxy()
	{
		return new WheelTowerSeasonTaskItem
		{
			OnClickToGet = this.OnClickToGet
		};
	}

	// Token: 0x040049A4 RID: 18852
	private readonly Action OnClickToGet;
}
