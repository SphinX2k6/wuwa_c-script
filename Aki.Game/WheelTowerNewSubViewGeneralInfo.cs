using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000ADB RID: 2779
internal sealed class WheelTowerNewSubViewGeneralInfo : ActivitySubViewGeneralInfo
{
	// Token: 0x06007364 RID: 29540 RVA: 0x0023A057 File Offset: 0x00238257
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
