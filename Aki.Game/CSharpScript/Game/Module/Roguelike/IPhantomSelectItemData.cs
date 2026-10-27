using System;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004D96 RID: 19862
	public interface IPhantomSelectItemData
	{
		// Token: 0x17007E96 RID: 32406
		// (get) Token: 0x0603350A RID: 210186
		// (set) Token: 0x0603350B RID: 210187
		int PhantomId { get; set; }

		// Token: 0x17007E97 RID: 32407
		// (get) Token: 0x0603350C RID: 210188
		// (set) Token: 0x0603350D RID: 210189
		int Index { get; set; }

		// Token: 0x17007E98 RID: 32408
		// (get) Token: 0x0603350E RID: 210190
		// (set) Token: 0x0603350F RID: 210191
		bool IsLock { get; set; }
	}
}
