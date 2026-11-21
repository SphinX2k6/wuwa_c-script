using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200057A RID: 1402
public class AdvanceNoticeData : ActivityBaseData
{
	// Token: 0x06004392 RID: 17298 RVA: 0x001755A0 File Offset: 0x001737A0
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

	// Token: 0x06004393 RID: 17299 RVA: 0x001755E9 File Offset: 0x001737E9
	public bool GetIsShow()
	{
		return this.IsShow;
	}

	// Token: 0x06004394 RID: 17300 RVA: 0x001755F1 File Offset: 0x001737F1
	public void SetIsShow(bool isShow)
	{
		this.IsShow = isShow;
	}

	// Token: 0x06004395 RID: 17301 RVA: 0x001755FA File Offset: 0x001737FA
	public override bool CheckIfInShowTime()
	{
		if (!AdvanceNoticeData.DebugFlag)
		{
			return this.IsShow && base.CheckIfInShowTime();
		}
		return base.CheckIfInShowTime();
	}

	// Token: 0x06004396 RID: 17302 RVA: 0x0017561A File Offset: 0x0017381A
	public long GetUnlockTimeStamp()
	{
		return this.UnlockTimeStamp;
	}

	// Token: 0x0400348A RID: 13450
	[StaticVariableRuleIgnore]
	public static bool DebugFlag;

	// Token: 0x0400348B RID: 13451
	private bool IsShow;

	// Token: 0x0400348C RID: 13452
	private long UnlockTimeStamp;
}
