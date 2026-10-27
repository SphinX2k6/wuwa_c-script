using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E1A RID: 28186
	public class IReduceTimeT
	{
		// Token: 0x1700D218 RID: 53784
		// (get) Token: 0x06031CDD RID: 203997 RVA: 0x006BE301 File Offset: 0x006BC501
		// (set) Token: 0x06031CDE RID: 203998 RVA: 0x006BE309 File Offset: 0x006BC509
		public EChangeTimerType Type { get; set; }

		// Token: 0x1700D219 RID: 53785
		// (get) Token: 0x06031CDF RID: 203999 RVA: 0x006BE312 File Offset: 0x006BC512
		// (set) Token: 0x06031CE0 RID: 204000 RVA: 0x006BE31A File Offset: 0x006BC51A
		public int Time { get; set; }

		// Token: 0x1700D21A RID: 53786
		// (get) Token: 0x06031CE1 RID: 204001 RVA: 0x006BE323 File Offset: 0x006BC523
		// (set) Token: 0x06031CE2 RID: 204002 RVA: 0x006BE32B File Offset: 0x006BC52B
		public TVarRefUnion VarForTime { get; set; }

		// Token: 0x1700D21B RID: 53787
		// (get) Token: 0x06031CE3 RID: 204003 RVA: 0x006BE334 File Offset: 0x006BC534
		// (set) Token: 0x06031CE4 RID: 204004 RVA: 0x006BE33C File Offset: 0x006BC53C
		public IChangeTimerUiConfigT UiConfig { get; set; }

		// Token: 0x1700D21C RID: 53788
		// (get) Token: 0x06031CE5 RID: 204005 RVA: 0x006BE345 File Offset: 0x006BC545
		// (set) Token: 0x06031CE6 RID: 204006 RVA: 0x006BE34D File Offset: 0x006BC54D
		public byte NullMask { get; set; }

		// Token: 0x06031CE7 RID: 204007 RVA: 0x006BE356 File Offset: 0x006BC556
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
