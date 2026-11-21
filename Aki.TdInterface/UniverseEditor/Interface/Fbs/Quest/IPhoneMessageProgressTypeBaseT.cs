using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043BC RID: 17340
	public class IPhoneMessageProgressTypeBaseT
	{
		// Token: 0x1700776F RID: 30575
		// (get) Token: 0x060189BB RID: 100795 RVA: 0x00382A82 File Offset: 0x00380C82
		// (set) Token: 0x060189BC RID: 100796 RVA: 0x00382A8A File Offset: 0x00380C8A
		public EPhoneMessageProgressType Type { get; set; }

		// Token: 0x060189BD RID: 100797 RVA: 0x00382A93 File Offset: 0x00380C93
		public IPhoneMessageProgressTypeBaseT()
		{
			this.Type = EPhoneMessageProgressType.CompleteMessage;
		}
	}
}
