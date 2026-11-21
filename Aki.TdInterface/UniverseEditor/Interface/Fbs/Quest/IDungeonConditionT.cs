using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200421E RID: 16926
	public class IDungeonConditionT
	{
		// Token: 0x1700734D RID: 29517
		// (get) Token: 0x0601784A RID: 96330 RVA: 0x0035B8A8 File Offset: 0x00359AA8
		// (set) Token: 0x0601784B RID: 96331 RVA: 0x0035B8B0 File Offset: 0x00359AB0
		public EDungeonConditionType Type { get; set; }

		// Token: 0x1700734E RID: 29518
		// (get) Token: 0x0601784C RID: 96332 RVA: 0x0035B8B9 File Offset: 0x00359AB9
		// (set) Token: 0x0601784D RID: 96333 RVA: 0x0035B8C1 File Offset: 0x00359AC1
		public int Count { get; set; }

		// Token: 0x1700734F RID: 29519
		// (get) Token: 0x0601784E RID: 96334 RVA: 0x0035B8CA File Offset: 0x00359ACA
		// (set) Token: 0x0601784F RID: 96335 RVA: 0x0035B8D2 File Offset: 0x00359AD2
		public bool IsExitDungeon { get; set; }

		// Token: 0x17007350 RID: 29520
		// (get) Token: 0x06017850 RID: 96336 RVA: 0x0035B8DB File Offset: 0x00359ADB
		// (set) Token: 0x06017851 RID: 96337 RVA: 0x0035B8E3 File Offset: 0x00359AE3
		public byte NullMask { get; set; }

		// Token: 0x06017852 RID: 96338 RVA: 0x0035B8EC File Offset: 0x00359AEC
		public IDungeonConditionT()
		{
			this.Type = EDungeonConditionType.DungeonSubType;
			this.Count = 0;
			this.IsExitDungeon = false;
			this.NullMask = 0;
		}
	}
}
