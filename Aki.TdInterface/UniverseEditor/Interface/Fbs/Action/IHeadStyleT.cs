using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068CB RID: 26827
	public class IHeadStyleT
	{
		// Token: 0x1700C711 RID: 50961
		// (get) Token: 0x0602ECAC RID: 191660 RVA: 0x00662BE6 File Offset: 0x00660DE6
		// (set) Token: 0x0602ECAD RID: 191661 RVA: 0x00662BEE File Offset: 0x00660DEE
		public EHeadStyle Type { get; set; }

		// Token: 0x0602ECAE RID: 191662 RVA: 0x00662BF7 File Offset: 0x00660DF7
		public IHeadStyleT()
		{
			this.Type = EHeadStyle.Normal;
		}
	}
}
