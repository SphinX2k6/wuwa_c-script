using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007586 RID: 30086
	public class IRangeCheckT
	{
		// Token: 0x1700DD4C RID: 56652
		// (get) Token: 0x06034C72 RID: 216178 RVA: 0x00718DB6 File Offset: 0x00716FB6
		// (set) Token: 0x06034C73 RID: 216179 RVA: 0x00718DBE File Offset: 0x00716FBE
		public ERangeCheckType Type { get; set; }

		// Token: 0x06034C74 RID: 216180 RVA: 0x00718DC7 File Offset: 0x00716FC7
		public IRangeCheckT()
		{
			this.Type = ERangeCheckType.Cone;
		}
	}
}
