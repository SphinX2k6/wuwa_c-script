using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006189 RID: 24969
	public class IAlertSystemOptionT
	{
		// Token: 0x1700BA2C RID: 47660
		// (get) Token: 0x0602B02C RID: 176172 RVA: 0x005EEF40 File Offset: 0x005ED140
		// (set) Token: 0x0602B02D RID: 176173 RVA: 0x005EEF48 File Offset: 0x005ED148
		public EAlertSystemOption Type { get; set; }

		// Token: 0x1700BA2D RID: 47661
		// (get) Token: 0x0602B02E RID: 176174 RVA: 0x005EEF51 File Offset: 0x005ED151
		// (set) Token: 0x0602B02F RID: 176175 RVA: 0x005EEF59 File Offset: 0x005ED159
		public int AreaId { get; set; }

		// Token: 0x0602B030 RID: 176176 RVA: 0x005EEF62 File Offset: 0x005ED162
		public IAlertSystemOptionT()
		{
			this.Type = EAlertSystemOption.EnableAlertArea;
			this.AreaId = 0;
		}
	}
}
