using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;

namespace CSharpScript.Game.Module.Giant
{
	// Token: 0x02004948 RID: 18760
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class GiantCollectItemGrid : LoopScrollMediumItemGrid<GiantCollectItemData>
	{
		// Token: 0x0602F0AC RID: 192684 RVA: 0x00D1D838 File Offset: 0x00D1BA38
		protected override void OnRefresh(GiantCollectItemData data, bool isSelected, int gridIndex)
		{
			this.ItemId = data.ItemId;
			this.OnClickCallback = data.OnClick;
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(this.ItemId, 0);
			PropMediumItemGrid propMediumItemGrid = new PropMediumItemGrid();
			propMediumItemGrid.IsOmitBottomText = new bool?(true);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(itemCountByConfigId);
			propMediumItemGrid.BottomText = defaultInterpolatedStringHandler.ToStringAndClear();
			propMediumItemGrid.ItemConfigId = new int?(this.ItemId);
			propMediumItemGrid.StarLevel = new int?(GiantConfig.GetItemQuality(this.ItemId));
			propMediumItemGrid.IsDisable = new bool?(data.IsLocked || data.IsDelivered.GetValueOrDefault());
			propMediumItemGrid.IsLockVisible = new bool?(data.IsLocked);
			propMediumItemGrid.IsCheckTick = new bool?(data.IsDelivered.GetValueOrDefault());
			PropMediumItemGrid parameters = propMediumItemGrid;
			base.Apply<PropMediumItemGrid>(parameters);
		}

		// Token: 0x0602F0AD RID: 192685 RVA: 0x00D1D915 File Offset: 0x00D1BB15
		protected override bool OnCanExecuteChange()
		{
			return false;
		}

		// Token: 0x0602F0AE RID: 192686 RVA: 0x00D1D918 File Offset: 0x00D1BB18
		protected override void OnExtendToggleClicked()
		{
			Action<int> onClickCallback = this.OnClickCallback;
			if (onClickCallback == null)
			{
				return;
			}
			onClickCallback(this.ItemId);
		}

		// Token: 0x04018F53 RID: 102227
		private int ItemId;

		// Token: 0x04018F54 RID: 102228
		[Nullable(2)]
		private Action<int> OnClickCallback;
	}
}
