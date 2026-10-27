using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001358 RID: 4952
public class PopularityModule : UiPanelBase
{
	// Token: 0x060089EB RID: 35307 RVA: 0x001D7814 File Offset: 0x001D5A14
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUISprite))
		};
	}

	// Token: 0x060089EC RID: 35308 RVA: 0x001D786E File Offset: 0x001D5A6E
	protected override void OnBeforeShow()
	{
		this.RefreshPopularity();
	}

	// Token: 0x060089ED RID: 35309 RVA: 0x001D7878 File Offset: 0x001D5A78
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

	// Token: 0x020079BE RID: 31166
	private static class EComponentDefine
	{
		// Token: 0x04028147 RID: 164167
		public const int RatingText = 0;

		// Token: 0x04028148 RID: 164168
		public const int ValueText = 1;

		// Token: 0x04028149 RID: 164169
		public const int Progress = 2;
	}
}
