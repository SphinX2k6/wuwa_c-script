using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B2E RID: 27438
	public class IConeRangeCheckT
	{
		// Token: 0x1700C981 RID: 51585
		// (get) Token: 0x0602F366 RID: 193382 RVA: 0x0067290F File Offset: 0x00670B0F
		// (set) Token: 0x0602F367 RID: 193383 RVA: 0x00672917 File Offset: 0x00670B17
		public ERangeCheckType Type { get; set; }

		// Token: 0x1700C982 RID: 51586
		// (get) Token: 0x0602F368 RID: 193384 RVA: 0x00672920 File Offset: 0x00670B20
		// (set) Token: 0x0602F369 RID: 193385 RVA: 0x00672928 File Offset: 0x00670B28
		public IVectorInfoT CenterOffset { get; set; }

		// Token: 0x1700C983 RID: 51587
		// (get) Token: 0x0602F36A RID: 193386 RVA: 0x00672931 File Offset: 0x00670B31
		// (set) Token: 0x0602F36B RID: 193387 RVA: 0x00672939 File Offset: 0x00670B39
		public float Radius { get; set; }

		// Token: 0x1700C984 RID: 51588
		// (get) Token: 0x0602F36C RID: 193388 RVA: 0x00672942 File Offset: 0x00670B42
		// (set) Token: 0x0602F36D RID: 193389 RVA: 0x0067294A File Offset: 0x00670B4A
		public float Height { get; set; }

		// Token: 0x0602F36E RID: 193390 RVA: 0x00672953 File Offset: 0x00670B53
		public IConeRangeCheckT()
		{
			this.Type = ERangeCheckType.Cone;
			this.CenterOffset = null;
			this.Radius = 0f;
			this.Height = 0f;
		}
	}
}
