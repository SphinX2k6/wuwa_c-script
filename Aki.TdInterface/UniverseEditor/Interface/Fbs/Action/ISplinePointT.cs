using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200796C RID: 31084
	public class ISplinePointT
	{
		// Token: 0x1700E3F1 RID: 58353
		// (get) Token: 0x06036BEC RID: 224236 RVA: 0x00752E08 File Offset: 0x00751008
		// (set) Token: 0x06036BED RID: 224237 RVA: 0x00752E10 File Offset: 0x00751010
		public string Spline { get; set; }

		// Token: 0x1700E3F2 RID: 58354
		// (get) Token: 0x06036BEE RID: 224238 RVA: 0x00752E19 File Offset: 0x00751019
		// (set) Token: 0x06036BEF RID: 224239 RVA: 0x00752E21 File Offset: 0x00751021
		public List<IVectorInfoT> Points { get; set; }

		// Token: 0x06036BF0 RID: 224240 RVA: 0x00752E2A File Offset: 0x0075102A
		public ISplinePointT()
		{
			this.Spline = null;
			this.Points = null;
		}
	}
}
