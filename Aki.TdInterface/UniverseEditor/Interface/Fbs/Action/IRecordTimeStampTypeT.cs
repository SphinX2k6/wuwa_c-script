using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200758F RID: 30095
	public class IRecordTimeStampTypeT
	{
		// Token: 0x1700DD55 RID: 56661
		// (get) Token: 0x06034CA4 RID: 216228 RVA: 0x00719288 File Offset: 0x00717488
		// (set) Token: 0x06034CA5 RID: 216229 RVA: 0x00719290 File Offset: 0x00717490
		public EDungeonEventType Type { get; set; }

		// Token: 0x1700DD56 RID: 56662
		// (get) Token: 0x06034CA6 RID: 216230 RVA: 0x00719299 File Offset: 0x00717499
		// (set) Token: 0x06034CA7 RID: 216231 RVA: 0x007192A1 File Offset: 0x007174A1
		public ETimeStampType TimeStampType { get; set; }

		// Token: 0x06034CA8 RID: 216232 RVA: 0x007192AA File Offset: 0x007174AA
		public IRecordTimeStampTypeT()
		{
			this.Type = EDungeonEventType.RecordTimeStamp;
			this.TimeStampType = ETimeStampType.DungeonBegin;
		}
	}
}
