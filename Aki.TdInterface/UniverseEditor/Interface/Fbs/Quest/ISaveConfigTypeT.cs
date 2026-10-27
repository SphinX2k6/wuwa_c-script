using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040FB RID: 16635
	public class ISaveConfigTypeT
	{
		// Token: 0x17007543 RID: 30019
		// (get) Token: 0x0601840F RID: 99343 RVA: 0x0037DCD6 File Offset: 0x0037BED6
		// (set) Token: 0x06018410 RID: 99344 RVA: 0x0037DCDE File Offset: 0x0037BEDE
		public ESaveConfig Type { get; set; }

		// Token: 0x06018411 RID: 99345 RVA: 0x0037DCE7 File Offset: 0x0037BEE7
		public ISaveConfigTypeT()
		{
			this.Type = ESaveConfig.SaveNew;
		}
	}
}
