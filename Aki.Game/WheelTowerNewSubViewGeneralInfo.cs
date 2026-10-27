using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001623 RID: 5667
internal sealed class WheelTowerNewSubViewGeneralInfo : ActivitySubViewGeneralInfo
{
	// Token: 0x06009F86 RID: 40838 RVA: 0x0023020B File Offset: 0x0022E40B
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
