using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DC8 RID: 24008
	public class IQteTypeT
	{
		// Token: 0x1700B0D1 RID: 45265
		// (get) Token: 0x06028070 RID: 163952 RVA: 0x0057964C File Offset: 0x0057784C
		// (set) Token: 0x06028071 RID: 163953 RVA: 0x00579654 File Offset: 0x00577854
		public EQteType Type { get; set; }

		// Token: 0x1700B0D2 RID: 45266
		// (get) Token: 0x06028072 RID: 163954 RVA: 0x0057965D File Offset: 0x0057785D
		// (set) Token: 0x06028073 RID: 163955 RVA: 0x00579665 File Offset: 0x00577865
		public int QteId { get; set; }

		// Token: 0x06028074 RID: 163956 RVA: 0x0057966E File Offset: 0x0057786E
		public IQteTypeT()
		{
			this.Type = EQteType.SingleBtn;
			this.QteId = 0;
		}
	}
}
