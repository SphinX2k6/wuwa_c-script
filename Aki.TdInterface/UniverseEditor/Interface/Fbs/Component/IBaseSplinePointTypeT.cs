using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EF3 RID: 20211
	public class IBaseSplinePointTypeT
	{
		// Token: 0x1700915A RID: 37210
		// (get) Token: 0x0601FE96 RID: 130710 RVA: 0x00471133 File Offset: 0x0046F333
		// (set) Token: 0x0601FE97 RID: 130711 RVA: 0x0047113B File Offset: 0x0046F33B
		public IVectorInfoT Position { get; set; }

		// Token: 0x1700915B RID: 37211
		// (get) Token: 0x0601FE98 RID: 130712 RVA: 0x00471144 File Offset: 0x0046F344
		// (set) Token: 0x0601FE99 RID: 130713 RVA: 0x0047114C File Offset: 0x0046F34C
		public IVectorInfoT ArriveTangent { get; set; }

		// Token: 0x1700915C RID: 37212
		// (get) Token: 0x0601FE9A RID: 130714 RVA: 0x00471155 File Offset: 0x0046F355
		// (set) Token: 0x0601FE9B RID: 130715 RVA: 0x0047115D File Offset: 0x0046F35D
		public IVectorInfoT LeaveTangent { get; set; }

		// Token: 0x1700915D RID: 37213
		// (get) Token: 0x0601FE9C RID: 130716 RVA: 0x00471166 File Offset: 0x0046F366
		// (set) Token: 0x0601FE9D RID: 130717 RVA: 0x0047116E File Offset: 0x0046F36E
		public ESplineLine LineType { get; set; }

		// Token: 0x1700915E RID: 37214
		// (get) Token: 0x0601FE9E RID: 130718 RVA: 0x00471177 File Offset: 0x0046F377
		// (set) Token: 0x0601FE9F RID: 130719 RVA: 0x0047117F File Offset: 0x0046F37F
		public IVectorInfoT Rotation { get; set; }

		// Token: 0x0601FEA0 RID: 130720 RVA: 0x00471188 File Offset: 0x0046F388
		public IBaseSplinePointTypeT()
		{
			this.Position = null;
			this.ArriveTangent = null;
			this.LeaveTangent = null;
			this.LineType = ESplineLine.Linear;
			this.Rotation = null;
		}
	}
}
