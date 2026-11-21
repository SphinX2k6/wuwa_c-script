using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;

namespace CSharpScript.Game.Module.ItemDeliver
{
	// Token: 0x020047F1 RID: 18417
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DeliverMediumItemGrid : LoopScrollMediumItemGrid<DeliverSlotData>
	{
		// Token: 0x0602E413 RID: 189459 RVA: 0x00CE671C File Offset: 0x00CE491C
		protected override void OnRefresh(DeliverSlotData data, bool isSelected, int gridIndex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			if (data.HasItem())
			{
				int needCount = data.GetNeedCount();
				int currentCount = data.GetCurrentCount();
				PropMediumItemGrid propMediumItemGrid = new PropMediumItemGrid
				{
					Data = data,
					ItemConfigId = new int?(data.GetCurrentItemConfigId())
				};
				if (data.GetItemRangeList().Count > 1)
				{
					propMediumItemGrid.ReduceButtonInfo = new LongPressButton
					{
						IsVisible = new bool?(currentCount > 0),
						LongPressConfigId = new LongPressButtonItem.ELongPressConfigId?(LongPressButtonItem.ELongPressConfigId.LongPressOne)
					};
				}
				if (currentCount < needCount)
				{
					propMediumItemGrid.BottomTextId = "DeliverSlotCountNotEnough";
					propMediumItemGrid.BottomTextParameter = new object[]
					{
						currentCount,
						needCount
					};
				}
				else
				{
					MediumItemGridBase mediumItemGridBase = propMediumItemGrid;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
					defaultInterpolatedStringHandler.AppendFormatted<int>(currentCount);
					defaultInterpolatedStringHandler.AppendLiteral("/");
					defaultInterpolatedStringHandler.AppendFormatted<int>(needCount);
					mediumItemGridBase.BottomText = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				base.Apply<PropMediumItemGrid>(propMediumItemGrid);
				return;
			}
			EmptyItemGrid emptyItemGrid = new EmptyItemGrid();
			emptyItemGrid.Data = data;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.GetCurrentCount());
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.GetNeedCount());
			emptyItemGrid.BottomText = defaultInterpolatedStringHandler.ToStringAndClear();
			EmptyItemGrid parameters = emptyItemGrid;
			base.Apply<EmptyItemGrid>(parameters);
		}

		// Token: 0x0602E414 RID: 189460 RVA: 0x00CE684F File Offset: 0x00CE4A4F
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true, false);
		}

		// Token: 0x0602E415 RID: 189461 RVA: 0x00CE6859 File Offset: 0x00CE4A59
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, false);
		}

		// Token: 0x0602E416 RID: 189462 RVA: 0x00CE6863 File Offset: 0x00CE4A63
		protected override bool OnCanExecuteChange()
		{
			return false;
		}

		// Token: 0x0602E417 RID: 189463 RVA: 0x00CE6868 File Offset: 0x00CE4A68
		protected override void OnExtendToggleClicked()
		{
			DeliverSlotData deliverSlotData = this.Data as DeliverSlotData;
			if (!deliverSlotData.HasItem())
			{
				return;
			}
			ItemController.Instance.OpenItemTipsByItemId(deliverSlotData.GetCurrentItemConfigId(), true, null, false);
		}
	}
}
