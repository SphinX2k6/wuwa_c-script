using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Manufacture.Common;

namespace CSharpScript.Game.Module.Manufacture.Compose.View
{
	// Token: 0x02004645 RID: 17989
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ComposeExchangeItem : LoopScrollMediumItemGrid<ISingleItemInfo>
	{
		// Token: 0x0602D3BD RID: 185277 RVA: 0x00CA82A8 File Offset: 0x00CA64A8
		protected override void OnRefresh(ISingleItemInfo data, bool isSelected, int gridIndex)
		{
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(data.Proto_ItemId, 0);
			int currentExchangeConsume = ComposeModel.Instance.CurrentExchangeConsume;
			int num = (currentExchangeConsume > 0) ? currentExchangeConsume : 2;
			string bottomText;
			if (itemCountByConfigId < num)
			{
				bottomText = StringUtils.Format("<color=#dc0300>{0}</color>", new string[]
				{
					itemCountByConfigId.ToString()
				});
			}
			else
			{
				bottomText = StringUtils.Format("<color=#ffffff>{0}</color>", new string[]
				{
					itemCountByConfigId.ToString()
				});
			}
			PropMediumItemGrid propMediumItemGrid = new PropMediumItemGrid
			{
				Data = data,
				BottomText = bottomText,
				IsDisable = new bool?(itemCountByConfigId < num)
			};
			if (data.Proto_IsUnlock)
			{
				propMediumItemGrid.ItemConfigId = new int?(data.Proto_ItemId);
			}
			base.Apply<PropMediumItemGrid>(propMediumItemGrid);
			base.SetIsPhantomLock(new bool?(!data.Proto_IsUnlock));
			this.SetSelected(false, false);
		}

		// Token: 0x0602D3BE RID: 185278 RVA: 0x00CA837F File Offset: 0x00CA657F
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true, false);
		}

		// Token: 0x0602D3BF RID: 185279 RVA: 0x00CA8389 File Offset: 0x00CA6589
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, false);
		}
	}
}
