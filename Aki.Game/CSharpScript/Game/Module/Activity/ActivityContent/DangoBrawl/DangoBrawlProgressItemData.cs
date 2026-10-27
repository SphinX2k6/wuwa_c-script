using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067D2 RID: 26578
	public class DangoBrawlProgressItemData
	{
		// Token: 0x06042336 RID: 271158 RVA: 0x0100DAB9 File Offset: 0x0100BCB9
		public DangoBrawlProgressItemData()
		{
		}

		// Token: 0x06042337 RID: 271159 RVA: 0x0100DAC1 File Offset: 0x0100BCC1
		public DangoBrawlProgressItemData(int index)
		{
			this.Index = index;
		}

		// Token: 0x040228DD RID: 141533
		public int Index;

		// Token: 0x040228DE RID: 141534
		public bool IsWin;

		// Token: 0x040228DF RID: 141535
		public bool IsLast;

		// Token: 0x040228E0 RID: 141536
		public bool NeedAnim;
	}
}
