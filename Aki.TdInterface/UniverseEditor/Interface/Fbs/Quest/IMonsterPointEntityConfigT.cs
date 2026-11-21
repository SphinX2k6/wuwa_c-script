using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200437D RID: 17277
	public class IMonsterPointEntityConfigT
	{
		// Token: 0x1700768B RID: 30347
		// (get) Token: 0x06018697 RID: 99991 RVA: 0x0037AF08 File Offset: 0x00379108
		// (set) Token: 0x06018698 RID: 99992 RVA: 0x0037AF10 File Offset: 0x00379110
		public int EntityId { get; set; }

		// Token: 0x1700768C RID: 30348
		// (get) Token: 0x06018699 RID: 99993 RVA: 0x0037AF19 File Offset: 0x00379119
		// (set) Token: 0x0601869A RID: 99994 RVA: 0x0037AF21 File Offset: 0x00379121
		public int Point { get; set; }

		// Token: 0x0601869B RID: 99995 RVA: 0x0037AF2A File Offset: 0x0037912A
		public IMonsterPointEntityConfigT()
		{
			this.EntityId = 0;
			this.Point = 0;
		}
	}
}
