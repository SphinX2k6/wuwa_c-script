using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;

namespace CSharpScript.Game.Module.Manufacture.Common.Item
{
	// Token: 0x020056A1 RID: 22177
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ManufactureMaterialItem : LoopScrollMediumItemGrid<ISingleItemInfo>
	{
		// Token: 0x060386E0 RID: 231136 RVA: 0x00D65CA4 File Offset: 0x00D63EA4
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

		// Token: 0x060386E1 RID: 231137 RVA: 0x00D65D4C File Offset: 0x00D63F4C
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

		// Token: 0x060386E2 RID: 231138 RVA: 0x00D65E18 File Offset: 0x00D64018
		public void SetTimes(int times)
		{
			this.Times = times;
			base.SetBottomText(this.GetBottomShowText(null));
		}

		// Token: 0x060386E3 RID: 231139 RVA: 0x00D65E41 File Offset: 0x00D64041
		public void SetNeedNum(int needNum)
		{
			base.SetBottomText(this.GetBottomShowText(new int?(needNum)));
		}

		// Token: 0x060386E4 RID: 231140 RVA: 0x00D65E55 File Offset: 0x00D64055
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true, false);
		}

		// Token: 0x060386E5 RID: 231141 RVA: 0x00D65E5F File Offset: 0x00D6405F
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, false);
		}

		// Token: 0x0401DA30 RID: 121392
		[Nullable(2)]
		private ISingleItemInfo ItemData;

		// Token: 0x0401DA31 RID: 121393
		private int Times;
	}
}
