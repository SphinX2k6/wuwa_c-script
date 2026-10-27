using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D14 RID: 23828
	public class IAreaFunctionT
	{
		// Token: 0x1700B28E RID: 45710
		// (get) Token: 0x06028B51 RID: 166737 RVA: 0x005976D5 File Offset: 0x005958D5
		// (set) Token: 0x06028B52 RID: 166738 RVA: 0x005976DD File Offset: 0x005958DD
		public int Id { get; set; }

		// Token: 0x1700B28F RID: 45711
		// (get) Token: 0x06028B53 RID: 166739 RVA: 0x005976E6 File Offset: 0x005958E6
		// (set) Token: 0x06028B54 RID: 166740 RVA: 0x005976EE File Offset: 0x005958EE
		public string Desc { get; set; }

		// Token: 0x1700B290 RID: 45712
		// (get) Token: 0x06028B55 RID: 166741 RVA: 0x005976F7 File Offset: 0x005958F7
		// (set) Token: 0x06028B56 RID: 166742 RVA: 0x005976FF File Offset: 0x005958FF
		public IAirCurrentDataT Data { get; set; }

		// Token: 0x06028B57 RID: 166743 RVA: 0x00597708 File Offset: 0x00595908
		public IAreaFunctionT()
		{
			this.Id = 0;
			this.Desc = null;
			this.Data = null;
		}
	}
}
