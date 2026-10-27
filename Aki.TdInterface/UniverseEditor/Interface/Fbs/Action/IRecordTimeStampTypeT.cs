using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E14 RID: 28180
	public class IRecordTimeStampTypeT
	{
		// Token: 0x1700D20D RID: 53773
		// (get) Token: 0x06031CA8 RID: 203944 RVA: 0x006BDBA0 File Offset: 0x006BBDA0
		// (set) Token: 0x06031CA9 RID: 203945 RVA: 0x006BDBA8 File Offset: 0x006BBDA8
		public EDungeonEventType Type { get; set; }

		// Token: 0x1700D20E RID: 53774
		// (get) Token: 0x06031CAA RID: 203946 RVA: 0x006BDBB1 File Offset: 0x006BBDB1
		// (set) Token: 0x06031CAB RID: 203947 RVA: 0x006BDBB9 File Offset: 0x006BBDB9
		public ETimeStampType TimeStampType { get; set; }

		// Token: 0x06031CAC RID: 203948 RVA: 0x006BDBC2 File Offset: 0x006BBDC2
		public IRecordTimeStampTypeT()
		{
			this.Type = EDungeonEventType.RecordTimeStamp;
			this.TimeStampType = ETimeStampType.DungeonBegin;
		}
	}
}
