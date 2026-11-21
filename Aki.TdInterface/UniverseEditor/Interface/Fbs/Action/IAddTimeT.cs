using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200679D RID: 26525
	public class IAddTimeT
	{
		// Token: 0x1700C0F3 RID: 49395
		// (get) Token: 0x0602CFF3 RID: 184307 RVA: 0x00626795 File Offset: 0x00624995
		// (set) Token: 0x0602CFF4 RID: 184308 RVA: 0x0062679D File Offset: 0x0062499D
		public EChangeTimerType Type { get; set; }

		// Token: 0x1700C0F4 RID: 49396
		// (get) Token: 0x0602CFF5 RID: 184309 RVA: 0x006267A6 File Offset: 0x006249A6
		// (set) Token: 0x0602CFF6 RID: 184310 RVA: 0x006267AE File Offset: 0x006249AE
		public int Time { get; set; }

		// Token: 0x1700C0F5 RID: 49397
		// (get) Token: 0x0602CFF7 RID: 184311 RVA: 0x006267B7 File Offset: 0x006249B7
		// (set) Token: 0x0602CFF8 RID: 184312 RVA: 0x006267BF File Offset: 0x006249BF
		public TVarRefUnion VarForTime { get; set; }

		// Token: 0x1700C0F6 RID: 49398
		// (get) Token: 0x0602CFF9 RID: 184313 RVA: 0x006267C8 File Offset: 0x006249C8
		// (set) Token: 0x0602CFFA RID: 184314 RVA: 0x006267D0 File Offset: 0x006249D0
		public IChangeTimerUiConfigT UiConfig { get; set; }

		// Token: 0x1700C0F7 RID: 49399
		// (get) Token: 0x0602CFFB RID: 184315 RVA: 0x006267D9 File Offset: 0x006249D9
		// (set) Token: 0x0602CFFC RID: 184316 RVA: 0x006267E1 File Offset: 0x006249E1
		public byte NullMask { get; set; }

		// Token: 0x0602CFFD RID: 184317 RVA: 0x006267EA File Offset: 0x006249EA
		public IAddTimeT()
		{
			this.Type = EChangeTimerType.Add;
			this.Time = 0;
			this.VarForTime = null;
			this.UiConfig = new IChangeTimerUiConfigT();
			this.NullMask = 0;
		}
	}
}
