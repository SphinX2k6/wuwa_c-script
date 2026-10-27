using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A1C RID: 18972
	public class ICheckEntityTypeT
	{
		// Token: 0x1700895B RID: 35163
		// (get) Token: 0x0601DB03 RID: 121603 RVA: 0x0042D3EA File Offset: 0x0042B5EA
		// (set) Token: 0x0601DB04 RID: 121604 RVA: 0x0042D3F2 File Offset: 0x0042B5F2
		public ECheckEntity Type { get; set; }

		// Token: 0x0601DB05 RID: 121605 RVA: 0x0042D3FB File Offset: 0x0042B5FB
		public ICheckEntityTypeT()
		{
			this.Type = ECheckEntity.OnlinePlayer;
		}
	}
}
