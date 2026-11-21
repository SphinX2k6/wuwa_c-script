using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001CF7 RID: 7415
public class RoleTowerRewardBottomPanel : UiPanelBase
{
	// Token: 0x060125C4 RID: 75204 RVA: 0x0056BAE4 File Offset: 0x00569CE4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUISprite))
		};
	}

	// Token: 0x060125C5 RID: 75205 RVA: 0x0056BB54 File Offset: 0x00569D54
	protected override void OnStart()
	{
		this.GiftLayout = new GenericLayout<RoleTowerScoreGiftItem, RoleTowerScoreGiftData>(base.GetHorizontalLayout(1), () => new RoleTowerScoreGiftItem(), base.GetItem(2).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x060125C6 RID: 75206 RVA: 0x0056BBA8 File Offset: 0x00569DA8
	public void Refresh()
	{
		int curScore = RoleTowerModel.Instance.GetCurScore();
		UUIText text = base.GetText(0);
		if (text != null)
		{
			text.SetText(curScore.ToString(), true);
		}
		List<RoleTowerScoreReward> sortedScoreRewardCfgList = RoleTowerModel.Instance.GetSortedScoreRewardCfgList();
		List<RoleTowerScoreGiftData> list = new List<RoleTowerScoreGiftData>();
		foreach (RoleTowerScoreReward roleTowerScoreReward in sortedScoreRewardCfgList)
		{
			list.Add(new RoleTowerScoreGiftData
			{
				ScoreRewardId = roleTowerScoreReward.Id
			});
		}
		GenericLayout<RoleTowerScoreGiftItem, RoleTowerScoreGiftData> giftLayout = this.GiftLayout;
		if (giftLayout != null)
		{
			giftLayout.RefreshByData(list, null, false);
		}
		this.RefreshProgressBar(curScore, sortedScoreRewardCfgList);
	}

	// Token: 0x060125C7 RID: 75207 RVA: 0x0056BC5C File Offset: 0x00569E5C
	[NullableContext(1)]
	private void RefreshProgressBar(int curScore, IReadOnlyList<RoleTowerScoreReward> scoreRewards)
	{
		UUISprite sprite = base.GetSprite(3);
		if (sprite == null)
		{
			return;
		}
		List<int> list = new List<int>();
		foreach (RoleTowerScoreReward roleTowerScoreReward in scoreRewards)
		{
			list.Add(roleTowerScoreReward.NeedScore);
		}
		int count = list.Count;
		if (count == 0)
		{
			sprite.SetFillAmount(0f);
			return;
		}
		int num = 0;
		while (num < count && curScore >= list[num])
		{
			num++;
		}
		float fillAmount;
		if (num >= count)
		{
			fillAmount = 1f;
		}
		else
		{
			int num2 = (num == 0) ? 0 : list[num - 1];
			int num3 = list[num];
			float num4 = (num3 > num2) ? ((float)(curScore - num2) / (float)(num3 - num2)) : 0f;
			fillAmount = ((float)num + num4) / (float)count;
		}
		sprite.SetFillAmount(fillAmount);
	}

	// Token: 0x0400A00C RID: 40972
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleTowerScoreGiftItem, RoleTowerScoreGiftData> GiftLayout;

	// Token: 0x02008015 RID: 32789
	private static class EChildType
	{
		// Token: 0x04029715 RID: 169749
		public const int TxtNum = 0;

		// Token: 0x04029716 RID: 169750
		public const int PnlHLayout = 1;

		// Token: 0x04029717 RID: 169751
		public const int PnlGift = 2;

		// Token: 0x04029718 RID: 169752
		public const int SprBarFill = 3;
	}
}
