using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051D0 RID: 20944
	public class ISpecifyRoleLevelT
	{
		// Token: 0x170095F6 RID: 38390
		// (get) Token: 0x06020F95 RID: 135061 RVA: 0x0048F0F4 File Offset: 0x0048D2F4
		// (set) Token: 0x06020F96 RID: 135062 RVA: 0x0048F0FC File Offset: 0x0048D2FC
		public ERoleLevelType Type { get; set; }

		// Token: 0x170095F7 RID: 38391
		// (get) Token: 0x06020F97 RID: 135063 RVA: 0x0048F105 File Offset: 0x0048D305
		// (set) Token: 0x06020F98 RID: 135064 RVA: 0x0048F10D File Offset: 0x0048D30D
		public int Index { get; set; }

		// Token: 0x170095F8 RID: 38392
		// (get) Token: 0x06020F99 RID: 135065 RVA: 0x0048F116 File Offset: 0x0048D316
		// (set) Token: 0x06020F9A RID: 135066 RVA: 0x0048F11E File Offset: 0x0048D31E
		public ECompare Compare { get; set; }

		// Token: 0x170095F9 RID: 38393
		// (get) Token: 0x06020F9B RID: 135067 RVA: 0x0048F127 File Offset: 0x0048D327
		// (set) Token: 0x06020F9C RID: 135068 RVA: 0x0048F12F File Offset: 0x0048D32F
		public int Level { get; set; }

		// Token: 0x06020F9D RID: 135069 RVA: 0x0048F138 File Offset: 0x0048D338
		public ISpecifyRoleLevelT()
		{
			this.Type = ERoleLevelType.SpecifyRole;
			this.Index = 0;
			this.Compare = ECompare.Eq;
			this.Level = 0;
		}
	}
}
