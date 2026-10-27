using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B7B RID: 23419
	public class IWindDirectionalT
	{
		// Token: 0x1700B0FF RID: 45311
		// (get) Token: 0x06028173 RID: 164211 RVA: 0x00582E4A File Offset: 0x0058104A
		// (set) Token: 0x06028174 RID: 164212 RVA: 0x00582E52 File Offset: 0x00581052
		public EWindSourceType Type { get; set; }

		// Token: 0x1700B100 RID: 45312
		// (get) Token: 0x06028175 RID: 164213 RVA: 0x00582E5B File Offset: 0x0058105B
		// (set) Token: 0x06028176 RID: 164214 RVA: 0x00582E63 File Offset: 0x00581063
		public IVectorInfoT Rot { get; set; }

		// Token: 0x1700B101 RID: 45313
		// (get) Token: 0x06028177 RID: 164215 RVA: 0x00582E6C File Offset: 0x0058106C
		// (set) Token: 0x06028178 RID: 164216 RVA: 0x00582E74 File Offset: 0x00581074
		public List<IWindDirectionalStateGradeT> Grades { get; set; }

		// Token: 0x06028179 RID: 164217 RVA: 0x00582E7D File Offset: 0x0058107D
		public IWindDirectionalT()
		{
			this.Type = EWindSourceType.Directional;
			this.Rot = null;
			this.Grades = null;
		}
	}
}
