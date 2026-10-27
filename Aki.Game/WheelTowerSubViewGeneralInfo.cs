using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001652 RID: 5714
internal sealed class WheelTowerSubViewGeneralInfo : ActivitySubViewGeneralInfo
{
	// Token: 0x0600A070 RID: 41072 RVA: 0x00235804 File Offset: 0x00233A04
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	protected override ValueTuple<bool, string, long> GetTimeVisibleAndRemainTime()
	{
		return ActivityModel.Instance.GetTimeVisibleAndRemainTime(this.ActivityBaseData, ConfigMultiTextLang.GetLocalTextNew("WheelTower_ActivityLimitTimeText", null) ?? string.Empty);
	}
}
