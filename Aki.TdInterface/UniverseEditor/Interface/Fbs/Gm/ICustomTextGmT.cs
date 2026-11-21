using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AA8 RID: 19112
	public class ICustomTextGmT
	{
		// Token: 0x170085DD RID: 34269
		// (get) Token: 0x0601CBB0 RID: 117680 RVA: 0x0040CADF File Offset: 0x0040ACDF
		// (set) Token: 0x0601CBB1 RID: 117681 RVA: 0x0040CAE7 File Offset: 0x0040ACE7
		public EGmCommand Type { get; set; }

		// Token: 0x170085DE RID: 34270
		// (get) Token: 0x0601CBB2 RID: 117682 RVA: 0x0040CAF0 File Offset: 0x0040ACF0
		// (set) Token: 0x0601CBB3 RID: 117683 RVA: 0x0040CAF8 File Offset: 0x0040ACF8
		public string Text { get; set; }

		// Token: 0x0601CBB4 RID: 117684 RVA: 0x0040CB01 File Offset: 0x0040AD01
		public ICustomTextGmT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.Text = null;
		}
	}
}
