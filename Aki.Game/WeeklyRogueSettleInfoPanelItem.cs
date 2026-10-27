using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002D41 RID: 11585
public class WeeklyRogueSettleInfoPanelItem : GridProxyAbstract<WeeklyRogueSettleInfoItemData>
{
	// Token: 0x0601858C RID: 99724 RVA: 0x0063284C File Offset: 0x00630A4C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText))
		};
	}

	// Token: 0x0601858D RID: 99725 RVA: 0x006328D4 File Offset: 0x00630AD4
	public override void Refresh(WeeklyRogueSettleInfoItemData data, bool isSelected, int gridIndex)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Title, Array.Empty<object>());
		base.GetText(2).SetText(data.Content, true);
		if (data.IsScoreUp)
		{
			WeeklyRogueData activityDataNew = WeeklyRogueModel.Instance.ActivityDataNew;
			if (activityDataNew == null)
			{
				return;
			}
			if (activityDataNew.GetCycleConfig() == null)
			{
				return;
			}
			int scoreRate = activityDataNew.GetScoreRate();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "WeRougeFormationIntegralMultiplier", new <>z__ReadOnlySingleElementList<object>(scoreRate));
		}
		UUIItem item = base.GetItem(3);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(data.IsScoreUp);
	}

	// Token: 0x020092CF RID: 37583
	private enum EWeeklyRogueSettleInfoPanelItemDefine
	{
		// Token: 0x0402F732 RID: 194354
		SpriteBg,
		// Token: 0x0402F733 RID: 194355
		TxtTitle,
		// Token: 0x0402F734 RID: 194356
		TxtContent,
		// Token: 0x0402F735 RID: 194357
		ScoreUpItem,
		// Token: 0x0402F736 RID: 194358
		TxtScoreUp
	}
}
