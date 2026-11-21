using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200550E RID: 21774
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardBackpackGridData
	{
		// Token: 0x170068B5 RID: 26805
		// (get) Token: 0x06035FB0 RID: 221104 RVA: 0x00F14151 File Offset: 0x00F12351
		public int ItemBlockId
		{
			get
			{
				return this.ItemBlockIdInternal;
			}
		}

		// Token: 0x06035FB1 RID: 221105 RVA: 0x00F14159 File Offset: 0x00F12359
		public DockyardBackpackGridData(IPanelPos posData)
		{
			this.PosData = posData;
		}

		// Token: 0x170068B6 RID: 26806
		// (get) Token: 0x06035FB2 RID: 221106 RVA: 0x00F14176 File Offset: 0x00F12376
		public bool IsValid
		{
			get
			{
				return this.Type > EBackpackGridType.Disable;
			}
		}

		// Token: 0x06035FB3 RID: 221107 RVA: 0x00F14181 File Offset: 0x00F12381
		public void SetIsQuicklySell(bool value)
		{
			this.IsQuicklySellInternal = value;
		}

		// Token: 0x170068B7 RID: 26807
		// (get) Token: 0x06035FB4 RID: 221108 RVA: 0x00F1418A File Offset: 0x00F1238A
		public bool IsQuicklySell
		{
			get
			{
				return this.IsQuicklySellInternal;
			}
		}

		// Token: 0x06035FB5 RID: 221109 RVA: 0x00F14192 File Offset: 0x00F12392
		public void SetGridType(EBackpackGridType type)
		{
			this.Type = type;
		}

		// Token: 0x06035FB6 RID: 221110 RVA: 0x00F1419B File Offset: 0x00F1239B
		public void SetItemBlockId(int id)
		{
			this.ItemBlockIdInternal = id;
		}

		// Token: 0x0401C85E RID: 116830
		private EBackpackGridType Type = EBackpackGridType.Enable;

		// Token: 0x0401C85F RID: 116831
		private bool IsQuicklySellInternal;

		// Token: 0x0401C860 RID: 116832
		private int ItemBlockIdInternal = -1;

		// Token: 0x0401C861 RID: 116833
		protected readonly IPanelPos PosData;
	}
}
