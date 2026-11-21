using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049C3 RID: 18883
	public class IRollBlockGlobalConfigT
	{
		// Token: 0x17008436 RID: 33846
		// (get) Token: 0x0601C38E RID: 115598 RVA: 0x003FC2D6 File Offset: 0x003FA4D6
		// (set) Token: 0x0601C38F RID: 115599 RVA: 0x003FC2DE File Offset: 0x003FA4DE
		public int Id { get; set; }

		// Token: 0x17008437 RID: 33847
		// (get) Token: 0x0601C390 RID: 115600 RVA: 0x003FC2E7 File Offset: 0x003FA4E7
		// (set) Token: 0x0601C391 RID: 115601 RVA: 0x003FC2EF File Offset: 0x003FA4EF
		public string GroupName { get; set; }

		// Token: 0x17008438 RID: 33848
		// (get) Token: 0x0601C392 RID: 115602 RVA: 0x003FC2F8 File Offset: 0x003FA4F8
		// (set) Token: 0x0601C393 RID: 115603 RVA: 0x003FC300 File Offset: 0x003FA500
		public List<IRollBlockLevelConfigT> Levels { get; set; }

		// Token: 0x0601C394 RID: 115604 RVA: 0x003FC309 File Offset: 0x003FA509
		public IRollBlockGlobalConfigT()
		{
			this.Id = 0;
			this.GroupName = null;
			this.Levels = null;
		}
	}
}
