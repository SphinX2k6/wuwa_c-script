using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006219 RID: 25113
	public class IBossPilingRandomBuffT
	{
		// Token: 0x1700BB24 RID: 47908
		// (get) Token: 0x0602B49A RID: 177306 RVA: 0x005F644A File Offset: 0x005F464A
		// (set) Token: 0x0602B49B RID: 177307 RVA: 0x005F6452 File Offset: 0x005F4652
		public int BuffPoolId { get; set; }

		// Token: 0x0602B49C RID: 177308 RVA: 0x005F645B File Offset: 0x005F465B
		public IBossPilingRandomBuffT()
		{
			this.BuffPoolId = 0;
		}
	}
}
