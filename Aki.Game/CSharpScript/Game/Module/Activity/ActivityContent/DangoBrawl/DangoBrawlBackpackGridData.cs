using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067C9 RID: 26569
	public class DangoBrawlBackpackGridData
	{
		// Token: 0x060422AF RID: 271023 RVA: 0x0100C27F File Offset: 0x0100A47F
		public DangoBrawlBackpackGridData(PanelPos panelPos)
		{
			this.PanelPos = panelPos;
		}

		// Token: 0x170096BD RID: 38589
		// (get) Token: 0x060422B0 RID: 271024 RVA: 0x0100C29C File Offset: 0x0100A49C
		public PanelPos GridPanelPos
		{
			get
			{
				return this.PanelPos;
			}
		}

		// Token: 0x170096BE RID: 38590
		// (get) Token: 0x060422B1 RID: 271025 RVA: 0x0100C2A4 File Offset: 0x0100A4A4
		public EDangoBrawlGridEquipState GridState
		{
			get
			{
				return this.State;
			}
		}

		// Token: 0x170096BF RID: 38591
		// (get) Token: 0x060422B2 RID: 271026 RVA: 0x0100C2AC File Offset: 0x0100A4AC
		// (set) Token: 0x060422B3 RID: 271027 RVA: 0x0100C2B4 File Offset: 0x0100A4B4
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

		// Token: 0x170096C0 RID: 38592
		// (get) Token: 0x060422B4 RID: 271028 RVA: 0x0100C2E0 File Offset: 0x0100A4E0
		// (set) Token: 0x060422B5 RID: 271029 RVA: 0x0100C2E8 File Offset: 0x0100A4E8
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

		// Token: 0x060422B6 RID: 271030 RVA: 0x0100C314 File Offset: 0x0100A514
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

		// Token: 0x060422B7 RID: 271031 RVA: 0x0100C32A File Offset: 0x0100A52A
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

		// Token: 0x060422B8 RID: 271032 RVA: 0x0100C340 File Offset: 0x0100A540
		public bool IsCanEquipBagPackItem(EDangoBrawlTemplateType type)
		{
			if (type == EDangoBrawlTemplateType.Bag)
			{
				return (this.State & EDangoBrawlGridEquipState.Bag) == EDangoBrawlGridEquipState.Empty;
			}
			return (this.State & EDangoBrawlGridEquipState.Bag) != EDangoBrawlGridEquipState.Empty && (this.State & EDangoBrawlGridEquipState.BagItem) == EDangoBrawlGridEquipState.Empty;
		}

		// Token: 0x040228AF RID: 141487
		private readonly PanelPos PanelPos;

		// Token: 0x040228B0 RID: 141488
		private EDangoBrawlGridEquipState State;

		// Token: 0x040228B1 RID: 141489
		private int EquipBagPackId = -1;

		// Token: 0x040228B2 RID: 141490
		private int EquipItemId = -1;
	}
}
