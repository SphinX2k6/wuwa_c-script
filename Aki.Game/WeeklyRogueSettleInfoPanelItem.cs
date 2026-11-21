using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200229B RID: 8859
public class WeeklyRogueSettleInfoPanelItem : GridProxyAbstract<WeeklyRogueSettleInfoItemData>
{
	// Token: 0x06015E2E RID: 89646 RVA: 0x0065885C File Offset: 0x00656A5C
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

	// Token: 0x06015E2F RID: 89647 RVA: 0x006588E4 File Offset: 0x00656AE4
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

	// Token: 0x020084F6 RID: 34038
	private enum EWeeklyRogueSettleInfoPanelItemDefine
	{
		// Token: 0x0402ADBA RID: 175546
		SpriteBg,
		// Token: 0x0402ADBB RID: 175547
		TxtTitle,
		// Token: 0x0402ADBC RID: 175548
		TxtContent,
		// Token: 0x0402ADBD RID: 175549
		ScoreUpItem,
		// Token: 0x0402ADBE RID: 175550
		TxtScoreUp
	}
}
