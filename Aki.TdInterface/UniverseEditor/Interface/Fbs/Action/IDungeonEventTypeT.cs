using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006616 RID: 26134
	public class IDungeonEventTypeT
	{
		// Token: 0x1700C237 RID: 49719
		// (get) Token: 0x0602D635 RID: 185909 RVA: 0x006382F2 File Offset: 0x006364F2
		// (set) Token: 0x0602D636 RID: 185910 RVA: 0x006382FA File Offset: 0x006364FA
		public EDungeonEventType Type { get; set; }

		// Token: 0x0602D637 RID: 185911 RVA: 0x00638303 File Offset: 0x00636503
		public IDungeonEventTypeT()
		{
			this.Type = EDungeonEventType.RecordTimeStamp;
		}
	}
}
