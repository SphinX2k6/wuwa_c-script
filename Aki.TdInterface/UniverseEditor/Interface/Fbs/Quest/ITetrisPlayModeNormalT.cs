using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004623 RID: 17955
	public class ITetrisPlayModeNormalT
	{
		// Token: 0x17007D9B RID: 32155
		// (get) Token: 0x0601A44C RID: 107596 RVA: 0x003BD470 File Offset: 0x003BB670
		// (set) Token: 0x0601A44D RID: 107597 RVA: 0x003BD478 File Offset: 0x003BB678
		public ETetrisPlayMode Type { get; set; }

		// Token: 0x17007D9C RID: 32156
		// (get) Token: 0x0601A44E RID: 107598 RVA: 0x003BD481 File Offset: 0x003BB681
		// (set) Token: 0x0601A44F RID: 107599 RVA: 0x003BD489 File Offset: 0x003BB689
		public int Time { get; set; }

		// Token: 0x0601A450 RID: 107600 RVA: 0x003BD492 File Offset: 0x003BB692
		public ITetrisPlayModeNormalT()
		{
			this.Type = ETetrisPlayMode.Normal;
			this.Time = 0;
		}
	}
}
