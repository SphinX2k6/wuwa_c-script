using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A06 RID: 27142
	public class IClientEnableAllPlayerOperationT
	{
		// Token: 0x1700C79C RID: 51100
		// (get) Token: 0x0602E91D RID: 190749 RVA: 0x0065A0D6 File Offset: 0x006582D6
		// (set) Token: 0x0602E91E RID: 190750 RVA: 0x0065A0DE File Offset: 0x006582DE
		public EPlayerOperationType Type { get; set; }

		// Token: 0x0602E91F RID: 190751 RVA: 0x0065A0E7 File Offset: 0x006582E7
		public IClientEnableAllPlayerOperationT()
		{
			this.Type = EPlayerOperationType.EnableAll;
		}
	}
}
