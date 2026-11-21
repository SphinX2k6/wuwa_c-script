using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005731 RID: 22321
	public class IExchangeSlideRailConfigT
	{
		// Token: 0x1700A12F RID: 41263
		// (get) Token: 0x06023E98 RID: 147096 RVA: 0x004EFE9B File Offset: 0x004EE09B
		// (set) Token: 0x06023E99 RID: 147097 RVA: 0x004EFEA3 File Offset: 0x004EE0A3
		public int MaxExchangeDistance { get; set; }

		// Token: 0x1700A130 RID: 41264
		// (get) Token: 0x06023E9A RID: 147098 RVA: 0x004EFEAC File Offset: 0x004EE0AC
		// (set) Token: 0x06023E9B RID: 147099 RVA: 0x004EFEB4 File Offset: 0x004EE0B4
		public int MaxExchangeHigh { get; set; }

		// Token: 0x1700A131 RID: 41265
		// (get) Token: 0x06023E9C RID: 147100 RVA: 0x004EFEBD File Offset: 0x004EE0BD
		// (set) Token: 0x06023E9D RID: 147101 RVA: 0x004EFEC5 File Offset: 0x004EE0C5
		public List<INextSlideRailT> NextRails { get; set; }

		// Token: 0x1700A132 RID: 41266
		// (get) Token: 0x06023E9E RID: 147102 RVA: 0x004EFECE File Offset: 0x004EE0CE
		// (set) Token: 0x06023E9F RID: 147103 RVA: 0x004EFED6 File Offset: 0x004EE0D6
		public byte NullMask { get; set; }

		// Token: 0x06023EA0 RID: 147104 RVA: 0x004EFEDF File Offset: 0x004EE0DF
		public IExchangeSlideRailConfigT()
		{
			this.MaxExchangeDistance = 0;
			this.MaxExchangeHigh = 0;
			this.NextRails = null;
			this.NullMask = 0;
		}
	}
}
