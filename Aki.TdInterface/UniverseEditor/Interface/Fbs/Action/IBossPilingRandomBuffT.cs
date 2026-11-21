using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200688A RID: 26762
	public class IBossPilingRandomBuffT
	{
		// Token: 0x1700C4AA RID: 50346
		// (get) Token: 0x0602DBF3 RID: 187379 RVA: 0x00641036 File Offset: 0x0063F236
		// (set) Token: 0x0602DBF4 RID: 187380 RVA: 0x0064103E File Offset: 0x0063F23E
		public int BuffPoolId { get; set; }

		// Token: 0x0602DBF5 RID: 187381 RVA: 0x00641047 File Offset: 0x0063F247
		public IBossPilingRandomBuffT()
		{
			this.BuffPoolId = 0;
		}
	}
}
