using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.Manufacture.Forging.View
{
	// Token: 0x02004628 RID: 17960
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ForgingMediumItemGrid : LoopScrollMediumItemGrid<IWeaponForgingData>
	{
		// Token: 0x0602D1EE RID: 184814 RVA: 0x00C9D7E3 File Offset: 0x00C9B9E3
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true, false);
		}

		// Token: 0x0602D1EF RID: 184815 RVA: 0x00C9D7ED File Offset: 0x00C9B9ED
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, false);
		}

		// Token: 0x0602D1F0 RID: 184816 RVA: 0x00C9D7F8 File Offset: 0x00C9B9F8
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
