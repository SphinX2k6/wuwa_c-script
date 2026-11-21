using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200464D RID: 17997
	public class ITrackEffectAutoChangeT
	{
		// Token: 0x17007E06 RID: 32262
		// (get) Token: 0x0601A5EE RID: 108014 RVA: 0x003C1042 File Offset: 0x003BF242
		// (set) Token: 0x0601A5EF RID: 108015 RVA: 0x003C104A File Offset: 0x003BF24A
		public ETrackEffectType Type { get; set; }

		// Token: 0x17007E07 RID: 32263
		// (get) Token: 0x0601A5F0 RID: 108016 RVA: 0x003C1053 File Offset: 0x003BF253
		// (set) Token: 0x0601A5F1 RID: 108017 RVA: 0x003C105B File Offset: 0x003BF25B
		public int EnterRange { get; set; }

		// Token: 0x17007E08 RID: 32264
		// (get) Token: 0x0601A5F2 RID: 108018 RVA: 0x003C1064 File Offset: 0x003BF264
		// (set) Token: 0x0601A5F3 RID: 108019 RVA: 0x003C106C File Offset: 0x003BF26C
		public int LeaveRange { get; set; }

		// Token: 0x0601A5F4 RID: 108020 RVA: 0x003C1075 File Offset: 0x003BF275
		public ITrackEffectAutoChangeT()
		{
			this.Type = ETrackEffectType.AutoChange;
			this.EnterRange = 0;
			this.LeaveRange = 0;
		}
	}
}
