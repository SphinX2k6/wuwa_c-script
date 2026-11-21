using System;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D5F RID: 15711
	public interface IPhantomSelectItemData
	{
		// Token: 0x17005246 RID: 21062
		// (get) Token: 0x06028377 RID: 164727
		// (set) Token: 0x06028378 RID: 164728
		int PhantomId { get; set; }

		// Token: 0x17005247 RID: 21063
		// (get) Token: 0x06028379 RID: 164729
		// (set) Token: 0x0602837A RID: 164730
		int Index { get; set; }

		// Token: 0x17005248 RID: 21064
		// (get) Token: 0x0602837B RID: 164731
		// (set) Token: 0x0602837C RID: 164732
		bool IsLock { get; set; }
	}
}
