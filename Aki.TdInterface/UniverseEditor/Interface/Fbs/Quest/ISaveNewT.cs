using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004101 RID: 16641
	public class ISaveNewT
	{
		// Token: 0x17007548 RID: 30024
		// (get) Token: 0x0601842F RID: 99375 RVA: 0x0037DF96 File Offset: 0x0037C196
		// (set) Token: 0x06018430 RID: 99376 RVA: 0x0037DF9E File Offset: 0x0037C19E
		public ESaveConfig Type { get; set; }

		// Token: 0x06018431 RID: 99377 RVA: 0x0037DFA7 File Offset: 0x0037C1A7
		public ISaveNewT()
		{
			this.Type = ESaveConfig.SaveNew;
		}
	}
}
