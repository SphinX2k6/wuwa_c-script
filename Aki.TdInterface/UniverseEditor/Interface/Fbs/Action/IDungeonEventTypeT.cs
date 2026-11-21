using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C87 RID: 27783
	public class IDungeonEventTypeT
	{
		// Token: 0x1700CBD5 RID: 52181
		// (get) Token: 0x0602FE06 RID: 196102 RVA: 0x00684E5A File Offset: 0x0068305A
		// (set) Token: 0x0602FE07 RID: 196103 RVA: 0x00684E62 File Offset: 0x00683062
		public EDungeonEventType Type { get; set; }

		// Token: 0x0602FE08 RID: 196104 RVA: 0x00684E6B File Offset: 0x0068306B
		public IDungeonEventTypeT()
		{
			this.Type = EDungeonEventType.RecordTimeStamp;
		}
	}
}
