using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075A7 RID: 30119
	public class IReignsChangePlayerNameT
	{
		// Token: 0x1700DD7E RID: 56702
		// (get) Token: 0x06034D61 RID: 216417 RVA: 0x0071A631 File Offset: 0x00718831
		// (set) Token: 0x06034D62 RID: 216418 RVA: 0x0071A639 File Offset: 0x00718839
		public string PlayerNameId { get; set; }

		// Token: 0x06034D63 RID: 216419 RVA: 0x0071A642 File Offset: 0x00718842
		public IReignsChangePlayerNameT()
		{
			this.PlayerNameId = null;
		}
	}
}
