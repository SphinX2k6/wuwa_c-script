using System;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D60 RID: 15712
	public class PhantomSelectItemData : IPhantomSelectItemData
	{
		// Token: 0x17005249 RID: 21065
		// (get) Token: 0x0602837D RID: 164733 RVA: 0x00B436F2 File Offset: 0x00B418F2
		// (set) Token: 0x0602837E RID: 164734 RVA: 0x00B436FA File Offset: 0x00B418FA
		public int PhantomId { get; set; }

		// Token: 0x1700524A RID: 21066
		// (get) Token: 0x0602837F RID: 164735 RVA: 0x00B43703 File Offset: 0x00B41903
		// (set) Token: 0x06028380 RID: 164736 RVA: 0x00B4370B File Offset: 0x00B4190B
		public int Index { get; set; }

		// Token: 0x1700524B RID: 21067
		// (get) Token: 0x06028381 RID: 164737 RVA: 0x00B43714 File Offset: 0x00B41914
		// (set) Token: 0x06028382 RID: 164738 RVA: 0x00B4371C File Offset: 0x00B4191C
		public bool IsLock { get; set; }
	}
}
