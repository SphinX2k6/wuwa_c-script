using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A41 RID: 31297
	public class ISwitchSubLevelsT
	{
		// Token: 0x1700E54E RID: 58702
		// (get) Token: 0x06037276 RID: 225910 RVA: 0x0075E3B2 File Offset: 0x0075C5B2
		// (set) Token: 0x06037277 RID: 225911 RVA: 0x0075E3BA File Offset: 0x0075C5BA
		public ESwitchSubLevelsType Type { get; set; }

		// Token: 0x06037278 RID: 225912 RVA: 0x0075E3C3 File Offset: 0x0075C5C3
		public ISwitchSubLevelsT()
		{
			this.Type = ESwitchSubLevelsType.Directly;
		}
	}
}
