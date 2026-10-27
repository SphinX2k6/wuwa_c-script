using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.SceneGameplayPanel
{
	// Token: 0x020047F3 RID: 18419
	public class SceneGameplayTipGridMonster : SceneGameplayTipGrid
	{
		// Token: 0x060303EC RID: 197612 RVA: 0x00B302F8 File Offset: 0x00B2E4F8
		[NullableContext(1)]
		protected override void OnRefreshItemGrid(CommonItemSmallItemGrid grid, int itemId, int itemCount, bool showGet = false)
		{
			PhantomItem? phantomItemById = PhantomBattleConfig.Instance.GetPhantomItemById(itemId);
			PropSmallItemGrid parameters = new PropSmallItemGrid
			{
				Data = itemId,
				IconPath = phantomItemById.Value.Icon
			};
			grid.ApplyPropSmallItemGrid(parameters);
			grid.SetAllowClickBack(false);
			UUIExtendToggle itemGridExtendToggle = grid.GetItemGridExtendToggle();
			if (itemGridExtendToggle == null)
			{
				return;
			}
			itemGridExtendToggle.SetToggleStateForce(EToggleState.ETT_UnDetermined, false, false, false);
		}
	}
}
