using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006191 RID: 24977
	public class IWindDirectionalT
	{
		// Token: 0x1700BA47 RID: 47687
		// (get) Token: 0x0602A737 RID: 173879 RVA: 0x005CA8DA File Offset: 0x005C8ADA
		// (set) Token: 0x0602A738 RID: 173880 RVA: 0x005CA8E2 File Offset: 0x005C8AE2
		public EWindSourceType Type { get; set; }

		// Token: 0x1700BA48 RID: 47688
		// (get) Token: 0x0602A739 RID: 173881 RVA: 0x005CA8EB File Offset: 0x005C8AEB
		// (set) Token: 0x0602A73A RID: 173882 RVA: 0x005CA8F3 File Offset: 0x005C8AF3
		public IVectorInfoT Rot { get; set; }

		// Token: 0x1700BA49 RID: 47689
		// (get) Token: 0x0602A73B RID: 173883 RVA: 0x005CA8FC File Offset: 0x005C8AFC
		// (set) Token: 0x0602A73C RID: 173884 RVA: 0x005CA904 File Offset: 0x005C8B04
		public List<IWindDirectionalStateGradeT> Grades { get; set; }

		// Token: 0x0602A73D RID: 173885 RVA: 0x005CA90D File Offset: 0x005C8B0D
		public IWindDirectionalT()
		{
			this.Type = EWindSourceType.Directional;
			this.Rot = null;
			this.Grades = null;
		}
	}
}
