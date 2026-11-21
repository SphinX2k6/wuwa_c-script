using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200461D RID: 17949
	public class ITetrisPlayModeEndlessT
	{
		// Token: 0x17007D8A RID: 32138
		// (get) Token: 0x0601A410 RID: 107536 RVA: 0x003BCE62 File Offset: 0x003BB062
		// (set) Token: 0x0601A411 RID: 107537 RVA: 0x003BCE6A File Offset: 0x003BB06A
		public ETetrisPlayMode Type { get; set; }

		// Token: 0x17007D8B RID: 32139
		// (get) Token: 0x0601A412 RID: 107538 RVA: 0x003BCE73 File Offset: 0x003BB073
		// (set) Token: 0x0601A413 RID: 107539 RVA: 0x003BCE7B File Offset: 0x003BB07B
		public int SpeedLevel { get; set; }

		// Token: 0x17007D8C RID: 32140
		// (get) Token: 0x0601A414 RID: 107540 RVA: 0x003BCE84 File Offset: 0x003BB084
		// (set) Token: 0x0601A415 RID: 107541 RVA: 0x003BCE8C File Offset: 0x003BB08C
		public byte NullMask { get; set; }

		// Token: 0x0601A416 RID: 107542 RVA: 0x003BCE95 File Offset: 0x003BB095
		public ITetrisPlayModeEndlessT()
		{
			this.Type = ETetrisPlayMode.Normal;
			this.SpeedLevel = 0;
			this.NullMask = 0;
		}
	}
}
