using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004BC3 RID: 19395
	public class IGlobalFixT
	{
		// Token: 0x17008950 RID: 35152
		// (get) Token: 0x0601D9BC RID: 121276 RVA: 0x00428197 File Offset: 0x00426397
		// (set) Token: 0x0601D9BD RID: 121277 RVA: 0x0042819F File Offset: 0x0042639F
		public int Id { get; set; }

		// Token: 0x17008951 RID: 35153
		// (get) Token: 0x0601D9BE RID: 121278 RVA: 0x004281A8 File Offset: 0x004263A8
		// (set) Token: 0x0601D9BF RID: 121279 RVA: 0x004281B0 File Offset: 0x004263B0
		public int DungeonId { get; set; }

		// Token: 0x17008952 RID: 35154
		// (get) Token: 0x0601D9C0 RID: 121280 RVA: 0x004281B9 File Offset: 0x004263B9
		// (set) Token: 0x0601D9C1 RID: 121281 RVA: 0x004281C1 File Offset: 0x004263C1
		public int ExecuteCount { get; set; }

		// Token: 0x17008953 RID: 35155
		// (get) Token: 0x0601D9C2 RID: 121282 RVA: 0x004281CA File Offset: 0x004263CA
		// (set) Token: 0x0601D9C3 RID: 121283 RVA: 0x004281D2 File Offset: 0x004263D2
		public int ExecuteCycle { get; set; }

		// Token: 0x17008954 RID: 35156
		// (get) Token: 0x0601D9C4 RID: 121284 RVA: 0x004281DB File Offset: 0x004263DB
		// (set) Token: 0x0601D9C5 RID: 121285 RVA: 0x004281E3 File Offset: 0x004263E3
		public IConditionGroupT Conditions { get; set; }

		// Token: 0x17008955 RID: 35157
		// (get) Token: 0x0601D9C6 RID: 121286 RVA: 0x004281EC File Offset: 0x004263EC
		// (set) Token: 0x0601D9C7 RID: 121287 RVA: 0x004281F4 File Offset: 0x004263F4
		public IGlobalFixActionsT Actions { get; set; }

		// Token: 0x0601D9C8 RID: 121288 RVA: 0x004281FD File Offset: 0x004263FD
		public IGlobalFixT()
		{
			this.Id = 0;
			this.DungeonId = 0;
			this.ExecuteCount = 0;
			this.ExecuteCycle = 0;
			this.Conditions = null;
			this.Actions = null;
		}
	}
}
