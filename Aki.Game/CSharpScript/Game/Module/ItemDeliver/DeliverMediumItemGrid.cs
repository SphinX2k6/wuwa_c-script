using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;

namespace CSharpScript.Game.Module.ItemDeliver
{
	// Token: 0x0200581A RID: 22554
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DeliverMediumItemGrid : LoopScrollMediumItemGrid<DeliverSlotData>
	{
		// Token: 0x060394FF RID: 234751 RVA: 0x00D9788C File Offset: 0x00D95A8C
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

		// Token: 0x06039500 RID: 234752 RVA: 0x00D979BF File Offset: 0x00D95BBF
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true, false);
		}

		// Token: 0x06039501 RID: 234753 RVA: 0x00D979C9 File Offset: 0x00D95BC9
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, false);
		}

		// Token: 0x06039502 RID: 234754 RVA: 0x00D979D3 File Offset: 0x00D95BD3
		protected override bool OnCanExecuteChange()
		{
			return false;
		}

		// Token: 0x06039503 RID: 234755 RVA: 0x00D979D8 File Offset: 0x00D95BD8
		protected override void OnExtendToggleClicked()
		{
			DeliverSlotData deliverSlotData = this.Data as DeliverSlotData;
			if (!deliverSlotData.HasItem())
			{
				return;
			}
			ItemController.Instance.OpenItemTipsByItemId(deliverSlotData.GetCurrentItemConfigId(), true, null);
		}
	}
}
