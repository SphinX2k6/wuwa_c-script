using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.Manufacture.Forging.View
{
	// Token: 0x02005652 RID: 22098
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ForgingMediumItemGrid : LoopScrollMediumItemGrid<IWeaponForgingData>
	{
		// Token: 0x060382F0 RID: 230128 RVA: 0x00D4FA57 File Offset: 0x00D4DC57
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true, false);
		}

		// Token: 0x060382F1 RID: 230129 RVA: 0x00D4FA61 File Offset: 0x00D4DC61
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, false);
		}

		// Token: 0x060382F2 RID: 230130 RVA: 0x00D4FA6C File Offset: 0x00D4DC6C
		protected override void OnRefresh(IWeaponForgingData data, bool isSelected, int gridIndex)
		{
			int itemId = data.ItemId;
			int itemId2 = ForgingConfig.Instance.GetForgeFormulaById(itemId).Value.ItemId;
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId2);
			if (itemConfigData == null)
			{
				return;
			}
			int isUnlock = data.IsUnlock;
			bool flag;
			if (isUnlock > 0)
			{
				flag = ForgingController.Instance.CheckCanForging(itemId);
			}
			else
			{
				flag = ForgingController.Instance.CheckCanUnlock(itemId);
			}
			PropMediumItemGrid parameters = new PropMediumItemGrid
			{
				Data = data,
				ItemConfigId = new int?(itemId2),
				BottomTextId = itemConfigData.Name,
				IsProhibit = new bool?(isUnlock == 0),
				IsNewVisible = new bool?(data.IsNew),
				IsDisable = new bool?(isUnlock > 0 && !flag),
				IsRedDotVisible = new bool?(flag && data.IsUnlock == 0),
				StarLevel = new int?(itemConfigData.QualityId),
				IsOmitBottomText = new bool?(true),
				IsTimeFlagVisible = new bool?(data.ExistEndTime > 0.0)
			};
			base.Apply<PropMediumItemGrid>(parameters);
			this.SetSelected(isSelected, false);
		}
	}
}
