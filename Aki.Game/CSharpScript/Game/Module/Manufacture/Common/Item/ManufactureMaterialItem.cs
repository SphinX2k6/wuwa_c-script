using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;

namespace CSharpScript.Game.Module.Manufacture.Common.Item
{
	// Token: 0x02004677 RID: 18039
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ManufactureMaterialItem : LoopScrollMediumItemGrid<ISingleItemInfo>
	{
		// Token: 0x0602D5DD RID: 185821 RVA: 0x00CB3DF4 File Offset: 0x00CB1FF4
		protected override void OnRefresh(ISingleItemInfo data, bool isSelected, int gridIndex)
		{
			this.ItemData = data;
			if (data.IsEmpty != null && data.IsEmpty.Value)
			{
				EmptyItemGrid parameters = new EmptyItemGrid();
				base.Apply<EmptyItemGrid>(parameters);
				this.SetSelected(false, false);
				return;
			}
			PropMediumItemGrid propMediumItemGrid = new PropMediumItemGrid
			{
				Data = data,
				BottomText = this.GetBottomShowText(null)
			};
			if (data.Proto_IsUnlock)
			{
				propMediumItemGrid.ItemConfigId = new int?(data.Proto_ItemId);
			}
			base.Apply<PropMediumItemGrid>(propMediumItemGrid);
			base.SetIsPhantomLock(new bool?(!data.Proto_IsUnlock));
			this.SetSelected(false, false);
		}

		// Token: 0x0602D5DE RID: 185822 RVA: 0x00CB3E9C File Offset: 0x00CB209C
		private string GetBottomShowText(int? need = null)
		{
			if (this.ItemData == null)
			{
				return string.Empty;
			}
			if (this.ItemData.Proto_IsUnlock)
			{
				int num = need ?? (this.ItemData.Proto_ItemNum * this.Times);
				int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(this.ItemData.Proto_ItemId, 0);
				string result = string.Empty;
				if (itemCountByConfigId < num)
				{
					result = StringUtils.Format("<color=#f55e66>{0}</color>/{1}", new string[]
					{
						itemCountByConfigId.ToString(),
						num.ToString()
					});
				}
				else
				{
					result = StringUtils.Format("<color=#f7eba6>{0}</color>/{1}", new string[]
					{
						itemCountByConfigId.ToString(),
						num.ToString()
					});
				}
				return result;
			}
			return ConfigMultiTextLang.GetLocalTextNew("Text_ItemSelectCookUnlock_text", null);
		}

		// Token: 0x0602D5DF RID: 185823 RVA: 0x00CB3F68 File Offset: 0x00CB2168
		public void SetTimes(int times)
		{
			this.Times = times;
			base.SetBottomText(this.GetBottomShowText(null));
		}

		// Token: 0x0602D5E0 RID: 185824 RVA: 0x00CB3F91 File Offset: 0x00CB2191
		public void SetNeedNum(int needNum)
		{
			base.SetBottomText(this.GetBottomShowText(new int?(needNum)));
		}

		// Token: 0x0602D5E1 RID: 185825 RVA: 0x00CB3FA5 File Offset: 0x00CB21A5
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true, false);
		}

		// Token: 0x0602D5E2 RID: 185826 RVA: 0x00CB3FAF File Offset: 0x00CB21AF
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, false);
		}

		// Token: 0x040184BB RID: 99515
		[Nullable(2)]
		private ISingleItemInfo ItemData;

		// Token: 0x040184BC RID: 99516
		private int Times;
	}
}
