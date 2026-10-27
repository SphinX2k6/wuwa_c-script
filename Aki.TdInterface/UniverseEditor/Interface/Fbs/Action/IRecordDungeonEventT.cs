using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E11 RID: 28177
	public class IRecordDungeonEventT
	{
		// Token: 0x1700D209 RID: 53769
		// (get) Token: 0x06031C94 RID: 203924 RVA: 0x006BD9B1 File Offset: 0x006BBBB1
		// (set) Token: 0x06031C95 RID: 203925 RVA: 0x006BD9B9 File Offset: 0x006BBBB9
		public IRecordTimeStampTypeT EventConfig { get; set; }

		// Token: 0x06031C96 RID: 203926 RVA: 0x006BD9C2 File Offset: 0x006BBBC2
		public IRecordDungeonEventT()
		{
			this.EventConfig = null;
		}
	}
}
