using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E7F RID: 15999
	public class IGradingSystemConfigT
	{
		// Token: 0x17006EFA RID: 28410
		// (get) Token: 0x060168CF RID: 92367 RVA: 0x00342327 File Offset: 0x00340527
		// (set) Token: 0x060168D0 RID: 92368 RVA: 0x0034232F File Offset: 0x0034052F
		public EEnableSystemType Type { get; set; }

		// Token: 0x17006EFB RID: 28411
		// (get) Token: 0x060168D1 RID: 92369 RVA: 0x00342338 File Offset: 0x00340538
		// (set) Token: 0x060168D2 RID: 92370 RVA: 0x00342340 File Offset: 0x00340540
		public int GradingSystemId { get; set; }

		// Token: 0x17006EFC RID: 28412
		// (get) Token: 0x060168D3 RID: 92371 RVA: 0x00342349 File Offset: 0x00340549
		// (set) Token: 0x060168D4 RID: 92372 RVA: 0x00342351 File Offset: 0x00340551
		public List<IGradingSystemVarT> Vars { get; set; }

		// Token: 0x17006EFD RID: 28413
		// (get) Token: 0x060168D5 RID: 92373 RVA: 0x0034235A File Offset: 0x0034055A
		// (set) Token: 0x060168D6 RID: 92374 RVA: 0x00342362 File Offset: 0x00340562
		public byte NullMask { get; set; }

		// Token: 0x060168D7 RID: 92375 RVA: 0x0034236B File Offset: 0x0034056B
		public IGradingSystemConfigT()
		{
			this.Type = EEnableSystemType.GradingSystem;
			this.GradingSystemId = 0;
			this.Vars = null;
			this.NullMask = 0;
		}
	}
}
