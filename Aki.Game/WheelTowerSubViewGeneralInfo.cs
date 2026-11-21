using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000B0A RID: 2826
internal sealed class WheelTowerSubViewGeneralInfo : ActivitySubViewGeneralInfo
{
	// Token: 0x0600744E RID: 29774 RVA: 0x0023F640 File Offset: 0x0023D840
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
