using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A51 RID: 23121
	public class ILevelAiCycleLooplyT
	{
		// Token: 0x1700A832 RID: 43058
		// (get) Token: 0x06025D24 RID: 154916 RVA: 0x0052F378 File Offset: 0x0052D578
		// (set) Token: 0x06025D25 RID: 154917 RVA: 0x0052F380 File Offset: 0x0052D580
		public ELevelAiCycleMode Type { get; set; }

		// Token: 0x1700A833 RID: 43059
		// (get) Token: 0x06025D26 RID: 154918 RVA: 0x0052F389 File Offset: 0x0052D589
		// (set) Token: 0x06025D27 RID: 154919 RVA: 0x0052F391 File Offset: 0x0052D591
		public bool IsCircle { get; set; }

		// Token: 0x06025D28 RID: 154920 RVA: 0x0052F39A File Offset: 0x0052D59A
		public ILevelAiCycleLooplyT()
		{
			this.Type = ELevelAiCycleMode.Loop;
			this.IsCircle = false;
		}
	}
}
