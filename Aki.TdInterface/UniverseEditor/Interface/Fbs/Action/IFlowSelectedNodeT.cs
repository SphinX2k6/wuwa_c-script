using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EA0 RID: 28320
	public class IFlowSelectedNodeT
	{
		// Token: 0x1700CFBB RID: 53179
		// (get) Token: 0x06030FD4 RID: 200660 RVA: 0x006A5346 File Offset: 0x006A3546
		// (set) Token: 0x06030FD5 RID: 200661 RVA: 0x006A534E File Offset: 0x006A354E
		public int FlowId { get; set; }

		// Token: 0x1700CFBC RID: 53180
		// (get) Token: 0x06030FD6 RID: 200662 RVA: 0x006A5357 File Offset: 0x006A3557
		// (set) Token: 0x06030FD7 RID: 200663 RVA: 0x006A535F File Offset: 0x006A355F
		public int StateId { get; set; }

		// Token: 0x1700CFBD RID: 53181
		// (get) Token: 0x06030FD8 RID: 200664 RVA: 0x006A5368 File Offset: 0x006A3568
		// (set) Token: 0x06030FD9 RID: 200665 RVA: 0x006A5370 File Offset: 0x006A3570
		public byte NullMask { get; set; }

		// Token: 0x06030FDA RID: 200666 RVA: 0x006A5379 File Offset: 0x006A3579
		public IFlowSelectedNodeT()
		{
			this.FlowId = 0;
			this.StateId = 0;
			this.NullMask = 0;
		}
	}
}
