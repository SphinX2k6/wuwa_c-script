using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041C4 RID: 16836
	public class ITetrisPlayModeEndlessT
	{
		// Token: 0x1700775E RID: 30558
		// (get) Token: 0x06018CBA RID: 101562 RVA: 0x00391A0E File Offset: 0x0038FC0E
		// (set) Token: 0x06018CBB RID: 101563 RVA: 0x00391A16 File Offset: 0x0038FC16
		public ETetrisPlayMode Type { get; set; }

		// Token: 0x1700775F RID: 30559
		// (get) Token: 0x06018CBC RID: 101564 RVA: 0x00391A1F File Offset: 0x0038FC1F
		// (set) Token: 0x06018CBD RID: 101565 RVA: 0x00391A27 File Offset: 0x0038FC27
		public int SpeedLevel { get; set; }

		// Token: 0x17007760 RID: 30560
		// (get) Token: 0x06018CBE RID: 101566 RVA: 0x00391A30 File Offset: 0x0038FC30
		// (set) Token: 0x06018CBF RID: 101567 RVA: 0x00391A38 File Offset: 0x0038FC38
		public byte NullMask { get; set; }

		// Token: 0x06018CC0 RID: 101568 RVA: 0x00391A41 File Offset: 0x0038FC41
		public ITetrisPlayModeEndlessT()
		{
			this.Type = ETetrisPlayMode.Normal;
			this.SpeedLevel = 0;
			this.NullMask = 0;
		}
	}
}
