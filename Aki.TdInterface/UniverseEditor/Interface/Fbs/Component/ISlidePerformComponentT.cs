using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F3A RID: 24378
	public class ISlidePerformComponentT
	{
		// Token: 0x1700B484 RID: 46212
		// (get) Token: 0x06028F5C RID: 167772 RVA: 0x00598B51 File Offset: 0x00596D51
		// (set) Token: 0x06028F5D RID: 167773 RVA: 0x00598B59 File Offset: 0x00596D59
		public bool Disabled { get; set; }

		// Token: 0x1700B485 RID: 46213
		// (get) Token: 0x06028F5E RID: 167774 RVA: 0x00598B62 File Offset: 0x00596D62
		// (set) Token: 0x06028F5F RID: 167775 RVA: 0x00598B6A File Offset: 0x00596D6A
		public int SlideSpeed { get; set; }

		// Token: 0x1700B486 RID: 46214
		// (get) Token: 0x06028F60 RID: 167776 RVA: 0x00598B73 File Offset: 0x00596D73
		// (set) Token: 0x06028F61 RID: 167777 RVA: 0x00598B7B File Offset: 0x00596D7B
		public int UpSpeed { get; set; }

		// Token: 0x1700B487 RID: 46215
		// (get) Token: 0x06028F62 RID: 167778 RVA: 0x00598B84 File Offset: 0x00596D84
		// (set) Token: 0x06028F63 RID: 167779 RVA: 0x00598B8C File Offset: 0x00596D8C
		public int DownSpeed { get; set; }

		// Token: 0x1700B488 RID: 46216
		// (get) Token: 0x06028F64 RID: 167780 RVA: 0x00598B95 File Offset: 0x00596D95
		// (set) Token: 0x06028F65 RID: 167781 RVA: 0x00598B9D File Offset: 0x00596D9D
		public int RailSplineEntityId { get; set; }

		// Token: 0x1700B489 RID: 46217
		// (get) Token: 0x06028F66 RID: 167782 RVA: 0x00598BA6 File Offset: 0x00596DA6
		// (set) Token: 0x06028F67 RID: 167783 RVA: 0x00598BAE File Offset: 0x00596DAE
		public List<IExchangeSlideRailConfigT> ExchangeRailConfigs { get; set; }

		// Token: 0x1700B48A RID: 46218
		// (get) Token: 0x06028F68 RID: 167784 RVA: 0x00598BB7 File Offset: 0x00596DB7
		// (set) Token: 0x06028F69 RID: 167785 RVA: 0x00598BBF File Offset: 0x00596DBF
		public ISlopeSlidePerformT SlidePerformConfig { get; set; }

		// Token: 0x1700B48B RID: 46219
		// (get) Token: 0x06028F6A RID: 167786 RVA: 0x00598BC8 File Offset: 0x00596DC8
		// (set) Token: 0x06028F6B RID: 167787 RVA: 0x00598BD0 File Offset: 0x00596DD0
		public byte NullMask { get; set; }

		// Token: 0x06028F6C RID: 167788 RVA: 0x00598BD9 File Offset: 0x00596DD9
		public ISlidePerformComponentT()
		{
			this.Disabled = false;
			this.SlideSpeed = 0;
			this.UpSpeed = 0;
			this.DownSpeed = 0;
			this.RailSplineEntityId = 0;
			this.ExchangeRailConfigs = null;
			this.SlidePerformConfig = null;
			this.NullMask = 0;
		}
	}
}
