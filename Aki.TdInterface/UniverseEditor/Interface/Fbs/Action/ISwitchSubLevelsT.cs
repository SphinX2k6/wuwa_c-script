using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200726C RID: 29292
	public class ISwitchSubLevelsT
	{
		// Token: 0x1700D955 RID: 55637
		// (get) Token: 0x06033F74 RID: 212852 RVA: 0x006FD052 File Offset: 0x006FB252
		// (set) Token: 0x06033F75 RID: 212853 RVA: 0x006FD05A File Offset: 0x006FB25A
		public ESwitchSubLevelsType Type { get; set; }

		// Token: 0x06033F76 RID: 212854 RVA: 0x006FD063 File Offset: 0x006FB263
		public ISwitchSubLevelsT()
		{
			this.Type = ESwitchSubLevelsType.Directly;
		}
	}
}
