using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x020048F0 RID: 18672
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrMaterialsDeliveryConsumeItem : LoopScrollMediumItemGrid<TItem>
	{
		// Token: 0x0602EDCD RID: 191949 RVA: 0x00D11C4C File Offset: 0x00D0FE4C
		protected override void OnRefresh(TItem data, bool isSelected, int gridIndex)
		{
			this.ItemId = data.ItemData.ItemId;
			CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(this.ItemId);
			if (itemConfigData == null)
			{
				return;
			}
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(this.ItemId, 0);
			string bottomText;
			if (itemCountByConfigId < data.Count)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
				defaultInterpolatedStringHandler.AppendLiteral("<color=#9d2437>");
				defaultInterpolatedStringHandler.AppendFormatted<int>(itemCountByConfigId);
				defaultInterpolatedStringHandler.AppendLiteral("</color>/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(data.Count);
				bottomText = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
				defaultInterpolatedStringHandler.AppendLiteral("<color=#ffd12f>");
				defaultInterpolatedStringHandler.AppendFormatted<int>(itemCountByConfigId);
				defaultInterpolatedStringHandler.AppendLiteral("</color>/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(data.Count);
				bottomText = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			PropMediumItemGrid parameters = new PropMediumItemGrid
			{
				Data = data,
				IsOmitBottomText = new bool?(true),
				BottomText = bottomText,
				ItemConfigId = new int?(this.ItemId),
				StarLevel = new int?(itemConfigData.QualityId)
			};
			base.Apply<PropMediumItemGrid>(parameters);
		}

		// Token: 0x0602EDCE RID: 191950 RVA: 0x00D11D6E File Offset: 0x00D0FF6E
		protected override bool OnCanExecuteChange()
		{
			return false;
		}

		// Token: 0x0602EDCF RID: 191951 RVA: 0x00D11D71 File Offset: 0x00D0FF71
		protected override void OnExtendToggleClicked()
		{
			ItemController.Instance.OpenItemTipsByItemId(this.ItemId, true, null, false);
		}

		// Token: 0x04018DD3 RID: 101843
		public Func<int, int> GetRolePositionFunc;

		// Token: 0x04018DD4 RID: 101844
		public Func<int, bool> IsHighlightIndex;

		// Token: 0x04018DD5 RID: 101845
		private int ItemId;
	}
}
