using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FA0 RID: 28576
	public class ISetAreaStateT
	{
		// Token: 0x1700D43C RID: 54332
		// (get) Token: 0x06032813 RID: 206867 RVA: 0x006D10A8 File Offset: 0x006CF2A8
		// (set) Token: 0x06032814 RID: 206868 RVA: 0x006D10B0 File Offset: 0x006CF2B0
		public int AreaId { get; set; }

		// Token: 0x1700D43D RID: 54333
		// (get) Token: 0x06032815 RID: 206869 RVA: 0x006D10B9 File Offset: 0x006CF2B9
		// (set) Token: 0x06032816 RID: 206870 RVA: 0x006D10C1 File Offset: 0x006CF2C1
		public int State { get; set; }

		// Token: 0x06032817 RID: 206871 RVA: 0x006D10CA File Offset: 0x006CF2CA
		public ISetAreaStateT()
		{
			this.AreaId = 0;
			this.State = 0;
		}
	}
}
