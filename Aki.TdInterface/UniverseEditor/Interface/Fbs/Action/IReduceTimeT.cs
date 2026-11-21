using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007598 RID: 30104
	public class IReduceTimeT
	{
		// Token: 0x1700DD67 RID: 56679
		// (get) Token: 0x06034CF3 RID: 216307 RVA: 0x00719C89 File Offset: 0x00717E89
		// (set) Token: 0x06034CF4 RID: 216308 RVA: 0x00719C91 File Offset: 0x00717E91
		public EChangeTimerType Type { get; set; }

		// Token: 0x1700DD68 RID: 56680
		// (get) Token: 0x06034CF5 RID: 216309 RVA: 0x00719C9A File Offset: 0x00717E9A
		// (set) Token: 0x06034CF6 RID: 216310 RVA: 0x00719CA2 File Offset: 0x00717EA2
		public int Time { get; set; }

		// Token: 0x1700DD69 RID: 56681
		// (get) Token: 0x06034CF7 RID: 216311 RVA: 0x00719CAB File Offset: 0x00717EAB
		// (set) Token: 0x06034CF8 RID: 216312 RVA: 0x00719CB3 File Offset: 0x00717EB3
		public TVarRefUnion VarForTime { get; set; }

		// Token: 0x1700DD6A RID: 56682
		// (get) Token: 0x06034CF9 RID: 216313 RVA: 0x00719CBC File Offset: 0x00717EBC
		// (set) Token: 0x06034CFA RID: 216314 RVA: 0x00719CC4 File Offset: 0x00717EC4
		public IChangeTimerUiConfigT UiConfig { get; set; }

		// Token: 0x1700DD6B RID: 56683
		// (get) Token: 0x06034CFB RID: 216315 RVA: 0x00719CCD File Offset: 0x00717ECD
		// (set) Token: 0x06034CFC RID: 216316 RVA: 0x00719CD5 File Offset: 0x00717ED5
		public byte NullMask { get; set; }

		// Token: 0x06034CFD RID: 216317 RVA: 0x00719CDE File Offset: 0x00717EDE
		public IReduceTimeT()
		{
			this.Type = EChangeTimerType.Add;
			this.Time = 0;
			this.VarForTime = null;
			this.UiConfig = new IChangeTimerUiConfigT();
			this.NullMask = 0;
		}
	}
}
