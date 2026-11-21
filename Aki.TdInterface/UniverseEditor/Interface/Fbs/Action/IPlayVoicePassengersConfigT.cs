using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074C0 RID: 29888
	public class IPlayVoicePassengersConfigT
	{
		// Token: 0x1700DBE5 RID: 56293
		// (get) Token: 0x06034639 RID: 214585 RVA: 0x0070E299 File Offset: 0x0070C499
		// (set) Token: 0x0603463A RID: 214586 RVA: 0x0070E2A1 File Offset: 0x0070C4A1
		public List<int> Passengers { get; set; }

		// Token: 0x1700DBE6 RID: 56294
		// (get) Token: 0x0603463B RID: 214587 RVA: 0x0070E2AA File Offset: 0x0070C4AA
		// (set) Token: 0x0603463C RID: 214588 RVA: 0x0070E2B2 File Offset: 0x0070C4B2
		public bool MatchNone { get; set; }

		// Token: 0x1700DBE7 RID: 56295
		// (get) Token: 0x0603463D RID: 214589 RVA: 0x0070E2BB File Offset: 0x0070C4BB
		// (set) Token: 0x0603463E RID: 214590 RVA: 0x0070E2C3 File Offset: 0x0070C4C3
		public byte NullMask { get; set; }

		// Token: 0x0603463F RID: 214591 RVA: 0x0070E2CC File Offset: 0x0070C4CC
		public IPlayVoicePassengersConfigT()
		{
			this.Passengers = null;
			this.MatchNone = false;
			this.NullMask = 0;
		}
	}
}
