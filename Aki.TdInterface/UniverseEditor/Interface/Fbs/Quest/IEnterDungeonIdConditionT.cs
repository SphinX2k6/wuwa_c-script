using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DFE RID: 15870
	public class IEnterDungeonIdConditionT
	{
		// Token: 0x17006DAE RID: 28078
		// (get) Token: 0x06016331 RID: 90929 RVA: 0x00334B94 File Offset: 0x00332D94
		// (set) Token: 0x06016332 RID: 90930 RVA: 0x00334B9C File Offset: 0x00332D9C
		public EDungeonConditionType Type { get; set; }

		// Token: 0x17006DAF RID: 28079
		// (get) Token: 0x06016333 RID: 90931 RVA: 0x00334BA5 File Offset: 0x00332DA5
		// (set) Token: 0x06016334 RID: 90932 RVA: 0x00334BAD File Offset: 0x00332DAD
		public int DungeonId { get; set; }

		// Token: 0x06016335 RID: 90933 RVA: 0x00334BB6 File Offset: 0x00332DB6
		public IEnterDungeonIdConditionT()
		{
			this.Type = EDungeonConditionType.DungeonSubType;
			this.DungeonId = 0;
		}
	}
}
