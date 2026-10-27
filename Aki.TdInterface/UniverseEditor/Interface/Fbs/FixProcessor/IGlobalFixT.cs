using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x0200475B RID: 18267
	public class IGlobalFixT
	{
		// Token: 0x1700830F RID: 33551
		// (get) Token: 0x0601C1E7 RID: 115175 RVA: 0x003FBEFB File Offset: 0x003FA0FB
		// (set) Token: 0x0601C1E8 RID: 115176 RVA: 0x003FBF03 File Offset: 0x003FA103
		public int Id { get; set; }

		// Token: 0x17008310 RID: 33552
		// (get) Token: 0x0601C1E9 RID: 115177 RVA: 0x003FBF0C File Offset: 0x003FA10C
		// (set) Token: 0x0601C1EA RID: 115178 RVA: 0x003FBF14 File Offset: 0x003FA114
		public int DungeonId { get; set; }

		// Token: 0x17008311 RID: 33553
		// (get) Token: 0x0601C1EB RID: 115179 RVA: 0x003FBF1D File Offset: 0x003FA11D
		// (set) Token: 0x0601C1EC RID: 115180 RVA: 0x003FBF25 File Offset: 0x003FA125
		public int ExecuteCount { get; set; }

		// Token: 0x17008312 RID: 33554
		// (get) Token: 0x0601C1ED RID: 115181 RVA: 0x003FBF2E File Offset: 0x003FA12E
		// (set) Token: 0x0601C1EE RID: 115182 RVA: 0x003FBF36 File Offset: 0x003FA136
		public int ExecuteCycle { get; set; }

		// Token: 0x17008313 RID: 33555
		// (get) Token: 0x0601C1EF RID: 115183 RVA: 0x003FBF3F File Offset: 0x003FA13F
		// (set) Token: 0x0601C1F0 RID: 115184 RVA: 0x003FBF47 File Offset: 0x003FA147
		public IConditionGroupT Conditions { get; set; }

		// Token: 0x17008314 RID: 33556
		// (get) Token: 0x0601C1F1 RID: 115185 RVA: 0x003FBF50 File Offset: 0x003FA150
		// (set) Token: 0x0601C1F2 RID: 115186 RVA: 0x003FBF58 File Offset: 0x003FA158
		public IGlobalFixActionsT Actions { get; set; }

		// Token: 0x0601C1F3 RID: 115187 RVA: 0x003FBF61 File Offset: 0x003FA161
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
