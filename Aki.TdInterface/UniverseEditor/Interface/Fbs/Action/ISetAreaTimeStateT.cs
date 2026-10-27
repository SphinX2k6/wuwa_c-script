using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FAC RID: 28588
	public class ISetAreaTimeStateT
	{
		// Token: 0x1700D44C RID: 54348
		// (get) Token: 0x0603286D RID: 206957 RVA: 0x006D1A91 File Offset: 0x006CFC91
		// (set) Token: 0x0603286E RID: 206958 RVA: 0x006D1A99 File Offset: 0x006CFC99
		public TSetAreaTimeTypeUnion SetAreaTimeConfig { get; set; }

		// Token: 0x0603286F RID: 206959 RVA: 0x006D1AA2 File Offset: 0x006CFCA2
		public ISetAreaTimeStateT()
		{
			this.SetAreaTimeConfig = null;
		}
	}
}
