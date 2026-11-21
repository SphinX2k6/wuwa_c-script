using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002063 RID: 8291
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueCommandRewardSelect : SurvivorsRogueCommandBaseObtain
{
	// Token: 0x060147E0 RID: 83936 RVA: 0x005F9A98 File Offset: 0x005F7C98
	public SurvivorsRogueCommandRewardSelect(ESurvivorsRogueCommandType type) : base(type)
	{
	}

	// Token: 0x060147E1 RID: 83937 RVA: 0x005F9AA4 File Offset: 0x005F7CA4
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
		defaultInterpolatedStringHandler.AppendLiteral("[RewardSelect] Count: ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.GetSurvivorsOption().GoodsDetails.Count);
		defaultInterpolatedStringHandler.AppendLiteral(" ");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x060147E2 RID: 83938 RVA: 0x005F9AF1 File Offset: 0x005F7CF1
	private SurvivorsOption GetSurvivorsOption()
	{
		return this.Data.TokenSelectView.SurvivorsOption;
	}

	// Token: 0x060147E3 RID: 83939 RVA: 0x005F9B04 File Offset: 0x005F7D04
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
