using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005722 RID: 22306
	public class DangoBrawlProgressItemData
	{
		// Token: 0x06036E8C RID: 224908 RVA: 0x00F4EF89 File Offset: 0x00F4D189
		public DangoBrawlProgressItemData()
		{
		}

		// Token: 0x06036E8D RID: 224909 RVA: 0x00F4EF91 File Offset: 0x00F4D191
		public DangoBrawlProgressItemData(int index)
		{
			this.Index = index;
		}

		// Token: 0x0401D13A RID: 119098
		public int Index;

		// Token: 0x0401D13B RID: 119099
		public bool IsWin;

		// Token: 0x0401D13C RID: 119100
		public bool IsLast;

		// Token: 0x0401D13D RID: 119101
		public bool NeedAnim;
	}
}
