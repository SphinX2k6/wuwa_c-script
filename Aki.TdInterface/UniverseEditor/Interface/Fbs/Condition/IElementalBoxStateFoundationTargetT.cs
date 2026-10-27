using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C02 RID: 19458
	public class IElementalBoxStateFoundationTargetT
	{
		// Token: 0x17008D59 RID: 36185
		// (get) Token: 0x0601ED07 RID: 126215 RVA: 0x00450CA5 File Offset: 0x0044EEA5
		// (set) Token: 0x0601ED08 RID: 126216 RVA: 0x00450CAD File Offset: 0x0044EEAD
		public EElementalBoxStateTargetType Type { get; set; }

		// Token: 0x17008D5A RID: 36186
		// (get) Token: 0x0601ED09 RID: 126217 RVA: 0x00450CB6 File Offset: 0x0044EEB6
		// (set) Token: 0x0601ED0A RID: 126218 RVA: 0x00450CBE File Offset: 0x0044EEBE
		public int EntityId { get; set; }

		// Token: 0x17008D5B RID: 36187
		// (get) Token: 0x0601ED0B RID: 126219 RVA: 0x00450CC7 File Offset: 0x0044EEC7
		// (set) Token: 0x0601ED0C RID: 126220 RVA: 0x00450CCF File Offset: 0x0044EECF
		public string State { get; set; }

		// Token: 0x0601ED0D RID: 126221 RVA: 0x00450CD8 File Offset: 0x0044EED8
		public IElementalBoxStateFoundationTargetT()
		{
			this.Type = EElementalBoxStateTargetType.Player;
			this.EntityId = 0;
			this.State = null;
		}
	}
}
