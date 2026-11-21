using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AF9 RID: 19193
	public class ISetTimeT
	{
		// Token: 0x1700867F RID: 34431
		// (get) Token: 0x0601CEB0 RID: 118448 RVA: 0x00411A74 File Offset: 0x0040FC74
		// (set) Token: 0x0601CEB1 RID: 118449 RVA: 0x00411A7C File Offset: 0x0040FC7C
		public EGmCommand Type { get; set; }

		// Token: 0x17008680 RID: 34432
		// (get) Token: 0x0601CEB2 RID: 118450 RVA: 0x00411A85 File Offset: 0x0040FC85
		// (set) Token: 0x0601CEB3 RID: 118451 RVA: 0x00411A8D File Offset: 0x0040FC8D
		public int Hour { get; set; }

		// Token: 0x17008681 RID: 34433
		// (get) Token: 0x0601CEB4 RID: 118452 RVA: 0x00411A96 File Offset: 0x0040FC96
		// (set) Token: 0x0601CEB5 RID: 118453 RVA: 0x00411A9E File Offset: 0x0040FC9E
		public int Minute { get; set; }

		// Token: 0x17008682 RID: 34434
		// (get) Token: 0x0601CEB6 RID: 118454 RVA: 0x00411AA7 File Offset: 0x0040FCA7
		// (set) Token: 0x0601CEB7 RID: 118455 RVA: 0x00411AAF File Offset: 0x0040FCAF
		public bool ShowUi { get; set; }

		// Token: 0x0601CEB8 RID: 118456 RVA: 0x00411AB8 File Offset: 0x0040FCB8
		public ISetTimeT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.Hour = 0;
			this.Minute = 0;
			this.ShowUi = false;
		}
	}
}
