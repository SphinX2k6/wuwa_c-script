using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E28 RID: 32296
	public class IWriteLetterConfigT
	{
		// Token: 0x1700F1D8 RID: 61912
		// (get) Token: 0x0603A5C5 RID: 239045 RVA: 0x007DC3DA File Offset: 0x007DA5DA
		// (set) Token: 0x0603A5C6 RID: 239046 RVA: 0x007DC3E2 File Offset: 0x007DA5E2
		public int LetterId { get; set; }

		// Token: 0x0603A5C7 RID: 239047 RVA: 0x007DC3EB File Offset: 0x007DA5EB
		public IWriteLetterConfigT()
		{
			this.LetterId = 0;
		}
	}
}
