using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057B2 RID: 22450
	public class IPullingFoundationTypeT
	{
		// Token: 0x1700A79A RID: 42906
		// (get) Token: 0x06025AE4 RID: 154340 RVA: 0x005328DA File Offset: 0x00530ADA
		// (set) Token: 0x06025AE5 RID: 154341 RVA: 0x005328E2 File Offset: 0x00530AE2
		public EPullingFoundation Type { get; set; }

		// Token: 0x06025AE6 RID: 154342 RVA: 0x005328EB File Offset: 0x00530AEB
		public IPullingFoundationTypeT()
		{
			this.Type = EPullingFoundation.CategoryMatching;
		}
	}
}
