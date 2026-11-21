using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200453C RID: 17724
	public class ISaveConfigTypeT
	{
		// Token: 0x17007B49 RID: 31561
		// (get) Token: 0x06019AB0 RID: 105136 RVA: 0x003A7C26 File Offset: 0x003A5E26
		// (set) Token: 0x06019AB1 RID: 105137 RVA: 0x003A7C2E File Offset: 0x003A5E2E
		public ESaveConfig Type { get; set; }

		// Token: 0x06019AB2 RID: 105138 RVA: 0x003A7C37 File Offset: 0x003A5E37
		public ISaveConfigTypeT()
		{
			this.Type = ESaveConfig.SaveNew;
		}
	}
}
