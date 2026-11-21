using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044C4 RID: 17604
	public class IRecallConfigT
	{
		// Token: 0x17007A91 RID: 31377
		// (get) Token: 0x06019702 RID: 104194 RVA: 0x003A12A2 File Offset: 0x0039F4A2
		// (set) Token: 0x06019703 RID: 104195 RVA: 0x003A12AA File Offset: 0x0039F4AA
		public int RecallId { get; set; }

		// Token: 0x06019704 RID: 104196 RVA: 0x003A12B3 File Offset: 0x0039F4B3
		public IRecallConfigT()
		{
			this.RecallId = 0;
		}
	}
}
