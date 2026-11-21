using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004350 RID: 17232
	public class ILogicNodeOccupationT
	{
		// Token: 0x1700763A RID: 30266
		// (get) Token: 0x0601850A RID: 99594 RVA: 0x00377FE9 File Offset: 0x003761E9
		// (set) Token: 0x0601850B RID: 99595 RVA: 0x00377FF1 File Offset: 0x003761F1
		public List<string> Occupations { get; set; }

		// Token: 0x1700763B RID: 30267
		// (get) Token: 0x0601850C RID: 99596 RVA: 0x00377FFA File Offset: 0x003761FA
		// (set) Token: 0x0601850D RID: 99597 RVA: 0x00378002 File Offset: 0x00376202
		public string TidDesc { get; set; }

		// Token: 0x1700763C RID: 30268
		// (get) Token: 0x0601850E RID: 99598 RVA: 0x0037800B File Offset: 0x0037620B
		// (set) Token: 0x0601850F RID: 99599 RVA: 0x00378013 File Offset: 0x00376213
		public List<IActionInfoT> ExitActions { get; set; }

		// Token: 0x1700763D RID: 30269
		// (get) Token: 0x06018510 RID: 99600 RVA: 0x0037801C File Offset: 0x0037621C
		// (set) Token: 0x06018511 RID: 99601 RVA: 0x00378024 File Offset: 0x00376224
		public List<IActionInfoT> ReenterActions { get; set; }

		// Token: 0x1700763E RID: 30270
		// (get) Token: 0x06018512 RID: 99602 RVA: 0x0037802D File Offset: 0x0037622D
		// (set) Token: 0x06018513 RID: 99603 RVA: 0x00378035 File Offset: 0x00376235
		public List<int> BanInteractEntities { get; set; }

		// Token: 0x1700763F RID: 30271
		// (get) Token: 0x06018514 RID: 99604 RVA: 0x0037803E File Offset: 0x0037623E
		// (set) Token: 0x06018515 RID: 99605 RVA: 0x00378046 File Offset: 0x00376246
		public bool ReclaimOccupationWhenEnter { get; set; }

		// Token: 0x17007640 RID: 30272
		// (get) Token: 0x06018516 RID: 99606 RVA: 0x0037804F File Offset: 0x0037624F
		// (set) Token: 0x06018517 RID: 99607 RVA: 0x00378057 File Offset: 0x00376257
		public byte NullMask { get; set; }

		// Token: 0x06018518 RID: 99608 RVA: 0x00378060 File Offset: 0x00376260
		public ILogicNodeOccupationT()
		{
			this.Occupations = null;
			this.TidDesc = null;
			this.ExitActions = null;
			this.ReenterActions = null;
			this.BanInteractEntities = null;
			this.ReclaimOccupationWhenEnter = false;
			this.NullMask = 0;
		}
	}
}
