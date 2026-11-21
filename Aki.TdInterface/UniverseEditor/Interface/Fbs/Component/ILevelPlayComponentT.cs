using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A66 RID: 23142
	public class ILevelPlayComponentT
	{
		// Token: 0x1700A873 RID: 43123
		// (get) Token: 0x06025E08 RID: 155144 RVA: 0x0053132A File Offset: 0x0052F52A
		// (set) Token: 0x06025E09 RID: 155145 RVA: 0x00531332 File Offset: 0x0052F532
		public bool Disabled { get; set; }

		// Token: 0x1700A874 RID: 43124
		// (get) Token: 0x06025E0A RID: 155146 RVA: 0x0053133B File Offset: 0x0052F53B
		// (set) Token: 0x06025E0B RID: 155147 RVA: 0x00531343 File Offset: 0x0052F543
		public int LevelPlayId { get; set; }

		// Token: 0x1700A875 RID: 43125
		// (get) Token: 0x06025E0C RID: 155148 RVA: 0x0053134C File Offset: 0x0052F54C
		// (set) Token: 0x06025E0D RID: 155149 RVA: 0x00531354 File Offset: 0x0052F554
		public byte NullMask { get; set; }

		// Token: 0x06025E0E RID: 155150 RVA: 0x0053135D File Offset: 0x0052F55D
		public ILevelPlayComponentT()
		{
			this.Disabled = false;
			this.LevelPlayId = 0;
			this.NullMask = 0;
		}
	}
}
