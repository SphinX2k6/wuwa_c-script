using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C3E RID: 19518
	public class IHourT
	{
		// Token: 0x17008DCC RID: 36300
		// (get) Token: 0x0601EEFD RID: 126717 RVA: 0x00453F80 File Offset: 0x00452180
		// (set) Token: 0x0601EEFE RID: 126718 RVA: 0x00453F88 File Offset: 0x00452188
		public int Hour { get; set; }

		// Token: 0x17008DCD RID: 36301
		// (get) Token: 0x0601EEFF RID: 126719 RVA: 0x00453F91 File Offset: 0x00452191
		// (set) Token: 0x0601EF00 RID: 126720 RVA: 0x00453F99 File Offset: 0x00452199
		public int Min { get; set; }

		// Token: 0x0601EF01 RID: 126721 RVA: 0x00453FA2 File Offset: 0x004521A2
		public IHourT()
		{
			this.Hour = 0;
			this.Min = 0;
		}
	}
}
