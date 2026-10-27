using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002AE7 RID: 10983
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueCommandRewardSelect : SurvivorsRogueCommandBaseObtain
{
	// Token: 0x06016DAF RID: 93615 RVA: 0x005CCF48 File Offset: 0x005CB148
	public SurvivorsRogueCommandRewardSelect(ESurvivorsRogueCommandType type) : base(type)
	{
	}

	// Token: 0x06016DB0 RID: 93616 RVA: 0x005CCF54 File Offset: 0x005CB154
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
		defaultInterpolatedStringHandler.AppendLiteral("[RewardSelect] Count: ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.GetSurvivorsOption().GoodsDetails.Count);
		defaultInterpolatedStringHandler.AppendLiteral(" ");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06016DB1 RID: 93617 RVA: 0x005CCFA1 File Offset: 0x005CB1A1
	private SurvivorsOption GetSurvivorsOption()
	{
		return this.Data.TokenSelectView.SurvivorsOption;
	}

	// Token: 0x06016DB2 RID: 93618 RVA: 0x005CCFB4 File Offset: 0x005CB1B4
	[NullableContext(2)]
	public override ISurvivorsObtainViewInfo GetViewInfo()
	{
		SurvivorsOption survivorsOption = this.GetSurvivorsOption();
		return new SurvivorsObtainViewInfo
		{
			CaptionId = "SurvivorPropSelection_ScreenName",
			TitleId = "SurvivorsNewProp_Title",
			ButtonId = "SurvivorsNewProp_ConfirtButton",
			ChooseData = base.GetChooseData(survivorsOption, new ESurvivorsObtainMode?(ESurvivorsObtainMode.SingleSelect)),
			GoodsList = survivorsOption.GoodsDetails
		};
	}
}
