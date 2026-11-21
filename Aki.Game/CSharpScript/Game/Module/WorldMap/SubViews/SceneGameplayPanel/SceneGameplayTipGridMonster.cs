using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.SceneGameplayPanel
{
	// Token: 0x02003724 RID: 14116
	public class SceneGameplayTipGridMonster : SceneGameplayTipGrid
	{
		// Token: 0x06024BBC RID: 150460 RVA: 0x00A60298 File Offset: 0x00A5E498
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
