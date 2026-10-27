using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DE3 RID: 15843
	public class IDungeonConditionT
	{
		// Token: 0x17006D6D RID: 28013
		// (get) Token: 0x0601622B RID: 90667 RVA: 0x00332EA4 File Offset: 0x003310A4
		// (set) Token: 0x0601622C RID: 90668 RVA: 0x00332EAC File Offset: 0x003310AC
		public EDungeonConditionType Type { get; set; }

		// Token: 0x17006D6E RID: 28014
		// (get) Token: 0x0601622D RID: 90669 RVA: 0x00332EB5 File Offset: 0x003310B5
		// (set) Token: 0x0601622E RID: 90670 RVA: 0x00332EBD File Offset: 0x003310BD
		public int Count { get; set; }

		// Token: 0x17006D6F RID: 28015
		// (get) Token: 0x0601622F RID: 90671 RVA: 0x00332EC6 File Offset: 0x003310C6
		// (set) Token: 0x06016230 RID: 90672 RVA: 0x00332ECE File Offset: 0x003310CE
		public bool IsExitDungeon { get; set; }

		// Token: 0x17006D70 RID: 28016
		// (get) Token: 0x06016231 RID: 90673 RVA: 0x00332ED7 File Offset: 0x003310D7
		// (set) Token: 0x06016232 RID: 90674 RVA: 0x00332EDF File Offset: 0x003310DF
		public byte NullMask { get; set; }

		// Token: 0x06016233 RID: 90675 RVA: 0x00332EE8 File Offset: 0x003310E8
		public IDungeonConditionT()
		{
			this.Type = EDungeonConditionType.DungeonSubType;
			this.Count = 0;
			this.IsExitDungeon = false;
			this.NullMask = 0;
		}
	}
}
