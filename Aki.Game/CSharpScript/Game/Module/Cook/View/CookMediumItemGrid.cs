using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;

namespace CSharpScript.Game.Module.Cook.View
{
	// Token: 0x02004AFB RID: 19195
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CookMediumItemGrid : LoopScrollMediumItemGrid<ICookItemData>
	{
		// Token: 0x06030012 RID: 196626 RVA: 0x00D63FD9 File Offset: 0x00D621D9
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x06030013 RID: 196627 RVA: 0x00D63FEC File Offset: 0x00D621EC
		protected override void OnBeforeDestroy()
		{
			this.SequencePlayer.Clear();
			this.SequencePlayer = null;
		}

		// Token: 0x06030014 RID: 196628 RVA: 0x00D64000 File Offset: 0x00D62200
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true, false);
		}

		// Token: 0x06030015 RID: 196629 RVA: 0x00D6400A File Offset: 0x00D6220A
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, false);
		}

		// Token: 0x06030016 RID: 196630 RVA: 0x00D64014 File Offset: 0x00D62214
		protected override void OnRefresh(ICookItemData data, bool isSelected, int gridIndex)
		{
			ICookingData cookingData = data as ICookingData;
			if (cookingData != null)
			{
				this.SetSelected(isSelected, false);
				int itemId = data.ItemId;
				PropMediumItemGrid propMediumItemGrid = new PropMediumItemGrid
				{
					Data = data,
					IsNewVisible = new bool?(data.IsNew),
					IsProhibit = new bool?(!data.IsUnLock),
					IsOmitBottomText = new bool?(true)
				};
				ECookListType mainType = data.MainType;
				if (mainType == ECookListType.Machining)
				{
					int finalItemId = CookConfig.Instance.GetCookProcessedById(itemId).FinalItemId;
					CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(finalItemId);
					if (itemConfigData == null)
					{
						return;
					}
					bool flag = CookController.Instance.CheckCanProcessed(itemId) && data.IsUnLock;
					propMediumItemGrid.IsDisable = new bool?(data.IsUnLock && !flag);
					propMediumItemGrid.BottomTextId = itemConfigData.Name;
					propMediumItemGrid.ItemConfigId = new int?(finalItemId);
					propMediumItemGrid.StarLevel = new int?(itemConfigData.QualityId);
				}
				if (mainType == ECookListType.Cooking)
				{
					CookFormula cookFormulaById = CookConfig.Instance.GetCookFormulaById(itemId);
					int foodItemId = cookFormulaById.FoodItemId;
					CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData2 = InventoryConfig.Instance.GetItemConfigData(foodItemId);
					if (itemConfigData2 == null)
					{
						return;
					}
					bool flag2 = CookController.Instance.CheckCanCook(itemId) && data.IsUnLock;
					propMediumItemGrid.IsDisable = new bool?(data.IsUnLock && !flag2);
					propMediumItemGrid.BottomTextId = itemConfigData2.Name;
					propMediumItemGrid.ItemConfigId = new int?(cookFormulaById.FoodItemId);
					propMediumItemGrid.StarLevel = new int?(itemConfigData2.QualityId);
					propMediumItemGrid.IsTimeFlagVisible = new bool?(cookingData.ExistEndTime > 0.0);
				}
				base.Apply<PropMediumItemGrid>(propMediumItemGrid);
				return;
			}
			if (data is IMachiningData)
			{
				this.SetSelected(isSelected, false);
				int itemId2 = data.ItemId;
				PropMediumItemGrid propMediumItemGrid2 = new PropMediumItemGrid
				{
					Data = data,
					IsNewVisible = new bool?(data.IsNew),
					IsProhibit = new bool?(!data.IsUnLock),
					IsOmitBottomText = new bool?(true)
				};
				if (data.MainType == ECookListType.Machining)
				{
					int finalItemId2 = CookConfig.Instance.GetCookProcessedById(itemId2).FinalItemId;
					ItemInfo? config = CSharpScript.Game.Module.Item.ItemConfig.Instance.GetConfig(finalItemId2);
					if (config == null)
					{
						return;
					}
					bool flag3 = CookController.Instance.CheckCanProcessed(itemId2) && data.IsUnLock;
					propMediumItemGrid2.IsDisable = new bool?(data.IsUnLock && !flag3);
					propMediumItemGrid2.BottomTextId = config.Value.Name;
					propMediumItemGrid2.ItemConfigId = new int?(finalItemId2);
					propMediumItemGrid2.StarLevel = new int?(config.Value.QualityId);
				}
				base.Apply<PropMediumItemGrid>(propMediumItemGrid2);
			}
		}

		// Token: 0x04019776 RID: 104310
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;
	}
}
