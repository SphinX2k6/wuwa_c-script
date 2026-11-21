using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200080C RID: 2060
public class PopularityModule : UiPanelBase
{
	// Token: 0x06005D86 RID: 23942 RVA: 0x001E0678 File Offset: 0x001DE878
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUISprite))
		};
	}

	// Token: 0x06005D87 RID: 23943 RVA: 0x001E06D2 File Offset: 0x001DE8D2
	protected override void OnBeforeShow()
	{
		this.RefreshPopularity();
	}

	// Token: 0x06005D88 RID: 23944 RVA: 0x001E06DC File Offset: 0x001DE8DC
	public void RefreshPopularity()
	{
		Popularity currentPopularityConfig = MoonChasingBusinessModel.Instance.GetCurrentPopularityConfig();
		int popularityValue = MoonChasingModel.Instance.GetPopularityValue();
		UUIText text = base.GetText(1);
		if (text != null)
		{
			text.SetText("<color=#ffd52b>" + popularityValue.ToString() + "</color>/" + currentPopularityConfig.PopularityValue.ToString(), true);
		}
		base.GetSprite(2).SetFillAmount((currentPopularityConfig.PopularityValue > 0) ? ((float)popularityValue / (float)currentPopularityConfig.PopularityValue) : 0f);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), currentPopularityConfig.PopularityRating, Array.Empty<object>());
	}

	// Token: 0x02006B48 RID: 27464
	private static class EComponentDefine
	{
		// Token: 0x04023474 RID: 144500
		public const int RatingText = 0;

		// Token: 0x04023475 RID: 144501
		public const int ValueText = 1;

		// Token: 0x04023476 RID: 144502
		public const int Progress = 2;
	}
}
