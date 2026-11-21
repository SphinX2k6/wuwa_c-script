using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006348 RID: 25416
	public class IAreaFunctionT
	{
		// Token: 0x1700BBEA RID: 48106
		// (get) Token: 0x0602B1A5 RID: 176549 RVA: 0x005DFF45 File Offset: 0x005DE145
		// (set) Token: 0x0602B1A6 RID: 176550 RVA: 0x005DFF4D File Offset: 0x005DE14D
		public int Id { get; set; }

		// Token: 0x1700BBEB RID: 48107
		// (get) Token: 0x0602B1A7 RID: 176551 RVA: 0x005DFF56 File Offset: 0x005DE156
		// (set) Token: 0x0602B1A8 RID: 176552 RVA: 0x005DFF5E File Offset: 0x005DE15E
		public string Desc { get; set; }

		// Token: 0x1700BBEC RID: 48108
		// (get) Token: 0x0602B1A9 RID: 176553 RVA: 0x005DFF67 File Offset: 0x005DE167
		// (set) Token: 0x0602B1AA RID: 176554 RVA: 0x005DFF6F File Offset: 0x005DE16F
		public IAirCurrentDataT Data { get; set; }

		// Token: 0x0602B1AB RID: 176555 RVA: 0x005DFF78 File Offset: 0x005DE178
		public IAreaFunctionT()
		{
			this.Id = 0;
			this.Desc = null;
			this.Data = null;
		}
	}
}
