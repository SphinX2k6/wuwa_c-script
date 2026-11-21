using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005719 RID: 22297
	public class DangoBrawlBackpackGridData
	{
		// Token: 0x06036E05 RID: 224773 RVA: 0x00F4D64B File Offset: 0x00F4B84B
		public DangoBrawlBackpackGridData(PanelPos panelPos)
		{
			this.PanelPos = panelPos;
		}

		// Token: 0x170069FE RID: 27134
		// (get) Token: 0x06036E06 RID: 224774 RVA: 0x00F4D668 File Offset: 0x00F4B868
		public PanelPos GridPanelPos
		{
			get
			{
				return this.PanelPos;
			}
		}

		// Token: 0x170069FF RID: 27135
		// (get) Token: 0x06036E07 RID: 224775 RVA: 0x00F4D670 File Offset: 0x00F4B870
		public EDangoBrawlGridEquipState GridState
		{
			get
			{
				return this.State;
			}
		}

		// Token: 0x17006A00 RID: 27136
		// (get) Token: 0x06036E08 RID: 224776 RVA: 0x00F4D678 File Offset: 0x00F4B878
		// (set) Token: 0x06036E09 RID: 224777 RVA: 0x00F4D680 File Offset: 0x00F4B880
		public int GridEquipBagId
		{
			get
			{
				return this.EquipBagPackId;
			}
			private set
			{
				if (value == -1)
				{
					this.State &= ~EDangoBrawlGridEquipState.Bag;
				}
				else
				{
					this.State |= EDangoBrawlGridEquipState.Bag;
				}
				this.EquipBagPackId = value;
			}
		}

		// Token: 0x17006A01 RID: 27137
		// (get) Token: 0x06036E0A RID: 224778 RVA: 0x00F4D6AC File Offset: 0x00F4B8AC
		// (set) Token: 0x06036E0B RID: 224779 RVA: 0x00F4D6B4 File Offset: 0x00F4B8B4
		public int GridEquipBagItemId
		{
			get
			{
				return this.EquipItemId;
			}
			private set
			{
				if (value == -1)
				{
					this.State &= ~EDangoBrawlGridEquipState.BagItem;
				}
				else
				{
					this.State |= EDangoBrawlGridEquipState.BagItem;
				}
				this.EquipItemId = value;
			}
		}

		// Token: 0x06036E0C RID: 224780 RVA: 0x00F4D6E0 File Offset: 0x00F4B8E0
		public bool EquipBagPackItem(int val, EDangoBrawlTemplateType type)
		{
			if (type == EDangoBrawlTemplateType.Bag)
			{
				this.GridEquipBagId = val;
				return true;
			}
			this.GridEquipBagItemId = val;
			return false;
		}

		// Token: 0x06036E0D RID: 224781 RVA: 0x00F4D6F6 File Offset: 0x00F4B8F6
		public bool UnEquipBagPackItem(EDangoBrawlTemplateType type)
		{
			if (type == EDangoBrawlTemplateType.Bag)
			{
				this.GridEquipBagId = -1;
				return true;
			}
			this.GridEquipBagItemId = -1;
			return false;
		}

		// Token: 0x06036E0E RID: 224782 RVA: 0x00F4D70C File Offset: 0x00F4B90C
		public bool IsCanEquipBagPackItem(EDangoBrawlTemplateType type)
		{
			if (type == EDangoBrawlTemplateType.Bag)
			{
				return (this.State & EDangoBrawlGridEquipState.Bag) == EDangoBrawlGridEquipState.Empty;
			}
			return (this.State & EDangoBrawlGridEquipState.Bag) != EDangoBrawlGridEquipState.Empty && (this.State & EDangoBrawlGridEquipState.BagItem) == EDangoBrawlGridEquipState.Empty;
		}

		// Token: 0x0401D10C RID: 119052
		private readonly PanelPos PanelPos;

		// Token: 0x0401D10D RID: 119053
		private EDangoBrawlGridEquipState State;

		// Token: 0x0401D10E RID: 119054
		private int EquipBagPackId = -1;

		// Token: 0x0401D10F RID: 119055
		private int EquipItemId = -1;
	}
}
