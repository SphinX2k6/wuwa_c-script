using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020010C6 RID: 4294
public class AdvanceNoticeData : ActivityBaseData
{
	// Token: 0x06006FFC RID: 28668 RVA: 0x0016CBE4 File Offset: 0x0016ADE4
	[NullableContext(1)]
	protected override void PhraseEx(ActivityData data)
	{
		AdvertisingPageData advertisingPageInfo = data.AdvertisingPageInfo;
		if (advertisingPageInfo == null)
		{
			this.IsShow = false;
			this.UnlockTimeStamp = 0L;
			return;
		}
		this.IsShow = advertisingPageInfo.Show;
		this.UnlockTimeStamp = MathUtils.Instance.LongToNumber(advertisingPageInfo.PointTime);
	}

	// Token: 0x06006FFD RID: 28669 RVA: 0x0016CC2D File Offset: 0x0016AE2D
	public bool GetIsShow()
	{
		return this.IsShow;
	}

	// Token: 0x06006FFE RID: 28670 RVA: 0x0016CC35 File Offset: 0x0016AE35
	public void SetIsShow(bool isShow)
	{
		this.IsShow = isShow;
	}

	// Token: 0x06006FFF RID: 28671 RVA: 0x0016CC3E File Offset: 0x0016AE3E
	public override bool CheckIfInShowTime()
	{
		if (!AdvanceNoticeData.DebugFlag)
		{
			return this.IsShow && base.CheckIfInShowTime();
		}
		return base.CheckIfInShowTime();
	}

	// Token: 0x06007000 RID: 28672 RVA: 0x0016CC5E File Offset: 0x0016AE5E
	public long GetUnlockTimeStamp()
	{
		return this.UnlockTimeStamp;
	}

	// Token: 0x040033F1 RID: 13297
	[StaticVariableRuleIgnore]
	public static bool DebugFlag;

	// Token: 0x040033F2 RID: 13298
	private bool IsShow;

	// Token: 0x040033F3 RID: 13299
	private long UnlockTimeStamp;
}
