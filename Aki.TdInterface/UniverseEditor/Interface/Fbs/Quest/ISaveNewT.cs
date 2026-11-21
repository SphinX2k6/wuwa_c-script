using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004542 RID: 17730
	public class ISaveNewT
	{
		// Token: 0x17007B4E RID: 31566
		// (get) Token: 0x06019AD0 RID: 105168 RVA: 0x003A7EE6 File Offset: 0x003A60E6
		// (set) Token: 0x06019AD1 RID: 105169 RVA: 0x003A7EEE File Offset: 0x003A60EE
		public ESaveConfig Type { get; set; }

		// Token: 0x06019AD2 RID: 105170 RVA: 0x003A7EF7 File Offset: 0x003A60F7
		public ISaveNewT()
		{
			this.Type = ESaveConfig.SaveNew;
		}
	}
}
