using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005848 RID: 22600
	public class IFrequencyPaintConfigT
	{
		// Token: 0x1700A3B6 RID: 41910
		// (get) Token: 0x060249DB RID: 149979 RVA: 0x0050813F File Offset: 0x0050633F
		// (set) Token: 0x060249DC RID: 149980 RVA: 0x00508147 File Offset: 0x00506347
		public string EntityState { get; set; }

		// Token: 0x1700A3B7 RID: 41911
		// (get) Token: 0x060249DD RID: 149981 RVA: 0x00508150 File Offset: 0x00506350
		// (set) Token: 0x060249DE RID: 149982 RVA: 0x00508158 File Offset: 0x00506358
		public TFrequencyPaintLineOptionUnion LineType { get; set; }

		// Token: 0x1700A3B8 RID: 41912
		// (get) Token: 0x060249DF RID: 149983 RVA: 0x00508161 File Offset: 0x00506361
		// (set) Token: 0x060249E0 RID: 149984 RVA: 0x00508169 File Offset: 0x00506369
		public List<IActionInfoT> SuccessActions { get; set; }

		// Token: 0x060249E1 RID: 149985 RVA: 0x00508172 File Offset: 0x00506372
		public IFrequencyPaintConfigT()
		{
			this.EntityState = null;
			this.LineType = null;
			this.SuccessActions = null;
		}
	}
}
