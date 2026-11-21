using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200756E RID: 30062
	public class IQteHourglassT
	{
		// Token: 0x1700DD0D RID: 56589
		// (get) Token: 0x06034B79 RID: 215929 RVA: 0x00716EC4 File Offset: 0x007150C4
		// (set) Token: 0x06034B7A RID: 215930 RVA: 0x00716ECC File Offset: 0x007150CC
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700DD0E RID: 56590
		// (get) Token: 0x06034B7B RID: 215931 RVA: 0x00716ED5 File Offset: 0x007150D5
		// (set) Token: 0x06034B7C RID: 215932 RVA: 0x00716EDD File Offset: 0x007150DD
		public List<int> QteIds { get; set; }

		// Token: 0x1700DD0F RID: 56591
		// (get) Token: 0x06034B7D RID: 215933 RVA: 0x00716EE6 File Offset: 0x007150E6
		// (set) Token: 0x06034B7E RID: 215934 RVA: 0x00716EEE File Offset: 0x007150EE
		public List<IQteHourglassConfigT> QteConfigs { get; set; }

		// Token: 0x1700DD10 RID: 56592
		// (get) Token: 0x06034B7F RID: 215935 RVA: 0x00716EF7 File Offset: 0x007150F7
		// (set) Token: 0x06034B80 RID: 215936 RVA: 0x00716EFF File Offset: 0x007150FF
		public byte NullMask { get; set; }

		// Token: 0x06034B81 RID: 215937 RVA: 0x00716F08 File Offset: 0x00715108
		public IQteHourglassT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.QteIds = null;
			this.QteConfigs = null;
			this.NullMask = 0;
		}
	}
}
