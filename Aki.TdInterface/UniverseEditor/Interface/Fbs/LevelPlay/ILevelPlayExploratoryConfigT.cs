using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044EF RID: 17647
	public class ILevelPlayExploratoryConfigT
	{
		// Token: 0x17007D0D RID: 32013
		// (get) Token: 0x0601A7B9 RID: 108473 RVA: 0x003C8901 File Offset: 0x003C6B01
		// (set) Token: 0x0601A7BA RID: 108474 RVA: 0x003C8909 File Offset: 0x003C6B09
		public ELevelPlayExploratoryCheckTiming When { get; set; }

		// Token: 0x17007D0E RID: 32014
		// (get) Token: 0x0601A7BB RID: 108475 RVA: 0x003C8912 File Offset: 0x003C6B12
		// (set) Token: 0x0601A7BC RID: 108476 RVA: 0x003C891A File Offset: 0x003C6B1A
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17007D0F RID: 32015
		// (get) Token: 0x0601A7BD RID: 108477 RVA: 0x003C8923 File Offset: 0x003C6B23
		// (set) Token: 0x0601A7BE RID: 108478 RVA: 0x003C892B File Offset: 0x003C6B2B
		public int AddType { get; set; }

		// Token: 0x17007D10 RID: 32016
		// (get) Token: 0x0601A7BF RID: 108479 RVA: 0x003C8934 File Offset: 0x003C6B34
		// (set) Token: 0x0601A7C0 RID: 108480 RVA: 0x003C893C File Offset: 0x003C6B3C
		public int AreaId { get; set; }

		// Token: 0x17007D11 RID: 32017
		// (get) Token: 0x0601A7C1 RID: 108481 RVA: 0x003C8945 File Offset: 0x003C6B45
		// (set) Token: 0x0601A7C2 RID: 108482 RVA: 0x003C894D File Offset: 0x003C6B4D
		public byte NullMask { get; set; }

		// Token: 0x0601A7C3 RID: 108483 RVA: 0x003C8956 File Offset: 0x003C6B56
		public ILevelPlayExploratoryConfigT()
		{
			this.When = ELevelPlayExploratoryCheckTiming.OnCompletion;
			this.Condition = null;
			this.AddType = 0;
			this.AreaId = 0;
			this.NullMask = 0;
		}
	}
}
