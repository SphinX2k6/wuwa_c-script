using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;

namespace CSharpScript.Game.Module.Giant
{
	// Token: 0x0200596F RID: 22895
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class GiantCollectItemGrid : LoopScrollMediumItemGrid<GiantCollectItemData>
	{
		// Token: 0x0603A186 RID: 237958 RVA: 0x00DCE5B0 File Offset: 0x00DCC7B0
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

		// Token: 0x0603A187 RID: 237959 RVA: 0x00DCE68D File Offset: 0x00DCC88D
		protected override bool OnCanExecuteChange()
		{
			return false;
		}

		// Token: 0x0603A188 RID: 237960 RVA: 0x00DCE690 File Offset: 0x00DCC890
		protected override void OnExtendToggleClicked()
		{
			Action<int> onClickCallback = this.OnClickCallback;
			if (onClickCallback == null)
			{
				return;
			}
			onClickCallback(this.ItemId);
		}

		// Token: 0x0401E4B5 RID: 124085
		private int ItemId;

		// Token: 0x0401E4B6 RID: 124086
		[Nullable(2)]
		private Action<int> OnClickCallback;
	}
}
