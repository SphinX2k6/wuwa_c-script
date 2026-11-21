using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B34 RID: 31540
	public class ITalkSequenceTransitionT
	{
		// Token: 0x1700EC43 RID: 60483
		// (get) Token: 0x06038CDB RID: 232667 RVA: 0x007AEAC4 File Offset: 0x007ACCC4
		// (set) Token: 0x06038CDC RID: 232668 RVA: 0x007AEACC File Offset: 0x007ACCCC
		public string OptionText { get; set; }

		// Token: 0x1700EC44 RID: 60484
		// (get) Token: 0x06038CDD RID: 232669 RVA: 0x007AEAD5 File Offset: 0x007ACCD5
		// (set) Token: 0x06038CDE RID: 232670 RVA: 0x007AEADD File Offset: 0x007ACCDD
		public string OptionTextKey { get; set; }

		// Token: 0x1700EC45 RID: 60485
		// (get) Token: 0x06038CDF RID: 232671 RVA: 0x007AEAE6 File Offset: 0x007ACCE6
		// (set) Token: 0x06038CE0 RID: 232672 RVA: 0x007AEAEE File Offset: 0x007ACCEE
		public int NextSequenceIndex { get; set; }

		// Token: 0x06038CE1 RID: 232673 RVA: 0x007AEAF7 File Offset: 0x007ACCF7
		public ITalkSequenceTransitionT()
		{
			this.OptionText = null;
			this.OptionTextKey = null;
			this.NextSequenceIndex = 0;
		}
	}
}
