using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200758C RID: 30092
	public class IRecordDungeonEventT
	{
		// Token: 0x1700DD51 RID: 56657
		// (get) Token: 0x06034C90 RID: 216208 RVA: 0x00719099 File Offset: 0x00717299
		// (set) Token: 0x06034C91 RID: 216209 RVA: 0x007190A1 File Offset: 0x007172A1
		public IRecordTimeStampTypeT EventConfig { get; set; }

		// Token: 0x06034C92 RID: 216210 RVA: 0x007190AA File Offset: 0x007172AA
		public IRecordDungeonEventT()
		{
			this.EventConfig = null;
		}
	}
}
