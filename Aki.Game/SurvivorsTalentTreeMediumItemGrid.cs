using System;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020020CA RID: 8394
public class SurvivorsTalentTreeMediumItemGrid : LoopScrollMediumItemGrid<int>
{
	// Token: 0x06014A32 RID: 84530 RVA: 0x00603A30 File Offset: 0x00601C30
	protected override void OnRefresh(int itemId, bool isSelected, int gridIndex)
	{
		SurvivorsItem? itemConfig = SurvivorsRogueConfig.Instance.GetSurvivorsItem(itemId);
		if (itemConfig == null)
		{
			return;
		}
		PropMediumItemGrid parameters = new PropMediumItemGrid
		{
			BottomTextId = itemConfig.Value.Name,
			IconPath = itemConfig.Value.Icon,
			QualityId = new int?(itemConfig.Value.Quality)
		};
		base.Apply<PropMediumItemGrid>(parameters);
		base.BindOnExtendToggleClicked(delegate(MediumItemGridExtendCallback callbackParameter)
		{
			SurvivorsRogueItemCard param = new SurvivorsRogueItemCard
			{
				Type = ESurvivorsRogueItemType.Normal,
				Id = itemId,
				Index = gridIndex,
				QualityId = itemConfig.Value.Quality,
				TitleId = itemConfig.Value.Name,
				DescId = itemConfig.Value.Desc,
				UseToggle = new bool?(false),
				IsLevelUp = new bool?(false)
			};
			UiManager.Instance.OpenView(EUiViewName.SurvivorsCardTips, param, null);
		});
		base.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
	}
}
