using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004791 RID: 18321
	public class IEntitiesStateT
	{
		// Token: 0x1700836B RID: 33643
		// (get) Token: 0x0601C38B RID: 115595 RVA: 0x003FEEE5 File Offset: 0x003FD0E5
		// (set) Token: 0x0601C38C RID: 115596 RVA: 0x003FEEED File Offset: 0x003FD0ED
		public List<IEntityStateT> Entities { get; set; }

		// Token: 0x1700836C RID: 33644
		// (get) Token: 0x0601C38D RID: 115597 RVA: 0x003FEEF6 File Offset: 0x003FD0F6
		// (set) Token: 0x0601C38E RID: 115598 RVA: 0x003FEEFE File Offset: 0x003FD0FE
		public int LevelId { get; set; }

		// Token: 0x1700836D RID: 33645
		// (get) Token: 0x0601C38F RID: 115599 RVA: 0x003FEF07 File Offset: 0x003FD107
		// (set) Token: 0x0601C390 RID: 115600 RVA: 0x003FEF0F File Offset: 0x003FD10F
		public byte NullMask { get; set; }

		// Token: 0x0601C391 RID: 115601 RVA: 0x003FEF18 File Offset: 0x003FD118
		public IEntitiesStateT()
		{
			this.Entities = null;
			this.LevelId = 0;
			this.NullMask = 0;
		}
	}
}
