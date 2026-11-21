using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E04 RID: 32260
	public class IWaitT
	{
		// Token: 0x1700F1A8 RID: 61864
		// (get) Token: 0x0603A4D1 RID: 238801 RVA: 0x007DAE55 File Offset: 0x007D9055
		// (set) Token: 0x0603A4D2 RID: 238802 RVA: 0x007DAE5D File Offset: 0x007D905D
		public float Min { get; set; }

		// Token: 0x1700F1A9 RID: 61865
		// (get) Token: 0x0603A4D3 RID: 238803 RVA: 0x007DAE66 File Offset: 0x007D9066
		// (set) Token: 0x0603A4D4 RID: 238804 RVA: 0x007DAE6E File Offset: 0x007D906E
		public float Time { get; set; }

		// Token: 0x1700F1AA RID: 61866
		// (get) Token: 0x0603A4D5 RID: 238805 RVA: 0x007DAE77 File Offset: 0x007D9077
		// (set) Token: 0x0603A4D6 RID: 238806 RVA: 0x007DAE7F File Offset: 0x007D907F
		public bool BanInput { get; set; }

		// Token: 0x1700F1AB RID: 61867
		// (get) Token: 0x0603A4D7 RID: 238807 RVA: 0x007DAE88 File Offset: 0x007D9088
		// (set) Token: 0x0603A4D8 RID: 238808 RVA: 0x007DAE90 File Offset: 0x007D9090
		public IVarIntervalT WaitInterval { get; set; }

		// Token: 0x1700F1AC RID: 61868
		// (get) Token: 0x0603A4D9 RID: 238809 RVA: 0x007DAE99 File Offset: 0x007D9099
		// (set) Token: 0x0603A4DA RID: 238810 RVA: 0x007DAEA1 File Offset: 0x007D90A1
		public byte NullMask { get; set; }

		// Token: 0x0603A4DB RID: 238811 RVA: 0x007DAEAA File Offset: 0x007D90AA
		public IWaitT()
		{
			this.Min = 0f;
			this.Time = 0f;
			this.BanInput = false;
			this.WaitInterval = null;
			this.NullMask = 0;
		}
	}
}
