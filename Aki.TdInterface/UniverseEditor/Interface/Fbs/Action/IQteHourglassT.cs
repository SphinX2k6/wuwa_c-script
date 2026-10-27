using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DF3 RID: 28147
	public class IQteHourglassT
	{
		// Token: 0x1700D1C5 RID: 53701
		// (get) Token: 0x06031B7D RID: 203645 RVA: 0x006BB7DC File Offset: 0x006B99DC
		// (set) Token: 0x06031B7E RID: 203646 RVA: 0x006BB7E4 File Offset: 0x006B99E4
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700D1C6 RID: 53702
		// (get) Token: 0x06031B7F RID: 203647 RVA: 0x006BB7ED File Offset: 0x006B99ED
		// (set) Token: 0x06031B80 RID: 203648 RVA: 0x006BB7F5 File Offset: 0x006B99F5
		public List<int> QteIds { get; set; }

		// Token: 0x1700D1C7 RID: 53703
		// (get) Token: 0x06031B81 RID: 203649 RVA: 0x006BB7FE File Offset: 0x006B99FE
		// (set) Token: 0x06031B82 RID: 203650 RVA: 0x006BB806 File Offset: 0x006B9A06
		public List<IQteHourglassConfigT> QteConfigs { get; set; }

		// Token: 0x1700D1C8 RID: 53704
		// (get) Token: 0x06031B83 RID: 203651 RVA: 0x006BB80F File Offset: 0x006B9A0F
		// (set) Token: 0x06031B84 RID: 203652 RVA: 0x006BB817 File Offset: 0x006B9A17
		public byte NullMask { get; set; }

		// Token: 0x06031B85 RID: 203653 RVA: 0x006BB820 File Offset: 0x006B9A20
		public IQteHourglassT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.QteIds = null;
			this.QteConfigs = null;
			this.NullMask = 0;
		}
	}
}
