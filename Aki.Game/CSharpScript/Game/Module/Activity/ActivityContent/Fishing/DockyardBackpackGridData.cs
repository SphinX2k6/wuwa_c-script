using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02006590 RID: 26000
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardBackpackGridData
	{
		// Token: 0x17009553 RID: 38227
		// (get) Token: 0x060412EB RID: 266987 RVA: 0x00FCD13D File Offset: 0x00FCB33D
		public int ItemBlockId
		{
			get
			{
				return this.ItemBlockIdInternal;
			}
		}

		// Token: 0x060412EC RID: 266988 RVA: 0x00FCD145 File Offset: 0x00FCB345
		public DockyardBackpackGridData(IPanelPos posData)
		{
			this.PosData = posData;
		}

		// Token: 0x17009554 RID: 38228
		// (get) Token: 0x060412ED RID: 266989 RVA: 0x00FCD162 File Offset: 0x00FCB362
		public bool IsValid
		{
			get
			{
				return this.Type > EBackpackGridType.Disable;
			}
		}

		// Token: 0x060412EE RID: 266990 RVA: 0x00FCD16D File Offset: 0x00FCB36D
		public void SetIsQuicklySell(bool value)
		{
			this.IsQuicklySellInternal = value;
		}

		// Token: 0x17009555 RID: 38229
		// (get) Token: 0x060412EF RID: 266991 RVA: 0x00FCD176 File Offset: 0x00FCB376
		public bool IsQuicklySell
		{
			get
			{
				return this.IsQuicklySellInternal;
			}
		}

		// Token: 0x060412F0 RID: 266992 RVA: 0x00FCD17E File Offset: 0x00FCB37E
		public void SetGridType(EBackpackGridType type)
		{
			this.Type = type;
		}

		// Token: 0x060412F1 RID: 266993 RVA: 0x00FCD187 File Offset: 0x00FCB387
		public void SetItemBlockId(int id)
		{
			this.ItemBlockIdInternal = id;
		}

		// Token: 0x04021F2D RID: 139053
		private EBackpackGridType Type = EBackpackGridType.Enable;

		// Token: 0x04021F2E RID: 139054
		private bool IsQuicklySellInternal;

		// Token: 0x04021F2F RID: 139055
		private int ItemBlockIdInternal = -1;

		// Token: 0x04021F30 RID: 139056
		protected readonly IPanelPos PosData;
	}
}
